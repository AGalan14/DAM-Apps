Public Class ProjectesCrear
    Dim coordinadorIndex As Integer = 0

    Private Sub ProjectesCrear_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each txtBox As Control In Me.Controls.OfType(Of TextBox)()
            txtBox.Text = ""
        Next
        ListBoxTasques.Items.Clear()
        ComboBoxCoordinador.Items.Clear()
        VoluntarisList.Items.Clear()
        ComboBoxAmbits.Items.Clear()

        iniciProjecte.MinDate = Date.Now()

        Dim llistaAmbits = getAmbitsArrayList()
        For Each ambit As String In llistaAmbits
            Me.ComboBoxAmbits.Items.Add(ambit)
        Next
    End Sub

    Private Sub VoluntarisList_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles VoluntarisList.ItemCheck
        Dim newCheckedCount = VoluntarisList.CheckedItems.Count + If(e.NewValue = CheckState.Checked, 1, 0)
        If newCheckedCount > CInt(maxVoluntaris.SelectedItem) And maxVoluntaris.Enabled And VoluntarisList.Enabled Then
            MsgBox("Sol pots afegir un màxim de " & maxVoluntaris.SelectedItem & " voluntaris.", MsgBoxStyle.Exclamation)
            e.NewValue = CheckState.Unchecked
            If coordinadorIndex <> ComboBoxCoordinador.SelectedIndex Then
                For i = 0 To VoluntarisList.Items.Count - 1
                    VoluntarisList.SetItemChecked(i, False)
                Next
                ComboBoxCoordinador.SelectedIndex = coordinadorIndex
                VoluntarisList.SetItemChecked(coordinadorIndex, True)
            End If
            Exit Sub
        End If
        coordinadorIndex = ComboBoxCoordinador.SelectedIndex
    End Sub

    Private Sub SelectedCoordinador(sender As Object, e As EventArgs) Handles ComboBoxCoordinador.SelectedIndexChanged
        If maxVoluntaris.Enabled = False Then
            coordinadorIndex = ComboBoxCoordinador.SelectedIndex
            VoluntarisList.SetItemChecked(coordinadorIndex, True)
            maxVoluntaris.Enabled = True
        Else
            VoluntarisList.SetItemChecked(ComboBoxCoordinador.SelectedIndex, True)
        End If
    End Sub

    Private Sub IniciProjecte_DateChanged(sender As Object, e As DateRangeEventArgs) Handles iniciProjecte.DateChanged
        Dim dataSeleccionada = iniciProjecte.SelectionStart
        finalitzacioProjecte.MinDate = dataSeleccionada
        finalitzacioProjecte.Enabled = True
    End Sub

    Private Sub Inscriure_Click(sender As Object, e As EventArgs) Handles crearProjecteBtn.Click
        If ComboBoxAmbits.SelectedIndex < 0 Then
            MessageBox.Show("Has de seleccionar algun Àmbit.", "Error al crear projecte", MessageBoxButtons.OK)
            Exit Sub
        End If
        If ComboBoxCoordinador.SelectedIndex < 0 Then
            MessageBox.Show("Has de seleccionar un coordinador.", "Error al crear projecte", MessageBoxButtons.OK)
            Exit Sub
        End If
        If VoluntarisList.CheckedItems.Count <= 1 Then
            MessageBox.Show("Has de seleccionar algún altre Voluntari.", "Error al crear projecte", MessageBoxButtons.OK)
            Exit Sub
        End If
        If finalitzacioProjecte.Enabled = False Or finalitzacioProjecte.SelectionStart = DateTime.MinValue Then
            MessageBox.Show("Has de seleccionar una data d'inici i finalització.", "Error al crear projecte", MessageBoxButtons.OK)
            Exit Sub
        End If
        If ListBoxTasques.Items.Count = 0 Then
            MessageBox.Show("Has d'afegir alguna tasca.", "Error al crear projecte", MessageBoxButtons.OK)
            Exit Sub
        End If
        If TextBoxProjecte.Text.Length <= 0 Or TextBoxDefinicio.Text.Length <= 0 Or TextBoxLloc.Text.Length <= 0 Then
            MessageBox.Show("Falten camps per completar.", "Error al crear projecte", MessageBoxButtons.OK)
            Exit Sub
        End If

        Dim projecte As String = TextBoxProjecte.Text
        Dim definicio_projecte As String = TextBoxDefinicio.Text
        Dim ambit As String = ComboBoxAmbits.Text
        Dim coordinador As String = ComboBoxCoordinador.SelectedItem.ToString()
        Dim nifcoordinador As String = GetNifFromComboBoxDisplay(coordinador)
        Dim idCoordinador As Integer = getIdVoluntariByNif(nifcoordinador)
        Dim voluntari_coordinador As Integer = idCoordinador
        Dim data_inici = iniciProjecte.SelectionRange.Start
        data_inici.ToString("dd/MM/yyyy")
        Dim data_finalitzacio = finalitzacioProjecte.SelectionRange.Start
        data_finalitzacio.ToString("dd/MM/yyyy")
        Dim lloc As String = TextBoxLloc.Text
        Dim nombre_voluntaris As Integer = CInt(maxVoluntaris.Text)
        Dim estat As String = "Pendent de Realitzar"

        Try
            InsertProjecte(projecte, definicio_projecte, ambit, voluntari_coordinador, data_inici, data_finalitzacio, lloc, nombre_voluntaris, estat)
            For Each i In VoluntarisList.CheckedIndices
                Dim voluntari As String = VoluntarisList.Items(i).ToString()
                Dim nifVoluntari As String = GetNifFromComboBoxDisplay(voluntari)
                Dim idVoluntari As Integer = getIdVoluntariByNif(nifVoluntari)
                InsertProjectesToVoluntari(projecte, idVoluntari)
            Next
            For Each tasca In ListBoxTasques.Items
                InsertTascaToProjecte(projecte, tasca)
            Next

            MessageBox.Show("El Projecte: [" & projecte & "] s'ha creat correctament.", "Correcte", MessageBoxButtons.OK)
            ProjectesCrear_Load(sender, e)
        Catch ex As Exception
            Debug.WriteLine("MISSATGE D'ERROR: " & ex.Message)
            Debug.WriteLine("STACK TRACE: " & ex.StackTrace)
            MessageBox.Show("Hi ha hagut un error al crear el Projecte. Si us plau, revisa les dades", "Error al crear", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub ComboBoxAmbits_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxAmbits.SelectedIndexChanged
        ComboBoxCoordinador.Enabled = True
        ComboBoxCoordinador.Items.Clear()
        ComboBoxCoordinador.Text = ""
        VoluntarisList.Items.Clear()
        Dim ambitSelected As String = ComboBoxAmbits.SelectedItem.ToString()
        For Each voluntari In comboBoxDisplayVoluntarisOfAmbit(ambitSelected)
            ComboBoxCoordinador.Items.Add(voluntari)
            VoluntarisList.Items.Add(voluntari)
        Next
        If maxVoluntaris.Enabled Then
            VoluntarisList.Enabled = False
        End If
    End Sub

    Private Sub MaxVoluntaris_SelectedIndexChanged(sender As Object, e As EventArgs) Handles maxVoluntaris.SelectedIndexChanged
        If VoluntarisList.CheckedItems.Count > CInt(maxVoluntaris.SelectedItem) Then
            For i = 0 To VoluntarisList.Items.Count - 1
                VoluntarisList.SetItemChecked(i, False)
            Next
        End If
        VoluntarisList.SetItemChecked(ComboBoxCoordinador.SelectedIndex, True)
        VoluntarisList.Enabled = True
    End Sub

    Private Sub AddTasca_Click(sender As Object, e As EventArgs) Handles AddTasca.Click
        Dim addTasca As String = InputBox("Insereix una nova tasca", "Tasca", "")

        If addTasca.Trim() <> "" Then
            ListBoxTasques.Items.Add(addTasca.Trim())
        End If
    End Sub

    Private Sub RemoveTasca_Click(sender As Object, e As EventArgs) Handles RemoveTasca.Click
        If ListBoxTasques.SelectedItems.Count > 0 Then
            ListBoxTasques.Items.RemoveAt(ListBoxTasques.SelectedIndex)
        End If
    End Sub

    Private Sub ComboBoxCoordinador_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBoxCoordinador.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            ComboBoxCoordinador.DroppedDown = True
            For i = 0 To ComboBoxCoordinador.Items.Count - 1
                If ComboBoxCoordinador.Items(i).ToString = ComboBoxCoordinador.Text Then
                    ComboBoxCoordinador.SelectedIndex = i
                    SelectedCoordinador(sender, e)
                    Exit For
                End If
            Next
        End If
    End Sub

    Private Sub BtnMouseEnter(sender As Object, e As EventArgs) Handles tornarMenuBtn.MouseEnter, crearProjecteBtn.MouseEnter
        sender.Size = New Size(sender.Width + 10, sender.Height + 10)
        sender.Location = New Point(sender.Location.X - 5, sender.Location.Y - 5)
    End Sub

    Private Sub BtnMouseLeave(sender As Object, e As EventArgs) Handles tornarMenuBtn.MouseLeave, crearProjecteBtn.MouseLeave
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