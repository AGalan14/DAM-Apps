package view;

import controller.Primitiva;
import javafx.event.Event;
import javafx.fxml.FXML;
import javafx.fxml.FXMLLoader;
import javafx.scene.Node;
import javafx.scene.Parent;
import javafx.scene.Scene;
import javafx.scene.control.*;
import javafx.scene.image.Image;
import javafx.scene.image.ImageView;
import javafx.stage.Stage;
import model.Aposta;
import model.Sorteig;

import java.io.IOException;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Collections;
import java.util.Date;

public class ResultatController {
    @FXML
    private ImageView returnMenuBtn;
    @FXML
    private MenuButton triarAccio;
    @FXML
    private ImageView consultarApostaBtn;
    @FXML
    private ImageView cobrarApostaBtn;
    @FXML
    private Label sorteigs_label;
    @FXML
    private MenuButton sorteigs_button;
    @FXML
    private Label idAposta_label;
    @FXML
    private MenuButton idAposta_button;
    @FXML
    private Label resultatConsulta_label;
    @FXML
    private Date dataSorteig;

    @FXML
    public void addHoverEffect(ImageView imageView) {
        double scaleFactor = 1.2;  // Incrementa les imatges
        imageView.setOnMouseEntered(_ -> {
            imageView.setScaleX(imageView.getScaleX() * scaleFactor);
            imageView.setScaleY(imageView.getScaleY() * scaleFactor);
        });
        imageView.setOnMouseExited(_ -> {
            imageView.setScaleX(imageView.getScaleX() / scaleFactor);
            imageView.setScaleY(imageView.getScaleY() / scaleFactor);
        });
    }

    // Tanca la finestra actual i torna al menú
    @FXML
    private void tornarMenu(Event event) throws IOException {
        Node node = (Node) event.getSource();
        Stage stage = (Stage) node.getScene().getWindow();
        stage.close();

        FXMLLoader fxmlLoader = new FXMLLoader(PrimitivaApplication.class.getResource("/primitiva-menu.fxml"));
        Parent root = fxmlLoader.load();
        Scene scene = new Scene(root);
        stage.setTitle("Primitiva [AGalan]");
        Image icon = new Image("primitiva_icon.png");
        stage.getIcons().add(icon);
        stage.setResizable(false);
        stage.setScene(scene);
        stage.show();
    }

    @FXML
    private void initialize() {
        // Afegeix un efecte al pasar el ratolí per un botó
        addHoverEffect(returnMenuBtn);
        addHoverEffect(consultarApostaBtn);
        addHoverEffect(cobrarApostaBtn);
    }

    // Canvia el contingut de la finestra per a Consultar una Aposta
    @FXML
    private void triarConsultarAposta() {
        triarAccio.setText("Consultar Aposta");
        consultarApostaBtn.setVisible(true);
        sorteigs_label.setVisible(true);
        sorteigs_button.setVisible(true);
        idAposta_label.setVisible(true);
        idAposta_button.setVisible(true);
        cobrarApostaBtn.setVisible(false);

        ArrayList<Sorteig> sorteigsRealitzats = Primitiva.sorteigsRealitzatsList();
        sorteigs_button.getItems().clear();
        sorteigs_button.setDisable(false);

        if(sorteigsRealitzats.isEmpty()) {
            sorteigs_button.setText("Cap Sorteig disponible");
            sorteigs_button.setDisable(true);
        } else {
            Collections.sort(sorteigsRealitzats);
            for (Sorteig sorteigRealitzat : sorteigsRealitzats) {
                MenuItem miTmp = new MenuItem();
                miTmp.setText("" + sorteigRealitzat.getDataSorteig());
                miTmp.setOnAction(_ -> {
                    sorteigs_button.setText(miTmp.getText());
                    SimpleDateFormat sdf = new SimpleDateFormat("yyyy-MM-dd");
                    try {
                        dataSorteig = sdf.parse(sorteigs_button.getText());
                    } catch (ParseException e) {
                        throw new RuntimeException(e);
                    }
                    selectIdAposta();
                });
                sorteigs_button.getItems().add(miTmp);
            }
        }
    }

    @FXML
    private void selectIdAposta() {
        // Afegeix els sorteigs realitzats
        java.sql.Date sqlDate = new java.sql.Date(dataSorteig.getTime());
        ArrayList<Integer> apostes = Primitiva.apostesFromSorteig(sqlDate);
        idAposta_button.getItems().clear();
        idAposta_button.setDisable(false);

        if(apostes.isEmpty()) {
            idAposta_button.setText("No té Apostes");
            idAposta_button.setDisable(true);
        } else {
            idAposta_button.setText("IDs...");
            Collections.sort(apostes);
            for (Integer apostaID : apostes) {
                MenuItem miTmp = new MenuItem();
                miTmp.setText("" + apostaID);
                miTmp.setOnAction(_ -> idAposta_button.setText(miTmp.getText()));
                idAposta_button.getItems().add(miTmp);
            }
        }
    }

    // Canvia el contingut de la finestra per a Cobrar una Aposta
    @FXML
    private void triarCobrarAposta() {
        triarAccio.setText("Cobrar Aposta");
        consultarApostaBtn.setVisible(false);
        sorteigs_label.setVisible(true);
        sorteigs_button.setVisible(true);
        idAposta_label.setVisible(true);
        idAposta_button.setVisible(true);
        cobrarApostaBtn.setVisible(true);

        ArrayList<Sorteig> sorteigsRealitzats = Primitiva.sorteigsRealitzatsList();
        sorteigs_button.getItems().clear();
        sorteigs_button.setDisable(false);

        if(sorteigsRealitzats.isEmpty()) {
            sorteigs_button.setText("Cap Sorteig disponible");
            sorteigs_button.setDisable(true);
        } else {
            Collections.sort(sorteigsRealitzats);
            for (Sorteig sorteigRealitzat : sorteigsRealitzats) {
                MenuItem miTmp = new MenuItem();
                miTmp.setText("" + sorteigRealitzat.getDataSorteig());
                miTmp.setOnAction(_ -> {
                    sorteigs_button.setText(miTmp.getText());
                    SimpleDateFormat sdf = new SimpleDateFormat("yyyy-MM-dd");
                    try {
                        dataSorteig = sdf.parse(sorteigs_button.getText());
                    } catch (ParseException e) {
                        throw new RuntimeException(e);
                    }
                    selectIdAposta();
                });
                sorteigs_button.getItems().add(miTmp);
            }
        }
    }

    // Consulta si l'Aposta té premi o no
    @FXML
    private void consultarPremiat() throws ParseException {
        try {
            if(sorteigs_button.getText().equals("Sorteigs...")) {
                Alert alert = new Alert(Alert.AlertType.ERROR);
                alert.setTitle("Error");
                alert.setHeaderText("Sense selecció");
                alert.setContentText("Selecciona un Sorteig abans de consultar si té premi o no.");
                alert.showAndWait();
            } else if(idAposta_button.getText().equals("IDs...")) {
                Alert alert = new Alert(Alert.AlertType.ERROR);
                alert.setTitle("Error");
                alert.setHeaderText("Sense selecció");
                alert.setContentText("Selecciona una ID d'Aposta abans de consultar si té premi o no.");
                alert.showAndWait();
            } else {
                SimpleDateFormat sdf = new SimpleDateFormat("yyyy-MM-dd");
                Aposta aposta = new Aposta(Primitiva.getCombinacioFromDB(sdf.parse(sorteigs_button.getText()), Integer.parseInt(idAposta_button.getText())), Integer.parseInt(idAposta_button.getText()));
                if(Primitiva.comprobarPremiat(aposta.getIdAposta(), sdf.parse(sorteigs_button.getText()))) {
                    resultatConsulta_label.setText("Resultat: " + Primitiva.premiDonat(aposta, new java.sql.Date(sdf.parse(sorteigs_button.getText()).getTime())));
                } else resultatConsulta_label.setText("Resultat: L'Aposta no està premiada.");
                resultatConsulta_label.setVisible(true);
            }
        } catch (NumberFormatException nfe){
            Alert alert = new Alert(Alert.AlertType.ERROR);
            alert.setTitle("Error");
            alert.setHeaderText("No es pot consultar");
            alert.setContentText("Ha hagut un error al consultar si l'Aposta està premiada. Comprova que els camps siguin correctes.");
            alert.showAndWait();
        }
    }

    // Cobra l'Aposta d'un Sorteig realitzat
    @FXML
    private void cobrarAposta() throws ParseException {
        SimpleDateFormat sdf = new SimpleDateFormat("yyyy-MM-dd");
        if(sorteigs_button.getText().equals("Sorteigs...")) {
            Alert alert = new Alert(Alert.AlertType.ERROR);
            alert.setTitle("Error");
            alert.setHeaderText("Sense selecció");
            alert.setContentText("Selecciona un Sorteig abans de cobrar l'Aposta.");
            alert.showAndWait();
        } else if(idAposta_button.getText().equals("IDs...")) {
            Alert alert = new Alert(Alert.AlertType.ERROR);
            alert.setTitle("Error");
            alert.setHeaderText("Sense selecció");
            alert.setContentText("Selecciona una ID d'Aposta abans de cobrarla.");
            alert.showAndWait();
        } else if (Primitiva.estaCobrada(Integer.parseInt(idAposta_button.getText()),new java.sql.Date(sdf.parse(sorteigs_button.getText()).getTime()))) {
            Alert alert = new Alert(Alert.AlertType.ERROR);
            alert.setTitle("Error");
            alert.setHeaderText("L'aposta ja ha set cobrada");
            alert.setContentText("Aquesta aposta ja s'ha cobrat anteriorment.");
            alert.showAndWait();
        } else if(!(Primitiva.comprobarPremiat(Integer.parseInt(idAposta_button.getText()), sdf.parse(sorteigs_button.getText())))) {
            Alert alert = new Alert(Alert.AlertType.ERROR);
            alert.setTitle("Error");
            alert.setHeaderText("L'Aposta no té cap premi");
            alert.setContentText("Aquesta aposta no ha set premiada.");
            alert.showAndWait();
        } else {
            if (Primitiva.cobrarAposta(Integer.parseInt(idAposta_button.getText()),new java.sql.Date(sdf.parse(sorteigs_button.getText()).getTime()))) {
                Alert alert = new Alert(Alert.AlertType.NONE);
                alert.setTitle("Aposta cobrada");
                alert.setContentText("L'Aposta amb ID: " + Integer.parseInt(idAposta_button.getText()) + " s'ha cobrat correctament.");
                ButtonType closeButton = new ButtonType("Tancar", ButtonBar.ButtonData.CANCEL_CLOSE);
                alert.getButtonTypes().add(closeButton);
                alert.showAndWait();
            } else {
                Alert alert = new Alert(Alert.AlertType.ERROR);
                alert.setTitle("Error");
                alert.setHeaderText("Aposta no cobrada");
                alert.setContentText("Ha hagut un error al cobrar l'Aposta. Si us plau, revisa les dades.");
                alert.showAndWait();
            }
        }
    }
}