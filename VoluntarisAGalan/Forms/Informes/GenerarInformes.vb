Imports System.IO
Imports System.Windows.Forms.DataVisualization.Charting
Imports iTextSharp.text
Imports iTextSharp.text.pdf

Public Class GenerarInformes
    Dim pdfFileName As String = ""

    Private Sub GenerarInformes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each informe In getInformesArrayList()
            ComboBoxInformes.Items.Add(informe)
        Next
    End Sub

    Private Sub ComboBoxInformes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxInformes.SelectedIndexChanged
        ChartGrafiques.Visible = True
        imprimirPDFBtn.Visible = True
        ChartGrafiques.Series.Clear()

        If ComboBoxInformes.SelectedIndex = 0 Then
            ChartGrafiques.Series.Add("Voluntaris")
            ChartGrafiques.Series.Add("Projectes")

            For Each yearOfCreationVoluntari In GetVoluntarisYearsOfCreation()
                ChartGrafiques.Series("Voluntaris").Points.AddXY(yearOfCreationVoluntari, countVoluntarisFromYear(yearOfCreationVoluntari))
            Next
            For Each yearOfCreationProjecte In getProjectesYearsOfCreation()
                ChartGrafiques.Series("Projectes").Points.AddXY(yearOfCreationProjecte, countProjectesFromYear(yearOfCreationProjecte))
            Next
            pdfFileName = "grafic_evolucio"
        ElseIf ComboBoxInformes.SelectedIndex = 1 Then
            ChartGrafiques.Series.Add("Voluntaris d'alta")
            ChartGrafiques.Series.Add("Voluntaris de baixa")
            Dim currentYear As Integer = DateTime.Now.Year

            For i = 0 To 4
                Dim yearDecreasing = currentYear - i
                ChartGrafiques.Series("Voluntaris d'alta").Points.AddXY(yearDecreasing, countVoluntarisActiuFromYear(yearDecreasing))
                ChartGrafiques.Series("Voluntaris de baixa").Points.AddXY(yearDecreasing, countVoluntarisBaixaFromYear(yearDecreasing))
            Next
            pdfFileName = "voluntaris_alta_baixa"
        ElseIf ComboBoxInformes.SelectedIndex = 2 Then
            Dim currentYear As Integer = DateTime.Now.Year
            ChartGrafiques.Series.Add("Projectes (" & currentYear & ")")
            ChartGrafiques.Series("Projectes (" & currentYear & ")").Points.AddXY(currentYear, countProjectesFromYear(currentYear))

            pdfFileName = "projectes_durant_any"
        ElseIf ComboBoxInformes.SelectedIndex = 3 Then
            Dim currentYear As Integer = DateTime.Now.Year
            ChartGrafiques.Series.Add("Projectes (" & currentYear & ")")
            For Each ambit In getAmbitsArrayList()
                ChartGrafiques.Series("Projectes (" & currentYear & ")").Points.AddXY(ambit, countProjectesFromYearAndAmbit(currentYear, ambit))
            Next

            pdfFileName = "projectes_durant_segons_ambit"
        ElseIf ComboBoxInformes.SelectedIndex = 4 Then
            Dim currentYear As Integer = DateTime.Now.Year
            ChartGrafiques.Series.Add("Voluntaris")
            For Each projecte In getProjectes()
                ChartGrafiques.Series("Voluntaris").Points.AddXY(projecte, countVoluntarisFromProjecte(projecte))
            Next

            pdfFileName = "voluntaris_participants_de_projecte"
        ElseIf ComboBoxInformes.SelectedIndex = 5 Then
            Dim currentYear As Integer = DateTime.Now.Year
            ChartGrafiques.Series.Add("Voluntaris")
            ChartGrafiques.Series("Voluntaris").Points.AddXY("Total", countVoluntaris())

            pdfFileName = "voluntaris_participants_de_projecte"
        End If
    End Sub

    Private Sub ImprimirBtn_Click(sender As Object, e As EventArgs) Handles imprimirPDFBtn.Click
        ChartGrafiques.SaveImage("chart.png", ChartImageFormat.Png)
        Dim doc As New Document(PageSize.A4)
        Dim pdfPath As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), pdfFileName & ".pdf")
        Dim writer As PdfWriter = PdfWriter.GetInstance(doc, New FileStream(pdfPath, FileMode.Create))
        doc.Open()
        Dim title As New Paragraph(ComboBoxInformes.SelectedItem.ToString())
        title.Alignment = Element.ALIGN_CENTER
        doc.Add(title)
        Dim paragraph As New Paragraph()
        paragraph.Add(Chunk.NEWLINE)
        paragraph.Add(Chunk.NEWLINE)
        doc.Add(paragraph)
        Dim img As Image = Image.GetInstance("chart.png")
        img.ScaleToFit(400, 300)
        img.Alignment = Element.ALIGN_CENTER
        doc.Add(img)
        doc.Close()
        MessageBox.Show("PDF guardat a: " & pdfPath)
    End Sub

    Private Sub BtnMouseEnter(sender As Object, e As EventArgs) Handles tornarMenuBtn.MouseEnter, imprimirPDFBtn.MouseEnter
        sender.Size = New Size(sender.Width + 10, sender.Height + 10)
        sender.Location = New Point(sender.Location.X - 5, sender.Location.Y - 5)
    End Sub

    Private Sub BtnMouseLeave(sender As Object, e As EventArgs) Handles tornarMenuBtn.MouseLeave, imprimirPDFBtn.MouseLeave
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