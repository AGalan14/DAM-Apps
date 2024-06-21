<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProjectesConsultar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProjectesConsultar))
        Me.consultarProjectesTitle = New System.Windows.Forms.PictureBox()
        Me.ComboBoxProjectes = New System.Windows.Forms.ComboBox()
        Me.LabelProjecte = New System.Windows.Forms.Label()
        Me.TasquesList = New System.Windows.Forms.ListBox()
        Me.LabelMaxVoluntaris = New System.Windows.Forms.Label()
        Me.LabelTasques = New System.Windows.Forms.Label()
        Me.LabelVoluntaris = New System.Windows.Forms.Label()
        Me.LabelAmbit = New System.Windows.Forms.Label()
        Me.LabelLloc = New System.Windows.Forms.Label()
        Me.TextBoxLloc = New System.Windows.Forms.TextBox()
        Me.LabelFinalitzacio = New System.Windows.Forms.Label()
        Me.LabelInici = New System.Windows.Forms.Label()
        Me.LabelCoordinador = New System.Windows.Forms.Label()
        Me.TextBoxDefinicio = New System.Windows.Forms.TextBox()
        Me.LabelNomProjecte = New System.Windows.Forms.Label()
        Me.TextBoxProjecte = New System.Windows.Forms.TextBox()
        Me.LabelDefinicio = New System.Windows.Forms.Label()
        Me.TextBoxIniciProjecte = New System.Windows.Forms.TextBox()
        Me.TextBoxFinalitzacioProjecte = New System.Windows.Forms.TextBox()
        Me.TextBoxAmbit = New System.Windows.Forms.TextBox()
        Me.TextBoxCoordinador = New System.Windows.Forms.TextBox()
        Me.TextBoxMaxVoluntaris = New System.Windows.Forms.TextBox()
        Me.previousBtn = New System.Windows.Forms.PictureBox()
        Me.nextBtn = New System.Windows.Forms.PictureBox()
        Me.tornarMenuBtn = New System.Windows.Forms.PictureBox()
        Me.TextBoxEstat = New System.Windows.Forms.TextBox()
        Me.LabelEstat = New System.Windows.Forms.Label()
        Me.VoluntarisList = New System.Windows.Forms.ListBox()
        CType(Me.consultarProjectesTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.previousBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nextBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tornarMenuBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'consultarProjectesTitle
        '
        Me.consultarProjectesTitle.BackColor = System.Drawing.Color.Transparent
        Me.consultarProjectesTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.consultarProjectesTitle.Image = CType(resources.GetObject("consultarProjectesTitle.Image"), System.Drawing.Image)
        Me.consultarProjectesTitle.Location = New System.Drawing.Point(0, 0)
        Me.consultarProjectesTitle.Name = "consultarProjectesTitle"
        Me.consultarProjectesTitle.Size = New System.Drawing.Size(1008, 101)
        Me.consultarProjectesTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.consultarProjectesTitle.TabIndex = 28
        Me.consultarProjectesTitle.TabStop = False
        '
        'ComboBoxProjectes
        '
        Me.ComboBoxProjectes.Font = New System.Drawing.Font("Dubai", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ComboBoxProjectes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ComboBoxProjectes.FormattingEnabled = True
        Me.ComboBoxProjectes.Location = New System.Drawing.Point(352, 541)
        Me.ComboBoxProjectes.Name = "ComboBoxProjectes"
        Me.ComboBoxProjectes.Size = New System.Drawing.Size(311, 29)
        Me.ComboBoxProjectes.Sorted = True
        Me.ComboBoxProjectes.TabIndex = 166
        '
        'LabelProjecte
        '
        Me.LabelProjecte.AutoSize = True
        Me.LabelProjecte.BackColor = System.Drawing.Color.Transparent
        Me.LabelProjecte.Font = New System.Drawing.Font("Dubai", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelProjecte.ForeColor = System.Drawing.Color.White
        Me.LabelProjecte.Location = New System.Drawing.Point(462, 514)
        Me.LabelProjecte.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelProjecte.Name = "LabelProjecte"
        Me.LabelProjecte.Size = New System.Drawing.Size(87, 24)
        Me.LabelProjecte.TabIndex = 165
        Me.LabelProjecte.Text = "Projecte nº ?"
        Me.LabelProjecte.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TasquesList
        '
        Me.TasquesList.BackColor = System.Drawing.SystemColors.Window
        Me.TasquesList.Font = New System.Drawing.Font("Dubai", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TasquesList.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.TasquesList.FormattingEnabled = True
        Me.TasquesList.ItemHeight = 21
        Me.TasquesList.Location = New System.Drawing.Point(410, 305)
        Me.TasquesList.Name = "TasquesList"
        Me.TasquesList.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.TasquesList.Size = New System.Drawing.Size(193, 130)
        Me.TasquesList.TabIndex = 189
        '
        'LabelMaxVoluntaris
        '
        Me.LabelMaxVoluntaris.AutoSize = True
        Me.LabelMaxVoluntaris.BackColor = System.Drawing.Color.Transparent
        Me.LabelMaxVoluntaris.Font = New System.Drawing.Font("Dubai", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMaxVoluntaris.ForeColor = System.Drawing.Color.White
        Me.LabelMaxVoluntaris.Location = New System.Drawing.Point(406, 220)
        Me.LabelMaxVoluntaris.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelMaxVoluntaris.Name = "LabelMaxVoluntaris"
        Me.LabelMaxVoluntaris.Size = New System.Drawing.Size(187, 24)
        Me.LabelMaxVoluntaris.TabIndex = 185
        Me.LabelMaxVoluntaris.Text = "Nombre màxim de Voluntaris"
        '
        'LabelTasques
        '
        Me.LabelTasques.AutoSize = True
        Me.LabelTasques.BackColor = System.Drawing.Color.Transparent
        Me.LabelTasques.Font = New System.Drawing.Font("Dubai", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTasques.ForeColor = System.Drawing.Color.White
        Me.LabelTasques.Location = New System.Drawing.Point(406, 278)
        Me.LabelTasques.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelTasques.Name = "LabelTasques"
        Me.LabelTasques.Size = New System.Drawing.Size(60, 24)
        Me.LabelTasques.TabIndex = 184
        Me.LabelTasques.Text = "Tasques"
        '
        'LabelVoluntaris
        '
        Me.LabelVoluntaris.AutoSize = True
        Me.LabelVoluntaris.BackColor = System.Drawing.Color.Transparent
        Me.LabelVoluntaris.Font = New System.Drawing.Font("Dubai", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelVoluntaris.ForeColor = System.Drawing.Color.White
        Me.LabelVoluntaris.Location = New System.Drawing.Point(620, 104)
        Me.LabelVoluntaris.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelVoluntaris.Name = "LabelVoluntaris"
        Me.LabelVoluntaris.Size = New System.Drawing.Size(74, 24)
        Me.LabelVoluntaris.TabIndex = 180
        Me.LabelVoluntaris.Text = "Voluntaris"
        '
        'LabelAmbit
        '
        Me.LabelAmbit.AutoSize = True
        Me.LabelAmbit.BackColor = System.Drawing.Color.Transparent
        Me.LabelAmbit.Font = New System.Drawing.Font("Dubai", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAmbit.ForeColor = System.Drawing.Color.White
        Me.LabelAmbit.Location = New System.Drawing.Point(406, 104)
        Me.LabelAmbit.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelAmbit.Name = "LabelAmbit"
        Me.LabelAmbit.Size = New System.Drawing.Size(47, 24)
        Me.LabelAmbit.TabIndex = 181
        Me.LabelAmbit.Text = "Àmbit"
        '
        'LabelLloc
        '
        Me.LabelLloc.AutoSize = True
        Me.LabelLloc.BackColor = System.Drawing.Color.Transparent
        Me.LabelLloc.Font = New System.Drawing.Font("Dubai", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLloc.ForeColor = System.Drawing.Color.White
        Me.LabelLloc.Location = New System.Drawing.Point(192, 255)
        Me.LabelLloc.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelLloc.Name = "LabelLloc"
        Me.LabelLloc.Size = New System.Drawing.Size(118, 24)
        Me.LabelLloc.TabIndex = 179
        Me.LabelLloc.Text = "Lloc on es realitza"
        '
        'TextBoxLloc
        '
        Me.TextBoxLloc.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxLloc.Font = New System.Drawing.Font("Dubai", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TextBoxLloc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.TextBoxLloc.Location = New System.Drawing.Point(196, 282)
        Me.TextBoxLloc.Multiline = True
        Me.TextBoxLloc.Name = "TextBoxLloc"
        Me.TextBoxLloc.ReadOnly = True
        Me.TextBoxLloc.Size = New System.Drawing.Size(193, 44)
        Me.TextBoxLloc.TabIndex = 178
        '
        'LabelFinalitzacio
        '
        Me.LabelFinalitzacio.AutoSize = True
        Me.LabelFinalitzacio.BackColor = System.Drawing.Color.Transparent
        Me.LabelFinalitzacio.Font = New System.Drawing.Font("Dubai", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFinalitzacio.ForeColor = System.Drawing.Color.White
        Me.LabelFinalitzacio.Location = New System.Drawing.Point(192, 388)
        Me.LabelFinalitzacio.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelFinalitzacio.Name = "LabelFinalitzacio"
        Me.LabelFinalitzacio.Size = New System.Drawing.Size(155, 24)
        Me.LabelFinalitzacio.TabIndex = 177
        Me.LabelFinalitzacio.Text = "Finalització del Projecte"
        '
        'LabelInici
        '
        Me.LabelInici.AutoSize = True
        Me.LabelInici.BackColor = System.Drawing.Color.Transparent
        Me.LabelInici.Font = New System.Drawing.Font("Dubai", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelInici.ForeColor = System.Drawing.Color.White
        Me.LabelInici.Location = New System.Drawing.Point(192, 329)
        Me.LabelInici.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelInici.Name = "LabelInici"
        Me.LabelInici.Size = New System.Drawing.Size(111, 24)
        Me.LabelInici.TabIndex = 175
        Me.LabelInici.Text = "Inici del Projecte"
        '
        'LabelCoordinador
        '
        Me.LabelCoordinador.AutoSize = True
        Me.LabelCoordinador.BackColor = System.Drawing.Color.Transparent
        Me.LabelCoordinador.Font = New System.Drawing.Font("Dubai", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCoordinador.ForeColor = System.Drawing.Color.White
        Me.LabelCoordinador.Location = New System.Drawing.Point(406, 162)
        Me.LabelCoordinador.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelCoordinador.Name = "LabelCoordinador"
        Me.LabelCoordinador.Size = New System.Drawing.Size(87, 24)
        Me.LabelCoordinador.TabIndex = 172
        Me.LabelCoordinador.Text = "Coordinador"
        '
        'TextBoxDefinicio
        '
        Me.TextBoxDefinicio.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxDefinicio.Font = New System.Drawing.Font("Dubai", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TextBoxDefinicio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.TextBoxDefinicio.Location = New System.Drawing.Point(196, 189)
        Me.TextBoxDefinicio.Multiline = True
        Me.TextBoxDefinicio.Name = "TextBoxDefinicio"
        Me.TextBoxDefinicio.ReadOnly = True
        Me.TextBoxDefinicio.Size = New System.Drawing.Size(193, 63)
        Me.TextBoxDefinicio.TabIndex = 170
        '
        'LabelNomProjecte
        '
        Me.LabelNomProjecte.AutoSize = True
        Me.LabelNomProjecte.BackColor = System.Drawing.Color.Transparent
        Me.LabelNomProjecte.Font = New System.Drawing.Font("Dubai", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNomProjecte.ForeColor = System.Drawing.Color.White
        Me.LabelNomProjecte.Location = New System.Drawing.Point(192, 104)
        Me.LabelNomProjecte.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelNomProjecte.Name = "LabelNomProjecte"
        Me.LabelNomProjecte.Size = New System.Drawing.Size(114, 24)
        Me.LabelNomProjecte.TabIndex = 169
        Me.LabelNomProjecte.Text = "Nom del Projecte"
        '
        'TextBoxProjecte
        '
        Me.TextBoxProjecte.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxProjecte.Font = New System.Drawing.Font("Dubai", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TextBoxProjecte.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.TextBoxProjecte.Location = New System.Drawing.Point(196, 131)
        Me.TextBoxProjecte.Name = "TextBoxProjecte"
        Me.TextBoxProjecte.ReadOnly = True
        Me.TextBoxProjecte.Size = New System.Drawing.Size(193, 28)
        Me.TextBoxProjecte.TabIndex = 168
        '
        'LabelDefinicio
        '
        Me.LabelDefinicio.AutoSize = True
        Me.LabelDefinicio.BackColor = System.Drawing.Color.Transparent
        Me.LabelDefinicio.Font = New System.Drawing.Font("Dubai", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDefinicio.ForeColor = System.Drawing.Color.White
        Me.LabelDefinicio.Location = New System.Drawing.Point(192, 162)
        Me.LabelDefinicio.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelDefinicio.Name = "LabelDefinicio"
        Me.LabelDefinicio.Size = New System.Drawing.Size(141, 24)
        Me.LabelDefinicio.TabIndex = 171
        Me.LabelDefinicio.Text = "Definició del Projecte"
        '
        'TextBoxIniciProjecte
        '
        Me.TextBoxIniciProjecte.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxIniciProjecte.Font = New System.Drawing.Font("Dubai", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TextBoxIniciProjecte.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.TextBoxIniciProjecte.Location = New System.Drawing.Point(196, 356)
        Me.TextBoxIniciProjecte.Name = "TextBoxIniciProjecte"
        Me.TextBoxIniciProjecte.ReadOnly = True
        Me.TextBoxIniciProjecte.Size = New System.Drawing.Size(191, 28)
        Me.TextBoxIniciProjecte.TabIndex = 190
        '
        'TextBoxFinalitzacioProjecte
        '
        Me.TextBoxFinalitzacioProjecte.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxFinalitzacioProjecte.Font = New System.Drawing.Font("Dubai", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TextBoxFinalitzacioProjecte.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.TextBoxFinalitzacioProjecte.Location = New System.Drawing.Point(196, 414)
        Me.TextBoxFinalitzacioProjecte.Name = "TextBoxFinalitzacioProjecte"
        Me.TextBoxFinalitzacioProjecte.ReadOnly = True
        Me.TextBoxFinalitzacioProjecte.Size = New System.Drawing.Size(191, 28)
        Me.TextBoxFinalitzacioProjecte.TabIndex = 191
        '
        'TextBoxAmbit
        '
        Me.TextBoxAmbit.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxAmbit.Font = New System.Drawing.Font("Dubai", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TextBoxAmbit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.TextBoxAmbit.Location = New System.Drawing.Point(410, 131)
        Me.TextBoxAmbit.Name = "TextBoxAmbit"
        Me.TextBoxAmbit.ReadOnly = True
        Me.TextBoxAmbit.Size = New System.Drawing.Size(193, 28)
        Me.TextBoxAmbit.TabIndex = 192
        '
        'TextBoxCoordinador
        '
        Me.TextBoxCoordinador.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxCoordinador.Font = New System.Drawing.Font("Dubai", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TextBoxCoordinador.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.TextBoxCoordinador.Location = New System.Drawing.Point(410, 189)
        Me.TextBoxCoordinador.Name = "TextBoxCoordinador"
        Me.TextBoxCoordinador.ReadOnly = True
        Me.TextBoxCoordinador.Size = New System.Drawing.Size(193, 28)
        Me.TextBoxCoordinador.TabIndex = 193
        '
        'TextBoxMaxVoluntaris
        '
        Me.TextBoxMaxVoluntaris.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxMaxVoluntaris.Font = New System.Drawing.Font("Dubai", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TextBoxMaxVoluntaris.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.TextBoxMaxVoluntaris.Location = New System.Drawing.Point(410, 247)
        Me.TextBoxMaxVoluntaris.Name = "TextBoxMaxVoluntaris"
        Me.TextBoxMaxVoluntaris.ReadOnly = True
        Me.TextBoxMaxVoluntaris.Size = New System.Drawing.Size(43, 28)
        Me.TextBoxMaxVoluntaris.TabIndex = 194
        '
        'previousBtn
        '
        Me.previousBtn.BackColor = System.Drawing.Color.Transparent
        Me.previousBtn.BackgroundImage = CType(resources.GetObject("previousBtn.BackgroundImage"), System.Drawing.Image)
        Me.previousBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.previousBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.previousBtn.Location = New System.Drawing.Point(445, 461)
        Me.previousBtn.Name = "previousBtn"
        Me.previousBtn.Size = New System.Drawing.Size(50, 50)
        Me.previousBtn.TabIndex = 196
        Me.previousBtn.TabStop = False
        '
        'nextBtn
        '
        Me.nextBtn.BackColor = System.Drawing.Color.Transparent
        Me.nextBtn.BackgroundImage = CType(resources.GetObject("nextBtn.BackgroundImage"), System.Drawing.Image)
        Me.nextBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.nextBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.nextBtn.Location = New System.Drawing.Point(516, 461)
        Me.nextBtn.Name = "nextBtn"
        Me.nextBtn.Size = New System.Drawing.Size(50, 50)
        Me.nextBtn.TabIndex = 195
        Me.nextBtn.TabStop = False
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
        Me.tornarMenuBtn.TabIndex = 197
        Me.tornarMenuBtn.TabStop = False
        '
        'TextBoxEstat
        '
        Me.TextBoxEstat.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxEstat.Font = New System.Drawing.Font("Dubai", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TextBoxEstat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.TextBoxEstat.Location = New System.Drawing.Point(624, 414)
        Me.TextBoxEstat.Name = "TextBoxEstat"
        Me.TextBoxEstat.ReadOnly = True
        Me.TextBoxEstat.Size = New System.Drawing.Size(191, 28)
        Me.TextBoxEstat.TabIndex = 199
        '
        'LabelEstat
        '
        Me.LabelEstat.AutoSize = True
        Me.LabelEstat.BackColor = System.Drawing.Color.Transparent
        Me.LabelEstat.Font = New System.Drawing.Font("Dubai", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEstat.ForeColor = System.Drawing.Color.White
        Me.LabelEstat.Location = New System.Drawing.Point(620, 388)
        Me.LabelEstat.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelEstat.Name = "LabelEstat"
        Me.LabelEstat.Size = New System.Drawing.Size(41, 24)
        Me.LabelEstat.TabIndex = 198
        Me.LabelEstat.Text = "Estat"
        '
        'VoluntarisList
        '
        Me.VoluntarisList.BackColor = System.Drawing.SystemColors.Window
        Me.VoluntarisList.Font = New System.Drawing.Font("Dubai", 9.0!, System.Drawing.FontStyle.Bold)
        Me.VoluntarisList.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.VoluntarisList.FormattingEnabled = True
        Me.VoluntarisList.ItemHeight = 21
        Me.VoluntarisList.Location = New System.Drawing.Point(624, 131)
        Me.VoluntarisList.Name = "VoluntarisList"
        Me.VoluntarisList.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.VoluntarisList.Size = New System.Drawing.Size(193, 256)
        Me.VoluntarisList.TabIndex = 200
        '
        'ProjectesConsultar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1008, 679)
        Me.Controls.Add(Me.VoluntarisList)
        Me.Controls.Add(Me.TextBoxEstat)
        Me.Controls.Add(Me.LabelEstat)
        Me.Controls.Add(Me.tornarMenuBtn)
        Me.Controls.Add(Me.previousBtn)
        Me.Controls.Add(Me.nextBtn)
        Me.Controls.Add(Me.TextBoxMaxVoluntaris)
        Me.Controls.Add(Me.TextBoxCoordinador)
        Me.Controls.Add(Me.TextBoxAmbit)
        Me.Controls.Add(Me.TextBoxFinalitzacioProjecte)
        Me.Controls.Add(Me.TextBoxIniciProjecte)
        Me.Controls.Add(Me.TasquesList)
        Me.Controls.Add(Me.LabelMaxVoluntaris)
        Me.Controls.Add(Me.LabelTasques)
        Me.Controls.Add(Me.LabelVoluntaris)
        Me.Controls.Add(Me.LabelAmbit)
        Me.Controls.Add(Me.LabelLloc)
        Me.Controls.Add(Me.TextBoxLloc)
        Me.Controls.Add(Me.LabelFinalitzacio)
        Me.Controls.Add(Me.LabelInici)
        Me.Controls.Add(Me.LabelCoordinador)
        Me.Controls.Add(Me.TextBoxDefinicio)
        Me.Controls.Add(Me.LabelNomProjecte)
        Me.Controls.Add(Me.TextBoxProjecte)
        Me.Controls.Add(Me.LabelDefinicio)
        Me.Controls.Add(Me.ComboBoxProjectes)
        Me.Controls.Add(Me.LabelProjecte)
        Me.Controls.Add(Me.consultarProjectesTitle)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1024, 718)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1024, 718)
        Me.Name = "ProjectesConsultar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consultar Projectes"
        CType(Me.consultarProjectesTitle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.previousBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nextBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tornarMenuBtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents consultarProjectesTitle As PictureBox
    Friend WithEvents ComboBoxProjectes As ComboBox
    Friend WithEvents LabelProjecte As Label
    Friend WithEvents TasquesList As ListBox
    Friend WithEvents LabelMaxVoluntaris As Label
    Friend WithEvents LabelTasques As Label
    Friend WithEvents LabelVoluntaris As Label
    Friend WithEvents LabelAmbit As Label
    Friend WithEvents LabelLloc As Label
    Friend WithEvents TextBoxLloc As TextBox
    Friend WithEvents LabelFinalitzacio As Label
    Friend WithEvents LabelInici As Label
    Friend WithEvents LabelCoordinador As Label
    Friend WithEvents TextBoxDefinicio As TextBox
    Friend WithEvents LabelNomProjecte As Label
    Friend WithEvents TextBoxProjecte As TextBox
    Friend WithEvents LabelDefinicio As Label
    Friend WithEvents TextBoxIniciProjecte As TextBox
    Friend WithEvents TextBoxFinalitzacioProjecte As TextBox
    Friend WithEvents TextBoxAmbit As TextBox
    Friend WithEvents TextBoxCoordinador As TextBox
    Friend WithEvents TextBoxMaxVoluntaris As TextBox
    Friend WithEvents previousBtn As PictureBox
    Friend WithEvents nextBtn As PictureBox
    Private WithEvents tornarMenuBtn As PictureBox
    Friend WithEvents TextBoxEstat As TextBox
    Friend WithEvents LabelEstat As Label
    Friend WithEvents VoluntarisList As ListBox
End Class
