<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VoluntarisSelection
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VoluntarisSelection))
        Me.addVoluntari = New System.Windows.Forms.PictureBox()
        Me.editVoluntari = New System.Windows.Forms.PictureBox()
        Me.checkVoluntari = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.addVoluntari, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.editVoluntari, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.checkVoluntari, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'addVoluntari
        '
        Me.addVoluntari.Cursor = System.Windows.Forms.Cursors.Hand
        Me.addVoluntari.Image = CType(resources.GetObject("addVoluntari.Image"), System.Drawing.Image)
        Me.addVoluntari.Location = New System.Drawing.Point(12, 12)
        Me.addVoluntari.Name = "addVoluntari"
        Me.addVoluntari.Size = New System.Drawing.Size(220, 210)
        Me.addVoluntari.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.addVoluntari.TabIndex = 0
        Me.addVoluntari.TabStop = False
        Me.ToolTip1.SetToolTip(Me.addVoluntari, "Inscriure un nou voluntari")
        '
        'editVoluntari
        '
        Me.editVoluntari.Cursor = System.Windows.Forms.Cursors.Hand
        Me.editVoluntari.Image = CType(resources.GetObject("editVoluntari.Image"), System.Drawing.Image)
        Me.editVoluntari.Location = New System.Drawing.Point(252, 12)
        Me.editVoluntari.Name = "editVoluntari"
        Me.editVoluntari.Size = New System.Drawing.Size(220, 210)
        Me.editVoluntari.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.editVoluntari.TabIndex = 1
        Me.editVoluntari.TabStop = False
        Me.ToolTip1.SetToolTip(Me.editVoluntari, "Editar les dades d'un voluntari")
        '
        'checkVoluntari
        '
        Me.checkVoluntari.Cursor = System.Windows.Forms.Cursors.Hand
        Me.checkVoluntari.Image = CType(resources.GetObject("checkVoluntari.Image"), System.Drawing.Image)
        Me.checkVoluntari.Location = New System.Drawing.Point(492, 12)
        Me.checkVoluntari.Name = "checkVoluntari"
        Me.checkVoluntari.Size = New System.Drawing.Size(220, 210)
        Me.checkVoluntari.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.checkVoluntari.TabIndex = 3
        Me.checkVoluntari.TabStop = False
        Me.ToolTip1.SetToolTip(Me.checkVoluntari, "Consultar voluntaris")
        '
        'ToolTip1
        '
        Me.ToolTip1.UseAnimation = False
        Me.ToolTip1.UseFading = False
        '
        'VoluntarisSelection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(724, 236)
        Me.Controls.Add(Me.checkVoluntari)
        Me.Controls.Add(Me.editVoluntari)
        Me.Controls.Add(Me.addVoluntari)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(740, 275)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(740, 275)
        Me.Name = "VoluntarisSelection"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Selecciona una opció"
        CType(Me.addVoluntari, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.editVoluntari, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.checkVoluntari, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents addVoluntari As PictureBox
    Friend WithEvents editVoluntari As PictureBox
    Friend WithEvents checkVoluntari As PictureBox
    Friend WithEvents ToolTip1 As ToolTip
End Class
