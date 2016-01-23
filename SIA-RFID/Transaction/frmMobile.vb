Option Explicit On


Imports System.Data
Imports System.Data.SqlClient
Imports DAL.Table
Imports Data.Table
Imports DAL.Common.Utilities
Imports OpenNETCF.Desktop.Communication
Imports System.IO
Imports System.Threading
Imports System.Text


Public Class frmMobile

    Public Enum TASK_TYPE
        Import = 1
        Export = 2
    End Enum

    Public Enum FIND_STATUS
        NotFound = 0
        Found = 1
        Post = 2
    End Enum

    Public Property SyncFor() As TASK_TYPE
        Get
            Select Case True
                Case RadioTask1.Checked
                    Return TASK_TYPE.Export
                Case RadioTask2.Checked
                    Return TASK_TYPE.Import
            End Select
        End Get
        Set(ByVal value As TASK_TYPE)
            Select Case value
                Case TASK_TYPE.Export
                    RadioTask1.Checked = True
                Case TASK_TYPE.Import
                    RadioTask2.Checked = True
            End Select
        End Set
    End Property

    Public ReadOnly Property DeviceName() As String
        Get
            Return Trim(ddlMobileList.Text)
        End Get
    End Property

    ''Public ReadOnly Property TaskState() As TASK_MODE
    ''    Get
    ''        Select Case True
    ''            Case Equals(TabExportOnline, TabMain.SelectedTab)
    ''                Return TASK_MODE.ExportOnline
    ''            Case Equals(TabExportOffline, TabMain.SelectedTab)
    ''                Return TASK_MODE.ExportOffline
    ''            Case Equals(TabImportOnline, TabMain.SelectedTab)
    ''                Return TASK_MODE.ImportOnline
    ''            Case Equals(TabImportOffline, TabMain.SelectedTab)
    ''                Return TASK_MODE.ImportOffline
    ''            Case Equals(TabSelection, TabMain.SelectedTab)
    ''                Return TASK_MODE.Selection
    ''            Case Else
    ''                Return TASK_MODE.None
    ''        End Select
    ''    End Get
    ''End Property

    Private Sub ButtonClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonClose.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Dispose()
    End Sub

    Private Sub frmMobile_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'RadioTask1.Checked = True
        'Hide Tab Interface
        TabMain.Top = -22
        Me.Height = 385

        'Clear Form
        ResetForm()

    End Sub

    Private Sub ResetForm()

        'Get Device_Name
        'ddlMobileList.Items.Clear()
        'Dim Devices() As String = GetDeviceNames()
        'For i = 0 To Devices.Length - 1
        '    ddlMobileList.Items.Add(Devices(i))
        'Next
        ddlMobileList.SelectedIndex = 0

    End Sub


    Public ExportList As DataTable

    Private Function GenerateExportList() As DataTable

        If Not IsNothing(ExportList) Then

            ExportList.TableName = "Export"
            Return ExportList
        Else
            Dim DT As New DataTable
            DT.Columns.Add("APP_NO") '------------���� Patent----------
            DT.Columns.Add("APP_NAME") '--------------���� Patent---------
            DT.Columns.Add("APP_POSITION") '-------------���˹觷����-------------
            DT.Columns.Add("LOAD_DATETIME") '----------���ҷ�� Load ��� -----------
            DT.Columns.Add("FIND_STATUS") '0 = Not found , 1 = Found , 2 = Post
            '---------Additional From Joining  Table---------

            DT.TableName = "Export"
            Return DT
        End If
    End Function

    Private Function GetDeviceNames() As String() 'Get List Of Device Name Array-------------------------------
        Dim Temp As String = ""
        Dim i As Integer

        ' Dim F As FileIO
        Dim MyDocPath As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        Dim IndexOfLastBackSlash As Integer = InStrRev(FileIO.FileSystem.GetDirectories(MyDocPath).Item(0), "\")
        For i = 0 To FileIO.FileSystem.GetDirectories(MyDocPath).Count - 1
            Dim TempFolderName As String = FileIO.FileSystem.GetDirectories(MyDocPath).Item(i)
            '"My Documents"
            TempFolderName = Mid(TempFolderName, IndexOfLastBackSlash + 1)
            If InStr(TempFolderName, "My Documents") > 0 Then
                ' Shift Another One Element Dimention
                Temp &= Trim(Mid(TempFolderName, 1, InStr(TempFolderName, "My Documents") - 1) & "\")
            ElseIf InStr(TempFolderName, "Documents on ") = 1 And InStr(TempFolderName, "'s Device") > 0 Then
                'Documents on xXx's Device
                Dim _tmp As String = TempFolderName.Replace("Documents on ", "")
                _tmp = _tmp.Substring(0, Len(_tmp) - Len("'s Device"))
                Temp &= Trim(_tmp) & "\"
            End If
        Next

        If Len(Temp) > 0 Then Temp = Mid(Temp, 1, Len(Temp) - 1)

        'Optimize New Returned Array
        GetDeviceNames = Split(Temp, "\")

    End Function


    Private Sub ButtonNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonNext.Click
        If Not RadioTask1.Checked And Not RadioTask2.Checked Then
            MsgBox("Select Action....") '�س��ͧ��÷���
            Exit Sub
        End If
        If DeviceName = "" Then
            MsgBox("Select Device...")
            Exit Sub
        End If

        Select Case True
            Case RadioTask1.Checked
                Do_Export()
            Case RadioTask2.Checked
                Do_Import()
        End Select

    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBackEF.Click, btnBackIF.Click
        TabMain.SelectedTab = TabSelection
    End Sub

    Private Sub btnFinish_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFinishEF.Click, btnFinishIF.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

#Region "Export Offline"

    Private Sub Do_Export()

        '-------------------------------Clear All Status'-------------------------------
        LabelExOfStep1.Font = New Font("Tahoma", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
        LabelExOfStep2.Font = New Font("Tahoma", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
        LabelExOfStep3.Font = New Font("Tahoma", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
        LabelExOfStep4.Font = New Font("Tahoma", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))

        LabelExOfStep1.ForeColor = Color.Gray
        LabelExOfStep2.ForeColor = Color.Gray
        LabelExOfStep3.ForeColor = Color.Gray
        LabelExOfStep4.ForeColor = Color.Gray

        IconExOfStep1.BackColor = Color.WhiteSmoke
        IconExOfStep2.BackColor = Color.WhiteSmoke
        IconExOfStep3.BackColor = Color.WhiteSmoke
        IconExOfStep4.BackColor = Color.WhiteSmoke

        txtQtyExOf.Clear()

        lblHeader_ExOf.Text = "Send Data To " & DeviceName & " ..." '���͡��ѧ

        btnCancelEF.Enabled = True
        btnBackEF.Enabled = False
        btnFinishEF.Enabled = False

        TabMain.SelectedTab = TabExportOffline

        '-------------------------------Step 1 Check Environment-------------------------------
        LabelExOfStep1.Font = New Font("Tahoma", 9.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))

        Dim MyDocPath As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        ' Dim FilePath As String = MyDocPath & "\" & DeviceName & " My Documents"
        Dim FilePath As String = MyDocPath & "\Documents on " & DeviceName
        If Not Directory.Exists(Application.StartupPath) Then
            Directory.CreateDirectory(Application.StartupPath)
            'Documents on xXx's Device
            'Temp = TempFolderName.Replace("Documents on ", "")
            'Temp = Temp.Substring(0, Len(Temp) - Len("'s Device"))
            ' FilePath = MyDocPath & "\Documents on " & DeviceName & "'s Device"
            'If Not Directory.Exists(FilePath) Then
            '    MsgBox("��辺 Directory ����ͧ������͡" & vbNewLine & "��سҵ�Ǩ�ͺ�ա����")

            '    '-------------- Display Error -------------
            '    LabelExOfStep1.ForeColor = Color.Red
            '    IconExOfStep1.BackColor = Color.Red
            '    StopExport(Nothing, Nothing)
            '    Exit Sub
            'End If
        End If

        If Not btnCancelEF.Enabled Then Exit Sub '----------Check Cancel Requested--------

        LabelExOfStep1.ForeColor = Color.Green
        IconExOfStep1.BackColor = Color.GreenYellow

        '-------------------------------Step 2 Retrieve Data To Export-------------------------
        LabelExOfStep2.Font = New Font("Tahoma", 9.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        Dim DT As DataTable
        Try
            DT = GenerateExportList().Copy

            DT.Columns.Add("REF_ID")

            Dim trans As New SqlTransactionDB
            trans.CreateTransaction()
            Dim ret As Boolean = False
            Dim ErrMessage As String = ""
            'ref_id
            For i As Integer = 0 To DT.Rows.Count - 1
                Dim dal As New TbFindHHTDAL
                dal.APP_NO = DT.Rows(i).Item("APP_NO")
                dal.LOAD_DATETIME = Now
                dal.LOAD_TYPE = "U"
                dal.FIND_STATUS = "N"

                ret = dal.InsertData(frmMain.txtUserName.Text, trans.Trans)

                If Not ret Then
                    ErrMessage = dal.ErrorMessage
                    StopExport(Nothing, Nothing)
                    Exit For
                Else
                    DT.Rows(i).Item("REF_ID") = dal.ID
                End If
            Next

            If ret Then
                trans.CommitTransaction()
            Else
                trans.RollbackTransaction()
                MsgBox(ErrMessage)
                LabelExOfStep2.Text = "Can Not Provide Information" '�������ö�������������
                LabelExOfStep2.ForeColor = Color.Red
                IconExOfStep2.BackColor = Color.Red
                Exit Sub
            End If


        Catch ex As Exception

            '-------------- Display Error -------------
            LabelExOfStep2.ForeColor = Color.Red
            IconExOfStep2.BackColor = Color.Red
            StopExport(Nothing, Nothing)
            MsgBox(ex.Message)
            Exit Sub

        End Try

        '###������� Copy file To Device#######
        'If File.Exists(FilePath & "\DIPExport.txt") Then File.Delete(Application.StartupPath & "\DIPExport.txt")
        'Dim objWriter As New System.IO.StreamWriter(Application.StartupPath & "\DIPExport.txt", True)
        If File.Exists(Application.StartupPath & "\DIPCheckOut.txt") Then File.Delete(Application.StartupPath & "\DIPCheckOut.txt")
        Dim objWriter As New System.IO.StreamWriter(Application.StartupPath & "\DIPCheckOut.txt", True)
        Dim strText As New StringBuilder
        For i As Integer = 0 To DT.Rows.Count - 1
            'strText.Append(DAL.Common.Utilities.Func.strToHex(DT.Rows(i)("APP_NO")))
            strText.Append(SetRFIDTAG(DT.Rows(i)("APP_NO")))
            strText.AppendLine()
        Next

        objWriter.Write(strText.ToString)
        objWriter.Close()

        Try
            Dim rapi As New RAPI
            If rapi.DevicePresent Then
                'If rapi.DeviceFileExists("\My Documents\DIPExport.txt") Then
                '    rapi.DeleteDeviceFile("\My Documents\DIPExport.txt")
                'End If
                rapi.Connect()
                rapi.CopyFileToDevice(Application.StartupPath & "\DIPCheckOut.txt", "\My Documents\DIPCheckOut.txt", True)
                rapi.CopyFileToDevice(Application.StartupPath & "\ApplicationType.txt", "\My Documents\ApplicationType.txt", True)
                rapi.Disconnect()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        '#################################

        txtQtyExOf.Text = FormatNumber(DT.Rows.Count, 0)

        If Not btnCancelEF.Enabled Then Exit Sub '----------Check Cancel Requested--------

        LabelExOfStep2.ForeColor = Color.Green
        IconExOfStep2.BackColor = Color.GreenYellow

        '-------------------------------Step 3 Write Text File-------------------------------
        LabelExOfStep3.Font = New Font("Tahoma", 9.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))

        Dim FileName As String = Application.StartupPath & "\DIPExport.dat"
        Try

            If File.Exists(FileName) Then File.Delete(FileName)
            Dim DS As New DataSet("DIP")
            DS.Tables.Add(DT)
            DS.WriteXml(FileName)


        Catch ex As Exception

            '-------------- Display Error -------------
            LabelExOfStep3.ForeColor = Color.Red
            IconExOfStep3.BackColor = Color.Red
            StopExport(Nothing, Nothing)
            MsgBox(ex.Message)
            Exit Sub

        End Try

        If Not btnCancelEF.Enabled Then Exit Sub '----------Check Cancel Requested--------

        LabelExOfStep3.ForeColor = Color.Green
        IconExOfStep3.BackColor = Color.GreenYellow

        '-------------------------------Step 4 Wait For Syncronize----------------------------
        LabelExOfStep4.Font = New Font("Tahoma", 9.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        WaitCount = 0
        TimerWait.Enabled = True
        '-------------------------------Finish-----------------------------------------

        MsgBox("Save Complete To Device ") '�ѹ�֡����������ػ�ó��;�ǧ�����

    End Sub

    Private Function SetRFIDTAG(ByVal APP_NO As String)
        Dim dt As DataTable = SqlDB.ExecuteTable("SELECT TAGRFID FROM TB_REQUISTION WHERE  APP_NO='" & APP_NO & "'")
        If dt.Rows.Count > 0 Then
            Return dt(0)("TAGRFID")
        Else
            Return ""
        End If
    End Function



    Private Sub StopExport(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancelEF.Click
        btnCancelEF.Enabled = False
        btnBackEF.Enabled = True
        btnFinishEF.Enabled = True
    End Sub

#End Region

#Region "Import"

    Private Sub Do_Import()

        '-------------------------------Clear All Status'-------------------------------
        LabelImOfStep1.Font = New Font("Tahoma", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
        LabelImOfStep2.Font = New Font("Tahoma", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
        LabelImOfStep3.Font = New Font("Tahoma", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
        LabelImOfStep4.Font = New Font("Tahoma", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))

        LabelImOfStep1.ForeColor = Color.Gray
        LabelImOfStep2.ForeColor = Color.Gray
        LabelImOfStep3.ForeColor = Color.Gray
        LabelImOfStep4.ForeColor = Color.Gray

        IconImOfStep1.BackColor = Color.WhiteSmoke
        IconImOfStep2.BackColor = Color.WhiteSmoke
        IconImOfStep3.BackColor = Color.WhiteSmoke
        IconImOfStep4.BackColor = Color.WhiteSmoke

        txtQtyImOf.Clear()
        txtErrImOf.Clear()

        btnViewImport.Enabled = False
        btnViewErrorImport.Enabled = False

        TotalImport = Nothing
        TotalError = Nothing

        lblHeader_ImOf.Text = "Read Data From  " & DeviceName & " ..." '��ҹ��§ҹ��ä��Ҩҡ

        TabMain.SelectedTab = TabImportOffline

        '-------------------------------Step 1 Check Environment-------------------------------
        LabelImOfStep1.Font = New Font("Tahoma", 9.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))

        Dim MyDocPath As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        'Dim FilePath As String = MyDocPath & "\" & DeviceName & " My Documents"
        Dim FilePath As String = MyDocPath & "\Documents on " & DeviceName


        'If Not Directory.Exists(FilePath) Then
        '    FilePath = MyDocPath & "\Documents on " & DeviceName & "'s Device"
        '    If Not Directory.Exists(FilePath) Then
        '        MsgBox("��辺 Directory �������§ҹ" & vbNewLine & "��سҵ�Ǩ�ͺ�ա����")
        '        '-------------- Display Error -------------
        '        LabelImOfStep1.ForeColor = Color.Red
        '        IconImOfStep1.BackColor = Color.Red
        '        StopImport(Nothing, Nothing)
        '        Exit Sub
        '    End If
        'End If

        'Dim FileName As String = MyDocPath & "\" & DeviceName & " My Documents\DIPImport.dat"
        'If Not File.Exists(FileName) Then
        '    FileName = FilePath & "\DIPImport.dat"
        '    If Not File.Exists(FileName) Then
        '        MsgBox("��辺�����§ҹ" & vbNewLine & "��سҵ�Ǩ�ͺ�ա����")

        '        '-------------- Display Error -------------
        '        LabelImOfStep1.ForeColor = Color.Red
        '        IconImOfStep1.BackColor = Color.Red
        '        StopImport(Nothing, Nothing)
        '        Exit Sub
        '    End If
        'End If
        Dim strFileImportName As String = ""
        Dim strType As String = ""
        Dim strRFIDREaderID As String = "0"
        Select Case frmMain.txtDocumentEvent.Text.ToLower
            Case "borrow"
                strFileImportName = "HH_CheckOut.txt"
                strType = 1
            Case "return"
                strFileImportName = "HH_CheckIn.txt"
                strType = 2
            Case "location"
                strFileImportName = "HH_Change.txt"
                strType = 3
        End Select

        Try
            Dim rapi As New RAPI
            If rapi.DevicePresent Then
                'If rapi.DeviceFileExists("\My Documents\DIPExport.txt") Then
                '    rapi.DeleteDeviceFile("\My Documents\DIPExport.txt")
                'End If
                rapi.Connect()
                rapi.CopyFileFromDevice(Application.StartupPath & "\" & strFileImportName, "\My Documents\" & strFileImportName, True)
                rapi.Disconnect()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        If Not btnCancelIF.Enabled Then Exit Sub '----------Check Cancel Requested--------

        LabelImOfStep1.ForeColor = Color.Green
        IconImOfStep1.BackColor = Color.GreenYellow

        '-------------------------------Step 2 Retrieve Data To Import-------------------------
        LabelImOfStep2.Font = New Font("Tahoma", 9.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))

        '�׹�ѹ�������ź Temp
        SqlDB.ExecuteNonQuery("DELETE FROM TMP_GATE_READER_TAG ")

        Dim ReadTextFile As New ReadBarcodeFromTextFile
        Dim RT As DataTable = ReadTextFile.ReadTextFile(Application.StartupPath & "\" & strFileImportName)
        Dim IsInsert As Boolean = ReadTextFile.ReadTextFileAndInsertToTemp(Application.StartupPath & "\" & strFileImportName, strRFIDREaderID, strType)
        If IsInsert = False Then
            '-------------- Display Error -------------
            LabelImOfStep2.Text = "Can not read file"
            LabelImOfStep2.ForeColor = Color.Red
            IconImOfStep2.BackColor = Color.Red
            StopImport(Nothing, Nothing)
            MsgBox("Can not read file")
            Exit Sub
        End If

        ''Dim DS As New DataSet
        ''Dim RT As DataTable
        ''Try
        ''    DS.ReadXml(Application.StartupPath & "\My Documents\DIPImport.txt")
        ''    RT = DS.Tables(0)
        ''Catch ex As Exception
        ''    '-------------- Display Error -------------
        ''    LabelImOfStep2.Text = "�������ö��ҹ�����§ҹ����"
        ''    LabelImOfStep2.ForeColor = Color.Red
        ''    IconImOfStep2.BackColor = Color.Red
        ''    StopImport(Nothing, Nothing)
        ''    MsgBox(ex.Message)
        ''    Exit Sub
        ''End Try


        txtQtyImOf.Text = RT.Rows.Count
        txtErrImOf.Text = 0

        btnViewImport.Enabled = True

        TotalImport = RT
        TotalError = RT.Copy

        If RT.Rows.Count = 0 Then
            '-------------- Display Error -------------
            LabelImOfStep2.ForeColor = Color.Red
            IconImOfStep2.BackColor = Color.Red
            StopImport(Nothing, Nothing)
            MsgBox("Data not found in file")
            LabelImOfStep2.Text = "Data not found"
            btnViewErrorImport.Enabled = True
            Exit Sub
        End If

        If Not btnCancelIF.Enabled Then Exit Sub '----------Check Cancel Requested--------

        LabelImOfStep2.ForeColor = Color.Green
        IconImOfStep2.BackColor = Color.GreenYellow

        '-------------------------------Step 3 Write Text File-------------------------------
        LabelImOfStep3.Font = New Font("Tahoma", 9.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))

        Dim trans As New SqlTransactionDB
        trans.CreateTransaction()
        Dim ret As Boolean = False
        Dim ErrMessage As String = ""
        Dim ErrCount As Integer = 0

        For i As Integer = 0 To RT.Rows.Count - 1
            Dim GetTextFile As New ReadBarcodeFromTextFile
            Dim strApp_No As String = GetTextFile.GetApplicationNoByRFID(RT.Rows(i).Item("APP_NO"))
            If strApp_No <> "" Then
                Dim dal As New TbFindHHTDAL
                dal.APP_NO = strApp_No
                'Dim LoadTime As DateTime = DateTime.FromOADate(CDbl(RT.Rows(i).Item("LOAD_DATETIME")))
                dal.LOAD_DATETIME = RT.Rows(i).Item("LOAD_DATETIME")
                dal.LOAD_TYPE = "D"
                If RT.Rows(i).Item("FIND_STATUS") = "0" Then
                    dal.FIND_STATUS = "N"
                Else
                    dal.FIND_STATUS = "Y"
                End If
                ' dal.REF_ID = RT.Rows(i).Item("REF_ID")
                ret = dal.InsertData(frmMain.txtUserName.Text, trans.Trans)
                If Not ret Then

                    '--------------- Get Error Record---------
                    Dim DR As DataRow = TotalError.NewRow
                    For j As Integer = 0 To RT.Columns.Count - 1
                        If Not IsDBNull(RT.Rows(i)) Then
                            DR(j) = RT.Rows(i)
                        End If
                    Next
                    TotalError.Rows.Add(DR)
                    '--------------- Get Error Record---------

                    ErrMessage = dal.ErrorMessage
                    ErrCount += 1
                    txtErrImOf.Text = ErrCount
                    txtErrImOf.Refresh()
                    btnViewErrorImport.Enabled = True
                    Exit For
                End If
            End If



        Next

        If ErrCount > 0 Then
            If MsgBox("Total " & ErrCount & " Item From " & RT.Rows.Count & "Item" & vbNewLine & " Save Fail" & vbNewLine & "You want to save the continue items or not?", MsgBoxStyle.YesNo) <> MsgBoxResult.Yes Then
                LabelImOfStep2.Text = "Save cancel"
                LabelImOfStep2.ForeColor = Color.Red
                IconImOfStep2.BackColor = Color.Red
                Exit Sub
            End If
        End If

        If ErrCount <> RT.Rows.Count Then
            trans.CommitTransaction()
        Else
            trans.RollbackTransaction()
        End If

        If Not btnCancelEF.Enabled Then Exit Sub '----------Check Cancel Requested--------

        LabelImOfStep3.ForeColor = Color.Green
        IconImOfStep3.BackColor = Color.GreenYellow

        '-------------------------------Step 4 Delete File----------------------------
        LabelImOfStep4.Font = New Font("Tahoma", 9.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        RT.Dispose()
        Try
            'If File.Exists(Application.StartupPath & "\" & strFileImportName) Then
            '    File.Delete(Application.StartupPath & "\" & strFileImportName)
            'End If
            'trans = Nothing
            'RemoveAccessDatabase(Application.StartupPath & "\" & strFileImportName, 100, 5)
        Catch ex As Exception
            MsgBox(ex)
            LabelImOfStep4.Text = "Can not delete file"
            LabelImOfStep4.ForeColor = Color.Red
            IconImOfStep4.BackColor = Color.Red
            Exit Sub
        End Try
        '-------------------------------Finish-----------------------------------------

        LabelImOfStep4.ForeColor = Color.Green
        IconImOfStep4.BackColor = Color.GreenYellow

        MsgBox("Save Complete")

    End Sub

    Function RemoveAccessDatabase( _
    ByVal FileName As String, _
    ByVal WaitTime As Integer, _
    ByVal Loops As Integer) As Boolean

        Dim Success As Boolean = False

        Dim LockFile As String = IO.Path.ChangeExtension(FileName, "txt")

        For Counter As Integer = 0 To Loops
            If IO.File.Exists(LockFile) Then
                System.Threading.Thread.Sleep(WaitTime)
                IO.File.Delete(FileName)
            Else
                Success = True
                Exit For
            End If
        Next

        Return Success

    End Function

    Dim TotalImport As DataTable
    Dim TotalError As DataTable

    Private Sub btnViewImport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewImport.Click
        Dim F As New frmPreviewMobile
        F.Datasource = TotalImport
        Dim Total As Integer = 0
        If Not IsNothing(TotalImport) AndAlso TotalImport.Rows.Count > 0 Then
            F.Text = "Summary " & TotalImport.Rows.Count & " Application"
            Dim tmp As DataTable = TotalError.Copy
            tmp.DefaultView.RowFilter = "FIND_STATUS='1'"
            F.Text &= "Found " & tmp.DefaultView.Count & "/" & tmp.Rows.Count
            tmp.Dispose()
        Else
            F.Text = "Not Found Applicatio"
        End If
        F.ShowDialog()
    End Sub

    Private Sub btnViewErrorImport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewErrorImport.Click
        Dim F As New frmPreviewMobile
        F.Datasource = TotalError
        Dim Total As Integer = 0
        If Not IsNothing(TotalError) AndAlso TotalError.Rows.Count > 0 Then
            F.Text = "Summary Save Fail " & TotalError.Rows.Count & " Application"
        Else
            F.Text = "Not Found Application Fail"
        End If
        F.ShowDialog()
    End Sub

    'Private Function IsFormatQuery(ByVal InputText As String) As String
    '    If Not InputText.IndexOf("INSERT INTO TB_FIND_HHT (id,app_no,load_datetime,load_type,find_status,createon,updateon) VALUES ((SELECT ISNULL(MAX(id),0)+1 FROM TB_FIND_HHT),") <> 0 Then
    '        Return False
    '    End If
    '    Try
    '        If Not InputText.IndexOf(",GetDate(),GetDate())") = -1 Then
    '            Return False
    '        End If
    '    Catch ex As Exception
    '        Return False
    '    End Try
    '    Return True
    'End Function

    Private Sub StopImport(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancelIF.Click
        btnCancelIF.Enabled = False
        btnBackIF.Enabled = True
        btnFinishIF.Enabled = True
    End Sub


#End Region

    Dim WaitCount As Integer = 0
    Dim MaxWait As Integer = 5

    Private Sub TimerWait_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles TimerWait.Tick
        WaitCount += 1

        '---------- Check Cancel Requested----------
        Select Case SyncFor
            Case TASK_TYPE.Export

                If Not btnCancelEF.Enabled Then
                    LabelExOfStep4.ForeColor = Color.Red
                    IconExOfStep4.BackColor = Color.Red
                    StopExport(Nothing, Nothing)
                    WaitCount = 0
                    TimerWait.Enabled = False
                    Exit Sub
                End If

                If WaitCount >= MaxWait Then
                    LabelExOfStep4.ForeColor = Color.Green
                    IconExOfStep4.BackColor = Color.GreenYellow
                    StopExport(Nothing, Nothing)
                    WaitCount = 0
                    TimerWait.Enabled = False
                End If

            Case TASK_TYPE.Import

        End Select

    End Sub

End Class