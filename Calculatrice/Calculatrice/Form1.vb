Public Class FrmMenu
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnCalc1.Click
        FrmCalc1.Show()
        Hide()
    End Sub

    Private Sub BtnCalc2_Click(sender As Object, e As EventArgs) Handles BtnCalc2.Click
        FrmCalc2.Show()
        Hide()
    End Sub
End Class
