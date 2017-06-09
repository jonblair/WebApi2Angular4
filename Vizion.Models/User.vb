Imports System.ComponentModel.DataAnnotations.Schema
Imports Vizion.Models

<Table("UserAccess")>
Public Class User

#Region "Mapped"
    Public Property Id As Integer
    Public Property UserName As String
    Public Property FirstName As String
    Public Property LastName As String
    Public Property Password As String
        Get
            Return _password
        End Get
        Set(value As String)
            _password = EncryptionHelper.Hash512(value)
        End Set
    End Property
    Private _password As String = Nothing
#End Region

#Region "Not Mapped"
    <NotMapped>
    Public Property Email As String

    <NotMapped>
    Public Property CommonName As String

    <NotMapped>
    Public Property FullName As String
        Get
            If (Me.CommonName IsNot Nothing) Then
                Return String.Format("{0} {1}", Me.CommonName, Me.LastName)
            End If

            Return StringHelper.TitleCase(String.Format("{0} {1}", Me.FirstName, Me.LastName))
        End Get
        Set(value As String)
            _fullName = StringHelper.TitleCase(value)
        End Set
    End Property
    Private _fullName As String = Nothing
#End Region

End Class
