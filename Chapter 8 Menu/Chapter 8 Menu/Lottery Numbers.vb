Public Class Lottery_Numbers

    Private Sub btnGenerateNumbers_Click(sender As Object, e As EventArgs) Handles btnGenerateNumbers.Click
        Const intMax_SUBSCRIPT As Integer = 4
        Dim intNumbers(intMax_SUBSCRIPT) As Integer
        Dim intCount As Integer

        Dim rand As New Random

        For intCount = 0 To intMax_SUBSCRIPT
            intNumbers(intCount) = rand.Next(100)
        Next

        lblone.Text = intNumbers(0).ToString
        lbltwo.Text = intNumbers(1).ToString
        lblthree.Text = intNumbers(2).ToString
        lblfour.Text = intNumbers(3).ToString
        lblFive.Text = intNumbers(4).ToString

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class