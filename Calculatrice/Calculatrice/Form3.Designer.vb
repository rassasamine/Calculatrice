<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCalc2
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
        Me.btnRetour = New System.Windows.Forms.Button()
        Me.btnCe = New System.Windows.Forms.Button()
        Me.btnC = New System.Windows.Forms.Button()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.btn7 = New System.Windows.Forms.Button()
        Me.btn8 = New System.Windows.Forms.Button()
        Me.btn9 = New System.Windows.Forms.Button()
        Me.btn6 = New System.Windows.Forms.Button()
        Me.btn5 = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btnVirgule = New System.Windows.Forms.Button()
        Me.bntSigne = New System.Windows.Forms.Button()
        Me.btn0 = New System.Windows.Forms.Button()
        Me.btnEgale = New System.Windows.Forms.Button()
        Me.btnPlus = New System.Windows.Forms.Button()
        Me.btnInverse = New System.Windows.Forms.Button()
        Me.btnMoins = New System.Windows.Forms.Button()
        Me.btnRac = New System.Windows.Forms.Button()
        Me.btnMultiple = New System.Windows.Forms.Button()
        Me.btnPuis = New System.Windows.Forms.Button()
        Me.btnDiv = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnRetour
        '
        Me.btnRetour.ForeColor = System.Drawing.Color.Red
        Me.btnRetour.Location = New System.Drawing.Point(35, 51)
        Me.btnRetour.Name = "btnRetour"
        Me.btnRetour.Size = New System.Drawing.Size(111, 23)
        Me.btnRetour.TabIndex = 0
        Me.btnRetour.Text = "RETOUR ARRIERE"
        Me.btnRetour.UseVisualStyleBackColor = True
        '
        'btnCe
        '
        Me.btnCe.ForeColor = System.Drawing.Color.Red
        Me.btnCe.Location = New System.Drawing.Point(180, 51)
        Me.btnCe.Name = "btnCe"
        Me.btnCe.Size = New System.Drawing.Size(36, 23)
        Me.btnCe.TabIndex = 1
        Me.btnCe.Text = "CE"
        Me.btnCe.UseVisualStyleBackColor = True
        '
        'btnC
        '
        Me.btnC.ForeColor = System.Drawing.Color.Red
        Me.btnC.Location = New System.Drawing.Point(222, 51)
        Me.btnC.Name = "btnC"
        Me.btnC.Size = New System.Drawing.Size(36, 23)
        Me.btnC.TabIndex = 2
        Me.btnC.Text = "C"
        Me.btnC.UseVisualStyleBackColor = True
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(12, 8)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.ReadOnly = True
        Me.txtInput.Size = New System.Drawing.Size(260, 20)
        Me.txtInput.TabIndex = 3
        Me.txtInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btn7
        '
        Me.btn7.Location = New System.Drawing.Point(35, 90)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(33, 30)
        Me.btn7.TabIndex = 4
        Me.btn7.Text = "7"
        Me.btn7.UseVisualStyleBackColor = True
        '
        'btn8
        '
        Me.btn8.Location = New System.Drawing.Point(74, 90)
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(33, 30)
        Me.btn8.TabIndex = 5
        Me.btn8.Text = "8"
        Me.btn8.UseVisualStyleBackColor = True
        '
        'btn9
        '
        Me.btn9.Location = New System.Drawing.Point(113, 90)
        Me.btn9.Name = "btn9"
        Me.btn9.Size = New System.Drawing.Size(33, 30)
        Me.btn9.TabIndex = 6
        Me.btn9.Text = "9"
        Me.btn9.UseVisualStyleBackColor = True
        '
        'btn6
        '
        Me.btn6.Location = New System.Drawing.Point(113, 126)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(33, 30)
        Me.btn6.TabIndex = 9
        Me.btn6.Text = "6"
        Me.btn6.UseVisualStyleBackColor = True
        '
        'btn5
        '
        Me.btn5.Location = New System.Drawing.Point(74, 126)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(33, 30)
        Me.btn5.TabIndex = 8
        Me.btn5.Text = "5"
        Me.btn5.UseVisualStyleBackColor = True
        '
        'btn4
        '
        Me.btn4.Location = New System.Drawing.Point(35, 126)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(33, 30)
        Me.btn4.TabIndex = 7
        Me.btn4.Text = "4"
        Me.btn4.UseVisualStyleBackColor = True
        '
        'btn3
        '
        Me.btn3.Location = New System.Drawing.Point(113, 162)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(33, 30)
        Me.btn3.TabIndex = 12
        Me.btn3.Text = "3"
        Me.btn3.UseVisualStyleBackColor = True
        '
        'btn2
        '
        Me.btn2.Location = New System.Drawing.Point(74, 162)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(33, 30)
        Me.btn2.TabIndex = 11
        Me.btn2.Text = "2"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'btn1
        '
        Me.btn1.Location = New System.Drawing.Point(35, 162)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(33, 30)
        Me.btn1.TabIndex = 10
        Me.btn1.Text = "1"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'btnVirgule
        '
        Me.btnVirgule.Location = New System.Drawing.Point(113, 202)
        Me.btnVirgule.Name = "btnVirgule"
        Me.btnVirgule.Size = New System.Drawing.Size(33, 30)
        Me.btnVirgule.TabIndex = 15
        Me.btnVirgule.Text = ","
        Me.btnVirgule.UseVisualStyleBackColor = True
        '
        'bntSigne
        '
        Me.bntSigne.Location = New System.Drawing.Point(74, 202)
        Me.bntSigne.Name = "bntSigne"
        Me.bntSigne.Size = New System.Drawing.Size(33, 30)
        Me.bntSigne.TabIndex = 14
        Me.bntSigne.Text = "+/-"
        Me.bntSigne.UseVisualStyleBackColor = True
        '
        'btn0
        '
        Me.btn0.Location = New System.Drawing.Point(35, 202)
        Me.btn0.Name = "btn0"
        Me.btn0.Size = New System.Drawing.Size(33, 30)
        Me.btn0.TabIndex = 13
        Me.btn0.Text = "0"
        Me.btn0.UseVisualStyleBackColor = True
        '
        'btnEgale
        '
        Me.btnEgale.Location = New System.Drawing.Point(222, 202)
        Me.btnEgale.Name = "btnEgale"
        Me.btnEgale.Size = New System.Drawing.Size(33, 30)
        Me.btnEgale.TabIndex = 23
        Me.btnEgale.Text = "="
        Me.btnEgale.UseVisualStyleBackColor = True
        '
        'btnPlus
        '
        Me.btnPlus.Location = New System.Drawing.Point(183, 202)
        Me.btnPlus.Name = "btnPlus"
        Me.btnPlus.Size = New System.Drawing.Size(33, 30)
        Me.btnPlus.TabIndex = 22
        Me.btnPlus.Text = "+"
        Me.btnPlus.UseVisualStyleBackColor = True
        '
        'btnInverse
        '
        Me.btnInverse.Location = New System.Drawing.Point(222, 162)
        Me.btnInverse.Name = "btnInverse"
        Me.btnInverse.Size = New System.Drawing.Size(33, 30)
        Me.btnInverse.TabIndex = 21
        Me.btnInverse.Text = "1/x"
        Me.btnInverse.UseVisualStyleBackColor = True
        '
        'btnMoins
        '
        Me.btnMoins.Location = New System.Drawing.Point(183, 162)
        Me.btnMoins.Name = "btnMoins"
        Me.btnMoins.Size = New System.Drawing.Size(33, 30)
        Me.btnMoins.TabIndex = 20
        Me.btnMoins.Text = "-"
        Me.btnMoins.UseVisualStyleBackColor = True
        '
        'btnRac
        '
        Me.btnRac.Location = New System.Drawing.Point(222, 126)
        Me.btnRac.Name = "btnRac"
        Me.btnRac.Size = New System.Drawing.Size(33, 30)
        Me.btnRac.TabIndex = 19
        Me.btnRac.Text = "Rac"
        Me.btnRac.UseVisualStyleBackColor = True
        '
        'btnMultiple
        '
        Me.btnMultiple.Location = New System.Drawing.Point(183, 126)
        Me.btnMultiple.Name = "btnMultiple"
        Me.btnMultiple.Size = New System.Drawing.Size(33, 30)
        Me.btnMultiple.TabIndex = 18
        Me.btnMultiple.Text = "*"
        Me.btnMultiple.UseVisualStyleBackColor = True
        '
        'btnPuis
        '
        Me.btnPuis.Location = New System.Drawing.Point(222, 90)
        Me.btnPuis.Name = "btnPuis"
        Me.btnPuis.Size = New System.Drawing.Size(33, 30)
        Me.btnPuis.TabIndex = 17
        Me.btnPuis.Text = "^"
        Me.btnPuis.UseVisualStyleBackColor = True
        '
        'btnDiv
        '
        Me.btnDiv.Location = New System.Drawing.Point(183, 90)
        Me.btnDiv.Name = "btnDiv"
        Me.btnDiv.Size = New System.Drawing.Size(33, 30)
        Me.btnDiv.TabIndex = 16
        Me.btnDiv.Text = "/"
        Me.btnDiv.UseVisualStyleBackColor = True
        '
        'FrmCalc2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnEgale)
        Me.Controls.Add(Me.btnPlus)
        Me.Controls.Add(Me.btnInverse)
        Me.Controls.Add(Me.btnMoins)
        Me.Controls.Add(Me.btnRac)
        Me.Controls.Add(Me.btnMultiple)
        Me.Controls.Add(Me.btnPuis)
        Me.Controls.Add(Me.btnDiv)
        Me.Controls.Add(Me.btnVirgule)
        Me.Controls.Add(Me.bntSigne)
        Me.Controls.Add(Me.btn0)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.btn6)
        Me.Controls.Add(Me.btn5)
        Me.Controls.Add(Me.btn4)
        Me.Controls.Add(Me.btn9)
        Me.Controls.Add(Me.btn8)
        Me.Controls.Add(Me.btn7)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.btnC)
        Me.Controls.Add(Me.btnCe)
        Me.Controls.Add(Me.btnRetour)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCalc2"
        Me.Text = "Calculatrice Standard"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnRetour As Button
    Friend WithEvents btnCe As Button
    Friend WithEvents btnC As Button
    Friend WithEvents txtInput As TextBox
    Friend WithEvents btn7 As Button
    Friend WithEvents btn8 As Button
    Friend WithEvents btn9 As Button
    Friend WithEvents btn6 As Button
    Friend WithEvents btn5 As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn1 As Button
    Friend WithEvents btnVirgule As Button
    Friend WithEvents bntSigne As Button
    Friend WithEvents btn0 As Button
    Friend WithEvents btnEgale As Button
    Friend WithEvents btnPlus As Button
    Friend WithEvents btnInverse As Button
    Friend WithEvents btnMoins As Button
    Friend WithEvents btnRac As Button
    Friend WithEvents btnMultiple As Button
    Friend WithEvents btnPuis As Button
    Friend WithEvents btnDiv As Button
End Class
