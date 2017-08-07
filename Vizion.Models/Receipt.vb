Imports System.ComponentModel.DataAnnotations.Schema
Imports Demo.Models

<Table("receipts")>
Public Class Receipt
    Public Property Customer As String
    Public Property Product As String
    Public Property Row As String
    Public Property Rack As String
    Public Property Slot As String
    Public Property Pallets As Decimal
    Public Property Cases As Decimal
    Public Property Net As Decimal
    Public Property ProductDate As DateTime?
    Public Property LotNumber As String
    Public Property PalletNumber As Integer
    Public Property StorThru As DateTime?
    Public Property Status As String
    Public Property CustomerPallet As String
    Public Property StartTime As DateTime?
    Public Property StopTime As DateTime?
End Class