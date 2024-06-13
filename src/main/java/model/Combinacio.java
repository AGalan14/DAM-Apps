package model;

import javafx.scene.control.Alert;

import java.util.Random;

public class Combinacio {
    private int[] combinacio;
    int reintegrament;

    // Crea una Combinació a partir de 6 nombres enters
    public Combinacio(int[] combinacio, int reintegrament) {
        try {
            if(combinacio.length != 6) throw new IllegalArgumentException("La Combinació ha d'estar formada per 6 digits.");
            else {
                for(int num : combinacio) {
                    if(num < 1 || num > 49) {
                        throw new IllegalArgumentException("La Combinació ha d'estar formada per números de l'1 al 49.");
                    }
                }
            }

            this.combinacio = new int[6];
            System.arraycopy(combinacio, 0, this.combinacio, 0, 6);
            sortNumbers(this.combinacio);
            if(reintegrament < -1 || reintegrament > 9) throw new IllegalArgumentException("El número de reintegrament ha de ser entre 0 i 9.");
        } catch (IllegalArgumentException iae){
            Alert alerta = new Alert(Alert.AlertType.ERROR);
            alerta.setTitle("[Error]");
            alerta.setHeaderText("La Aposta no s'ha afegit");
            alerta.setContentText("La Combinació és incorrecta: " + iae.getMessage());
            alerta.showAndWait();
        }
        this.reintegrament = reintegrament;
    }

    // Crea una nova Combinació
    public Combinacio() {
        Random tmp = new Random();
        combinacio = generarCombinacioAleatoria();
        reintegrament = tmp.nextInt(10);
    }

    // Ordena els números de la combinacio
    private void sortNumbers(int[] combinacio) {
        for (int i = 0; i < 5; i++) {
            for (int j = 0; j < 5 - i; j++) {
                if (combinacio[j] > combinacio[j + 1]) {
                    int temp = combinacio[j];
                    combinacio[j] = combinacio[j + 1];
                    combinacio[j + 1] = temp;
                }
            }
        }
    }

    // Genera una Combinació aleatòria
    public int[] generarCombinacioAleatoria() {
        int[] combinacioAleatoria = new int[6];
        Random random = new Random();
        for (int i = 0; i < 6; i++) {
            int num;
            boolean repetit;
            do {
                num = random.nextInt(49) + 1;
                repetit = false;
                for(int j = 0; j < i; j++) {
                    if(combinacioAleatoria[j] == num) {
                        repetit = true;
                        break;
                    }
                }
            } while (repetit);
            combinacioAleatoria[i] = num;
        }
        sortNumbers(combinacioAleatoria);
        return combinacioAleatoria;
    }

    // Convertir la Combinació a String
    public String combinacioToString() {
        String combinacioString = "";
        for (int i = 0; i < 6; i++) {
            if (combinacio[i] < 10) combinacioString += "0" + combinacio[i];
            else combinacioString += combinacio[i];

            if(i < 5) combinacioString += " ";
        }
        return combinacioString;
    }

    // Getters
    public int[] getCombinacio() { return this.combinacio; }
    public int getReintegrament() {
        return this.reintegrament;
    }
}
