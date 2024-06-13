package model;

import controller.Primitiva;

import java.sql.*;
import java.time.LocalDate;
import java.util.ArrayList;
import java.util.IllegalFormatCodePointException;

public class ApostaDAO {
    private static final String USER = "avvgjxvq";

    private static final String URL = "jdbc:postgresql://rogue.db.elephantsql.com/" + USER;

    private static final String PASSWD = "kzWFhLsfLCqSHmCokR5twr4EL96nes0f";

    // Afegir l'Aposta dins la base de dades
    public static boolean afegirAposta(Aposta aposta, java.util.Date data) {
        Connection dbconnection;
        PreparedStatement statement;
        ResultSet resultID;
        int insertResult;
        String sql;
        boolean apostaAfegida = false;

        try {
            sql = "SELECT MAX(id_aposta) AS newID FROM Aposta";
            dbconnection = DriverManager.getConnection(URL, USER, PASSWD);
            statement = dbconnection.prepareStatement(sql);
            resultID = statement.executeQuery();

            if(resultID.next()) {
                aposta.setIdAposta(resultID.getInt("newID") + 1);
            } else {
                aposta.setIdAposta(1);
            }

            System.out.println(aposta.getIdAposta());

            sql = "INSERT INTO Aposta VALUES(?, ?, ?, ?)";
            statement = dbconnection.prepareStatement(sql);
            statement.setInt(1, aposta.getIdAposta());
            statement.setDate(2, new java.sql.Date(data.getTime()));
            Combinacio combinacio = aposta.getCombinacio();
            statement.setString(3, combinacio.combinacioToString());
            statement.setInt(4, combinacio.getReintegrament());
            insertResult = statement.executeUpdate();

            if (insertResult != -1) apostaAfegida = true;

            statement.close();
            dbconnection.close();
        } catch(SQLException sqle){
            System.err.println("Error al afegir l'Aposta dins la base de dades");
            sqle.printStackTrace();
        }
        return apostaAfegida;
    }

    // Obtindre la combinació de l'Aposta desde la base de dades
    public static Combinacio getCombinacioFromDB(java.util.Date data, int id) {
        Connection dbconnection;
        PreparedStatement statement;
        ResultSet result;
        String sql;
        Combinacio combinacio = null;

        try{
            sql = "SELECT combinacio, reintegrament FROM Aposta WHERE id_aposta = ? AND data_sorteig = ?" ;
            dbconnection = DriverManager.getConnection(URL, USER, PASSWD);
            statement = dbconnection.prepareStatement(sql);
            statement.setInt(1, id);
            statement.setDate(2, new java.sql.Date(data.getTime()));
            result = statement.executeQuery();

            if (result.next()){
                int[] tmp2 = new int[6];
                String[] tmp = result.getString("combinacio").split(" ");
                for (int i = 0; i < tmp2.length; i++) tmp2[i] = Integer.parseInt(tmp[i]);
                combinacio = new Combinacio(tmp2, result.getInt("reintegrament"));
            }

            result.close();
            statement.close();
            dbconnection.close();
        } catch(SQLException sqle){
            System.err.println("Error al obtindre la combinació de l'Aposta desde la base de dades");
            sqle.printStackTrace();
        }
        return combinacio;
    }

    // Comprova si l'Aposta s'ha cobrat o no
    public static boolean estaCobrada(int id, java.sql.Date data){
        Connection dbconnection;
        PreparedStatement statement;
        ResultSet result;
        String sql;
        boolean estaCobradaComprovat = false;

        try {
            sql = "SELECT cobrada FROM Aposta A INNER JOIN Sorteig S ON A.data_sorteig = S.data_sorteig WHERE A.id_aposta = ? AND S.data_sorteig = ?";
            dbconnection = DriverManager.getConnection(URL, USER, PASSWD);
            statement = dbconnection.prepareStatement(sql);
            statement.setInt(1, id);
            statement.setDate(2, data);
            result = statement.executeQuery();

            if (result.next()){
                if (result.getBoolean("Cobrada")){
                    estaCobradaComprovat = true;
                }
            }

            result.close();
            statement.close();
            dbconnection.close();
        } catch(SQLException sqle){
            System.err.println("Error al comprovar si l'Aposta ha set cobrada");
            sqle.printStackTrace();
        }
        return estaCobradaComprovat;
    }

    // Comprova si l'Aposta ha set premiada o no
    public static boolean comprobarPremiat(int id, java.util.Date data){
        Connection dbconnection;
        PreparedStatement statement;
        ResultSet result;
        String sql;
        boolean setPremiada = false;

        try{
            sql = "SELECT premiada FROM Aposta WHERE id_aposta = ? AND data_sorteig = ?" ;
            dbconnection = DriverManager.getConnection(URL, USER, PASSWD);
            statement = dbconnection.prepareStatement(sql);
            statement.setInt(1, id);
            statement.setDate(2, new java.sql.Date(data.getTime()));
            result = statement.executeQuery();
            if (result.next()){
                if (result.getBoolean("premiada")){
                    setPremiada = true;
                }
            }


            result.close();
            statement.close();
            dbconnection.close();
        } catch(SQLException sqle){
            System.err.println("Error al comprovar si l'Aposta ha set premiada");
            sqle.printStackTrace();
        }
        return setPremiada;
    }

    // Marca l'aposta com cobrada
    public static boolean cobrarAposta(int id, java.sql.Date data) {
        Connection dbconnection;
        PreparedStatement statement;
        int result = 0;
        String sql;

        try{
            sql = "UPDATE Aposta SET cobrada = true WHERE id_aposta = ? AND data_sorteig = ?" ;
            dbconnection = DriverManager.getConnection(URL, USER, PASSWD);
            statement = dbconnection.prepareStatement(sql);
            statement.setInt(1, id);
            statement.setDate(2, new java.sql.Date(data.getTime()));
            result = statement.executeUpdate();

            statement.close();
            dbconnection.close();
        } catch(SQLException sqle){
            System.err.println("Error al marcar l'Aposta com cobrada");
            sqle.printStackTrace();
        }

        return (result > 0);
    }

    // Marca l'Aposta com a premiada
    public static void marcarPremiada(java.util.Date data) {
        Connection dbconnection;
        PreparedStatement statement;
        ResultSet result;
        ResultSet result2;
        String sql;
        String[] tmp;
        String[] tmp2;
        int[] combinacio = new int[6];
        int[] premiat = new int[6];

        try{
            sql = "SELECT * FROM Aposta WHERE data_sorteig = ?" ;
            dbconnection = DriverManager.getConnection(URL, USER, PASSWD);
            statement = dbconnection.prepareStatement(sql);
            statement.setDate(1, new java.sql.Date(data.getTime()));
            result = statement.executeQuery();

            sql = "SELECT * FROM Premiat WHERE data_sorteig = ?" ;
            statement = dbconnection.prepareStatement(sql);
            statement.setDate(1, new java.sql.Date(data.getTime()));
            result2 = statement.executeQuery();
            result2.next();
            while (result.next()){
                tmp = result.getString("combinacio").split(" ");
                tmp2 = result2.getString("combinacio").split(" ");
                for (int i = 0; i < tmp.length; i++) {
                    combinacio[i] = Integer.parseInt(tmp[i]);
                    premiat[i] = Integer.parseInt(tmp2[i]);
                }
                if (Primitiva.nombreEncerts(combinacio, premiat) > 0 || result.getInt("reintegrament") == result2.getInt("reintegrament")){
                    sql = "UPDATE Aposta SET premiada = true WHERE id_aposta = ? AND data_sorteig = ?" ;
                    statement = dbconnection.prepareStatement(sql);
                    statement.setInt(1, result.getInt("id_aposta"));
                    statement.setDate(2, new java.sql.Date(data.getTime()));
                    statement.executeUpdate();
                }
            }
            result.close();
            statement.close();
            dbconnection.close();
        } catch(SQLException sqle){
            System.err.println("Error al marcar l'Aposta com a premiada");
            sqle.printStackTrace();
        }

    }

    // Comprova quines Apostes queda per cobrar en un sorteig sempre que estigui premiada
    public static int apostaPremiadaQuedaPerCobrarByData(Date data) {
        Connection dbconnection;
        PreparedStatement statement;
        ResultSet result;
        String sql;
        int tmp = -1;

        try{
            sql = "SELECT COUNT(id_aposta) AS ID FROM Aposta WHERE data_sorteig = ? AND premiada = true AND cobrada = false" ;
            dbconnection = DriverManager.getConnection(URL, USER, PASSWD);
            statement = dbconnection.prepareStatement(sql);
            statement.setDate(1, data);
            result = statement.executeQuery();
            result.next();
            tmp = result.getInt("ID");

            result.close();
            statement.close();
            dbconnection.close();
        } catch(SQLException sqle){
            System.err.println("Error al comprovar si queden Apostes per cobrar");
            sqle.printStackTrace();
        }
        return tmp;
    }

    // Agafa l'últim dígit de l'ID de les Apostes
    public static int getLastIdAposta() {
        Connection dbconnection;
        PreparedStatement statement;
        ResultSet result;
        String sql;
        int idAposta = 0;

        try {
            sql = "SELECT MAX(id_aposta) AS ID FROM Aposta";
            dbconnection = DriverManager.getConnection(URL, USER, PASSWD);
            statement = dbconnection.prepareStatement(sql);
            result = statement.executeQuery();
            if (result.next()) {
                idAposta = result.getInt("ID");
            }

            result.close();
            statement.close();
            dbconnection.close();
        } catch(SQLException sqle){
            System.err.println("Error al agafar l'últim dígit de l'ID de les Apostes");
            sqle.printStackTrace();
        }
        return idAposta;
    }

    // Recopila les Apostes en un ArrayList
    public static ArrayList<Integer> apostesFromSorteig(Date data) {
        Connection dbconnection;
        PreparedStatement statement;
        ResultSet result;
        String sql;
        ArrayList<Integer> apostes = new ArrayList<>();

        try{
            sql = "SELECT id_aposta FROM Aposta WHERE data_sorteig = ?";
            dbconnection = DriverManager.getConnection(URL, USER, PASSWD);
            statement = dbconnection.prepareStatement(sql);
            statement.setDate(1, new Date(data.getTime()));
            result = statement.executeQuery();

            while(result.next()) {
                apostes.add(result.getInt("id_aposta"));
            }

            result.close();
            statement.close();
            dbconnection.close();
        } catch(SQLException sqle){
            System.err.println("Error al recopilar Apostes en una llista");
            sqle.printStackTrace();
        }
        return apostes;
    }
}
