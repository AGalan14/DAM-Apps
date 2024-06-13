package view;

import controller.Primitiva;
import javafx.event.Event;
import javafx.fxml.FXML;
import javafx.fxml.FXMLLoader;
import javafx.scene.Node;
import javafx.scene.Parent;
import javafx.scene.Scene;
import javafx.scene.image.Image;
import javafx.scene.image.ImageView;
import javafx.stage.Modality;
import javafx.stage.Stage;
import model.Sorteig;

import java.io.IOException;
import java.util.ArrayList;
import java.util.Date;

public class PrimitivaController {
    @FXML
    public ImageView gestionarSorteigsBtn;
    @FXML
    public ImageView afegirApostaBtn;
    @FXML
    public ImageView resultatsApostesBtn;

    @FXML
    public void initialize() {
        // Afegeix un efecte al pasar el ratolí per un botó
        addHoverEffect(gestionarSorteigsBtn);
        addHoverEffect(afegirApostaBtn);
        addHoverEffect(resultatsApostesBtn);

        // Comproba els Sorteigs actius que ja s'han realitzat i el realitza.
        ArrayList<Sorteig> tmp = Primitiva.sorteigsNoRealitzatsList();
        for (Sorteig sorteig : tmp) {
            if (sorteig.getDataSorteig().before(new Date())) {
                Primitiva.realitzarSorteig(new java.sql.Date(sorteig.getDataSorteig().getTime()));
            }
        }
    }

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

    @FXML
    public void sorteigsClick(Event event) {
        try {
            Node node = (Node) event.getSource();
            Stage stage = (Stage) node.getScene().getWindow();
            stage.close();

            FXMLLoader fxmlLoader = new FXMLLoader(PrimitivaApplication.class.getResource("/primitiva-sorteig.fxml"));
            Parent root = fxmlLoader.load();
            Scene scene = new Scene(root);
            stage = new Stage();
            stage.initModality(Modality.APPLICATION_MODAL);
            stage.setTitle("Primitiva [AGalan] - Gestionar Sorteigs");
            Image icon = new Image("primitiva_icon.png");
            stage.getIcons().add(icon);
            stage.setResizable(false);
            stage.setScene(scene);
            stage.showAndWait();
        } catch (IOException e) {
            throw new RuntimeException(e);
        }
    }

    @FXML
    public void apostaClick(Event event) {
        try {
            Node node = (Node) event.getSource();
            Stage stage = (Stage) node.getScene().getWindow();
            stage.close();

            FXMLLoader fxmlLoader = new FXMLLoader(PrimitivaApplication.class.getResource("/primitiva-aposta.fxml"));
            Parent root = fxmlLoader.load();
            Scene scene = new Scene(root);
            stage = new Stage();
            stage.initModality(Modality.APPLICATION_MODAL);
            stage.setTitle("Primitiva [AGalan] - Afegir Aposta");
            Image icon = new Image("primitiva_icon.png");
            stage.getIcons().add(icon);
            stage.setResizable(false);
            stage.setScene(scene);
            stage.showAndWait();
        } catch (IOException e) {
            throw new RuntimeException(e);
        }
    }

    @FXML
    public void resultatClick(Event event) {
        try {
            Node node = (Node) event.getSource();
            Stage stage = (Stage) node.getScene().getWindow();
            stage.close();

            FXMLLoader fxmlLoader = new FXMLLoader(PrimitivaApplication.class.getResource("/primitiva-resultat.fxml"));
            Parent root = fxmlLoader.load();
            Scene scene = new Scene(root);
            stage = new Stage();
            stage.initModality(Modality.APPLICATION_MODAL);
            stage.setTitle("Primitiva [AGalan] - Resultats Apostes");
            Image icon = new Image("primitiva_icon.png");
            stage.getIcons().add(icon);
            stage.setResizable(false);
            stage.setScene(scene);
            stage.showAndWait();
        } catch (IOException e) {
            throw new RuntimeException(e);
        }
    }
}