Imports System.IO
Imports DAL.Table
Imports DAL.Common.Utilities

Public Class ReadBarcodeFromTextFile

    Function ReadTextFile(ByVal strFilePath As String) As DataTable
        Dim dt As New DataTable
        dt.Columns.Add(New DataColumn("APP_NO", GetType(String))) '------------รหัส Patent----------
        dt.Columns.Add(New DataColumn("APP_NAME", GetType(String))) '--------------ชื่อ Patent---------
        dt.Columns.Add(New DataColumn("APP_POSITION", GetType(String))) '-------------ตำแหน่งที่เก็บ-------------
        dt.Columns.Add(New DataColumn("LOAD_DATETIME", GetType(String))) '----------เวลาที่ Load เข้า -----------
        dt.Columns.Add(New DataColumn("FIND_STATUS", GetType(String))) '0 = Not found , 1 = Found , 2 = Post
        Dim dr As DataRow
        Dim line, lineTemp As String
        Dim ckLine As String()
        Dim sr As New StreamReader(strFilePath)
        Try
            ' Dim sr As New StreamReader(strFilePath)
            While (sr.Peek() > -1)
                lineTemp = sr.ReadLine
                ckLine = lineTemp.Split(",") 'มี , บาง  ใน File Check Out
                If ckLine.Length > 0 Then
                    line = ckLine(0)
                Else
                    line = lineTemp
                End If
                dr = dt.NewRow
                dr("APP_NO") = line
                dr("APP_NAME") = ""
                dr("APP_POSITION") = ""
                dr("LOAD_DATETIME") = Date.Now
                dr("FIND_STATUS") = 1
                dt.Rows.Add(dr)
            End While


        Catch e As Exception
            'Console.WriteLine("The file could not be read:")
            'Console.WriteLine(e.Message)
        Finally
            sr.Close()
        End Try
        Return dt

        'Dim IniFileName As String = Application.StartupPath & "\" & strFileName
        'Dim ini As New IniReader(IniFileName)
        'ini.Section = "Setting"
        'Dim mypath As String = ini.ReadString("txtBarcodePath ")

        'Dim dt As New DataTable
        'dt.Columns.Add(New DataColumn("Barcode", GetType(String)))
        'Dim line As String = ""
        'Try
        '    Dim sr As New StreamReader(mypath)
        '    Dim dr As DataRow
        '    While (sr.Peek() > -1)
        '        line = sr.ReadLine
        '        dr = dt.NewRow
        '        dr(0) = line
        '        dt.Rows.Add(dr)
        '    End While
        'Catch
        'End Try
        'Return dt
    End Function

    Function ReadTextFileAndInsertToTemp(ByVal strFilePath As String, ByVal reader_id As String, ByVal read_type As String) As Boolean
        Dim IsInsert As Boolean = True
        Dim dt As New DataTable
        dt = ReadTextFile(strFilePath)
        If Not dt Is Nothing AndAlso dt.Rows.Count > 0 Then

            Try
                Dim Trans As New SqlTransactionDB
                Trans.CreateTransaction()
                For i As Integer = 0 To dt.Rows.Count - 1
                    Dim tagrfid As String = dt.Rows(i).Item("APP_NO") & ""
                    Dim tbreq As New TbRequisitionDAL
                    Dim dtReq As New DataTable
                    dtReq = tbreq.GetListBySql("Select App_No From TB_REQUISTION WHERE TAGRFID like '%" & tagrfid & "%'", "", Trans.Trans)
                    Dim TAG_ID As String = ""
                    If dtReq.Rows.Count > 0 Then
                        TAG_ID = dtReq.Rows(0).Item("App_No") & ""
                    Else
                        Continue For
                    End If

                    Dim tmp As New TmpGateReaderTagDAL
                    tmp.READER_ID = reader_id
                    tmp.TAG_ID = TAG_ID
                    tmp.READ_TYPE = read_type
                    Dim a = tmp.InsertData(reader_id, Trans.Trans)
                Next
                Trans.CommitTransaction()
            Catch ex As Exception
                IsInsert = False
            End Try

            Return IsInsert
        End If
    End Function

    Function GetApplicationNoByRFID(ByVal tagrfid As String) As String
        Dim tbreq As New TbRequisitionDAL
        Dim dtReq As New DataTable
        Dim Trans As New SqlTransactionDB
        Trans.CreateTransaction()
        dtReq = tbreq.GetListBySql("Select App_No From TB_REQUISTION WHERE TAGRFID like '%" & tagrfid & "%'", "", Trans.Trans)
        Dim ApplicationNo As String = ""
        If dtReq.Rows.Count > 0 Then
            ApplicationNo = dtReq.Rows(0).Item("App_No") & ""
        Else
            ApplicationNo = ""
        End If
        Trans.CommitTransaction()
        Return ApplicationNo
    End Function

End Class
