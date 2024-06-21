Public Class VoluntarisInscripcio
    Private Sub VInscripcio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each txtBox As Control In Me.Controls.OfType(Of TextBox)()
            txtBox.Text = ""
        Next

        CheckBoxAssegurat.Checked = False

        For Each rButton In Me.Controls.OfType(Of RadioButton)()
            rButton.Checked = False
        Next

        Me.AmbitsList.Items.Clear()
        Me.HabilitatsList.Items.Clear()
        Me.IdiomesList.Items.Clear()

        naixementCalendari.MaxDate = DateTime.Now()

        Dim llistaAmbits = getAmbitsArrayList()
        For Each ambit As String In llistaAmbits
            Me.AmbitsList.Items.Add(ambit)
        Next

        Dim llistaHabilitats = getHabilitatsArrayList()
        For Each habilitat As String In llistaHabilitats
            Me.HabilitatsList.Items.Add(habilitat)
        Next

        Dim llistaIdiomes = getIdiomesArrayList()
        For Each idioma As String In llistaIdiomes
            Me.IdiomesList.Items.Add(idioma)
        Next
    End Sub

    Private Sub Inscriure_Voluntari(sender As Object, e As EventArgs) Handles addVoluntariBtn.Click
        Dim data_inscripcio = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
        Dim nom = TextBoxNom.Text
        Dim cognom1 = TextBoxCognom1.Text
        Dim cognom2 = TextBoxCognom2.Text
        Dim nif = TextBoxNIF.Text
        Dim sexe = TextBoxSexe.Text
        Dim poblacio = TextBoxCodiPostal.Text + " " + TextBoxPoblacio.Text
        Dim adreca = TextBoxAdreca.Text
        Dim email = TextBoxEmail.Text
        Dim tel1 = Val(TextBoxTel1.Text.Replace(" ", ""))
        Dim tel2 = Val(TextBoxTel2.Text.Replace(" ", ""))
        Dim data_naixement = naixementCalendari.SelectionRange.Start
        data_naixement.ToString("dd/MM/yyyy")
        Dim motiu As String
        If Motiu1.Checked Then
            motiu = Motiu1.Text
        ElseIf Motiu2.Checked Then
            motiu = Motiu2.Text
        Else motiu = Motiu3.Text
        End If
        Dim assegurat As Boolean = CheckBoxAssegurat.Checked
        Dim observacions = TextBoxObservacions.Text
        Dim disponibilitat = TextBoxDisponibilitat.Text
        Dim actiu As Boolean = True

        If TextBoxNIF.TextLength < 9 Then
            MessageBox.Show("Has d'escriure un NIF", "Error al inscriure", MessageBoxButtons.OK)
            Exit Sub
        End If
        If checkIfNifExists(nif) = True Then
            MessageBox.Show("Aquest NIF (" & nif & ") ja està afegit a un voluntari", "Error al inscriure", MessageBoxButtons.OK)
            Exit Sub
        End If
        If tel1.ToString().Length() <> 9 And tel1.ToString().Length() > 1 Or tel2.ToString().Length() <> 9 And tel2.ToString().Length() > 1 Then
            MessageBox.Show("Els números de telèfon han d'estar formats per 9 dígits", "Error al inscriure", MessageBoxButtons.OK)
            Exit Sub
        End If
        If AmbitsList.CheckedItems.Count < 1 Then
            MessageBox.Show("Has de seleccionar algun àmbit.", "Error al inscriure", MessageBoxButtons.OK)
            Exit Sub
        End If
        If HabilitatsList.CheckedItems.Count < 1 Then
            MessageBox.Show("Has de seleccionar alguna habilitat.", "Error al inscriure", MessageBoxButtons.OK)
            Exit Sub
        End If

        Try
            InsertVoluntari(data_inscripcio, nom, cognom1, cognom2, nif, sexe, poblacio, adreca, email, tel1, tel2, data_naixement, motiu, assegurat, observacions, disponibilitat, actiu, "")

            Dim idVoluntari As Integer = getIdVoluntariByNif(nif)
            For Each selectedAmbit In AmbitsList.CheckedItems
                InsertAmbitsToVoluntari(idVoluntari, selectedAmbit.ToString)
            Next

            For Each selectedHabilitats In HabilitatsList.CheckedItems
                InsertHabilitatsToVoluntari(idVoluntari, selectedHabilitats.ToString)
            Next

            For Each selectedIdiomes In IdiomesList.CheckedItems
                InsertIdiomesToVoluntari(idVoluntari, selectedIdiomes.ToString)
            Next

            MessageBox.Show("Voluntari afegit correctament.", "Correcte", MessageBoxButtons.OK)
            VInscripcio_Load(sender, e)
        Catch ex As Exception
            Debug.WriteLine("MISSATGE D'ERROR: " & ex.Message)
            Debug.WriteLine("STACK TRACE: " & ex.StackTrace)
            MessageBox.Show("Hi ha hagut un error al inscriure el voluntari. Si us plau, revisa les dades", "Error al inscriure", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub AfegirHabilitat(sender As Object, e As EventArgs) Handles AddHabilitat.Click
        Dim addHabilitat As String = InputBox("", "Insereix una nova habilitat", "Nom de l'habilitat")

        If checkIfHabilitatExists(addHabilitat) = True Then
            MessageBox.Show("L'Habilitat introduïda ja existeix.", "Error", MessageBoxButtons.OK)
            Exit Sub
        End If

        If addHabilitat <> "" Then
            InsertHabilitat(addHabilitat)
            HabilitatsList.Items.Clear()
            Dim llistaHabilitats = getHabilitatsArrayList()
            For Each habilitat As String In llistaHabilitats
                Me.HabilitatsList.Items.Add(habilitat)
            Next
        End If
    End Sub

    Private Sub AfegirIdioma(sender As Object, e As EventArgs) Handles addIdioma.Click
        Dim addIdioma As String = InputBox("", "Idioma a afegir", "Nou idioma")

        If checkIfIdiomaExists(addIdioma) = True Then
            MessageBox.Show("L'Idioma introduït ja existeix.", "Error", MessageBoxButtons.OK)
            Exit Sub
        End If

        If addIdioma <> "" Then
            InsertIdioma(addIdioma)
            IdiomesList.Items.Clear()
            Dim llistaIdiomes = getIdiomesArrayList()
            For Each idioma As String In llistaIdiomes
                Me.IdiomesList.Items.Add(idioma)
            Next
        End If
    End Sub

    Private Sub EliminarHabilitat(sender As Object, e As EventArgs) Handles RemoveHabilitat.Click
        If HabilitatsList.SelectedItems.Count > 0 Then
            For Each selectedHabilitat In HabilitatsList.SelectedItems
                If IsHabilitatLinkedBeforeDeleting(selectedHabilitat) Then
                    Dim result As DialogResult = MessageBox.Show("Segur que vols eliminar? Hi han voluntaris amb aquesta Habilitat", "Eliminar Habilitat", MessageBoxButtons.YesNo)
                    If result = DialogResult.Yes Then
                        deleteLinkedHabilitat(selectedHabilitat)
                    ElseIf result = DialogResult.No Then
                        Exit Sub
                    End If
                End If
                deleteHabilitat(selectedHabilitat)
            Next
        End If
        HabilitatsList.Items.Clear()
        Dim llistaHabilitats = getHabilitatsArrayList()
        For Each habilitat As String In llistaHabilitats
            Me.HabilitatsList.Items.Add(habilitat)
        Next
    End Sub

    Private Sub EliminarIdioma(sender As Object, e As EventArgs) Handles removeIdioma.Click
        If IdiomesList.SelectedItems.Count > 0 Then
            For Each selectedIdioma In IdiomesList.SelectedItems
                If IsIdiomaLinkedBeforeDeleting(selectedIdioma) Then
                    Dim result As DialogResult = MessageBox.Show("Segur que vols eliminar? Hi han voluntaris amb aquest idioma", "Eliminar Idioma", MessageBoxButtons.YesNo)
                    If result = DialogResult.Yes Then
                        deleteLinkedIdioma(selectedIdioma)
                    ElseIf result = DialogResult.No Then
                        Exit Sub
                    End If
                End If
                deleteIdioma(selectedIdioma)
            Next
        End If
        IdiomesList.Items.Clear()
        Dim llistaIdiomes = getIdiomesArrayList()
        For Each idioma As String In llistaIdiomes
            Me.IdiomesList.Items.Add(idioma)
        Next
    End Sub

    Private Sub TextBox_OnlyNumbers(sender As Object, e As KeyPressEventArgs) Handles TextBoxTel1.KeyPress, TextBoxTel2.KeyPress, TextBoxCodiPostal.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Or e.KeyChar = Chr(32)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub BtnMouseEnter(sender As Object, e As EventArgs) Handles tornarMenuBtn.MouseEnter, addVoluntariBtn.MouseEnter
        sender.Size = New Size(sender.Width + 10, sender.Height + 10)
        sender.Location = New Point(sender.Location.X - 5, sender.Location.Y - 5)
    End Sub

    Private Sub BtnMouseLeave(sender As Object, e As EventArgs) Handles tornarMenuBtn.MouseLeave, addVoluntariBtn.MouseLeave
        sender.Size = New Size(sender.Width - 10, sender.Height - 10)
        sender.Location = New Point(sender.Location.X + 5, sender.Location.Y + 5)
    End Sub

    Private Sub TornarMenu(sender As Object, e As EventArgs) Handles tornarMenuBtn.Click
        Application.Restart()
    End Sub

    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or &H2000000
            Return cp
        End Get
    End Property
End Class