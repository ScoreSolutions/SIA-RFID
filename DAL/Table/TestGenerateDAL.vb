﻿Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports DB = DAL.Common.Utilities.SqlDB
Imports Data.Common.Utilities
Imports Data.Table

Namespace Table
    'Represents a transaction for TEST_GENERATE table DAL.
    '[Create by  on December, 19 2010]
    Public Class TestGenerateDAL
        Public Sub TestGenerateDAL()

        End Sub
        ' TEST_GENERATE
        Const _tableName As String = "TEST_GENERATE"
        Dim _deletedRow As Int16 = 0

        'Set Common Property
        Dim _error As String = ""
        Dim _information As String = ""
        Dim _haveData As Boolean = False

        Public ReadOnly Property TableName() As String
            Get
                Return _tableName
            End Get
        End Property
        Public ReadOnly Property ErrorMessage() As String
            Get
                Return _error
            End Get
        End Property
        Public ReadOnly Property InfoMessage() As String
            Get
                Return _information
            End Get
        End Property
        Public ReadOnly Property HaveData() As Boolean
            Get
                Return _haveData
            End Get
        End Property


        'Generate Field List
        Dim _ID As Long = 0
        Dim _COLUNIQUE As String = ""
        Dim _COLINT As Long = 0
        Dim _COLVARCHAR As String = ""
        Dim _COLDATETIME As DateTime = New DateTime(1, 1, 1)
        Dim _CREATEBY As String = ""
        Dim _CREATEON As DateTime = New DateTime(1, 1, 1)
        Dim _UPDATEBY As String = ""
        Dim _UPDATEON As DateTime = New DateTime(1, 1, 1)

        'Generate Field Property 
        Public ReadOnly Property ID() As Long
            Get
                Return _ID
            End Get
        End Property
        Public Property COLUNIQUE() As String
            Get
                Return _COLUNIQUE
            End Get
            Set(ByVal value As String)
                _COLUNIQUE = value
            End Set
        End Property
        Public Property COLINT() As Long
            Get
                Return _COLINT
            End Get
            Set(ByVal value As Long)
                _COLINT = value
            End Set
        End Property
        Public Property COLVARCHAR() As String
            Get
                Return _COLVARCHAR
            End Get
            Set(ByVal value As String)
                _COLVARCHAR = value
            End Set
        End Property
        Public Property COLDATETIME() As DateTime
            Get
                Return _COLDATETIME
            End Get
            Set(ByVal value As DateTime)
                _COLDATETIME = value
            End Set
        End Property
        Public ReadOnly Property CREATEBY() As String
            Get
                Return _CREATEBY
            End Get
        End Property
        Public ReadOnly Property CREATEON() As DateTime
            Get
                Return _CREATEON
            End Get
        End Property
        Public ReadOnly Property UPDATEBY() As String
            Get
                Return _UPDATEBY
            End Get
        End Property
        Public ReadOnly Property UPDATEON() As DateTime
            Get
                Return _UPDATEON
            End Get
        End Property


        'Clear All Data
        Private Sub ClearData()
            _ID = 0
            _COLUNIQUE = ""
            _COLINT = 0
            _COLVARCHAR = ""
            _COLDATETIME = New DateTime(1, 1, 1)
            _CREATEBY = ""
            _CREATEON = New DateTime(1, 1, 1)
            _UPDATEBY = ""
            _UPDATEON = New DateTime(1, 1, 1)
        End Sub

        'Define Public Method 
        'Execute the select statement with the specified condition and return a System.Data.DataTable.
        '/// <param name=whereClause>The condition for execute select statement.</param>
        '/// <param name=orderBy>The fields for sort data.</param>
        '/// <param name=trans>The System.Data.SQLClient.SQLTransaction used by this System.Data.SQLClient.SQLCommand.</param>
        '/// <returns>The System.Data.DataTable object for specified condition.</returns>
        Public Function GetDataList(ByVal whClause As String, ByVal orderBy As String, ByVal trans As SQLTransaction) As DataTable
            Return DB.ExecuteTable(SqlSelect & IIf(whClause = "", "", " WHERE " & whClause) & IIF(orderBy = "", "", " ORDER BY  " & orderBy), trans)
        End Function


        'Execute the select statement with the specified condition and return a System.Data.DataTable.
        '/// <param name=whereClause>The condition for execute select statement.</param>
        '/// <param name=orderBy>The fields for sort data.</param>
        '/// <param name=trans>The System.Data.SQLClient.SQLTransaction used by this System.Data.SQLClient.SQLCommand.</param>
        '/// <returns>The System.Data.DataTable object for specified condition.</returns>
        Public Function GetListBySql(ByVal Sql As String, ByVal orderBy As String, ByVal trans As SQLTransaction) As DataTable
            Return DB.ExecuteTable(Sql & IIF(orderBy = "", "", " ORDER BY  " & orderBy), trans)
        End Function


        '/// Returns an indication whether the current data is inserted into TEST_GENERATE table successfully.
        '/// <param name=userID>The current user.</param>
        '/// <param name=trans>The System.Data.SQLClient.SQLTransaction used by this System.Data.SQLClient.SQLCommand.</param>
        '/// <returns>true if insert data successfully; otherwise, false.</returns>
        Public Function InsertData(ByVal UserID As String, ByVal trans As SQLTransaction) As Boolean
            _id = DB.GetNextID("id", tableName, trans)
            _CREATEBY = UserID
            _CREATEON = DateTime.Now
            Return doInsert(trans)
        End Function


        '/// Returns an indication whether the current data is updated to TEST_GENERATE table successfully.
        '/// <param name=userID>The current user.</param>
        '/// <param name=trans>The System.Data.SQLClient.SQLTransaction used by this System.Data.SQLClient.SQLCommand.</param>
        '/// <returns>true if update data successfully; otherwise, false.</returns>
        Public Function UpdateByid(ByVal UserID As String, ByVal trans As SQLTransaction) As Boolean
            _UPDATEBY = UserID
            _UPDATEON = DateTime.Now
            Return doUpdate("id = " & DB.SetDouble(_id) & " ", trans)
        End Function


        '/// Returns an indication whether the current data is deleted from TEST_GENERATE table successfully.
        '/// <param name=trans>The System.Data.SQLClient.SQLTransaction used by this System.Data.SQLClient.SQLCommand.</param>
        '/// <returns>true if delete data successfully; otherwise, false.</returns>
        Public Function DeleteByid(ByVal trans As SQLTransaction) As Boolean
            Return doDelete("id = " & DB.SetDouble(_id) & " ", trans)
        End Function


        '/// Returns an indication whether the record of TEST_GENERATE by specified id key is retrieved successfully.
        '/// <param name=cid>The id key.</param>
        '/// <param name=trans>The System.Data.SQLClient.SQLTransaction used by this System.Data.SQLClient.SQLCommand.</param>
        '/// <returns>true if data is retrieved successfully; otherwise, false.</returns>
        Public Function ChkDataByid(ByVal cid As Long, ByVal trans As SQLTransaction) As Boolean
            Return doChkData("id = " & DB.SetDouble(cid) & " ", trans)
        End Function


        '/// Returns an indication whether the record and Mapping field to Data Class of TEST_GENERATE by specified id key is retrieved successfully.
        '/// <param name=cid>The id key.</param>
        '/// <param name=trans>The System.Data.SQLClient.SQLTransaction used by this System.Data.SQLClient.SQLCommand.</param>
        '/// <returns>true if data is retrieved successfully; otherwise, false.</returns>
        Public Function GetDataByid(ByVal cid As Long, ByVal trans As SQLTransaction) As TestGenerateData
            Return doGetMappingData("id = " & DB.SetDouble(cid) & " ", trans)
        End Function


        '/// Returns an indication whether the current data is updated to TEST_GENERATE table successfully.
        '/// <param name=userID>The current user.</param>
        '/// <param name=trans>The System.Data.SQLClient.SQLTransaction used by this System.Data.SQLClient.SQLCommand.</param>
        '/// <returns>true if update data successfully; otherwise, false.</returns>
        Public Function UpdateByCOLINT_COLUNIQUE(ByVal cCOLINT As Long, ByVal cCOLUNIQUE As String, ByVal UserID As String, ByVal trans As SQLTransaction) As Boolean
            _UPDATEBY = UserID
            _UPDATEON = DateTime.Now
            Return doUpdate("COLINT = " & DB.SetDouble(cCOLINT) & " AND COLUNIQUE = " & DB.SetString(cCOLUNIQUE), trans)
        End Function


        '/// Returns an indication whether the current data is deleted from TEST_GENERATE table successfully.
        '/// <param name=trans>The System.Data.SQLClient.SQLTransaction used by this System.Data.SQLClient.SQLCommand.</param>
        '/// <returns>true if delete data successfully; otherwise, false.</returns>
        Public Function DeleteByCOLINT_COLUNIQUE(ByVal cCOLINT As Long, ByVal cCOLUNIQUE As String, ByVal trans As SQLTransaction) As Boolean
            Return doDelete("COLINT = " & DB.SetDouble(cCOLINT) & " AND COLUNIQUE = " & DB.SetString(cCOLUNIQUE), trans)
        End Function


        '/// Returns an indication whether the record of TEST_GENERATE by specified COLINT_COLUNIQUE key is retrieved successfully.
        '/// <param name=cCOLINT_COLUNIQUE>The COLINT_COLUNIQUE key.</param>
        '/// <param name=trans>The System.Data.SQLClient.SQLTransaction used by this System.Data.SQLClient.SQLCommand.</param>
        '/// <returns>true if data is retrieved successfully; otherwise, false.</returns>
        Public Function ChkDataByCOLINT_COLUNIQUE(ByVal cCOLINT As Long, ByVal cCOLUNIQUE As String, ByVal trans As SQLTransaction) As Boolean
            Return doChkData("COLINT = " & DB.SetDouble(cCOLINT) & " AND COLUNIQUE = " & DB.SetString(cCOLUNIQUE), trans)
        End Function

        '/// Returns an indication whether the Data Class of TEST_GENERATE by specified COLINT_COLUNIQUE key is retrieved successfully.
        '/// <param name=cCOLINT_COLUNIQUE>The COLINT_COLUNIQUE key.</param>
        '/// <param name=trans>The System.Data.SQLClient.SQLTransaction used by this System.Data.SQLClient.SQLCommand.</param>
        '/// <returns>true if data is retrieved successfully; otherwise, false.</returns>
        Public Function GetDataByCOLINT_COLUNIQUE(ByVal cCOLINT As Long, ByVal cCOLUNIQUE As String, ByVal trans As SQLTransaction) As TestGenerateData
            Return doGetMappingData("COLINT = " & DB.SetDouble(cCOLINT) & " AND COLUNIQUE = " & DB.SetString(cCOLUNIQUE), trans)
        End Function

        '/// Returns an indication whether the record of TEST_GENERATE by specified condition is retrieved successfully.
        '/// <param name=whText>The condition specify the deleting record(s).</param>
        '/// <param name=trans>The System.Data.SQLClient.SQLTransaction used by this System.Data.SQLClient.SQLCommand.</param>
        '/// <returns>true if data is retrieved successfully; otherwise, false.</returns>
        Public Function ChkDataByWhere(ByVal whText As String, ByVal trans As SQLTransaction) As Boolean
            Return doChkData(whText, trans)
        End Function


        '/// Returns an indication whether the Data Class of TEST_GENERATE by specified condition is retrieved successfully.
        '/// <param name=whText>The condition specify the deleting record(s).</param>
        '/// <param name=trans>The System.Data.SQLClient.SQLTransaction used by this System.Data.SQLClient.SQLCommand.</param>
        '/// <returns>true if data is retrieved successfully; otherwise, false.</returns>
        Public Function GetDataListByWhere(ByVal whText As String, ByVal trans As SQLTransaction) As TestGenerateData()
            Return doGetMappingDataList(whText, trans)
        End Function



        '/// Returns an indication whether the current data is inserted into TEST_GENERATE table successfully.
        '/// <param name=trans>The System.Data.SQLClient.SQLTransaction used by this System.Data.SQLClient.SQLCommand.</param>
        '/// <returns>true if insert data successfully; otherwise, false.</returns>
        Private Function doInsert(ByVal trans As SQLTransaction) As Boolean
            Dim ret As Boolean = True
            If _haveData = False Then
                Try
                    ret = (DB.ExecuteNonQuery(SqlInsert, trans) > 0)
                    If ret = False Then
                        _error = MessageResources.MSGEN001
                    Else
                        _haveData = True
                    End If
                    _information = MessageResources.MSGIN001
                Catch ex As ApplicationException
                    ret = False
                    _error = ex.Message
                Catch ex As Exception
                    ex.ToString()
                    ret = False
                    _error = MessageResources.MSGEC101
                End Try
            Else
                ret = False
                _error = MessageResources.MSGEN002
            End If

            Return ret
        End Function


        '/// Returns an indication whether the current data is updated to TEST_GENERATE table successfully.
        '/// <param name=whText>The condition specify the updating record(s).</param>
        '/// <param name=trans>The System.Data.SQLClient.SQLTransaction used by this System.Data.SQLClient.SQLCommand.</param>
        '/// <returns>true if update data successfully; otherwise, false.</returns>
        Private Function doUpdate(ByVal whText As String, ByVal trans As SQLTransaction) As Boolean
            Dim ret As Boolean = True
            If _haveData = True Then
                If whText.Trim() <> "" Then
                    Dim tmpWhere As String = " Where " & whText
                    Try
                        ret = (DB.ExecuteNonQuery(SqlUpdate & tmpWhere, trans) > 0)
                        If ret = False Then
                            _error = MessageResources.MSGEU001
                        End If
                        _information = MessageResources.MSGIU001
                    Catch ex As ApplicationException
                        ret = False
                        _error = ex.Message
                    Catch ex As Exception
                        ex.ToString()
                        ret = False
                        _error = MessageResources.MSGEC102
                    End Try
                Else
                    ret = False
                    _error = MessageResources.MSGEU003
                End If
            Else
                ret = False
                _error = MessageResources.MSGEU002
            End If

            Return ret
        End Function


        '/// Returns an indication whether the current data is deleted from TEST_GENERATE table successfully.
        '/// <param name=whText>The condition specify the deleting record(s).</param>
        '/// <param name=trans>The System.Data.SQLClient.SQLTransaction used by this System.Data.SQLClient.SQLCommand.</param>
        '/// <returns>true if delete data successfully; otherwise, false.</returns>
        Private Function doDelete(ByVal whText As String, ByVal trans As SQLTransaction) As Boolean
            Dim ret As Boolean = True
            If _haveData = True Then
                If whText.Trim() <> "" Then
                    Dim tmpWhere As String = " Where " & whText
                    Try
                        ret = (DB.ExecuteNonQuery(SqlDelete & tmpWhere, trans) > 0)
                        If ret = False Then
                            _error = MessageResources.MSGED001
                        End If
                        _information = MessageResources.MSGID001
                    Catch ex As ApplicationException
                        ret = False
                        _error = ex.Message
                    Catch ex As Exception
                        ex.ToString()
                        ret = False
                        _error = MessageResources.MSGEC103
                    End Try
                Else
                    ret = False
                    _error = MessageResources.MSGED003
                End If
            Else
                ret = False
                _error = MessageResources.MSGEU002
            End If

            Return ret
        End Function


        '/// Returns an indication whether the record of TEST_GENERATE by specified condition is retrieved successfully.
        '/// <param name=whText>The condition specify the deleting record(s).</param>
        '/// <param name=trans>The System.Data.SQLClient.SQLTransaction used by this System.Data.SQLClient.SQLCommand.</param>
        '/// <returns>true if data is retrieved successfully; otherwise, false.</returns>
        Private Function doChkData(ByVal whText As String, ByVal trans As SQLTransaction) As Boolean
            Dim ret As Boolean = True
            ClearData()
            _haveData = False
            If whText.Trim() <> "" Then
                Dim tmpWhere As String = " WHERE " & whText
                Dim Rdr As SQLDataReader
                Try
                    Rdr = DB.ExecuteReader(SqlSelect() & tmpWhere, trans)
                    If Rdr.Read() Then
                        _haveData = True
                        If Convert.IsDBNull(Rdr("id")) = False Then _id = Convert.ToInt64(Rdr("id"))
                        If Convert.IsDBNull(Rdr("colunique")) = False Then _colunique = Rdr("colunique").ToString()
                        If Convert.IsDBNull(Rdr("colint")) = False Then _colint = Convert.ToInt64(Rdr("colint"))
                        If Convert.IsDBNull(Rdr("colvarchar")) = False Then _colvarchar = Rdr("colvarchar").ToString()
                        If Convert.IsDBNull(Rdr("coldatetime")) = False Then _coldatetime = Convert.ToDateTime(Rdr("coldatetime"))
                        If Convert.IsDBNull(Rdr("createby")) = False Then _createby = Rdr("createby").ToString()
                        If Convert.IsDBNull(Rdr("createon")) = False Then _createon = Convert.ToDateTime(Rdr("createon"))
                        If Convert.IsDBNull(Rdr("updateby")) = False Then _updateby = Rdr("updateby").ToString()
                        If Convert.IsDBNull(Rdr("updateon")) = False Then _updateon = Convert.ToDateTime(Rdr("updateon"))
                    Else
                        ret = False
                        _error = MessageResources.MSGEV002
                    End If

                    Rdr.Close()
                Catch ex As Exception
                    ex.ToString()
                    ret = False
                    _error = MessageResources.MSGEC104
                    If Rdr IsNot Nothing And Rdr.IsClosed = False Then
                        Rdr.Close()
                    End If
                End Try
            Else
                ret = False
                _error = MessageResources.MSGEV001
            End If

            Return ret
        End Function
        '/// Returns an indication whether the Class Data of TEST_GENERATE by specified condition is retrieved successfully.
        '/// <param name=whText>The condition specify the deleting record(s).</param>
        '/// <param name=trans>The System.Data.SQLClient.SQLTransaction used by this System.Data.SQLClient.SQLCommand.</param>
        '/// <returns>true if data is retrieved successfully; otherwise, false.</returns>
        Private Function doMappingData(ByVal ret As TestGenerateData, ByVal RDr As DataRow) As TestGenerateData
            If Convert.IsDBNull(Rdr("id")) = False Then ret.ID = Convert.ToInt64(Rdr("id"))
            If Convert.IsDBNull(Rdr("colunique")) = False Then ret.COLUNIQUE = Rdr("colunique").ToString()
            If Convert.IsDBNull(Rdr("colint")) = False Then ret.COLINT = Convert.ToInt64(Rdr("colint"))
            If Convert.IsDBNull(Rdr("colvarchar")) = False Then ret.COLVARCHAR = Rdr("colvarchar").ToString()
            If Convert.IsDBNull(Rdr("coldatetime")) = False Then ret.COLDATETIME = Convert.ToDateTime(Rdr("coldatetime"))
            If Convert.IsDBNull(Rdr("createby")) = False Then ret.CREATEBY = Rdr("createby").ToString()
            If Convert.IsDBNull(Rdr("createon")) = False Then ret.CREATEON = Convert.ToDateTime(Rdr("createon"))
            If Convert.IsDBNull(Rdr("updateby")) = False Then ret.UPDATEBY = Rdr("updateby").ToString()
            If Convert.IsDBNull(Rdr("updateon")) = False Then ret.UPDATEON = Convert.ToDateTime(Rdr("updateon"))
            Return ret
        End Function


        '/// Returns an indication whether the record of TEST_GENERATE by specified condition is retrieved successfully.
        '/// <param name=whText>The condition specify the deleting record(s).</param>
        '/// <param name=trans>The System.Data.SQLClient.SQLTransaction used by this System.Data.SQLClient.SQLCommand.</param>
        '/// <returns>true if data is retrieved successfully; otherwise, false.</returns>
        Private Function doGetMappingData(ByVal whText As String, ByVal trans As SQLTransaction) As TestGenerateData
            ClearData()
            _haveData = False
            Dim ret As New TestGenerateData
            If whText.Trim() <> "" Then
                Dim tmpWhere As String = " WHERE " & whText
                Dim Rdt As DataTable
                Try
                    Rdt = DB.ExecuteTable(SqlSelect() & tmpWhere, trans)
                    If Rdt.Rows.Count = 1 Then
                        _haveData = True
                        Dim RDr As DataRow
                        RDr = Rdt.Rows(0)
                        ret = doMappingData(ret, RDr)
                    Else
                        _haveData = False
                        _error = MessageResources.MSGEV002
                    End If

                    Rdt = Nothing
                Catch ex As Exception
                    ex.ToString()
                    _haveData = False
                    _error = MessageResources.MSGEC104
                    If Rdt IsNot Nothing Then
                        Rdt = Nothing
                    End If
                End Try
            Else
                _haveData = False
                _error = MessageResources.MSGEV001
            End If

            Return ret
        End Function


        '/// Returns an indication whether the Data Class of TEST_GENERATE by specified condition is retrieved successfully.
        '/// <param name=whText>The condition specify the deleting record(s).</param>
        '/// <param name=trans>The System.Data.SQLClient.SQLTransaction used by this System.Data.SQLClient.SQLCommand.</param>
        '/// <returns>true if data is retrieved successfully; otherwise, false.</returns>
        Private Function doGetMappingDataList(ByVal whText As String, ByVal trans As SQLTransaction) As TestGenerateData()
            ClearData()
            _haveData = False
            Dim ret() As TestGenerateData
            If whText.Trim() <> "" Then
                Dim tmpWhere As String = " WHERE " & whText
                Dim Rdt As DataTable
                Try
                    Rdt = DB.ExecuteTable(SqlSelect() & tmpWhere, trans)
                    If Rdt.Rows.Count > 0 Then
                        For i As int16 = 0 To Rdt.Rows.Count - 1
                            _haveData = True
                            Dim RDr As DataRow
                            RDr = Rdt.Rows(i)
                            ret(i) = doMappingData(ret(i), RDr)
                        Next
                    Else
                        _haveData = False
                        _error = MessageResources.MSGEV002
                    End If

                    Rdt = Nothing
                Catch ex As Exception
                    ex.ToString()
                    _haveData = False
                    _error = MessageResources.MSGEC104
                    If Rdt IsNot Nothing Then
                        Rdt = Nothing
                    End If
                End Try
            Else
                _haveData = False
                _error = MessageResources.MSGEV001
            End If

            Return ret
        End Function



        ' SQL Statements


        'Get Insert Statement for table TEST_GENERATE
        Private ReadOnly Property SqlInsert() As String
            Get
                Dim Sql As String = ""
                Sql += "INSERT INTO " & tableName & " (ID, COLUNIQUE, COLINT, COLVARCHAR, COLDATETIME, CREATEBY, CREATEON, UPDATEBY, UPDATEON)"
                Sql += " VALUES("
                sql += DB.SetDouble(_ID) & ", "
                sql += DB.SetString(_COLUNIQUE) & ", "
                sql += DB.SetDouble(_COLINT) & ", "
                sql += DB.SetString(_COLVARCHAR) & ", "
                sql += DB.SetDateTime(_COLDATETIME) & ", "
                sql += DB.SetString(_CREATEBY) & ", "
                sql += DB.SetDateTime(_CREATEON) & ", "
                sql += DB.SetString(_UPDATEBY) & ", "
                sql += DB.SetDateTime(_UPDATEON)
                sql += ")"
                Return sql
            End Get
        End Property


        'Get update statement form table TEST_GENERATE
        Private ReadOnly Property SqlUpdate() As String
            Get
                Dim Sql As String = ""
                Sql += "UPDATE " & tableName & " SET "
                Sql += "ID = " & DB.SetDouble(_ID) & ", "
                Sql += "COLUNIQUE = " & DB.SetString(_COLUNIQUE) & ", "
                Sql += "COLINT = " & DB.SetDouble(_COLINT) & ", "
                Sql += "COLVARCHAR = " & DB.SetString(_COLVARCHAR) & ", "
                Sql += "COLDATETIME = " & DB.SetDateTime(_COLDATETIME) & ", "
                Sql += "CREATEBY = " & DB.SetString(_CREATEBY) & ", "
                Sql += "CREATEON = " & DB.SetDateTime(_CREATEON) & ", "
                Sql += "UPDATEBY = " & DB.SetString(_UPDATEBY) & ", "
                Sql += "UPDATEON = " & DB.SetDateTime(_UPDATEON) + ""
                Return Sql
            End Get
        End Property


        'Get Delete Record in table TEST_GENERATE
        Private ReadOnly Property SqlDelete() As String
            Get
                Dim Sql As String = "DELETE FROM " & tableName
                Return Sql
            End Get
        End Property


        'Get Select Statement for table TEST_GENERATE
        Private ReadOnly Property SqlSelect() As String
            Get
                Dim Sql As String = "SELECT * FROM " & tableName
                Return Sql
            End Get
        End Property


    End Class
End Namespace