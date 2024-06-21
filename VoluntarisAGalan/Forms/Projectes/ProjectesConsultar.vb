Public Class ProjectesConsultar
    Dim projecte As String = ""
    Dim projecteIndex As Integer = 0

    Private Sub ProjectesConsultar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBoxProjectes.Items.Clear()
        For Each projecte In comboBoxDisplayProjectes()
            ComboBoxProjectes.Items.Add(projecte)
        Next

        projecte = getProjectes(projecteIndex)
        WriteProjecteData(projecte)
    End Sub

    Private Sub ComboBoxProjectes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxProjectes.SelectionChangeCommitted
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
                    ComboBoxProjectes_SelectedIndexChanged(sender, e)
                    Exit For
                End If
            Next

            If ComboBoxProjectes.SelectedIndex = -1 Then
                ComboBoxProjectes.DroppedDown = True
            End If
        End If
    End Sub

    Public Function WriteProjecteData(projecte As String)
        For Each control As Control In Me.Controls
            If TypeOf control Is TextBox Then
                DirectCast(control, TextBox).Clear()
            End If
        Next
        VoluntarisList.Items.Clear()
        TasquesList.Items.Clear()
        LabelProjecte.Text = "Projecte nº" & projecteIndex + 1

        Dim success As Boolean
        Try
            Dim projecteDataArray = getProjecteData(projecte)

            TextBoxProjecte.Text = projecteDataArray(0).ToString()
            TextBoxDefinicio.Text = projecteDataArray(1).ToString()
            TextBoxAmbit.Text = projecteDataArray(2).ToString()
            Dim coordinador As String = getCoordinadorDisplayFromVoluntaris(projecteDataArray(3))
            TextBoxCoordinador.Text = coordinador
            TextBoxIniciProjecte.Text = projecteDataArray(4).ToString()
            TextBoxFinalitzacioProjecte.Text = projecteDataArray(5).ToString()
            TextBoxLloc.Text = projecteDataArray(6).ToString()
            TextBoxMaxVoluntaris.Text = projecteDataArray(7).ToString()
            TextBoxEstat.Text = projecteDataArray(8).ToString()
            For Each voluntari In ListBoxDisplayVoluntarisFromProjecte(projecte)
                VoluntarisList.Items.Add(voluntari)
            Next
            For Each tasca In ListBoxDisplayTasquesFromProjecte(projecte)
                TasquesList.Items.Add(tasca)
            Next
            ComboBoxProjectes.SelectedIndex = projecteIndex
            success = True
        Catch ex As Exception
            Throw
        End Try
        Return success
    End Function

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