Public Class VoluntarisSelection
    Private Sub buttonMouseEnter(sender As Object, e As EventArgs) Handles addVoluntari.MouseEnter, editVoluntari.MouseEnter, checkVoluntari.MouseEnter
        sender.Size = New Size(sender.Width + 10, sender.Height + 10)
        sender.Location = New Point(sender.Location.X - 5, sender.Location.Y - 5)
    End Sub

    Private Sub buttonMouseLeave(sender As Object, e As EventArgs) Handles addVoluntari.MouseLeave, editVoluntari.MouseLeave, checkVoluntari.MouseLeave
        sender.Size = New Size(sender.Width - 10, sender.Height - 10)
        sender.Location = New Point(sender.Location.X + 5, sender.Location.Y + 5)
    End Sub

    Private Sub addVoluntari_Click(sender As Object, e As EventArgs) Handles addVoluntari.Click
        VoluntarisInscripcio.Show()
        Me.Close()
        MenuApp.Close()
    End Sub

    Private Sub checkVoluntari_Click(sender As Object, e As EventArgs) Handles checkVoluntari.Click
        VoluntarisConsultar.Show()
        Me.Close()
        MenuApp.Close()
    End Sub

    Private Sub editVoluntari_Click(sender As Object, e As EventArgs) Handles editVoluntari.Click
        VoluntarisEditar.Show()
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