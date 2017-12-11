Public Class Freind_List

    Private Sub btnEnterNames_Click(sender As Object, e As EventArgs) Handles btnEnterNames.Click
        Const intMAX_SUBSCRIPT As Integer = 4
        Dim strNames(intMAX_SUBSCRIPT) As String
        Dim intCount As Integer

        MessageBox.Show("I'm going to ask you to enter the names " &
                        "of five friends")

        For intCount = 0 To intMAX_SUBSCRIPT
            strNames(intCount) = InputBox("Enter a friends name.")
        Next

        lstFriends.Items.Clear()

        For intCount = 0 To intMAX_SUBSCRIPT
            lstFriends.Items.Add(strNames(intCount))
        Next
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub
End Class