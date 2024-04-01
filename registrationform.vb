Imports System.Data.SqlClient
Public Class registrationform
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim i As Integer
    Private Sub registrationform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Ayush\College\Sem-4\New folder\Computer Accessories Management System\Database1.mdf;Integrated Security=True"
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
    End Sub
    Private Sub btnsup_Click(sender As Object, e As EventArgs) Handles btnsup.Click
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "insert into registration values('" + Me.fname.Text + "','" + Me.lname.Text + "','" + Me.username.Text + "','" + Me.password.Text + "','" + Me.email.Text + "','" + Me.contact.Text + "','user')"
        cmd.ExecuteNonQuery()
        MessageBox.Show("Registration Completed Successfully", "User Added", MessageBoxButtons.OK, MessageBoxIcon.Information)
        con.Close()
        Me.Hide()
        Dim lform As New Form1()
        lform.Show()
    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If password.UseSystemPasswordChar = True Then
            password.UseSystemPasswordChar = False
        Else
            password.UseSystemPasswordChar = True
        End If
        If npassword.UseSystemPasswordChar = True Then
            npassword.UseSystemPasswordChar = False
        Else
            npassword.UseSystemPasswordChar = True
        End If
    End Sub
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        Dim lform As New Form1()
        lform.Show()
    End Sub
End Class