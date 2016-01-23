Imports System.Data.SqlClient
Imports DAL.Common.Utilities

Module ModuleConfig

    Public INIFlieName As String = "C:\Windows\SIA-RFID.ini"

    Public Function CheckConn(ByVal ConnectionString As String) As Boolean
        Dim Conn As New SqlConnection
        Try
            If Conn.State = ConnectionState.Open Then
                Conn.Close()
            End If
            Conn.ConnectionString = ConnectionString
            Conn.Open()
            Conn.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Function FixDate(ByVal StringDate As String) As String
        Dim d As String = ""
        Dim m As String = ""
        Dim y As String = ""
        If IsDate(StringDate) Then
            Dim dmy As Date = CDate(StringDate)
            d = dmy.Day
            m = dmy.Month
            y = dmy.Year
            If y > 2500 Then
                y = y - 543
            End If
            Return y.ToString & m.ToString.PadLeft(2, "0") & d.ToString.PadLeft(2, "0")
        Else
            Return ""
        End If
    End Function

    Public Function DateNowCondition() As String
        Dim d As String = ""
        Dim m As String = ""
        Dim y As String = ""
        Dim dmy As Date = Date.Now
        d = dmy.Day
        m = dmy.Month
        y = dmy.Year
        If y < 2500 Then
            y = y + 543
        End If
        Return d.ToString.PadLeft(2, "0") & "/" & m.ToString.PadLeft(2, "0") & "/" & y.ToString
    End Function

End Module
