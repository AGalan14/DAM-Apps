<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProjectesCrear
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProjectesCrear))
        Me.crearProjecteTitle = New System.Windows.Forms.PictureBox()
        Me.TextBoxProjecte = New System.Windows.Forms.TextBox()
        Me.LabelNomProjecte = New System.Windows.Forms.Label()
        Me.LabelDefinicio = New System.Windows.Forms.Label()
        Me.TextBoxDefinicio = New System.Windows.Forms.TextBox()
        Me.LabelCoordinador = New System.Windows.Forms.Label()
        Me.ComboBoxCoordinador = New System.Windows.Forms.ComboBox()
        Me.iniciProjecte = New System.Windows.Forms.MonthCalendar()
        Me.LabelInici = New System.Windows.Forms.Label()
        Me.LabelFinalitzacio = New System.Windows.Forms.Label()
        Me.finalitzacioProjecte = New System.Windows.Forms.MonthCalendar()
        Me.LabelLloc = New System.Windows.Forms.Label()
        Me.TextBoxLloc = New System.Windows.Forms.TextBox()
        Me.LabelVoluntaris = New System.Windows.Forms.Label()
        Me.LabelAmbit = New System.Windows.Forms.Label()
        Me.VoluntarisList = New System.Windows.Forms.CheckedListBox()
        Me.ComboBoxAmbits = New System.Windows.Forms.ComboBox()
        Me.LabelTasques = New System.Windows.Forms.Label()
        Me.maxVoluntaris = New System.Windows.Forms.ComboBox()
        Me.LabelMaxVoluntaris = New System.Windows.Forms.Label()
        Me.RemoveTasca = New System.Windows.Forms.Button()
        Me.AddTasca = New System.Windows.Forms.Button()
        Me.ListBoxTasques = New System.Windows.Forms.ListBox()
        Me.tornarMenuBtn = New System.Windows.Forms.PictureBox()
        Me.crearProjecteBtn = New System.Windows.Forms.PictureBox()
        CType(Me.crearProjecteTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tornarMenuBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.crearProjecteBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'crearProjecteTitle
        '
        Me.crearProjecteTitle.BackColor = System.Drawing.Color.Transparent
        Me.crearProjecteTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.crearProjecteTitle.Image = CType(resources.GetObject("crearProjecteTitle.Image"), System.Drawing.Image)
        Me.crearProjecteTitle.Location = New System.Drawing.Point(0, 0)
        Me.crearProjecteTitle.Name = "crearProjecteTitle"
        Me.crearProjecteTitle.Size = New System.Drawing.Size(1008, 90)
        Me.crearProjecteTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.crearProjecteTitle.TabIndex = 27
        Me.crearProjecteTitle.TabStop = False
        '
        'TextBoxProjecte
        '
        Me.TextBoxProjecte.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxProjecte.Font = New System.Drawing.Font("Dubai", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TextBoxProjecte.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.TextBoxProjecte.Location = New System.Drawing.Point(199, 124)
        Me.TextBoxProjecte.Name = "TextBoxProjecte"
        Me.TextBoxProjecte.Size = New System.Drawing.Size(193, 28)
        Me.TextBoxProjecte.TabIndex = 42
        '
        'LabelNomProjecte
        '
        Me.LabelNomProjecte.AutoSize = True
        Me.LabelNomProjecte.BackColor = System.Drawing.Color.Transparent
        Me.LabelNomProjecte.Font = New System.Drawing.Font("Dubai", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNomProjecte.ForeColor = System.Drawing.Color.White
        Me.LabelNomProjecte.Location = New System.Drawing.Point(195, 97)
        Me.LabelNomProjecte.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelNomProjecte.Name = "LabelNomProjecte"
        Me.LabelNomProjecte.Size = New System.Drawing.Size(114, 24)
        Me.LabelNomProjecte.TabIndex = 45
        Me.LabelNomProjecte.Text = "Nom del Projecte"
        '
        'LabelDefinicio
        '
        Me.LabelDefinicio.AutoSize = True
        Me.LabelDefinicio.BackColor = System.Drawing.Color.Transparent
        Me.LabelDefinicio.Font = New System.Drawing.Font("Dubai", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDefinicio.ForeColor = System.Drawing.Color.White
        Me.LabelDefinicio.Location = New System.Drawing.Point(195, 155)
        Me.LabelDefinicio.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelDefinicio.Name = "LabelDefinicio"
        Me.LabelDefinicio.Size = New System.Drawing.Size(141, 24)
        Me.LabelDefinicio.TabIndex = 47
        Me.LabelDefinicio.Text = "Definició del Projecte"
        '
        'TextBoxDefinicio
        '
        Me.TextBoxDefinicio.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxDefinicio.Font = New System.Drawing.Font("Dubai", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TextBoxDefinicio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.TextBoxDefinicio.Location = New System.Drawing.Point(199, 182)
        Me.TextBoxDefinicio.Multiline = True
        Me.TextBoxDefinicio.Name = "TextBoxDefinicio"
        Me.TextBoxDefinicio.Size = New System.Drawing.Size(193, 63)
        Me.TextBoxDefinicio.TabIndex = 46
        '
        'LabelCoordinador
        '
        Me.LabelCoordinador.AutoSize = True
        Me.LabelCoordinador.BackColor = System.Drawing.Color.Transparent
        Me.LabelCoordinador.Font = New System.Drawing.Font("Dubai", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCoordinador.ForeColor = System.Drawing.Color.White
        Me.LabelCoordinador.Location = New System.Drawing.Point(623, 156)
        Me.LabelCoordinador.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelCoordinador.Name = "LabelCoordinador"
        Me.LabelCoordinador.Size = New System.Drawing.Size(87, 24)
        Me.LabelCoordinador.TabIndex = 48
        Me.LabelCoordinador.Text = "Coordinador"
        '
        'ComboBoxCoordinador
        '
        Me.ComboBoxCoordinador.BackColor = System.Drawing.SystemColors.Window
        Me.ComboBoxCoordinador.Enabled = False
        Me.ComboBoxCoordinador.Font = New System.Drawing.Font("Dubai", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ComboBoxCoordinador.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ComboBoxCoordinador.FormattingEnabled = True
        Me.ComboBoxCoordinador.Location = New System.Drawing.Point(627, 183)
        Me.ComboBoxCoordinador.Name = "ComboBoxCoordinador"
        Me.ComboBoxCoordinador.Size = New System.Drawing.Size(193, 29)
        Me.ComboBoxCoordinador.Sorted = True
        Me.ComboBoxCoordinador.TabIndex = 125
        '
        'iniciProjecte
        '
        Me.iniciProjecte.BackColor = System.Drawing.SystemColors.Window
        Me.iniciProjecte.Font = New System.Drawing.Font("Dubai", 9.0!, System.Drawing.FontStyle.Bold)
        Me.iniciProjecte.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.iniciProjecte.Location = New System.Drawing.Point(414, 124)
        Me.iniciProjecte.MaxSelectionCount = 1
        Me.iniciProjecte.Name = "iniciProjecte"
        Me.iniciProjecte.TabIndex = 126
        Me.iniciProjecte.TitleBackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.iniciProjecte.TrailingForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(63, Byte), Integer))
        '
        'LabelInici
        '
        Me.LabelInici.AutoSize = True
        Me.LabelInici.BackColor = System.Drawing.Color.Transparent
        Me.LabelInici.Font = New System.Drawing.Font("Dubai", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelInici.ForeColor = System.Drawing.Color.White
        Me.LabelInici.Location = New System.Drawing.Point(410, 97)
        Me.LabelInici.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelInici.Name = "LabelInici"
        Me.LabelInici.Size = New System.Drawing.Size(111, 24)
        Me.LabelInici.TabIndex = 127
        Me.LabelInici.Text = "Inici del Projecte"
        '
        'LabelFinalitzacio
        '
        Me.LabelFinalitzacio.AutoSize = True
        Me.LabelFinalitzacio.BackColor = System.Drawing.Color.Transparent
        Me.LabelFinalitzacio.Font = New System.Drawing.Font("Dubai", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFinalitzacio.ForeColor = System.Drawing.Color.White
        Me.LabelFinalitzacio.Location = New System.Drawing.Point(410, 295)
        Me.LabelFinalitzacio.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelFinalitzacio.Name = "LabelFinalitzacio"
        Me.LabelFinalitzacio.Size = New System.Drawing.Size(155, 24)
        Me.LabelFinalitzacio.TabIndex = 129
        Me.LabelFinalitzacio.Text = "Finalització del Projecte"
        '
        'finalitzacioProjecte
        '
        Me.finalitzacioProjecte.BackColor = System.Drawing.SystemColors.Window
        Me.finalitzacioProjecte.Enabled = False
        Me.finalitzacioProjecte.Font = New System.Drawing.Font("Dubai", 9.0!, System.Drawing.FontStyle.Bold)
        Me.finalitzacioProjecte.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.finalitzacioProjecte.Location = New System.Drawing.Point(414, 322)
        Me.finalitzacioProjecte.MaxSelectionCount = 1
        Me.finalitzacioProjecte.Name = "finalitzacioProjecte"
        Me.finalitzacioProjecte.TabIndex = 128
        Me.finalitzacioProjecte.TitleBackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.finalitzacioProjecte.TrailingForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(63, Byte), Integer))
        '
        'LabelLloc
        '
        Me.LabelLloc.AutoSize = True
        Me.LabelLloc.BackColor = System.Drawing.Color.Transparent
        Me.LabelLloc.Font = New System.Drawing.Font("Dubai", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLloc.ForeColor = System.Drawing.Color.White
        Me.LabelLloc.Location = New System.Drawing.Point(195, 248)
        Me.LabelLloc.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelLloc.Name = "LabelLloc"
        Me.LabelLloc.Size = New System.Drawing.Size(118, 24)
        Me.LabelLloc.TabIndex = 131
        Me.LabelLloc.Text = "Lloc on es realitza"
        '
        'TextBoxLloc
        '
        Me.TextBoxLloc.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxLloc.Font = New System.Drawing.Font("Dubai", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TextBoxLloc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.TextBoxLloc.Location = New System.Drawing.Point(199, 275)
        Me.TextBoxLloc.Multiline = True
        Me.TextBoxLloc.Name = "TextBoxLloc"
        Me.TextBoxLloc.Size = New System.Drawing.Size(193, 44)
        Me.TextBoxLloc.TabIndex = 130
        '
        'LabelVoluntaris
        '
        Me.LabelVoluntaris.AutoSize = True
        Me.LabelVoluntaris.BackColor = System.Drawing.Color.Transparent
        Me.LabelVoluntaris.Font = New System.Drawing.Font("Dubai", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelVoluntaris.ForeColor = System.Drawing.Color.White
        Me.LabelVoluntaris.Location = New System.Drawing.Point(623, 274)
        Me.LabelVoluntaris.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelVoluntaris.Name = "LabelVoluntaris"
        Me.LabelVoluntaris.Size = New System.Drawing.Size(74, 24)
        Me.LabelVoluntaris.TabIndex = 134
        Me.LabelVoluntaris.Text = "Voluntaris"
        '
        'LabelAmbit
        '
        Me.LabelAmbit.AutoSize = True
        Me.LabelAmbit.BackColor = System.Drawing.Color.Transparent
        Me.LabelAmbit.Font = New System.Drawing.Font("Dubai", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAmbit.ForeColor = System.Drawing.Color.White
        Me.LabelAmbit.Location = New System.Drawing.Point(623, 97)
        Me.LabelAmbit.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelAmbit.Name = "LabelAmbit"
        Me.LabelAmbit.Size = New System.Drawing.Size(47, 24)
        Me.LabelAmbit.TabIndex = 137
        Me.LabelAmbit.Text = "Àmbit"
        '
        'VoluntarisList
        '
        Me.VoluntarisList.BackColor = System.Drawing.SystemColors.Window
        Me.VoluntarisList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.VoluntarisList.Enabled = False
        Me.VoluntarisList.Font = New System.Drawing.Font("Dubai", 9.0!, System.Drawing.FontStyle.Bold)
        Me.VoluntarisList.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.VoluntarisList.FormattingEnabled = True
        Me.VoluntarisList.Location = New System.Drawing.Point(627, 301)
        Me.VoluntarisList.Name = "VoluntarisList"
        Me.VoluntarisList.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.VoluntarisList.Size = New System.Drawing.Size(193, 186)
        Me.VoluntarisList.Sorted = True
        Me.VoluntarisList.TabIndex = 138
        '
        'ComboBoxAmbits
        '
        Me.ComboBoxAmbits.BackColor = System.Drawing.SystemColors.Window
        Me.ComboBoxAmbits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxAmbits.Font = New System.Drawing.Font("Dubai", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ComboBoxAmbits.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ComboBoxAmbits.FormattingEnabled = True
        Me.ComboBoxAmbits.Location = New System.Drawing.Point(627, 124)
        Me.ComboBoxAmbits.Name = "ComboBoxAmbits"
        Me.ComboBoxAmbits.Size = New System.Drawing.Size(193, 29)
        Me.ComboBoxAmbits.TabIndex = 140
        '
        'LabelTasques
        '
        Me.LabelTasques.AutoSize = True
        Me.LabelTasques.BackColor = System.Drawing.Color.Transparent
        Me.LabelTasques.Font = New System.Drawing.Font("Dubai", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTasques.ForeColor = System.Drawing.Color.White
        Me.LabelTasques.Location = New System.Drawing.Point(195, 322)
        Me.LabelTasques.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelTasques.Name = "LabelTasques"
        Me.LabelTasques.Size = New System.Drawing.Size(60, 24)
        Me.LabelTasques.TabIndex = 141
        Me.LabelTasques.Text = "Tasques"
        '
        'maxVoluntaris
        '
        Me.maxVoluntaris.BackColor = System.Drawing.SystemColors.Window
        Me.maxVoluntaris.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.maxVoluntaris.Enabled = False
        Me.maxVoluntaris.Font = New System.Drawing.Font("Dubai", 9.0!, System.Drawing.FontStyle.Bold)
        Me.maxVoluntaris.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.maxVoluntaris.FormattingEnabled = True
        Me.maxVoluntaris.Items.AddRange(New Object() {"2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20"})
        Me.maxVoluntaris.Location = New System.Drawing.Point(627, 242)
        Me.maxVoluntaris.Name = "maxVoluntaris"
        Me.maxVoluntaris.Size = New System.Drawing.Size(53, 29)
        Me.maxVoluntaris.TabIndex = 144
        '
        'LabelMaxVoluntaris
        '
        Me.LabelMaxVoluntaris.AutoSize = True
        Me.LabelMaxVoluntaris.BackColor = System.Drawing.Color.Transparent
        Me.LabelMaxVoluntaris.Font = New System.Drawing.Font("Dubai", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMaxVoluntaris.ForeColor = System.Drawing.Color.White
        Me.LabelMaxVoluntaris.Location = New System.Drawing.Point(623, 215)
        Me.LabelMaxVoluntaris.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelMaxVoluntaris.Name = "LabelMaxVoluntaris"
        Me.LabelMaxVoluntaris.Size = New System.Drawing.Size(93, 24)
        Me.LabelMaxVoluntaris.TabIndex = 143
        Me.LabelMaxVoluntaris.Text = "Nº Voluntaris"
        '
        'RemoveTasca
        '
        Me.RemoveTasca.BackgroundImage = CType(resources.GetObject("RemoveTasca.BackgroundImage"), System.Drawing.Image)
        Me.RemoveTasca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RemoveTasca.Font = New System.Drawing.Font("Dubai", 10.0!, System.Drawing.FontStyle.Bold)
        Me.RemoveTasca.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.RemoveTasca.Location = New System.Drawing.Point(166, 385)
        Me.RemoveTasca.Margin = New System.Windows.Forms.Padding(0)
        Me.RemoveTasca.Name = "RemoveTasca"
        Me.RemoveTasca.Size = New System.Drawing.Size(30, 30)
        Me.RemoveTasca.TabIndex = 146
        Me.RemoveTasca.UseVisualStyleBackColor = True
        '
        'AddTasca
        '
        Me.AddTasca.BackgroundImage = CType(resources.GetObject("AddTasca.BackgroundImage"), System.Drawing.Image)
        Me.AddTasca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.AddTasca.Font = New System.Drawing.Font("Dubai", 10.0!, System.Drawing.FontStyle.Bold)
        Me.AddTasca.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.AddTasca.Location = New System.Drawing.Point(166, 349)
        Me.AddTasca.Margin = New System.Windows.Forms.Padding(0)
        Me.AddTasca.Name = "AddTasca"
        Me.AddTasca.Size = New System.Drawing.Size(30, 30)
        Me.AddTasca.TabIndex = 145
        Me.AddTasca.Text = " "
        Me.AddTasca.UseVisualStyleBackColor = True
        '
        'ListBoxTasques
        '
        Me.ListBoxTasques.BackColor = System.Drawing.SystemColors.Window
        Me.ListBoxTasques.Font = New System.Drawing.Font("Dubai", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ListBoxTasques.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ListBoxTasques.FormattingEnabled = True
        Me.ListBoxTasques.ItemHeight = 21
        Me.ListBoxTasques.Location = New System.Drawing.Point(199, 349)
        Me.ListBoxTasques.Name = "ListBoxTasques"
        Me.ListBoxTasques.Size = New System.Drawing.Size(193, 130)
        Me.ListBoxTasques.TabIndex = 147
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
        Me.tornarMenuBtn.TabIndex = 207
        Me.tornarMenuBtn.TabStop = False
        '
        'crearProjecteBtn
        '
        Me.crearProjecteBtn.BackColor = System.Drawing.Color.Transparent
        Me.crearProjecteBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.crearProjecteBtn.Image = CType(resources.GetObject("crearProjecteBtn.Image"), System.Drawing.Image)
        Me.crearProjecteBtn.Location = New System.Drawing.Point(414, 516)
        Me.crearProjecteBtn.Name = "crearProjecteBtn"
        Me.crearProjecteBtn.Size = New System.Drawing.Size(192, 84)
        Me.crearProjecteBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.crearProjecteBtn.TabIndex = 208
        Me.crearProjecteBtn.TabStop = False
        '
        'ProjectesCrear
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1008, 679)
        Me.Controls.Add(Me.crearProjecteBtn)
        Me.Controls.Add(Me.tornarMenuBtn)
        Me.Controls.Add(Me.ListBoxTasques)
        Me.Controls.Add(Me.RemoveTasca)
        Me.Controls.Add(Me.AddTasca)
        Me.Controls.Add(Me.maxVoluntaris)
        Me.Controls.Add(Me.LabelMaxVoluntaris)
        Me.Controls.Add(Me.LabelTasques)
        Me.Controls.Add(Me.ComboBoxAmbits)
        Me.Controls.Add(Me.VoluntarisList)
        Me.Controls.Add(Me.LabelVoluntaris)
        Me.Controls.Add(Me.LabelAmbit)
        Me.Controls.Add(Me.LabelLloc)
        Me.Controls.Add(Me.TextBoxLloc)
        Me.Controls.Add(Me.LabelFinalitzacio)
        Me.Controls.Add(Me.finalitzacioProjecte)
        Me.Controls.Add(Me.LabelInici)
        Me.Controls.Add(Me.iniciProjecte)
        Me.Controls.Add(Me.ComboBoxCoordinador)
        Me.Controls.Add(Me.LabelCoordinador)
        Me.Controls.Add(Me.TextBoxDefinicio)
        Me.Controls.Add(Me.LabelNomProjecte)
        Me.Controls.Add(Me.TextBoxProjecte)
        Me.Controls.Add(Me.crearProjecteTitle)
        Me.Controls.Add(Me.LabelDefinicio)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1024, 718)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1024, 718)
        Me.Name = "ProjectesCrear"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Crear Projectes"
        CType(Me.crearProjecteTitle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tornarMenuBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.crearProjecteBtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents crearProjecteTitle As PictureBox
    Friend WithEvents TextBoxProjecte As TextBox
    Friend WithEvents LabelNomProjecte As Label
    Friend WithEvents LabelDefinicio As Label
    Friend WithEvents TextBoxDefinicio As TextBox
    Friend WithEvents LabelCoordinador As Label
    Friend WithEvents ComboBoxCoordinador As ComboBox
    Friend WithEvents iniciProjecte As MonthCalendar
    Friend WithEvents LabelInici As Label
    Friend WithEvents LabelFinalitzacio As Label
    Friend WithEvents finalitzacioProjecte As MonthCalendar
    Friend WithEvents LabelLloc As Label
    Friend WithEvents TextBoxLloc As TextBox
    Friend WithEvents LabelVoluntaris As Label
    Friend WithEvents LabelAmbit As Label
    Friend WithEvents VoluntarisList As CheckedListBox
    Friend WithEvents ComboBoxAmbits As ComboBox
    Friend WithEvents LabelTasques As Label
    Friend WithEvents maxVoluntaris As ComboBox
    Friend WithEvents LabelMaxVoluntaris As Label
    Friend WithEvents RemoveTasca As Button
    Friend WithEvents AddTasca As Button
    Friend WithEvents ListBoxTasques As ListBox
    Private WithEvents tornarMenuBtn As PictureBox
    Private WithEvents crearProjecteBtn As PictureBox
End Class
