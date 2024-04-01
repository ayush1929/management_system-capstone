Imports System.Data.SqlClient
Imports System.Data
Public Class user
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim i As Integer
    Dim role As String
    Private Sub user_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = Getuserlist()
    End Sub
    Private Function Getuserlist() As DataTable
        Dim dtusers As New DataTable
        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Ayush\College\Sem-4\New folder\Computer Accessories Management System\Database1.mdf;Integrated Security=True"
        Using cmd As New SqlCommand("select * from dbo.registration", con)
            con.Open()
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            dtusers.Load(reader)
        End Using
        Return dtusers
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dim rform As New admin()
        rform.Show()
    End Sub

    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "
        cmd.ExecuteNonQuery()
        MessageBox.Show("Registration Completed Successfully", "User Added", MessageBoxButtons.OK, MessageBoxIcon.Information)
        con.Close()
    End Sub
End Class