Imports System.Data.SqlClient

Module DBFunctions_Projectes
    Dim connectionString As String = "Data Source=ANGEL\SQLEXPRESS;Initial Catalog=Voluntariat;Integrated Security=True"
    Dim connection As New SqlConnection(connectionString)

    Public Function InsertProjecte(projecte As String, definicio_projecte As String, ambit As String, voluntari_coordinador As Integer, data_inici As String, data_finalitzacio As String, lloc As String, nombre_voluntaris As Integer, estat As String) As Boolean
        Dim success As Boolean = False
        Try
            connection.Open()
            Dim sql = "INSERT INTO Projectes(projecte, definicio_projecte, ambit, voluntari_coordinador, data_inici, data_finalitzacio, lloc, nombre_voluntaris, estat) VALUES(@projecte, @definicio_projecte, @ambit, @voluntari_coordinador, @data_inici, @data_finalitzacio, @lloc, @nombre_voluntaris, @estat)"
            Dim command As New SqlCommand(sql, connection)
            command.Parameters.AddWithValue("@projecte", projecte)
            command.Parameters.AddWithValue("@definicio_projecte", definicio_projecte)
            command.Parameters.AddWithValue("@ambit", ambit)
            command.Parameters.AddWithValue("@voluntari_coordinador", voluntari_coordinador)
            command.Parameters.AddWithValue("@data_inici", data_inici)
            command.Parameters.AddWithValue("@data_finalitzacio", data_finalitzacio)
            command.Parameters.AddWithValue("@lloc", lloc)
            command.Parameters.AddWithValue("@nombre_voluntaris", nombre_voluntaris)
            command.Parameters.AddWithValue("@estat", estat)
            command.ExecuteNonQuery()
            success = True
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
        Return success
    End Function

    Public Function editProjecte(og_projecte As String, projecte As String, definicio_projecte As String, ambit As String, voluntari_coordinador As Integer, data_inici As String, data_finalitzacio As String, lloc As String, nombre_voluntaris As Integer, estat As String) As Boolean
        Dim success As Boolean = False
        Try
            connection.Open()
            Dim sql = "UPDATE Projectes SET projecte = @projecte, definicio_projecte = @definicio_projecte, ambit = @ambit, voluntari_coordinador = @voluntari_coordinador, data_inici = @data_inici, data_finalitzacio = @data_finalitzacio, lloc = @lloc, nombre_voluntaris = @nombre_voluntaris, estat = @estat WHERE projecte = @og_projecte"
            Dim command As New SqlCommand(sql, connection)
            command.Parameters.AddWithValue("@og_projecte", og_projecte)
            command.Parameters.AddWithValue("@projecte", projecte)
            command.Parameters.AddWithValue("@definicio_projecte", definicio_projecte)
            command.Parameters.AddWithValue("@ambit", ambit)
            command.Parameters.AddWithValue("@voluntari_coordinador", voluntari_coordinador)
            command.Parameters.AddWithValue("@data_inici", data_inici)
            command.Parameters.AddWithValue("@data_finalitzacio", data_finalitzacio)
            command.Parameters.AddWithValue("@lloc", lloc)
            command.Parameters.AddWithValue("@nombre_voluntaris", nombre_voluntaris)
            command.Parameters.AddWithValue("@estat", estat)
            command.ExecuteNonQuery()
            success = True
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
        Return success
    End Function

    Public Function getProjectes() As String()
        Dim projectes As New List(Of String)
        Try
            connection.Open()
            Dim sql = "SELECT projecte FROM Projectes"
            Dim command As New SqlCommand(sql, connection)
            Dim reader As SqlDataReader = command.ExecuteReader()
            If reader.HasRows Then
                While reader.Read()
                    projectes.Add(reader("projecte").ToString())
                End While
            End If
            reader.Close()
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
        Return projectes.ToArray()
    End Function

    Public Function comboBoxDisplayProjectes() As String()
        Dim displayProjectes As New List(Of String)
        Try
            connection.Open()
            Dim sql = "SELECT DISTINCT projecte, ambit FROM Projectes"
            Dim command As New SqlCommand(sql, connection)
            Dim reader As SqlDataReader = command.ExecuteReader()
            If reader.HasRows Then
                While reader.Read()
                    displayProjectes.Add(reader("projecte").ToString() & " (" & reader("ambit").ToString() & ")")
                End While
            End If
            reader.Close()
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
        Return displayProjectes.ToArray()
    End Function

    Public Function getMaxProjectesNum() As Integer
        Dim maxProjectesNum As Integer = 1
        Try
            connection.Open()
            Dim sql = String.Format("SELECT COUNT(*) FROM Projectes")
            Dim command As New SqlCommand(sql, connection)
            If Not IsDBNull(command.ExecuteScalar()) Then
                maxProjectesNum = CInt(command.ExecuteScalar())
            End If
        Catch ex As Exception
            Throw
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
        Return maxProjectesNum
    End Function

    Public Function getProjecteData(projecte As String) As String()
        Dim projecteData As New List(Of String)
        Try
            connection.Open()
            Dim sql = "SELECT * FROM Projectes WHERE projecte = @projecteParam"
            Dim command As New SqlCommand(sql, connection)
            command.Parameters.AddWithValue("@projecteParam", projecte)
            Dim reader As SqlDataReader = command.ExecuteReader()
            If reader.HasRows Then
                reader.Read()
                For col = 0 To reader.FieldCount - 1
                    projecteData.Add(reader.GetValue(col).ToString())
                Next
            End If
            reader.Close()
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
        Return projecteData.ToArray()
    End Function

    ' VoluntariProjectes

    Public Function InsertProjectesToVoluntari(projecte As String, idVoluntari As Integer) As Boolean
        Dim success As Boolean = False
        Try
            connection.Open()
            Dim sql = "INSERT INTO VoluntariProjectes(projecte, id_voluntari) VALUES(@projecteParam, @idVoluntariParam)"
            Dim command As New SqlCommand(sql, connection)
            command.Parameters.AddWithValue("@projecteParam", projecte)
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

    Public Function deleteAllVoluntarisFromProjecte(projecte As String) As Boolean
        Dim success As Boolean = False
        Try
            connection.Open()
            Dim sql = "DELETE FROM VoluntariProjectes WHERE projecte = @projecteParam"
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

    Public Function getProjectesRealitzantFromVoluntari(idVoluntari As Integer) As String()
        Dim idiomesVoluntari As New List(Of String)
        Try
            connection.Open()
            Dim sql = String.Format("SELECT DISTINCT VP.projecte FROM VoluntariProjectes VP INNER JOIN Projectes P ON VP.projecte = P.projecte WHERE VP.id_voluntari = @idVoluntariParam AND P.estat NOT LIKE 'Finalitzat'")
            Dim command As New SqlCommand(sql, connection)
            command.Parameters.AddWithValue("@idVoluntariParam", idVoluntari)
            Dim adapter As New SqlDataAdapter(command)
            Dim dataTable As New DataTable
            adapter.Fill(dataTable)
            For Each row In dataTable.Rows
                idiomesVoluntari.Add(row("projecte").ToString())
            Next
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
        Return idiomesVoluntari.ToArray()
    End Function

    Public Function getProjectesRealitzatsFromVoluntari(idVoluntari As Integer) As String()
        Dim idiomesVoluntari As New List(Of String)
        Try
            connection.Open()
            Dim sql = String.Format("SELECT DISTINCT VP.projecte FROM VoluntariProjectes VP INNER JOIN Projectes P ON VP.projecte = P.projecte WHERE VP.id_voluntari = @idVoluntariParam AND P.estat LIKE 'Finalitzat'")
            Dim command As New SqlCommand(sql, connection)
            command.Parameters.AddWithValue("@idVoluntariParam", idVoluntari)
            Dim adapter As New SqlDataAdapter(command)
            Dim dataTable As New DataTable
            adapter.Fill(dataTable)
            For Each row In dataTable.Rows
                idiomesVoluntari.Add(row("projecte").ToString())
            Next
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
        Return idiomesVoluntari.ToArray()
    End Function
End Module
