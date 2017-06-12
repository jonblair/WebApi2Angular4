Imports Vizion.Models
Imports Vizion.Repositories
Imports System.Data.Entity

Public Class UserRepository : Inherits Repository(Of User)
    Implements IUserRepository

    Private myUsersList As List(Of User)
    Private myUser As User

    Public Sub New(context As DbContext)
        MyBase.New(context)

        myUsersList = New List(Of User)
        myUser = New User
    End Sub

    Public ReadOnly Property _dbContext() As DbContext
        Get
            Return TryCast(Context, DbContext)
        End Get
    End Property
End Class
