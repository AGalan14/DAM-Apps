Public Class VoluntarisConsultar
    Dim idVoluntari As Integer = 1

    Private Sub VoluntarisConsulta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i = 0 To getMaxIdVoluntari() - 1
            ComboBoxVoluntaris.Items.Add(comboBoxDisplayVoluntaris(i + 1))
        Next
        LabelTotalVoluntaris.Text = "Nombre de Voluntaris: " & ComboBoxVoluntaris.Items.Count()
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
        For Each control As Control In Me.Controls
            If TypeOf control Is TextBox Then
                DirectCast(control, TextBox).Clear()
            End If
            If TypeOf control Is RadioButton Then
                DirectCast(control, RadioButton).Checked = False
            End If
            If TypeOf control Is ListBox Then
                DirectCast(control, ListBox).Items.Clear()
            End If
        Next

        Dim success As Boolean = False
        Try
            Dim voluntariDataArray = getVoluntariData(voluntariId)
            Dim ambitsVoluntariDataArray = getAmbitsFromVoluntari(voluntariId)
            Dim habilitatsVoluntariDataArray = getHabilitatsFromVoluntari(voluntariId)
            Dim idiomesVoluntariDataArray = getIdiomesFromVoluntari(voluntariId)
            Dim projectesRealitzantDataArray = getProjectesRealitzantFromVoluntari(voluntariId)
            Dim projectesRealitzatsDataArray = getProjectesRealitzatsFromVoluntari(voluntariId)

            Dim assegurat, actiu As String

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
            TextBoxDataNaixement.Text = voluntariDataArray(12).ToString()
            If voluntariDataArray(13).ToString() = Motiu1.Text Then
                Motiu1.Checked = True
            ElseIf voluntariDataArray(13).ToString() = Motiu2.Text Then
                Motiu2.Checked = True
            Else Motiu3.Checked = True
            End If
            If voluntariDataArray(14) = False Then
                assegurat = "No"
            Else assegurat = "Si"
            End If
            TextBoxAssegurat.Text = assegurat

            TextBoxObservacions.Text = voluntariDataArray(15).ToString()
            TextBoxDisponibilitat.Text = voluntariDataArray(16).ToString()

            If voluntariDataArray(17) = False Then
                actiu = "No"
            Else actiu = "Si"
            End If
            TextBoxActiu.Text = actiu

            For Each ambit In ambitsVoluntariDataArray
                ListBoxAmbits.Items.Add(ambit.ToString())
            Next

            For Each habilitat In habilitatsVoluntariDataArray
                ListBoxHabilitats.Items.Add(habilitat.ToString())
            Next

            For Each idioma In idiomesVoluntariDataArray
                ListBoxIdiomes.Items.Add(idioma.ToString())
            Next

            For Each projecte In projectesRealitzantDataArray
                ListBoxProjectesRealitzant.Items.Add(projecte.ToString())
            Next

            For Each projecte In projectesRealitzatsDataArray
                ListBoxProjectesRealitzats.Items.Add(projecte.ToString())
            Next

            LabelIdVoluntari.Text = "Voluntari nº " & voluntariDataArray(0).ToString()
            TextBoxDataCreacio.Text = voluntariDataArray(1).ToString()
            ComboBoxVoluntaris.SelectedIndex = idVoluntari - 1
            If ComboBoxVoluntaris.SelectedIndex >= 0 Then
                ComboBoxVoluntaris.Text = ComboBoxVoluntaris.SelectedItem.ToString()
            End If
            success = True
        Catch ex As Exception
            Throw
        End Try
        Return success
    End Function

    Private Sub BtnMouseEnter(sender As Object, e As EventArgs) Handles tornarMenuBtn.MouseEnter, nextBtn.MouseEnter, previousBtn.MouseEnter
        sender.Size = New Size(sender.Width + 10, sender.Height + 10)
        sender.Location = New Point(sender.Location.X - 5, sender.Location.Y - 5)
    End Sub

    Private Sub BtnMouseLeave(sender As Object, e As EventArgs) Handles tornarMenuBtn.MouseLeave, nextBtn.MouseLeave, previousBtn.MouseLeave
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