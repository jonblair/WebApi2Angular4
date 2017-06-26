Imports System.ComponentModel.DataAnnotations.Schema
Imports Vizion.Models

<Table("shipmentheader")>
Public Class Shipment
    Implements IShipment

    Public Sub New()

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

#Region "Mapped"
    Public Property Id As Integer Implements IShipment.Id
    <Column("shipment", TypeName:="text")>
    Public Property ShipmentId As String Implements IShipment.ShipmentId
    Public Property Consolidation As Decimal? Implements IShipment.Consolidation
    <Column("customer", TypeName:="text")>
    Public Property CustomerName As String Implements IShipment.CustomerName
    Public Property ShipDate As DateTime? Implements IShipment.ShipDate
    <Column("arrivaltime", TypeName:="datetime")>
    Public Property ArrivalDate As DateTime? Implements IShipment.ArrivalDate
    <Column("complettiontime", TypeName:="datetime")>
    Public Property CompletetionDate As DateTime? Implements IShipment.CompletetionDate
    Public Property AppointmentDate As DateTime? Implements IShipment.AppointmentDate
    Public Property SignInDate As DateTime? Implements IShipment.SignInDate
    Public Property SignOutDate As DateTime? Implements IShipment.SignOutDate
    Public Property CustomerReference As String Implements IShipment.CustomerReference
    Public Property Scac As String Implements IShipment.Scac
    Public Property Trailer As String Implements IShipment.Trailer
    Public Property TempRequired As String Implements IShipment.TempRequired
    Public Property PalletsIn As Decimal? Implements IShipment.PalletsIn
    Public Property PalletsOut As Decimal? Implements IShipment.PalletsOut
    Public Property SpecialInstructions As String Implements IShipment.SpecialInstructions
    Public Property DoorNumber As String Implements IShipment.DoorNumber
    Public Property FullPallets As Decimal? Implements IShipment.FullPallets
    Public Property PickPallets As Decimal? Implements IShipment.PickPallets
    Public Property TotalPallets As Decimal? Implements IShipment.TotalPallets
    Public Property Dock As String Implements IShipment.Dock
    Public Property LoadStatus As String Implements IShipment.LoadStatus
    Public Property TempRecorder As String Implements IShipment.TempRecorder
#End Region

#Region "Not Mapped"

#End Region

    Public Interface IShipment
        Property Id As Integer
        Property ShipmentId As String
        Property Consolidation As Decimal?
        Property CustomerName As String
        Property ShipDate As DateTime?
        Property ArrivalDate As DateTime?
        Property CompletetionDate As DateTime?
        Property AppointmentDate As DateTime?
        Property SignInDate As DateTime?
        Property SignOutDate As DateTime?
        Property CustomerReference As String
        Property Scac As String
        Property Trailer As String
        Property TempRequired As String
        Property PalletsIn As Decimal?
        Property PalletsOut As Decimal?
        Property SpecialInstructions As String
        Property DoorNumber As String
        Property FullPallets As Decimal?
        Property PickPallets As Decimal?
        Property TotalPallets As Decimal?
        Property Dock As String
        Property LoadStatus As String
        Property TempRecorder As String
    End Interface
End Class
