Public Class admin
    Private Sub btnstock_Click(sender As Object, e As EventArgs) Handles btnstock.Click
        Me.Hide()
        Dim sform As New stock()
        sform.Show()
    End Sub

    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        Me.Hide()
        Dim rform1 As New Form1()
        rform1.Show()
    End Sub

    Private Sub btnuser_Click(sender As Object, e As EventArgs) Handles btnuser.Click
        Me.Hide()
        Dim uform As New user
        uform.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dim rform As New Product()
        rform.Show()
    End Sub

    Private Sub admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class