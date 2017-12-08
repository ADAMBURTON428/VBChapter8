Public Class Form1

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        Const intMAX_SUBSCRIPT As Integer = 4
        Dim intNumber(intMAX_SUBSCRIPT) As Integer
        Dim intCount As Integer
        Dim rand As New Random

        For intCount = 0 To intMAX_SUBSCRIPT
            intNumber(intCount) = rand.Next(100)
        Next

        lblFirst.Text = intNumber(0).ToString()
        lblSecond.Text = intNumber(1).ToString()
        lblThird.Text = intNumber(2).ToString()
        lblForth.Text = intNumber(3).ToString()
        lblFifth.Text = intNumber(4).ToString()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
