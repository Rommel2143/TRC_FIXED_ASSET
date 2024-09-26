<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addfatype
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
        Dim Status As System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cb_status = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.addbtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtmasterlist = New Guna.UI2.WinForms.Guna2TextBox()
        Status = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Status
        '
        Status.AutoSize = True
        Status.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Status.Location = New System.Drawing.Point(53, 175)
        Status.Name = "Status"
        Status.Size = New System.Drawing.Size(89, 21)
        Status.TabIndex = 179
        Status.Text = "Detination :"
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.cb_status)
        Me.Panel1.Controls.Add(Me.addbtn)
        Me.Panel1.Controls.Add(Status)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtmasterlist)
        Me.Panel1.Location = New System.Drawing.Point(114, 55)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(494, 371)
        Me.Panel1.TabIndex = 185
        '
        'cb_status
        '
        Me.cb_status.BackColor = System.Drawing.Color.Transparent
        Me.cb_status.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cb_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_status.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cb_status.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cb_status.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cb_status.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cb_status.ItemHeight = 30
        Me.cb_status.Items.AddRange(New Object() {"Section", "FA Type", "Supplier", "Service Provider"})
        Me.cb_status.Location = New System.Drawing.Point(57, 199)
        Me.cb_status.Name = "cb_status"
        Me.cb_status.Size = New System.Drawing.Size(229, 36)
        Me.cb_status.TabIndex = 184
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
        Me.addbtn.Text = "Add New Masterlist"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(53, 91)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(121, 21)
        Me.Label9.TabIndex = 178
        Me.Label9.Text = "Type Masterlist :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(229, 32)
        Me.Label1.TabIndex = 183
        Me.Label1.Text = "Add New Masterlist"
        '
        'txtmasterlist
        '
        Me.txtmasterlist.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtmasterlist.DefaultText = ""
        Me.txtmasterlist.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtmasterlist.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtmasterlist.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtmasterlist.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtmasterlist.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtmasterlist.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmasterlist.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtmasterlist.Location = New System.Drawing.Point(57, 115)
        Me.txtmasterlist.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtmasterlist.Name = "txtmasterlist"
        Me.txtmasterlist.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtmasterlist.PlaceholderText = "Enter Masterlist..."
        Me.txtmasterlist.SelectedText = ""
        Me.txtmasterlist.Size = New System.Drawing.Size(229, 30)
        Me.txtmasterlist.TabIndex = 181
        '
        'addfatype
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(743, 491)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "addfatype"
        Me.Text = "addfatype"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents addbtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtmasterlist As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cb_status As Guna.UI2.WinForms.Guna2ComboBox
End Class
