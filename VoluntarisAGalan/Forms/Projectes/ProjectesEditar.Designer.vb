<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProjectesEditar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProjectesEditar))
        Me.editarProjecteTitle = New System.Windows.Forms.PictureBox()
        Me.TasquesList = New System.Windows.Forms.ListBox()
        Me.RemoveTasca = New System.Windows.Forms.Button()
        Me.AddTasca = New System.Windows.Forms.Button()
        Me.LabelMaxVoluntaris = New System.Windows.Forms.Label()
        Me.LabelTasques = New System.Windows.Forms.Label()
        Me.ComboBoxAmbits = New System.Windows.Forms.ComboBox()
        Me.VoluntarisList = New System.Windows.Forms.CheckedListBox()
        Me.LabelVoluntaris = New System.Windows.Forms.Label()
        Me.LabelAmbit = New System.Windows.Forms.Label()
        Me.LabelLloc = New System.Windows.Forms.Label()
        Me.TextBoxLloc = New System.Windows.Forms.TextBox()
        Me.LabelFinalitzacio = New System.Windows.Forms.Label()
        Me.finalitzacioProjecte = New System.Windows.Forms.MonthCalendar()
        Me.LabelInici = New System.Windows.Forms.Label()
        Me.iniciProjecte = New System.Windows.Forms.MonthCalendar()
        Me.ComboBoxCoordinador = New System.Windows.Forms.ComboBox()
        Me.LabelCoordinador = New System.Windows.Forms.Label()
        Me.TextBoxDefinicio = New System.Windows.Forms.TextBox()
        Me.LabelNomProjecte = New System.Windows.Forms.Label()
        Me.TextBoxProjecte = New System.Windows.Forms.TextBox()
        Me.LabelDefinicio = New System.Windows.Forms.Label()
        Me.editProjecteBtn = New System.Windows.Forms.PictureBox()
        Me.tornarMenuBtn = New System.Windows.Forms.PictureBox()
        Me.TextBoxEstat = New System.Windows.Forms.TextBox()
        Me.LabelEstat = New System.Windows.Forms.Label()
        Me.previousBtn = New System.Windows.Forms.PictureBox()
        Me.nextBtn = New System.Windows.Forms.PictureBox()
        Me.ComboBoxProjectes = New System.Windows.Forms.ComboBox()
        Me.LabelProjecte = New System.Windows.Forms.Label()
        Me.maxVoluntaris = New System.Windows.Forms.ComboBox()
        Me.LabelDescartar = New System.Windows.Forms.Label()
        Me.DescartarBtn = New System.Windows.Forms.Button()
        CType(Me.editarProjecteTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.editProjecteBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tornarMenuBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.previousBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nextBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'editarProjecteTitle
        '
        Me.editarProjecteTitle.BackColor = System.Drawing.Color.Transparent
        Me.editarProjecteTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.editarProjecteTitle.Image = CType(resources.GetObject("editarProjecteTitle.Image"), System.Drawing.Image)
        Me.editarProjecteTitle.Location = New System.Drawing.Point(0, 0)
        Me.editarProjecteTitle.Name = "editarProjecteTitle"
        Me.editarProjecteTitle.Size = New System.Drawing.Size(1008, 101)
        Me.editarProjecteTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.editarProjecteTitle.TabIndex = 29
        Me.editarProjecteTitle.TabStop = False
        '
        'TasquesList
        '
        Me.TasquesList.BackColor = System.Drawing.SystemColors.Window
        Me.TasquesList.Font = New System.Drawing.Font("Dubai", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TasquesList.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.TasquesList.FormattingEnabled = True
        Me.TasquesList.ItemHeight = 21
        Me.TasquesList.Location = New System.Drawing.Point(190, 337)
        Me.TasquesList.Name = "TasquesList"
        Me.TasquesList.Size = New System.Drawing.Size(193, 130)
        Me.TasquesList.TabIndex = 192
        '
        'RemoveTasca
        '
        Me.RemoveTasca.BackgroundImage = CType(resources.GetObject("RemoveTasca.BackgroundImage"), System.Drawing.Image)
        Me.RemoveTasca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RemoveTasca.Font = New System.Drawing.Font("Dubai", 10.0!, System.Drawing.FontStyle.Bold)
        Me.RemoveTasca.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.RemoveTasca.Location = New System.Drawing.Point(157, 373)
        Me.RemoveTasca.Margin = New System.Windows.Forms.Padding(0)
        Me.RemoveTasca.Name = "RemoveTasca"
        Me.RemoveTasca.Size = New System.Drawing.Size(30, 30)
        Me.RemoveTasca.TabIndex = 191
        Me.RemoveTasca.UseVisualStyleBackColor = True
        '
        'AddTasca
        '
        Me.AddTasca.BackgroundImage = CType(resources.GetObject("AddTasca.BackgroundImage"), System.Drawing.Image)
        Me.AddTasca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.AddTasca.Font = New System.Drawing.Font("Dubai", 10.0!, System.Drawing.FontStyle.Bold)
        Me.AddTasca.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.AddTasca.Location = New System.Drawing.Point(157, 337)
        Me.AddTasca.Margin = New System.Windows.Forms.Padding(0)
        Me.AddTasca.Name = "AddTasca"
        Me.AddTasca.Size = New System.Drawing.Size(30, 30)
        Me.AddTasca.TabIndex = 190
        Me.AddTasca.Text = " "
        Me.AddTasca.UseVisualStyleBackColor = True
        '
        'LabelMaxVoluntaris
        '
        Me.LabelMaxVoluntaris.AutoSize = True
        Me.LabelMaxVoluntaris.BackColor = System.Drawing.Color.Transparent
        Me.LabelMaxVoluntaris.Font = New System.Drawing.Font("Dubai", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMaxVoluntaris.ForeColor = System.Drawing.Color.White
        Me.LabelMaxVoluntaris.Location = New System.Drawing.Point(186, 470)
        Me.LabelMaxVoluntaris.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelMaxVoluntaris.Name = "LabelMaxVoluntaris"
        Me.LabelMaxVoluntaris.Size = New System.Drawing.Size(93, 24)
        Me.LabelMaxVoluntaris.TabIndex = 188
        Me.LabelMaxVoluntaris.Text = "Nº Voluntaris"
        '
        'LabelTasques
        '
        Me.LabelTasques.AutoSize = True
        Me.LabelTasques.BackColor = System.Drawing.Color.Transparent
        Me.LabelTasques.Font = New System.Drawing.Font("Dubai", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTasques.ForeColor = System.Drawing.Color.White
        Me.LabelTasques.Location = New System.Drawing.Point(186, 310)
        Me.LabelTasques.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelTasques.Name = "LabelTasques"
        Me.LabelTasques.Size = New System.Drawing.Size(60, 24)
        Me.LabelTasques.TabIndex = 187
        Me.LabelTasques.Text = "Tasques"
        '
        'ComboBoxAmbits
        '
        Me.ComboBoxAmbits.BackColor = System.Drawing.SystemColors.Window
        Me.ComboBoxAmbits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxAmbits.Font = New System.Drawing.Font("Dubai", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ComboBoxAmbits.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ComboBoxAmbits.FormattingEnabled = True
        Me.ComboBoxAmbits.Location = New System.Drawing.Point(405, 329)
        Me.ComboBoxAmbits.Name = "ComboBoxAmbits"
        Me.ComboBoxAmbits.Size = New System.Drawing.Size(193, 29)
        Me.ComboBoxAmbits.TabIndex = 186
        '
        'VoluntarisList
        '
        Me.VoluntarisList.BackColor = System.Drawing.SystemColors.Window
        Me.VoluntarisList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.VoluntarisList.Font = New System.Drawing.Font("Dubai", 9.0!, System.Drawing.FontStyle.Bold)
        Me.VoluntarisList.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.VoluntarisList.FormattingEnabled = True
        Me.VoluntarisList.Location = New System.Drawing.Point(619, 329)
        Me.VoluntarisList.Name = "VoluntarisList"
        Me.VoluntarisList.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.VoluntarisList.Size = New System.Drawing.Size(193, 140)
        Me.VoluntarisList.Sorted = True
        Me.VoluntarisList.TabIndex = 185
        '
        'LabelVoluntaris
        '
        Me.LabelVoluntaris.AutoSize = True
        Me.LabelVoluntaris.BackColor = System.Drawing.Color.Transparent
        Me.LabelVoluntaris.Font = New System.Drawing.Font("Dubai", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelVoluntaris.ForeColor = System.Drawing.Color.White
        Me.LabelVoluntaris.Location = New System.Drawing.Point(615, 302)
        Me.LabelVoluntaris.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelVoluntaris.Name = "LabelVoluntaris"
        Me.LabelVoluntaris.Size = New System.Drawing.Size(74, 24)
        Me.LabelVoluntaris.TabIndex = 183
        Me.LabelVoluntaris.Text = "Voluntaris"
        '
        'LabelAmbit
        '
        Me.LabelAmbit.AutoSize = True
        Me.LabelAmbit.BackColor = System.Drawing.Color.Transparent
        Me.LabelAmbit.Font = New System.Drawing.Font("Dubai", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAmbit.ForeColor = System.Drawing.Color.White
        Me.LabelAmbit.Location = New System.Drawing.Point(401, 302)
        Me.LabelAmbit.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelAmbit.Name = "LabelAmbit"
        Me.LabelAmbit.Size = New System.Drawing.Size(47, 24)
        Me.LabelAmbit.TabIndex = 184
        Me.LabelAmbit.Text = "Àmbit"
        '
        'LabelLloc
        '
        Me.LabelLloc.AutoSize = True
        Me.LabelLloc.BackColor = System.Drawing.Color.Transparent
        Me.LabelLloc.Font = New System.Drawing.Font("Dubai", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLloc.ForeColor = System.Drawing.Color.White
        Me.LabelLloc.Location = New System.Drawing.Point(186, 236)
        Me.LabelLloc.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelLloc.Name = "LabelLloc"
        Me.LabelLloc.Size = New System.Drawing.Size(118, 24)
        Me.LabelLloc.TabIndex = 182
        Me.LabelLloc.Text = "Lloc on es realitza"
        '
        'TextBoxLloc
        '
        Me.TextBoxLloc.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxLloc.Font = New System.Drawing.Font("Dubai", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TextBoxLloc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.TextBoxLloc.Location = New System.Drawing.Point(190, 263)
        Me.TextBoxLloc.Multiline = True
        Me.TextBoxLloc.Name = "TextBoxLloc"
        Me.TextBoxLloc.Size = New System.Drawing.Size(193, 44)
        Me.TextBoxLloc.TabIndex = 181
        '
        'LabelFinalitzacio
        '
        Me.LabelFinalitzacio.AutoSize = True
        Me.LabelFinalitzacio.BackColor = System.Drawing.Color.Transparent
        Me.LabelFinalitzacio.Font = New System.Drawing.Font("Dubai", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFinalitzacio.ForeColor = System.Drawing.Color.White
        Me.LabelFinalitzacio.Location = New System.Drawing.Point(615, 104)
        Me.LabelFinalitzacio.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelFinalitzacio.Name = "LabelFinalitzacio"
        Me.LabelFinalitzacio.Size = New System.Drawing.Size(155, 24)
        Me.LabelFinalitzacio.TabIndex = 180
        Me.LabelFinalitzacio.Text = "Finalització del Projecte"
        '
        'finalitzacioProjecte
        '
        Me.finalitzacioProjecte.BackColor = System.Drawing.SystemColors.Window
        Me.finalitzacioProjecte.Font = New System.Drawing.Font("Dubai", 9.0!, System.Drawing.FontStyle.Bold)
        Me.finalitzacioProjecte.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.finalitzacioProjecte.Location = New System.Drawing.Point(619, 131)
        Me.finalitzacioProjecte.MaxSelectionCount = 1
        Me.finalitzacioProjecte.Name = "finalitzacioProjecte"
        Me.finalitzacioProjecte.TabIndex = 179
        Me.finalitzacioProjecte.TitleBackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.finalitzacioProjecte.TrailingForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(63, Byte), Integer))
        '
        'LabelInici
        '
        Me.LabelInici.AutoSize = True
        Me.LabelInici.BackColor = System.Drawing.Color.Transparent
        Me.LabelInici.Font = New System.Drawing.Font("Dubai", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelInici.ForeColor = System.Drawing.Color.White
        Me.LabelInici.Location = New System.Drawing.Point(401, 104)
        Me.LabelInici.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelInici.Name = "LabelInici"
        Me.LabelInici.Size = New System.Drawing.Size(111, 24)
        Me.LabelInici.TabIndex = 178
        Me.LabelInici.Text = "Inici del Projecte"
        '
        'iniciProjecte
        '
        Me.iniciProjecte.BackColor = System.Drawing.SystemColors.Window
        Me.iniciProjecte.Font = New System.Drawing.Font("Dubai", 9.0!, System.Drawing.FontStyle.Bold)
        Me.iniciProjecte.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.iniciProjecte.Location = New System.Drawing.Point(405, 131)
        Me.iniciProjecte.MaxSelectionCount = 1
        Me.iniciProjecte.Name = "iniciProjecte"
        Me.iniciProjecte.TabIndex = 177
        Me.iniciProjecte.TitleBackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.iniciProjecte.TrailingForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(63, Byte), Integer))
        '
        'ComboBoxCoordinador
        '
        Me.ComboBoxCoordinador.BackColor = System.Drawing.SystemColors.Window
        Me.ComboBoxCoordinador.Font = New System.Drawing.Font("Dubai", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ComboBoxCoordinador.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ComboBoxCoordinador.FormattingEnabled = True
        Me.ComboBoxCoordinador.Location = New System.Drawing.Point(405, 389)
        Me.ComboBoxCoordinador.Name = "ComboBoxCoordinador"
        Me.ComboBoxCoordinador.Size = New System.Drawing.Size(193, 29)
        Me.ComboBoxCoordinador.Sorted = True
        Me.ComboBoxCoordinador.TabIndex = 176
        '
        'LabelCoordinador
        '
        Me.LabelCoordinador.AutoSize = True
        Me.LabelCoordinador.BackColor = System.Drawing.Color.Transparent
        Me.LabelCoordinador.Font = New System.Drawing.Font("Dubai", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCoordinador.ForeColor = System.Drawing.Color.White
        Me.LabelCoordinador.Location = New System.Drawing.Point(401, 362)
        Me.LabelCoordinador.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelCoordinador.Name = "LabelCoordinador"
        Me.LabelCoordinador.Size = New System.Drawing.Size(87, 24)
        Me.LabelCoordinador.TabIndex = 175
        Me.LabelCoordinador.Text = "Coordinador"
        '
        'TextBoxDefinicio
        '
        Me.TextBoxDefinicio.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxDefinicio.Font = New System.Drawing.Font("Dubai", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TextBoxDefinicio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.TextBoxDefinicio.Location = New System.Drawing.Point(190, 189)
        Me.TextBoxDefinicio.Multiline = True
        Me.TextBoxDefinicio.Name = "TextBoxDefinicio"
        Me.TextBoxDefinicio.Size = New System.Drawing.Size(193, 44)
        Me.TextBoxDefinicio.TabIndex = 173
        '
        'LabelNomProjecte
        '
        Me.LabelNomProjecte.AutoSize = True
        Me.LabelNomProjecte.BackColor = System.Drawing.Color.Transparent
        Me.LabelNomProjecte.Font = New System.Drawing.Font("Dubai", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNomProjecte.ForeColor = System.Drawing.Color.White
        Me.LabelNomProjecte.Location = New System.Drawing.Point(186, 104)
        Me.LabelNomProjecte.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelNomProjecte.Name = "LabelNomProjecte"
        Me.LabelNomProjecte.Size = New System.Drawing.Size(114, 24)
        Me.LabelNomProjecte.TabIndex = 172
        Me.LabelNomProjecte.Text = "Nom del Projecte"
        '
        'TextBoxProjecte
        '
        Me.TextBoxProjecte.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxProjecte.Font = New System.Drawing.Font("Dubai", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TextBoxProjecte.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.TextBoxProjecte.Location = New System.Drawing.Point(190, 131)
        Me.TextBoxProjecte.Name = "TextBoxProjecte"
        Me.TextBoxProjecte.Size = New System.Drawing.Size(193, 28)
        Me.TextBoxProjecte.TabIndex = 171
        '
        'LabelDefinicio
        '
        Me.LabelDefinicio.AutoSize = True
        Me.LabelDefinicio.BackColor = System.Drawing.Color.Transparent
        Me.LabelDefinicio.Font = New System.Drawing.Font("Dubai", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDefinicio.ForeColor = System.Drawing.Color.White
        Me.LabelDefinicio.Location = New System.Drawing.Point(186, 162)
        Me.LabelDefinicio.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelDefinicio.Name = "LabelDefinicio"
        Me.LabelDefinicio.Size = New System.Drawing.Size(141, 24)
        Me.LabelDefinicio.TabIndex = 174
        Me.LabelDefinicio.Text = "Definició del Projecte"
        '
        'editProjecteBtn
        '
        Me.editProjecteBtn.BackColor = System.Drawing.Color.Transparent
        Me.editProjecteBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.editProjecteBtn.Image = CType(resources.GetObject("editProjecteBtn.Image"), System.Drawing.Image)
        Me.editProjecteBtn.Location = New System.Drawing.Point(405, 583)
        Me.editProjecteBtn.Name = "editProjecteBtn"
        Me.editProjecteBtn.Size = New System.Drawing.Size(193, 84)
        Me.editProjecteBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.editProjecteBtn.TabIndex = 210
        Me.editProjecteBtn.TabStop = False
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
        Me.tornarMenuBtn.TabIndex = 209
        Me.tornarMenuBtn.TabStop = False
        '
        'TextBoxEstat
        '
        Me.TextBoxEstat.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxEstat.Font = New System.Drawing.Font("Dubai", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TextBoxEstat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.TextBoxEstat.Location = New System.Drawing.Point(268, 497)
        Me.TextBoxEstat.Name = "TextBoxEstat"
        Me.TextBoxEstat.ReadOnly = True
        Me.TextBoxEstat.Size = New System.Drawing.Size(115, 28)
        Me.TextBoxEstat.TabIndex = 211
        '
        'LabelEstat
        '
        Me.LabelEstat.AutoSize = True
        Me.LabelEstat.BackColor = System.Drawing.Color.Transparent
        Me.LabelEstat.Font = New System.Drawing.Font("Dubai", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEstat.ForeColor = System.Drawing.Color.White
        Me.LabelEstat.Location = New System.Drawing.Point(342, 470)
        Me.LabelEstat.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelEstat.Name = "LabelEstat"
        Me.LabelEstat.Size = New System.Drawing.Size(41, 24)
        Me.LabelEstat.TabIndex = 212
        Me.LabelEstat.Text = "Estat"
        '
        'previousBtn
        '
        Me.previousBtn.BackColor = System.Drawing.Color.Transparent
        Me.previousBtn.BackgroundImage = CType(resources.GetObject("previousBtn.BackgroundImage"), System.Drawing.Image)
        Me.previousBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.previousBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.previousBtn.Location = New System.Drawing.Point(443, 444)
        Me.previousBtn.Name = "previousBtn"
        Me.previousBtn.Size = New System.Drawing.Size(50, 50)
        Me.previousBtn.TabIndex = 216
        Me.previousBtn.TabStop = False
        '
        'nextBtn
        '
        Me.nextBtn.BackColor = System.Drawing.Color.Transparent
        Me.nextBtn.BackgroundImage = CType(resources.GetObject("nextBtn.BackgroundImage"), System.Drawing.Image)
        Me.nextBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.nextBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.nextBtn.Location = New System.Drawing.Point(514, 444)
        Me.nextBtn.Name = "nextBtn"
        Me.nextBtn.Size = New System.Drawing.Size(50, 50)
        Me.nextBtn.TabIndex = 215
        Me.nextBtn.TabStop = False
        '
        'ComboBoxProjectes
        '
        Me.ComboBoxProjectes.Font = New System.Drawing.Font("Dubai", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ComboBoxProjectes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ComboBoxProjectes.FormattingEnabled = True
        Me.ComboBoxProjectes.Location = New System.Drawing.Point(346, 541)
        Me.ComboBoxProjectes.Name = "ComboBoxProjectes"
        Me.ComboBoxProjectes.Size = New System.Drawing.Size(311, 29)
        Me.ComboBoxProjectes.Sorted = True
        Me.ComboBoxProjectes.TabIndex = 214
        '
        'LabelProjecte
        '
        Me.LabelProjecte.AutoSize = True
        Me.LabelProjecte.BackColor = System.Drawing.Color.Transparent
        Me.LabelProjecte.Font = New System.Drawing.Font("Dubai", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelProjecte.ForeColor = System.Drawing.Color.White
        Me.LabelProjecte.Location = New System.Drawing.Point(457, 502)
        Me.LabelProjecte.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelProjecte.Name = "LabelProjecte"
        Me.LabelProjecte.Size = New System.Drawing.Size(87, 24)
        Me.LabelProjecte.TabIndex = 213
        Me.LabelProjecte.Text = "Projecte nº ?"
        Me.LabelProjecte.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'maxVoluntaris
        '
        Me.maxVoluntaris.BackColor = System.Drawing.SystemColors.Window
        Me.maxVoluntaris.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.maxVoluntaris.Font = New System.Drawing.Font("Dubai", 9.0!, System.Drawing.FontStyle.Bold)
        Me.maxVoluntaris.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.maxVoluntaris.FormattingEnabled = True
        Me.maxVoluntaris.Items.AddRange(New Object() {"2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20"})
        Me.maxVoluntaris.Location = New System.Drawing.Point(190, 497)
        Me.maxVoluntaris.Name = "maxVoluntaris"
        Me.maxVoluntaris.Size = New System.Drawing.Size(53, 29)
        Me.maxVoluntaris.TabIndex = 217
        '
        'LabelDescartar
        '
        Me.LabelDescartar.AutoSize = True
        Me.LabelDescartar.BackColor = System.Drawing.Color.Transparent
        Me.LabelDescartar.Font = New System.Drawing.Font("Dubai", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDescartar.ForeColor = System.Drawing.Color.White
        Me.LabelDescartar.Location = New System.Drawing.Point(654, 481)
        Me.LabelDescartar.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelDescartar.Name = "LabelDescartar"
        Me.LabelDescartar.Size = New System.Drawing.Size(121, 24)
        Me.LabelDescartar.TabIndex = 219
        Me.LabelDescartar.Text = "Descartar Projecte"
        '
        'DescartarBtn
        '
        Me.DescartarBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.DescartarBtn.BackgroundImage = CType(resources.GetObject("DescartarBtn.BackgroundImage"), System.Drawing.Image)
        Me.DescartarBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.DescartarBtn.Location = New System.Drawing.Point(691, 509)
        Me.DescartarBtn.Name = "DescartarBtn"
        Me.DescartarBtn.Size = New System.Drawing.Size(50, 50)
        Me.DescartarBtn.TabIndex = 218
        Me.DescartarBtn.UseVisualStyleBackColor = False
        '
        'ProjectesEditar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1008, 679)
        Me.Controls.Add(Me.LabelDescartar)
        Me.Controls.Add(Me.DescartarBtn)
        Me.Controls.Add(Me.maxVoluntaris)
        Me.Controls.Add(Me.previousBtn)
        Me.Controls.Add(Me.nextBtn)
        Me.Controls.Add(Me.ComboBoxProjectes)
        Me.Controls.Add(Me.LabelProjecte)
        Me.Controls.Add(Me.LabelEstat)
        Me.Controls.Add(Me.TextBoxEstat)
        Me.Controls.Add(Me.editProjecteBtn)
        Me.Controls.Add(Me.tornarMenuBtn)
        Me.Controls.Add(Me.TasquesList)
        Me.Controls.Add(Me.RemoveTasca)
        Me.Controls.Add(Me.AddTasca)
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
        Me.Controls.Add(Me.LabelDefinicio)
        Me.Controls.Add(Me.editarProjecteTitle)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1024, 718)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1024, 718)
        Me.Name = "ProjectesEditar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Editar Projectes"
        CType(Me.editarProjecteTitle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.editProjecteBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tornarMenuBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.previousBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nextBtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents editarProjecteTitle As PictureBox
    Friend WithEvents TasquesList As ListBox
    Friend WithEvents RemoveTasca As Button
    Friend WithEvents AddTasca As Button
    Friend WithEvents LabelMaxVoluntaris As Label
    Friend WithEvents LabelTasques As Label
    Friend WithEvents ComboBoxAmbits As ComboBox
    Friend WithEvents VoluntarisList As CheckedListBox
    Friend WithEvents LabelVoluntaris As Label
    Friend WithEvents LabelAmbit As Label
    Friend WithEvents LabelLloc As Label
    Friend WithEvents TextBoxLloc As TextBox
    Friend WithEvents LabelFinalitzacio As Label
    Friend WithEvents finalitzacioProjecte As MonthCalendar
    Friend WithEvents LabelInici As Label
    Friend WithEvents iniciProjecte As MonthCalendar
    Friend WithEvents ComboBoxCoordinador As ComboBox
    Friend WithEvents LabelCoordinador As Label
    Friend WithEvents TextBoxDefinicio As TextBox
    Friend WithEvents LabelNomProjecte As Label
    Friend WithEvents TextBoxProjecte As TextBox
    Friend WithEvents LabelDefinicio As Label
    Private WithEvents editProjecteBtn As PictureBox
    Private WithEvents tornarMenuBtn As PictureBox
    Friend WithEvents TextBoxEstat As TextBox
    Friend WithEvents LabelEstat As Label
    Friend WithEvents previousBtn As PictureBox
    Friend WithEvents nextBtn As PictureBox
    Friend WithEvents ComboBoxProjectes As ComboBox
    Friend WithEvents LabelProjecte As Label
    Friend WithEvents maxVoluntaris As ComboBox
    Friend WithEvents LabelDescartar As Label
    Friend WithEvents DescartarBtn As Button
End Class
