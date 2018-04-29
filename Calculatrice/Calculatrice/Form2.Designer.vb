<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCalc1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblNb1 = New System.Windows.Forms.Label()
        Me.lblNb2 = New System.Windows.Forms.Label()
        Me.txtC1 = New System.Windows.Forms.TextBox()
        Me.txtC2 = New System.Windows.Forms.TextBox()
        Me.fraOpt = New System.Windows.Forms.GroupBox()
        Me.optMult = New System.Windows.Forms.RadioButton()
        Me.optDiv = New System.Windows.Forms.RadioButton()
        Me.optMoins = New System.Windows.Forms.RadioButton()
        Me.optPlus = New System.Windows.Forms.RadioButton()
        Me.lblRes = New System.Windows.Forms.Label()
        Me.txtRes = New System.Windows.Forms.TextBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnCalculer = New System.Windows.Forms.Button()
        Me.fraOpt.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblNb1
        '
        Me.lblNb1.AutoSize = True
        Me.lblNb1.Location = New System.Drawing.Point(34, 18)
        Me.lblNb1.Name = "lblNb1"
        Me.lblNb1.Size = New System.Drawing.Size(53, 13)
        Me.lblNb1.TabIndex = 0
        Me.lblNb1.Text = "Nombre 1"
        '
        'lblNb2
        '
        Me.lblNb2.AutoSize = True
        Me.lblNb2.Location = New System.Drawing.Point(34, 54)
        Me.lblNb2.Name = "lblNb2"
        Me.lblNb2.Size = New System.Drawing.Size(53, 13)
        Me.lblNb2.TabIndex = 1
        Me.lblNb2.Text = "Nombre 2"
        '
        'txtC1
        '
        Me.txtC1.Location = New System.Drawing.Point(152, 18)
        Me.txtC1.Name = "txtC1"
        Me.txtC1.Size = New System.Drawing.Size(100, 20)
        Me.txtC1.TabIndex = 2
        Me.txtC1.Text = "0"
        Me.txtC1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtC2
        '
        Me.txtC2.Location = New System.Drawing.Point(152, 54)
        Me.txtC2.Name = "txtC2"
        Me.txtC2.Size = New System.Drawing.Size(100, 20)
        Me.txtC2.TabIndex = 3
        Me.txtC2.Text = "0"
        Me.txtC2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'fraOpt
        '
        Me.fraOpt.Controls.Add(Me.optMult)
        Me.fraOpt.Controls.Add(Me.optDiv)
        Me.fraOpt.Controls.Add(Me.optMoins)
        Me.fraOpt.Controls.Add(Me.optPlus)
        Me.fraOpt.Location = New System.Drawing.Point(37, 80)
        Me.fraOpt.Name = "fraOpt"
        Me.fraOpt.Size = New System.Drawing.Size(215, 100)
        Me.fraOpt.TabIndex = 4
        Me.fraOpt.TabStop = False
        Me.fraOpt.Text = "Operations"
        '
        'optMult
        '
        Me.optMult.AutoSize = True
        Me.optMult.Location = New System.Drawing.Point(104, 65)
        Me.optMult.Name = "optMult"
        Me.optMult.Size = New System.Drawing.Size(29, 17)
        Me.optMult.TabIndex = 3
        Me.optMult.TabStop = True
        Me.optMult.Text = "*"
        Me.optMult.UseVisualStyleBackColor = True
        '
        'optDiv
        '
        Me.optDiv.AutoSize = True
        Me.optDiv.Location = New System.Drawing.Point(7, 65)
        Me.optDiv.Name = "optDiv"
        Me.optDiv.Size = New System.Drawing.Size(30, 17)
        Me.optDiv.TabIndex = 2
        Me.optDiv.TabStop = True
        Me.optDiv.Text = "/"
        Me.optDiv.UseVisualStyleBackColor = True
        '
        'optMoins
        '
        Me.optMoins.AutoSize = True
        Me.optMoins.Location = New System.Drawing.Point(103, 19)
        Me.optMoins.Name = "optMoins"
        Me.optMoins.Size = New System.Drawing.Size(28, 17)
        Me.optMoins.TabIndex = 1
        Me.optMoins.TabStop = True
        Me.optMoins.Text = "-"
        Me.optMoins.UseVisualStyleBackColor = True
        '
        'optPlus
        '
        Me.optPlus.AutoSize = True
        Me.optPlus.Location = New System.Drawing.Point(7, 19)
        Me.optPlus.Name = "optPlus"
        Me.optPlus.Size = New System.Drawing.Size(31, 17)
        Me.optPlus.TabIndex = 0
        Me.optPlus.TabStop = True
        Me.optPlus.Text = "+"
        Me.optPlus.UseVisualStyleBackColor = True
        '
        'lblRes
        '
        Me.lblRes.AutoSize = True
        Me.lblRes.Location = New System.Drawing.Point(34, 194)
        Me.lblRes.Name = "lblRes"
        Me.lblRes.Size = New System.Drawing.Size(46, 13)
        Me.lblRes.TabIndex = 5
        Me.lblRes.Text = "Resultat"
        '
        'txtRes
        '
        Me.txtRes.Location = New System.Drawing.Point(152, 191)
        Me.txtRes.Name = "txtRes"
        Me.txtRes.ReadOnly = True
        Me.txtRes.Size = New System.Drawing.Size(100, 20)
        Me.txtRes.TabIndex = 6
        Me.txtRes.Text = "0"
        Me.txtRes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(177, 226)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 8
        Me.btnClose.Text = "&Fermer"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnCalculer
        '
        Me.btnCalculer.Location = New System.Drawing.Point(37, 226)
        Me.btnCalculer.Name = "btnCalculer"
        Me.btnCalculer.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculer.TabIndex = 9
        Me.btnCalculer.Text = "&Calculer"
        Me.btnCalculer.UseVisualStyleBackColor = True
        '
        'FrmCalc1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnCalculer)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.txtRes)
        Me.Controls.Add(Me.lblRes)
        Me.Controls.Add(Me.fraOpt)
        Me.Controls.Add(Me.txtC2)
        Me.Controls.Add(Me.txtC1)
        Me.Controls.Add(Me.lblNb2)
        Me.Controls.Add(Me.lblNb1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCalc1"
        Me.Text = "Calculatrice Simple"
        Me.fraOpt.ResumeLayout(False)
        Me.fraOpt.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNb1 As Label
    Friend WithEvents lblNb2 As Label
    Friend WithEvents txtC1 As TextBox
    Friend WithEvents txtC2 As TextBox
    Friend WithEvents optMult As RadioButton
    Friend WithEvents optDiv As RadioButton
    Friend WithEvents optMoins As RadioButton
    Friend WithEvents optPlus As RadioButton
    Friend WithEvents lblRes As Label
    Friend WithEvents txtRes As TextBox
    Friend WithEvents btnClose As Button
    Friend WithEvents fraOpt As GroupBox
    Friend WithEvents btnCalculer As Button
End Class
