Public Class customers
    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        Me.Hide()
        Dim rform1 As New Form1()
        rform1.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dim rform2 As New changepassword()
        rform2.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Dim rfrom3 As New sell()
        rfrom3.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Dim rfrom4 As New sales()
        rfrom4.Show()
    End Sub
End Class