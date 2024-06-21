<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VoluntarisEditar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VoluntarisEditar))
        Me.editarTitle = New System.Windows.Forms.PictureBox()
        Me.previousBtn = New System.Windows.Forms.PictureBox()
        Me.nextBtn = New System.Windows.Forms.PictureBox()
        Me.LabelIdVoluntari = New System.Windows.Forms.Label()
        Me.removeIdioma = New System.Windows.Forms.Button()
        Me.addIdioma = New System.Windows.Forms.Button()
        Me.IdiomesList = New System.Windows.Forms.CheckedListBox()
        Me.AmbitsList = New System.Windows.Forms.CheckedListBox()
        Me.TextBoxSexe = New System.Windows.Forms.TextBox()
        Me.LabelSexe = New System.Windows.Forms.Label()
        Me.TextBoxPoblacio = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxCodiPostal = New System.Windows.Forms.TextBox()
        Me.naixementCalendari = New System.Windows.Forms.MonthCalendar()
        Me.TextBoxDisponibilitat = New System.Windows.Forms.TextBox()
        Me.TextBoxCognom1 = New System.Windows.Forms.TextBox()
        Me.TextBoxCognom2 = New System.Windows.Forms.TextBox()
        Me.TextBoxTel2 = New System.Windows.Forms.TextBox()
        Me.TextBoxNIF = New System.Windows.Forms.TextBox()
        Me.TextBoxObservacions = New System.Windows.Forms.TextBox()
        Me.TextBoxAdreca = New System.Windows.Forms.TextBox()
        Me.TextBoxTel1 = New System.Windows.Forms.TextBox()
        Me.TextBoxEmail = New System.Windows.Forms.TextBox()
        Me.HabilitatsList = New System.Windows.Forms.CheckedListBox()
        Me.TextBoxNom = New System.Windows.Forms.TextBox()
        Me.LabelDataNaix = New System.Windows.Forms.Label()
        Me.LabelDisponibilitat = New System.Windows.Forms.Label()
        Me.LabelCognom1 = New System.Windows.Forms.Label()
        Me.LabelCognom2 = New System.Windows.Forms.Label()
        Me.checkBoxAssegurat = New System.Windows.Forms.CheckBox()
        Me.LabelNom = New System.Windows.Forms.Label()
        Me.Motiu3 = New System.Windows.Forms.RadioButton()
        Me.Motiu2 = New System.Windows.Forms.RadioButton()
        Me.Motiu1 = New System.Windows.Forms.RadioButton()
        Me.LabelTel2 = New System.Windows.Forms.Label()
        Me.LabelNIF = New System.Windows.Forms.Label()
        Me.LabelObservacions = New System.Windows.Forms.Label()
        Me.LabelAdreca = New System.Windows.Forms.Label()
        Me.removeHabilitat = New System.Windows.Forms.Button()
        Me.addHabilitat = New System.Windows.Forms.Button()
        Me.LabelTel1 = New System.Windows.Forms.Label()
        Me.LabelEmail = New System.Windows.Forms.Label()
        Me.LabelMotiu = New System.Windows.Forms.Label()
        Me.LabelHabilitats = New System.Windows.Forms.Label()
        Me.LabelPoblacio = New System.Windows.Forms.Label()
        Me.LabelAmbits = New System.Windows.Forms.Label()
        Me.LabelIdiomes = New System.Windows.Forms.Label()
        Me.CheckBoxActiu = New System.Windows.Forms.CheckBox()
        Me.tornarMenuBtn = New System.Windows.Forms.PictureBox()
        Me.editVoluntariBtn = New System.Windows.Forms.PictureBox()
        Me.ComboBoxVoluntaris = New System.Windows.Forms.ComboBox()
        Me.TextBoxMotiuInactiu = New System.Windows.Forms.TextBox()
        Me.LabelMotiuInactiu = New System.Windows.Forms.Label()
        CType(Me.editarTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.previousBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nextBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tornarMenuBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.editVoluntariBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'editarTitle
        '
        Me.editarTitle.BackColor = System.Drawing.Color.Transparent
        Me.editarTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.editarTitle.Image = CType(resources.GetObject("editarTitle.Image"), System.Drawing.Image)
        Me.editarTitle.Location = New System.Drawing.Point(0, 0)
        Me.editarTitle.Name = "editarTitle"
        Me.editarTitle.Size = New System.Drawing.Size(1008, 90)
        Me.editarTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.editarTitle.TabIndex = 28
        Me.editarTitle.TabStop = False
        '
        'previousBtn
        '
        Me.previousBtn.BackColor = System.Drawing.Color.Transparent
        Me.previousBtn.BackgroundImage = CType(resources.GetObject("previousBtn.BackgroundImage"), System.Drawing.Image)
        Me.previousBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.previousBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.previousBtn.Location = New System.Drawing.Point(438, 451)
        Me.previousBtn.Name = "previousBtn"
        Me.previousBtn.Size = New System.Drawing.Size(50, 50)
        Me.previousBtn.TabIndex = 155
        Me.previousBtn.TabStop = False
        '
        'nextBtn
        '
        Me.nextBtn.BackColor = System.Drawing.Color.Transparent
        Me.nextBtn.BackgroundImage = CType(resources.GetObject("nextBtn.BackgroundImage"), System.Drawing.Image)
        Me.nextBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.nextBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.nextBtn.Location = New System.Drawing.Point(509, 451)
        Me.nextBtn.Name = "nextBtn"
        Me.nextBtn.Size = New System.Drawing.Size(50, 50)
        Me.nextBtn.TabIndex = 154
        Me.nextBtn.TabStop = False
        '
        'LabelIdVoluntari
        '
        Me.LabelIdVoluntari.AutoSize = True
        Me.LabelIdVoluntari.BackColor = System.Drawing.Color.Transparent
        Me.LabelIdVoluntari.Font = New System.Drawing.Font("Dubai", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelIdVoluntari.ForeColor = System.Drawing.Color.White
        Me.LabelIdVoluntari.Location = New System.Drawing.Point(450, 506)
        Me.LabelIdVoluntari.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelIdVoluntari.Name = "LabelIdVoluntari"
        Me.LabelIdVoluntari.Size = New System.Drawing.Size(95, 24)
        Me.LabelIdVoluntari.TabIndex = 158
        Me.LabelIdVoluntari.Text = "Voluntari nº ?"
        '
        'removeIdioma
        '
        Me.removeIdioma.BackgroundImage = CType(resources.GetObject("removeIdioma.BackgroundImage"), System.Drawing.Image)
        Me.removeIdioma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.removeIdioma.Font = New System.Drawing.Font("Dubai", 10.0!, System.Drawing.FontStyle.Bold)
        Me.removeIdioma.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.removeIdioma.Location = New System.Drawing.Point(943, 461)
        Me.removeIdioma.Margin = New System.Windows.Forms.Padding(0)
        Me.removeIdioma.Name = "removeIdioma"
        Me.removeIdioma.Size = New System.Drawing.Size(30, 30)
        Me.removeIdioma.TabIndex = 204
        Me.removeIdioma.UseVisualStyleBackColor = True
        '
        'addIdioma
        '
        Me.addIdioma.BackgroundImage = CType(resources.GetObject("addIdioma.BackgroundImage"), System.Drawing.Image)
        Me.addIdioma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.addIdioma.Font = New System.Drawing.Font("Dubai", 10.0!, System.Drawing.FontStyle.Bold)
        Me.addIdioma.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.addIdioma.Location = New System.Drawing.Point(943, 425)
        Me.addIdioma.Margin = New System.Windows.Forms.Padding(0)
        Me.addIdioma.Name = "addIdioma"
        Me.addIdioma.Size = New System.Drawing.Size(30, 30)
        Me.addIdioma.TabIndex = 203
        Me.addIdioma.Text = " "
        Me.addIdioma.UseVisualStyleBackColor = True
        '
        'IdiomesList
        '
        Me.IdiomesList.BackColor = System.Drawing.SystemColors.Window
        Me.IdiomesList.Font = New System.Drawing.Font("Dubai", 9.0!, System.Drawing.FontStyle.Bold)
        Me.IdiomesList.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.IdiomesList.FormattingEnabled = True
        Me.IdiomesList.Location = New System.Drawing.Point(735, 425)
        Me.IdiomesList.MultiColumn = True
        Me.IdiomesList.Name = "IdiomesList"
        Me.IdiomesList.Size = New System.Drawing.Size(205, 119)
        Me.IdiomesList.Sorted = True
        Me.IdiomesList.TabIndex = 202
        '
        'AmbitsList
        '
        Me.AmbitsList.BackColor = System.Drawing.SystemColors.Window
        Me.AmbitsList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AmbitsList.Font = New System.Drawing.Font("Dubai", 9.0!, System.Drawing.FontStyle.Bold)
        Me.AmbitsList.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.AmbitsList.FormattingEnabled = True
        Me.AmbitsList.Location = New System.Drawing.Point(735, 115)
        Me.AmbitsList.Name = "AmbitsList"
        Me.AmbitsList.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.AmbitsList.Size = New System.Drawing.Size(205, 140)
        Me.AmbitsList.Sorted = True
        Me.AmbitsList.TabIndex = 199
        '
        'TextBoxSexe
        '
        Me.TextBoxSexe.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxSexe.Font = New System.Drawing.Font("Dubai", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TextBoxSexe.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.TextBoxSexe.Location = New System.Drawing.Point(180, 275)
        Me.TextBoxSexe.MaxLength = 9
        Me.TextBoxSexe.Name = "TextBoxSexe"
        Me.TextBoxSexe.Size = New System.Drawing.Size(73, 28)
        Me.TextBoxSexe.TabIndex = 198
        '
        'LabelSexe
        '
        Me.LabelSexe.AutoSize = True
        Me.LabelSexe.BackColor = System.Drawing.Color.Transparent
        Me.LabelSexe.Font = New System.Drawing.Font("Dubai", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSexe.ForeColor = System.Drawing.Color.White
        Me.LabelSexe.Location = New System.Drawing.Point(176, 253)
        Me.LabelSexe.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelSexe.Name = "LabelSexe"
        Me.LabelSexe.Size = New System.Drawing.Size(39, 24)
        Me.LabelSexe.TabIndex = 197
        Me.LabelSexe.Text = "Sexe"
        '
        'TextBoxPoblacio
        '
        Me.TextBoxPoblacio.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxPoblacio.Font = New System.Drawing.Font("Dubai", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TextBoxPoblacio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.TextBoxPoblacio.Location = New System.Drawing.Point(50, 328)
        Me.TextBoxPoblacio.Name = "TextBoxPoblacio"
        Me.TextBoxPoblacio.Size = New System.Drawing.Size(110, 28)
        Me.TextBoxPoblacio.TabIndex = 196
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Dubai", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(46, 306)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 24)
        Me.Label1.TabIndex = 195
        Me.Label1.Text = "Població"
        '
        'TextBoxCodiPostal
        '
        Me.TextBoxCodiPostal.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxCodiPostal.Font = New System.Drawing.Font("Dubai", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TextBoxCodiPostal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.TextBoxCodiPostal.Location = New System.Drawing.Point(180, 328)
        Me.TextBoxCodiPostal.MaxLength = 5
        Me.TextBoxCodiPostal.Name = "TextBoxCodiPostal"
        Me.TextBoxCodiPostal.Size = New System.Drawing.Size(73, 28)
        Me.TextBoxCodiPostal.TabIndex = 194
        '
        'naixementCalendari
        '
        Me.naixementCalendari.BackColor = System.Drawing.SystemColors.Window
        Me.naixementCalendari.Font = New System.Drawing.Font("Dubai", 9.0!, System.Drawing.FontStyle.Bold)
        Me.naixementCalendari.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.naixementCalendari.Location = New System.Drawing.Point(281, 115)
        Me.naixementCalendari.MaxDate = New Date(2024, 5, 12, 0, 0, 0, 0)
        Me.naixementCalendari.MaxSelectionCount = 1
        Me.naixementCalendari.Name = "naixementCalendari"
        Me.naixementCalendari.TabIndex = 168
        Me.naixementCalendari.TitleBackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.naixementCalendari.TrailingForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(63, Byte), Integer))
        '
        'TextBoxDisponibilitat
        '
        Me.TextBoxDisponibilitat.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxDisponibilitat.Font = New System.Drawing.Font("Dubai", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TextBoxDisponibilitat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.TextBoxDisponibilitat.Location = New System.Drawing.Point(501, 223)
        Me.TextBoxDisponibilitat.Multiline = True
        Me.TextBoxDisponibilitat.Name = "TextBoxDisponibilitat"
        Me.TextBoxDisponibilitat.Size = New System.Drawing.Size(205, 80)
        Me.TextBoxDisponibilitat.TabIndex = 191
        '
        'TextBoxCognom1
        '
        Me.TextBoxCognom1.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxCognom1.Font = New System.Drawing.Font("Dubai", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TextBoxCognom1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.TextBoxCognom1.Location = New System.Drawing.Point(50, 169)
        Me.TextBoxCognom1.Name = "TextBoxCognom1"
        Me.TextBoxCognom1.Size = New System.Drawing.Size(203, 28)
        Me.TextBoxCognom1.TabIndex = 163
        '
        'TextBoxCognom2
        '
        Me.TextBoxCognom2.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxCognom2.Font = New System.Drawing.Font("Dubai", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TextBoxCognom2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.TextBoxCognom2.Location = New System.Drawing.Point(50, 222)
        Me.TextBoxCognom2.Name = "TextBoxCognom2"
        Me.TextBoxCognom2.Size = New System.Drawing.Size(203, 28)
        Me.TextBoxCognom2.TabIndex = 164
        '
        'TextBoxTel2
        '
        Me.TextBoxTel2.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxTel2.Font = New System.Drawing.Font("Dubai", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TextBoxTel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.TextBoxTel2.Location = New System.Drawing.Point(146, 516)
        Me.TextBoxTel2.MaxLength = 12
        Me.TextBoxTel2.Name = "TextBoxTel2"
        Me.TextBoxTel2.Size = New System.Drawing.Size(108, 28)
        Me.TextBoxTel2.TabIndex = 185
        '
        'TextBoxNIF
        '
        Me.TextBoxNIF.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxNIF.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBoxNIF.Font = New System.Drawing.Font("Dubai", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TextBoxNIF.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.TextBoxNIF.Location = New System.Drawing.Point(50, 275)
        Me.TextBoxNIF.MaxLength = 9
        Me.TextBoxNIF.Name = "TextBoxNIF"
        Me.TextBoxNIF.Size = New System.Drawing.Size(87, 28)
        Me.TextBoxNIF.TabIndex = 171
        '
        'TextBoxObservacions
        '
        Me.TextBoxObservacions.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxObservacions.Font = New System.Drawing.Font("Dubai", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TextBoxObservacions.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.TextBoxObservacions.Location = New System.Drawing.Point(501, 115)
        Me.TextBoxObservacions.Multiline = True
        Me.TextBoxObservacions.Name = "TextBoxObservacions"
        Me.TextBoxObservacions.Size = New System.Drawing.Size(205, 82)
        Me.TextBoxObservacions.TabIndex = 183
        '
        'TextBoxAdreca
        '
        Me.TextBoxAdreca.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxAdreca.Font = New System.Drawing.Font("Dubai", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TextBoxAdreca.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.TextBoxAdreca.Location = New System.Drawing.Point(50, 381)
        Me.TextBoxAdreca.Name = "TextBoxAdreca"
        Me.TextBoxAdreca.Size = New System.Drawing.Size(203, 28)
        Me.TextBoxAdreca.TabIndex = 173
        '
        'TextBoxTel1
        '
        Me.TextBoxTel1.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxTel1.Font = New System.Drawing.Font("Dubai", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TextBoxTel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.TextBoxTel1.Location = New System.Drawing.Point(146, 476)
        Me.TextBoxTel1.MaxLength = 12
        Me.TextBoxTel1.Name = "TextBoxTel1"
        Me.TextBoxTel1.Size = New System.Drawing.Size(108, 28)
        Me.TextBoxTel1.TabIndex = 175
        '
        'TextBoxEmail
        '
        Me.TextBoxEmail.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxEmail.Font = New System.Drawing.Font("Dubai", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TextBoxEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.TextBoxEmail.Location = New System.Drawing.Point(50, 435)
        Me.TextBoxEmail.Name = "TextBoxEmail"
        Me.TextBoxEmail.Size = New System.Drawing.Size(203, 28)
        Me.TextBoxEmail.TabIndex = 177
        '
        'HabilitatsList
        '
        Me.HabilitatsList.BackColor = System.Drawing.SystemColors.Window
        Me.HabilitatsList.Font = New System.Drawing.Font("Dubai", 9.0!, System.Drawing.FontStyle.Bold)
        Me.HabilitatsList.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.HabilitatsList.FormattingEnabled = True
        Me.HabilitatsList.Location = New System.Drawing.Point(735, 281)
        Me.HabilitatsList.MultiColumn = True
        Me.HabilitatsList.Name = "HabilitatsList"
        Me.HabilitatsList.Size = New System.Drawing.Size(205, 119)
        Me.HabilitatsList.Sorted = True
        Me.HabilitatsList.TabIndex = 180
        '
        'TextBoxNom
        '
        Me.TextBoxNom.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxNom.Font = New System.Drawing.Font("Dubai", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TextBoxNom.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.TextBoxNom.Location = New System.Drawing.Point(50, 115)
        Me.TextBoxNom.Name = "TextBoxNom"
        Me.TextBoxNom.Size = New System.Drawing.Size(203, 28)
        Me.TextBoxNom.TabIndex = 162
        '
        'LabelDataNaix
        '
        Me.LabelDataNaix.AutoSize = True
        Me.LabelDataNaix.BackColor = System.Drawing.Color.Transparent
        Me.LabelDataNaix.Font = New System.Drawing.Font("Dubai", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDataNaix.ForeColor = System.Drawing.Color.White
        Me.LabelDataNaix.Location = New System.Drawing.Point(277, 93)
        Me.LabelDataNaix.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelDataNaix.Name = "LabelDataNaix"
        Me.LabelDataNaix.Size = New System.Drawing.Size(106, 24)
        Me.LabelDataNaix.TabIndex = 169
        Me.LabelDataNaix.Text = "Data naixement"
        '
        'LabelDisponibilitat
        '
        Me.LabelDisponibilitat.AutoSize = True
        Me.LabelDisponibilitat.BackColor = System.Drawing.Color.Transparent
        Me.LabelDisponibilitat.Font = New System.Drawing.Font("Dubai", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDisponibilitat.ForeColor = System.Drawing.Color.White
        Me.LabelDisponibilitat.Location = New System.Drawing.Point(497, 200)
        Me.LabelDisponibilitat.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelDisponibilitat.Name = "LabelDisponibilitat"
        Me.LabelDisponibilitat.Size = New System.Drawing.Size(95, 24)
        Me.LabelDisponibilitat.TabIndex = 192
        Me.LabelDisponibilitat.Text = "Disponibilitat"
        '
        'LabelCognom1
        '
        Me.LabelCognom1.AutoSize = True
        Me.LabelCognom1.BackColor = System.Drawing.Color.Transparent
        Me.LabelCognom1.Font = New System.Drawing.Font("Dubai", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCognom1.ForeColor = System.Drawing.Color.White
        Me.LabelCognom1.Location = New System.Drawing.Point(46, 146)
        Me.LabelCognom1.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelCognom1.Name = "LabelCognom1"
        Me.LabelCognom1.Size = New System.Drawing.Size(101, 24)
        Me.LabelCognom1.TabIndex = 166
        Me.LabelCognom1.Text = "Primer cognom"
        '
        'LabelCognom2
        '
        Me.LabelCognom2.AutoSize = True
        Me.LabelCognom2.BackColor = System.Drawing.Color.Transparent
        Me.LabelCognom2.Font = New System.Drawing.Font("Dubai", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCognom2.ForeColor = System.Drawing.Color.White
        Me.LabelCognom2.Location = New System.Drawing.Point(46, 200)
        Me.LabelCognom2.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelCognom2.Name = "LabelCognom2"
        Me.LabelCognom2.Size = New System.Drawing.Size(99, 24)
        Me.LabelCognom2.TabIndex = 167
        Me.LabelCognom2.Text = "Segon cognom"
        '
        'checkBoxAssegurat
        '
        Me.checkBoxAssegurat.AutoSize = True
        Me.checkBoxAssegurat.BackColor = System.Drawing.Color.Transparent
        Me.checkBoxAssegurat.CheckAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.checkBoxAssegurat.Font = New System.Drawing.Font("Dubai", 10.0!, System.Drawing.FontStyle.Bold)
        Me.checkBoxAssegurat.ForeColor = System.Drawing.Color.White
        Me.checkBoxAssegurat.Location = New System.Drawing.Point(281, 374)
        Me.checkBoxAssegurat.Name = "checkBoxAssegurat"
        Me.checkBoxAssegurat.Size = New System.Drawing.Size(74, 42)
        Me.checkBoxAssegurat.TabIndex = 190
        Me.checkBoxAssegurat.Text = "Assegurat"
        Me.checkBoxAssegurat.UseVisualStyleBackColor = False
        '
        'LabelNom
        '
        Me.LabelNom.AutoSize = True
        Me.LabelNom.BackColor = System.Drawing.Color.Transparent
        Me.LabelNom.Font = New System.Drawing.Font("Dubai", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNom.ForeColor = System.Drawing.Color.White
        Me.LabelNom.Location = New System.Drawing.Point(46, 93)
        Me.LabelNom.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelNom.Name = "LabelNom"
        Me.LabelNom.Size = New System.Drawing.Size(39, 24)
        Me.LabelNom.TabIndex = 165
        Me.LabelNom.Text = "Nom"
        '
        'Motiu3
        '
        Me.Motiu3.AutoSize = True
        Me.Motiu3.BackColor = System.Drawing.Color.Transparent
        Me.Motiu3.Font = New System.Drawing.Font("Dubai", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Motiu3.ForeColor = System.Drawing.Color.White
        Me.Motiu3.Location = New System.Drawing.Point(281, 348)
        Me.Motiu3.Name = "Motiu3"
        Me.Motiu3.Size = New System.Drawing.Size(101, 25)
        Me.Motiu3.TabIndex = 189
        Me.Motiu3.TabStop = True
        Me.Motiu3.Text = "Altres entitats"
        Me.Motiu3.UseVisualStyleBackColor = False
        '
        'Motiu2
        '
        Me.Motiu2.AutoSize = True
        Me.Motiu2.BackColor = System.Drawing.Color.Transparent
        Me.Motiu2.Font = New System.Drawing.Font("Dubai", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Motiu2.ForeColor = System.Drawing.Color.White
        Me.Motiu2.Location = New System.Drawing.Point(281, 328)
        Me.Motiu2.Name = "Motiu2"
        Me.Motiu2.Size = New System.Drawing.Size(67, 25)
        Me.Motiu2.TabIndex = 188
        Me.Motiu2.TabStop = True
        Me.Motiu2.Text = "Premsa"
        Me.Motiu2.UseVisualStyleBackColor = False
        '
        'Motiu1
        '
        Me.Motiu1.AutoSize = True
        Me.Motiu1.BackColor = System.Drawing.Color.Transparent
        Me.Motiu1.Font = New System.Drawing.Font("Dubai", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Motiu1.ForeColor = System.Drawing.Color.White
        Me.Motiu1.Location = New System.Drawing.Point(281, 308)
        Me.Motiu1.Name = "Motiu1"
        Me.Motiu1.Size = New System.Drawing.Size(129, 25)
        Me.Motiu1.TabIndex = 187
        Me.Motiu1.TabStop = True
        Me.Motiu1.Text = "Amics i/o Coneguts"
        Me.Motiu1.UseVisualStyleBackColor = False
        '
        'LabelTel2
        '
        Me.LabelTel2.AutoSize = True
        Me.LabelTel2.BackColor = System.Drawing.Color.Transparent
        Me.LabelTel2.Font = New System.Drawing.Font("Dubai", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTel2.ForeColor = System.Drawing.Color.White
        Me.LabelTel2.Location = New System.Drawing.Point(47, 515)
        Me.LabelTel2.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelTel2.Name = "LabelTel2"
        Me.LabelTel2.Size = New System.Drawing.Size(83, 24)
        Me.LabelTel2.TabIndex = 186
        Me.LabelTel2.Text = "Telèfon fixe"
        '
        'LabelNIF
        '
        Me.LabelNIF.AutoSize = True
        Me.LabelNIF.BackColor = System.Drawing.Color.Transparent
        Me.LabelNIF.Font = New System.Drawing.Font("Dubai", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNIF.ForeColor = System.Drawing.Color.White
        Me.LabelNIF.Location = New System.Drawing.Point(46, 253)
        Me.LabelNIF.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelNIF.Name = "LabelNIF"
        Me.LabelNIF.Size = New System.Drawing.Size(66, 24)
        Me.LabelNIF.TabIndex = 170
        Me.LabelNIF.Text = "NIF / NIE"
        '
        'LabelObservacions
        '
        Me.LabelObservacions.AutoSize = True
        Me.LabelObservacions.BackColor = System.Drawing.Color.Transparent
        Me.LabelObservacions.Font = New System.Drawing.Font("Dubai", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelObservacions.ForeColor = System.Drawing.Color.White
        Me.LabelObservacions.Location = New System.Drawing.Point(497, 93)
        Me.LabelObservacions.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelObservacions.Name = "LabelObservacions"
        Me.LabelObservacions.Size = New System.Drawing.Size(92, 24)
        Me.LabelObservacions.TabIndex = 184
        Me.LabelObservacions.Text = "Observacions"
        '
        'LabelAdreca
        '
        Me.LabelAdreca.AutoSize = True
        Me.LabelAdreca.BackColor = System.Drawing.Color.Transparent
        Me.LabelAdreca.Font = New System.Drawing.Font("Dubai", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAdreca.ForeColor = System.Drawing.Color.White
        Me.LabelAdreca.Location = New System.Drawing.Point(46, 359)
        Me.LabelAdreca.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelAdreca.Name = "LabelAdreca"
        Me.LabelAdreca.Size = New System.Drawing.Size(52, 24)
        Me.LabelAdreca.TabIndex = 172
        Me.LabelAdreca.Text = "Adreça"
        '
        'removeHabilitat
        '
        Me.removeHabilitat.BackgroundImage = CType(resources.GetObject("removeHabilitat.BackgroundImage"), System.Drawing.Image)
        Me.removeHabilitat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.removeHabilitat.Font = New System.Drawing.Font("Dubai", 10.0!, System.Drawing.FontStyle.Bold)
        Me.removeHabilitat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.removeHabilitat.Location = New System.Drawing.Point(943, 317)
        Me.removeHabilitat.Margin = New System.Windows.Forms.Padding(0)
        Me.removeHabilitat.Name = "removeHabilitat"
        Me.removeHabilitat.Size = New System.Drawing.Size(30, 30)
        Me.removeHabilitat.TabIndex = 182
        Me.removeHabilitat.UseVisualStyleBackColor = True
        '
        'addHabilitat
        '
        Me.addHabilitat.BackgroundImage = CType(resources.GetObject("addHabilitat.BackgroundImage"), System.Drawing.Image)
        Me.addHabilitat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.addHabilitat.Font = New System.Drawing.Font("Dubai", 10.0!, System.Drawing.FontStyle.Bold)
        Me.addHabilitat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.addHabilitat.Location = New System.Drawing.Point(943, 281)
        Me.addHabilitat.Margin = New System.Windows.Forms.Padding(0)
        Me.addHabilitat.Name = "addHabilitat"
        Me.addHabilitat.Size = New System.Drawing.Size(30, 30)
        Me.addHabilitat.TabIndex = 181
        Me.addHabilitat.Text = " "
        Me.addHabilitat.UseVisualStyleBackColor = True
        '
        'LabelTel1
        '
        Me.LabelTel1.AutoSize = True
        Me.LabelTel1.BackColor = System.Drawing.Color.Transparent
        Me.LabelTel1.Font = New System.Drawing.Font("Dubai", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTel1.ForeColor = System.Drawing.Color.White
        Me.LabelTel1.Location = New System.Drawing.Point(47, 475)
        Me.LabelTel1.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelTel1.Name = "LabelTel1"
        Me.LabelTel1.Size = New System.Drawing.Size(90, 24)
        Me.LabelTel1.TabIndex = 174
        Me.LabelTel1.Text = "Telèfon mòb."
        '
        'LabelEmail
        '
        Me.LabelEmail.AutoSize = True
        Me.LabelEmail.BackColor = System.Drawing.Color.Transparent
        Me.LabelEmail.Font = New System.Drawing.Font("Dubai", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEmail.ForeColor = System.Drawing.Color.White
        Me.LabelEmail.Location = New System.Drawing.Point(46, 412)
        Me.LabelEmail.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelEmail.Name = "LabelEmail"
        Me.LabelEmail.Size = New System.Drawing.Size(114, 24)
        Me.LabelEmail.TabIndex = 176
        Me.LabelEmail.Text = "Correu electrònic"
        '
        'LabelMotiu
        '
        Me.LabelMotiu.AutoSize = True
        Me.LabelMotiu.BackColor = System.Drawing.Color.Transparent
        Me.LabelMotiu.Font = New System.Drawing.Font("Dubai", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMotiu.ForeColor = System.Drawing.Color.White
        Me.LabelMotiu.Location = New System.Drawing.Point(277, 286)
        Me.LabelMotiu.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelMotiu.Name = "LabelMotiu"
        Me.LabelMotiu.Size = New System.Drawing.Size(138, 24)
        Me.LabelMotiu.TabIndex = 178
        Me.LabelMotiu.Text = "Es fa voluntari/a per:"
        '
        'LabelHabilitats
        '
        Me.LabelHabilitats.AutoSize = True
        Me.LabelHabilitats.BackColor = System.Drawing.Color.Transparent
        Me.LabelHabilitats.Font = New System.Drawing.Font("Dubai", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelHabilitats.ForeColor = System.Drawing.Color.White
        Me.LabelHabilitats.Location = New System.Drawing.Point(731, 259)
        Me.LabelHabilitats.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelHabilitats.Name = "LabelHabilitats"
        Me.LabelHabilitats.Size = New System.Drawing.Size(70, 24)
        Me.LabelHabilitats.TabIndex = 179
        Me.LabelHabilitats.Text = "Habilitats"
        '
        'LabelPoblacio
        '
        Me.LabelPoblacio.AutoSize = True
        Me.LabelPoblacio.BackColor = System.Drawing.Color.Transparent
        Me.LabelPoblacio.Font = New System.Drawing.Font("Dubai", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPoblacio.ForeColor = System.Drawing.Color.White
        Me.LabelPoblacio.Location = New System.Drawing.Point(176, 306)
        Me.LabelPoblacio.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelPoblacio.Name = "LabelPoblacio"
        Me.LabelPoblacio.Size = New System.Drawing.Size(79, 24)
        Me.LabelPoblacio.TabIndex = 193
        Me.LabelPoblacio.Text = "Codi Postal"
        '
        'LabelAmbits
        '
        Me.LabelAmbits.AutoSize = True
        Me.LabelAmbits.BackColor = System.Drawing.Color.Transparent
        Me.LabelAmbits.Font = New System.Drawing.Font("Dubai", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAmbits.ForeColor = System.Drawing.Color.White
        Me.LabelAmbits.Location = New System.Drawing.Point(731, 93)
        Me.LabelAmbits.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelAmbits.Name = "LabelAmbits"
        Me.LabelAmbits.Size = New System.Drawing.Size(53, 24)
        Me.LabelAmbits.TabIndex = 200
        Me.LabelAmbits.Text = "Àmbits"
        '
        'LabelIdiomes
        '
        Me.LabelIdiomes.AutoSize = True
        Me.LabelIdiomes.BackColor = System.Drawing.Color.Transparent
        Me.LabelIdiomes.Font = New System.Drawing.Font("Dubai", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelIdiomes.ForeColor = System.Drawing.Color.White
        Me.LabelIdiomes.Location = New System.Drawing.Point(731, 403)
        Me.LabelIdiomes.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelIdiomes.Name = "LabelIdiomes"
        Me.LabelIdiomes.Size = New System.Drawing.Size(58, 24)
        Me.LabelIdiomes.TabIndex = 201
        Me.LabelIdiomes.Text = "Idiomes"
        '
        'CheckBoxActiu
        '
        Me.CheckBoxActiu.AutoSize = True
        Me.CheckBoxActiu.BackColor = System.Drawing.Color.Transparent
        Me.CheckBoxActiu.CheckAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CheckBoxActiu.Font = New System.Drawing.Font("Dubai", 10.0!, System.Drawing.FontStyle.Bold)
        Me.CheckBoxActiu.ForeColor = System.Drawing.Color.White
        Me.CheckBoxActiu.Location = New System.Drawing.Point(427, 374)
        Me.CheckBoxActiu.Name = "CheckBoxActiu"
        Me.CheckBoxActiu.Size = New System.Drawing.Size(46, 42)
        Me.CheckBoxActiu.TabIndex = 205
        Me.CheckBoxActiu.Text = "Actiu"
        Me.CheckBoxActiu.UseVisualStyleBackColor = False
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
        Me.tornarMenuBtn.TabIndex = 206
        Me.tornarMenuBtn.TabStop = False
        '
        'editVoluntariBtn
        '
        Me.editVoluntariBtn.BackColor = System.Drawing.Color.Transparent
        Me.editVoluntariBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.editVoluntariBtn.Image = CType(resources.GetObject("editVoluntariBtn.Image"), System.Drawing.Image)
        Me.editVoluntariBtn.Location = New System.Drawing.Point(401, 567)
        Me.editVoluntariBtn.Name = "editVoluntariBtn"
        Me.editVoluntariBtn.Size = New System.Drawing.Size(192, 84)
        Me.editVoluntariBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.editVoluntariBtn.TabIndex = 207
        Me.editVoluntariBtn.TabStop = False
        '
        'ComboBoxVoluntaris
        '
        Me.ComboBoxVoluntaris.Font = New System.Drawing.Font("Dubai", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ComboBoxVoluntaris.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ComboBoxVoluntaris.FormattingEnabled = True
        Me.ComboBoxVoluntaris.Location = New System.Drawing.Point(390, 532)
        Me.ComboBoxVoluntaris.Name = "ComboBoxVoluntaris"
        Me.ComboBoxVoluntaris.Size = New System.Drawing.Size(214, 29)
        Me.ComboBoxVoluntaris.TabIndex = 208
        '
        'TextBoxMotiuInactiu
        '
        Me.TextBoxMotiuInactiu.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxMotiuInactiu.Enabled = False
        Me.TextBoxMotiuInactiu.Font = New System.Drawing.Font("Dubai", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TextBoxMotiuInactiu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.TextBoxMotiuInactiu.Location = New System.Drawing.Point(501, 328)
        Me.TextBoxMotiuInactiu.Name = "TextBoxMotiuInactiu"
        Me.TextBoxMotiuInactiu.Size = New System.Drawing.Size(203, 28)
        Me.TextBoxMotiuInactiu.TabIndex = 210
        '
        'LabelMotiuInactiu
        '
        Me.LabelMotiuInactiu.AutoSize = True
        Me.LabelMotiuInactiu.BackColor = System.Drawing.Color.Transparent
        Me.LabelMotiuInactiu.Font = New System.Drawing.Font("Dubai", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMotiuInactiu.ForeColor = System.Drawing.Color.White
        Me.LabelMotiuInactiu.Location = New System.Drawing.Point(497, 306)
        Me.LabelMotiuInactiu.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelMotiuInactiu.Name = "LabelMotiuInactiu"
        Me.LabelMotiuInactiu.Size = New System.Drawing.Size(92, 24)
        Me.LabelMotiuInactiu.TabIndex = 209
        Me.LabelMotiuInactiu.Text = "Motiu Inactiu"
        '
        'VoluntarisEditar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1008, 679)
        Me.Controls.Add(Me.TextBoxMotiuInactiu)
        Me.Controls.Add(Me.LabelMotiuInactiu)
        Me.Controls.Add(Me.ComboBoxVoluntaris)
        Me.Controls.Add(Me.editVoluntariBtn)
        Me.Controls.Add(Me.tornarMenuBtn)
        Me.Controls.Add(Me.CheckBoxActiu)
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
        Me.Controls.Add(Me.checkBoxAssegurat)
        Me.Controls.Add(Me.LabelNom)
        Me.Controls.Add(Me.Motiu3)
        Me.Controls.Add(Me.Motiu2)
        Me.Controls.Add(Me.Motiu1)
        Me.Controls.Add(Me.LabelTel2)
        Me.Controls.Add(Me.LabelNIF)
        Me.Controls.Add(Me.LabelObservacions)
        Me.Controls.Add(Me.LabelAdreca)
        Me.Controls.Add(Me.removeHabilitat)
        Me.Controls.Add(Me.addHabilitat)
        Me.Controls.Add(Me.LabelTel1)
        Me.Controls.Add(Me.LabelEmail)
        Me.Controls.Add(Me.LabelMotiu)
        Me.Controls.Add(Me.LabelHabilitats)
        Me.Controls.Add(Me.LabelPoblacio)
        Me.Controls.Add(Me.LabelAmbits)
        Me.Controls.Add(Me.LabelIdiomes)
        Me.Controls.Add(Me.LabelIdVoluntari)
        Me.Controls.Add(Me.previousBtn)
        Me.Controls.Add(Me.nextBtn)
        Me.Controls.Add(Me.editarTitle)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1024, 718)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1024, 718)
        Me.Name = "VoluntarisEditar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Editar Voluntaris"
        CType(Me.editarTitle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.previousBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nextBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tornarMenuBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.editVoluntariBtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents editarTitle As PictureBox
    Friend WithEvents previousBtn As PictureBox
    Friend WithEvents nextBtn As PictureBox
    Friend WithEvents LabelIdVoluntari As Label
    Friend WithEvents removeIdioma As Button
    Friend WithEvents addIdioma As Button
    Friend WithEvents IdiomesList As CheckedListBox
    Friend WithEvents AmbitsList As CheckedListBox
    Friend WithEvents TextBoxSexe As TextBox
    Friend WithEvents LabelSexe As Label
    Friend WithEvents TextBoxPoblacio As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxCodiPostal As TextBox
    Friend WithEvents naixementCalendari As MonthCalendar
    Friend WithEvents TextBoxDisponibilitat As TextBox
    Friend WithEvents TextBoxCognom1 As TextBox
    Friend WithEvents TextBoxCognom2 As TextBox
    Friend WithEvents TextBoxTel2 As TextBox
    Friend WithEvents TextBoxNIF As TextBox
    Friend WithEvents TextBoxObservacions As TextBox
    Friend WithEvents TextBoxAdreca As TextBox
    Friend WithEvents TextBoxTel1 As TextBox
    Friend WithEvents TextBoxEmail As TextBox
    Friend WithEvents HabilitatsList As CheckedListBox
    Friend WithEvents TextBoxNom As TextBox
    Friend WithEvents LabelDataNaix As Label
    Friend WithEvents LabelDisponibilitat As Label
    Friend WithEvents LabelCognom1 As Label
    Friend WithEvents LabelCognom2 As Label
    Friend WithEvents checkBoxAssegurat As CheckBox
    Friend WithEvents LabelNom As Label
    Friend WithEvents Motiu3 As RadioButton
    Friend WithEvents Motiu2 As RadioButton
    Friend WithEvents Motiu1 As RadioButton
    Friend WithEvents LabelTel2 As Label
    Friend WithEvents LabelNIF As Label
    Friend WithEvents LabelObservacions As Label
    Friend WithEvents LabelAdreca As Label
    Friend WithEvents removeHabilitat As Button
    Friend WithEvents addHabilitat As Button
    Friend WithEvents LabelTel1 As Label
    Friend WithEvents LabelEmail As Label
    Friend WithEvents LabelMotiu As Label
    Friend WithEvents LabelHabilitats As Label
    Friend WithEvents LabelPoblacio As Label
    Friend WithEvents LabelAmbits As Label
    Friend WithEvents LabelIdiomes As Label
    Friend WithEvents CheckBoxActiu As CheckBox
    Private WithEvents tornarMenuBtn As PictureBox
    Private WithEvents editVoluntariBtn As PictureBox
    Friend WithEvents ComboBoxVoluntaris As ComboBox
    Friend WithEvents TextBoxMotiuInactiu As TextBox
    Friend WithEvents LabelMotiuInactiu As Label
End Class
