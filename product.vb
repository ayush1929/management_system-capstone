Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class Product
    Dim rdr As SqlDataReader = Nothing
    Dim dtable As DataTable
    Dim con As SqlConnection = Nothing
    Dim adp As SqlDataAdapter
    Dim ds As DataSet
    Dim cmd As SqlCommand = Nothing
    Dim dt As New DataTable
    Dim cs As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Ayush\College\Sem-4\New folder\Computer Accessories Management System\Database1.mdf;Integrated Security=True"

    Sub clear()
        txtPrice.Text = ""
        txtProductCode.Text = ""
        txtProductName.Text = ""
        TextBox2.Text = ""
        txtquantity.Text = ""
        TextBox1.Text = ""
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
        txtProductCode.Text = "P-" & GetUniqueKey(4)
    End Sub
    Private Sub NewRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewRecord.Click
        clear()
        txtProductName.Focus()
        Save.Enabled = True
        Update_Record.Enabled = False
        Delete.Enabled = False
    End Sub
    Sub autocomplete()
        con = New SqlConnection(cs)
        con.Open()

        Dim cmd As New SqlCommand("SELECT productName FROM product", con)
        Dim ds As New DataSet
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(ds, "My List") 'list can be any name u want

        Dim col As New AutoCompleteStringCollection
        Dim i As Integer
        For i = 0 To ds.Tables(0).Rows.Count - 1
            col.Add(ds.Tables(0).Rows(i)("Productname").ToString())

        Next
        txtProductName.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtProductName.AutoCompleteCustomSource = col
        txtProductName.AutoCompleteMode = AutoCompleteMode.Suggest

        con.Close()
    End Sub
    Private Sub Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Save.Click


        If Len(Trim(txtProductName.Text)) = 0 Then
            MessageBox.Show("Please enter product name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtProductName.Focus()
            Exit Sub
        End If
        If Len(Trim(TextBox2.Text)) = 0 Then
            MessageBox.Show("Please select category", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBox2.Focus()
            Exit Sub
        End If
        If Len(Trim(txtquantity.Text)) = 0 Then
            MessageBox.Show("Please enter quantity", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtquantity.Focus()
            Exit Sub
        End If
        If Len(Trim(txtPrice.Text)) = 0 Then
            MessageBox.Show("Please enter price", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPrice.Focus()
            Exit Sub
        End If


        Try
            con = New SqlConnection(cs)
            con.Open()
            Dim ct1 As String = "select productname from product where productname= '" & txtProductName.Text & "' and quantity= '" & txtquantity.Text & "'"

            cmd = New SqlCommand(ct1)
            cmd.Connection = con
            rdr = cmd.ExecuteReader()

            If rdr.Read Then
                MessageBox.Show("Entry for product already exists" & vbCrLf & "You can not make duplicate entry" & vbCrLf & "for the same product name & quantity" & vbCrLf & "please update the details of product", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                If Not rdr Is Nothing Then
                    rdr.Close()
                End If
                Exit Sub
            End If

            auto()
            con = New SqlConnection(cs)
            con.Open()
            Dim ct As String = "select productcode from product where productcode=@find"

            cmd = New SqlCommand(ct)
            cmd.Connection = con
            cmd.Parameters.Add(New SqlParameter("@find", System.Data.SqlDbType.NChar, 20, "productcode"))
            cmd.Parameters("@find").Value = txtProductCode.Text
            rdr = cmd.ExecuteReader()

            If rdr.Read Then
                MessageBox.Show("Product Code Already Exists", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                If Not rdr Is Nothing Then
                    rdr.Close()
                End If

            Else



                con = New SqlConnection(cs)
                con.Open()
                Me.TextBox1.Text = Me.txtPrice.Text * Me.txtquantity.Text
                Dim cb As String = "insert into product(productcode,productname,category,quantity,price) VALUES (@d1,@d2,@d3,@d4,@d5)"

                cmd = New SqlCommand(cb)

                cmd.Connection = con

                cmd.Parameters.Add(New SqlParameter("@d1", System.Data.SqlDbType.NChar, 20, "productcode"))
                cmd.Parameters.Add(New SqlParameter("@d2", System.Data.SqlDbType.VarChar, 250, "productname"))


                cmd.Parameters.Add(New SqlParameter("@d3", System.Data.SqlDbType.VarChar, 150, "category"))

                cmd.Parameters.Add(New SqlParameter("@d4", System.Data.SqlDbType.NChar, 10, "quantity"))

                cmd.Parameters.Add(New SqlParameter("@d5", System.Data.SqlDbType.Float, 10, "price"))



                cmd.Parameters("@d1").Value = txtProductCode.Text
                cmd.Parameters("@d2").Value = txtProductName.Text

                cmd.Parameters("@d3").Value = TextBox2.Text


                cmd.Parameters("@d4").Value = txtquantity.Text

                cmd.Parameters("@d5").Value = CDbl(txtPrice.Text)


                cmd.ExecuteReader()
                MessageBox.Show("Successfully saved", "Product Details", MessageBoxButtons.OK, MessageBoxIcon.Information)

                fillCategory()
                fillquantity()
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

    Private Sub Update_Record_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Update_Record.Click
        Try

            con = New SqlConnection(cs)
            con.Open()

            Dim cb As String = "update product set Productname=@d2,category=@d3,quantity=@d4,price=@d5 where Productcode=@d1"

            cmd = New SqlCommand(cb)

            cmd.Connection = con

            cmd.Parameters.Add(New SqlParameter("@d1", System.Data.SqlDbType.NChar, 20, "productcode"))
            cmd.Parameters.Add(New SqlParameter("@d2", System.Data.SqlDbType.VarChar, 250, "productname"))


            cmd.Parameters.Add(New SqlParameter("@d3", System.Data.SqlDbType.VarChar, 150, "category"))

            cmd.Parameters.Add(New SqlParameter("@d4", System.Data.SqlDbType.NChar, 10, "quantity"))

            cmd.Parameters.Add(New SqlParameter("@d5", System.Data.SqlDbType.Float, 10, "price"))



            cmd.Parameters("@d1").Value = txtProductCode.Text
            cmd.Parameters("@d2").Value = txtProductName.Text

            cmd.Parameters("@d3").Value = TextBox2.Text


            cmd.Parameters("@d4").Value = txtquantity.Text

            cmd.Parameters("@d5").Value = CDbl(txtPrice.Text)


            cmd.ExecuteReader()
            MessageBox.Show("Successfully updated", "Product Details", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Update_Record.Enabled = False
            fillCategory()
            fillquantity()
            autocomplete()
            If con.State = ConnectionState.Open Then
                con.Close()
            End If

            con.Close()



        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Delete.Click
        Try



            If MessageBox.Show("Do you really want to delete the record?", "Product Record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                delete_records()



            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub delete_records()
        Try



            Dim RowsAffected As Integer = 0

            con = New SqlConnection(cs)

            con.Open()
            Dim ct As String = "select productcode from product where productcode=@find"


            cmd = New SqlCommand(ct)

            cmd.Connection = con
            cmd.Parameters.Add(New SqlParameter("@find", System.Data.SqlDbType.NChar, 20, "ProductCode"))


            cmd.Parameters("@find").Value = txtProductCode.Text


            rdr = cmd.ExecuteReader()

            If rdr.Read Then
                MessageBox.Show("Unable to delete..Already in use", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                clear()

                Update_Record.Enabled = False
                Delete.Enabled = False

                If Not rdr Is Nothing Then
                    rdr.Close()
                End If
                Exit Sub
            End If
            con = New SqlConnection(cs)

            con.Open()
            Dim ct1 As String = "select ProductCode from ProductSold where ProductCode=@find"


            cmd = New SqlCommand(ct1)

            cmd.Connection = con
            cmd.Parameters.Add(New SqlParameter("@find", System.Data.SqlDbType.NChar, 20, "ProductCode"))


            cmd.Parameters("@find").Value = txtProductCode.Text


            rdr = cmd.ExecuteReader()

            If rdr.Read Then
                MessageBox.Show("Unable to delete..Already in use", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                clear()

                Update_Record.Enabled = False
                Delete.Enabled = False

                If Not rdr Is Nothing Then
                    rdr.Close()
                End If
                Exit Sub
            End If
            con = New SqlConnection(cs)

            con.Open()
            Dim ct2 As String = "select productCode from product where productCode=@find"


            cmd = New SqlCommand(ct2)

            cmd.Connection = con
            cmd.Parameters.Add(New SqlParameter("@find", System.Data.SqlDbType.NChar, 20, "ProductCode"))


            cmd.Parameters("@find").Value = txtProductCode.Text


            rdr = cmd.ExecuteReader()

            If rdr.Read Then
                MessageBox.Show("Unable to delete..Already in use", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                clear()

                Update_Record.Enabled = False
                Delete.Enabled = False

                If Not rdr Is Nothing Then
                    rdr.Close()
                End If
                Exit Sub
            End If
            con = New SqlConnection(cs)

            con.Open()


            Dim cq As String = "delete from Product where ProductCode=@DELETE1;"


            cmd = New SqlCommand(cq)

            cmd.Connection = con

            cmd.Parameters.Add(New SqlParameter("@DELETE1", System.Data.SqlDbType.NChar, 20, "ProductCode"))


            cmd.Parameters("@DELETE1").Value = Trim(txtProductCode.Text)
            RowsAffected = cmd.ExecuteNonQuery()
            If RowsAffected > 0 Then

                MessageBox.Show("Successfully deleted", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)

                clear()

                Update_Record.Enabled = False
                Delete.Enabled = False
                fillCategory()
                fillquantity()
                autocomplete()
            Else
                MessageBox.Show("No record found", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information)

                clear()
                Update_Record.Enabled = False
                Delete.Enabled = False


                If con.State = ConnectionState.Open Then

                    con.Close()
                End If

                con.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub fillCategory()

        Try

            Dim CN As New SqlConnection(cs)

            CN.Open()
            adp = New SqlDataAdapter()
            adp.SelectCommand = New SqlCommand("SELECT distinct  RTRIM(category) FROM product", CN)
            ds = New DataSet("ds")

            adp.Fill(ds)
            dtable = ds.Tables(0)
            TextBox2.Clear()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub fillquantity()

        Try

            Dim CN As New SqlConnection(cs)

            CN.Open()
            adp = New SqlDataAdapter()
            adp.SelectCommand = New SqlCommand("SELECT distinct  RTRIM(quantity) FROM product", CN)
            ds = New DataSet("ds")

            adp.Fill(ds)
            dtable = ds.Tables(0)
            txtquantity.Clear()

            For Each drow As DataRow In dtable.Rows
                Dim v = txtquantity.SelectedText(drow(0).ToString())
                'DocName.SelectedIndex = -1
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmProduct_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Hide()
        admin.Show()
    End Sub
    Private Sub frmProduct_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fillCategory()
        fillquantity()
        autocomplete()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Save.Click
        Me.clear()
        stock.DataGridView1.DataSource = Nothing
        TextBox2.Text = ""
        txtquantity.Text = ""
        stock.DataGridView1.DataSource = Nothing
        txtProductName.Text = ""
        txtProductCode.Text = ""
        stock.DataGridView1.DataSource = Nothing
        stock.DataGridView1.DataSource = Nothing
    End Sub

    Private Sub txtPrice_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPrice.KeyPress
        Dim keyChar = e.KeyChar

        If Char.IsControl(keyChar) Then
            'Allow all control characters.
        ElseIf Char.IsDigit(keyChar) OrElse keyChar = "."c Then
            Dim text = Me.txtPrice.Text
            Dim selectionStart = Me.txtPrice.SelectionStart
            Dim selectionLength = Me.txtPrice.SelectionLength

            text = text.Substring(0, selectionStart) & keyChar & text.Substring(selectionStart + selectionLength)

            If Integer.TryParse(text, New Integer) AndAlso text.Length > 16 Then
                'Reject an integer that is longer than 16 digits.
                e.Handled = True
            ElseIf Double.TryParse(text, New Double) AndAlso text.IndexOf("."c) < text.Length - 3 Then
                'Reject a real number with two many decimal places.
                e.Handled = False
            End If
        Else
            'Reject all other characters.
            e.Handled = True
        End If
    End Sub
End Class