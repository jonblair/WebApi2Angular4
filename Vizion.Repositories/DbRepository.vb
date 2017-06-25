Imports Vizion.Repositories
Imports System.Data.Entity

Public Class DBRepository
    Implements IDbRepository

    Private ReadOnly _context As DbContext

    Public Sub New(ByVal context As DbContext)
        _context = context
        Users = New UserRepository(_context)
        Customers = New CustomerRepository(_context)
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()

        Dispose()
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

    Public Property Customers As ICustomerRepository Implements IDbRepository.Customers
        Get
            Return m_Customers
        End Get
        Private Set
            m_Customers = Value
        End Set
    End Property
    Private m_Customers As ICustomerRepository

    Public Function Complete() As Integer Implements IDbRepository.Complete
        Return _context.SaveChanges()
    End Function

    Public Sub Dispose() Implements IDisposable.Dispose
        _context.Dispose()
    End Sub
End Class
