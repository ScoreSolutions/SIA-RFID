Imports DAL.Table
Public Class frmBorrowByMonth

    Private Sub frmBorrowByMonth_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetMonthList(cmbMonthFrom)
        SetMonthList(cmbMonthTo)
    End Sub

    Private Sub SetMonthList(ByVal cmb As ComboBox)
        Dim dt As New DataTable
        dt.Columns.Add("month_no")
        dt.Columns.Add("month_name")

        Dim dr As DataRow = dt.NewRow
        dr("month_no") = "0"
        dr("month_name") = "Select"
        dt.Rows.Add(dr)

        For i As Integer = 0 To 11
            Dim monthName As String = ""
            Select Case i + 1
                Case "1"
                    monthName = "January"
                Case "2"
                    monthName = "February"
                Case "3"
                    monthName = "March"
                Case "4"
                    monthName = "April"
                Case "5"
                    monthName = "May"
                Case "6"
                    monthName = "June"
                Case "7"
                    monthName = "July"
                Case "8"
                    monthName = "August"
                Case "9"
                    monthName = "September"
                Case "10"
                    monthName = "October"
                Case "11"
                    monthName = "November"
                Case "12"
                    monthName = "December"
            End Select

            dr = dt.NewRow
            dr("month_no") = Format(i + 1, "00")
            dr("month_name") = monthName
            dt.Rows.Add(dr)
        Next

        cmb.DataSource = dt
        cmb.ValueMember = "month_no"
        cmb.DisplayMember = "month_name"
    End Sub

   
End Class