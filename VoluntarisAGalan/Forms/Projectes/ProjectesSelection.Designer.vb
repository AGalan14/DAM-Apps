<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProjectesSelection
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProjectesSelection))
        Me.checkProjecte = New System.Windows.Forms.PictureBox()
        Me.editProjecte = New System.Windows.Forms.PictureBox()
        Me.addProjecte = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.checkProjecte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.editProjecte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.addProjecte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'checkProjecte
        '
        Me.checkProjecte.Cursor = System.Windows.Forms.Cursors.Hand
        Me.checkProjecte.Image = CType(resources.GetObject("checkProjecte.Image"), System.Drawing.Image)
        Me.checkProjecte.Location = New System.Drawing.Point(492, 12)
        Me.checkProjecte.Name = "checkProjecte"
        Me.checkProjecte.Size = New System.Drawing.Size(220, 210)
        Me.checkProjecte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.checkProjecte.TabIndex = 7
        Me.checkProjecte.TabStop = False
        Me.ToolTip1.SetToolTip(Me.checkProjecte, "Consultar els projectes creats")
        '
        'editProjecte
        '
        Me.editProjecte.Cursor = System.Windows.Forms.Cursors.Hand
        Me.editProjecte.Image = CType(resources.GetObject("editProjecte.Image"), System.Drawing.Image)
        Me.editProjecte.Location = New System.Drawing.Point(252, 12)
        Me.editProjecte.Name = "editProjecte"
        Me.editProjecte.Size = New System.Drawing.Size(220, 210)
        Me.editProjecte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.editProjecte.TabIndex = 5
        Me.editProjecte.TabStop = False
        Me.ToolTip1.SetToolTip(Me.editProjecte, "Editar un projecte existent")
        '
        'addProjecte
        '
        Me.addProjecte.Cursor = System.Windows.Forms.Cursors.Hand
        Me.addProjecte.Image = CType(resources.GetObject("addProjecte.Image"), System.Drawing.Image)
        Me.addProjecte.Location = New System.Drawing.Point(12, 12)
        Me.addProjecte.Name = "addProjecte"
        Me.addProjecte.Size = New System.Drawing.Size(220, 210)
        Me.addProjecte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.addProjecte.TabIndex = 4
        Me.addProjecte.TabStop = False
        Me.ToolTip1.SetToolTip(Me.addProjecte, "Crear un nou projecte")
        '
        'ProjectesSelection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(724, 236)
        Me.Controls.Add(Me.checkProjecte)
        Me.Controls.Add(Me.editProjecte)
        Me.Controls.Add(Me.addProjecte)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(740, 275)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(740, 275)
        Me.Name = "ProjectesSelection"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Selecciona una opció"
        CType(Me.checkProjecte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.editProjecte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.addProjecte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents checkProjecte As PictureBox
    Friend WithEvents editProjecte As PictureBox
    Friend WithEvents addProjecte As PictureBox
    Friend WithEvents ToolTip1 As ToolTip
End Class
