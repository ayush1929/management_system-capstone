Imports System.Data.SqlClient
Public Class Form1

    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim i As Integer
    Dim role As String


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Ayush\College\Sem-4\New folder\Computer Accessories Management System\Database1.mdf;Integrated Security=True"
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
        btnsign.Focus()

    End Sub

    Private Sub btnsign_Click(sender As Object, e As EventArgs) Handles btnsign.Click

        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
        role = ""
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from registration where username='" + TextBox1.Text + "' and password='" + TextBox2.Text + "'"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        Dim dr As SqlDataReader
        dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
        While dr.Read
            role = dr.GetString(dr.GetOrdinal("role")).ToString()
        End While
        If role.ToString() = "" Then
            MessageBox.Show("Invalid Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        ElseIf role.ToString() = "Admin" Then
            Dim am = New admin
            am.Show()
            Me.Hide()
        ElseIf role.ToString() = "user" Then
            Dim cm = New customers
            cm.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If TextBox2.UseSystemPasswordChar = True Then
            TextBox2.UseSystemPasswordChar = False
        Else
            TextBox2.UseSystemPasswordChar = True
        End If
    End Sub
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        Dim rform As New registrationform()
        rform.Show()
    End Sub
End Class
