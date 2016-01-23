<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTransfer
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTransfer))
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtBarcode = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnComfirm = New System.Windows.Forms.Button
        Me.PictureReserve = New System.Windows.Forms.PictureBox
        Me.ddlFloor = New System.Windows.Forms.ComboBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnMobileDevice = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnReadRFID = New System.Windows.Forms.Button
        Me.gdvDataBook = New System.Windows.Forms.DataGridView
        Me.ddlRoom = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.ddlCabinet = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.PanelLocation = New System.Windows.Forms.Panel
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Floor = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Room = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Cabinet = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.PictureReserve, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.gdvDataBook, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelLocation.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(58, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 37)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Barcode"
        '
        'txtBarcode
        '
        Me.txtBarcode.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBarcode.Location = New System.Drawing.Point(199, 40)
        Me.txtBarcode.MaxLength = 20
        Me.txtBarcode.Name = "txtBarcode"
        Me.txtBarcode.Size = New System.Drawing.Size(200, 25)
        Me.txtBarcode.TabIndex = 0
        Me.txtBarcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 37)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Floor"
        '
        'btnComfirm
        '
        Me.btnComfirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnComfirm.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnComfirm.Location = New System.Drawing.Point(308, 454)
        Me.btnComfirm.Name = "btnComfirm"
        Me.btnComfirm.Size = New System.Drawing.Size(153, 40)
        Me.btnComfirm.TabIndex = 43
        Me.btnComfirm.UseVisualStyleBackColor = True
        '
        'PictureReserve
        '
        Me.PictureReserve.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureReserve.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureReserve.Location = New System.Drawing.Point(0, 0)
        Me.PictureReserve.Name = "PictureReserve"
        Me.PictureReserve.Size = New System.Drawing.Size(1164, 624)
        Me.PictureReserve.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureReserve.TabIndex = 47
        Me.PictureReserve.TabStop = False
        '
        'ddlFloor
        '
        Me.ddlFloor.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.ddlFloor.FormattingEnabled = True
        Me.ddlFloor.Location = New System.Drawing.Point(161, 108)
        Me.ddlFloor.Name = "ddlFloor"
        Me.ddlFloor.Size = New System.Drawing.Size(217, 25)
        Me.ddlFloor.TabIndex = 49
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnMobileDevice)
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Controls.Add(Me.btnReadRFID)
        Me.Panel1.Controls.Add(Me.gdvDataBook)
        Me.Panel1.Location = New System.Drawing.Point(65, 92)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(610, 345)
        Me.Panel1.TabIndex = 50
        '
        'btnMobileDevice
        '
        Me.btnMobileDevice.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMobileDevice.BackColor = System.Drawing.SystemColors.Control
        Me.btnMobileDevice.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMobileDevice.Font = New System.Drawing.Font("Browallia New", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMobileDevice.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnMobileDevice.Location = New System.Drawing.Point(397, 67)
        Me.btnMobileDevice.Name = "btnMobileDevice"
        Me.btnMobileDevice.Size = New System.Drawing.Size(151, 67)
        Me.btnMobileDevice.TabIndex = 90
        Me.btnMobileDevice.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnCancel.Location = New System.Drawing.Point(383, 248)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(189, 51)
        Me.btnCancel.TabIndex = 49
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnReadRFID
        '
        Me.btnReadRFID.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnReadRFID.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnReadRFID.Location = New System.Drawing.Point(371, 170)
        Me.btnReadRFID.Name = "btnReadRFID"
        Me.btnReadRFID.Size = New System.Drawing.Size(207, 51)
        Me.btnReadRFID.TabIndex = 48
        Me.btnReadRFID.UseVisualStyleBackColor = True
        '
        'gdvDataBook
        '
        Me.gdvDataBook.AllowUserToAddRows = False
        Me.gdvDataBook.AllowUserToDeleteRows = False
        Me.gdvDataBook.AllowUserToResizeColumns = False
        Me.gdvDataBook.AllowUserToResizeRows = False
        Me.gdvDataBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.gdvDataBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gdvDataBook.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column6, Me.Column7, Me.Floor, Me.Room, Me.Cabinet})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gdvDataBook.DefaultCellStyle = DataGridViewCellStyle1
        Me.gdvDataBook.Location = New System.Drawing.Point(39, 32)
        Me.gdvDataBook.MultiSelect = False
        Me.gdvDataBook.Name = "gdvDataBook"
        Me.gdvDataBook.ReadOnly = True
        Me.gdvDataBook.RowHeadersVisible = False
        Me.gdvDataBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gdvDataBook.Size = New System.Drawing.Size(288, 280)
        Me.gdvDataBook.TabIndex = 47
        '
        'ddlRoom
        '
        Me.ddlRoom.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.ddlRoom.FormattingEnabled = True
        Me.ddlRoom.Location = New System.Drawing.Point(161, 170)
        Me.ddlRoom.Name = "ddlRoom"
        Me.ddlRoom.Size = New System.Drawing.Size(217, 25)
        Me.ddlRoom.TabIndex = 52
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 159)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 37)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "Room"
        '
        'ddlCabinet
        '
        Me.ddlCabinet.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.ddlCabinet.FormattingEnabled = True
        Me.ddlCabinet.Location = New System.Drawing.Point(161, 232)
        Me.ddlCabinet.Name = "ddlCabinet"
        Me.ddlCabinet.Size = New System.Drawing.Size(217, 25)
        Me.ddlCabinet.TabIndex = 54
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 221)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 37)
        Me.Label4.TabIndex = 53
        Me.Label4.Text = "Cabinet"
        '
        'PanelLocation
        '
        Me.PanelLocation.Controls.Add(Me.Label1)
        Me.PanelLocation.Controls.Add(Me.ddlCabinet)
        Me.PanelLocation.Controls.Add(Me.ddlFloor)
        Me.PanelLocation.Controls.Add(Me.Label4)
        Me.PanelLocation.Controls.Add(Me.Label3)
        Me.PanelLocation.Controls.Add(Me.ddlRoom)
        Me.PanelLocation.Location = New System.Drawing.Point(732, 92)
        Me.PanelLocation.Name = "PanelLocation"
        Me.PanelLocation.Size = New System.Drawing.Size(390, 345)
        Me.PanelLocation.TabIndex = 55
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "seq"
        Me.Column6.HeaderText = "No."
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column6.Width = 30
        '
        'Column7
        '
        Me.Column7.DataPropertyName = "tag_id"
        Me.Column7.HeaderText = "Our Ref."
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column7.Width = 53
        '
        'Floor
        '
        Me.Floor.DataPropertyName = "floor_name"
        Me.Floor.HeaderText = "Floor"
        Me.Floor.Name = "Floor"
        Me.Floor.ReadOnly = True
        Me.Floor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Floor.Width = 36
        '
        'Room
        '
        Me.Room.DataPropertyName = "room_name"
        Me.Room.HeaderText = "Room"
        Me.Room.Name = "Room"
        Me.Room.ReadOnly = True
        Me.Room.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Room.Width = 41
        '
        'Cabinet
        '
        Me.Cabinet.DataPropertyName = "cabinet_name"
        Me.Cabinet.HeaderText = "Cabinet"
        Me.Cabinet.Name = "Cabinet"
        Me.Cabinet.ReadOnly = True
        Me.Cabinet.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Cabinet.Width = 49
        '
        'frmTransfer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.DIP.My.Resources.Resources.bg
        Me.ClientSize = New System.Drawing.Size(1164, 624)
        Me.Controls.Add(Me.PanelLocation)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnComfirm)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtBarcode)
        Me.Controls.Add(Me.PictureReserve)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmTransfer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ย้ายสิทธิบัตร"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureReserve, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.gdvDataBook, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelLocation.ResumeLayout(False)
        Me.PanelLocation.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtBarcode As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnComfirm As System.Windows.Forms.Button
    Friend WithEvents PictureReserve As System.Windows.Forms.PictureBox
    Friend WithEvents ddlFloor As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnReadRFID As System.Windows.Forms.Button
    Friend WithEvents gdvDataBook As System.Windows.Forms.DataGridView
    Friend WithEvents ddlRoom As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ddlCabinet As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PanelLocation As System.Windows.Forms.Panel
    Friend WithEvents btnMobileDevice As System.Windows.Forms.Button
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Floor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Room As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cabinet As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
