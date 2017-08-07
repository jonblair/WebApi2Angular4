Imports System.ComponentModel.DataAnnotations.Schema
Imports Demo.Models

<Table("appointments")>
Public Class Appointment

    Public Property AppointDate As Date?

    Public Property ApptNumber As Decimal

    Public Property ApptStatus As String

    Public Property Carrier As String

    Public Property Comments As String

    Public Property Consolidation As Decimal

    Public Property Contact As String

    Public Property Customer As String

    Public Property CustomerPo As String

    Public Property DateTaken As Date?

    <Column("AppointmentID", TypeName:="int")>
    Public Property Id As Integer

    Public Property Location As String

    Public Property Trailer As String
    <Column("TransType", TypeName:="text")>
    Public Property TransactionType As String

    Public Property Username As String
End Class
