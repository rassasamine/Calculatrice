Public Class FrmCalc1
    Private Sub optPlus_CheckedChanged(sender As Object, e As EventArgs) Handles optPlus.CheckedChanged
        'txtRes.Text = CInt(txtC1.Text) + CInt(txtC2.Text)
    End Sub

    Private Sub optDiv_CheckedChanged(sender As Object, e As EventArgs) Handles optDiv.CheckedChanged
        'txtRes.Text = CInt(txtC1.Text) \ CInt(txtC2.Text)
    End Sub

    Private Sub optMoins_CheckedChanged(sender As Object, e As EventArgs) Handles optMoins.CheckedChanged
        'txtRes.Text = CInt(txtC1.Text) - CInt(txtC2.Text)
    End Sub

    Private Sub optMult_CheckedChanged(sender As Object, e As EventArgs) Handles optMult.CheckedChanged
        'txtRes.Text = CInt(txtC1.Text) * CInt(txtC2.Text)
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Hide()
        FrmMenu.Show()
    End Sub

    Private Sub txtC1_TextChanged(sender As Object, e As EventArgs) Handles txtC1.TextChanged

    End Sub

    Private Sub lblNb1_Click(sender As Object, e As EventArgs) Handles lblNb1.Click

    End Sub

    Private Sub lblNb2_Click(sender As Object, e As EventArgs) Handles lblNb2.Click

    End Sub

    Private Sub txtC2_TextChanged(sender As Object, e As EventArgs) Handles txtC2.TextChanged

    End Sub

    Private Sub fraOpt_Enter(sender As Object, e As EventArgs) Handles fraOpt.Enter

    End Sub

    Private Sub lblRes_Click(sender As Object, e As EventArgs) Handles lblRes.Click

    End Sub

    Private Sub txtRes_TextChanged(sender As Object, e As EventArgs) Handles txtRes.TextChanged

    End Sub

    Private Sub btnCalculer_Click(sender As Object, e As EventArgs) Handles btnCalculer.Click
        Select Case True
            Case optPlus.Checked
                txtRes.Text = CInt(txtC1.Text) + CInt(txtC2.Text)
            Case optMoins.Checked
                txtRes.Text = CInt(txtC1.Text) - CInt(txtC2.Text)
            Case optDiv.Checked
                txtRes.Text = CInt(txtC1.Text) / CInt(txtC2.Text)
            Case optMult.Checked
                txtRes.Text = CInt(txtC1.Text) * CInt(txtC2.Text)
        End Select
    End Sub
End Class