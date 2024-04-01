<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class customers
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(customers))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnlogout = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Button1.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(84, 153)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(168, 43)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Change Password"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnlogout
        '
        Me.btnlogout.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnlogout.BackColor = System.Drawing.Color.Tomato
        Me.btnlogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnlogout.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnlogout.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnlogout.Location = New System.Drawing.Point(760, 25)
        Me.btnlogout.Name = "btnlogout"
        Me.btnlogout.Size = New System.Drawing.Size(130, 43)
        Me.btnlogout.TabIndex = 8
        Me.btnlogout.Text = "LogOut"
        Me.btnlogout.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe Print", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.FloralWhite
        Me.Label1.Location = New System.Drawing.Point(383, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(223, 42)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "CB COMPUTERS"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Button3.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button3.Location = New System.Drawing.Point(84, 218)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(168, 43)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "Sell"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Button2.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button2.Location = New System.Drawing.Point(84, 286)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(168, 43)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "View Sales"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe Print", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.FloralWhite
        Me.Label2.Location = New System.Drawing.Point(80, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(172, 42)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "User Control"
        '
        'customers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(917, 543)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnlogout)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "customers"
        Me.Text = "customers"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents btnlogout As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label2 As Label
End Class
