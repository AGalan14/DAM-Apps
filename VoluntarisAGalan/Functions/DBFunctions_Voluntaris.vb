Imports System.Data.SqlClient

Module DBFunctions_Voluntaris
    Dim connectionString As String = "Data Source=ANGEL\SQLEXPRESS;Initial Catalog=Voluntariat;Integrated Security=True"
    Dim connection As New SqlConnection(connectionString)

    Public Function InsertVoluntari(data_inscripcio As String, nom As String, cognom1 As String, cognom2 As String, nif As String, sexe As String, poblacio As String, adreca As String, email As String, telefon1 As Integer, telefon2 As Integer, data_naixement As String, motiu As String, assegurat As Boolean, observacions As String, disponibilitat As String, actiu As Boolean, motiu_inactiu As String) As Boolean
        Dim success As Boolean = False
        Try
            connection.Open()
            Dim sql = "INSERT INTO Voluntaris(data_inscripcio, nom, cognom1, cognom2, nif, sexe, poblacio, adreca, email, telefon1, telefon2, data_naixement, motiu, assegurat, observacions, disponibilitat, actiu, motiu_inactiu) VALUES(@data_inscripcio, @nom, @cognom1, @cognom2, @nif, @sexe, @poblacio, @adreca, @email, @telefon1, @telefon2, @data_naixement, @motiu, @assegurat, @observacions, @disponibilitat, @actiu, @motiu_inactiu)"
            Dim command As New SqlCommand(sql, connection)
            command.Parameters.AddWithValue("@data_inscripcio", data_inscripcio)
            command.Parameters.AddWithValue("@nom", nom)
            command.Parameters.AddWithValue("@cognom1", cognom1)
            command.Parameters.AddWithValue("@cognom2", cognom2)
            command.Parameters.AddWithValue("@nif", nif)
            command.Parameters.AddWithValue("@sexe", sexe)
            command.Parameters.AddWithValue("@poblacio", poblacio)
            command.Parameters.AddWithValue("@adreca", adreca)
            command.Parameters.AddWithValue("@email", email)
            command.Parameters.AddWithValue("@telefon1", telefon1)
            command.Parameters.AddWithValue("@telefon2", telefon2)
            command.Parameters.AddWithValue("@data_naixement", data_naixement)
            command.Parameters.AddWithValue("@motiu", motiu)
            command.Parameters.AddWithValue("@assegurat", assegurat)
            command.Parameters.AddWithValue("@observacions", observacions)
            command.Parameters.AddWithValue("@disponibilitat", disponibilitat)
            command.Parameters.AddWithValue("@actiu", actiu)
            command.Parameters.AddWithValue("@motiu_inactiu", motiu_inactiu)
            command.ExecuteNonQuery()
            success = True
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
        Return success
    End Function

    Public Function editVoluntari(idVoluntari As Integer, data_inscripcio As String, nom As String, cognom1 As String, cognom2 As String, nif As String, sexe As String, poblacio As String, adreca As String, email As String, telefon1 As Integer, telefon2 As Integer, data_naixement As String, motiu As String, assegurat As Boolean, observacions As String, disponibilitat As String, actiu As Boolean, motiu_inactiu As String) As Boolean
        Dim success As Boolean = False
        Try
            connection.Open()
            Dim sql = "UPDATE Voluntaris SET data_inscripcio = @data_inscripcio, nom = @nom, cognom1 = @cognom1, cognom2 = @cognom2, nif = @nif, sexe = @sexe, poblacio = @poblacio, adreca = @adreca, email = @email, telefon1 = @telefon1, telefon2 = @telefon2, data_naixement = @data_naixement, motiu = @motiu, assegurat = @assegurat, observacions = @observacions, disponibilitat = @disponibilitat, actiu = @actiu, motiu_inactiu = @motiu_inactiu WHERE id_voluntari = @idVoluntariParam"
            Dim command As New SqlCommand(sql, connection)
            command.Parameters.AddWithValue("@data_inscripcio", data_inscripcio)
            command.Parameters.AddWithValue("@nom", nom)
            command.Parameters.AddWithValue("@cognom1", cognom1)
            command.Parameters.AddWithValue("@cognom2", cognom2)
            command.Parameters.AddWithValue("@nif", nif)
            command.Parameters.AddWithValue("@sexe", sexe)
            command.Parameters.AddWithValue("@poblacio", poblacio)
            command.Parameters.AddWithValue("@adreca", adreca)
            command.Parameters.AddWithValue("@email", email)
            command.Parameters.AddWithValue("@telefon1", telefon1)
            command.Parameters.AddWithValue("@telefon2", telefon2)
            command.Parameters.AddWithValue("@data_naixement", data_naixement)
            command.Parameters.AddWithValue("@motiu", motiu)
            command.Parameters.AddWithValue("@assegurat", assegurat)
            command.Parameters.AddWithValue("@observacions", observacions)
            command.Parameters.AddWithValue("@disponibilitat", disponibilitat)
            command.Parameters.AddWithValue("@actiu", actiu)
            command.Parameters.AddWithValue("@motiu_inactiu", motiu_inactiu)
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

    Public Function getIdVoluntariByNif(nif As String) As Integer
        Dim idVoluntari As Integer?
        Try
            connection.Open()
            Dim sql = "SELECT id_voluntari FROM Voluntaris WHERE nif = @nifParam"
            Dim command As New SqlCommand(sql, connection)
            command.Parameters.AddWithValue("@nifParam", nif)
            idVoluntari = CInt(command.ExecuteScalar())
        Catch ex As Exception
            Throw
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
        Return idVoluntari
    End Function

    Public Function checkIfNifExists(nif As String) As Boolean
        Dim columnExists As Boolean = False
        Try
            connection.Open()
            Dim sql = String.Format("SELECT nif FROM Voluntaris WHERE nif = @nif")
            Dim command As New SqlCommand(sql, connection)
            command.Parameters.AddWithValue("@nif", nif)
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

    Public Function checkIfNifIsFromVoluntari(nif As String, IdVoluntari As Integer) As Boolean
        Dim columnExists As Boolean = False
        Try
            connection.Open()
            Dim sql = String.Format("SELECT nif, id_voluntari FROM Voluntaris WHERE nif = @nif AND id_voluntari = @idVoluntariParam")
            Dim command As New SqlCommand(sql, connection)
            command.Parameters.AddWithValue("@nif", nif)
            command.Parameters.AddWithValue("@idVoluntariParam", IdVoluntari)
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

    Public Function checkIfVoluntariIsInProjecte(IdVoluntari As Integer, projecte As String) As Boolean
        Dim columnExists As Boolean = False
        Try
            connection.Open()
            Dim sql = String.Format("SELECT id_voluntari FROM VoluntariProjectes WHERE id_voluntari = @idVoluntariParam AND projecte = @projecteParam")
            Dim command As New SqlCommand(sql, connection)
            command.Parameters.AddWithValue("@idVoluntariParam", IdVoluntari)
            command.Parameters.AddWithValue("@projecteParam", projecte)
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

    Public Function checkIfVoluntariIsNotActiu(IdVoluntari As Integer) As Boolean
        Dim columnExists As Boolean = False
        Try
            connection.Open()
            Dim sql = String.Format("SELECT actiu FROM Voluntaris WHERE actiu = 0 AND id_voluntari = @idVoluntariParam")
            Dim command As New SqlCommand(sql, connection)
            command.Parameters.AddWithValue("@idVoluntariParam", IdVoluntari)
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

    Public Function compareNif(idVoluntari As Integer, nif As String) As Boolean
        Dim nifFromDB As String = ""
        Try
            connection.Open()
            Dim sql = String.Format("SELECT nif FROM Voluntaris WHERE id_voluntari = @idVoluntari")
            Dim command As New SqlCommand(sql, connection)
            command.Parameters.AddWithValue("@idVoluntari", idVoluntari)
            Dim reader As SqlDataReader = command.ExecuteReader()
            If reader.HasRows Then
                reader.Read()
                nifFromDB = reader.GetString(0)
            End If
            reader.Close()
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
        Return nifFromDB.Equals(nif, StringComparison.OrdinalIgnoreCase)
    End Function

    Public Function getVoluntariData(idVoluntari As Integer) As String()
        Dim voluntariData As New List(Of String)
        Try
            connection.Open()
            Dim sql = "SELECT * FROM Voluntaris WHERE id_voluntari = @idVoluntariParam"
            Dim command As New SqlCommand(sql, connection)
            command.Parameters.AddWithValue("@idVoluntariParam", idVoluntari)
            Dim reader As SqlDataReader = command.ExecuteReader()
            If reader.HasRows Then
                reader.Read()
                For col = 0 To reader.FieldCount - 1
                    voluntariData.Add(reader.GetValue(col).ToString())
                Next
            End If
            reader.Close()
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
        Return voluntariData.ToArray()
    End Function

    Public Function getMaxIdVoluntari() As Integer
        Dim maxId As Integer = 0
        Try
            connection.Open()
            Dim sql = String.Format("SELECT MAX(id_voluntari) FROM Voluntaris")
            Dim command As New SqlCommand(sql, connection)
            If Not IsDBNull(command.ExecuteScalar()) Then
                maxId = CInt(command.ExecuteScalar())
            End If
        Catch ex As Exception
            Throw
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
        Return maxId
    End Function

    Public Function comboBoxDisplayVoluntaris(idVoluntari As Integer) As String
        Dim comboBoxDisplay As String = ""
        Try
            connection.Open()
            Dim sql = "SELECT nom, cognom1, nif FROM Voluntaris WHERE id_voluntari = @idVoluntariParam"
            Dim command As New SqlCommand(sql, connection)
            command.Parameters.AddWithValue("@idVoluntariParam", idVoluntari)
            Dim reader As SqlDataReader = command.ExecuteReader()
            If reader.HasRows Then
                reader.Read()
                comboBoxDisplay = reader("nom").ToString() & " " & reader("cognom1").ToString() & " (" & reader("nif").ToString() & ")"
            End If
            reader.Close()
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
        Return comboBoxDisplay
    End Function

    Public Function comboBoxDisplayVoluntarisSearch(searchText As String) As String()
        Dim comboBoxDisplaySearch As New List(Of String)
        Try
            connection.Open()
            Dim sql = "SELECT nom, cognom1, nif FROM Voluntaris WHERE nom LIKE @searchText + '%'"
            Dim command As New SqlCommand(sql, connection)
            command.Parameters.AddWithValue("@searchText", searchText)
            Dim reader As SqlDataReader = command.ExecuteReader()
            If reader.HasRows Then
                reader.Read()
                comboBoxDisplaySearch.Add(reader("nom").ToString() & " " & reader("cognom1").ToString() & " (" & reader("nif").ToString() & ")")
            End If
            reader.Close()
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
        Return comboBoxDisplaySearch.ToArray()
    End Function

    Public Function ListBoxDisplayVoluntarisFromProjecte(projecte As String) As String()
        Dim listBoxDisplay As New List(Of String)
        Try
            connection.Open()
            Dim sql = "SELECT nom, cognom1, nif FROM Voluntaris V INNER JOIN VoluntariProjectes VP ON V.id_voluntari = VP.id_voluntari WHERE projecte = @projecteParam"
            Dim command As New SqlCommand(sql, connection)
            command.Parameters.AddWithValue("@projecteParam", projecte)
            Dim reader As SqlDataReader = command.ExecuteReader()
            If reader.HasRows Then
                While reader.Read()
                    listBoxDisplay.Add(reader("nom").ToString() & " " & reader("cognom1").ToString() & " (" & reader("nif").ToString() & ")")
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

    Public Function getCoordinadorDisplayFromVoluntaris(coordinador As Integer) As String
        Dim voluntariDisplay As String = ""
        Try
            connection.Open()
            Dim sql = "SELECT nom, cognom1, nif FROM Voluntaris WHERE id_voluntari = @coordinadorParam"
            Dim command As New SqlCommand(sql, connection)
            command.Parameters.AddWithValue("@coordinadorParam", coordinador)
            Dim reader As SqlDataReader = command.ExecuteReader()
            If reader.HasRows Then
                reader.Read()
                voluntariDisplay = reader("nom").ToString() & " " & reader("cognom1").ToString() & " (" & reader("nif").ToString() & ")"
            End If
            reader.Close()
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
        Return voluntariDisplay
    End Function
End Module
