Imports System.Data.SqlClient

Module DBFunctions_Idiomes
    Dim connectionString As String = "Data Source=ANGEL\SQLEXPRESS;Initial Catalog=Voluntariat;Integrated Security=True"
    Dim connection As New SqlConnection(connectionString)

    Public Function InsertIdioma(idioma As String) As Boolean
        Dim success As Boolean = False
        Try
            connection.Open()
            Dim sql = "INSERT INTO Idiomes(idioma) VALUES(@idiomaParam)"
            Dim command As New SqlCommand(sql, connection)
            command.Parameters.AddWithValue("@idiomaParam", idioma)
            command.ExecuteNonQuery()
            success = True
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
        Return success
    End Function

    Public Function deleteIdioma(idioma As String) As Boolean
        Dim success As Boolean = False
        Try
            connection.Open()
            Dim sql = "DELETE FROM Idiomes WHERE idioma = @idiomaParam"
            Dim command As New SqlCommand(sql, connection)
            command.Parameters.AddWithValue("@idiomaParam", idioma)
            command.ExecuteNonQuery()
            success = True
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
        Return success
    End Function

    Public Function getIdiomesArrayList() As String()
        Dim ambitsList As New List(Of String)
        Try
            connection.Open()
            Dim sql = "SELECT idioma FROM Idiomes"
            Dim command As New SqlCommand(sql, connection)
            Dim reader As SqlDataReader = command.ExecuteReader()
            While reader.Read()
                ambitsList.Add(reader("idioma").ToString())
            End While
            reader.Close()
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
        Return ambitsList.ToArray()
    End Function

    Public Function checkIfIdiomaExists(idioma As String) As Boolean
        Dim columnExists As Boolean = False
        Try
            connection.Open()
            Dim sql = "SELECT idioma FROM Idiomes WHERE idioma = @idiomaParam"
            Dim command As New SqlCommand(sql, connection)
            command.Parameters.AddWithValue("@idiomaParam", idioma)
            Dim reader As SqlDataReader = command.ExecuteReader()
            columnExists = reader.HasRows
            reader.Close()
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
        Return columnExists
    End Function

    'VoluntariIdiomes

    Public Function InsertIdiomesToVoluntari(idVoluntari As Integer, idioma As String) As Boolean
        Dim success As Boolean = False
        Try
            connection.Open()
            Dim sql = "INSERT INTO VoluntariIdiomes(id_voluntari, idioma) VALUES(@idVoluntariParam, @idiomaParam)"
            Dim command As New SqlCommand(sql, connection)
            command.Parameters.AddWithValue("@idVoluntariParam", idVoluntari)
            command.Parameters.AddWithValue("@idiomaParam", idioma)
            command.ExecuteNonQuery()
            success = True
        Catch ex As Exception
            Throw
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
        Return success
    End Function

    Public Function DeleteAllIdiomesFromVoluntari(idVoluntari As Integer) As Boolean
        Dim success As Boolean = False
        Try
            connection.Open()
            Dim sql = "DELETE FROM VoluntariIdiomes WHERE id_voluntari = @idVoluntariParam"
            Dim command As New SqlCommand(sql, connection)
            command.Parameters.AddWithValue("@idVoluntariParam", idVoluntari)
            command.ExecuteNonQuery()
            success = True
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
        Return success
    End Function

    Public Function IsIdiomaLinkedBeforeDeleting(idioma As String) As Boolean
        Dim isLinked As Boolean = False
        Try
            connection.Open()
            Dim sql = "SELECT idioma FROM VoluntariIdiomes WHERE idioma = @idiomaParam"
            Dim command As New SqlCommand(sql, connection)
            command.Parameters.AddWithValue("@idiomaParam", idioma)
            Dim reader As SqlDataReader = command.ExecuteReader()
            isLinked = reader.HasRows
            reader.Close()
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
        Return isLinked
    End Function

    Public Function deleteLinkedIdioma(idioma As String) As Boolean
        Dim success As Boolean = False
        Try
            connection.Open()
            Dim sql = "DELETE FROM VoluntariIdiomes WHERE idioma = @idiomaParam"
            Dim command As New SqlCommand(sql, connection)
            command.Parameters.AddWithValue("@idiomaParam", idioma)
            command.ExecuteNonQuery()
            success = True
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
        Return success
    End Function

    Public Function getIdiomesFromVoluntari(idVoluntari As Integer) As String()
        Dim idiomesVoluntari As New List(Of String)
        Try
            connection.Open()
            Dim sql = String.Format("SELECT idioma FROM VoluntariIdiomes WHERE id_voluntari = @idVoluntariParam")
            Dim command As New SqlCommand(sql, connection)
            command.Parameters.AddWithValue("@idVoluntariParam", idVoluntari)
            Dim adapter As New SqlDataAdapter(command)
            Dim dataTable As New DataTable
            adapter.Fill(dataTable)
            For Each row In dataTable.Rows
                idiomesVoluntari.Add(row("idioma").ToString())
            Next
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
        Return idiomesVoluntari.ToArray()
    End Function
End Module
