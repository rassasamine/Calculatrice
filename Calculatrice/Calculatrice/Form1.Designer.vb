<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMenu
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.BtnCalc1 = New System.Windows.Forms.Button()
        Me.BtnCalc2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnClose
        '
        Me.BtnClose.Location = New System.Drawing.Point(105, 226)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(75, 23)
        Me.BtnClose.TabIndex = 0
        Me.BtnClose.Text = "&Fermer"
        Me.BtnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'BtnCalc1
        '
        Me.BtnCalc1.Location = New System.Drawing.Point(71, 49)
        Me.BtnCalc1.Name = "BtnCalc1"
        Me.BtnCalc1.Size = New System.Drawing.Size(151, 23)
        Me.BtnCalc1.TabIndex = 1
        Me.BtnCalc1.Text = "&Calculatrice Simple"
        Me.BtnCalc1.UseVisualStyleBackColor = True
        '
        'BtnCalc2
        '
        Me.BtnCalc2.Location = New System.Drawing.Point(71, 133)
        Me.BtnCalc2.Name = "BtnCalc2"
        Me.BtnCalc2.Size = New System.Drawing.Size(151, 23)
        Me.BtnCalc2.TabIndex = 2
        Me.BtnCalc2.Text = "&Calculatrice Standard"
        Me.BtnCalc2.UseVisualStyleBackColor = True
        '
        'FrmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnCalc2)
        Me.Controls.Add(Me.BtnCalc1)
        Me.Controls.Add(Me.BtnClose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "FrmMenu"
        Me.Text = "Menu Principale"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnClose As Button
    Friend WithEvents BtnCalc1 As Button
    Friend WithEvents BtnCalc2 As Button
End Class
