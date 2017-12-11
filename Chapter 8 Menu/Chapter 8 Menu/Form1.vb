Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Box = New Lottery_Numbers()
        Box.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Box = New Seating_Chart()
        Box.Show()
    End Sub

    Private Sub btnFriendsList_Click(sender As Object, e As EventArgs) Handles btnFriendsList.Click
        Dim Box = New Freind_List()
        Box.Show()
    End Sub

    Private Sub btnFriendsList2_Click(sender As Object, e As EventArgs) Handles btnFriendsList2.Click
        Dim Box = New Friends_List_2()
        Box.Show()
    End Sub
End Class
