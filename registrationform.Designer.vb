<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class registrationform
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblid = New System.Windows.Forms.Label()
        Me.btnsup = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.username = New System.Windows.Forms.TextBox()
        Me.password = New System.Windows.Forms.TextBox()
        Me.fname = New System.Windows.Forms.TextBox()
        Me.lname = New System.Windows.Forms.TextBox()
        Me.lbl4 = New System.Windows.Forms.Label()
        Me.email = New System.Windows.Forms.TextBox()
        Me.contact = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.npassword = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(57, 275)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 21)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Password"
        '
        'lblid
        '
        Me.lblid.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblid.AutoSize = True
        Me.lblid.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblid.Location = New System.Drawing.Point(57, 213)
        Me.lblid.Name = "lblid"
        Me.lblid.Size = New System.Drawing.Size(111, 21)
        Me.lblid.TabIndex = 9
        Me.lblid.Text = "Username "
        '
        'btnsup
        '
        Me.btnsup.AccessibleName = "btnsup"
        Me.btnsup.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnsup.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnsup.Location = New System.Drawing.Point(176, 379)
        Me.btnsup.Name = "btnsup"
        Me.btnsup.Size = New System.Drawing.Size(112, 32)
        Me.btnsup.TabIndex = 8
        Me.btnsup.Text = "Sign Up"
        Me.btnsup.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(392, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 21)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Last Name"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(57, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 21)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "First Name"
        '
        'CheckBox1
        '
        Me.CheckBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CheckBox1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CheckBox1.Location = New System.Drawing.Point(380, 280)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(126, 22)
        Me.CheckBox1.TabIndex = 13
        Me.CheckBox1.Text = "Show Password"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'username
        '
        Me.username.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.username.BackColor = System.Drawing.SystemColors.Menu
        Me.username.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.username.Location = New System.Drawing.Point(176, 210)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(185, 30)
        Me.username.TabIndex = 11
        '
        'password
        '
        Me.password.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.password.BackColor = System.Drawing.SystemColors.Menu
        Me.password.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.password.Location = New System.Drawing.Point(176, 272)
        Me.password.Name = "password"
        Me.password.Size = New System.Drawing.Size(185, 30)
        Me.password.TabIndex = 12
        Me.password.UseSystemPasswordChar = True
        '
        'fname
        '
        Me.fname.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.fname.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.fname.Location = New System.Drawing.Point(176, 65)
        Me.fname.Name = "fname"
        Me.fname.Size = New System.Drawing.Size(198, 30)
        Me.fname.TabIndex = 16
        '
        'lname
        '
        Me.lname.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lname.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lname.Location = New System.Drawing.Point(533, 65)
        Me.lname.Name = "lname"
        Me.lname.Size = New System.Drawing.Size(198, 30)
        Me.lname.TabIndex = 17
        '
        'lbl4
        '
        Me.lbl4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl4.AutoSize = True
        Me.lbl4.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl4.Location = New System.Drawing.Point(57, 142)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(89, 21)
        Me.lbl4.TabIndex = 18
        Me.lbl4.Text = "Email Id"
        '
        'email
        '
        Me.email.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.email.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.email.Location = New System.Drawing.Point(176, 137)
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(555, 30)
        Me.email.TabIndex = 19
        '
        'contact
        '
        Me.contact.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.contact.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.contact.Location = New System.Drawing.Point(533, 208)
        Me.contact.Name = "contact"
        Me.contact.Size = New System.Drawing.Size(198, 30)
        Me.contact.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(392, 213)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 21)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Contact No"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Bookman Old Style", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(316, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(137, 36)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Sign Up "
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LinkLabel1
        '
        Me.LinkLabel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Bookman Old Style", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LinkLabel1.Location = New System.Drawing.Point(176, 430)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(210, 15)
        Me.LinkLabel1.TabIndex = 25
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Already Have one,click here to login"
        '
        'npassword
        '
        Me.npassword.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.npassword.BackColor = System.Drawing.SystemColors.Menu
        Me.npassword.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.npassword.Location = New System.Drawing.Point(176, 319)
        Me.npassword.Name = "npassword"
        Me.npassword.Size = New System.Drawing.Size(185, 30)
        Me.npassword.TabIndex = 22
        Me.npassword.UseSystemPasswordChar = True
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(57, 322)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 42)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Confirm " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Password"
        '
        'registrationform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Bisque
        Me.ClientSize = New System.Drawing.Size(800, 454)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.npassword)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.contact)
        Me.Controls.Add(Me.email)
        Me.Controls.Add(Me.lbl4)
        Me.Controls.Add(Me.lname)
        Me.Controls.Add(Me.fname)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.password)
        Me.Controls.Add(Me.username)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblid)
        Me.Controls.Add(Me.btnsup)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "registrationform"
        Me.Text = "registrationform"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents lblid As Label
    Friend WithEvents btnsup As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents username As TextBox
    Friend WithEvents password As TextBox
    Friend WithEvents fname As TextBox
    Friend WithEvents lname As TextBox
    Friend WithEvents lbl4 As Label
    Friend WithEvents email As TextBox
    Friend WithEvents contact As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents npassword As TextBox
    Friend WithEvents Label5 As Label
End Class
