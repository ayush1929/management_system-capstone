Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text
Public Class sell
    Dim rdr As SqlDataReader = Nothing
    Dim dtable As DataTable
    Dim con As SqlConnection = Nothing
    Dim adp As SqlDataAdapter
    Dim ds As DataSet
    Dim cmd As SqlCommand = Nothing
    Dim dt As New DataTable
    Dim cs As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Ayush\College\Sem-4\New folder\Computer Accessories Management System\Database1.mdf;Integrated Security=True"
    Public Property Save As Object

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        Me.Hide()
        Dim rform As New customers()
        rform.Show()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PrintDocument1.Print()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.total.Text = Me.price.Text * Me.quantity.Text
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.Show()

    End Sub
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString("CB COMPUTERS", New Font("Bookman Old Style", 24, FontStyle.Bold), Brushes.Blue, New Point(250, 20))

        e.Graphics.DrawString("Date:" + DateTime.Now, New Font("Bookman Old Style", 24, FontStyle.Regular), Brushes.Black, New Point(200, 200))
        e.Graphics.DrawString("Customer Name:" + Me.cnm.Text, New Font("Bookman Old Style", 24, FontStyle.Regular), Brushes.Black, New Point(200, 250))
        e.Graphics.DrawString("Customer Number:" + Me.cno.Text, New Font("Bookman Old Style", 24, FontStyle.Regular), Brushes.Black, New Point(200, 300))
        e.Graphics.DrawString("Produce Code:" + Me.pcode.Text, New Font("Bookman Old Style", 24, FontStyle.Regular), Brushes.Black, New Point(200, 350))
        e.Graphics.DrawString("Price:" + Me.price.Text, New Font("Bookman Old Style", 24, FontStyle.Regular), Brushes.Black, New Point(200, 400))
        e.Graphics.DrawString("Quantity:" + Me.quantity.Text, New Font("Bookman Old Style", 24, FontStyle.Regular), Brushes.Black, New Point(200, 450))
        e.Graphics.DrawString("Total Rs." + Me.total.Text, New Font("Bookman Old Style", 24, FontStyle.Regular), Brushes.Black, New Point(200, 500))
        e.Graphics.DrawString("Thanks For Buying", New Font("Bookman Old Style", 24, FontStyle.Bold), Brushes.Red, New Point(200, 600))
    End Sub
    Sub clear()
        cnm.Text = ""
        cno.Text = ""
        pcode.Text = ""
        price.Text = ""
        quantity.Text = ""
        total.Text = ""

    End Sub
    Public Shared Function GetUniqueKey(ByVal maxSize As Integer) As String
        Dim chars As Char() = New Char(61) {}
        chars = "123456789".ToCharArray()
        Dim data As Byte() = New Byte(0) {}
        Dim crypto As New RNGCryptoServiceProvider()
        crypto.GetNonZeroBytes(data)
        data = New Byte(maxSize - 1) {}
        crypto.GetNonZeroBytes(data)
        Dim result As New StringBuilder(maxSize)
        For Each b As Byte In data
            result.Append(chars(b Mod (chars.Length)))
        Next
        Return result.ToString()
    End Function
    Sub auto()
        pcode.Text = "P-" & GetUniqueKey(4)

    End Sub
    Sub autocomplete()
        con = New SqlConnection(cs)
        con.Open()

        Dim cmd As New SqlCommand("SELECT productcode FROM sales", con)
        Dim ds As New DataSet
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(ds, "My List") 'list can be any name u want

        Dim col As New AutoCompleteStringCollection
        Dim i As Integer
        For i = 0 To ds.Tables(0).Rows.Count - 1
            col.Add(ds.Tables(0).Rows(i)("productcode").ToString())

        Next
        cnm.AutoCompleteSource = AutoCompleteSource.CustomSource
        cno.AutoCompleteCustomSource = col
        pcode.AutoCompleteMode = AutoCompleteMode.Suggest

        con.Close()
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click


        If Len(Trim(cnm.Text)) = 0 Then
            MessageBox.Show("Please enter Customer name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cnm.Focus()
            Exit Sub
        End If
        If Len(Trim(cno.Text)) = 0 Then
            MessageBox.Show("Please enter Customer no", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cno.Focus()
            Exit Sub
        End If
        If Len(Trim(price.Text)) = 0 Then
            MessageBox.Show("Please enter price", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            price.Focus()
            Exit Sub
        End If
        If Len(Trim(quantity.Text)) = 0 Then
            MessageBox.Show("Please enter Quantity", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            quantity.Focus()
            Exit Sub
        End If


        Try
            auto()
            con = New SqlConnection(cs)
            con.Open()
            Dim ct As String = "select productcode from product where productcode=@find"

            cmd = New SqlCommand(ct)
            cmd.Connection = con
            cmd.Parameters.Add(New SqlParameter("@find", System.Data.SqlDbType.NVarChar, 50, "productcode"))
            cmd.Parameters("@find").Value = pcode.Text
            rdr = cmd.ExecuteReader()
            Me.total.Text = Me.price.Text * Me.quantity.Text
            If rdr.Read Then
                MessageBox.Show("Product Code Already Exists", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                If Not rdr Is Nothing Then
                    rdr.Close()
                End If

            Else
                con = New SqlConnection(cs)
                con.Open()

                Dim cb As String = "insert into sales(cname,cno,productcode,price,quantity) VALUES (@d1,@d2,@d3,@d4,@d5)"

                cmd = New SqlCommand(cb)

                cmd.Connection = con

                cmd.Parameters.Add(New SqlParameter("@d1", System.Data.SqlDbType.NVarChar, 50, "cname"))
                cmd.Parameters.Add(New SqlParameter("@d2", System.Data.SqlDbType.Int, 18, "cno"))


                cmd.Parameters.Add(New SqlParameter("@d3", System.Data.SqlDbType.NVarChar, 50, "productcode"))

                cmd.Parameters.Add(New SqlParameter("@d4", System.Data.SqlDbType.Float, 10, "price"))

                cmd.Parameters.Add(New SqlParameter("@d5", System.Data.SqlDbType.Int, 10, "quantity"))



                cmd.Parameters("@d1").Value = cnm.Text
                cmd.Parameters("@d2").Value = cno.Text

                cmd.Parameters("@d3").Value = pcode.Text


                cmd.Parameters("@d4").Value = CDbl(price.Text)

                cmd.Parameters("@d5").Value = quantity.Text




                cmd.ExecuteReader()
                MessageBox.Show("Successfully saved", "Sale Details", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Save.Enabled = False
                autocomplete()
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If

                con.Close()
            End If



        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub frmsell_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Hide()
        customers.Show()
    End Sub
End Class