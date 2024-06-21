<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VoluntarisInscripcio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VoluntarisInscripcio))
        Me.inscripcioTitle = New System.Windows.Forms.PictureBox()
        Me.LabelDataNaix = New System.Windows.Forms.Label()
        Me.LabelDisponibilitat = New System.Windows.Forms.Label()
        Me.LabelCognom1 = New System.Windows.Forms.Label()
        Me.TextBoxDisponibilitat = New System.Windows.Forms.TextBox()
        Me.LabelCognom2 = New System.Windows.Forms.Label()
        Me.CheckBoxAssegurat = New System.Windows.Forms.CheckBox()
        Me.LabelNom = New System.Windows.Forms.Label()
        Me.Motiu3 = New System.Windows.Forms.RadioButton()
        Me.TextBoxNom = New System.Windows.Forms.TextBox()
        Me.Motiu2 = New System.Windows.Forms.RadioButton()
        Me.TextBoxCognom1 = New System.Windows.Forms.TextBox()
        Me.Motiu1 = New System.Windows.Forms.RadioButton()
        Me.TextBoxCognom2 = New System.Windows.Forms.TextBox()
        Me.LabelTel2 = New System.Windows.Forms.Label()
        Me.naixementCalendari = New System.Windows.Forms.MonthCalendar()
        Me.TextBoxTel2 = New System.Windows.Forms.TextBox()
        Me.LabelNIF = New System.Windows.Forms.Label()
        Me.LabelObservacions = New System.Windows.Forms.Label()
        Me.TextBoxNIF = New System.Windows.Forms.TextBox()
        Me.TextBoxObservacions = New System.Windows.Forms.TextBox()
        Me.LabelAdreca = New System.Windows.Forms.Label()
        Me.RemoveHabilitat = New System.Windows.Forms.Button()
        Me.TextBoxAdreca = New System.Windows.Forms.TextBox()
        Me.AddHabilitat = New System.Windows.Forms.Button()
        Me.LabelTel1 = New System.Windows.Forms.Label()
        Me.TextBoxTel1 = New System.Windows.Forms.TextBox()
        Me.LabelEmail = New System.Windows.Forms.Label()
        Me.TextBoxEmail = New System.Windows.Forms.TextBox()
        Me.HabilitatsList = New System.Windows.Forms.CheckedListBox()
        Me.LabelMotiu = New System.Windows.Forms.Label()
        Me.LabelHabilitats = New System.Windows.Forms.Label()
        Me.TextBoxCodiPostal = New System.Windows.Forms.TextBox()
        Me.LabelPoblacio = New System.Windows.Forms.Label()
        Me.TextBoxPoblacio = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxSexe = New System.Windows.Forms.TextBox()
        Me.LabelSexe = New System.Windows.Forms.Label()
        Me.AmbitsList = New System.Windows.Forms.CheckedListBox()
        Me.LabelAmbits = New System.Windows.Forms.Label()
        Me.LabelIdiomes = New System.Windows.Forms.Label()
        Me.IdiomesList = New System.Windows.Forms.CheckedListBox()
        Me.removeIdioma = New System.Windows.Forms.Button()
        Me.addIdioma = New System.Windows.Forms.Button()
        Me.addVoluntariBtn = New System.Windows.Forms.PictureBox()
        Me.tornarMenuBtn = New System.Windows.Forms.PictureBox()
        CType(Me.inscripcioTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.addVoluntariBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tornarMenuBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'inscripcioTitle
        '
        Me.inscripcioTitle.BackColor = System.Drawing.Color.Transparent
        Me.inscripcioTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.inscripcioTitle.Image = CType(resources.GetObject("inscripcioTitle.Image"), System.Drawing.Image)
        Me.inscripcioTitle.Location = New System.Drawing.Point(0, 0)
        Me.inscripcioTitle.Name = "inscripcioTitle"
        Me.inscripcioTitle.Size = New System.Drawing.Size(1008, 90)
        Me.inscripcioTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.inscripcioTitle.TabIndex = 26
        Me.inscripcioTitle.TabStop = False
        '
        'LabelDataNaix
        '
        Me.LabelDataNaix.AutoSize = True
        Me.LabelDataNaix.BackColor = System.Drawing.Color.Transparent
        Me.LabelDataNaix.Font = New System.Drawing.Font("Dubai", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDataNaix.ForeColor = System.Drawing.Color.White
        Me.LabelDataNaix.Location = New System.Drawing.Point(399, 96)
        Me.LabelDataNaix.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelDataNaix.Name = "LabelDataNaix"
        Me.LabelDataNaix.Size = New System.Drawing.Size(106, 24)
        Me.LabelDataNaix.TabIndex = 48
        Me.LabelDataNaix.Text = "Data naixement"
        '
        'LabelDisponibilitat
        '
        Me.LabelDisponibilitat.AutoSize = True
        Me.LabelDisponibilitat.BackColor = System.Drawing.Color.Transparent
        Me.LabelDisponibilitat.Font = New System.Drawing.Font("Dubai", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDisponibilitat.ForeColor = System.Drawing.Color.White
        Me.LabelDisponibilitat.Location = New System.Drawing.Point(399, 443)
        Me.LabelDisponibilitat.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelDisponibilitat.Name = "LabelDisponibilitat"
        Me.LabelDisponibilitat.Size = New System.Drawing.Size(95, 24)
        Me.LabelDisponibilitat.TabIndex = 72
        Me.LabelDisponibilitat.Text = "Disponibilitat"
        '
        'LabelCognom1
        '
        Me.LabelCognom1.AutoSize = True
        Me.LabelCognom1.BackColor = System.Drawing.Color.Transparent
        Me.LabelCognom1.Font = New System.Drawing.Font("Dubai", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCognom1.ForeColor = System.Drawing.Color.White
        Me.LabelCognom1.Location = New System.Drawing.Point(158, 149)
        Me.LabelCognom1.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelCognom1.Name = "LabelCognom1"
        Me.LabelCognom1.Size = New System.Drawing.Size(101, 24)
        Me.LabelCognom1.TabIndex = 45
        Me.LabelCognom1.Text = "Primer cognom"
        '
        'TextBoxDisponibilitat
        '
        Me.TextBoxDisponibilitat.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxDisponibilitat.Font = New System.Drawing.Font("Dubai", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TextBoxDisponibilitat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.TextBoxDisponibilitat.Location = New System.Drawing.Point(403, 465)
        Me.TextBoxDisponibilitat.Multiline = True
        Me.TextBoxDisponibilitat.Name = "TextBoxDisponibilitat"
        Me.TextBoxDisponibilitat.Size = New System.Drawing.Size(192, 35)
        Me.TextBoxDisponibilitat.TabIndex = 71
        '
        'LabelCognom2
        '
        Me.LabelCognom2.AutoSize = True
        Me.LabelCognom2.BackColor = System.Drawing.Color.Transparent
        Me.LabelCognom2.Font = New System.Drawing.Font("Dubai", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCognom2.ForeColor = System.Drawing.Color.White
        Me.LabelCognom2.Location = New System.Drawing.Point(158, 203)
        Me.LabelCognom2.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelCognom2.Name = "LabelCognom2"
        Me.LabelCognom2.Size = New System.Drawing.Size(99, 24)
        Me.LabelCognom2.TabIndex = 46
        Me.LabelCognom2.Text = "Segon cognom"
        '
        'CheckBoxAssegurat
        '
        Me.CheckBoxAssegurat.AutoSize = True
        Me.CheckBoxAssegurat.BackColor = System.Drawing.Color.Transparent
        Me.CheckBoxAssegurat.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CheckBoxAssegurat.Font = New System.Drawing.Font("Dubai", 10.0!, System.Drawing.FontStyle.Bold)
        Me.CheckBoxAssegurat.ForeColor = System.Drawing.Color.White
        Me.CheckBoxAssegurat.Location = New System.Drawing.Point(748, 552)
        Me.CheckBoxAssegurat.Name = "CheckBoxAssegurat"
        Me.CheckBoxAssegurat.Size = New System.Drawing.Size(89, 28)
        Me.CheckBoxAssegurat.TabIndex = 70
        Me.CheckBoxAssegurat.Text = "Assegurat"
        Me.CheckBoxAssegurat.UseVisualStyleBackColor = False
        '
        'LabelNom
        '
        Me.LabelNom.AutoSize = True
        Me.LabelNom.BackColor = System.Drawing.Color.Transparent
        Me.LabelNom.Font = New System.Drawing.Font("Dubai", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNom.ForeColor = System.Drawing.Color.White
        Me.LabelNom.Location = New System.Drawing.Point(158, 96)
        Me.LabelNom.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelNom.Name = "LabelNom"
        Me.LabelNom.Size = New System.Drawing.Size(39, 24)
        Me.LabelNom.TabIndex = 44
        Me.LabelNom.Text = "Nom"
        '
        'Motiu3
        '
        Me.Motiu3.AutoSize = True
        Me.Motiu3.BackColor = System.Drawing.Color.Transparent
        Me.Motiu3.Font = New System.Drawing.Font("Dubai", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Motiu3.ForeColor = System.Drawing.Color.White
        Me.Motiu3.Location = New System.Drawing.Point(403, 351)
        Me.Motiu3.Name = "Motiu3"
        Me.Motiu3.Size = New System.Drawing.Size(101, 25)
        Me.Motiu3.TabIndex = 69
        Me.Motiu3.TabStop = True
        Me.Motiu3.Text = "Altres entitats"
        Me.Motiu3.UseVisualStyleBackColor = False
        '
        'TextBoxNom
        '
        Me.TextBoxNom.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxNom.Font = New System.Drawing.Font("Dubai", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TextBoxNom.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.TextBoxNom.Location = New System.Drawing.Point(162, 118)
        Me.TextBoxNom.Name = "TextBoxNom"
        Me.TextBoxNom.Size = New System.Drawing.Size(203, 28)
        Me.TextBoxNom.TabIndex = 41
        '
        'Motiu2
        '
        Me.Motiu2.AutoSize = True
        Me.Motiu2.BackColor = System.Drawing.Color.Transparent
        Me.Motiu2.Font = New System.Drawing.Font("Dubai", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Motiu2.ForeColor = System.Drawing.Color.White
        Me.Motiu2.Location = New System.Drawing.Point(403, 331)
        Me.Motiu2.Name = "Motiu2"
        Me.Motiu2.Size = New System.Drawing.Size(67, 25)
        Me.Motiu2.TabIndex = 68
        Me.Motiu2.TabStop = True
        Me.Motiu2.Text = "Premsa"
        Me.Motiu2.UseVisualStyleBackColor = False
        '
        'TextBoxCognom1
        '
        Me.TextBoxCognom1.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxCognom1.Font = New System.Drawing.Font("Dubai", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TextBoxCognom1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.TextBoxCognom1.Location = New System.Drawing.Point(162, 172)
        Me.TextBoxCognom1.Name = "TextBoxCognom1"
        Me.TextBoxCognom1.Size = New System.Drawing.Size(203, 28)
        Me.TextBoxCognom1.TabIndex = 42
        '
        'Motiu1
        '
        Me.Motiu1.AutoSize = True
        Me.Motiu1.BackColor = System.Drawing.Color.Transparent
        Me.Motiu1.Font = New System.Drawing.Font("Dubai", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Motiu1.ForeColor = System.Drawing.Color.White
        Me.Motiu1.Location = New System.Drawing.Point(403, 311)
        Me.Motiu1.Name = "Motiu1"
        Me.Motiu1.Size = New System.Drawing.Size(129, 25)
        Me.Motiu1.TabIndex = 67
        Me.Motiu1.TabStop = True
        Me.Motiu1.Text = "Amics i/o Coneguts"
        Me.Motiu1.UseVisualStyleBackColor = False
        '
        'TextBoxCognom2
        '
        Me.TextBoxCognom2.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxCognom2.Font = New System.Drawing.Font("Dubai", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TextBoxCognom2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.TextBoxCognom2.Location = New System.Drawing.Point(162, 225)
        Me.TextBoxCognom2.Name = "TextBoxCognom2"
        Me.TextBoxCognom2.Size = New System.Drawing.Size(203, 28)
        Me.TextBoxCognom2.TabIndex = 43
        '
        'LabelTel2
        '
        Me.LabelTel2.AutoSize = True
        Me.LabelTel2.BackColor = System.Drawing.Color.Transparent
        Me.LabelTel2.Font = New System.Drawing.Font("Dubai", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTel2.ForeColor = System.Drawing.Color.White
        Me.LabelTel2.Location = New System.Drawing.Point(158, 541)
        Me.LabelTel2.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelTel2.Name = "LabelTel2"
        Me.LabelTel2.Size = New System.Drawing.Size(83, 24)
        Me.LabelTel2.TabIndex = 66
        Me.LabelTel2.Text = "Telèfon fixe"
        '
        'naixementCalendari
        '
        Me.naixementCalendari.BackColor = System.Drawing.SystemColors.Window
        Me.naixementCalendari.Font = New System.Drawing.Font("Dubai", 9.0!, System.Drawing.FontStyle.Bold)
        Me.naixementCalendari.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.naixementCalendari.Location = New System.Drawing.Point(403, 118)
        Me.naixementCalendari.MaxDate = New Date(2024, 4, 29, 0, 0, 0, 0)
        Me.naixementCalendari.MaxSelectionCount = 1
        Me.naixementCalendari.Name = "naixementCalendari"
        Me.naixementCalendari.TabIndex = 47
        Me.naixementCalendari.TitleBackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.naixementCalendari.TrailingForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(63, Byte), Integer))
        '
        'TextBoxTel2
        '
        Me.TextBoxTel2.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxTel2.Font = New System.Drawing.Font("Dubai", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TextBoxTel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.TextBoxTel2.Location = New System.Drawing.Point(257, 539)
        Me.TextBoxTel2.MaxLength = 12
        Me.TextBoxTel2.Name = "TextBoxTel2"
        Me.TextBoxTel2.Size = New System.Drawing.Size(108, 28)
        Me.TextBoxTel2.TabIndex = 65
        '
        'LabelNIF
        '
        Me.LabelNIF.AutoSize = True
        Me.LabelNIF.BackColor = System.Drawing.Color.Transparent
        Me.LabelNIF.Font = New System.Drawing.Font("Dubai", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNIF.ForeColor = System.Drawing.Color.White
        Me.LabelNIF.Location = New System.Drawing.Point(158, 256)
        Me.LabelNIF.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelNIF.Name = "LabelNIF"
        Me.LabelNIF.Size = New System.Drawing.Size(66, 24)
        Me.LabelNIF.TabIndex = 49
        Me.LabelNIF.Text = "NIF / NIE"
        '
        'LabelObservacions
        '
        Me.LabelObservacions.AutoSize = True
        Me.LabelObservacions.BackColor = System.Drawing.Color.Transparent
        Me.LabelObservacions.Font = New System.Drawing.Font("Dubai", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelObservacions.ForeColor = System.Drawing.Color.White
        Me.LabelObservacions.Location = New System.Drawing.Point(399, 382)
        Me.LabelObservacions.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelObservacions.Name = "LabelObservacions"
        Me.LabelObservacions.Size = New System.Drawing.Size(92, 24)
        Me.LabelObservacions.TabIndex = 64
        Me.LabelObservacions.Text = "Observacions"
        '
        'TextBoxNIF
        '
        Me.TextBoxNIF.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxNIF.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBoxNIF.Font = New System.Drawing.Font("Dubai", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TextBoxNIF.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.TextBoxNIF.Location = New System.Drawing.Point(162, 278)
        Me.TextBoxNIF.MaxLength = 9
        Me.TextBoxNIF.Name = "TextBoxNIF"
        Me.TextBoxNIF.Size = New System.Drawing.Size(87, 28)
        Me.TextBoxNIF.TabIndex = 50
        '
        'TextBoxObservacions
        '
        Me.TextBoxObservacions.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxObservacions.Font = New System.Drawing.Font("Dubai", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TextBoxObservacions.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.TextBoxObservacions.Location = New System.Drawing.Point(403, 404)
        Me.TextBoxObservacions.Multiline = True
        Me.TextBoxObservacions.Name = "TextBoxObservacions"
        Me.TextBoxObservacions.Size = New System.Drawing.Size(192, 36)
        Me.TextBoxObservacions.TabIndex = 63
        '
        'LabelAdreca
        '
        Me.LabelAdreca.AutoSize = True
        Me.LabelAdreca.BackColor = System.Drawing.Color.Transparent
        Me.LabelAdreca.Font = New System.Drawing.Font("Dubai", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAdreca.ForeColor = System.Drawing.Color.White
        Me.LabelAdreca.Location = New System.Drawing.Point(158, 362)
        Me.LabelAdreca.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelAdreca.Name = "LabelAdreca"
        Me.LabelAdreca.Size = New System.Drawing.Size(52, 24)
        Me.LabelAdreca.TabIndex = 51
        Me.LabelAdreca.Text = "Adreça"
        '
        'RemoveHabilitat
        '
        Me.RemoveHabilitat.BackgroundImage = CType(resources.GetObject("RemoveHabilitat.BackgroundImage"), System.Drawing.Image)
        Me.RemoveHabilitat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RemoveHabilitat.Font = New System.Drawing.Font("Dubai", 10.0!, System.Drawing.FontStyle.Bold)
        Me.RemoveHabilitat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.RemoveHabilitat.Location = New System.Drawing.Point(840, 321)
        Me.RemoveHabilitat.Margin = New System.Windows.Forms.Padding(0)
        Me.RemoveHabilitat.Name = "RemoveHabilitat"
        Me.RemoveHabilitat.Size = New System.Drawing.Size(30, 30)
        Me.RemoveHabilitat.TabIndex = 62
        Me.RemoveHabilitat.UseVisualStyleBackColor = True
        '
        'TextBoxAdreca
        '
        Me.TextBoxAdreca.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxAdreca.Font = New System.Drawing.Font("Dubai", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TextBoxAdreca.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.TextBoxAdreca.Location = New System.Drawing.Point(162, 384)
        Me.TextBoxAdreca.Name = "TextBoxAdreca"
        Me.TextBoxAdreca.Size = New System.Drawing.Size(203, 28)
        Me.TextBoxAdreca.TabIndex = 52
        '
        'AddHabilitat
        '
        Me.AddHabilitat.BackgroundImage = CType(resources.GetObject("AddHabilitat.BackgroundImage"), System.Drawing.Image)
        Me.AddHabilitat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.AddHabilitat.Font = New System.Drawing.Font("Dubai", 10.0!, System.Drawing.FontStyle.Bold)
        Me.AddHabilitat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.AddHabilitat.Location = New System.Drawing.Point(840, 285)
        Me.AddHabilitat.Margin = New System.Windows.Forms.Padding(0)
        Me.AddHabilitat.Name = "AddHabilitat"
        Me.AddHabilitat.Size = New System.Drawing.Size(30, 30)
        Me.AddHabilitat.TabIndex = 61
        Me.AddHabilitat.Text = " "
        Me.AddHabilitat.UseVisualStyleBackColor = True
        '
        'LabelTel1
        '
        Me.LabelTel1.AutoSize = True
        Me.LabelTel1.BackColor = System.Drawing.Color.Transparent
        Me.LabelTel1.Font = New System.Drawing.Font("Dubai", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTel1.ForeColor = System.Drawing.Color.White
        Me.LabelTel1.Location = New System.Drawing.Point(158, 490)
        Me.LabelTel1.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelTel1.Name = "LabelTel1"
        Me.LabelTel1.Size = New System.Drawing.Size(90, 24)
        Me.LabelTel1.TabIndex = 53
        Me.LabelTel1.Text = "Telèfon mòb."
        '
        'TextBoxTel1
        '
        Me.TextBoxTel1.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxTel1.Font = New System.Drawing.Font("Dubai", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TextBoxTel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.TextBoxTel1.Location = New System.Drawing.Point(257, 488)
        Me.TextBoxTel1.MaxLength = 12
        Me.TextBoxTel1.Name = "TextBoxTel1"
        Me.TextBoxTel1.Size = New System.Drawing.Size(108, 28)
        Me.TextBoxTel1.TabIndex = 54
        '
        'LabelEmail
        '
        Me.LabelEmail.AutoSize = True
        Me.LabelEmail.BackColor = System.Drawing.Color.Transparent
        Me.LabelEmail.Font = New System.Drawing.Font("Dubai", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEmail.ForeColor = System.Drawing.Color.White
        Me.LabelEmail.Location = New System.Drawing.Point(158, 415)
        Me.LabelEmail.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelEmail.Name = "LabelEmail"
        Me.LabelEmail.Size = New System.Drawing.Size(114, 24)
        Me.LabelEmail.TabIndex = 55
        Me.LabelEmail.Text = "Correu electrònic"
        '
        'TextBoxEmail
        '
        Me.TextBoxEmail.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxEmail.Font = New System.Drawing.Font("Dubai", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TextBoxEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.TextBoxEmail.Location = New System.Drawing.Point(162, 438)
        Me.TextBoxEmail.Name = "TextBoxEmail"
        Me.TextBoxEmail.Size = New System.Drawing.Size(203, 28)
        Me.TextBoxEmail.TabIndex = 56
        '
        'HabilitatsList
        '
        Me.HabilitatsList.BackColor = System.Drawing.SystemColors.Window
        Me.HabilitatsList.Font = New System.Drawing.Font("Dubai", 9.0!, System.Drawing.FontStyle.Bold)
        Me.HabilitatsList.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.HabilitatsList.FormattingEnabled = True
        Me.HabilitatsList.Location = New System.Drawing.Point(632, 284)
        Me.HabilitatsList.MultiColumn = True
        Me.HabilitatsList.Name = "HabilitatsList"
        Me.HabilitatsList.Size = New System.Drawing.Size(205, 119)
        Me.HabilitatsList.Sorted = True
        Me.HabilitatsList.TabIndex = 59
        '
        'LabelMotiu
        '
        Me.LabelMotiu.AutoSize = True
        Me.LabelMotiu.BackColor = System.Drawing.Color.Transparent
        Me.LabelMotiu.Font = New System.Drawing.Font("Dubai", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMotiu.ForeColor = System.Drawing.Color.White
        Me.LabelMotiu.Location = New System.Drawing.Point(399, 289)
        Me.LabelMotiu.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelMotiu.Name = "LabelMotiu"
        Me.LabelMotiu.Size = New System.Drawing.Size(138, 24)
        Me.LabelMotiu.TabIndex = 57
        Me.LabelMotiu.Text = "Es fa voluntari/a per:"
        '
        'LabelHabilitats
        '
        Me.LabelHabilitats.AutoSize = True
        Me.LabelHabilitats.BackColor = System.Drawing.Color.Transparent
        Me.LabelHabilitats.Font = New System.Drawing.Font("Dubai", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelHabilitats.ForeColor = System.Drawing.Color.White
        Me.LabelHabilitats.Location = New System.Drawing.Point(628, 262)
        Me.LabelHabilitats.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelHabilitats.Name = "LabelHabilitats"
        Me.LabelHabilitats.Size = New System.Drawing.Size(70, 24)
        Me.LabelHabilitats.TabIndex = 58
        Me.LabelHabilitats.Text = "Habilitats"
        '
        'TextBoxCodiPostal
        '
        Me.TextBoxCodiPostal.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxCodiPostal.Font = New System.Drawing.Font("Dubai", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TextBoxCodiPostal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.TextBoxCodiPostal.Location = New System.Drawing.Point(292, 331)
        Me.TextBoxCodiPostal.MaxLength = 5
        Me.TextBoxCodiPostal.Name = "TextBoxCodiPostal"
        Me.TextBoxCodiPostal.Size = New System.Drawing.Size(73, 28)
        Me.TextBoxCodiPostal.TabIndex = 75
        '
        'LabelPoblacio
        '
        Me.LabelPoblacio.AutoSize = True
        Me.LabelPoblacio.BackColor = System.Drawing.Color.Transparent
        Me.LabelPoblacio.Font = New System.Drawing.Font("Dubai", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPoblacio.ForeColor = System.Drawing.Color.White
        Me.LabelPoblacio.Location = New System.Drawing.Point(288, 309)
        Me.LabelPoblacio.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelPoblacio.Name = "LabelPoblacio"
        Me.LabelPoblacio.Size = New System.Drawing.Size(79, 24)
        Me.LabelPoblacio.TabIndex = 74
        Me.LabelPoblacio.Text = "Codi Postal"
        '
        'TextBoxPoblacio
        '
        Me.TextBoxPoblacio.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxPoblacio.Font = New System.Drawing.Font("Dubai", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TextBoxPoblacio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.TextBoxPoblacio.Location = New System.Drawing.Point(162, 331)
        Me.TextBoxPoblacio.Name = "TextBoxPoblacio"
        Me.TextBoxPoblacio.Size = New System.Drawing.Size(110, 28)
        Me.TextBoxPoblacio.TabIndex = 77
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Dubai", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(158, 309)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 24)
        Me.Label1.TabIndex = 76
        Me.Label1.Text = "Població"
        '
        'TextBoxSexe
        '
        Me.TextBoxSexe.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxSexe.Font = New System.Drawing.Font("Dubai", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TextBoxSexe.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.TextBoxSexe.Location = New System.Drawing.Point(292, 278)
        Me.TextBoxSexe.MaxLength = 9
        Me.TextBoxSexe.Name = "TextBoxSexe"
        Me.TextBoxSexe.Size = New System.Drawing.Size(73, 28)
        Me.TextBoxSexe.TabIndex = 79
        '
        'LabelSexe
        '
        Me.LabelSexe.AutoSize = True
        Me.LabelSexe.BackColor = System.Drawing.Color.Transparent
        Me.LabelSexe.Font = New System.Drawing.Font("Dubai", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSexe.ForeColor = System.Drawing.Color.White
        Me.LabelSexe.Location = New System.Drawing.Point(288, 256)
        Me.LabelSexe.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelSexe.Name = "LabelSexe"
        Me.LabelSexe.Size = New System.Drawing.Size(39, 24)
        Me.LabelSexe.TabIndex = 78
        Me.LabelSexe.Text = "Sexe"
        '
        'AmbitsList
        '
        Me.AmbitsList.BackColor = System.Drawing.SystemColors.Window
        Me.AmbitsList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AmbitsList.Font = New System.Drawing.Font("Dubai", 9.0!, System.Drawing.FontStyle.Bold)
        Me.AmbitsList.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.AmbitsList.FormattingEnabled = True
        Me.AmbitsList.Location = New System.Drawing.Point(632, 119)
        Me.AmbitsList.Name = "AmbitsList"
        Me.AmbitsList.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.AmbitsList.Size = New System.Drawing.Size(205, 140)
        Me.AmbitsList.Sorted = True
        Me.AmbitsList.TabIndex = 80
        '
        'LabelAmbits
        '
        Me.LabelAmbits.AutoSize = True
        Me.LabelAmbits.BackColor = System.Drawing.Color.Transparent
        Me.LabelAmbits.Font = New System.Drawing.Font("Dubai", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAmbits.ForeColor = System.Drawing.Color.White
        Me.LabelAmbits.Location = New System.Drawing.Point(628, 96)
        Me.LabelAmbits.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelAmbits.Name = "LabelAmbits"
        Me.LabelAmbits.Size = New System.Drawing.Size(53, 24)
        Me.LabelAmbits.TabIndex = 81
        Me.LabelAmbits.Text = "Àmbits"
        '
        'LabelIdiomes
        '
        Me.LabelIdiomes.AutoSize = True
        Me.LabelIdiomes.BackColor = System.Drawing.Color.Transparent
        Me.LabelIdiomes.Font = New System.Drawing.Font("Dubai", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelIdiomes.ForeColor = System.Drawing.Color.White
        Me.LabelIdiomes.Location = New System.Drawing.Point(628, 406)
        Me.LabelIdiomes.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelIdiomes.Name = "LabelIdiomes"
        Me.LabelIdiomes.Size = New System.Drawing.Size(58, 24)
        Me.LabelIdiomes.TabIndex = 83
        Me.LabelIdiomes.Text = "Idiomes"
        '
        'IdiomesList
        '
        Me.IdiomesList.BackColor = System.Drawing.SystemColors.Window
        Me.IdiomesList.Font = New System.Drawing.Font("Dubai", 9.0!, System.Drawing.FontStyle.Bold)
        Me.IdiomesList.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.IdiomesList.FormattingEnabled = True
        Me.IdiomesList.Location = New System.Drawing.Point(632, 425)
        Me.IdiomesList.MultiColumn = True
        Me.IdiomesList.Name = "IdiomesList"
        Me.IdiomesList.Size = New System.Drawing.Size(205, 119)
        Me.IdiomesList.Sorted = True
        Me.IdiomesList.TabIndex = 84
        '
        'removeIdioma
        '
        Me.removeIdioma.BackgroundImage = CType(resources.GetObject("removeIdioma.BackgroundImage"), System.Drawing.Image)
        Me.removeIdioma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.removeIdioma.Font = New System.Drawing.Font("Dubai", 10.0!, System.Drawing.FontStyle.Bold)
        Me.removeIdioma.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.removeIdioma.Location = New System.Drawing.Point(840, 461)
        Me.removeIdioma.Margin = New System.Windows.Forms.Padding(0)
        Me.removeIdioma.Name = "removeIdioma"
        Me.removeIdioma.Size = New System.Drawing.Size(30, 30)
        Me.removeIdioma.TabIndex = 86
        Me.removeIdioma.UseVisualStyleBackColor = True
        '
        'addIdioma
        '
        Me.addIdioma.BackgroundImage = CType(resources.GetObject("addIdioma.BackgroundImage"), System.Drawing.Image)
        Me.addIdioma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.addIdioma.Font = New System.Drawing.Font("Dubai", 10.0!, System.Drawing.FontStyle.Bold)
        Me.addIdioma.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.addIdioma.Location = New System.Drawing.Point(840, 425)
        Me.addIdioma.Margin = New System.Windows.Forms.Padding(0)
        Me.addIdioma.Name = "addIdioma"
        Me.addIdioma.Size = New System.Drawing.Size(30, 30)
        Me.addIdioma.TabIndex = 85
        Me.addIdioma.Text = " "
        Me.addIdioma.UseVisualStyleBackColor = True
        '
        'addVoluntariBtn
        '
        Me.addVoluntariBtn.BackColor = System.Drawing.Color.Transparent
        Me.addVoluntariBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.addVoluntariBtn.Image = CType(resources.GetObject("addVoluntariBtn.Image"), System.Drawing.Image)
        Me.addVoluntariBtn.Location = New System.Drawing.Point(403, 552)
        Me.addVoluntariBtn.Name = "addVoluntariBtn"
        Me.addVoluntariBtn.Size = New System.Drawing.Size(192, 84)
        Me.addVoluntariBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.addVoluntariBtn.TabIndex = 208
        Me.addVoluntariBtn.TabStop = False
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
        'VoluntarisInscripcio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1008, 679)
        Me.Controls.Add(Me.tornarMenuBtn)
        Me.Controls.Add(Me.addVoluntariBtn)
        Me.Controls.Add(Me.removeIdioma)
        Me.Controls.Add(Me.addIdioma)
        Me.Controls.Add(Me.IdiomesList)
        Me.Controls.Add(Me.AmbitsList)
        Me.Controls.Add(Me.TextBoxSexe)
        Me.Controls.Add(Me.LabelSexe)
        Me.Controls.Add(Me.TextBoxPoblacio)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxCodiPostal)
        Me.Controls.Add(Me.naixementCalendari)
        Me.Controls.Add(Me.TextBoxDisponibilitat)
        Me.Controls.Add(Me.TextBoxCognom1)
        Me.Controls.Add(Me.TextBoxCognom2)
        Me.Controls.Add(Me.TextBoxTel2)
        Me.Controls.Add(Me.TextBoxNIF)
        Me.Controls.Add(Me.TextBoxObservacions)
        Me.Controls.Add(Me.TextBoxAdreca)
        Me.Controls.Add(Me.TextBoxTel1)
        Me.Controls.Add(Me.TextBoxEmail)
        Me.Controls.Add(Me.HabilitatsList)
        Me.Controls.Add(Me.TextBoxNom)
        Me.Controls.Add(Me.LabelDataNaix)
        Me.Controls.Add(Me.LabelDisponibilitat)
        Me.Controls.Add(Me.LabelCognom1)
        Me.Controls.Add(Me.LabelCognom2)
        Me.Controls.Add(Me.CheckBoxAssegurat)
        Me.Controls.Add(Me.LabelNom)
        Me.Controls.Add(Me.Motiu3)
        Me.Controls.Add(Me.Motiu2)
        Me.Controls.Add(Me.Motiu1)
        Me.Controls.Add(Me.LabelTel2)
        Me.Controls.Add(Me.LabelNIF)
        Me.Controls.Add(Me.LabelObservacions)
        Me.Controls.Add(Me.LabelAdreca)
        Me.Controls.Add(Me.RemoveHabilitat)
        Me.Controls.Add(Me.AddHabilitat)
        Me.Controls.Add(Me.LabelTel1)
        Me.Controls.Add(Me.LabelEmail)
        Me.Controls.Add(Me.LabelMotiu)
        Me.Controls.Add(Me.LabelHabilitats)
        Me.Controls.Add(Me.inscripcioTitle)
        Me.Controls.Add(Me.LabelPoblacio)
        Me.Controls.Add(Me.LabelAmbits)
        Me.Controls.Add(Me.LabelIdiomes)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1024, 718)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1024, 718)
        Me.Name = "VoluntarisInscripcio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inscriure Voluntaris"
        CType(Me.inscripcioTitle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.addVoluntariBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tornarMenuBtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents inscripcioTitle As PictureBox
    Friend WithEvents LabelDataNaix As Label
    Friend WithEvents LabelDisponibilitat As Label
    Friend WithEvents LabelCognom1 As Label
    Friend WithEvents TextBoxDisponibilitat As TextBox
    Friend WithEvents LabelCognom2 As Label
    Friend WithEvents CheckBoxAssegurat As CheckBox
    Friend WithEvents LabelNom As Label
    Friend WithEvents Motiu3 As RadioButton
    Friend WithEvents TextBoxNom As TextBox
    Friend WithEvents Motiu2 As RadioButton
    Friend WithEvents TextBoxCognom1 As TextBox
    Friend WithEvents Motiu1 As RadioButton
    Friend WithEvents TextBoxCognom2 As TextBox
    Friend WithEvents LabelTel2 As Label
    Friend WithEvents naixementCalendari As MonthCalendar
    Friend WithEvents TextBoxTel2 As TextBox
    Friend WithEvents LabelNIF As Label
    Friend WithEvents LabelObservacions As Label
    Friend WithEvents TextBoxNIF As TextBox
    Friend WithEvents TextBoxObservacions As TextBox
    Friend WithEvents LabelAdreca As Label
    Friend WithEvents RemoveHabilitat As Button
    Friend WithEvents TextBoxAdreca As TextBox
    Friend WithEvents AddHabilitat As Button
    Friend WithEvents LabelTel1 As Label
    Friend WithEvents TextBoxTel1 As TextBox
    Friend WithEvents LabelEmail As Label
    Friend WithEvents TextBoxEmail As TextBox
    Friend WithEvents HabilitatsList As CheckedListBox
    Friend WithEvents LabelMotiu As Label
    Friend WithEvents LabelHabilitats As Label
    Friend WithEvents TextBoxCodiPostal As TextBox
    Friend WithEvents LabelPoblacio As Label
    Friend WithEvents TextBoxPoblacio As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxSexe As TextBox
    Friend WithEvents LabelSexe As Label
    Friend WithEvents AmbitsList As CheckedListBox
    Friend WithEvents LabelAmbits As Label
    Friend WithEvents LabelIdiomes As Label
    Friend WithEvents IdiomesList As CheckedListBox
    Friend WithEvents removeIdioma As Button
    Friend WithEvents addIdioma As Button
    Private WithEvents addVoluntariBtn As PictureBox
    Private WithEvents tornarMenuBtn As PictureBox
End Class
