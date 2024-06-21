Public Class AmbitsCRUD
    Private Sub AmbitsCRUD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each ambit In getAmbitsArrayList()
            ListBoxAmbits.Items.Add(ambit)
        Next
    End Sub

    Private Sub AfegirAmbit(sender As Object, e As EventArgs) Handles AddAmbit.Click
        Dim addAmbit As String = InputBox("", "Insereix un nou Àmbit", "Nom de l'àmbit")

        If checkIfAmbitExists(addAmbit) = True Then
            MessageBox.Show("L'Àmbit introduït ja existeix.", "Error", MessageBoxButtons.OK)
            Exit Sub
        End If

        If addAmbit <> "" Then
            InsertAmbit(addAmbit)
            ListBoxAmbits.Items.Clear()
            Dim llistaAmbits = getAmbitsArrayList()
            For Each ambit As String In llistaAmbits
                Me.ListBoxAmbits.Items.Add(ambit)
            Next
        End If
    End Sub

    Private Sub EliminarAmbit(sender As Object, e As EventArgs) Handles RemoveAmbit.Click
        If ListBoxAmbits.SelectedItems.Count > 0 Then
            For Each selectedAmbit In ListBoxAmbits.SelectedItems
                If IsAmbitLinkedBeforeDeleting(selectedAmbit) Then
                    Dim result As DialogResult = MessageBox.Show("Segur que vols eliminar? Hi han voluntaris afegits a aquest Àmbit", "Eliminar Àmbit", MessageBoxButtons.YesNo)
                    If result = DialogResult.Yes Then
                        deleteLinkedAmbit(selectedAmbit)
                    ElseIf result = DialogResult.No Then
                        Exit Sub
                    End If
                End If
                deleteAmbit(selectedAmbit)
            Next
        End If
        ListBoxAmbits.Items.Clear()
        Dim llistaAmbits = getAmbitsArrayList()
        For Each ambit As String In llistaAmbits
            Me.ListBoxAmbits.Items.Add(ambit)
        Next
    End Sub

    Private Sub BtnMouseEnter(sender As Object, e As EventArgs) Handles tornarMenuBtn.MouseEnter
        sender.Size = New Size(sender.Width + 10, sender.Height + 10)
        sender.Location = New Point(sender.Location.X - 5, sender.Location.Y - 5)
    End Sub

    Private Sub BtnMouseLeave(sender As Object, e As EventArgs) Handles tornarMenuBtn.MouseLeave
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