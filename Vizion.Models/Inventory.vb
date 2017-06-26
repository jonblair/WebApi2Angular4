Imports System.ComponentModel.DataAnnotations.Schema
Imports Vizion.Models

<Table("inventory")>
Public Class Inventory
    Implements IInventory

    Public Sub New()

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

#Region "Mapped"
    Public Property Customer As String Implements IInventory.Customer
    Public Property Product As String Implements IInventory.Product
    Public Property Row As String Implements IInventory.Row
    Public Property Rack As String Implements IInventory.Rack
    Public Property Slot As String Implements IInventory.Slot
    Public Property Pallets As Double? Implements IInventory.Pallets
    Public Property Cases As Double? Implements IInventory.Cases
    Public Property Net As Double? Implements IInventory.Net
    Public Property ProductDate As DateTime? Implements IInventory.ProductDate
    Public Property ReceiverNumber As Double? Implements IInventory.ReceiverNumber
    Public Property LotNumber As String Implements IInventory.LotNumber
    Public Property ReceiveDate As DateTime? Implements IInventory.ReceiveDate
    Public Property StorThru As DateTime? Implements IInventory.StorThru
    Public Property Status As String Implements IInventory.Status
    Public Property CustomerReference As String Implements IInventory.CustomerReference
    Public Property PalletNumber As Decimal Implements IInventory.PalletNumber
    Public Property CustomerPallet As String Implements IInventory.CustomerPallet
    Public Property StartTime As String Implements IInventory.StartTime
    Public Property StopTime As String Implements IInventory.StopTime
    Public Property SalesOrderNumber As String Implements IInventory.SalesOrderNumber
    Public Property EnteredBy As String Implements IInventory.EnteredBy
    Public Property FullPalletQty As String Implements IInventory.FullPalletQty
    Public Property PalletQtyReceived As String Implements IInventory.PalletQtyReceived
    Public Property Id As Integer Implements IInventory.Id
    Public Property LpNumber As String Implements IInventory.LpNumber

#End Region

#Region "Not Mapped"

#End Region
End Class

Public Interface IInventory
    Property Customer As String
    Property Product As String
    Property Row As String
    Property Rack As String
    Property Slot As String
    ' Property Pallets As Double?
    Property Pallets As Double?
    Property Cases As Double?
    Property Net As Double?
    Property ProductDate As DateTime?
    Property ReceiverNumber As Double?
    Property LotNumber As String
    Property ReceiveDate As DateTime?
    Property StorThru As DateTime?
    Property Status As String
    Property CustomerReference As String
    Property PalletNumber As Decimal
    Property CustomerPallet As String
    Property StartTime As String
    Property StopTime As String
    Property SalesOrderNumber As String
    Property EnteredBy As String
    Property FullPalletQty As String
    Property PalletQtyReceived As String
    Property Id As Integer
    Property LpNumber As String
End Interface
