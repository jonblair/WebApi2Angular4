Imports Vizion.Repositories
Imports System.Data.Entity

Public Class DBRepository
    Implements IDbRepository

    Private ReadOnly _context As DbContext

    Public Sub New(ByVal context As DbContext)
        _context = context
        Users = New UserRepository(_context)
    End Sub

    Public Property Users As IUserRepository Implements IDbRepository.Users
        Get
            Return m_Users
        End Get
        Private Set
            m_Users = Value
        End Set
    End Property
    Private m_Users As IUserRepository

    Public Function Complete() As Integer Implements IDbRepository.Complete
        Return _context.SaveChanges()
    End Function

    Public Sub Dispose() Implements IDisposable.Dispose
        _context.Dispose()
    End Sub

End Class
