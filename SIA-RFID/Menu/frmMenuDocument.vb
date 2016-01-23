Imports Data.Common.Utilities
Imports DAL.Common.Utilities
Imports System.Data.SqlClient
Imports DAL.Table

Public Class frmMenuDocument

    Private Sub frmMenuDocument_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.BackgroundImage = Image.FromFile("images/BG.jpg")
        CheckMenu(frmMain.txtIdUser.Text)
    End Sub

    Private Sub btnReturn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReturn.Click
        CloseAllForm()
        frmMain.txtDocumentEvent.Text = "return" 'ใช้ตอน import file จาก Handle
        Dim frm As New frmReturns
        ShowForm(frm)
    End Sub

    Private Sub btnBorrow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrow.Click
        CloseAllForm()
        'Dim frmLogin As New frmLogin
        'frmLogin.txtFormName.Text = Constant.FormName.FormReserve
        'If frmLogin.ShowDialog = Windows.Forms.DialogResult.OK Then
        '    Dim frm As New frmBorrow
        '    ShowForm(frm)
        'End If
        frmMain.txtDocumentEvent.Text = "borrow" 'ใช้ตอน import file จาก Handle
        Dim frm As New frmBorrow
        ShowForm(frm)
    End Sub

    Private Sub btnTransfer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTransfer.Click
        CloseAllForm()
        frmMain.txtDocumentEvent.Text = "location" 'ใช้ตอน import file จาก Handle
        Dim frm As New frmTransfer
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

    Sub CheckMenu(ByVal OfficeID As String)
        btnBorrow.Enabled = False
        btnReturn.Enabled = False
        btnTransfer.Enabled = False
        btnReturn.BackgroundImage = Image.FromFile("images/dis_app_icon_03.jpg")
        btnBorrow.BackgroundImage = Image.FromFile("images/dis_app_icon_05.jpg")
        btnTransfer.BackgroundImage = Image.FromFile("images/dis_app_icon_10.jpg")
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
            Case "mnuTransfer"
                btnTransfer.Enabled = True
                btnTransfer.BackgroundImage = Image.FromFile("images/app_icon_10.jpg")
            Case "mnuBorrow"
                btnBorrow.Enabled = True
                btnBorrow.BackgroundImage = Image.FromFile("images/app_icon_05.jpg")
            Case "mnuReturn"
                btnReturn.Enabled = True
                btnReturn.BackgroundImage = Image.FromFile("images/app_icon_03.jpg")
                'Case "mnuBorrowByOfficer"
                '    mnuBorrowByOfficer.Enabled = True
                'Case "mnuBorrowByDepartment"
                '    mnuBorrowByDepartment.Enabled = True
                'Case "mnuBorrowByDate"
                '    mnuBorrowByDate.Enabled = True
                'Case "mnuBorrowBetween"
                '    mnuBorrowBetween.Enabled = True
                'Case "mnuBorrowNoReturn"
                '    mnuBorrowNoReturn.Enabled = True
                'Case "mnuBorrowAllOfficer"
                '    mnuBorrowAllOfficer.Enabled = True
                'Case "mnuReturnByOfficer"
                '    mnuReturnByOfficer.Enabled = True
                'Case "mnuReturnByDepartment"
                '    mnuReturnByDepartment.Enabled = True
                'Case "mnuReturnByDate"
                '    mnuReturnByDate.Enabled = True
                'Case "mnuStatisticsBorrow"
                '    mnuStatisticsBorrow.Enabled = True
                'Case "mnuStatisticsReturn"
                '    mnuStatisticsReturn.Enabled = True
                'Case "mnuStatisticsByOfficer"
                '    mnuStatisticsByOfficer.Enabled = True
                'Case "mnuPerform"
                '    mnuPerform.Enabled = True
                'Case "mnuReportsHistory"
                '    mnuReportsHistory.Enabled = True
                'Case "mnuGraphAll"
                '    mnuGraphAll.Enabled = True
                'Case "mnuGraphBorrowByDepartment"
                '    mnuGraphBorrowByDepartment.Enabled = True
                'Case "mnuGraphBorrowByPatentType"
                '    mnuGraphBorrowByPatentType.Enabled = True
                'Case "mnuGraphByOfficer"
                '    mnuGraphByOfficer.Enabled = True
                'Case "mnuShutdownProgram"
                '    mnuShutdownProgram.Enabled = True
                'Case "mnuShutdownMenu"
                '    mnuShutdownMenu.Enabled = True
                'Case "mnuPermission"
                '    mnuPermission.Enabled = True
                'Case "mnuOfficer"
                '    mnuOfficer.Enabled = True
                'Case "mnuDepartment"
                '    mnuDepartment.Enabled = True
                'Case "mnuPosition"
                '    mnuPosition.Enabled = True
                'Case "mnuTitleName"
                '    mnuTitleName.Enabled = True
                'Case "mnuPatentType"
                '    mnuPatentType.Enabled = True
                'Case "mnuShelf"
                '    mnuShelf.Enabled = True
                'Case "mnuSubFile"
                '    mnuSubFile.Enabled = True
                'Case "mnuHandheld"
                '    mnuHandheld.Enabled = True
                'Case "mnuMifare"
                '    mnuMifare.Enabled = True
                'Case "mnuCounterReader"
                '    mnuCounterReader.Enabled = True
                'Case "mnuSearchOfficerByDepartment"
                '    mnuSearchOfficerByDepartment.Enabled = True
                'Case "mnuAgent"
                '    mnuAgent.Enabled = True
        End Select
    End Sub
End Class