﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmcabinet
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmcabinet))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.cbRoom = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.cbFloor = New System.Windows.Forms.ComboBox
        Me.txtCabinet = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtID = New System.Windows.Forms.TextBox
        Me.btnAdd = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.GridData = New System.Windows.Forms.DataGridView
        Me.Floor_Name = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.room_name = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Cabinet_name = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.room_id = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.floor_id = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btnDelete = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        CType(Me.GridData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnDelete)
        Me.Panel1.Controls.Add(Me.cbRoom)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.cbFloor)
        Me.Panel1.Controls.Add(Me.txtCabinet)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtID)
        Me.Panel1.Controls.Add(Me.btnAdd)
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Location = New System.Drawing.Point(11, 10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(506, 152)
        Me.Panel1.TabIndex = 7
        '
        'cbRoom
        '
        Me.cbRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbRoom.Enabled = False
        Me.cbRoom.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.cbRoom.FormattingEnabled = True
        Me.cbRoom.Location = New System.Drawing.Point(106, 40)
        Me.cbRoom.Name = "cbRoom"
        Me.cbRoom.Size = New System.Drawing.Size(318, 25)
        Me.cbRoom.TabIndex = 23
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(53, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 17)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Cabinet"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(61, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 17)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Room"
        '
        'cbFloor
        '
        Me.cbFloor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFloor.Enabled = False
        Me.cbFloor.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.cbFloor.FormattingEnabled = True
        Me.cbFloor.Location = New System.Drawing.Point(106, 9)
        Me.cbFloor.Name = "cbFloor"
        Me.cbFloor.Size = New System.Drawing.Size(318, 25)
        Me.cbFloor.TabIndex = 19
        '
        'txtCabinet
        '
        Me.txtCabinet.Enabled = False
        Me.txtCabinet.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCabinet.Location = New System.Drawing.Point(106, 71)
        Me.txtCabinet.Name = "txtCabinet"
        Me.txtCabinet.Size = New System.Drawing.Size(318, 25)
        Me.txtCabinet.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(66, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 17)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Floor"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(33, 114)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(56, 20)
        Me.txtID.TabIndex = 16
        Me.txtID.Visible = False
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(106, 114)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 27)
        Me.btnAdd.TabIndex = 15
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Enabled = False
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(268, 114)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 27)
        Me.btnCancel.TabIndex = 9
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Enabled = False
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(187, 114)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 27)
        Me.btnSave.TabIndex = 8
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'GridData
        '
        Me.GridData.AllowUserToAddRows = False
        Me.GridData.AllowUserToDeleteRows = False
        Me.GridData.AllowUserToOrderColumns = True
        Me.GridData.AllowUserToResizeColumns = False
        Me.GridData.AllowUserToResizeRows = False
        Me.GridData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Floor_Name, Me.room_name, Me.Cabinet_name, Me.room_id, Me.id, Me.floor_id})
        Me.GridData.Location = New System.Drawing.Point(11, 168)
        Me.GridData.MultiSelect = False
        Me.GridData.Name = "GridData"
        Me.GridData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridData.Size = New System.Drawing.Size(506, 252)
        Me.GridData.TabIndex = 8
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
        Me.room_name.Width = 250
        '
        'Cabinet_name
        '
        Me.Cabinet_name.DataPropertyName = "Cabinet_name"
        Me.Cabinet_name.HeaderText = "Cabinet"
        Me.Cabinet_name.Name = "Cabinet_name"
        '
        'room_id
        '
        Me.room_id.DataPropertyName = "room_id"
        Me.room_id.HeaderText = "room_id"
        Me.room_id.Name = "room_id"
        Me.room_id.Visible = False
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
        'btnDelete
        '
        Me.btnDelete.Enabled = False
        Me.btnDelete.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(349, 114)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 27)
        Me.btnDelete.TabIndex = 18
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'frmcabinet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(529, 432)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GridData)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmcabinet"
        Me.Text = "กำหนดตู้"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.GridData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbFloor As System.Windows.Forms.ComboBox
    Friend WithEvents txtCabinet As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents GridData As System.Windows.Forms.DataGridView
    Friend WithEvents cbRoom As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Floor_Name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents room_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cabinet_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents room_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents floor_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnDelete As System.Windows.Forms.Button
End Class