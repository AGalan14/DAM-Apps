package model;

public class Aposta {
    private int idAposta;
    private Combinacio combinacio;

    // Crea una Aposta
    public Aposta(Combinacio combinacio, int idAposta) {
        this.combinacio = combinacio;
        this.idAposta = idAposta;
    }

    // Canvia la id de l'Aposta
    public void setIdAposta(int idAposta) {
        this.idAposta = idAposta;
    }

    // Getters
    public int getIdAposta() {
        return idAposta;
    }
    public Combinacio getCombinacio() {
        return combinacio;
    }
}
