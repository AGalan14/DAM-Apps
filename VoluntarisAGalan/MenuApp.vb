Public Class MenuApp
    ReadOnly menuButtons As New List(Of PictureBox)

    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        menuButtons.Add(VoluntarisButton)
        menuButtons.Add(AmbitsButton)
        menuButtons.Add(ProjectesButton)
        menuButtons.Add(AgendaButton)

        For Each item As PictureBox In menuButtons
            AddHandler item.MouseEnter, AddressOf MenuButtonMouseEnter
            AddHandler item.MouseLeave, AddressOf MenuButtonMouseLeave
        Next
    End Sub

    Private Sub MenuButtonMouseEnter(sender As Object, e As EventArgs)
        Dim newSize As New Size(sender.Width + 10, sender.Height + 10)
        Dim newLocation As New Point(sender.Location.X - 5, sender.Location.Y - 5)
        sender.Size = newSize
        sender.Location = newLocation
    End Sub

    Private Sub MenuButtonMouseLeave(sender As Object, e As EventArgs)
        Dim newSize As New Size(sender.Width - 10, sender.Height - 10)
        Dim newLocation As New Point(sender.Location.X + 5, sender.Location.Y + 5)
        sender.Size = newSize
        sender.Location = newLocation
    End Sub

    Private Sub VoluntarisButton_Click(sender As Object, e As EventArgs) Handles VoluntarisButton.Click
        VoluntarisSelection.ShowDialog()
    End Sub

    Private Sub AmbitsButton_Click(sender As Object, e As EventArgs) Handles AmbitsButton.Click
        AmbitsCRUD.Show()
        Me.Close()
    End Sub

    Private Sub ProjectesButton_Click(sender As Object, e As EventArgs) Handles ProjectesButton.Click
        ProjectesSelection.ShowDialog()
    End Sub

    Private Sub AgendaButton_Click(sender As Object, e As EventArgs) Handles AgendaButton.Click
        GenerarInformes.Show()
        Me.Close()
    End Sub

    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or &H2000000
            Return cp
        End Get
    End Property
End Class
