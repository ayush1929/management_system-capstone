<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class user
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Delete = New System.Windows.Forms.Button()
        Me.Update_Record = New System.Windows.Forms.Button()
        Me.adduser = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(744, 475)
        Me.DataGridView1.TabIndex = 0
        '
        'Delete
        '
        Me.Delete.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Delete.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Delete.Location = New System.Drawing.Point(769, 191)
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(91, 41)
        Me.Delete.TabIndex = 7
        Me.Delete.Text = "Delete"
        Me.Delete.UseVisualStyleBackColor = True
        '
        'Update_Record
        '
        Me.Update_Record.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Update_Record.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Update_Record.Location = New System.Drawing.Point(769, 132)
        Me.Update_Record.Name = "Update_Record"
        Me.Update_Record.Size = New System.Drawing.Size(91, 41)
        Me.Update_Record.TabIndex = 6
        Me.Update_Record.Text = "Update"
        Me.Update_Record.UseVisualStyleBackColor = True
        '
        'adduser
        '
        Me.adduser.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.adduser.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.adduser.Location = New System.Drawing.Point(769, 72)
        Me.adduser.Name = "adduser"
        Me.adduser.Size = New System.Drawing.Size(91, 41)
        Me.adduser.TabIndex = 4
        Me.adduser.Text = "Add"
        Me.adduser.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(781, 263)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(68, 48)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'user
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(872, 499)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Delete)
        Me.Controls.Add(Me.Update_Record)
        Me.Controls.Add(Me.adduser)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "user"
        Me.Text = "user"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Delete As Button
    Friend WithEvents Update_Record As Button
    Friend WithEvents adduser As Button
    Friend WithEvents Button1 As Button
End Class
