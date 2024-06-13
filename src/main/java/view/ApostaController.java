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
import javafx.util.converter.IntegerStringConverter;
import model.Aposta;
import model.Combinacio;
import model.Sorteig;

import java.io.IOException;
import java.sql.Date;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Collections;

public class ApostaController {
    @FXML
    private ImageView returnMenuBtn;
    @FXML
    private ImageView afegirApostaBtn;
    @FXML
    private MenuButton triarData;
    @FXML
    private MenuButton triarTipus;
    @FXML
    private Label combinacio_label;
    @FXML
    private TextField combinacio_textfield;
    @FXML
    private Button generarCombinacio_button;
    @FXML
    private Label reintegrament_label;
    @FXML
    private TextField reintegrament_textfield;
    @FXML
    private CheckBox reintegrament_checkbox;
    @FXML
    private Label sorteigAnterior_label;
    @FXML
    private MenuButton sorteigAnterior_button;
    @FXML
    private Label idAposta_label;
    @FXML
    private MenuButton idAposta_button;
    @FXML
    private Label emptySorteigs_label;

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
        addHoverEffect(afegirApostaBtn);

        // Afegeig les dates dels sorteigs no realitzats i actius als menuButtons
        ArrayList<Sorteig> sorteigsNoRealitzats = Primitiva.sorteigsNoRealitzatsList();

        if(sorteigsNoRealitzats.isEmpty()) {
            triarData.setDisable(true);
            triarTipus.setDisable(true);
            emptySorteigs_label.setVisible(true);
        }
        else {
            Collections.sort(sorteigsNoRealitzats);
            triarData.getItems().clear();
            for (Sorteig sorteigsNoRealitzat : sorteigsNoRealitzats) {
                MenuItem menuItem = new MenuItem();
                menuItem.setText("" + sorteigsNoRealitzat.getDataSorteig());
                menuItem.setOnAction(_ -> triarData.setText(menuItem.getText()));
                triarData.getItems().add(menuItem);
            }
        }

        // Comprova que sol es puguin escriure números del 0 al 9 en el text field de Reintegrament
        TextFormatter<Integer> textFormatterR = new TextFormatter<>(
                new IntegerStringConverter(),
                null,
                change -> {
                    String newText = change.getControlNewText();
                    if(newText.matches("[0-9]") || newText.isEmpty()) return change;
                    return null;
                }
        );
        reintegrament_textfield.setTextFormatter(textFormatterR);
    }

    public void showSorteigSelectionAlert() {
        Alert alert = new Alert(Alert.AlertType.NONE);
        alert.setTitle("Sorteig");
        alert.setContentText("Selecciona un dels Sorteigs");
        ButtonType closeButton = new ButtonType("Cancelar", ButtonBar.ButtonData.CANCEL_CLOSE);
        alert.getButtonTypes().add(closeButton);
        alert.showAndWait();
    }

    @FXML
    private void triarCombinacioAleatoria() {
        // Comprova que s'ha triat una data de Sorteig on afegir l'Aposta
        if (triarData.getText().equals("Tria una data")) showSorteigSelectionAlert();
        else {
            // Canvia el tipus d'Aposta a Aleatòria si s'ha triat una data
            triarTipus.setText("Combinació Aleatòria");
            sorteigAnterior_label.setVisible(false);
            idAposta_label.setVisible(false);
            sorteigAnterior_button.setVisible(false);
            idAposta_button.setVisible(false);
            generarCombinacio_button.setVisible(true);
            combinacio_label.setVisible(true);
            reintegrament_label.setVisible(true);
            combinacio_textfield.setVisible(true);
            reintegrament_textfield.setVisible(true);
            combinacio_textfield.setEditable(false);
            reintegrament_textfield.setEditable(false);
            reintegrament_checkbox.setVisible(true);
            generarCombinacioAleatoria();
        }
    }

    @FXML
    private void triarCombinacioCopia() {
        // Comprova que s'ha triat una data de Sorteig on afegir l'Aposta
        if (triarData.getText().equals("Tria una data")) showSorteigSelectionAlert();
        else {
            // Canvia el tipus d'Aposta a Còpia si s'ha triat una data
            triarTipus.setText("Combinació Còpia");
            sorteigAnterior_label.setVisible(true);
            idAposta_label.setVisible(true);
            sorteigAnterior_button.setVisible(true);
            idAposta_button.setVisible(true);
            generarCombinacio_button.setVisible(false);
            combinacio_label.setVisible(false);
            reintegrament_label.setVisible(false);
            combinacio_textfield.setText("");
            reintegrament_textfield.setText("");
            combinacio_textfield.setVisible(false);
            reintegrament_textfield.setVisible(false);
            combinacio_textfield.setEditable(false);
            reintegrament_textfield.setEditable(false);
            reintegrament_checkbox.setVisible(false);

            // Ordena i mostra les dates dels Sorteigs realitzats el dia present 
            ArrayList<Sorteig> tmp = Primitiva.sorteigsList();

            if (tmp.isEmpty()) sorteigAnterior_button.setText("No disponible");
            else {
                Collections.sort(tmp);
                sorteigAnterior_button.getItems().clear();
                for (Sorteig sorteig : tmp) {
                    MenuItem miTmp = new MenuItem();
                    miTmp.setText("" + sorteig.getDataSorteig());
                    miTmp.setOnAction(_ -> {
                        sorteigAnterior_button.setText(miTmp.getText());
                        try {
                            addIDCopia();
                        } catch (ParseException e) {
                            throw new RuntimeException(e);
                        }
                    });
                    sorteigAnterior_button.getItems().add(miTmp);
                }
            }
        }
    }

    @FXML
    private void triarCombinacio6Enters() {
        // Comprova que s'ha triat una data de Sorteig on afegir l'Aposta
        if (triarData.getText().equals("Tria una data")) showSorteigSelectionAlert();
        else {
            //Si te una data elegida, configura tot per a que l'aposta sigui "Personal"
            triarTipus.setText("Combinació de 6 enters");
            sorteigAnterior_label.setVisible(false);
            idAposta_label.setVisible(false);
            sorteigAnterior_button.setVisible(false);
            idAposta_button.setVisible(false);
            generarCombinacio_button.setVisible(false);
            combinacio_label.setVisible(true);
            reintegrament_label.setVisible(true);
            combinacio_textfield.setText("");
            reintegrament_textfield.setText("");
            combinacio_textfield.setVisible(true);
            reintegrament_textfield.setVisible(true);
            combinacio_textfield.setEditable(true);
            reintegrament_textfield.setEditable(true);
            reintegrament_checkbox.setVisible(true);
        }
    }

    // Estableix si s'utilitza Reintegrament o no
    @FXML
    private void reintegramentChecked() {
        if(!reintegrament_checkbox.isSelected()) {
            reintegrament_textfield.setText("-1");
            reintegrament_textfield.setDisable(true);
        } else {
            reintegrament_textfield.setDisable(false);
            reintegrament_textfield.setText("");
        }
    }

    // Genera una combinació Aleatòria per canviar l'actual
    @FXML
    private void generarCombinacioAleatoria() {
        Combinacio combinacio = new Combinacio();
        combinacio_textfield.setText(combinacio.combinacioToString());
        if(reintegrament_checkbox.isSelected()) reintegrament_textfield.setText("" + combinacio.getReintegrament());
    }

    @FXML
    private void addIDCopia() throws ParseException {
        // Ordena i mostra les dates dels Sorteigs realitzats el dia present
        SimpleDateFormat sdf = new SimpleDateFormat("yyyy-MM-dd");
        java.util.Date date = sdf.parse(sorteigAnterior_button.getText());
        java.sql.Date sqlDate = new java.sql.Date(date.getTime());
        ArrayList<Integer> apostes = Primitiva.apostesFromSorteig(sqlDate);
        idAposta_button.setDisable(false);

        if (apostes.isEmpty()) {
            idAposta_button.setText("Sense Apostes");
            idAposta_button.setDisable(true);
        }
        else {
            Collections.sort(apostes);
            idAposta_button.getItems().clear();
            for (Integer apostaID : apostes) {
                MenuItem miTmp = new MenuItem();
                miTmp.setText("" + apostaID);
                miTmp.setOnAction(_ -> idAposta_button.setText(miTmp.getText()));
                idAposta_button.getItems().add(miTmp);
            }
        }
    }

    @FXML
    private void afegirAposta() throws ParseException {
        // Mostra alertes d'error segons el problema o el que falti seleccionar
        if(emptySorteigs_label.isVisible()) {
            Alert alert = new Alert(Alert.AlertType.NONE);
            alert.setTitle("Error");
            alert.setHeaderText("Cap Sorteig disponible");
            alert.setContentText("No hi han sorteigs disponibles. Crea un de nou primer.");
            ButtonType closeButton = new ButtonType("Ok", ButtonBar.ButtonData.CANCEL_CLOSE);
            alert.getButtonTypes().add(closeButton);
            alert.showAndWait();
        } else if(triarData.getText().equals("Tria una data")) {
            Alert alert = new Alert(Alert.AlertType.NONE);
            alert.setTitle("Error");
            alert.setHeaderText("Cap Sorteig seleccionat");
            alert.setContentText("Si us plau, selecciona un dels sorteigs disponibles");
            ButtonType closeButton = new ButtonType("Ok", ButtonBar.ButtonData.CANCEL_CLOSE);
            alert.getButtonTypes().add(closeButton);
            alert.showAndWait();
        } else if(triarTipus.getText().equals("Tria un tipus")) {
            Alert alert = new Alert(Alert.AlertType.ERROR);
            alert.setTitle("Error");
            alert.setHeaderText("Cap tipus de Combinació seleccionat");
            alert.setContentText("Si us plau, selecciona un tipus de Combinació.");
            alert.showAndWait();
        } else if(triarTipus.getText().equals("Combinació Còpia") && (idAposta_button.getText().isEmpty() || sorteigAnterior_button.getText().equals("Sorteigs existents..."))) {
            Alert alert = new Alert(Alert.AlertType.ERROR);
            alert.setTitle("Error");
            alert.setHeaderText("Falten camps");
            alert.setContentText("Emplena els camps corresponents abans d'afegir l'Aposta.");
            alert.showAndWait();
        } else {
            String tipus = triarTipus.getText();
            Aposta aposta;
            Combinacio combinacio;
            SimpleDateFormat sdf = new SimpleDateFormat("yyyy-MM-dd");

            // Afegeix l'Aposta dels tipus que no siguin de còpia
            if(!(tipus.equals("Combinació Còpia"))) {
                int reintegrament = -2;
                int[] num = new int[6];
                String[] tmp = combinacio_textfield.getText().split(" ");
                try {
                    for (int i = 0; i < num.length; i++) {
                        num[i] = Integer.parseInt(tmp[i]);
                    }
                } catch (NumberFormatException nfe) {
                    Alert alert = new Alert(Alert.AlertType.ERROR);
                    alert.setTitle("Error");
                    alert.setHeaderText("Aposta no afegida");
                    alert.setContentText("Introdueix sol números");
                    alert.showAndWait();
                } catch (ArrayIndexOutOfBoundsException aioobe){
                    Alert alert = new Alert(Alert.AlertType.ERROR);
                    alert.setTitle("Error");
                    alert.setHeaderText("Aposta no afegida");
                    alert.setContentText("Segueix el format de l'exemple");
                    alert.showAndWait();
                }
                if(reintegrament_checkbox.isSelected()) {
                    try {
                        reintegrament = Integer.parseInt(reintegrament_textfield.getText());
                    } catch (NumberFormatException nfe){
                        Alert alert = new Alert(Alert.AlertType.ERROR);
                        alert.setTitle("Error");
                        alert.setHeaderText("Aposta no afegida");
                        alert.setContentText("Si us plau, des-selecciona la casella del Reintegrament o afegeix un número de Reintegrament.");
                        alert.showAndWait();
                    }
                } else reintegrament = -1;
                combinacio = new Combinacio(num, reintegrament);
                // Si és còpia
            } else {
                if(idAposta_button.getText().equals("IDs...")) {
                    Alert alert = new Alert(Alert.AlertType.ERROR);
                    alert.setTitle("Error");
                    alert.setHeaderText("Aposta no afegida");
                    alert.setContentText("Has d'afegir una ID d'Aposta primer.");
                    alert.showAndWait();
                }
                combinacio = Primitiva.getCombinacioFromDB(sdf.parse(sorteigAnterior_button.getText()), Integer.parseInt(idAposta_button.getText()));
            }
            if (combinacio == null) {
                Alert alert = new Alert(Alert.AlertType.ERROR);
                alert.setTitle("Error");
                alert.setHeaderText("Aposta no afegida");
                alert.setContentText("Aquesta ID amb aquesta data no existeix, comprova les dades si us plau.");
                alert.showAndWait();
            } else {
                //Afegir l'aposta a la base de dades
                aposta = new Aposta(combinacio, -1);

                //Aqui entra si consegueix afegir l'aposta
                if (Primitiva.afegirAposta(aposta, sdf.parse(triarData.getText()))) {
                    Alert alert = new Alert(Alert.AlertType.NONE);
                    alert.setTitle("L'Aposta ha set afegida correctament");

                    String apostaAfegidaString = "ID Aposta: " + aposta.getIdAposta() + "\nData del Sorteig: " + triarData.getText() + "\nCombinació: " + combinacio.combinacioToString();
                    if (combinacio.getReintegrament() == -1) apostaAfegidaString += "\nReintegrament: " + combinacio.getReintegrament();
                    alert.setContentText(apostaAfegidaString);

                    ButtonType closeButton = new ButtonType("Ok", ButtonBar.ButtonData.CANCEL_CLOSE);
                    alert.getButtonTypes().add(closeButton);
                    alert.showAndWait();
                } else {
                    Alert alert = new Alert(Alert.AlertType.ERROR);
                    alert.setTitle("Error");
                    alert.setHeaderText("Aposta no afegida");
                    alert.setContentText("L'Aposta no s'ha afegit.");
                    alert.showAndWait();
                }
            }
        }
    }
}
