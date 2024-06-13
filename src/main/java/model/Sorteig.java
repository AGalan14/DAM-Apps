package model;

import java.util.Date;

public class Sorteig implements Comparable<Sorteig> {
    private Date dataSorteig;

    // Constructor Sorteig
    public Sorteig(Date dataSorteig) {
        this.dataSorteig = dataSorteig;
    }

    //Comparar Sorteigs
    @Override
    public int compareTo(Sorteig otherSorteig) {
        return this.dataSorteig.compareTo(otherSorteig.dataSorteig);
    }

    // Getters
    public Date getDataSorteig() {
        return dataSorteig;
    }
}
