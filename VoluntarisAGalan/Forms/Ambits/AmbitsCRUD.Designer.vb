<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AmbitsCRUD
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AmbitsCRUD))
        Me.crearProjecteTitle = New System.Windows.Forms.PictureBox()
        Me.ListBoxAmbits = New System.Windows.Forms.ListBox()
        Me.RemoveAmbit = New System.Windows.Forms.Button()
        Me.AddAmbit = New System.Windows.Forms.Button()
        Me.tornarMenuBtn = New System.Windows.Forms.PictureBox()
        CType(Me.crearProjecteTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tornarMenuBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'crearProjecteTitle
        '
        Me.crearProjecteTitle.BackColor = System.Drawing.Color.Transparent
        Me.crearProjecteTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.crearProjecteTitle.Image = CType(resources.GetObject("crearProjecteTitle.Image"), System.Drawing.Image)
        Me.crearProjecteTitle.Location = New System.Drawing.Point(0, 0)
        Me.crearProjecteTitle.Name = "crearProjecteTitle"
        Me.crearProjecteTitle.Size = New System.Drawing.Size(1008, 101)
        Me.crearProjecteTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.crearProjecteTitle.TabIndex = 30
        Me.crearProjecteTitle.TabStop = False
        '
        'ListBoxAmbits
        '
        Me.ListBoxAmbits.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ListBoxAmbits.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ListBoxAmbits.FormattingEnabled = True
        Me.ListBoxAmbits.ItemHeight = 27
        Me.ListBoxAmbits.Location = New System.Drawing.Point(294, 152)
        Me.ListBoxAmbits.Name = "ListBoxAmbits"
        Me.ListBoxAmbits.Size = New System.Drawing.Size(416, 301)
        Me.ListBoxAmbits.TabIndex = 31
        '
        'RemoveAmbit
        '
        Me.RemoveAmbit.BackgroundImage = CType(resources.GetObject("RemoveAmbit.BackgroundImage"), System.Drawing.Image)
        Me.RemoveAmbit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RemoveAmbit.Font = New System.Drawing.Font("Dubai", 10.0!, System.Drawing.FontStyle.Bold)
        Me.RemoveAmbit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.RemoveAmbit.Location = New System.Drawing.Point(713, 207)
        Me.RemoveAmbit.Margin = New System.Windows.Forms.Padding(0)
        Me.RemoveAmbit.Name = "RemoveAmbit"
        Me.RemoveAmbit.Size = New System.Drawing.Size(50, 50)
        Me.RemoveAmbit.TabIndex = 64
        Me.RemoveAmbit.UseVisualStyleBackColor = True
        '
        'AddAmbit
        '
        Me.AddAmbit.BackgroundImage = CType(resources.GetObject("AddAmbit.BackgroundImage"), System.Drawing.Image)
        Me.AddAmbit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.AddAmbit.Font = New System.Drawing.Font("Dubai", 10.0!, System.Drawing.FontStyle.Bold)
        Me.AddAmbit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.AddAmbit.Location = New System.Drawing.Point(713, 152)
        Me.AddAmbit.Margin = New System.Windows.Forms.Padding(0)
        Me.AddAmbit.Name = "AddAmbit"
        Me.AddAmbit.Size = New System.Drawing.Size(50, 50)
        Me.AddAmbit.TabIndex = 63
        Me.AddAmbit.Text = " "
        Me.AddAmbit.UseVisualStyleBackColor = True
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
        Me.tornarMenuBtn.TabIndex = 210
        Me.tornarMenuBtn.TabStop = False
        '
        'AmbitsCRUD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1008, 679)
        Me.Controls.Add(Me.tornarMenuBtn)
        Me.Controls.Add(Me.RemoveAmbit)
        Me.Controls.Add(Me.AddAmbit)
        Me.Controls.Add(Me.ListBoxAmbits)
        Me.Controls.Add(Me.crearProjecteTitle)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1024, 718)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1024, 718)
        Me.Name = "AmbitsCRUD"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificar Àmbits"
        CType(Me.crearProjecteTitle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tornarMenuBtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents crearProjecteTitle As PictureBox
    Friend WithEvents ListBoxAmbits As ListBox
    Friend WithEvents RemoveAmbit As Button
    Friend WithEvents AddAmbit As Button
    Private WithEvents tornarMenuBtn As PictureBox
End Class
