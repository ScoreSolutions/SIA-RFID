﻿
Namespace Table
    'Represents a transaction for TB_SETUP table Data.
    '[Create by  on December, 23 2010]
    Public Class TbSetupData

        'Generate Field List
        Dim _ID As Long = 0
        Dim _SETUP_NAME As String = ""
        Dim _SETUP_VALUE As String = ""
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
        Public Property SETUP_NAME() As String
            Get
                Return _SETUP_NAME
            End Get
            Set(ByVal value As String)
                _SETUP_NAME = value
            End Set
        End Property
        Public Property SETUP_VALUE() As String
            Get
                Return _SETUP_VALUE
            End Get
            Set(ByVal value As String)
                _SETUP_VALUE = value
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