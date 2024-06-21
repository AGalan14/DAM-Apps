Public Class ProjectesSelection
    Private Sub buttonMouseEnter(sender As Object, e As EventArgs) Handles addProjecte.MouseEnter, editProjecte.MouseEnter, checkProjecte.MouseEnter
        sender.Size = New Size(sender.Width + 10, sender.Height + 10)
        sender.Location = New Point(sender.Location.X - 5, sender.Location.Y - 5)
    End Sub

    Private Sub buttonMouseLeave(sender As Object, e As EventArgs) Handles addProjecte.MouseLeave, editProjecte.MouseLeave, checkProjecte.MouseLeave
        sender.Size = New Size(sender.Width - 10, sender.Height - 10)
        sender.Location = New Point(sender.Location.X + 5, sender.Location.Y + 5)
    End Sub

    Private Sub addProjecte_Click(sender As Object, e As EventArgs) Handles addProjecte.Click
        ProjectesCrear.Show()
        Me.Close()
        MenuApp.Close()
    End Sub

    Private Sub checkProjecte_Click(sender As Object, e As EventArgs) Handles checkProjecte.Click
        ProjectesConsultar.Show()
        Me.Close()
        MenuApp.Close()
    End Sub

    Private Sub editProjecte_Click(sender As Object, e As EventArgs) Handles editProjecte.Click
        ProjectesEditar.Show()
        Me.Close()
        MenuApp.Close()
    End Sub

    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or &H2000000
            Return cp
        End Get
    End Property
End Class