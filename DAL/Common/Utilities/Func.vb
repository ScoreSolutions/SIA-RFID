Imports System.Security.Cryptography
Imports System.Text
Imports DAL.Table
Imports System.Data.SqlClient

Namespace Common.Utilities
    Public Class Func

        Const encryptKey As String = "DiPRfId"
        Private Shared IV() As Byte = {10, 20, 30, 40, 50, 60, 70, 80}
        Public Shared Function GetEncrypt(ByVal text As String) As String
            Dim tdsp As New TripleDESCryptoServiceProvider
            Dim md5csp = New MD5CryptoServiceProvider
            Dim buffer As Byte() = Encoding.ASCII.GetBytes(text)
            tdsp.Key = md5csp.ComputeHash(ASCIIEncoding.ASCII.GetBytes(encryptKey))
            tdsp.IV = IV
            Return Convert.ToBase64String(tdsp.CreateEncryptor().TransformFinalBlock(buffer, 0, buffer.Length))
        End Function
        Public Shared Function GetDecrypt(ByVal text As String) As String
            Dim tdsp As New TripleDESCryptoServiceProvider
            Dim md5csp = New MD5CryptoServiceProvider
            Dim buffer As Byte() = Encoding.ASCII.GetBytes(text)
            buffer = Convert.FromBase64String(text)
            tdsp.Key = md5csp.ComputeHash(ASCIIEncoding.ASCII.GetBytes(encryptKey))
            tdsp.IV = IV
            Return Encoding.ASCII.GetString(tdsp.CreateDecryptor().TransformFinalBlock(buffer, 0, buffer.Length))
        End Function

        Public Shared Function GetSetupValue(ByVal SetupName As String, ByVal trans As SqlTransaction) As String
            Dim ret As String = ""
            Dim dal As New TbSetupDAL
            Dim dt As DataTable = dal.GetDataList("setup_name = '" & SetupName & "'", "", trans)
            If dt.Rows.Count > 0 Then
                ret = dt.Rows(0)("setup_value").ToString
            End If
            Return ret
        End Function

        Public Shared Function ChkUserPermission(ByVal OfficerID As Long, ByVal PermissionID As Integer, ByVal trans As SqlTransaction) As Boolean
            'ตรวจสอบว่าผู้ใช้มีสิทธิ์ตามกลุ่มที่ต้องการค้นหาหรือไม่
            Dim ret As Boolean = False
            Dim oDal As New TbOfficerDAL
            oDal.GetDataByid(OfficerID, trans)

            Dim pDal As New TbPermissionOfficerDAL
            Dim dt As DataTable = pDal.GetDataList("permission_id=" & PermissionID & " and officer_id = " & OfficerID, "", trans)
            If dt.Rows.Count > 0 Then
                ret = True
            End If

            Return ret
        End Function

        Public Shared Function ChkUserMenu(ByVal OfficerID As Long, ByVal MenuID As Integer, ByVal trans As SqlTransaction) As Boolean
            'ตรวจสอบว่าผู้ใช้มีสิทธิ์เข้าเมนูที่ต้องการค้นหาหรือไม่
            Dim ret As Boolean = False
            Dim oDal As New TbOfficerDAL
            oDal.GetDataByid(OfficerID, trans)

            Dim mDal As New OfficerMenuListDAL
            Dim dt As DataTable = mDal.GetDataList("officer_id = " & OfficerID & " and menu_id = " & MenuID, "", trans)
            If dt.Rows.Count > 0 Then
                ret = True
            End If

            Return ret
        End Function

        Public Shared Function UpdateStatusToInnova(ByVal status As String, ByVal refInnovaId As String, ByVal UserId As String, ByVal REQUISITION_ID As String) As Boolean
            'สำหรับการ Update สถานะการยืม-คืน กลับไปยังระบบของ Innova
            'status = B คือการยืมที่ห้องแฟ้ม
            'status = R คือ การคืนแฟ้มที่ห้องแฟ้ม
            Dim ret As Boolean = True
            Dim sql As String = ""
            Dim dt As New DataTable
            Try
                If status = "B" Then
                    sql = "exec UPDATEBORROW '" & refInnovaId & "','" & UserId & "'"
                    SqlDB.ExecuteTable(sql)
                    ret = True
                ElseIf status = "R" Then
                    dt = New DataTable
                    sql = "select id,ref_innova_id from TB_RESERVE where requidition_id = '" & REQUISITION_ID & "' and borrowstatus = 'T' and reserve_status = 'Y'"
                    dt = SqlDB.ExecuteTable(sql)
                    If dt.Rows.Count > 0 Then
                        sql = "exec UPDATERETURN '" & dt.Rows(0).Item("ref_innova_id").ToString & "','" & UserId & "'"
                        SqlDB.ExecuteTable(sql)
                        sql = "Update TB_RESERVE set reserve_status = 'N' where id = '" & dt.Rows(0).Item("id").ToString & "' and borrowstatus = 'T'"
                        SqlDB.ExecuteTable(sql)
                        ret = True
                    Else
                        sql = "exec UPDATERETURN '" & refInnovaId & "','" & UserId & "'"
                        SqlDB.ExecuteTable(sql)
                        ret = True
                    End If
                End If
            Catch ex As Exception
                ret = False
            End Try



            Return ret

        End Function

        Public Shared Function strToHex(ByVal app_no As String) As String
            Dim txt As String
            Dim bytes() As Byte
            Dim i As Integer
            Dim buffer
            ' Display the bytes.
            txt = app_no
            bytes = System.Text.Encoding.ASCII.GetBytes(txt)
            txt = ""
            For i = LBound(bytes) To UBound(bytes)

                txt = txt & Format$(Hex$(bytes(i)))      ' concatenate &H here
            Next i
            Dim intLen As Integer = txt.Length

            'If (intLen > 0) And (intLen < 8) Then
            '    For j As Integer = intLen To 8
            '        txt &= "0" & txt
            '    Next
            'ElseIf (intLen > 8) And (intLen < 16) Then
            '    For j As Integer = intLen To 16
            '        txt &= "0" & txt
            '    Next
            'ElseIf (intLen > 16) And (intLen < 24) Then
            '    For j As Integer = intLen To 24
            '        txt &= "0" & txt
            '    Next
            'ElseIf (intLen > 24) And (intLen < 32) Then
            '    For j As Integer = intLen To 32
            '        txt &= "0" & txt
            '    Next
            'End If
            Dim strFront As String = ""
            If (intLen > 0) And (intLen < 8) Then
                For j As Integer = intLen To 7
                    strFront &= "0"
                Next
            ElseIf (intLen > 8) And (intLen < 16) Then
                For j As Integer = intLen To 15
                    strFront &= "0"
                Next
            ElseIf (intLen > 16) And (intLen < 24) Then
                For j As Integer = intLen To 23
                    strFront &= "0"
                Next
            ElseIf (intLen > 24) And (intLen < 32) Then
                For j As Integer = intLen To 31
                    strFront &= "0"
                Next
            End If

            strToHex = strFront & txt
        End Function

        Public Shared Function CheckDeleteRelation(ByVal strTable As String, ByVal strColums As String, ByVal strId As String) As Boolean
            Dim ret As Boolean = True
            Dim dt As DataTable = SqlDB.ExecuteTable("SELECT * FROM " & strTable & " WHERE " & strColums & "='" & Val(strId) & "'")
            If dt.Rows.Count > 0 Then
                ret = False
            Else
                ret = True
            End If

            Return ret
        End Function
    End Class
End Namespace