Imports System.Data.SqlClient

Module DBFunctions_Habilitats
    Dim connectionString As String = "Data Source=ANGEL\SQLEXPRESS;Initial Catalog=Voluntariat;Integrated Security=True"
    Dim connection As New SqlConnection(connectionString)

    Public Function InsertHabilitat(habilitat As String) As Boolean
        Dim success As Boolean = False
        Try
            connection.Open()
            Dim sql = "INSERT INTO Habilitats(habilitat) VALUES(@habilitatParam)"
            Dim command As New SqlCommand(sql, connection)
            command.Parameters.AddWithValue("@habilitatParam", habilitat)
            command.ExecuteNonQuery()
            success = True
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
        Return success
    End Function

    Public Function deleteHabilitat(habilitat As String) As Boolean
        Dim success As Boolean = False
        Try
            connection.Open()
            Dim sql = "DELETE FROM Habilitats WHERE habilitat = @habilitatParam"
            Dim command As New SqlCommand(sql, connection)
            command.Parameters.AddWithValue("@habilitatParam", habilitat)
            command.ExecuteNonQuery()
            success = True
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
        Return success
    End Function

    Public Function getHabilitatsArrayList() As String()
        Dim ambitsList As New List(Of String)
        Try
            connection.Open()
            Dim sql = "SELECT habilitat FROM Habilitats"
            Dim command As New SqlCommand(sql, connection)
            Dim reader As SqlDataReader = command.ExecuteReader()
            While reader.Read()
                ambitsList.Add(reader("habilitat").ToString())
            End While
            reader.Close()
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
        Return ambitsList.ToArray()
    End Function

    Public Function checkIfHabilitatExists(habilitat As String) As Boolean
        Dim columnExists As Boolean = False
        Try
            connection.Open()
            Dim sql = "SELECT habilitat FROM Habilitats WHERE habilitat = @habilitatParam"
            Dim command As New SqlCommand(sql, connection)
            command.Parameters.AddWithValue("@habilitatParam", habilitat)
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

    'VoluntariHabilitats
    Public Function InsertHabilitatsToVoluntari(idVoluntari As Integer, habilitat As String) As Boolean
        Dim success As Boolean = False
        Try
            connection.Open()
            Dim sql = "INSERT INTO VoluntariHabilitats(id_voluntari, habilitat) VALUES(@idVoluntariParam, @habilitatParam)"
            Dim command As New SqlCommand(sql, connection)
            command.Parameters.AddWithValue("@idVoluntariParam", idVoluntari)
            command.Parameters.AddWithValue("@habilitatParam", habilitat)
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

    Public Function deleteAllHabilitatsFromVoluntari(idVoluntari As Integer) As Boolean
        Dim success As Boolean = False
        Try
            connection.Open()
            Dim sql = "DELETE FROM VoluntariHabilitats WHERE id_voluntari = @idVoluntariParam"
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

    Public Function checkIfVoluntariHasHabilitat(idVoluntari As Integer, habilitat As String) As Boolean
        Dim hasAmbit As Boolean = False
        Try
            connection.Open()
            Dim sql = "SELECT habilitat FROM VoluntariHabilitats WHERE id_voluntari = @idVoluntariParam AND habilitat = @habilitatParam"
            Dim command As New SqlCommand(sql, connection)
            command.Parameters.AddWithValue("@idVoluntariParam", idVoluntari)
            command.Parameters.AddWithValue("@habilitatParam", habilitat)
            Dim reader As SqlDataReader = command.ExecuteReader()
            hasAmbit = reader.HasRows
            reader.Close()
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
        Return hasAmbit
    End Function

    Public Function IsHabilitatLinkedBeforeDeleting(habilitat As String) As Boolean
        Dim isLinked As Boolean = False
        Try
            connection.Open()
            Dim sql = "SELECT habilitat FROM VoluntariHabilitats WHERE habilitat = @habilitatParam"
            Dim command As New SqlCommand(sql, connection)
            command.Parameters.AddWithValue("@habilitatParam", habilitat)
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

    Public Function deleteLinkedHabilitat(habilitat As String) As Boolean
        Dim success As Boolean = False
        Try
            connection.Open()
            Dim sql = "DELETE FROM VoluntariHabilitats WHERE habilitat = @habilitatParam"
            Dim command As New SqlCommand(sql, connection)
            command.Parameters.AddWithValue("@habilitatParam", habilitat)
            command.ExecuteNonQuery()
            success = True
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
        Return success
    End Function

    Public Function getHabilitatsFromVoluntari(idVoluntari As Integer) As String()
        Dim habilitatsVoluntari As New List(Of String)
        Try
            connection.Open()
            Dim sql = String.Format("SELECT habilitat FROM VoluntariHabilitats WHERE id_voluntari = @idVoluntariParam")
            Dim command As New SqlCommand(sql, connection)
            command.Parameters.AddWithValue("@idVoluntariParam", idVoluntari)
            Dim adapter As New SqlDataAdapter(command)
            Dim dataTable As New DataTable
            adapter.Fill(dataTable)
            For Each row In dataTable.Rows
                habilitatsVoluntari.Add(row("habilitat").ToString())
            Next
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
        Return habilitatsVoluntari.ToArray()
    End Function
End Module
