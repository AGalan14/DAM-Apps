package controller;

import model.*;

import java.util.*;

public class Primitiva {
    public static boolean insertarSorteig(Sorteig sorteig){
        return SorteigDAO.insertarSorteig(sorteig);
    }

    public static ArrayList<Sorteig> sorteigsNoRealitzatsList() {
        return SorteigDAO.sorteigsNoRealitzatsList();
    }

    public static ArrayList<Sorteig> sorteigsRealitzatsList() {
        return SorteigDAO.sorteigsRealitzatsList();
    }

    public static ArrayList<Sorteig> sorteigsList() {
        return SorteigDAO.sorteigsList();
    }

    public static boolean realitzarSorteig(java.sql.Date data){
        return SorteigDAO.realitzarSorteig(data);
    }

    public static ArrayList<Integer> apostesFromSorteig(java.sql.Date data) { return ApostaDAO.apostesFromSorteig(data); }

    public static int getLastIdAposta() { return ApostaDAO.getLastIdAposta(); };

    public static boolean estaCobrada(int id, java.sql.Date data){
        return ApostaDAO.estaCobrada(id, data);
    }

    public static boolean afegirAposta(Aposta aposta, Date data){
        return ApostaDAO.afegirAposta(aposta, data);
    }

    public static Combinacio getCombinacioFromDB(Date data, int id){
        return ApostaDAO.getCombinacioFromDB(data, id);
    }

    public static int quantitatApostes(java.sql.Date date){
        return SorteigDAO.quantitatApostes(date);
    }

    public static int quantitatPremiades(java.sql.Date date){
        return SorteigDAO.quantitatPremiades(date);
    }

    public static int apostesReintegrament(java.sql.Date date){
        return SorteigDAO.apostesReintegrament(date);
    }

    public static boolean comprobarPremiat(int id, Date data){
        return ApostaDAO.comprobarPremiat(id, data);
    }

    public static String premiDonat(Aposta aposta, java.sql.Date data) {
        return SorteigDAO.premiDonat(aposta, data);
    }

    public static boolean cobrarAposta(int id, java.sql.Date data){
        return ApostaDAO.cobrarAposta(id, data);
    }

    public static void marcarPremiada(Date data){
        ApostaDAO.marcarPremiada(data);
    }

    public static int apostaPremiadaQuedaPerCobrarByData(java.sql.Date date){
        return ApostaDAO.apostaPremiadaQuedaPerCobrarByData(date);
    }

    public static int nombreEncerts(int[] combinacio, int[] resultat) {
        int encerts = 0;
        for (int i = 0; i < combinacio.length; i++) {
            if (Arrays.binarySearch(resultat, combinacio[i]) >= 0) {
                encerts++;
            }
        }
        return encerts;
    }
}
