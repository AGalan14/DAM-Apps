Imports System.Data.SqlClient

Module DBFunctions_Informes
    Dim connectionString As String = "Data Source=ANGEL\SQLEXPRESS;Initial Catalog=Voluntariat;Integrated Security=True"
    Dim connection As New SqlConnection(connectionString)

    Public Function getInformesArrayList() As String()
        Dim informesList As New List(Of String)
        Try
            connection.Open()
            Dim sql = "SELECT informe FROM Informes"
            Dim command As New SqlCommand(sql, connection)
            Dim reader As SqlDataReader = command.ExecuteReader()
            While reader.Read()
                informesList.Add(reader("informe").ToString())
            End While
            reader.Close()
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
        Return informesList.ToArray()
    End Function

    Public Function GetVoluntarisYearsOfCreation() As String()
        Dim voluntarisYearsOfCreation As New List(Of String)
        Try
            connection.Open()
            Dim sql = "SELECT DISTINCT YEAR(CONVERT(DATE, data_inscripcio)) AS 'AnyCreacio' FROM Voluntaris"
            Dim command As New SqlCommand(sql, connection)
            Dim reader As SqlDataReader = command.ExecuteReader()
            While reader.Read()
                voluntarisYearsOfCreation.Add(reader("AnyCreacio").ToString())
            End While
            reader.Close()
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
        Return voluntarisYearsOfCreation.ToArray()
    End Function

    Public Function countVoluntarisFromYear(year As Integer) As Integer
        Dim voluntarisFromYear As Integer
        Try
            connection.Open()
            Dim sql = "SELECT COUNT(id_voluntari) FROM Voluntaris WHERE YEAR(CONVERT(DATE, data_inscripcio)) = @yearParam"
            Dim command As New SqlCommand(sql, connection)
            command.Parameters.AddWithValue("@yearParam", year)
            voluntarisFromYear = CInt(command.ExecuteScalar())
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
        Return voluntarisFromYear
    End Function

    Public Function countVoluntarisFromProjecte(projecte As String) As Integer
        Dim voluntarisFromProjecte As Integer
        Try
            connection.Open()
            Dim sql = "SELECT COUNT(id_voluntari) FROM VoluntariProjectes WHERE projecte = @projecteParam"
            Dim command As New SqlCommand(sql, connection)
            command.Parameters.AddWithValue("@projecteParam", projecte)
            voluntarisFromProjecte = CInt(command.ExecuteScalar())
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
        Return voluntarisFromProjecte
    End Function

    Public Function countVoluntaris() As Integer
        Dim voluntarisCount As Integer
        Try
            connection.Open()
            Dim sql = "SELECT COUNT(id_voluntari) FROM Voluntaris"
            Dim command As New SqlCommand(sql, connection)
            voluntarisCount = CInt(command.ExecuteScalar())
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
        Return voluntarisCount
    End Function

    Public Function countVoluntarisActiuFromYear(year As Integer) As Integer
        Dim voluntarisFromYear As Integer
        Try
            connection.Open()
            Dim sql = "SELECT COUNT(id_voluntari) FROM Voluntaris WHERE YEAR(CONVERT(DATE, data_inscripcio)) = @yearParam AND actiu = 1"
            Dim command As New SqlCommand(sql, connection)
            command.Parameters.AddWithValue("@yearParam", year)
            voluntarisFromYear = CInt(command.ExecuteScalar())
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
        Return voluntarisFromYear
    End Function

    Public Function countVoluntarisBaixaFromYear(year As Integer) As Integer
        Dim voluntarisFromYear As Integer
        Try
            connection.Open()
            Dim sql = "SELECT COUNT(id_voluntari) FROM Voluntaris WHERE YEAR(CONVERT(DATE, data_inscripcio)) = @yearParam AND actiu = 0"
            Dim command As New SqlCommand(sql, connection)
            command.Parameters.AddWithValue("@yearParam", year)
            voluntarisFromYear = CInt(command.ExecuteScalar())
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
        Return voluntarisFromYear
    End Function

    Public Function getProjectesYearsOfCreation() As String()
        Dim projectesYearsOfCreation As New List(Of String)
        Try
            connection.Open()
            Dim sql = "SELECT DISTINCT YEAR(CONVERT(DATE, data_finalitzacio)) AS 'AnyCreacio' FROM Projectes WHERE estat LIKE 'Finalitzat'"
            Dim command As New SqlCommand(sql, connection)
            Dim reader As SqlDataReader = command.ExecuteReader()
            If reader.HasRows Then
                While reader.Read()
                    projectesYearsOfCreation.Add(reader("AnyCreacio").ToString())
                End While
            End If
            reader.Close()
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
        Return projectesYearsOfCreation.ToArray()
    End Function

    Public Function countProjectesFromYear(year As Integer) As Integer
        Dim projectesFromYear As Integer
        Try
            connection.Open()
            Dim sql = "SELECT COUNT(projecte) FROM Projectes WHERE YEAR(CONVERT(DATE, data_finalitzacio)) = @yearParam AND estat LIKE 'Finalitzat'"
            Dim command As New SqlCommand(sql, connection)
            command.Parameters.AddWithValue("@yearParam", year)
            projectesFromYear = CInt(command.ExecuteScalar())
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
        Return projectesFromYear
    End Function

    Public Function countProjectesFromYearAndAmbit(year As Integer, ambit As String) As Integer
        Dim projectesFromYear As Integer
        Try
            connection.Open()
            Dim sql = "SELECT COUNT(projecte) FROM Projectes WHERE YEAR(CONVERT(DATE, data_finalitzacio)) = @yearParam AND estat LIKE 'Finalitzat' AND ambit = @ambitParam"
            Dim command As New SqlCommand(sql, connection)
            command.Parameters.AddWithValue("@yearParam", year)
            command.Parameters.AddWithValue("@ambitParam", ambit)
            projectesFromYear = CInt(command.ExecuteScalar())
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
        Return projectesFromYear
    End Function
End Module
