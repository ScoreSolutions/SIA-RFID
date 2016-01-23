Imports System.Data.SqlClient
Imports DAL.Table
Imports DAL.Common.Utilities
Public Class frmMenuReport

    Private Sub frmMenuReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackgroundImage = Image.FromFile("images/BG.jpg")
    End Sub

    Private Sub frmMenuReport_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Dim dt As New DataTable
        dt = GetMenuReport(frmMain.txtUserName.Text)
        SetPermission(dt)
    End Sub

    'Private Sub ShowForm(ByVal frm As Form)
    '    CloseAllForm()
    '    frm.MdiParent = frmMain
    '    frm.StartPosition = FormStartPosition.CenterParent
    '    frm.Show()
    'End Sub

    'Private Sub CloseAllForm()
    '    For Each fm In Me.MdiChildren
    '        fm.Close()
    '        fm.Dispose()
    '    Next
    'End Sub

    Function GetMenuReport(ByVal username As String) As DataTable
        Dim dal As New TbFloorDAL
        Dim trans As New SqlTransactionDB
        trans.CreateTransaction()
        Dim dt As New DataTable
        Dim sql As String = "select * from ("
        sql += " select id,menu_name from tb_menu where module_id = 3 ) MenuMaster"
        sql += " left join ("
        sql += " select Menu_id from TB_PERMISSION_MENU"
        sql += " where Permission_id in ("
        sql += " select permission_id from TB_PERMISSION_OFFICER P inner join TB_OFFICER O on P.officer_id = O.id"
        sql += " where username = '" & username & "')) MenuOfficer"
        sql += " on MenuMaster.id = MenuOfficer.Menu_id"
        dt = dal.GetListBySql(sql, "", trans.Trans)
        trans.CommitTransaction()
        Return dt
    End Function

    Function CheckPermission(ByVal dt As DataTable, ByVal menu_id As String)
        Dim tmpdr() As DataRow
        tmpdr = dt.Select(" isnull(menu_id,'') ='" & menu_id & "'")
        If tmpdr.Length = 0 Then Return False
        Return True
    End Function

    Sub SetPermission(ByVal dt As DataTable)
        lblmnuBorrowByOfficer.Enabled = CheckPermission(dt, "4") 'menu_id = 4 รายงานการยืมแฟ้ม (รายคน) 
        lblmnuBorrowByDepartment.Enabled = CheckPermission(dt, "5") 'menu_id = 5 รายงานการยืมแฟ้ม (ตามสังกัด)
        lblmnuBorrowByDate.Enabled = CheckPermission(dt, "6") 'menu_id = 6 รายงานการยืมแฟ้มประจำวัน
        lblmnuBorrowBetween.Enabled = CheckPermission(dt, "7") 'menu_id = 7 รายงานแฟ้มที่ติดชื่อผู้ยืม (ตามสังกัด)
        lblmnuBorrowNoReturn.Enabled = CheckPermission(dt, "8") 'menu_id = 8 รายงานแฟ้มที่ติดชื่อผู้ยืม (รายคน)
        lblmnuBorrowAllOfficer.Enabled = CheckPermission(dt, "9") 'menu_id = 9 รายงานแฟ้มที่ติดชื่อผู้ยืมทั้งหมด

        lblmnuReturnByOfficer.Enabled = CheckPermission(dt, "10") 'menu_id = 10 รายงานการคืนแฟ้ม (รายคน)
        lblmnuReturnByDepartment.Enabled = CheckPermission(dt, "11") 'menu_id = 11 รายงานการคืนแฟ้ม (ตามสังกัด)
        lblmnuReturnByDate.Enabled = CheckPermission(dt, "12") 'menu_id = 12 รายงานการคืนแฟ้มประจำวัน

        lblmnuReportsHistory.Enabled = CheckPermission(dt, "17") 'menu_id = 17 รายงานประวัติการยืม-การคืนแฟ้ม
        lblmnuPerform.Enabled = CheckPermission(dt, "16") 'menu_id = 16 รายงานการปฏิบัติงานของเจ้าหน้าที่ห้องแฟ้ม

        lblmnuGraphAll.Enabled = CheckPermission(dt, "18") 'menu_id = 18 กราฟแสดงรายการยืม-คืนแฟ้ม (ทั้งหมด)
        lblmnuGraphBorrowByDepartment.Enabled = CheckPermission(dt, "19") 'menu_id = 19 กราฟแสดงรายการยิม-คืนแฟ้ม (ตามสังกัด)
        lblmnuGraphBorrowByPatentType.Enabled = CheckPermission(dt, "20") 'menu_id = 20 กราฟแสดงรายการยิม-คืนแฟ้ม (ตามประเภทแฟ้ม)
        lblmnuGraphByOfficer.Enabled = CheckPermission(dt, "21") 'menu_id = 21 กราฟแสดงรายการยืม-คืนแฟ้ม (ตามเจ้าหน้าที่ห้องแฟ้ม)

        lblmnuStatisticsBorrow.Enabled = CheckPermission(dt, "13") 'menu_id = 13 รายงานสถิติการยืมแฟ้ม
        lblmnuStatisticsReturn.Enabled = CheckPermission(dt, "14") 'menu_id = 14 รายงานสถิติการคืนแฟ้ม
        lblmnuStatisticsByOfficer.Enabled = CheckPermission(dt, "15") 'menu_id = 15 รายงานประวัติการยืม-คืน (รายบุคคล)
    End Sub

    Private Sub lblmnuBorrowByOfficer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblmnuBorrowByOfficer.Click
        Dim frm As New frmBorrowByOfficer
        frmMain.ShowForm(frm)
    End Sub

    Private Sub lblmnuBorrowByDepartment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblmnuBorrowByDepartment.Click
        Dim frm As New frmBorrowByDepartment
        frmMain.ShowForm(frm)
    End Sub


    Private Sub lblmnuReturnByOfficer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblmnuReturnByOfficer.Click
        Dim frm As New frmReturnByOfficer
        frmMain.ShowForm(frm)
    End Sub
    Private Sub lblmnuReturnByDate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblmnuReturnByDate.Click
        Dim frm As New frmReturnByDay
        frmMain.ShowForm(frm)
    End Sub
    Private Sub mnuReturnByDepartment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblmnuReturnByDepartment.Click
        Dim frm As New frmReturnByDepartment
        frmMain.ShowForm(frm)
    End Sub

    Private Sub lblmnuReportsReturn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblmnuReportsReturn.Click

    End Sub

    Private Sub lblmnuBorrowByDate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblmnuBorrowByDate.Click
        Dim frm As New frmBorrowByDate
        frmMain.ShowForm(frm)
    End Sub

    Private Sub lblmnuBorrowBetween_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblmnuBorrowBetween.Click
        Dim frm As New frmBorrowBetween
        frmMain.ShowForm(frm)
    End Sub

    Private Sub lblmnuBorrowNoReturn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblmnuBorrowNoReturn.Click
        Dim frm As New frmBorrowNoReturn
        frmMain.ShowForm(frm)
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblmnuBorrowAllOfficer.Click
        Dim frm As New frmBorrowWithName
        frmMain.ShowForm(frm)
    End Sub

    Private Sub lblmnuStatisticsBorrow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblmnuStatisticsBorrow.Click
        Dim frm As New frmStatisticsBorrow
        frmMain.ShowForm(frm)
    End Sub

    Private Sub lblmnuStatisticsReturn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblmnuStatisticsReturn.Click
        Dim frm As New frmStatisticsReturn
        frmMain.ShowForm(frm)
    End Sub

    Private Sub lblmnuStatisticsByOfficer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblmnuStatisticsByOfficer.Click
        Dim frm As New frmStatisticsByOfficer
        frmMain.ShowForm(frm)
    End Sub

    Private Sub lblmnuPerform_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblmnuPerform.Click
        Dim frm As New frmPerform
        frmMain.ShowForm(frm)
    End Sub

    Private Sub lblmnuReportsHistory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblmnuReportsHistory.Click
        Dim frm As New frmFileHistory
        frmMain.ShowForm(frm)
    End Sub

    Private Sub lblmnuGraphAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblmnuGraphAll.Click
        Dim frm As New frmGraphAll
        frmMain.ShowForm(frm)
    End Sub

    Private Sub lblmnuGraphBorrowByDepartment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblmnuGraphBorrowByDepartment.Click
        Dim frm As New frmGraphByDepartment
        frmMain.ShowForm(frm)
    End Sub

    Private Sub lblmnuGraphBorrowByPatentType_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblmnuGraphBorrowByPatentType.Click
        Dim frm As New frmGraphByPatentType
        frmMain.ShowForm(frm)
    End Sub

    Private Sub lblmnuGraphByOfficer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblmnuGraphByOfficer.Click
        Dim frm As New frmGraphByOfficer
        frmMain.ShowForm(frm)
    End Sub

End Class