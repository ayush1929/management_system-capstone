<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class admin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(admin))
        Me.btnlogout = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnstock = New System.Windows.Forms.Button()
        Me.btnuser = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnlogout
        '
        Me.btnlogout.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnlogout.BackColor = System.Drawing.Color.Tomato
        Me.btnlogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnlogout.Font = New System.Drawing.Font("Bookman Old Style", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnlogout.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnlogout.Location = New System.Drawing.Point(607, 12)
        Me.btnlogout.Name = "btnlogout"
        Me.btnlogout.Size = New System.Drawing.Size(130, 43)
        Me.btnlogout.TabIndex = 7
        Me.btnlogout.Text = "LogOut"
        Me.btnlogout.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Bookman Old Style", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(36, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(247, 39)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Admin Control"
        '
        'btnstock
        '
        Me.btnstock.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnstock.BackColor = System.Drawing.Color.MediumAquamarine
        Me.btnstock.Font = New System.Drawing.Font("Bookman Old Style", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnstock.Location = New System.Drawing.Point(59, 254)
        Me.btnstock.Name = "btnstock"
        Me.btnstock.Size = New System.Drawing.Size(170, 42)
        Me.btnstock.TabIndex = 8
        Me.btnstock.Text = "View Stock"
        Me.btnstock.UseVisualStyleBackColor = False
        '
        'btnuser
        '
        Me.btnuser.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnuser.BackColor = System.Drawing.Color.MediumAquamarine
        Me.btnuser.Font = New System.Drawing.Font("Bookman Old Style", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnuser.Location = New System.Drawing.Point(59, 129)
        Me.btnuser.Name = "btnuser"
        Me.btnuser.Size = New System.Drawing.Size(170, 42)
        Me.btnuser.TabIndex = 7
        Me.btnuser.Text = "View Users"
        Me.btnuser.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Bookman Old Style", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(232, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(285, 39)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "CB COMPUTERS"
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.BackColor = System.Drawing.Color.MediumAquamarine
        Me.Button1.Font = New System.Drawing.Font("Bookman Old Style", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(59, 195)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(170, 42)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Add Stock"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(749, 493)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnlogout)
        Me.Controls.Add(Me.btnstock)
        Me.Controls.Add(Me.btnuser)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "admin"
        Me.Text = "admin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnlogout As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnstock As Button
    Friend WithEvents btnuser As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
End Class
