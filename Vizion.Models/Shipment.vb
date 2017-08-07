Imports System.ComponentModel.DataAnnotations.Schema
Imports Demo.Models

<Table("shipmentheader")>
Public Class Shipment

    Public Sub New()

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

#Region "Mapped"
    Public Property Id As Integer
    <Column("shipment", TypeName:="text")>
    Public Property ShipmentId As String
    Public Property Consolidation As Decimal?
    <Column("customer", TypeName:="text")>
    Public Property CustomerName As String
    Public Property ShipDate As DateTime?
    <Column("arrivaltime", TypeName:="datetime")>
    Public Property ArrivalDate As DateTime?
    <Column("complettiontime", TypeName:="datetime")>
    Public Property CompletetionDate As DateTime?
    Public Property AppointmentDate As DateTime?
    Public Property SignInDate As DateTime?
    Public Property SignOutDate As DateTime?
    Public Property CustomerReference As String
    Public Property Scac As String
    Public Property Trailer As String
    Public Property TempRequired As String
    Public Property PalletsIn As Decimal?
    Public Property PalletsOut As Decimal?
    Public Property SpecialInstructions As String
    Public Property DoorNumber As String
    Public Property FullPallets As Decimal?
    Public Property PickPallets As Decimal?
    Public Property TotalPallets As Decimal?
    Public Property Dock As String
    Public Property LoadStatus As String
    Public Property TempRecorder As String
#End Region

#Region "Not Mapped"

#End Region
End Class
