Public Class FrmCalc2
    Dim res As Double
    Dim ope As String
    Dim checkText As Boolean
    Dim virgule As Boolean
    Dim signe As Double

    Private Sub txtInput_TextChanged(sender As Object, e As EventArgs) Handles txtInput.TextChanged

    End Sub

    Private Sub btnRetour_Click(sender As Object, e As EventArgs) Handles btnRetour.Click
        Hide()
        FrmMenu.Show()
    End Sub

    Private Sub btnCe_Click(sender As Object, e As EventArgs) Handles btnCe.Click
        txtInput.Text = txtInput.Text.Remove(txtInput.Text.Length - 1, 1)

    End Sub

    Private Sub btnC_Click(sender As Object, e As EventArgs) Handles btnC.Click
        txtInput.Clear()
    End Sub

    Private Sub bntSigne_Click(sender As Object, e As EventArgs) Handles bntSigne.Click
        If txtInput.Text = "" Then
            txtInput.Text = "-"
        Else
            txtInput.Text = Val(txtInput.Text) * -1
        End If
    End Sub

    Private Sub btnVirgule_Click(sender As Object, e As EventArgs) Handles btnVirgule.Click
        If virgule = False And txtInput.Text <> "" Then
            txtInput.Text = txtInput.Text + "."
            virgule = True
        End If
    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        If checkText = True Then
            txtInput.Text = "0"
            checkText = False
        Else
            txtInput.Text = txtInput.Text + "0"
        End If
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        If checkText = True Then
            txtInput.Text = "1"
            checkText = False
        Else
            txtInput.Text = txtInput.Text + "1"
        End If
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        If checkText = True Then
            txtInput.Text = "2"
            checkText = False
        Else
            txtInput.Text = txtInput.Text + "2"
        End If
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        If checkText = True Then
            txtInput.Text = "3"
            checkText = False
        Else
            txtInput.Text = txtInput.Text + "3"
        End If
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        If checkText = True Then
            txtInput.Text = "4"
            checkText = False
        Else
            txtInput.Text = txtInput.Text + "4"
        End If
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        If checkText = True Then
            txtInput.Text = "5"
            checkText = False
        Else
            txtInput.Text = txtInput.Text + "5"
        End If
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        If checkText = True Then
            txtInput.Text = "6"
            checkText = False
        Else
            txtInput.Text = txtInput.Text + "6"
        End If
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        If checkText = True Then
            txtInput.Text = "7"
            checkText = False
        Else
            txtInput.Text = txtInput.Text + "7"
        End If
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        If checkText = True Then
            txtInput.Text = "8"
            checkText = False
        Else
            txtInput.Text = txtInput.Text + "8"
        End If
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        If checkText = True Then
            txtInput.Text = "9"
            checkText = False
        Else
            txtInput.Text = txtInput.Text + "9"
        End If
    End Sub

    Private Sub btnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click
        res = Val(txtInput.Text)
        txtInput.Clear()
        ope = "+"
        checkText = True
        virgule = False
    End Sub

    Private Sub btnMoins_Click(sender As Object, e As EventArgs) Handles btnMoins.Click
        res = txtInput.Text
        txtInput.Clear()
        ope = "-"
    End Sub

    Private Sub btnMultiple_Click(sender As Object, e As EventArgs) Handles btnMultiple.Click
        res = txtInput.Text
        txtInput.Clear()
        ope = "*"
    End Sub

    Private Sub btnDiv_Click(sender As Object, e As EventArgs) Handles btnDiv.Click
        res = txtInput.Text
        txtInput.Clear()
        ope = "/"
    End Sub

    Private Sub btnPuis_Click(sender As Object, e As EventArgs) Handles btnPuis.Click
        res = txtInput.Text
        txtInput.Clear()
        ope = "^"
    End Sub

    Private Sub btnRac_Click(sender As Object, e As EventArgs) Handles btnRac.Click
        res = txtInput.Text
        txtInput.Clear()
        txtInput.Text = Math.Sqrt(res)

    End Sub

    Private Sub btnInverse_Click(sender As Object, e As EventArgs) Handles btnInverse.Click
        res = txtInput.Text
        txtInput.Clear()
        If res <> 0 Then
            txtInput.Text = 1 / res
        Else
            txtInput.Text = "Erreur division par 0"
        End If
    End Sub

    Private Sub btnEgale_Click(sender As Object, e As EventArgs) Handles btnEgale.Click
        If ope = "+" Then
            res += Val(txtInput.Text)
        ElseIf ope = "-" Then
            res -= Val(txtInput.Text)
        ElseIf ope = "*" Then
            res *= Val(txtInput.Text)
        ElseIf ope = "/" Then
            res /= Val(txtInput.Text)
        End If
        txtInput.Text = res
        checkText = True
        virgule = False
    End Sub
End Class