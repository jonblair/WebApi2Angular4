Imports Vizion.Models
Imports Vizion.Repositories
Imports System.Data.Entity

Public Interface IAppointmentRepository : Inherits IRepository(Of Appointment)
End Interface

Public Class AppointmentRepository : Inherits Repository(Of Appointment)
    Implements IAppointmentRepository

    Public Sub New(context As DbContext)
        MyBase.New(context)
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()

        _dbContext.Dispose()
    End Sub

    Public ReadOnly Property _dbContext() As DbContext
        Get
            Return TryCast(Context, DbContext)
        End Get
    End Property
End Class

