package model;

import controller.Primitiva;

import java.sql.*;
import java.util.ArrayList;

public class SorteigDAO {
    private static final String USER = "avvgjxvq";

    private static final String URL = "jdbc:postgresql://rogue.db.elephantsql.com/" + USER;

    private static final String PASSWD = "kzWFhLsfLCqSHmCokR5twr4EL96nes0f";

    // Crea un nou sorteig dins la base de dades
    public static boolean insertarSorteig(Sorteig sorteig) {
        Connection dbconnection;
        PreparedStatement statement;
        ResultSet result;
        int result2;
        String sql;
        Date data;

        try{
            sql = "SELECT data_sorteig FROM Sorteig WHERE data_sorteig = ?";
            dbconnection = DriverManager.getConnection(URL, USER, PASSWD);
            statement = dbconnection.prepareStatement(sql);
            data = new java.sql.Date(sorteig.getDataSorteig().getTime());
            statement.setDate(1, data);
            result = statement.executeQuery();

            if(result.next()) return false;
            else {
                sql = "INSERT INTO Sorteig (data_sorteig) VALUES (?)";
                statement = dbconnection.prepareStatement(sql);
                statement.setDate(1, data);
                result2 = statement.executeUpdate();
            }

            result.close();
            statement.close();
            dbconnection.close();
        } catch(SQLException sqle){
            System.err.println("Error al crear un nou Sorteig");
            sqle.printStackTrace();
            return false;
        }
        return result2 != -1;
    }

    // Recopila els Sorteigs realitzats en un ArrayList
    public static ArrayList<Sorteig> sorteigsNoRealitzatsList() {
        Connection dbconnection;
        PreparedStatement statement;
        ResultSet result;
        String sql;
        ArrayList<Sorteig> tmp = new ArrayList<>();

        try{
            sql = "SELECT data_sorteig FROM Sorteig WHERE realitzat = false";
            dbconnection = DriverManager.getConnection(URL, USER, PASSWD);
            statement = dbconnection.prepareStatement(sql);
            result = statement.executeQuery();

            while(result.next()) tmp.add(new Sorteig(result.getDate(1)));

            result.close();
            statement.close();
            dbconnection.close();
        } catch(SQLException sqle){
            System.err.println("Error al recopilar Sorteigs en una llista");
            sqle.printStackTrace();
        }
        return tmp;
    }

    // Recopila els Sorteigs realitzats en un ArrayList
    public static ArrayList<Sorteig> sorteigsRealitzatsList() {
        Connection dbconnection;
        PreparedStatement statement;
        ResultSet result;
        String sql;
        ArrayList<Sorteig> sorteigs = new ArrayList<>();

        try{
            sql = "SELECT data_sorteig FROM Sorteig WHERE realitzat = true";
            dbconnection = DriverManager.getConnection(URL, USER, PASSWD);
            statement = dbconnection.prepareStatement(sql);
            result = statement.executeQuery();

            while(result.next()) sorteigs.add(new Sorteig(result.getDate(1)));

            result.close();
            statement.close();
            dbconnection.close();
        } catch(SQLException sqle){
            System.err.println("Error al recopilar els sorteigs en una llista");
            sqle.printStackTrace();
        }
        return sorteigs;
    }

    // Recopila els Sorteigs en un ArrayList
    public static ArrayList<Sorteig> sorteigsList() {
        Connection dbconnection;
        PreparedStatement statement;
        ResultSet result;
        String sql;
        ArrayList<Sorteig> sorteigs = new ArrayList<>();

        try{
            sql = "SELECT data_sorteig, realitzat FROM Sorteig";
            dbconnection = DriverManager.getConnection(URL, USER, PASSWD);
            statement = dbconnection.prepareStatement(sql);
            result = statement.executeQuery();

            while(result.next()) sorteigs.add(new Sorteig(result.getDate(1)));

            result.close();
            statement.close();
            dbconnection.close();
        } catch(SQLException sqle){
            System.err.println("Error al recopilar els sorteigs en una llista");
            sqle.printStackTrace();
        }
        return sorteigs;
    }

    // Realitza el Sorteig
    public static boolean realitzarSorteig(Date dia_sorteig) {
        Connection dbconnection;
        PreparedStatement statement;
        int result, result2;
        String sql;

        try{
            sql = "UPDATE Sorteig SET realitzat = true WHERE data_sorteig = ?";
            dbconnection = DriverManager.getConnection(URL, USER, PASSWD);
            statement = dbconnection.prepareStatement(sql);
            statement.setDate(1, dia_sorteig);
            result = statement.executeUpdate();

            Combinacio combinacio = new Combinacio();

            sql = "INSERT INTO Premiat VALUES (?, ?, ?)";
            dbconnection = DriverManager.getConnection(URL, USER, PASSWD);
            statement = dbconnection.prepareStatement(sql);
            statement.setDate(1, dia_sorteig);
            statement.setString(2, combinacio.combinacioToString());
            statement.setInt(3, combinacio.getReintegrament());
            result2 = statement.executeUpdate();

            statement.close();
            dbconnection.close();
        } catch(SQLException sqle){
            System.err.println("Error al realitzar el Sorteig");
            sqle.printStackTrace();
            return false;
        }
        if(result != 0 && result2 != 0) Primitiva.marcarPremiada(dia_sorteig);
        return result != 0;
    }

    // Retorna la quantitat d'Apostes realitzades d'un Sorteig
    public static int quantitatApostes(java.sql.Date data) {
        Connection dbconnection;
        PreparedStatement statement;
        ResultSet result;
        String sql;
        int quantitat;

        try{
            sql = "SELECT COUNT(*) AS quantitat FROM Aposta WHERE data_sorteig = ?";
            dbconnection = DriverManager.getConnection(URL, USER, PASSWD);
            statement = dbconnection.prepareStatement(sql);
            statement.setDate(1, data);
            result = statement.executeQuery();
            result.next();
            quantitat = result.getInt("quantitat");

            statement.close();
            dbconnection.close();
        } catch(SQLException sqle){
            System.err.println("Error al contar la quantitat d'Apostes realitzades en un Sorteig");
            sqle.printStackTrace();
            return -2;
        }
        return quantitat;
    }

    // Retorna la quantitat de Apostes premiades d'un Sorteig
    public static int quantitatPremiades(java.sql.Date data) {
        Connection dbconnection;
        PreparedStatement statement;
        ResultSet result;
        String sql;
        int quantitat;

        try{
            sql = "SELECT COUNT(*) AS quantitat FROM Aposta WHERE premiada = true AND data_sorteig = ?";
            dbconnection = DriverManager.getConnection(URL, USER, PASSWD);
            statement = dbconnection.prepareStatement(sql);
            statement.setDate(1, data);
            result = statement.executeQuery();
            result.next();
            quantitat = result.getInt("quantitat");

            statement.close();
            dbconnection.close();
        } catch(SQLException sqle){
            System.err.println("Error al contar la quantitat d'Apostes premiades en un Sorteig");
            sqle.printStackTrace();
            return -2;
        }
        return quantitat;
    }

    // Retorna la quantitat d'Apostes amb Reintegrament d'un Sorteig
    public static int apostesReintegrament(java.sql.Date data) {
        Connection dbconnection;
        PreparedStatement statement;
        ResultSet result;
        String sql;
        int quantitat;

        try {
            sql = "SELECT COUNT(*) AS quantitat FROM Aposta WHERE reintegrament != -1 AND data_sorteig = ?";
            dbconnection = DriverManager.getConnection(URL, USER, PASSWD);
            statement = dbconnection.prepareStatement(sql);
            statement.setDate(1, data);
            result = statement.executeQuery();
            result.next();
            quantitat = result.getInt("quantitat");
            statement.close();
            dbconnection.close();
        } catch(SQLException sqle) {
            System.err.println("Error al contar la quantitat d'Apostes amb Reintegrrament d'un Sorteig");
            sqle.printStackTrace();
            return -2;
        }
        return quantitat;
    }

    // Si l'Aposta té un premi mostra quin premi correspòn
    public static String premiDonat(Aposta aposta, Date data) {
        Connection dbconnection;
        PreparedStatement statement;
        ResultSet result;
        String sql;
        String[] tmp;
        int[] guanyador = new int[6];
        int[] combinacio = new int[6];
        int reintegro;
        String premi = "";

        try{
            sql = "SELECT combinacio, reintegrament FROM Premiat WHERE data_sorteig = ?";
            dbconnection = DriverManager.getConnection(URL, USER, PASSWD);
            statement = dbconnection.prepareStatement(sql);
            statement.setDate(1, data);
            result = statement.executeQuery();
            result.next();
            tmp = result.getString("combinacio").split(" ");
            reintegro = result.getInt("reintegrament");
            for (int i = 0; i < guanyador.length; i++) {
                guanyador[i] = Integer.parseInt(tmp[i]);
            }
            tmp = aposta.getCombinacio().combinacioToString().split(" ");
            for (int i = 0; i < combinacio.length; i++) {
                combinacio[i] = Integer.parseInt(tmp[i]);
            }

            int encerts = Primitiva.nombreEncerts(combinacio, guanyador);
            boolean reintegramentGuanyat = (reintegro == aposta.getCombinacio().getReintegrament());

            if (encerts == 6) {
                premi = "Has guanyat el premi! (6 encerts)";
            } else if (encerts == 5) {
                premi = "Has guanyat el premi! (5 encerts)";
            } else if (encerts == 4) {
                premi = "Has guanyat el premi! (4 encerts)";
            } else if (encerts == 3) {
                premi = "No has set premiat... (3 encerts)";
            } else if (encerts == 2) {
                premi = "No has set premiat... (2 encerts)";
            } else if (encerts == 1) {
                premi = "No has set premiat... (1 encerts)";
            } else premi = "No has set premiat... (0 encerts)";

            if (reintegramentGuanyat) premi += "\nHas guanyat per Reintegrament!";
            else premi += "\nNo hi ha reintegrament";

            statement.close();
            dbconnection.close();
        } catch(SQLException sqle){
            System.err.println("Error al mostrar el premi corresponent");
            sqle.printStackTrace();
        }
        return premi;
    }
}
