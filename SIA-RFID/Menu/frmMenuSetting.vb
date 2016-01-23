Imports Data.Common.Utilities
Imports DAL.Common.Utilities
Imports DAL.Table
Public Class frmMenuSetting

    Private Sub frmMenuDocument_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.BackgroundImage = Image.FromFile("images/BG.jpg")
        CheckMenu(frmMain.txtIdUser.Text)
    End Sub

    Private Sub btnReturn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_set_07.Click
        CloseAllForm()
        Dim frm As New frmPatentType
        ShowForm(frm)
    End Sub

    Private Sub btnRegisterClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_set_01.Click
        CloseAllForm()
        Dim frm As New frmPermission
        ShowForm(frm)
    End Sub

    Private Sub btnTransfer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_set_11.Click
        CloseAllForm()
        Dim frm As New frmFloor
        ShowForm(frm)
    End Sub


    Private Sub CloseAllForm()
        For Each fm In frmMain.MdiChildren
            fm.Close()
            fm.Dispose()
        Next
    End Sub


    Private Sub ShowForm(ByVal frm As Form)
        CloseAllForm()
        frm.MdiParent = frmMain
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.Show()
    End Sub

    Private Sub btn_set_10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_set_10.Click
        CloseAllForm()
        Dim frm As New frmRegisterList
        ShowForm(frm)
    End Sub

    Private Sub btn_set_02_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_set_02.Click
        CloseAllForm()
        Dim frm As New frmOfficerSearch
        ShowForm(frm)
    End Sub

    Private Sub btn_set_03_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_set_03.Click
        CloseAllForm()
        Dim frm As New frmDepartment
        ShowForm(frm)
    End Sub

    Private Sub btn_set_04_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_set_04.Click
        CloseAllForm()
        Dim frm As New frmPosition
        ShowForm(frm)
    End Sub

    Private Sub btn_set_05_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_set_05.Click
        CloseAllForm()
        Dim frm As New frmTitle
        ShowForm(frm)
    End Sub

    Private Sub btn_set_06_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_set_06.Click
        CloseAllForm()
        Dim frm As New frmChangePassword
        ShowForm(frm)
    End Sub

    Private Sub btn_set_08_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_set_08.Click
        CloseAllForm()
        Dim frm As New frmSubfile
        ShowForm(frm)
    End Sub

    Private Sub btn_set_09_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_set_09.Click
        CloseAllForm()
        Dim frm As New frmDBConfig
        ShowForm(frm)
    End Sub

    Private Sub btn_set_12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_set_12.Click
        CloseAllForm()
        Dim frm As New frmRoom
        ShowForm(frm)
    End Sub

    Private Sub btn_set_13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_set_13.Click
        CloseAllForm()
        Dim frm As New frmcabinet
        ShowForm(frm)
    End Sub

    Sub CheckMenu(ByVal OfficeID As String)
        btn_set_01.Enabled = False 'กำหนดสิทธิ์การเข้าใช้งาน
        btn_set_02.Enabled = False 'กำหนดชื่อผู้ใช้งาน
        btn_set_03.Enabled = False 'กำหนดชื่อหน่วยงาน
        btn_set_04.Enabled = False 'กำหนดตำแหน่งเจ้าหน้าที่
        btn_set_05.Enabled = False 'กำหนดคำนำหน้าชื่อ
        btn_set_06.Enabled = True  'เปลี่ยน Password
        btn_set_07.Enabled = False 'กำหนดประเภท Application
        btn_set_08.Enabled = False 'บันทึกข้อมูลแฟ้มต่อ
        btn_set_09.Enabled = True  'เชื่อมต่อ Database
        btn_set_10.Enabled = False 'กำหนดApplication
        btn_set_11.Enabled = False 'กำหนดชั้น
        btn_set_12.Enabled = False 'กำหนดห้อง
        btn_set_13.Enabled = False 'กำหนดตู้

        btn_set_01.BackgroundImage = Image.FromFile("images/dis_set_01.jpg")
        btn_set_02.BackgroundImage = Image.FromFile("images/dis_set_02.jpg")
        btn_set_03.BackgroundImage = Image.FromFile("images/dis_set_03.jpg")
        btn_set_04.BackgroundImage = Image.FromFile("images/dis_set_04.jpg")
        btn_set_05.BackgroundImage = Image.FromFile("images/dis_set_05.jpg")
        btn_set_06.BackgroundImage = Image.FromFile("images/set_06.jpg")
        btn_set_07.BackgroundImage = Image.FromFile("images/dis_set_07.jpg")
        btn_set_08.BackgroundImage = Image.FromFile("images/dis_set_08.jpg")
        btn_set_09.BackgroundImage = Image.FromFile("images/set_09.jpg")
        btn_set_10.BackgroundImage = Image.FromFile("images/dis_set_10.jpg")
        btn_set_11.BackgroundImage = Image.FromFile("images/dis_set_11.jpg")
        btn_set_12.BackgroundImage = Image.FromFile("images/dis_set_12.jpg")
        btn_set_13.BackgroundImage = Image.FromFile("images/dis_set_13.jpg")

        Dim AuthMenuDal As New OfficerMenuListDAL
        Dim dtmenu As DataTable = AuthMenuDal.GetDataList("officer_id = '" & OfficeID & "'", "", Nothing)
        If dtmenu.Rows.Count > 0 Then
            For i As Int32 = 0 To dtmenu.Rows.Count - 1
                CheckMenuNotDisable(dtmenu.Rows(i).Item("menu_url").ToString.Trim)
            Next
        End If

    End Sub

    Sub CheckMenuNotDisable(ByVal MenuName As String)

        Select Case MenuName
            Case "mnuPermission"
                btn_set_01.Enabled = True
                btn_set_01.BackgroundImage = Image.FromFile("images/set_01.jpg")
            Case "mnuOfficer"
                btn_set_02.Enabled = True
                btn_set_02.BackgroundImage = Image.FromFile("images/set_02.jpg")
            Case "mnuDepartment"
                btn_set_03.Enabled = True
                btn_set_03.BackgroundImage = Image.FromFile("images/set_03.jpg")
            Case "mnuPosition"
                btn_set_04.Enabled = True
                btn_set_04.BackgroundImage = Image.FromFile("images/set_04.jpg")
            Case "mnuTitleName"
                btn_set_05.Enabled = True
                btn_set_05.BackgroundImage = Image.FromFile("images/set_05.jpg")
            Case "mnuPatentType"
                btn_set_07.Enabled = True
                btn_set_07.BackgroundImage = Image.FromFile("images/set_07.jpg")
            Case "mnuSubFile"
                btn_set_08.Enabled = True
                btn_set_08.BackgroundImage = Image.FromFile("images/set_08.jpg")
            Case "mnuRegister"
                btn_set_10.Enabled = True
                btn_set_10.BackgroundImage = Image.FromFile("images/set_10.jpg")
            Case "mnuFloor"
                btn_set_11.Enabled = True
                btn_set_11.BackgroundImage = Image.FromFile("images/set_11.jpg")
            Case "mnuRoom"
                btn_set_12.Enabled = True
                btn_set_12.BackgroundImage = Image.FromFile("images/set_12.jpg")
            Case "mnuCabinet"
                btn_set_13.Enabled = True
                btn_set_13.BackgroundImage = Image.FromFile("images/set_13.jpg")
        End Select
    End Sub
End Class