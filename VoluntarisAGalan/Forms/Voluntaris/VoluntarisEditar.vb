Public Class VoluntarisEditar
    Dim idVoluntari As Integer = 1
    Dim motiuInactiu As String = ""
    Dim loadedData As Boolean = False

    Private Sub VoluntarisEditar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i = 0 To getMaxIdVoluntari() - 1
            ComboBoxVoluntaris.Items.Add(comboBoxDisplayVoluntaris(i + 1))
        Next
        WriteVoluntariData(idVoluntari)
    End Sub

    Private Sub PreviousBtn_Click(sender As Object, e As EventArgs) Handles previousBtn.Click
        If idVoluntari - 1 >= 1 Then
            idVoluntari -= 1
            WriteVoluntariData(idVoluntari)
        End If
    End Sub

    Private Sub NextBtn_Click(sender As Object, e As EventArgs) Handles nextBtn.Click
        If idVoluntari + 1 < getMaxIdVoluntari() + 1 Then
            idVoluntari += 1
            WriteVoluntariData(idVoluntari)
        End If
    End Sub

    Private Sub ComboBoxVoluntaris_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxVoluntaris.SelectionChangeCommitted
        Dim isInList As Boolean = False
        For Each voluntari In ComboBoxVoluntaris.Items
            If ComboBoxVoluntaris.Text = voluntari Then
                isInList = True
            End If
        Next

        If isInList = False Then
            Exit Sub
        End If

        idVoluntari = ComboBoxVoluntaris.SelectedIndex + 1
        WriteVoluntariData(idVoluntari)
    End Sub

    Private Sub ComboBoxVoluntaris_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBoxVoluntaris.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            For i = 0 To ComboBoxVoluntaris.Items.Count - 1
                If ComboBoxVoluntaris.Items(i).ToString = ComboBoxVoluntaris.Text Then
                    ComboBoxVoluntaris.SelectedIndex = i
                    ComboBoxVoluntaris_SelectedIndexChanged(sender, e)
                    Exit For
                End If
            Next

            If ComboBoxVoluntaris.SelectedIndex = -1 Then
                ComboBoxVoluntaris.DroppedDown = True
            End If
        End If
    End Sub

    Public Function WriteVoluntariData(voluntariId As Integer)
        loadedData = False
        For Each control As Control In Me.Controls
            If TypeOf control Is TextBox Then
                DirectCast(control, TextBox).Clear()
            End If
            If TypeOf control Is RadioButton Then
                DirectCast(control, RadioButton).Checked = False
            End If
            If TypeOf control Is CheckedListBox Then
                DirectCast(control, CheckedListBox).Items.Clear()
            End If
        Next

        Dim success As Boolean = False
        Try
            Dim voluntariDataArray = getVoluntariData(voluntariId)
            Dim ambitsVoluntariDataArray = getAmbitsFromVoluntari(voluntariId)
            Dim habilitatsVoluntariDataArray = getHabilitatsFromVoluntari(voluntariId)
            Dim idiomesVoluntariDataArray = getIdiomesFromVoluntari(voluntariId)

            TextBoxNom.Text = voluntariDataArray(2).ToString()
            TextBoxCognom1.Text = voluntariDataArray(3).ToString()
            TextBoxCognom2.Text = voluntariDataArray(4).ToString()
            TextBoxNIF.Text = voluntariDataArray(5).ToString()
            TextBoxSexe.Text = voluntariDataArray(6).ToString()
            Dim poblacio = voluntariDataArray(7).ToString()
            If poblacio.Length > 1 Then
                TextBoxCodiPostal.Text = poblacio.Substring(0, 5)
                TextBoxPoblacio.Text = poblacio.Substring(5).Trim()
            End If
            TextBoxAdreca.Text = voluntariDataArray(8).ToString()
            TextBoxEmail.Text = voluntariDataArray(9).ToString()
            TextBoxTel1.Text = FormatTelefon(voluntariDataArray(10))
            TextBoxTel2.Text = FormatTelefon(voluntariDataArray(11))
            Dim dataNaixement = DateTime.ParseExact(voluntariDataArray(12), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture)
            naixementCalendari.SelectionStart = dataNaixement
            If voluntariDataArray(13).ToString() = Motiu1.Text Then
                Motiu1.Checked = True
            ElseIf voluntariDataArray(13).ToString() = Motiu2.Text Then
                Motiu2.Checked = True
            Else Motiu3.Checked = True
            End If

            checkBoxAssegurat.Checked = voluntariDataArray(14)

            TextBoxObservacions.Text = voluntariDataArray(15).ToString()
            TextBoxDisponibilitat.Text = voluntariDataArray(16).ToString()

            CheckBoxActiu.Checked = voluntariDataArray(17)
            If voluntariDataArray(18) = "" Then
                TextBoxMotiuInactiu.Enabled = False
            Else
                TextBoxMotiuInactiu.Enabled = True
                TextBoxMotiuInactiu.Text = voluntariDataArray(18)
            End If

            Dim llistaAmbits = getAmbitsArrayList()
            For Each ambit As String In llistaAmbits
                Me.AmbitsList.Items.Add(ambit)
            Next
            For i As Integer = 0 To AmbitsList.Items.Count - 1
                Dim ambit As String = AmbitsList.Items(i).ToString
                If getAmbitsFromVoluntari(idVoluntari).Any(Function(ambitFromVoluntari) ambitFromVoluntari = ambit) Then
                    AmbitsList.SetItemChecked(i, True)
                End If
            Next

            Dim llistaHabilitats = getHabilitatsArrayList()
            For Each habilitat As String In llistaHabilitats
                Me.HabilitatsList.Items.Add(habilitat)
            Next
            For i As Integer = 0 To HabilitatsList.Items.Count - 1
                Dim habilitat As String = HabilitatsList.Items(i).ToString
                If getHabilitatsFromVoluntari(idVoluntari).Any(Function(habilitatFromVoluntari) habilitatFromVoluntari = habilitat) Then
                    HabilitatsList.SetItemChecked(i, True)
                End If
            Next

            Dim llistaIdiomes = getIdiomesArrayList()
            For Each idioma As String In llistaIdiomes
                Me.IdiomesList.Items.Add(idioma)
            Next
            For i As Integer = 0 To IdiomesList.Items.Count - 1
                Dim idioma As String = IdiomesList.Items(i).ToString
                If getIdiomesFromVoluntari(idVoluntari).Any(Function(idiomaFromVoluntari) idiomaFromVoluntari = idioma) Then
                    IdiomesList.SetItemChecked(i, True)
                End If
            Next

            LabelIdVoluntari.Text = "Voluntari nº " & voluntariDataArray(0).ToString()
            ComboBoxVoluntaris.SelectedIndex = idVoluntari - 1
            If ComboBoxVoluntaris.SelectedIndex >= 0 Then
                ComboBoxVoluntaris.Text = ComboBoxVoluntaris.SelectedItem.ToString()
            End If
            loadedData = True
            success = True
        Catch ex As Exception
            Throw
        End Try
        Return success
    End Function

    Private Sub editVoluntariBtn_Click(sender As Object, e As EventArgs) Handles editVoluntariBtn.Click
        Dim data_inscripcio = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
        Dim nom = TextBoxNom.Text
        Dim cognom1 = TextBoxCognom1.Text
        Dim cognom2 = TextBoxCognom2.Text
        Dim nif = TextBoxNIF.Text
        Dim sexe = TextBoxSexe.Text
        Dim poblacio = TextBoxCodiPostal.Text + " " + TextBoxPoblacio.Text
        Dim adreca = TextBoxAdreca.Text
        Dim email = TextBoxEmail.Text
        Dim tel1 = Val(TextBoxTel1.Text)
        Dim tel2 = Val(TextBoxTel2.Text)
        Dim data_naixement = naixementCalendari.SelectionRange.Start
        data_naixement.ToString("dd/MM/yyyy")
        Dim motiu As String
        If Motiu1.Checked Then
            motiu = Motiu1.Text
        ElseIf Motiu2.Checked Then
            motiu = Motiu2.Text
        Else motiu = Motiu3.Text
        End If
        Dim assegurat As Boolean = checkBoxAssegurat.Checked
        Dim observacions = TextBoxObservacions.Text
        Dim disponibilitat = TextBoxDisponibilitat.Text
        Dim actiu As Boolean = CheckBoxActiu.Checked
        Dim motiu_inactiu As String = ""
        If CheckBoxActiu.Checked = False Then
            motiu_inactiu = TextBoxMotiuInactiu.Text
        End If

        If TextBoxNIF.TextLength < 9 Then
            MessageBox.Show("Has d'escriure un NIF", "Error al inscriure", MessageBoxButtons.OK)
            Exit Sub
        End If
        If checkIfNifExists(nif) = True And checkIfNifIsFromVoluntari(nif, idVoluntari) = False Then
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
            editVoluntari(idVoluntari, data_inscripcio, nom, cognom1, cognom2, nif, sexe, poblacio, adreca, email, tel1, tel2, data_naixement, motiu, assegurat, observacions, disponibilitat, actiu, motiu_inactiu)

            deleteAllAmbitsFromVoluntari(idVoluntari)
            For Each selectedAmbit In AmbitsList.CheckedItems
                InsertAmbitsToVoluntari(idVoluntari, selectedAmbit.ToString())
            Next
            deleteAllHabilitatsFromVoluntari(idVoluntari)
            For Each selectedHabilitat In HabilitatsList.CheckedItems
                InsertHabilitatsToVoluntari(idVoluntari, selectedHabilitat.ToString())
            Next
            DeleteAllIdiomesFromVoluntari(idVoluntari)
            For Each selectedIdioma In IdiomesList.CheckedItems
                InsertIdiomesToVoluntari(idVoluntari, selectedIdioma.ToString())
            Next

            MessageBox.Show("Voluntari editat correctament.", "Correcte", MessageBoxButtons.OK)
            VoluntarisEditar_Load(sender, e)
        Catch ex As Exception
            Debug.WriteLine("MISSATGE D'ERROR: " & ex.Message)
            Debug.WriteLine("STACK TRACE: " & ex.StackTrace)
            MessageBox.Show("Hi ha hagut un error al editar el Voluntari. Si us plau, revisa les dades", "Error al editar", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub AfegirHabilitat(sender As Object, e As EventArgs) Handles addHabilitat.Click
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

    Private Sub EliminarHabilitat(sender As Object, e As EventArgs) Handles removeHabilitat.Click
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

    Private Sub CheckBoxActiu_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxActiu.CheckedChanged
        If loadedData Then
            If CheckBoxActiu.CheckState = CheckState.Checked Then
                motiuInactiu = ""
                TextBoxMotiuInactiu.Enabled = False
                TextBoxMotiuInactiu.Text = ""
            End If
            If CheckBoxActiu.CheckState = CheckState.Unchecked Then
                Dim inputMotiuInactiu = InputBox("Quin és el motiu de l'inactivitat?", "Motiu Inactivitat", "")
                If inputMotiuInactiu <> "" Then
                    motiuInactiu = inputMotiuInactiu
                    TextBoxMotiuInactiu.Enabled = True
                    TextBoxMotiuInactiu.Text = motiuInactiu
                Else
                    motiuInactiu = ""
                    Exit Sub
                End If
            End If
        End If
    End Sub

    Private Sub TextBoxTel_OnlyNumbers(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub BtnMouseEnter(sender As Object, e As EventArgs) Handles tornarMenuBtn.MouseEnter, editVoluntariBtn.MouseEnter, nextBtn.MouseEnter, previousBtn.MouseEnter
        sender.Size = New Size(sender.Width + 10, sender.Height + 10)
        sender.Location = New Point(sender.Location.X - 5, sender.Location.Y - 5)
    End Sub

    Private Sub BtnMouseLeave(sender As Object, e As EventArgs) Handles tornarMenuBtn.MouseLeave, editVoluntariBtn.MouseLeave, nextBtn.MouseLeave, previousBtn.MouseLeave
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