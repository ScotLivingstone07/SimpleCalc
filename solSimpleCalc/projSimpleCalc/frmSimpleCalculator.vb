Public Class frmSimpleCalculator
    Dim dblNum1, dblNum2, dblResult As Double
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        dblNum1 = CType(txtNum1.Text, Double)
        dblNum2 = CType(txtNum2.Text, Double)
        dblResult = dblNum1 + dblNum2
        lblResult.Text = CType(dblResult, String)

    End Sub
    Private Sub btnSubtract_Click(sender As Object, e As EventArgs) Handles btnSubtract.Click
        dblNum1 = CType(txtNum1.Text, Double)
        dblNum2 = CType(txtNum2.Text, Double)
        dblResult = dblNum1 - dblNum2
        lblResult.Text = CType(dblResult, String)
    End Sub
    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click
        dblNum1 = CType(txtNum1.Text, Double)
        dblNum2 = CType(txtNum2.Text, Double)
        dblResult = dblNum1 * dblNum2
        lblResult.Text = CType(dblResult, String)
    End Sub
    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        dblNum1 = CType(txtNum1.Text, Double)
        dblNum2 = CType(txtNum2.Text, Double)
        dblResult = dblNum1 / dblNum2
        lblResult.Text = CType(dblResult, String)
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
