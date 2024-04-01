<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sell
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sell))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.back = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cnm = New System.Windows.Forms.TextBox()
        Me.cno = New System.Windows.Forms.TextBox()
        Me.pcode = New System.Windows.Forms.TextBox()
        Me.price = New System.Windows.Forms.TextBox()
        Me.quantity = New System.Windows.Forms.TextBox()
        Me.total = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(540, 533)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(194, 45)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Print Bill"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'back
        '
        Me.back.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.back.Location = New System.Drawing.Point(264, 533)
        Me.back.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(113, 45)
        Me.back.TabIndex = 1
        Me.back.Text = "Back"
        Me.back.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(44, 32)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(172, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Customer Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(44, 113)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(191, 25)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Customer Number:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(44, 195)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(149, 25)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Product Code:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(44, 285)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 25)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Price:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(44, 366)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 25)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Quantity:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(44, 451)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(145, 25)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Total Amount:"
        '
        'cnm
        '
        Me.cnm.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cnm.Location = New System.Drawing.Point(378, 32)
        Me.cnm.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cnm.Name = "cnm"
        Me.cnm.Size = New System.Drawing.Size(356, 31)
        Me.cnm.TabIndex = 8
        '
        'cno
        '
        Me.cno.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cno.Location = New System.Drawing.Point(378, 113)
        Me.cno.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cno.Name = "cno"
        Me.cno.Size = New System.Drawing.Size(356, 31)
        Me.cno.TabIndex = 9
        '
        'pcode
        '
        Me.pcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.pcode.Location = New System.Drawing.Point(378, 195)
        Me.pcode.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pcode.Name = "pcode"
        Me.pcode.Size = New System.Drawing.Size(356, 31)
        Me.pcode.TabIndex = 10
        '
        'price
        '
        Me.price.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.price.Location = New System.Drawing.Point(378, 285)
        Me.price.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.price.Name = "price"
        Me.price.Size = New System.Drawing.Size(356, 31)
        Me.price.TabIndex = 11
        '
        'quantity
        '
        Me.quantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.quantity.Location = New System.Drawing.Point(378, 366)
        Me.quantity.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.quantity.Name = "quantity"
        Me.quantity.Size = New System.Drawing.Size(356, 31)
        Me.quantity.TabIndex = 12
        '
        'total
        '
        Me.total.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.total.Location = New System.Drawing.Point(378, 451)
        Me.total.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.total.Name = "total"
        Me.total.Size = New System.Drawing.Size(356, 31)
        Me.total.TabIndex = 13
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button3.Location = New System.Drawing.Point(415, 533)
        Me.Button3.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(68, 45)
        Me.Button3.TabIndex = 14
        Me.Button3.Text = "Sell"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button4.Location = New System.Drawing.Point(540, 595)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(194, 40)
        Me.Button4.TabIndex = 15
        Me.Button4.Text = "Print Preview"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'sell
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(896, 680)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.total)
        Me.Controls.Add(Me.quantity)
        Me.Controls.Add(Me.price)
        Me.Controls.Add(Me.pcode)
        Me.Controls.Add(Me.cno)
        Me.Controls.Add(Me.cnm)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.back)
        Me.Controls.Add(Me.Button1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "sell"
        Me.Text = "sell"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents back As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cnm As TextBox
    Friend WithEvents cno As TextBox
    Friend WithEvents pcode As TextBox
    Friend WithEvents price As TextBox
    Friend WithEvents quantity As TextBox
    Friend WithEvents total As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
End Class
