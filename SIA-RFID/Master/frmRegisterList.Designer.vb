<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegisterList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRegisterList))
        Me.GridData = New System.Windows.Forms.DataGridView
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Template = New System.Windows.Forms.Button
        Me.imgIcon = New System.Windows.Forms.PictureBox
        Me.btnUpload = New System.Windows.Forms.Button
        Me.txtFile = New System.Windows.Forms.TextBox
        Me.btnImport = New System.Windows.Forms.Button
        Me.txtID = New System.Windows.Forms.TextBox
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnSearch = New System.Windows.Forms.Button
        Me.cbStatus = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtAppName = New System.Windows.Forms.TextBox
        Me.cbCabinet = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.cbAppType = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.cbRoom = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.cbFloor = New System.Windows.Forms.ComboBox
        Me.txtAppNo = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnAdd = New System.Windows.Forms.Button
        Me.btnClear = New System.Windows.Forms.Button
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.App_No = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.App_Name = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.patent_type_name = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.app_order = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.app_ref = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.filingNo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.filingdate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Floor_Name = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.room_name = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Cabinet_name = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.app_Status = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.floor_id = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.room_id = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cabinet_id = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.patent_type_id = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.GridData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.imgIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridData
        '
        Me.GridData.AllowUserToAddRows = False
        Me.GridData.AllowUserToDeleteRows = False
        Me.GridData.AllowUserToOrderColumns = True
        Me.GridData.AllowUserToResizeColumns = False
        Me.GridData.AllowUserToResizeRows = False
        Me.GridData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.App_No, Me.App_Name, Me.patent_type_name, Me.app_order, Me.app_ref, Me.filingNo, Me.filingdate, Me.Floor_Name, Me.room_name, Me.Cabinet_name, Me.app_Status, Me.id, Me.floor_id, Me.room_id, Me.cabinet_id, Me.patent_type_id})
        Me.GridData.Location = New System.Drawing.Point(12, 210)
        Me.GridData.MultiSelect = False
        Me.GridData.Name = "GridData"
        Me.GridData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridData.Size = New System.Drawing.Size(819, 304)
        Me.GridData.TabIndex = 11
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Template)
        Me.Panel1.Controls.Add(Me.imgIcon)
        Me.Panel1.Controls.Add(Me.btnUpload)
        Me.Panel1.Controls.Add(Me.txtFile)
        Me.Panel1.Controls.Add(Me.btnImport)
        Me.Panel1.Controls.Add(Me.txtID)
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Controls.Add(Me.btnDelete)
        Me.Panel1.Controls.Add(Me.btnSearch)
        Me.Panel1.Controls.Add(Me.cbStatus)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txtAppName)
        Me.Panel1.Controls.Add(Me.cbCabinet)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.cbAppType)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.cbRoom)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.cbFloor)
        Me.Panel1.Controls.Add(Me.txtAppNo)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnAdd)
        Me.Panel1.Controls.Add(Me.btnClear)
        Me.Panel1.Location = New System.Drawing.Point(12, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(819, 201)
        Me.Panel1.TabIndex = 12
        '
        'Template
        '
        Me.Template.Location = New System.Drawing.Point(735, 148)
        Me.Template.Name = "Template"
        Me.Template.Size = New System.Drawing.Size(66, 43)
        Me.Template.TabIndex = 40
        Me.Template.Text = "Template"
        Me.Template.UseVisualStyleBackColor = True
        '
        'imgIcon
        '
        Me.imgIcon.Image = Global.DIP.My.Resources.Resources.Excel16
        Me.imgIcon.Location = New System.Drawing.Point(555, 156)
        Me.imgIcon.Name = "imgIcon"
        Me.imgIcon.Size = New System.Drawing.Size(28, 24)
        Me.imgIcon.TabIndex = 39
        Me.imgIcon.TabStop = False
        Me.imgIcon.Visible = False
        '
        'btnUpload
        '
        Me.btnUpload.Enabled = False
        Me.btnUpload.Location = New System.Drawing.Point(662, 148)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(67, 43)
        Me.btnUpload.TabIndex = 38
        Me.btnUpload.Text = "Upload"
        Me.btnUpload.UseVisualStyleBackColor = True
        '
        'txtFile
        '
        Me.txtFile.Enabled = False
        Me.txtFile.Location = New System.Drawing.Point(706, 106)
        Me.txtFile.Multiline = True
        Me.txtFile.Name = "txtFile"
        Me.txtFile.Size = New System.Drawing.Size(95, 30)
        Me.txtFile.TabIndex = 37
        Me.txtFile.Visible = False
        '
        'btnImport
        '
        Me.btnImport.Location = New System.Drawing.Point(589, 148)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(67, 43)
        Me.btnImport.TabIndex = 36
        Me.btnImport.Text = "Import File"
        Me.btnImport.UseVisualStyleBackColor = True
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(32, 160)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(56, 20)
        Me.txtID.TabIndex = 35
        Me.txtID.Visible = False
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnCancel.Enabled = False
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(355, 155)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 27)
        Me.btnCancel.TabIndex = 34
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnDelete.Enabled = False
        Me.btnDelete.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(438, 155)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 27)
        Me.btnDelete.TabIndex = 33
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(186, 155)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 27)
        Me.btnSearch.TabIndex = 32
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'cbStatus
        '
        Me.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbStatus.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.cbStatus.FormattingEnabled = True
        Me.cbStatus.Location = New System.Drawing.Point(463, 54)
        Me.cbStatus.Name = "cbStatus"
        Me.cbStatus.Size = New System.Drawing.Size(221, 25)
        Me.cbStatus.TabIndex = 31
        Me.cbStatus.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(414, 57)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 17)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Status"
        Me.Label7.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(395, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 17)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Applicant"
        '
        'txtAppName
        '
        Me.txtAppName.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAppName.Location = New System.Drawing.Point(463, 23)
        Me.txtAppName.Name = "txtAppName"
        Me.txtAppName.Size = New System.Drawing.Size(221, 25)
        Me.txtAppName.TabIndex = 28
        '
        'cbCabinet
        '
        Me.cbCabinet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCabinet.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.cbCabinet.FormattingEnabled = True
        Me.cbCabinet.Location = New System.Drawing.Point(118, 110)
        Me.cbCabinet.Name = "cbCabinet"
        Me.cbCabinet.Size = New System.Drawing.Size(218, 25)
        Me.cbCabinet.TabIndex = 27
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(7, 54)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 17)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Application Type"
        '
        'cbAppType
        '
        Me.cbAppType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbAppType.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.cbAppType.FormattingEnabled = True
        Me.cbAppType.Location = New System.Drawing.Point(118, 49)
        Me.cbAppType.Name = "cbAppType"
        Me.cbAppType.Size = New System.Drawing.Size(218, 25)
        Me.cbAppType.TabIndex = 25
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(56, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 17)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Our Ref."
        '
        'cbRoom
        '
        Me.cbRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbRoom.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.cbRoom.FormattingEnabled = True
        Me.cbRoom.Location = New System.Drawing.Point(463, 85)
        Me.cbRoom.Name = "cbRoom"
        Me.cbRoom.Size = New System.Drawing.Size(221, 25)
        Me.cbRoom.TabIndex = 23
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(60, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 17)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Cabinet"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(414, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 17)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Room"
        '
        'cbFloor
        '
        Me.cbFloor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFloor.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.cbFloor.FormattingEnabled = True
        Me.cbFloor.Location = New System.Drawing.Point(118, 80)
        Me.cbFloor.Name = "cbFloor"
        Me.cbFloor.Size = New System.Drawing.Size(218, 25)
        Me.cbFloor.TabIndex = 19
        '
        'txtAppNo
        '
        Me.txtAppNo.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAppNo.Location = New System.Drawing.Point(118, 18)
        Me.txtAppNo.Name = "txtAppNo"
        Me.txtAppNo.Size = New System.Drawing.Size(218, 25)
        Me.txtAppNo.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(74, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 17)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Floor"
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(105, 155)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 27)
        Me.btnAdd.TabIndex = 15
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(267, 155)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 27)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'App_No
        '
        Me.App_No.DataPropertyName = "App_No"
        Me.App_No.HeaderText = "Our Ref."
        Me.App_No.Name = "App_No"
        '
        'App_Name
        '
        Me.App_Name.DataPropertyName = "App_Name"
        Me.App_Name.HeaderText = "Applicant"
        Me.App_Name.Name = "App_Name"
        Me.App_Name.Width = 250
        '
        'patent_type_name
        '
        Me.patent_type_name.DataPropertyName = "patent_type_name"
        Me.patent_type_name.HeaderText = "Application Type"
        Me.patent_type_name.Name = "patent_type_name"
        '
        'app_order
        '
        Me.app_order.DataPropertyName = "app_order"
        Me.app_order.HeaderText = "Order"
        Me.app_order.Name = "app_order"
        '
        'app_ref
        '
        Me.app_ref.DataPropertyName = "app_ref"
        Me.app_ref.HeaderText = "Your Ref No."
        Me.app_ref.Name = "app_ref"
        '
        'filingNo
        '
        Me.filingNo.DataPropertyName = "filingNo"
        Me.filingNo.HeaderText = "Filing No"
        Me.filingNo.Name = "filingNo"
        '
        'filingdate
        '
        Me.filingdate.DataPropertyName = "filingdate"
        Me.filingdate.HeaderText = "Filing Date"
        Me.filingdate.Name = "filingdate"
        '
        'Floor_Name
        '
        Me.Floor_Name.DataPropertyName = "Floor_Name"
        Me.Floor_Name.HeaderText = "Floor"
        Me.Floor_Name.Name = "Floor_Name"
        '
        'room_name
        '
        Me.room_name.DataPropertyName = "room_name"
        Me.room_name.HeaderText = "Room"
        Me.room_name.Name = "room_name"
        '
        'Cabinet_name
        '
        Me.Cabinet_name.DataPropertyName = "Cabinet_name"
        Me.Cabinet_name.HeaderText = "Cabinet"
        Me.Cabinet_name.Name = "Cabinet_name"
        '
        'app_Status
        '
        Me.app_Status.DataPropertyName = "app_Status"
        Me.app_Status.HeaderText = "Status"
        Me.app_Status.Name = "app_Status"
        '
        'id
        '
        Me.id.DataPropertyName = "id"
        Me.id.HeaderText = "id"
        Me.id.Name = "id"
        Me.id.Visible = False
        '
        'floor_id
        '
        Me.floor_id.DataPropertyName = "floor_id"
        Me.floor_id.HeaderText = "floor_id"
        Me.floor_id.Name = "floor_id"
        Me.floor_id.Visible = False
        '
        'room_id
        '
        Me.room_id.DataPropertyName = "room_id"
        Me.room_id.HeaderText = "room_id"
        Me.room_id.Name = "room_id"
        Me.room_id.Visible = False
        '
        'cabinet_id
        '
        Me.cabinet_id.DataPropertyName = "cabinet_id"
        Me.cabinet_id.HeaderText = "cabinet_id"
        Me.cabinet_id.Name = "cabinet_id"
        Me.cabinet_id.Visible = False
        '
        'patent_type_id
        '
        Me.patent_type_id.DataPropertyName = "patent_type_id"
        Me.patent_type_id.HeaderText = "patent_type_id"
        Me.patent_type_id.Name = "patent_type_id"
        Me.patent_type_id.Visible = False
        '
        'frmRegisterList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(843, 514)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GridData)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRegisterList"
        Me.Text = "RegisterList"
        CType(Me.GridData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.imgIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridData As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents cbStatus As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtAppName As System.Windows.Forms.TextBox
    Friend WithEvents cbCabinet As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cbAppType As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbRoom As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbFloor As System.Windows.Forms.ComboBox
    Friend WithEvents txtAppNo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnImport As System.Windows.Forms.Button
    Friend WithEvents txtFile As System.Windows.Forms.TextBox
    Friend WithEvents btnUpload As System.Windows.Forms.Button
    Friend WithEvents imgIcon As System.Windows.Forms.PictureBox
    Friend WithEvents Template As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents App_No As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents App_Name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents patent_type_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents app_order As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents app_ref As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents filingNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents filingdate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Floor_Name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents room_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cabinet_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents app_Status As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents floor_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents room_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cabinet_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents patent_type_id As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
