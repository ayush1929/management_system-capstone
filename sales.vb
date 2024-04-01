Imports System.Data.SqlClient
Imports System.Data
Public Class sales
    Dim con As New SqlConnection
    Private Sub sales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = Getsaleslist()
    End Sub
    Private Function Getsaleslist() As DataTable
        Dim dtsales As New DataTable
        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Ayush\College\Sem-4\New folder\Computer Accessories Management System\Database1.mdf;Integrated Security=True"
        Using cmd As New SqlCommand("select * from dbo.sales", con)
            con.Open()
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            dtsales.Load(reader)
        End Using
        Return dtsales
    End Function
End Class