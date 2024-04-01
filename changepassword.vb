Imports System.Data.SqlClient
Public Class changepassword
    Dim rdr As SqlDataReader = Nothing
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim i As Integer
    Dim role As String
    Dim ck As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Ayush\College\Sem-4\New folder\Computer Accessories Management System\Database1.mdf;Integrated Security=True"
    Private Sub ChangePassword_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Hide()
        Form1.Show()
        Form1.TextBox1.Text = ""
        Form1.TextBox2.Text = ""

        Form1.TextBox1.Focus()
    End Sub

    Private Sub btncp_Click(sender As Object, e As EventArgs) Handles btncp.Click
        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Ayush\College\Sem-4\New folder\Computer Accessories Management System\Database1.mdf;Integrated Security=True"
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
        Try
            Dim RowsAffected As Integer = 0
            If Len(Trim(txtun.Text)) = 0 Then
                MessageBox.Show("Please enter user name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtun.Focus()
                Exit Sub
            End If
            If Len(Trim(txtop.Text)) = 0 Then
                MessageBox.Show("Please enter old password", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtop.Focus()
                Exit Sub
            End If
            If Len(Trim(txtnp.Text)) = 0 Then
                MessageBox.Show("Please enter new password", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtnp.Focus()
                Exit Sub
            End If
            If Len(Trim(txtcp.Text)) = 0 Then
                MessageBox.Show("Please confirm new password", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtcp.Focus()
                Exit Sub
            End If
            If txtnp.TextLength < 5 Then
                MessageBox.Show("The New Password Should be of Atleast 5 Characters", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtnp.Text = ""
                txtcp.Text = ""
                txtnp.Focus()
                Exit Sub
            ElseIf txtnp.Text <> txtcp.Text Then
                MessageBox.Show("Password do not match", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtnp.Text = ""
                txtop.Text = ""
                txtcp.Text = ""
                txtop.Focus()
                Exit Sub
            ElseIf txtop.Text = txtnp.Text Then
                MessageBox.Show("Password is same..Re-enter new password", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtnp.Text = ""
                txtcp.Text = ""
                txtnp.Focus()
                Exit Sub
            End If


            con = New SqlConnection(ck)

            con.Open()

            Dim co As String = "Update registration set Password = '" & txtnp.Text & "'where username='" & txtun.Text & "' and Password = '" & txtop.Text & "'"

            cmd = New SqlCommand(co)

            cmd.Connection = con
            RowsAffected = cmd.ExecuteNonQuery()
            If RowsAffected > 0 Then

                MessageBox.Show("Successfully changed", "Password", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Hide()
                Form1.Show()
                txtun.Text = ""
                txtnp.Text = ""
                txtop.Text = ""
                txtcp.Text = ""
                Form1.TextBox1.Focus()
            Else

                MessageBox.Show("invalid user name or password", "input error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtun.Text = ""
                txtnp.Text = ""
                txtop.Text = ""
                txtcp.Text = ""
                txtun.Focus()
            End If








            If con.State = ConnectionState.Open Then

                con.Close()

            End If
            con.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Class