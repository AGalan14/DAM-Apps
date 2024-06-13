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
import model.Sorteig;

import java.io.IOException;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.time.LocalDate;
import java.util.ArrayList;
import java.util.Collections;
import java.util.Date;

public class SorteigController {
    @FXML
    private ImageView returnMenuBtn;
    @FXML
    private MenuButton triarOpcio;
    @FXML
    private ListView<String> sorteigsActius_list;
    @FXML
    private DatePicker triarData_date;
    @FXML
    private Label dataSorteig_label;
    @FXML
    private ImageView crearSorteigBtn;
    @FXML
    private Label sorteigRealitzar_label;
    @FXML
    private MenuButton sorteigRealitzar_button;
    @FXML
    private ImageView realitzarSorteigBtn;
    @FXML
    private Label consultarSorteigCobrat_label;
    @FXML
    private MenuButton consultarSorteigCobrat_button;
    @FXML
    private Label estadistiquesSorteig_label;
    @FXML
    private MenuButton estadistiquesSorteig_button;
    @FXML
    private Label quantitatApostes_label;
    @FXML
    private Label quantitatApostesPremiades_label;
    @FXML
    private Label quantitatApostesReintegrament_label;

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
        addHoverEffect(crearSorteigBtn);
        addHoverEffect(realitzarSorteigBtn);
    }

    // Canvia el contingut de la finestra per a crear el Sorteig
    @FXML
    private void triarCrearSorteig() {
        triarOpcio.setText("Crear Sorteig");
        crearSorteigBtn.setVisible(true);
        dataSorteig_label.setVisible(true);
        triarData_date.setVisible(true);
        sorteigRealitzar_label.setVisible(false);
        sorteigRealitzar_button.setVisible(false);
        realitzarSorteigBtn.setVisible(false);
        sorteigsActius_list.setVisible(false);
        consultarSorteigCobrat_label.setVisible(false);
        consultarSorteigCobrat_button.setVisible(false);
        estadistiquesSorteig_label.setVisible(false);
        estadistiquesSorteig_button.setVisible(false);
        quantitatApostes_label.setVisible(false);
        quantitatApostesPremiades_label.setVisible(false);
        quantitatApostesReintegrament_label.setVisible(false);
    }

    // Crea un Sorteig si es selecciona una data
    @FXML
    private void crearSorteig() {
        if(triarData_date.getValue() == null) {
            Alert alert = new Alert(Alert.AlertType.ERROR);
            alert.setTitle("Error");
            alert.setHeaderText("Camp buit");
            alert.setContentText("Has de triar una data abans de crear el Sorteig.");
            alert.showAndWait();
        } else if(triarData_date.getValue().isBefore(LocalDate.now())) {
            Alert alert = new Alert(Alert.AlertType.ERROR);
            alert.setTitle("Error");
            alert.setHeaderText("Data incorrecta");
            alert.setContentText("La data ha de ser posterior a l'actual.");
            alert.showAndWait();
        } else {
            Date data = java.sql.Date.valueOf(triarData_date.getValue());
            Sorteig sorteig = new Sorteig(data);
            if(Primitiva.insertarSorteig(sorteig)) {
                Alert alert = new Alert(Alert.AlertType.NONE);
                alert.setTitle("Sorteig creat correctament");
                alert.setContentText("El Sorteig ha set creat");
                ButtonType closeButton = new ButtonType("Ok", ButtonBar.ButtonData.CANCEL_CLOSE);
                alert.getButtonTypes().add(closeButton);
                alert.showAndWait();
            } else {
                Alert alert = new Alert(Alert.AlertType.ERROR);
                alert.setTitle("Error");
                alert.setHeaderText("Data repetida");
                alert.setContentText("Ja existeix un Sorteig amb la data seleccionada.");
                alert.showAndWait();
            }
        }
    }

    // Canvia el contingut de la finestra per a mostrar els Sorteigs actius
    @FXML
    private void triarSorteigsActius() {
        triarOpcio.setText("Consultar Sorteigs Actius");
        crearSorteigBtn.setVisible(false);
        dataSorteig_label.setVisible(false);
        triarData_date.setVisible(false);
        sorteigRealitzar_label.setVisible(false);
        sorteigRealitzar_button.setVisible(false);
        realitzarSorteigBtn.setVisible(false);
        sorteigsActius_list.setVisible(true);
        consultarSorteigCobrat_label.setVisible(false);
        consultarSorteigCobrat_button.setVisible(false);
        estadistiquesSorteig_label.setVisible(false);
        estadistiquesSorteig_button.setVisible(false);
        quantitatApostes_label.setVisible(false);
        quantitatApostesPremiades_label.setVisible(false);
        quantitatApostesReintegrament_label.setVisible(false);

        ArrayList<Sorteig> sorteigsNoRealitzats = Primitiva.sorteigsNoRealitzatsList();
        sorteigsActius_list.getItems().clear();
        sorteigsActius_list.setDisable(false);

        if(sorteigsNoRealitzats.isEmpty()) {
            sorteigsActius_list.getItems().add("No hi han sorteigs actius.");
            sorteigsActius_list.setDisable(true);
        } else {
            Collections.sort(sorteigsNoRealitzats);
            for (Sorteig sorteigsNoRealitzat : sorteigsNoRealitzats) {
                sorteigsActius_list.getItems().add("" + sorteigsNoRealitzat.getDataSorteig());
            }
        }
    }

    // Canvia el contingut de la finestra per a mostrar si un sorteig ha estat cobrat o no
    @FXML
    private void triarSorteigCobrat() {
        triarOpcio.setText("Sorteigs Cobrats S/N");
        crearSorteigBtn.setVisible(false);
        dataSorteig_label.setVisible(false);
        triarData_date.setVisible(false);
        sorteigRealitzar_label.setVisible(false);
        sorteigRealitzar_button.setVisible(false);
        realitzarSorteigBtn.setVisible(false);
        sorteigsActius_list.setVisible(false);
        consultarSorteigCobrat_label.setVisible(true);
        consultarSorteigCobrat_button.setVisible(true);
        estadistiquesSorteig_label.setVisible(false);
        estadistiquesSorteig_button.setVisible(false);
        quantitatApostes_label.setVisible(false);
        quantitatApostesPremiades_label.setVisible(false);
        quantitatApostesReintegrament_label.setVisible(false);

        // Afegeix els sorteigs realitzats
        ArrayList<Sorteig> sorteigsRealitzats = Primitiva.sorteigsRealitzatsList();
        consultarSorteigCobrat_button.setDisable(false);

        if (sorteigsRealitzats.isEmpty()) {
            consultarSorteigCobrat_button.setText("Cap Sorteig disponible");
            consultarSorteigCobrat_button.setDisable(true);
        } else {
            Collections.sort(sorteigsRealitzats);
            consultarSorteigCobrat_button.getItems().clear();
            for (Sorteig sorteigRealitzat : sorteigsRealitzats) {
                MenuItem miTmp = new MenuItem();
                miTmp.setText("" + sorteigRealitzat.getDataSorteig());
                miTmp.setOnAction(_ -> {
                    consultarSorteigCobrat_button.setText(miTmp.getText());

                    SimpleDateFormat sdf = new SimpleDateFormat("yyyy-MM-dd");
                    Date date;
                    try {
                        date = sdf.parse(consultarSorteigCobrat_button.getText());
                    } catch (ParseException ex) {
                        throw new RuntimeException(ex);
                    }
                    int resultat = Primitiva.apostaPremiadaQuedaPerCobrarByData(new java.sql.Date(date.getTime()));
                    Alert alert = new Alert(Alert.AlertType.NONE);
                    alert.setTitle("Sorteig " + consultarSorteigCobrat_button.getText());
                    if (resultat < 1) alert.setContentText("No queda cap participant per a cobrar l'Aposta.");
                    else alert.setContentText("Queden " + resultat + " participants per a cobrar l'Aposta.");
                    ButtonType closeButton = new ButtonType("Ok", ButtonBar.ButtonData.CANCEL_CLOSE);
                    alert.getButtonTypes().add(closeButton);
                    alert.showAndWait();
                    consultarSorteigCobrat_button.setText("Sorteigs...");
                });
                consultarSorteigCobrat_button.getItems().add(miTmp);
            }
        }
    }

    // Canvia el contingut de la finestra per a marcar un Sorteig com realitzat
    @FXML
    private void triarRealitzarSorteig() {
        triarOpcio.setText("Realitzar Sorteig");
        crearSorteigBtn.setVisible(false);
        dataSorteig_label.setVisible(false);
        triarData_date.setVisible(false);
        sorteigRealitzar_label.setVisible(true);
        sorteigRealitzar_button.setVisible(true);
        realitzarSorteigBtn.setVisible(true);
        sorteigsActius_list.setVisible(false);
        consultarSorteigCobrat_label.setVisible(false);
        consultarSorteigCobrat_button.setVisible(false);
        estadistiquesSorteig_label.setVisible(false);
        estadistiquesSorteig_button.setVisible(false);
        quantitatApostes_label.setVisible(false);
        quantitatApostesPremiades_label.setVisible(false);
        quantitatApostesReintegrament_label.setVisible(false);

        // Afegeix els Sorteigs no realitzats a la llista
        ArrayList<Sorteig> sorteigsNoRealitzats = Primitiva.sorteigsNoRealitzatsList();
        sorteigRealitzar_button.setDisable(false);

        if(sorteigsNoRealitzats.isEmpty()) {
            sorteigRealitzar_button.setText("Cap Sorteig disponible");
            sorteigRealitzar_button.setDisable(true);
        }
        else {
            Collections.sort(sorteigsNoRealitzats);
            sorteigRealitzar_button.getItems().clear();
            for (Sorteig sorteigNoRealitzat : sorteigsNoRealitzats) {
                MenuItem miTmp = new MenuItem();
                miTmp.setText("" + sorteigNoRealitzat.getDataSorteig());
                miTmp.setOnAction(_ -> sorteigRealitzar_button.setText(miTmp.getText()));
                sorteigRealitzar_button.getItems().add(miTmp);
            }
        }
    }

    // Realitza el Sorteig
    @FXML
    private void realitzarSorteig() throws ParseException {
        if (sorteigRealitzar_button.getText().equals("Cap Sorteig disponible")) {
            Alert alert = new Alert(Alert.AlertType.ERROR);
            alert.setTitle("Error");
            alert.setHeaderText("Cap Sorteig disponible");
            alert.setContentText("No has seleccionat cap Sorteig. No hi ha cap disponible.");
            alert.showAndWait();
        } else {
            SimpleDateFormat sdf = new SimpleDateFormat("yyyy-MM-dd");
            Date date = sdf.parse(sorteigRealitzar_button.getText());
            java.sql.Date sqlDate = new java.sql.Date(date.getTime());
            if (Primitiva.realitzarSorteig(sqlDate)){
                sorteigRealitzar_button.setText("Sorteig...");
                for (int i = 0; i < sorteigRealitzar_button.getItems().size(); i++) {
                    if (sorteigRealitzar_button.getItems().get(i).getText().equals("" + sqlDate)) {
                        sorteigRealitzar_button.getItems().remove(i);
                    }
                }
                Alert alert = new Alert(Alert.AlertType.NONE);
                alert.setTitle("Sorteig realitzat");
                alert.setContentText("El Sorteig s'ha realitzat correctament.");
                ButtonType closeButton = new ButtonType("Ok", ButtonBar.ButtonData.CANCEL_CLOSE);
                alert.getButtonTypes().add(closeButton);
                alert.showAndWait();
            } else {
                Alert alert = new Alert(Alert.AlertType.ERROR);
                alert.setTitle("Error");
                alert.setContentText("Ha hagut un problema al realitzar el Sorteig. Si us plau, revisa les dades.");
                alert.showAndWait();
            }
        }
    }

    // Canvia el contingut de la finestra per a mostrar les estadístiques d'un Sorteig
    @FXML
    private void triarEstadistiques() {
        triarOpcio.setText("Consultar Estadístiques");
        crearSorteigBtn.setVisible(false);
        dataSorteig_label.setVisible(false);
        triarData_date.setVisible(false);
        sorteigRealitzar_label.setVisible(false);
        sorteigRealitzar_button.setVisible(false);
        realitzarSorteigBtn.setVisible(false);
        sorteigsActius_list.setVisible(false);
        consultarSorteigCobrat_label.setVisible(false);
        consultarSorteigCobrat_button.setVisible(false);
        estadistiquesSorteig_label.setVisible(true);
        estadistiquesSorteig_button.setVisible(true);

        // Afegeix tots els Sorteigs a la llista
        ArrayList<Sorteig> sorteigs = Primitiva.sorteigsList();
        estadistiquesSorteig_button.setDisable(false);

        if(sorteigs.isEmpty()) {
            estadistiquesSorteig_button.setText("Cap Sorteig disponible");
            estadistiquesSorteig_button.setDisable(true);
        } else {
            Collections.sort(sorteigs);
            estadistiquesSorteig_button.getItems().clear();
            for (Sorteig sorteig : sorteigs) {
                MenuItem miTmp = new MenuItem();
                miTmp.setText("" + sorteig.getDataSorteig());
                miTmp.setOnAction(_ -> {
                    estadistiquesSorteig_button.setText(miTmp.getText());

                    SimpleDateFormat sdf = new SimpleDateFormat("yyyy-MM-dd");
                    Date date;
                    try {
                        date = sdf.parse(estadistiquesSorteig_button.getText());
                    } catch (ParseException pe) {
                        throw new RuntimeException(pe);
                    }
                    java.sql.Date sqlDate = new java.sql.Date(date.getTime());
                    quantitatApostes_label.setText("Quantitat d'Apostes: " + Primitiva.quantitatApostes(sqlDate));
                    quantitatApostesPremiades_label.setText("Quantitat d'Apostes Premiades: " + Primitiva.quantitatPremiades(sqlDate));
                    quantitatApostesReintegrament_label.setText("Quantitat d'Apostes amb Reintegrament: " + Primitiva.apostesReintegrament(sqlDate));
                    quantitatApostes_label.setVisible(true);
                    quantitatApostesPremiades_label.setVisible(true);
                    quantitatApostesReintegrament_label.setVisible(true);
                });
                estadistiquesSorteig_button.getItems().add(miTmp);
            }
        }
    }
}