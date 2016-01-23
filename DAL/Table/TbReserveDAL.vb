﻿Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports DB = DAL.Common.Utilities.SqlDB
Imports Data.Common.Utilities
Imports Data.Table

Namespace Table
    'Represents a transaction for TB_RESERVE table DAL.
    '[Create by  on December, 25 2010]
    Public Class TbReserveDAL
        Public Sub TbReserveDAL()

        End Sub
        ' TB_RESERVE
        Const _tableName As String = "TB_RESERVE"
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
        Dim _REQUIDITION_ID As Long = 0
        Dim _MEMBER_ID As String = ""
        Dim _MEMBER_NAME As String = ""
        Dim _RESERVE_DATE As DateTime = New DateTime(1, 1, 1)
        Dim _RESERVE_ORDER As Integer = 0
        Dim _RESERVE_JOB_ID As Long = 0
        Dim _REF_INNOVA_ID As Long = 0
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
        Public Property REQUIDITION_ID() As Long
            Get
                Return _REQUIDITION_ID
            End Get
            Set(ByVal value As Long)
                _REQUIDITION_ID = value
            End Set
        End Property
        Public Property MEMBER_ID() As String
            Get
                Return _MEMBER_ID
            End Get
            Set(ByVal value As String)
                _MEMBER_ID = value
            End Set
        End Property
        Public Property MEMBER_NAME() As String
            Get
                Return _MEMBER_NAME
            End Get
            Set(ByVal value As String)
                _MEMBER_NAME = value
            End Set
        End Property
        Public Property RESERVE_DATE() As DateTime
            Get
                Return _RESERVE_DATE
            End Get
            Set(ByVal value As DateTime)
                _RESERVE_DATE = value
            End Set
        End Property
        Public Property RESERVE_ORDER() As Integer
            Get
                Return _RESERVE_ORDER
            End Get
            Set(ByVal value As Integer)
                _RESERVE_ORDER = value
            End Set
        End Property
        Public Property RESERVE_JOB_ID() As Long
            Get
                Return _RESERVE_JOB_ID
            End Get
            Set(ByVal value As Long)
                _RESERVE_JOB_ID = value
            End Set
        End Property
        Public Property REF_INNOVA_ID() As Long
            Get
                Return _REF_INNOVA_ID
            End Get
            Set(ByVal value As Long)
                _REF_INNOVA_ID = value
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
            _REQUIDITION_ID = 0
            _MEMBER_ID = ""
            _MEMBER_NAME = ""
            _RESERVE_DATE = New DateTime(1, 1, 1)
            _RESERVE_ORDER = 0
            _RESERVE_JOB_ID = 0
            _REF_INNOVA_ID = 0
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


        '/// Returns an indication whether the current data is inserted into TB_RESERVE table successfully.
        '/// <param name=userID>The current user.</param>
        '/// <param name=trans>The System.Data.SQLClient.SQLTransaction used by this System.Data.SQLClient.SQLCommand.</param>
        '/// <returns>true if insert data successfully; otherwise, false.</returns>
        Public Function InsertData(ByVal UserID As String, ByVal trans As SQLTransaction) As Boolean
            _id = DB.GetNextID("id", tableName, trans)
            _CREATEBY = UserID
            _CREATEON = DateTime.Now
            Return doInsert(trans)
        End Function


        '/// Returns an indication whether the current data is updated to TB_RESERVE table successfully.
        '/// <param name=userID>The current user.</param>
        '/// <param name=trans>The System.Data.SQLClient.SQLTransaction used by this System.Data.SQLClient.SQLCommand.</param>
        '/// <returns>true if update data successfully; otherwise, false.</returns>
        Public Function UpdateByid(ByVal UserID As String, ByVal trans As SQLTransaction) As Boolean
            _UPDATEBY = UserID
            _UPDATEON = DateTime.Now
            Return doUpdate("id = " & DB.SetDouble(_id) & " ", trans)
        End Function


        '/// Returns an indication whether the current data is deleted from TB_RESERVE table successfully.
        '/// <param name=trans>The System.Data.SQLClient.SQLTransaction used by this System.Data.SQLClient.SQLCommand.</param>
        '/// <returns>true if delete data successfully; otherwise, false.</returns>
        Public Function DeleteByid(ByVal trans As SQLTransaction) As Boolean
            Return doDelete("id = " & DB.SetDouble(_id) & " ", trans)
        End Function


        '/// Returns an indication whether the record of TB_RESERVE by specified id key is retrieved successfully.
        '/// <param name=cid>The id key.</param>
        '/// <param name=trans>The System.Data.SQLClient.SQLTransaction used by this System.Data.SQLClient.SQLCommand.</param>
        '/// <returns>true if data is retrieved successfully; otherwise, false.</returns>
        Public Function ChkDataByid(ByVal cid As Long, ByVal trans As SQLTransaction) As Boolean
            Return doChkData("id = " & DB.SetDouble(cid) & " ", trans)
        End Function


        '/// Returns an indication whether the record and Mapping field to Data Class of TB_RESERVE by specified id key is retrieved successfully.
        '/// <param name=cid>The id key.</param>
        '/// <param name=trans>The System.Data.SQLClient.SQLTransaction used by this System.Data.SQLClient.SQLCommand.</param>
        '/// <returns>true if data is retrieved successfully; otherwise, false.</returns>
        Public Function GetDataByid(ByVal cid As Long, ByVal trans As SQLTransaction) As TbReserveData
            Return doGetMappingData("id = " & DB.SetDouble(cid) & " ", trans)
        End Function


        '/// Returns an indication whether the current data is updated to TB_RESERVE table successfully.
        '/// <param name=userID>The current user.</param>
        '/// <param name=trans>The System.Data.SQLClient.SQLTransaction used by this System.Data.SQLClient.SQLCommand.</param>
        '/// <returns>true if update data successfully; otherwise, false.</returns>
        Public Function UpdateByREQUIDITION_ID_RESERVE_JOB_ID(ByVal cREQUIDITION_ID As Long, ByVal cRESERVE_JOB_ID As Long, ByVal UserID As String, ByVal trans As SQLTransaction) As Boolean
            _UPDATEBY = UserID
            _UPDATEON = DateTime.Now
            Return doUpdate("REQUIDITION_ID = " & DB.SetDouble(cREQUIDITION_ID) & " AND RESERVE_JOB_ID = " & DB.SetDouble(cRESERVE_JOB_ID), trans)
        End Function


        '/// Returns an indication whether the current data is deleted from TB_RESERVE table successfully.
        '/// <param name=trans>The System.Data.SQLClient.SQLTransaction used by this System.Data.SQLClient.SQLCommand.</param>
        '/// <returns>true if delete data successfully; otherwise, false.</returns>
        Public Function DeleteByREQUIDITION_ID_RESERVE_JOB_ID(ByVal cREQUIDITION_ID As Long, ByVal cRESERVE_JOB_ID As Long, ByVal trans As SQLTransaction) As Boolean
            Return doDelete("REQUIDITION_ID = " & DB.SetDouble(cREQUIDITION_ID) & " AND RESERVE_JOB_ID = " & DB.SetDouble(cRESERVE_JOB_ID), trans)
        End Function


        '/// Returns an indication whether the record of TB_RESERVE by specified REQUIDITION_ID_RESERVE_JOB_ID key is retrieved successfully.
        '/// <param name=cREQUIDITION_ID_RESERVE_JOB_ID>The REQUIDITION_ID_RESERVE_JOB_ID key.</param>
        '/// <param name=trans>The System.Data.SQLClient.SQLTransaction used by this System.Data.SQLClient.SQLCommand.</param>
        '/// <returns>true if data is retrieved successfully; otherwise, false.</returns>
        Public Function ChkDataByREQUIDITION_ID_RESERVE_JOB_ID(ByVal cREQUIDITION_ID As Long, ByVal cRESERVE_JOB_ID As Long, ByVal trans As SQLTransaction) As Boolean
            Return doChkData("REQUIDITION_ID = " & DB.SetDouble(cREQUIDITION_ID) & " AND RESERVE_JOB_ID = " & DB.SetDouble(cRESERVE_JOB_ID), trans)
        End Function

        '/// Returns an indication whether the Data Class of TB_RESERVE by specified REQUIDITION_ID_RESERVE_JOB_ID key is retrieved successfully.
        '/// <param name=cREQUIDITION_ID_RESERVE_JOB_ID>The REQUIDITION_ID_RESERVE_JOB_ID key.</param>
        '/// <param name=trans>The System.Data.SQLClient.SQLTransaction used by this System.Data.SQLClient.SQLCommand.</param>
        '/// <returns>true if data is retrieved successfully; otherwise, false.</returns>
        Public Function GetDataByREQUIDITION_ID_RESERVE_JOB_ID(ByVal cREQUIDITION_ID As Long, ByVal cRESERVE_JOB_ID As Long, ByVal trans As SQLTransaction) As TbReserveData
            Return doGetMappingData("REQUIDITION_ID = " & DB.SetDouble(cREQUIDITION_ID) & " AND RESERVE_JOB_ID = " & DB.SetDouble(cRESERVE_JOB_ID), trans)
        End Function

        '/// Returns an indication whether the record of TB_RESERVE by specified condition is retrieved successfully.
        '/// <param name=whText>The condition specify the deleting record(s).</param>
        '/// <param name=trans>The System.Data.SQLClient.SQLTransaction used by this System.Data.SQLClient.SQLCommand.</param>
        '/// <returns>true if data is retrieved successfully; otherwise, false.</returns>
        Public Function ChkDataByWhere(ByVal whText As String, ByVal trans As SQLTransaction) As Boolean
            Return doChkData(whText, trans)
        End Function



        '/// Returns an indication whether the current data is inserted into TB_RESERVE table successfully.
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


        '/// Returns an indication whether the current data is updated to TB_RESERVE table successfully.
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


        '/// Returns an indication whether the current data is deleted from TB_RESERVE table successfully.
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


        '/// Returns an indication whether the record of TB_RESERVE by specified condition is retrieved successfully.
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
                        If Convert.IsDBNull(Rdr("requidition_id")) = False Then _requidition_id = Convert.ToInt64(Rdr("requidition_id"))
                        If Convert.IsDBNull(Rdr("member_id")) = False Then _member_id = Rdr("member_id").ToString()
                        If Convert.IsDBNull(Rdr("member_name")) = False Then _member_name = Rdr("member_name").ToString()
                        If Convert.IsDBNull(Rdr("reserve_date")) = False Then _reserve_date = Convert.ToDateTime(Rdr("reserve_date"))
                        If Convert.IsDBNull(Rdr("reserve_order")) = False Then _reserve_order = Convert.ToInt32(Rdr("reserve_order"))
                        If Convert.IsDBNull(Rdr("reserve_job_id")) = False Then _reserve_job_id = Convert.ToInt64(Rdr("reserve_job_id"))
                        If Convert.IsDBNull(Rdr("ref_innova_id")) = False Then _ref_innova_id = Convert.ToInt64(Rdr("ref_innova_id"))
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
        '/// Returns an indication whether the Class Data of TB_RESERVE by specified condition is retrieved successfully.
        '/// <param name=whText>The condition specify the deleting record(s).</param>
        '/// <param name=trans>The System.Data.SQLClient.SQLTransaction used by this System.Data.SQLClient.SQLCommand.</param>
        '/// <returns>true if data is retrieved successfully; otherwise, false.</returns>
        Private Function doMappingData(ByVal ret As TbReserveData, ByVal RDr As DataRow) As TbReserveData
            If Convert.IsDBNull(Rdr("id")) = False Then ret.ID = Convert.ToInt64(Rdr("id"))
            If Convert.IsDBNull(Rdr("requidition_id")) = False Then ret.REQUIDITION_ID = Convert.ToInt64(Rdr("requidition_id"))
            If Convert.IsDBNull(Rdr("member_id")) = False Then ret.MEMBER_ID = Rdr("member_id").ToString()
            If Convert.IsDBNull(Rdr("member_name")) = False Then ret.MEMBER_NAME = Rdr("member_name").ToString()
            If Convert.IsDBNull(Rdr("reserve_date")) = False Then ret.RESERVE_DATE = Convert.ToDateTime(Rdr("reserve_date"))
            If Convert.IsDBNull(Rdr("reserve_order")) = False Then ret.RESERVE_ORDER = Convert.ToInt32(Rdr("reserve_order"))
            If Convert.IsDBNull(Rdr("reserve_job_id")) = False Then ret.RESERVE_JOB_ID = Convert.ToInt64(Rdr("reserve_job_id"))
            If Convert.IsDBNull(Rdr("ref_innova_id")) = False Then ret.REF_INNOVA_ID = Convert.ToInt64(Rdr("ref_innova_id"))
            If Convert.IsDBNull(Rdr("createby")) = False Then ret.CREATEBY = Rdr("createby").ToString()
            If Convert.IsDBNull(Rdr("createon")) = False Then ret.CREATEON = Convert.ToDateTime(Rdr("createon"))
            If Convert.IsDBNull(Rdr("updateby")) = False Then ret.UPDATEBY = Rdr("updateby").ToString()
            If Convert.IsDBNull(Rdr("updateon")) = False Then ret.UPDATEON = Convert.ToDateTime(Rdr("updateon"))
            Return ret
        End Function


        '/// Returns an indication whether the record of TB_RESERVE by specified condition is retrieved successfully.
        '/// <param name=whText>The condition specify the deleting record(s).</param>
        '/// <param name=trans>The System.Data.SQLClient.SQLTransaction used by this System.Data.SQLClient.SQLCommand.</param>
        '/// <returns>true if data is retrieved successfully; otherwise, false.</returns>
        Private Function doGetMappingData(ByVal whText As String, ByVal trans As SQLTransaction) As TbReserveData
            ClearData()
            _haveData = False
            Dim ret As New TbReserveData
            If whText.Trim() <> "" Then
                Dim tmpWhere As String = " WHERE " & whText
                Dim Rdt As DataTable
                Try
                    Rdt = DB.ExecuteTable(SqlSelect() & tmpWhere, trans)
                    If Rdt.Rows.Count = 1 Then
                        _haveData = True
                        Dim RDr As DataRow
                        RDr = Rdt.Rows(0)
                        doChkData(whText, trans)
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



        ' SQL Statements


        'Get Insert Statement for table TB_RESERVE
        Private ReadOnly Property SqlInsert() As String
            Get
                Dim Sql As String = ""
                Sql += "INSERT INTO " & tableName & " (ID, REQUIDITION_ID, MEMBER_ID, MEMBER_NAME, RESERVE_DATE, RESERVE_ORDER, RESERVE_JOB_ID, REF_INNOVA_ID, CREATEBY, CREATEON, UPDATEBY, UPDATEON)"
                Sql += " VALUES("
                sql += DB.SetDouble(_ID) & ", "
                sql += DB.SetDouble(_REQUIDITION_ID) & ", "
                sql += DB.SetString(_MEMBER_ID) & ", "
                sql += DB.SetString(_MEMBER_NAME) & ", "
                sql += DB.SetDateTime(_RESERVE_DATE) & ", "
                sql += DB.SetDouble(_RESERVE_ORDER) & ", "
                sql += DB.SetDouble(_RESERVE_JOB_ID) & ", "
                sql += DB.SetDouble(_REF_INNOVA_ID) & ", "
                sql += DB.SetString(_CREATEBY) & ", "
                sql += DB.SetDateTime(_CREATEON) & ", "
                sql += DB.SetString(_UPDATEBY) & ", "
                sql += DB.SetDateTime(_UPDATEON)
                sql += ")"
                Return sql
            End Get
        End Property


        'Get update statement form table TB_RESERVE
        Private ReadOnly Property SqlUpdate() As String
            Get
                Dim Sql As String = ""
                Sql += "UPDATE " & tableName & " SET "
                Sql += "ID = " & DB.SetDouble(_ID) & ", "
                Sql += "REQUIDITION_ID = " & DB.SetDouble(_REQUIDITION_ID) & ", "
                Sql += "MEMBER_ID = " & DB.SetString(_MEMBER_ID) & ", "
                Sql += "MEMBER_NAME = " & DB.SetString(_MEMBER_NAME) & ", "
                Sql += "RESERVE_DATE = " & DB.SetDateTime(_RESERVE_DATE) & ", "
                Sql += "RESERVE_ORDER = " & DB.SetDouble(_RESERVE_ORDER) & ", "
                Sql += "RESERVE_JOB_ID = " & DB.SetDouble(_RESERVE_JOB_ID) & ", "
                Sql += "REF_INNOVA_ID = " & DB.SetDouble(_REF_INNOVA_ID) & ", "
                Sql += "CREATEBY = " & DB.SetString(_CREATEBY) & ", "
                Sql += "CREATEON = " & DB.SetDateTime(_CREATEON) & ", "
                Sql += "UPDATEBY = " & DB.SetString(_UPDATEBY) & ", "
                Sql += "UPDATEON = " & DB.SetDateTime(_UPDATEON) + ""
                Return Sql
            End Get
        End Property


        'Get Delete Record in table TB_RESERVE
        Private ReadOnly Property SqlDelete() As String
            Get
                Dim Sql As String = "DELETE FROM " & tableName
                Return Sql
            End Get
        End Property


        'Get Select Statement for table TB_RESERVE
        Private ReadOnly Property SqlSelect() As String
            Get
                Dim Sql As String = "SELECT * FROM " & tableName
                Return Sql
            End Get
        End Property


    End Class
End Namespace