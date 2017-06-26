Imports System.ComponentModel.DataAnnotations.Schema
Imports Vizion.Models

<Table("UserAccess")>
Public Class User
    Implements IUser

    Public Sub New()

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub


#Region "Mapped"
    Public Property Id As Integer Implements IUser.Id
    Public Property UserName As String Implements IUser.UserName
        Get
            Return _userName
        End Get
        Set(value As String)
            _userName = value.ToLower
        End Set
    End Property
    Private _userName As String = Nothing
    Public Property FirstName As String Implements IUser.FirstName
        Get
            Return _firstName
        End Get
        Set(value As String)
            _firstName = StringHelper.TitleCase(value.ToLower)
        End Set
    End Property
    Private _firstName As String = Nothing
    Public Property LastName As String Implements IUser.LastName
        Get
            Return _lastName
        End Get
        Set(value As String)
            _lastName = StringHelper.TitleCase(value.ToLower)
        End Set
    End Property
    Private _lastName As String = Nothing
    Public Property Password As String Implements IUser.Password
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
    Public Property Email As String Implements IUser.Email

    <NotMapped>
    Public Property CommonName As String Implements IUser.CommonName

    <NotMapped>
    Public ReadOnly Property FullName As String Implements IUser.FullName
        Get
            If (Me.CommonName IsNot Nothing) Then
                Return String.Format("{0} {1}", Me.CommonName, Me.LastName)
            End If

            Return StringHelper.TitleCase(String.Format("{0} {1}", Me.FirstName.ToLower, Me.LastName.ToLower))
        End Get
    End Property
#End Region

    Public Interface IUser
        Property Id As Integer
        Property UserName As String
        Property FirstName As String
        Property LastName As String
        Property Password As String
        Property Email As String
        Property CommonName As String
        ReadOnly Property FullName As String
    End Interface

End Class
