Imports System.ComponentModel.DataAnnotations.Schema
Imports Demo.Models

<Table("inventory")>
Public Class CustomerPalletMetrics
    <NotMapped()>
    Public Property Customer As String
    <NotMapped()>
    Public Property PalletCount As Integer
End Class
