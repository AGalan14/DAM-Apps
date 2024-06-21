Imports System.Data.SqlClient

Module DBFunctions_Ambits
    Dim connectionString As String = "Data Source=ANGEL\SQLEXPRESS;Initial Catalog=Voluntariat;Integrated Security=True"
    Dim connection As New SqlConnection(connectionString)

    Public Function getAmbitsArrayList() As String()
        Dim ambitsList As New List(Of String)
        Try
            connection.Open()
            Dim sql = "SELECT ambit FROM Ambits"
            Dim command As New SqlCommand(sql, connection)
            Dim reader As SqlDataReader = command.ExecuteReader()
            While reader.Read()
                ambitsList.Add(reader("ambit").ToString())
            End While
            reader.Close()
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
        Return ambitsList.ToArray()
    End Function

    Public Function InsertAmbit(ambit As String) As Boolean
        Dim success As Boolean = False
        Try
            connection.Open()
            Dim sql = "INSERT INTO Ambits(ambit) VALUES(@ambitParam)"
            Dim command As New SqlCommand(sql, connection)
            command.Parameters.AddWithValue("@ambitParam", ambit)
            command.ExecuteNonQuery()
            success = True
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
        Return success
    End Function

    Public Function deleteAmbit(ambit As String) As Boolean
        Dim success As Boolean = False
        Try
            connection.Open()
            Dim sql = "DELETE FROM Ambits WHERE ambit = @ambitParam"
            Dim command As New SqlCommand(sql, connection)
            command.Parameters.AddWithValue("@ambitParam", ambit)
            command.ExecuteNonQuery()
            success = True
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
        Return success
    End Function

    Public Function checkIfAmbitExists(ambit As String) As Boolean
        Dim columnExists As Boolean = False
        Try
            connection.Open()
            Dim sql = "SELECT ambit FROM Ambits WHERE ambit = @ambitParam"
            Dim command As New SqlCommand(sql, connection)
            command.Parameters.AddWithValue("@ambitParam", ambit)
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

    'VoluntariAmbits
    Public Function InsertAmbitsToVoluntari(idVoluntari As Integer, ambit As String) As Boolean
        Dim success As Boolean = False
        Try
            connection.Open()
            Dim sql = "INSERT INTO VoluntariAmbits(id_voluntari, ambit) VALUES(@idVoluntariParam, @ambitParam)"
            Dim command As New SqlCommand(sql, connection)
            command.Parameters.AddWithValue("@idVoluntariParam", idVoluntari)
            command.Parameters.AddWithValue("@ambitParam", ambit)
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

    Public Function deleteAllAmbitsFromVoluntari(idVoluntari As Integer) As Boolean
        Dim success As Boolean = False
        Try
            connection.Open()
            Dim sql = "DELETE FROM VoluntariAmbits WHERE id_voluntari = @idVoluntariParam"
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

    Public Function IsAmbitLinkedBeforeDeleting(ambit As String) As Boolean
        Dim isLinked As Boolean = False
        Try
            connection.Open()
            Dim sql = "SELECT ambit FROM VoluntariAmbits WHERE ambit = @ambitParam"
            Dim command As New SqlCommand(sql, connection)
            command.Parameters.AddWithValue("@ambitParam", ambit)
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

    Public Function deleteLinkedAmbit(ambit As String) As Boolean
        Dim success As Boolean = False
        Try
            connection.Open()
            Dim sql = "DELETE FROM VoluntariAmbits WHERE ambit = @ambitParam"
            Dim command As New SqlCommand(sql, connection)
            command.Parameters.AddWithValue("@ambitParam", ambit)
            command.ExecuteNonQuery()
            success = True
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
        Return success
    End Function

    Public Function getAmbitsFromVoluntari(idVoluntari As Integer) As String()
        Dim ambitsVoluntari As New List(Of String)
        Try
            connection.Open()
            Dim sql = String.Format("SELECT ambit FROM VoluntariAmbits WHERE id_voluntari = @idVoluntariParam")
            Dim command As New SqlCommand(sql, connection)
            command.Parameters.AddWithValue("@idVoluntariParam", idVoluntari)
            Dim adapter As New SqlDataAdapter(command)
            Dim dataTable As New DataTable
            adapter.Fill(dataTable)
            For Each row In dataTable.Rows
                ambitsVoluntari.Add(row("ambit").ToString())
            Next
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
        Return ambitsVoluntari.ToArray()
    End Function

    Public Function comboBoxDisplayVoluntarisOfAmbit(ambit As String) As String()
        Dim comboBoxDisplay As New List(Of String)
        Try
            connection.Open()
            Dim sql = "SELECT DISTINCT nom, cognom1, nif FROM Voluntaris V INNER JOIN VoluntariAmbits VA ON V.id_voluntari = VA.id_voluntari WHERE VA.ambit = @ambitParam"
            Dim command As New SqlCommand(sql, connection)
            command.Parameters.AddWithValue("@ambitParam", ambit)
            Dim reader As SqlDataReader = command.ExecuteReader()
            While reader.Read()
                comboBoxDisplay.Add(reader("nom").ToString() & " " & reader("cognom1").ToString() & " (" & reader("nif").ToString() & ")")
            End While
            reader.Close()
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
        Return comboBoxDisplay.ToArray()
    End Function
End Module
