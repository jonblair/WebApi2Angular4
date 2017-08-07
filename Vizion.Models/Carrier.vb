Imports System.ComponentModel.DataAnnotations.Schema
Imports Demo.Models

<Table("carriermaster")>
Public Class Carrier

    <Column("CarrierAdd1", TypeName:="text")>
    Public Property Add1 As String
    <Column("CarrierAdd2", TypeName:="text")>
    Public Property Add2 As String
    <Column("CarrierCity", TypeName:="text")>
    Public Property City As String
    Public Property Comments As String
    <Column("CarrierContact", TypeName:="text")>
    Public Property Contact As String
    Public Property Id As Integer
    <Column("CarrierName", TypeName:="text")>
    Public Property Name As String
    <Column("CarrierPhone", TypeName:="text")>
    Public Property Phone As String
    Public Property Scac As String
    <Column("CarrierState", TypeName:="text")>
    Public Property State As String
    <Column("CarrierZip", TypeName:="text")>
    Public Property Zip As String
End Class
