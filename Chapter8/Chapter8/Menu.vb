Public Class Menu

    Private Sub btnFriends_Click(sender As Object, e As EventArgs) Handles btnFriends.Click
        Dim box = New FriendsList()
        box.Show()
    End Sub

    Private Sub btnSeating_Click(sender As Object, e As EventArgs) Handles btnSeating.Click
        Dim box = New SeatingChart()
        box.Show()
    End Sub

    Private Sub btnRandomNum_Click(sender As Object, e As EventArgs) Handles btnRandomNum.Click
        Dim box = New Form1()
        box.Show()
    End Sub

    Private Sub btnFriend2_Click(sender As Object, e As EventArgs) Handles btnFriend2.Click
        Dim box = New FriendList2()
        box.Show()
    End Sub
End Class