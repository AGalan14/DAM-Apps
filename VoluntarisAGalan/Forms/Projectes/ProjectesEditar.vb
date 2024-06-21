Public Class ProjectesEditar
    Dim projecte As String = ""
    Dim og_projecte As String = ""
    Dim projecteIndex As Integer = 0
    Dim coordinadorIndex As Integer = 0
    Dim loadedProjecteData As Boolean = False
    Dim projecteDescartat As Boolean = False

    Private Sub ProjectesEditar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBoxProjectes.Items.Clear()
        For Each projecte In comboBoxDisplayProjectes()
            ComboBoxProjectes.Items.Add(projecte)
        Next

        Dim llistaAmbits = getAmbitsArrayList()
        For Each ambit As String In llistaAmbits
            Me.ComboBoxAmbits.Items.Add(ambit)
        Next

        projecte = getProjectes(projecteIndex)
        WriteProjecteData(projecte)
    End Sub

    Private Sub VoluntarisList_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles VoluntarisList.ItemCheck
        Dim newCheckedCount = VoluntarisList.CheckedItems.Count + If(e.NewValue = CheckState.Checked, 1, 0)
        If newCheckedCount > Val(maxVoluntaris.SelectedItem) And loadedProjecteData Then
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

    Private Sub ComboBoxProjectesEditar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxProjectes.SelectionChangeCommitted
        Dim isInList As Boolean = False
        For Each projecte In ComboBoxProjectes.Items
            If ComboBoxProjectes.Text = projecte Then
                isInList = True
            End If
        Next

        If isInList = False Then
            Exit Sub
        End If

        Dim projecteComboBox As String = GetProjecteFromComboBox(ComboBoxProjectes.SelectedItem.ToString())
        projecteIndex = ComboBoxProjectes.SelectedIndex
        WriteProjecteData(projecteComboBox)
    End Sub

    Private Sub ComboBoxProjectes_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBoxProjectes.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            For i = 0 To ComboBoxProjectes.Items.Count - 1
                If ComboBoxProjectes.Items(i).ToString = ComboBoxProjectes.Text Then
                    ComboBoxProjectes.SelectedIndex = i
                    ComboBoxProjectesEditar_SelectedIndexChanged(sender, e)
                    Exit For
                End If
            Next

            If ComboBoxProjectes.SelectedIndex = -1 Then
                ComboBoxProjectes.DroppedDown = True
            End If
        End If
    End Sub

    Private Sub ComboBoxCoordinador_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxCoordinador.SelectedIndexChanged
        Dim isInList As Boolean = False
        For Each coordinador In ComboBoxCoordinador.Items
            If ComboBoxCoordinador.Text = coordinador Then
                isInList = True
            End If
        Next

        If isInList = False Then
            Exit Sub
        End If

        If loadedProjecteData Then
            coordinadorIndex = ComboBoxCoordinador.SelectedIndex
            VoluntarisList.SetItemChecked(coordinadorIndex, True)
            VoluntarisList.Enabled = True
        End If
    End Sub

    Private Sub ComboBoxCoordinador_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBoxCoordinador.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            For i = 0 To ComboBoxCoordinador.Items.Count - 1
                If ComboBoxCoordinador.Items(i).ToString = ComboBoxCoordinador.Text Then
                    ComboBoxCoordinador.SelectedIndex = i
                    ComboBoxCoordinador_SelectedIndexChanged(sender, e)
                    Exit For
                End If
            Next

            If ComboBoxCoordinador.SelectedIndex = -1 Then
                ComboBoxCoordinador.DroppedDown = True
            End If
        End If
    End Sub

    Public Function WriteProjecteData(projecte As String)
        loadedProjecteData = False
        projecteDescartat = False
        For Each control As Control In Me.Controls
            If TypeOf control Is TextBox Then
                DirectCast(control, TextBox).Clear()
            End If
        Next
        ComboBoxCoordinador.Items.Clear()
        VoluntarisList.Items.Clear()
        TasquesList.Items.Clear()
        iniciProjecte.MinDate = DateTime.ParseExact("01/01/1753", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture)
        iniciProjecte.MaxDate = DateTime.ParseExact("31/12/9998", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture)
        finalitzacioProjecte.MinDate = DateTime.ParseExact("01/01/1753", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture)
        finalitzacioProjecte.MaxDate = DateTime.ParseExact("31/12/9998", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture)
        LabelProjecte.Text = "Projecte nº" & projecteIndex + 1

        Dim success As Boolean
        Try
            Dim projecteDataArray = getProjecteData(projecte)
            og_projecte = projecte

            TextBoxProjecte.Text = projecteDataArray(0).ToString()
            TextBoxDefinicio.Text = projecteDataArray(1).ToString()
            iniciProjecte.SelectionStart = DateTime.ParseExact(projecteDataArray(4), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture)
            finalitzacioProjecte.SelectionStart = DateTime.ParseExact(projecteDataArray(5), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture)
            TextBoxLloc.Text = projecteDataArray(6).ToString()
            TextBoxEstat.Text = projecteDataArray(8).ToString()
            ComboBoxAmbits.SelectedItem = projecteDataArray(2).ToString()
            maxVoluntaris.SelectedItem = projecteDataArray(7).ToString()

            For Each tasca In ListBoxDisplayTasquesFromProjecte(projecte)
                TasquesList.Items.Add(tasca)
            Next

            For Each voluntari In comboBoxDisplayVoluntarisOfAmbit(projecteDataArray(2).ToString())
                ComboBoxCoordinador.Items.Add(voluntari)
                VoluntarisList.Items.Add(voluntari)
            Next

            Dim coordinador As String = getCoordinadorDisplayFromVoluntaris(projecteDataArray(3))
            ComboBoxCoordinador.SelectedItem = coordinador
            coordinadorIndex = ComboBoxCoordinador.SelectedIndex

            For i = 0 To VoluntarisList.Items.Count() - 1
                For Each voluntari In ListBoxDisplayVoluntarisFromProjecte(projecte)
                    If VoluntarisList.Items(i) = voluntari Then
                        VoluntarisList.SetItemChecked(i, True)
                    End If
                Next
            Next
            VoluntarisList.SetItemChecked(coordinadorIndex, True)

            ComboBoxProjectes.SelectedIndex = projecteIndex
            loadedProjecteData = True
            success = True
        Catch ex As Exception
            Throw
        End Try
        Return success
    End Function

    Private Sub editProjecteBtn_Click(sender As Object, e As EventArgs) Handles editProjecteBtn.Click
        Dim projecte As String = TextBoxProjecte.Text
        Dim definicio_projecte As String = TextBoxDefinicio.Text
        Dim ambit As String = ComboBoxAmbits.SelectedItem.ToString()
        Dim coordinador As String = ComboBoxCoordinador.SelectedItem.ToString()
        Dim nifCoordinador As String = GetNifFromComboBoxDisplay(coordinador)
        Dim idCoordinador As Integer = getIdVoluntariByNif(nifCoordinador)
        Dim voluntari_coordinador As Integer = idCoordinador
        Dim data_inici = iniciProjecte.SelectionRange.Start
        data_inici.ToString("dd/MM/yyyy")
        Dim data_finalitzacio = finalitzacioProjecte.SelectionRange.Start
        data_finalitzacio.ToString("dd/MM/yyyy")
        Dim lloc As String = TextBoxLloc.Text
        Dim nombre_voluntaris As Integer = Val(maxVoluntaris.SelectedItem)
        Dim estat As String = TextBoxEstat.Text

        Try
            deleteAllVoluntarisFromProjecte(og_projecte)
            deleteAllTasquesFromProjecte(og_projecte)
            editProjecte(og_projecte, projecte, definicio_projecte, ambit, voluntari_coordinador, data_inici, data_finalitzacio, lloc, nombre_voluntaris, estat)

            For Each tasca In TasquesList.Items
                InsertTascaToProjecte(projecte, tasca)
            Next

            For Each voluntari In VoluntarisList.CheckedItems
                Dim nifVoluntari As String = GetNifFromComboBoxDisplay(voluntari)
                Dim idVoluntari As Integer = getIdVoluntariByNif(nifVoluntari)
                InsertProjectesToVoluntari(projecte, idVoluntari)
            Next

            MessageBox.Show("Projecte editat correctament.", "Correcte", MessageBoxButtons.OK)
            ProjectesEditar_Load(sender, e)
        Catch ex As Exception
            Debug.WriteLine("MISSATGE D'ERROR: " & ex.Message)
            Debug.WriteLine("STACK TRACE: " & ex.StackTrace)
            MessageBox.Show("Hi ha hagut un error al editar el Projecte. Si us plau, revisa les dades", "Error al editar", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub SelectedCoordinador(sender As Object, e As EventArgs) Handles ComboBoxCoordinador.SelectionChangeCommitted
        If loadedProjecteData = True Then
            If maxVoluntaris.Enabled = False Then
                coordinadorIndex = ComboBoxCoordinador.SelectedIndex
                VoluntarisList.SetItemChecked(coordinadorIndex, True)
                maxVoluntaris.Enabled = True
            Else
                VoluntarisList.SetItemChecked(ComboBoxCoordinador.SelectedIndex, True)
            End If
        End If
    End Sub

    Private Sub ComboBoxAmbits_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxAmbits.SelectedIndexChanged
        If loadedProjecteData = True Then
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
        End If
    End Sub

    Private Sub MaxVoluntaris_SelectedIndexChanged(sender As Object, e As EventArgs) Handles maxVoluntaris.SelectedIndexChanged
        If loadedProjecteData = True Then
            If VoluntarisList.CheckedItems.Count > CInt(maxVoluntaris.SelectedItem) Then
                For i = 0 To VoluntarisList.Items.Count - 1
                    VoluntarisList.SetItemChecked(i, False)
                Next
            End If
            VoluntarisList.SetItemChecked(ComboBoxCoordinador.SelectedIndex, True)
            VoluntarisList.Enabled = True
        End If
    End Sub

    Private Sub IniciProjecte_DateChanged(sender As Object, e As DateRangeEventArgs) Handles iniciProjecte.DateChanged
        If loadedProjecteData Then
            Dim dataSeleccionada = iniciProjecte.SelectionStart
            finalitzacioProjecte.MinDate = dataSeleccionada

            Dim currentDate = Date.Now()
            Dim data_inici = iniciProjecte.SelectionRange.Start.ToString("dd/MM/yyyy")
            Dim data_finalitzacio = finalitzacioProjecte.SelectionRange.Start.ToString("dd/MM/yyyy")
            If data_inici > currentDate Then
                TextBoxEstat.Text = "Pendent de Realitzar"
            ElseIf data_finalitzacio < currentDate Then
                TextBoxEstat.Text = "Finalitzat"
            ElseIf currentDate > data_inici And currentDate < data_finalitzacio Then
                TextBoxEstat.Text = "En vigor"
            End If
        End If
    End Sub

    Private Sub FinalitzacioProjecte_DateChanged(sender As Object, e As DateRangeEventArgs) Handles finalitzacioProjecte.DateChanged
        If loadedProjecteData Then
            Dim dataSeleccionada = finalitzacioProjecte.SelectionStart
            iniciProjecte.MaxDate = dataSeleccionada

            Dim currentDate = Date.Now()
            Dim data_inici = iniciProjecte.SelectionRange.Start.ToString("dd/MM/yyyy")
            Dim data_finalitzacio = finalitzacioProjecte.SelectionRange.Start.ToString("dd/MM/yyyy")
            If data_inici > currentDate Then
                TextBoxEstat.Text = "Pendent de Realitzar"
            ElseIf data_finalitzacio < currentDate Then
                TextBoxEstat.Text = "Finalitzat"
            ElseIf currentDate > data_inici And currentDate < data_finalitzacio Then
                TextBoxEstat.Text = "En vigor"
            End If
        End If
    End Sub

    Private Sub AddTasca_Click(sender As Object, e As EventArgs) Handles AddTasca.Click
        Dim addTasca As String = InputBox("Insereix una nova tasca", "Tasca", "")

        If addTasca.Trim() <> "" Then
            TasquesList.Items.Add(addTasca.Trim())
        End If
    End Sub

    Private Sub RemoveTasca_Click(sender As Object, e As EventArgs) Handles RemoveTasca.Click
        If TasquesList.SelectedItems.Count > 0 Then
            TasquesList.Items.RemoveAt(TasquesList.SelectedIndex)
        End If
    End Sub

    Private Sub PreviousBtn_Click(sender As Object, e As EventArgs) Handles previousBtn.Click
        If projecteIndex - 1 >= 0 Then
            projecteIndex -= 1
            projecte = getProjectes(projecteIndex)
            WriteProjecteData(projecte)
        End If
    End Sub

    Private Sub NextBtn_Click(sender As Object, e As EventArgs) Handles nextBtn.Click
        If projecteIndex + 1 < getMaxProjectesNum() Then
            projecteIndex += 1
            projecte = getProjectes(projecteIndex)
            WriteProjecteData(projecte)
        End If
    End Sub

    Private Sub DescartarBtn_Click(sender As Object, e As EventArgs) Handles DescartarBtn.Click
        Dim result As DialogResult = MessageBox.Show("Segur que vols descartar el Projecte? (Es desarà com Descartat)", "Descartar Projecte", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            TextBoxEstat.Text = "Descartat"
            projecteDescartat = True
        ElseIf result = DialogResult.No Then
            Exit Sub
        End If
    End Sub

    Private Sub BtnMouseEnter(sender As Object, e As EventArgs) Handles tornarMenuBtn.MouseEnter, editProjecteBtn.MouseEnter, DescartarBtn.MouseEnter, nextBtn.MouseEnter, previousBtn.MouseEnter
        sender.Size = New Size(sender.Width + 10, sender.Height + 10)
        sender.Location = New Point(sender.Location.X - 5, sender.Location.Y - 5)
    End Sub

    Private Sub BtnMouseLeave(sender As Object, e As EventArgs) Handles tornarMenuBtn.MouseLeave, editProjecteBtn.MouseLeave, DescartarBtn.MouseLeave, nextBtn.MouseLeave, previousBtn.MouseLeave
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