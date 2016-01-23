﻿
Namespace Table
    'Represents a transaction for TB_CABINET table Parameter.
    '[Create by  on April, 25 2014]
    Public Class TbCabinetData

        'Generate Field List
        Dim _ID As Long = 0
        Dim _FLOOR_ID As Long = 0
        Dim _ROOM_ID As Long = 0
        Dim _CABINET_NAME As String = ""
        Dim _CREATEBY As String = ""
        Dim _CREATEON As DateTime = New DateTime(1, 1, 1)
        Dim _UPDATEBY As String = ""
        Dim _UPDATEON As DateTime = New DateTime(1, 1, 1)

        'Generate Field Property 
        Public Property ID() As Long
            Get
                Return _ID
            End Get
            Set(ByVal value As Long)
                _ID = value
            End Set
        End Property
        Public Property FLOOR_ID() As Long
            Get
                Return _FLOOR_ID
            End Get
            Set(ByVal value As Long)
                _FLOOR_ID = value
            End Set
        End Property
        Public Property ROOM_ID() As Long
            Get
                Return _ROOM_ID
            End Get
            Set(ByVal value As Long)
                _ROOM_ID = value
            End Set
        End Property
        Public Property CABINET_NAME() As String
            Get
                Return _CABINET_NAME
            End Get
            Set(ByVal value As String)
                _CABINET_NAME = value
            End Set
        End Property
        Public Property CREATEBY() As String
            Get
                Return _CREATEBY
            End Get
            Set(ByVal value As String)
                _CREATEBY = value
            End Set
        End Property
        Public Property CREATEON() As DateTime
            Get
                Return _CREATEON
            End Get
            Set(ByVal value As DateTime)
                _CREATEON = value
            End Set
        End Property
        Public Property UPDATEBY() As String
            Get
                Return _UPDATEBY
            End Get
            Set(ByVal value As String)
                _UPDATEBY = value
            End Set
        End Property
        Public Property UPDATEON() As DateTime
            Get
                Return _UPDATEON
            End Get
            Set(ByVal value As DateTime)
                _UPDATEON = value
            End Set
        End Property
    End Class
End Namespace