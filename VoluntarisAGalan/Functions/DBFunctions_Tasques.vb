Imports System.Data.SqlClient

Module DBFunctions_Tasques
    Dim connectionString As String = "Data Source=ANGEL\SQLEXPRESS;Initial Catalog=Voluntariat;Integrated Security=True"
    Dim connection As New SqlConnection(connectionString)

    Public Function InsertTascaToProjecte(projecte As String, tasca As String) As Boolean
        Dim success As Boolean = False
        Try
            connection.Open()
            Dim sql = "INSERT INTO ProjecteTasques(projecte, tasca) VALUES(@projecteParam, @tascaParam)"
            Dim command As New SqlCommand(sql, connection)
            command.Parameters.AddWithValue("@projecteParam", projecte)
            command.Parameters.AddWithValue("@tascaParam", tasca)
            command.ExecuteNonQuery()
            success = True
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
        Return success
    End Function

    Public Function DeleteTascaFromProjecte(projecte As String, tasca As String) As Boolean
        Dim success As Boolean = False
        Try
            connection.Open()
            Dim sql = "DELETE FROM ProjecteTasques WHERE projecte = @projecteParam AND tasca = @tascaParam"
            Dim command As New SqlCommand(sql, connection)
            command.Parameters.AddWithValue("@projecteParam", projecte)
            command.Parameters.AddWithValue("@tascaParam", tasca)
            command.ExecuteNonQuery()
            success = True
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
        Return success
    End Function

    Public Function deleteAllTasquesFromProjecte(projecte As String) As Boolean
        Dim success As Boolean = False
        Try
            connection.Open()
            Dim sql = "DELETE FROM ProjecteTasques WHERE projecte = @projecteParam"
            Dim command As New SqlCommand(sql, connection)
            command.Parameters.AddWithValue("@projecteParam", projecte)
            command.ExecuteNonQuery()
            success = True
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
        Return success
    End Function

    Public Function ListBoxDisplayTasquesFromProjecte(projecte As String) As String()
        Dim listBoxDisplay As New List(Of String)
        Try
            connection.Open()
            Dim sql = "SELECT DISTINCT tasca FROM ProjecteTasques WHERE projecte = @projecteParam"
            Dim command As New SqlCommand(sql, connection)
            command.Parameters.AddWithValue("@projecteParam", projecte)
            Dim reader As SqlDataReader = command.ExecuteReader()
            If reader.HasRows Then
                While reader.Read()
                    listBoxDisplay.Add(reader("tasca").ToString())
                End While
            End If
            reader.Close()
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
        Return listBoxDisplay.ToArray()
    End Function
End Module
