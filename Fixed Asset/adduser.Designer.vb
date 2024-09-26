<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adduser
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.addbtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtfullname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtidnumber = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.addbtn)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.txtfullname)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtidnumber)
        Me.Panel1.Location = New System.Drawing.Point(156, 56)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(494, 371)
        Me.Panel1.TabIndex = 185
        '
        'addbtn
        '
        Me.addbtn.BorderRadius = 4
        Me.addbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.addbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.addbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.addbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.addbtn.FillColor = System.Drawing.Color.ForestGreen
        Me.addbtn.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addbtn.ForeColor = System.Drawing.Color.White
        Me.addbtn.Location = New System.Drawing.Point(57, 254)
        Me.addbtn.Name = "addbtn"
        Me.addbtn.Size = New System.Drawing.Size(130, 51)
        Me.addbtn.TabIndex = 180
        Me.addbtn.Text = "Add New User"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(53, 175)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 21)
        Me.Label8.TabIndex = 179
        Me.Label8.Text = "Fullname :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(53, 91)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(94, 21)
        Me.Label9.TabIndex = 178
        Me.Label9.Text = "ID Number :"
        '
        'txtfullname
        '
        Me.txtfullname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtfullname.DefaultText = ""
        Me.txtfullname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtfullname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtfullname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtfullname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtfullname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtfullname.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfullname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtfullname.Location = New System.Drawing.Point(57, 199)
        Me.txtfullname.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtfullname.Name = "txtfullname"
        Me.txtfullname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtfullname.PlaceholderText = "Enter Fullname..."
        Me.txtfullname.SelectedText = ""
        Me.txtfullname.Size = New System.Drawing.Size(360, 30)
        Me.txtfullname.TabIndex = 177
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(171, 32)
        Me.Label1.TabIndex = 183
        Me.Label1.Text = "Add New User"
        '
        'txtidnumber
        '
        Me.txtidnumber.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtidnumber.DefaultText = ""
        Me.txtidnumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtidnumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtidnumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtidnumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtidnumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtidnumber.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtidnumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtidnumber.Location = New System.Drawing.Point(57, 115)
        Me.txtidnumber.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtidnumber.Name = "txtidnumber"
        Me.txtidnumber.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtidnumber.PlaceholderText = "Enter ID Number..."
        Me.txtidnumber.SelectedText = ""
        Me.txtidnumber.Size = New System.Drawing.Size(229, 30)
        Me.txtidnumber.TabIndex = 181
        '
        'adduser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(807, 483)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "adduser"
        Me.Text = "adduser"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents addbtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtfullname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtidnumber As Guna.UI2.WinForms.Guna2TextBox
End Class
