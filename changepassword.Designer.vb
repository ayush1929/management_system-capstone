<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class changepassword
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
        Me.btncp = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtun = New System.Windows.Forms.TextBox()
        Me.txtop = New System.Windows.Forms.TextBox()
        Me.txtnp = New System.Windows.Forms.TextBox()
        Me.txtcp = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btncp
        '
        Me.btncp.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btncp.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btncp.Location = New System.Drawing.Point(198, 290)
        Me.btncp.Name = "btncp"
        Me.btncp.Size = New System.Drawing.Size(220, 29)
        Me.btncp.TabIndex = 0
        Me.btncp.Text = "Change Password"
        Me.btncp.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bookman Old Style", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(38, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bookman Old Style", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(38, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Old Password"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bookman Old Style", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(38, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(157, 24)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "New Password"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Bookman Old Style", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(38, 200)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(197, 24)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Confirm Password"
        '
        'txtun
        '
        Me.txtun.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtun.Location = New System.Drawing.Point(261, 48)
        Me.txtun.Name = "txtun"
        Me.txtun.Size = New System.Drawing.Size(220, 23)
        Me.txtun.TabIndex = 5
        '
        'txtop
        '
        Me.txtop.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtop.Location = New System.Drawing.Point(261, 102)
        Me.txtop.Name = "txtop"
        Me.txtop.Size = New System.Drawing.Size(220, 23)
        Me.txtop.TabIndex = 6
        '
        'txtnp
        '
        Me.txtnp.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtnp.Location = New System.Drawing.Point(261, 155)
        Me.txtnp.Name = "txtnp"
        Me.txtnp.Size = New System.Drawing.Size(220, 23)
        Me.txtnp.TabIndex = 7
        '
        'txtcp
        '
        Me.txtcp.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtcp.Location = New System.Drawing.Point(261, 201)
        Me.txtcp.Name = "txtcp"
        Me.txtcp.Size = New System.Drawing.Size(220, 23)
        Me.txtcp.TabIndex = 8
        '
        'changepassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(569, 356)
        Me.Controls.Add(Me.txtcp)
        Me.Controls.Add(Me.txtnp)
        Me.Controls.Add(Me.txtop)
        Me.Controls.Add(Me.txtun)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btncp)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "changepassword"
        Me.Text = "changepassword"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btncp As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtun As TextBox
    Friend WithEvents txtop As TextBox
    Friend WithEvents txtnp As TextBox
    Friend WithEvents txtcp As TextBox
End Class
