<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReturns
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
        Me.components = New System.ComponentModel.Container
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReturns))
        Me.btnPrint = New System.Windows.Forms.Button
        Me.PictureReserve = New System.Windows.Forms.PictureBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtBarcode = New System.Windows.Forms.TextBox
        Me.btnConfirm = New System.Windows.Forms.Button
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnMobileDevice = New System.Windows.Forms.Button
        Me.gdvError = New System.Windows.Forms.DataGridView
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label8 = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblB_txt2 = New System.Windows.Forms.Label
        Me.lblE_txt2 = New System.Windows.Forms.Label
        Me.lblB_count = New System.Windows.Forms.Label
        Me.lblE_txt1 = New System.Windows.Forms.Label
        Me.lblB_txt1 = New System.Windows.Forms.Label
        Me.lblE_count = New System.Windows.Forms.Label
        Me.gdvBook = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.btnReadRFID = New System.Windows.Forms.Button
        Me.lblR_txt2 = New System.Windows.Forms.Label
        Me.btnCancel = New System.Windows.Forms.Button
        Me.gdvReturns = New System.Windows.Forms.DataGridView
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.APP_NO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.borrow_date = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ReadBy = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColReserve = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.ItemID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.REF_INNOVA_ID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.lblR_count = New System.Windows.Forms.Label
        Me.lblR_txt1 = New System.Windows.Forms.Label
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Read = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        CType(Me.PictureReserve, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.gdvError, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.gdvBook, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdvReturns, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnPrint
        '
        Me.btnPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrint.BackColor = System.Drawing.SystemColors.Control
        Me.btnPrint.Enabled = False
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPrint.Font = New System.Drawing.Font("Browallia New", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnPrint.Location = New System.Drawing.Point(1064, 337)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(188, 50)
        Me.btnPrint.TabIndex = 20
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'PictureReserve
        '
        Me.PictureReserve.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureReserve.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureReserve.Location = New System.Drawing.Point(0, 0)
        Me.PictureReserve.Name = "PictureReserve"
        Me.PictureReserve.Size = New System.Drawing.Size(1276, 662)
        Me.PictureReserve.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureReserve.TabIndex = 23
        Me.PictureReserve.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Label6.Font = New System.Drawing.Font("Browallia New", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(93, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(133, 46)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "BARCODE"
        '
        'txtBarcode
        '
        Me.txtBarcode.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBarcode.Location = New System.Drawing.Point(234, 29)
        Me.txtBarcode.Name = "txtBarcode"
        Me.txtBarcode.Size = New System.Drawing.Size(226, 25)
        Me.txtBarcode.TabIndex = 33
        Me.txtBarcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnConfirm
        '
        Me.btnConfirm.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnConfirm.BackColor = System.Drawing.SystemColors.Control
        Me.btnConfirm.Enabled = False
        Me.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnConfirm.Font = New System.Drawing.Font("Browallia New", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirm.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnConfirm.Location = New System.Drawing.Point(1064, 281)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(188, 50)
        Me.btnConfirm.TabIndex = 36
        Me.btnConfirm.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnMobileDevice)
        Me.Panel1.Controls.Add(Me.gdvError)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.lblB_txt2)
        Me.Panel1.Controls.Add(Me.lblE_txt2)
        Me.Panel1.Controls.Add(Me.lblB_count)
        Me.Panel1.Controls.Add(Me.lblE_txt1)
        Me.Panel1.Controls.Add(Me.lblB_txt1)
        Me.Panel1.Controls.Add(Me.lblE_count)
        Me.Panel1.Controls.Add(Me.gdvBook)
        Me.Panel1.Controls.Add(Me.btnReadRFID)
        Me.Panel1.Controls.Add(Me.lblR_txt2)
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Controls.Add(Me.gdvReturns)
        Me.Panel1.Controls.Add(Me.lblR_count)
        Me.Panel1.Controls.Add(Me.lblR_txt1)
        Me.Panel1.Location = New System.Drawing.Point(54, 77)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(923, 488)
        Me.Panel1.TabIndex = 37
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Browallia New", 22.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(635, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(193, 39)
        Me.Label1.TabIndex = 90
        Me.Label1.Text = "Not Check Out List"
        '
        'btnMobileDevice
        '
        Me.btnMobileDevice.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMobileDevice.BackColor = System.Drawing.SystemColors.Control
        Me.btnMobileDevice.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMobileDevice.Font = New System.Drawing.Font("Browallia New", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMobileDevice.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnMobileDevice.Location = New System.Drawing.Point(313, 395)
        Me.btnMobileDevice.Name = "btnMobileDevice"
        Me.btnMobileDevice.Size = New System.Drawing.Size(151, 67)
        Me.btnMobileDevice.TabIndex = 89
        Me.btnMobileDevice.UseVisualStyleBackColor = False
        '
        'gdvError
        '
        Me.gdvError.AllowUserToAddRows = False
        Me.gdvError.AllowUserToDeleteRows = False
        Me.gdvError.AllowUserToResizeRows = False
        Me.gdvError.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gdvError.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.gdvError.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gdvError.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.Read, Me.DataGridViewCheckBoxColumn1})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gdvError.DefaultCellStyle = DataGridViewCellStyle3
        Me.gdvError.Location = New System.Drawing.Point(635, 83)
        Me.gdvError.MultiSelect = False
        Me.gdvError.Name = "gdvError"
        Me.gdvError.ReadOnly = True
        Me.gdvError.RowHeadersVisible = False
        Me.gdvError.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gdvError.Size = New System.Drawing.Size(257, 282)
        Me.gdvError.TabIndex = 84
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Panel4)
        Me.Panel5.Controls.Add(Me.Label8)
        Me.Panel5.Controls.Add(Me.Panel3)
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Location = New System.Drawing.Point(50, 264)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(0, 0)
        Me.Panel5.TabIndex = 85
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel4.Location = New System.Drawing.Point(26, -57)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(24, 24)
        Me.Panel4.TabIndex = 34
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(79, -57)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(107, 17)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "รายการอ่านโดย RFID"
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.PaleGreen
        Me.Panel3.Location = New System.Drawing.Point(26, -27)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(24, 24)
        Me.Panel3.TabIndex = 33
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(79, -20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 17)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "รายการที่อ่านโดย Barcode"
        '
        'lblB_txt2
        '
        Me.lblB_txt2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblB_txt2.AutoSize = True
        Me.lblB_txt2.BackColor = System.Drawing.Color.Transparent
        Me.lblB_txt2.Location = New System.Drawing.Point(413, 56)
        Me.lblB_txt2.Name = "lblB_txt2"
        Me.lblB_txt2.Size = New System.Drawing.Size(27, 13)
        Me.lblB_txt2.TabIndex = 84
        Me.lblB_txt2.Text = "Item"
        Me.lblB_txt2.Visible = False
        '
        'lblE_txt2
        '
        Me.lblE_txt2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblE_txt2.AutoSize = True
        Me.lblE_txt2.BackColor = System.Drawing.Color.Transparent
        Me.lblE_txt2.Location = New System.Drawing.Point(707, 57)
        Me.lblE_txt2.Name = "lblE_txt2"
        Me.lblE_txt2.Size = New System.Drawing.Size(27, 13)
        Me.lblE_txt2.TabIndex = 88
        Me.lblE_txt2.Text = "Item"
        Me.lblE_txt2.Visible = False
        '
        'lblB_count
        '
        Me.lblB_count.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblB_count.BackColor = System.Drawing.Color.Transparent
        Me.lblB_count.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblB_count.Location = New System.Drawing.Point(371, 55)
        Me.lblB_count.Name = "lblB_count"
        Me.lblB_count.Size = New System.Drawing.Size(36, 17)
        Me.lblB_count.TabIndex = 83
        Me.lblB_count.Text = "0"
        Me.lblB_count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblB_count.Visible = False
        '
        'lblE_txt1
        '
        Me.lblE_txt1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblE_txt1.AutoSize = True
        Me.lblE_txt1.BackColor = System.Drawing.Color.Transparent
        Me.lblE_txt1.Location = New System.Drawing.Point(639, 57)
        Me.lblE_txt1.Name = "lblE_txt1"
        Me.lblE_txt1.Size = New System.Drawing.Size(31, 13)
        Me.lblE_txt1.TabIndex = 86
        Me.lblE_txt1.Text = "Total"
        Me.lblE_txt1.Visible = False
        '
        'lblB_txt1
        '
        Me.lblB_txt1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblB_txt1.AutoSize = True
        Me.lblB_txt1.BackColor = System.Drawing.Color.Transparent
        Me.lblB_txt1.Location = New System.Drawing.Point(334, 56)
        Me.lblB_txt1.Name = "lblB_txt1"
        Me.lblB_txt1.Size = New System.Drawing.Size(31, 13)
        Me.lblB_txt1.TabIndex = 82
        Me.lblB_txt1.Text = "Total"
        Me.lblB_txt1.Visible = False
        '
        'lblE_count
        '
        Me.lblE_count.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblE_count.BackColor = System.Drawing.Color.Transparent
        Me.lblE_count.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblE_count.Location = New System.Drawing.Point(674, 54)
        Me.lblE_count.Name = "lblE_count"
        Me.lblE_count.Size = New System.Drawing.Size(36, 17)
        Me.lblE_count.TabIndex = 87
        Me.lblE_count.Text = "0"
        Me.lblE_count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblE_count.Visible = False
        '
        'gdvBook
        '
        Me.gdvBook.AllowUserToAddRows = False
        Me.gdvBook.AllowUserToDeleteRows = False
        Me.gdvBook.AllowUserToResizeRows = False
        Me.gdvBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gdvBook.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.gdvBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gdvBook.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewCheckBoxColumn2})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gdvBook.DefaultCellStyle = DataGridViewCellStyle6
        Me.gdvBook.Location = New System.Drawing.Point(337, 83)
        Me.gdvBook.MultiSelect = False
        Me.gdvBook.Name = "gdvBook"
        Me.gdvBook.ReadOnly = True
        Me.gdvBook.RowHeadersVisible = False
        Me.gdvBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gdvBook.Size = New System.Drawing.Size(253, 282)
        Me.gdvBook.TabIndex = 71
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "No"
        Me.DataGridViewTextBoxColumn5.HeaderText = "No."
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn5.Width = 30
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "APP_NO"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Our Ref."
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn6.Width = 48
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "member_name"
        Me.DataGridViewTextBoxColumn7.HeaderText = "User Name"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn7.Width = 60
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "borrow_date"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Reserved Date"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn8.Width = 77
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "ReadBy"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Read"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn9.Visible = False
        Me.DataGridViewTextBoxColumn9.Width = 39
        '
        'DataGridViewCheckBoxColumn2
        '
        Me.DataGridViewCheckBoxColumn2.DataPropertyName = "Reserve"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.NullValue = False
        Me.DataGridViewCheckBoxColumn2.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewCheckBoxColumn2.HeaderText = "Reserved"
        Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
        Me.DataGridViewCheckBoxColumn2.ReadOnly = True
        Me.DataGridViewCheckBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewCheckBoxColumn2.Width = 59
        '
        'btnReadRFID
        '
        Me.btnReadRFID.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnReadRFID.BackColor = System.Drawing.SystemColors.Control
        Me.btnReadRFID.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnReadRFID.Font = New System.Drawing.Font("Browallia New", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReadRFID.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnReadRFID.Location = New System.Drawing.Point(480, 402)
        Me.btnReadRFID.Name = "btnReadRFID"
        Me.btnReadRFID.Size = New System.Drawing.Size(198, 51)
        Me.btnReadRFID.TabIndex = 80
        Me.btnReadRFID.UseVisualStyleBackColor = False
        '
        'lblR_txt2
        '
        Me.lblR_txt2.AutoSize = True
        Me.lblR_txt2.BackColor = System.Drawing.Color.Transparent
        Me.lblR_txt2.Location = New System.Drawing.Point(120, 56)
        Me.lblR_txt2.Name = "lblR_txt2"
        Me.lblR_txt2.Size = New System.Drawing.Size(27, 13)
        Me.lblR_txt2.TabIndex = 75
        Me.lblR_txt2.Text = "Item"
        Me.lblR_txt2.Visible = False
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.BackColor = System.Drawing.SystemColors.Control
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCancel.Location = New System.Drawing.Point(695, 402)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(189, 51)
        Me.btnCancel.TabIndex = 83
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'gdvReturns
        '
        Me.gdvReturns.AllowUserToAddRows = False
        Me.gdvReturns.AllowUserToDeleteRows = False
        Me.gdvReturns.AllowUserToResizeRows = False
        Me.gdvReturns.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gdvReturns.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.gdvReturns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gdvReturns.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.APP_NO, Me.Column3, Me.borrow_date, Me.ReadBy, Me.ColReserve, Me.ItemID, Me.Column5, Me.Column6, Me.Column7, Me.REF_INNOVA_ID})
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gdvReturns.DefaultCellStyle = DataGridViewCellStyle9
        Me.gdvReturns.Location = New System.Drawing.Point(39, 83)
        Me.gdvReturns.MultiSelect = False
        Me.gdvReturns.Name = "gdvReturns"
        Me.gdvReturns.ReadOnly = True
        Me.gdvReturns.RowHeadersVisible = False
        Me.gdvReturns.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gdvReturns.Size = New System.Drawing.Size(255, 282)
        Me.gdvReturns.TabIndex = 65
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "No"
        Me.Column1.HeaderText = "No."
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column1.Width = 30
        '
        'APP_NO
        '
        Me.APP_NO.DataPropertyName = "APP_NO"
        Me.APP_NO.HeaderText = "Our Ref."
        Me.APP_NO.Name = "APP_NO"
        Me.APP_NO.ReadOnly = True
        Me.APP_NO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.APP_NO.Width = 48
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "member_name"
        Me.Column3.HeaderText = "User Name"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column3.Width = 60
        '
        'borrow_date
        '
        Me.borrow_date.DataPropertyName = "borrow_date"
        Me.borrow_date.HeaderText = "Reserved Date"
        Me.borrow_date.Name = "borrow_date"
        Me.borrow_date.ReadOnly = True
        Me.borrow_date.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.borrow_date.Width = 77
        '
        'ReadBy
        '
        Me.ReadBy.DataPropertyName = "ReadBy"
        Me.ReadBy.HeaderText = "ReadBy"
        Me.ReadBy.Name = "ReadBy"
        Me.ReadBy.ReadOnly = True
        Me.ReadBy.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ReadBy.Visible = False
        Me.ReadBy.Width = 51
        '
        'ColReserve
        '
        Me.ColReserve.DataPropertyName = "Reserve"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.NullValue = False
        Me.ColReserve.DefaultCellStyle = DataGridViewCellStyle8
        Me.ColReserve.HeaderText = "Reserved"
        Me.ColReserve.Name = "ColReserve"
        Me.ColReserve.ReadOnly = True
        Me.ColReserve.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColReserve.Width = 59
        '
        'ItemID
        '
        Me.ItemID.DataPropertyName = "ItemID"
        Me.ItemID.HeaderText = "ItemID"
        Me.ItemID.Name = "ItemID"
        Me.ItemID.ReadOnly = True
        Me.ItemID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ItemID.Visible = False
        Me.ItemID.Width = 44
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "staff"
        Me.Column5.HeaderText = "Column5"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column5.Visible = False
        Me.Column5.Width = 54
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "member_id"
        Me.Column6.HeaderText = "Column6"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column6.Visible = False
        Me.Column6.Width = 54
        '
        'Column7
        '
        Me.Column7.DataPropertyName = "Printdate"
        Me.Column7.HeaderText = "Column7"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column7.Visible = False
        Me.Column7.Width = 54
        '
        'REF_INNOVA_ID
        '
        Me.REF_INNOVA_ID.DataPropertyName = "REF_INNOVA_ID"
        Me.REF_INNOVA_ID.HeaderText = "REF_INNOVA_ID"
        Me.REF_INNOVA_ID.Name = "REF_INNOVA_ID"
        Me.REF_INNOVA_ID.ReadOnly = True
        Me.REF_INNOVA_ID.Visible = False
        Me.REF_INNOVA_ID.Width = 117
        '
        'lblR_count
        '
        Me.lblR_count.BackColor = System.Drawing.Color.Transparent
        Me.lblR_count.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblR_count.Location = New System.Drawing.Point(78, 53)
        Me.lblR_count.Name = "lblR_count"
        Me.lblR_count.Size = New System.Drawing.Size(36, 17)
        Me.lblR_count.TabIndex = 74
        Me.lblR_count.Text = "0"
        Me.lblR_count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblR_count.Visible = False
        '
        'lblR_txt1
        '
        Me.lblR_txt1.AutoSize = True
        Me.lblR_txt1.BackColor = System.Drawing.Color.Transparent
        Me.lblR_txt1.Location = New System.Drawing.Point(36, 56)
        Me.lblR_txt1.Name = "lblR_txt1"
        Me.lblR_txt1.Size = New System.Drawing.Size(31, 13)
        Me.lblR_txt1.TabIndex = 73
        Me.lblR_txt1.Text = "Total"
        Me.lblR_txt1.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "No"
        Me.DataGridViewTextBoxColumn1.HeaderText = "No."
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn1.Width = 30
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "APP_NO"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Our Ref."
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn2.Width = 53
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "member_name"
        Me.DataGridViewTextBoxColumn3.HeaderText = "User Name"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn3.Width = 66
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "borrow_date"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Reserved Date"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn4.Width = 77
        '
        'Read
        '
        Me.Read.DataPropertyName = "ReadBy"
        Me.Read.HeaderText = "Read"
        Me.Read.Name = "Read"
        Me.Read.ReadOnly = True
        Me.Read.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Read.Visible = False
        Me.Read.Width = 39
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "Reserve"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.NullValue = False
        Me.DataGridViewCheckBoxColumn1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Reserved"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.ReadOnly = True
        Me.DataGridViewCheckBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewCheckBoxColumn1.Width = 59
        '
        'frmReturns
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Menu
        Me.BackgroundImage = Global.DIP.My.Resources.Resources.bg
        Me.ClientSize = New System.Drawing.Size(1276, 662)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtBarcode)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PictureReserve)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmReturns"
        Me.Text = "Returns"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureReserve, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.gdvError, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.gdvBook, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdvReturns, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnPrint As System.Windows.Forms.Button

    Friend WithEvents PictureReserve As System.Windows.Forms.PictureBox

    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtBarcode As System.Windows.Forms.TextBox
    Friend WithEvents btnConfirm As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblB_txt2 As System.Windows.Forms.Label
    Friend WithEvents lblB_count As System.Windows.Forms.Label
    Friend WithEvents lblB_txt1 As System.Windows.Forms.Label
    Friend WithEvents gdvBook As System.Windows.Forms.DataGridView
    Friend WithEvents lblR_txt2 As System.Windows.Forms.Label
    Friend WithEvents gdvReturns As System.Windows.Forms.DataGridView
    Friend WithEvents lblR_count As System.Windows.Forms.Label
    Friend WithEvents lblR_txt1 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents gdvError As System.Windows.Forms.DataGridView
    Friend WithEvents lblE_txt2 As System.Windows.Forms.Label
    Friend WithEvents lblE_txt1 As System.Windows.Forms.Label
    Friend WithEvents lblE_count As System.Windows.Forms.Label
    Friend WithEvents btnReadRFID As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnMobileDevice As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn2 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents APP_NO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents borrow_date As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReadBy As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColReserve As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ItemID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents REF_INNOVA_ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Read As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
