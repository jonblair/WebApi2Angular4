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

    Public ReadOnly Property _dbWmsDataContext() As VizionWMSDataContext
        Get
            Return TryCast(Context, VizionWMSDataContext)
        End Get
    End Property

    Public ReadOnly Property _dbWmsReportsContext() As VizionWMSReportsContext
        Get
            Return TryCast(Context, VizionWMSReportsContext)
        End Get
    End Property
End Class
