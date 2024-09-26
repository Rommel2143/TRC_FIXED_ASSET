<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.datagrid1 = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.btn_delete = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_edit = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_save = New Guna.UI2.WinForms.Guna2Button()
        Me.txt_amount = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_itemdes = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_sino = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_pono = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_fano = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_no = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cb_section = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cb_supplier = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cb_fatype = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.cb_servicepro = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.dt_podate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.dt_accomdate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.txt_sino1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_amount1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtuser = New Guna.UI2.WinForms.Guna2TextBox()
        Me.dt_date = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.btn_cancel = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_exit = New Guna.UI2.WinForms.Guna2Button()
        Me.btnaddservice = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.datagrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'datagrid1
        '
        Me.datagrid1.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.datagrid1.AllowUserToResizeRows = False
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagrid1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
        Me.datagrid1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagrid1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.datagrid1.ColumnHeadersHeight = 30
        Me.datagrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datagrid1.DefaultCellStyle = DataGridViewCellStyle11
        Me.datagrid1.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.datagrid1.Location = New System.Drawing.Point(12, 429)
        Me.datagrid1.MinimumSize = New System.Drawing.Size(20, 0)
        Me.datagrid1.Name = "datagrid1"
        Me.datagrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagrid1.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.datagrid1.RowHeadersVisible = False
        Me.datagrid1.Size = New System.Drawing.Size(1334, 131)
        Me.datagrid1.TabIndex = 53
        Me.datagrid1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.datagrid1.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.datagrid1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.datagrid1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.datagrid1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.datagrid1.ThemeStyle.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.datagrid1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.datagrid1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.datagrid1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.datagrid1.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datagrid1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.datagrid1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.datagrid1.ThemeStyle.HeaderStyle.Height = 30
        Me.datagrid1.ThemeStyle.ReadOnly = False
        Me.datagrid1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.datagrid1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.datagrid1.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datagrid1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.datagrid1.ThemeStyle.RowsStyle.Height = 22
        Me.datagrid1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.datagrid1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'btn_delete
        '
        Me.btn_delete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_delete.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_delete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_delete.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_delete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_delete.FillColor = System.Drawing.Color.Tomato
        Me.btn_delete.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_delete.ForeColor = System.Drawing.Color.White
        Me.btn_delete.Location = New System.Drawing.Point(1053, 372)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(79, 37)
        Me.btn_delete.TabIndex = 52
        Me.btn_delete.Text = "DELETE"
        '
        'btn_edit
        '
        Me.btn_edit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_edit.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_edit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_edit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_edit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_edit.FillColor = System.Drawing.Color.DodgerBlue
        Me.btn_edit.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_edit.ForeColor = System.Drawing.Color.White
        Me.btn_edit.Location = New System.Drawing.Point(855, 372)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(79, 37)
        Me.btn_edit.TabIndex = 50
        Me.btn_edit.Text = "UPDATE"
        '
        'btn_save
        '
        Me.btn_save.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_save.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_save.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_save.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_save.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_save.FillColor = System.Drawing.Color.DodgerBlue
        Me.btn_save.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_save.ForeColor = System.Drawing.Color.White
        Me.btn_save.Location = New System.Drawing.Point(759, 372)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(79, 37)
        Me.btn_save.TabIndex = 49
        Me.btn_save.Text = "SAVE"
        '
        'txt_amount
        '
        Me.txt_amount.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_amount.DefaultText = ""
        Me.txt_amount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_amount.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_amount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_amount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_amount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_amount.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_amount.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_amount.Location = New System.Drawing.Point(500, 196)
        Me.txt_amount.Name = "txt_amount"
        Me.txt_amount.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_amount.PlaceholderText = "Enter Amount.."
        Me.txt_amount.SelectedText = ""
        Me.txt_amount.Size = New System.Drawing.Size(201, 36)
        Me.txt_amount.TabIndex = 48
        '
        'txt_itemdes
        '
        Me.txt_itemdes.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_itemdes.DefaultText = ""
        Me.txt_itemdes.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_itemdes.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_itemdes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_itemdes.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_itemdes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_itemdes.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_itemdes.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_itemdes.Location = New System.Drawing.Point(160, 321)
        Me.txt_itemdes.Name = "txt_itemdes"
        Me.txt_itemdes.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_itemdes.PlaceholderText = "Enter Item Description..."
        Me.txt_itemdes.SelectedText = ""
        Me.txt_itemdes.Size = New System.Drawing.Size(201, 36)
        Me.txt_itemdes.TabIndex = 47
        '
        'txt_sino
        '
        Me.txt_sino.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_sino.DefaultText = ""
        Me.txt_sino.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_sino.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_sino.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_sino.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_sino.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_sino.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_sino.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_sino.Location = New System.Drawing.Point(500, 141)
        Me.txt_sino.Name = "txt_sino"
        Me.txt_sino.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_sino.PlaceholderText = "Enter SI No..."
        Me.txt_sino.SelectedText = ""
        Me.txt_sino.Size = New System.Drawing.Size(201, 36)
        Me.txt_sino.TabIndex = 45
        '
        'txt_pono
        '
        Me.txt_pono.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_pono.DefaultText = ""
        Me.txt_pono.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_pono.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_pono.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_pono.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_pono.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_pono.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_pono.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_pono.Location = New System.Drawing.Point(500, 89)
        Me.txt_pono.Name = "txt_pono"
        Me.txt_pono.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_pono.PlaceholderText = "Enter PO No..."
        Me.txt_pono.SelectedText = ""
        Me.txt_pono.Size = New System.Drawing.Size(201, 36)
        Me.txt_pono.TabIndex = 44
        '
        'txt_fano
        '
        Me.txt_fano.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_fano.DefaultText = ""
        Me.txt_fano.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_fano.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_fano.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_fano.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_fano.Enabled = False
        Me.txt_fano.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_fano.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_fano.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_fano.Location = New System.Drawing.Point(160, 164)
        Me.txt_fano.Name = "txt_fano"
        Me.txt_fano.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_fano.PlaceholderText = "Enter FA No..."
        Me.txt_fano.ReadOnly = True
        Me.txt_fano.SelectedText = ""
        Me.txt_fano.Size = New System.Drawing.Size(201, 36)
        Me.txt_fano.TabIndex = 41
        '
        'txt_no
        '
        Me.txt_no.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_no.DefaultText = ""
        Me.txt_no.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_no.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_no.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_no.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_no.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_no.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_no.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_no.Location = New System.Drawing.Point(160, 117)
        Me.txt_no.Name = "txt_no"
        Me.txt_no.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_no.PlaceholderText = "Enter No.."
        Me.txt_no.SelectedText = ""
        Me.txt_no.Size = New System.Drawing.Size(201, 36)
        Me.txt_no.TabIndex = 40
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(384, 161)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 20)
        Me.Label10.TabIndex = 39
        Me.Label10.Text = "SI No. :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(384, 206)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 20)
        Me.Label9.TabIndex = 38
        Me.Label9.Text = "Amount :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(24, 337)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(133, 20)
        Me.Label8.TabIndex = 37
        Me.Label8.Text = "Item Description :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(28, 287)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 20)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Section:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(384, 109)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 20)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "PO No. :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(384, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 20)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Acquisition Date :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(28, 232)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 20)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "FA Type :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(28, 180)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 20)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "FA No."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 130)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 20)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "No. :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(384, 256)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 20)
        Me.Label6.TabIndex = 54
        Me.Label6.Text = "Supplier :"
        '
        'cb_section
        '
        Me.cb_section.BackColor = System.Drawing.Color.Transparent
        Me.cb_section.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cb_section.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_section.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cb_section.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cb_section.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cb_section.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cb_section.ItemHeight = 30
        Me.cb_section.Location = New System.Drawing.Point(160, 271)
        Me.cb_section.Name = "cb_section"
        Me.cb_section.Size = New System.Drawing.Size(201, 36)
        Me.cb_section.TabIndex = 57
        '
        'cb_supplier
        '
        Me.cb_supplier.BackColor = System.Drawing.Color.Transparent
        Me.cb_supplier.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cb_supplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_supplier.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cb_supplier.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cb_supplier.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cb_supplier.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cb_supplier.ItemHeight = 30
        Me.cb_supplier.Location = New System.Drawing.Point(500, 250)
        Me.cb_supplier.Name = "cb_supplier"
        Me.cb_supplier.Size = New System.Drawing.Size(201, 36)
        Me.cb_supplier.TabIndex = 58
        '
        'cb_fatype
        '
        Me.cb_fatype.BackColor = System.Drawing.Color.Transparent
        Me.cb_fatype.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cb_fatype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_fatype.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cb_fatype.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cb_fatype.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cb_fatype.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cb_fatype.ItemHeight = 30
        Me.cb_fatype.Location = New System.Drawing.Point(160, 216)
        Me.cb_fatype.Name = "cb_fatype"
        Me.cb_fatype.Size = New System.Drawing.Size(201, 36)
        Me.cb_fatype.TabIndex = 59
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(12, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(205, 20)
        Me.Label11.TabIndex = 60
        Me.Label11.Text = "Related Services If any?"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.White
        Me.Guna2Panel1.BorderColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Guna2Panel1.Controls.Add(Me.cb_servicepro)
        Me.Guna2Panel1.Controls.Add(Me.dt_podate)
        Me.Guna2Panel1.Controls.Add(Me.dt_accomdate)
        Me.Guna2Panel1.Controls.Add(Me.txt_sino1)
        Me.Guna2Panel1.Controls.Add(Me.txt_amount1)
        Me.Guna2Panel1.Controls.Add(Me.Label16)
        Me.Guna2Panel1.Controls.Add(Me.Label12)
        Me.Guna2Panel1.Controls.Add(Me.Label13)
        Me.Guna2Panel1.Controls.Add(Me.Label14)
        Me.Guna2Panel1.Controls.Add(Me.Label15)
        Me.Guna2Panel1.Controls.Add(Me.Label11)
        Me.Guna2Panel1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Guna2Panel1.Location = New System.Drawing.Point(759, 55)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(515, 301)
        Me.Guna2Panel1.TabIndex = 61
        '
        'cb_servicepro
        '
        Me.cb_servicepro.BackColor = System.Drawing.Color.Transparent
        Me.cb_servicepro.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cb_servicepro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_servicepro.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cb_servicepro.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cb_servicepro.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cb_servicepro.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cb_servicepro.ItemHeight = 30
        Me.cb_servicepro.Location = New System.Drawing.Point(148, 47)
        Me.cb_servicepro.Name = "cb_servicepro"
        Me.cb_servicepro.Size = New System.Drawing.Size(201, 36)
        Me.cb_servicepro.TabIndex = 152
        '
        'dt_podate
        '
        Me.dt_podate.BorderRadius = 2
        Me.dt_podate.Checked = True
        Me.dt_podate.CustomFormat = "MMMM dd yyyy"
        Me.dt_podate.FillColor = System.Drawing.SystemColors.Highlight
        Me.dt_podate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dt_podate.ForeColor = System.Drawing.Color.White
        Me.dt_podate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dt_podate.Location = New System.Drawing.Point(106, 145)
        Me.dt_podate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dt_podate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dt_podate.Name = "dt_podate"
        Me.dt_podate.Size = New System.Drawing.Size(191, 36)
        Me.dt_podate.TabIndex = 130
        Me.dt_podate.Value = New Date(2024, 9, 23, 0, 0, 0, 0)
        '
        'dt_accomdate
        '
        Me.dt_accomdate.BorderRadius = 2
        Me.dt_accomdate.Checked = True
        Me.dt_accomdate.CustomFormat = "MMMM dd yyyy"
        Me.dt_accomdate.FillColor = System.Drawing.SystemColors.Highlight
        Me.dt_accomdate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dt_accomdate.ForeColor = System.Drawing.Color.White
        Me.dt_accomdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dt_accomdate.Location = New System.Drawing.Point(182, 99)
        Me.dt_accomdate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dt_accomdate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dt_accomdate.Name = "dt_accomdate"
        Me.dt_accomdate.Size = New System.Drawing.Size(191, 36)
        Me.dt_accomdate.TabIndex = 129
        Me.dt_accomdate.Value = New Date(2024, 9, 23, 0, 0, 0, 0)
        '
        'txt_sino1
        '
        Me.txt_sino1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_sino1.DefaultText = ""
        Me.txt_sino1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_sino1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_sino1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_sino1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_sino1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_sino1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_sino1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_sino1.Location = New System.Drawing.Point(96, 250)
        Me.txt_sino1.Name = "txt_sino1"
        Me.txt_sino1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_sino1.PlaceholderText = "Enter SI NO..."
        Me.txt_sino1.SelectedText = ""
        Me.txt_sino1.Size = New System.Drawing.Size(201, 36)
        Me.txt_sino1.TabIndex = 70
        '
        'txt_amount1
        '
        Me.txt_amount1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_amount1.DefaultText = ""
        Me.txt_amount1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_amount1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_amount1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_amount1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_amount1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_amount1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_amount1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_amount1.Location = New System.Drawing.Point(96, 200)
        Me.txt_amount1.Name = "txt_amount1"
        Me.txt_amount1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_amount1.PlaceholderText = "Enter Amount..."
        Me.txt_amount1.SelectedText = ""
        Me.txt_amount1.Size = New System.Drawing.Size(201, 36)
        Me.txt_amount1.TabIndex = 69
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(12, 254)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(61, 20)
        Me.Label16.TabIndex = 65
        Me.Label16.Text = "SI No. :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(12, 210)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(73, 20)
        Me.Label12.TabIndex = 64
        Me.Label12.Text = "Amount :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(12, 115)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(173, 20)
        Me.Label13.TabIndex = 63
        Me.Label13.Text = "Accomplishment Date :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(12, 160)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(78, 20)
        Me.Label14.TabIndex = 62
        Me.Label14.Text = "PO Date :"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(12, 63)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(130, 20)
        Me.Label15.TabIndex = 61
        Me.Label15.Text = "Service Provider :"
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BorderColor = System.Drawing.Color.Black
        Me.Guna2Panel2.Controls.Add(Me.Label19)
        Me.Guna2Panel2.Controls.Add(Me.txtuser)
        Me.Guna2Panel2.Controls.Add(Me.dt_date)
        Me.Guna2Panel2.Controls.Add(Me.Label17)
        Me.Guna2Panel2.Controls.Add(Me.txt_itemdes)
        Me.Guna2Panel2.Controls.Add(Me.Label1)
        Me.Guna2Panel2.Controls.Add(Me.cb_supplier)
        Me.Guna2Panel2.Controls.Add(Me.cb_fatype)
        Me.Guna2Panel2.Controls.Add(Me.Label2)
        Me.Guna2Panel2.Controls.Add(Me.Label6)
        Me.Guna2Panel2.Controls.Add(Me.Label3)
        Me.Guna2Panel2.Controls.Add(Me.cb_section)
        Me.Guna2Panel2.Controls.Add(Me.Label7)
        Me.Guna2Panel2.Controls.Add(Me.Label8)
        Me.Guna2Panel2.Controls.Add(Me.txt_no)
        Me.Guna2Panel2.Controls.Add(Me.txt_fano)
        Me.Guna2Panel2.Controls.Add(Me.txt_amount)
        Me.Guna2Panel2.Controls.Add(Me.Label4)
        Me.Guna2Panel2.Controls.Add(Me.txt_sino)
        Me.Guna2Panel2.Controls.Add(Me.Label5)
        Me.Guna2Panel2.Controls.Add(Me.txt_pono)
        Me.Guna2Panel2.Controls.Add(Me.Label9)
        Me.Guna2Panel2.Controls.Add(Me.Label10)
        Me.Guna2Panel2.FillColor = System.Drawing.Color.White
        Me.Guna2Panel2.Location = New System.Drawing.Point(15, 55)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(724, 368)
        Me.Guna2Panel2.TabIndex = 62
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.White
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(24, 89)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(51, 20)
        Me.Label19.TabIndex = 151
        Me.Label19.Text = "User :"
        '
        'txtuser
        '
        Me.txtuser.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtuser.DefaultText = ""
        Me.txtuser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtuser.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtuser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtuser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtuser.Enabled = False
        Me.txtuser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtuser.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtuser.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtuser.Location = New System.Drawing.Point(160, 79)
        Me.txtuser.Name = "txtuser"
        Me.txtuser.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtuser.PlaceholderText = "..."
        Me.txtuser.SelectedText = ""
        Me.txtuser.Size = New System.Drawing.Size(201, 30)
        Me.txtuser.TabIndex = 150
        '
        'dt_date
        '
        Me.dt_date.BorderRadius = 2
        Me.dt_date.Checked = True
        Me.dt_date.CustomFormat = "MMMM dd yyyy"
        Me.dt_date.FillColor = System.Drawing.SystemColors.Highlight
        Me.dt_date.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dt_date.ForeColor = System.Drawing.Color.White
        Me.dt_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dt_date.Location = New System.Drawing.Point(523, 43)
        Me.dt_date.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dt_date.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dt_date.Name = "dt_date"
        Me.dt_date.Size = New System.Drawing.Size(191, 36)
        Me.dt_date.TabIndex = 128
        Me.dt_date.Value = New Date(2024, 9, 23, 0, 0, 0, 0)
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.White
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(25, 16)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(209, 20)
        Me.Label17.TabIndex = 61
        Me.Label17.Text = "MASTERDATA DETAILS" & Global.Microsoft.VisualBasic.ChrW(9)
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1346, 36)
        Me.Panel1.TabIndex = 187
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label18.Location = New System.Drawing.Point(10, 1)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(203, 32)
        Me.Label18.TabIndex = 6
        Me.Label18.Text = "FIXED ASSET TAG"
        '
        'btn_cancel
        '
        Me.btn_cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_cancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_cancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_cancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_cancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_cancel.FillColor = System.Drawing.Color.Tomato
        Me.btn_cancel.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_cancel.ForeColor = System.Drawing.Color.White
        Me.btn_cancel.Location = New System.Drawing.Point(1142, 372)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(79, 37)
        Me.btn_cancel.TabIndex = 188
        Me.btn_cancel.Text = "CANCEL"
        '
        'btn_exit
        '
        Me.btn_exit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_exit.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_exit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_exit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_exit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_exit.FillColor = System.Drawing.Color.Tomato
        Me.btn_exit.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_exit.ForeColor = System.Drawing.Color.White
        Me.btn_exit.Location = New System.Drawing.Point(1236, 372)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(79, 37)
        Me.btn_exit.TabIndex = 189
        Me.btn_exit.Text = "EXIT"
        '
        'btnaddservice
        '
        Me.btnaddservice.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnaddservice.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnaddservice.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnaddservice.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnaddservice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnaddservice.FillColor = System.Drawing.Color.DodgerBlue
        Me.btnaddservice.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnaddservice.ForeColor = System.Drawing.Color.White
        Me.btnaddservice.Location = New System.Drawing.Point(957, 372)
        Me.btnaddservice.Name = "btnaddservice"
        Me.btnaddservice.Size = New System.Drawing.Size(79, 37)
        Me.btnaddservice.TabIndex = 190
        Me.btnaddservice.Text = "ADD SERVICES"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1346, 708)
        Me.Controls.Add(Me.btnaddservice)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.datagrid1)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.btn_save)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "                             "
        CType(Me.datagrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents datagrid1 As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents btn_delete As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_edit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_save As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txt_amount As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_itemdes As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_sino As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_pono As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_fano As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_no As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cb_section As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cb_supplier As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cb_fatype As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents txt_amount1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label17 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label18 As Label
    Friend WithEvents dt_date As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents dt_podate As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents dt_accomdate As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents txt_sino1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btn_cancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_exit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label19 As Label
    Friend WithEvents txtuser As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cb_servicepro As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents btnaddservice As Guna.UI2.WinForms.Guna2Button
End Class
