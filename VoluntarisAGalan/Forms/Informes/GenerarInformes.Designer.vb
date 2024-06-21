<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GenerarInformes
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GenerarInformes))
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.generarInformesTitle = New System.Windows.Forms.PictureBox()
        Me.LabelNom = New System.Windows.Forms.Label()
        Me.ComboBoxInformes = New System.Windows.Forms.ComboBox()
        Me.ChartGrafiques = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.imprimirPDFBtn = New System.Windows.Forms.PictureBox()
        Me.tornarMenuBtn = New System.Windows.Forms.PictureBox()
        CType(Me.generarInformesTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChartGrafiques, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imprimirPDFBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tornarMenuBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'generarInformesTitle
        '
        Me.generarInformesTitle.BackColor = System.Drawing.Color.Transparent
        Me.generarInformesTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.generarInformesTitle.Image = CType(resources.GetObject("generarInformesTitle.Image"), System.Drawing.Image)
        Me.generarInformesTitle.Location = New System.Drawing.Point(0, 0)
        Me.generarInformesTitle.Name = "generarInformesTitle"
        Me.generarInformesTitle.Size = New System.Drawing.Size(1008, 119)
        Me.generarInformesTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.generarInformesTitle.TabIndex = 27
        Me.generarInformesTitle.TabStop = False
        '
        'LabelNom
        '
        Me.LabelNom.AutoSize = True
        Me.LabelNom.BackColor = System.Drawing.Color.Transparent
        Me.LabelNom.Font = New System.Drawing.Font("Dubai", 15.0!, System.Drawing.FontStyle.Bold)
        Me.LabelNom.ForeColor = System.Drawing.Color.White
        Me.LabelNom.Location = New System.Drawing.Point(394, 122)
        Me.LabelNom.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelNom.Name = "LabelNom"
        Me.LabelNom.Size = New System.Drawing.Size(221, 34)
        Me.LabelNom.TabIndex = 45
        Me.LabelNom.Text = "Quin PDF vols generar?"
        '
        'ComboBoxInformes
        '
        Me.ComboBoxInformes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxInformes.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ComboBoxInformes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ComboBoxInformes.FormattingEnabled = True
        Me.ComboBoxInformes.Location = New System.Drawing.Point(106, 159)
        Me.ComboBoxInformes.Name = "ComboBoxInformes"
        Me.ComboBoxInformes.Size = New System.Drawing.Size(793, 35)
        Me.ComboBoxInformes.TabIndex = 46
        '
        'ChartGrafiques
        '
        Me.ChartGrafiques.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ChartGrafiques.BackImage = "C:\Users\angel\Desktop\2DAM\Projecte\2nProjecte\VoluntarisAGalan\VoluntarisAGalan" &
    "\Resources\background.png"
        Me.ChartGrafiques.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.Scaled
        Me.ChartGrafiques.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid
        Me.ChartGrafiques.BorderlineWidth = 5
        Me.ChartGrafiques.BorderSkin.BorderColor = System.Drawing.Color.White
        ChartArea2.AxisX.IsLabelAutoFit = False
        ChartArea2.AxisX.LabelStyle.Font = New System.Drawing.Font("Dubai", 9.0!, System.Drawing.FontStyle.Bold)
        ChartArea2.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White
        ChartArea2.AxisY.IsLabelAutoFit = False
        ChartArea2.AxisY.LabelStyle.Font = New System.Drawing.Font("Dubai", 9.0!, System.Drawing.FontStyle.Bold)
        ChartArea2.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White
        ChartArea2.Name = "ChartArea1"
        Me.ChartGrafiques.ChartAreas.Add(ChartArea2)
        Legend2.Font = New System.Drawing.Font("Dubai", 9.0!, System.Drawing.FontStyle.Bold)
        Legend2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(63, Byte), Integer))
        Legend2.IsTextAutoFit = False
        Legend2.Name = "Legend1"
        Me.ChartGrafiques.Legends.Add(Legend2)
        Me.ChartGrafiques.Location = New System.Drawing.Point(106, 205)
        Me.ChartGrafiques.Name = "ChartGrafiques"
        Me.ChartGrafiques.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None
        Me.ChartGrafiques.PaletteCustomColors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(188, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(110, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(114, Byte), Integer))}
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Me.ChartGrafiques.Series.Add(Series2)
        Me.ChartGrafiques.Size = New System.Drawing.Size(793, 372)
        Me.ChartGrafiques.TabIndex = 50
        Me.ChartGrafiques.Text = "Gràfic"
        Me.ChartGrafiques.Visible = False
        '
        'imprimirPDFBtn
        '
        Me.imprimirPDFBtn.BackColor = System.Drawing.Color.Transparent
        Me.imprimirPDFBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.imprimirPDFBtn.Image = CType(resources.GetObject("imprimirPDFBtn.Image"), System.Drawing.Image)
        Me.imprimirPDFBtn.Location = New System.Drawing.Point(405, 583)
        Me.imprimirPDFBtn.Name = "imprimirPDFBtn"
        Me.imprimirPDFBtn.Size = New System.Drawing.Size(193, 84)
        Me.imprimirPDFBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imprimirPDFBtn.TabIndex = 211
        Me.imprimirPDFBtn.TabStop = False
        '
        'tornarMenuBtn
        '
        Me.tornarMenuBtn.BackColor = System.Drawing.Color.Transparent
        Me.tornarMenuBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tornarMenuBtn.Image = CType(resources.GetObject("tornarMenuBtn.Image"), System.Drawing.Image)
        Me.tornarMenuBtn.Location = New System.Drawing.Point(12, 605)
        Me.tornarMenuBtn.Name = "tornarMenuBtn"
        Me.tornarMenuBtn.Size = New System.Drawing.Size(64, 62)
        Me.tornarMenuBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.tornarMenuBtn.TabIndex = 212
        Me.tornarMenuBtn.TabStop = False
        '
        'GenerarInformes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1008, 679)
        Me.Controls.Add(Me.tornarMenuBtn)
        Me.Controls.Add(Me.imprimirPDFBtn)
        Me.Controls.Add(Me.ChartGrafiques)
        Me.Controls.Add(Me.ComboBoxInformes)
        Me.Controls.Add(Me.LabelNom)
        Me.Controls.Add(Me.generarInformesTitle)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1024, 718)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1024, 718)
        Me.Name = "GenerarInformes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Generar Informes"
        CType(Me.generarInformesTitle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartGrafiques, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imprimirPDFBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tornarMenuBtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents generarInformesTitle As PictureBox
    Friend WithEvents LabelNom As Label
    Friend WithEvents ComboBoxInformes As ComboBox
    Friend WithEvents ChartGrafiques As DataVisualization.Charting.Chart
    Private WithEvents imprimirPDFBtn As PictureBox
    Private WithEvents tornarMenuBtn As PictureBox
End Class
