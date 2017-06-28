Imports System.ComponentModel.DataAnnotations.Schema
Imports Vizion.Models

<Table("inventory")>
Public Class Inventory

    Public Sub New()

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

#Region "Mapped"
    Public Property Customer As String
    Public Property Product As String
    Public Property Row As String
    Public Property Rack As String
    Public Property Slot As String
    Public Property Pallets As Double?
    Public Property Cases As Double?
    Public Property Net As Double?
    Public Property ProductDate As DateTime?
    Public Property ReceiverNumber As Double?
    Public Property LotNumber As String
    Public Property ReceiveDate As DateTime?
    Public Property StorThru As DateTime?
    Public Property Status As String
    Public Property CustomerReference As String
    Public Property PalletNumber As Decimal
    Public Property CustomerPallet As String
    Public Property StartTime As String
    Public Property StopTime As String
    Public Property SalesOrderNumber As String
    Public Property EnteredBy As String
    Public Property FullPalletQty As String
    Public Property PalletQtyReceived As String
    Public Property Id As Integer
    Public Property LpNumber As String

#End Region

#Region "Not Mapped"

#End Region
End Class
