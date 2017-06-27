Imports System.ComponentModel.DataAnnotations.Schema
Imports Vizion.Models

<Table("appointments")>
Public Class Appointment
    Implements IAppointment

    Public Property AppointDate As Date? Implements IAppointment.AppointDate

    Public Property ApptNumber As Decimal Implements IAppointment.ApptNumber

    Public Property ApptStatus As String Implements IAppointment.ApptStatus

    Public Property Carrier As String Implements IAppointment.Carrier

    Public Property Comments As String Implements IAppointment.Comments

    Public Property Consolidation As Decimal Implements IAppointment.Consolidation

    Public Property Contact As String Implements IAppointment.Contact

    Public Property Customer As String Implements IAppointment.Customer

    Public Property CustomerPo As String Implements IAppointment.CustomerPo

    Public Property DateTaken As Date? Implements IAppointment.DateTaken

    <Column("AppointmentID", TypeName:="int")>
    Public Property Id As Integer Implements IAppointment.Id

    Public Property Location As String Implements IAppointment.Location

    Public Property Trailer As String Implements IAppointment.Trailer
    <Column("TransType", TypeName:="text")>
    Public Property TransactionType As String Implements IAppointment.TransactionType

    Public Property Username As String Implements IAppointment.Username
End Class

Public Interface IAppointment
    Property Id As Integer
    Property Consolidation As Decimal
    Property TransactionType As String
    Property Customer As String
    Property Carrier As String
    Property Trailer As String
    Property AppointDate As DateTime?
    Property CustomerPo As String
    Property Location As String
    Property Contact As String
    Property ApptNumber As Decimal
    Property Username As String
    Property DateTaken As DateTime?
    Property Comments As String
    Property ApptStatus As String
End Interface
