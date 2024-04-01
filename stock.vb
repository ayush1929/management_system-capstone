Imports System.Data.SqlClient
Imports System.Data
Public Class stock
    Dim con As New SqlConnection
    Private Sub stock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = Getproductlist()
    End Sub
    Private Function Getproductlist() As DataTable
        Dim dtproduct As New DataTable
        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Ayush\College\Sem-4\New folder\Computer Accessories Management System\Database1.mdf;Integrated Security=True"
        Using cmd As New SqlCommand("select * from dbo.product", con)
            con.Open()
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            dtproduct.Load(reader)
        End Using
        Return dtproduct
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dim rform As New admin()
        rform.Show()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class