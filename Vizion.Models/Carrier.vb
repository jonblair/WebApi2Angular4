Imports System.ComponentModel.DataAnnotations.Schema
Imports Vizion.Models

<Table("carriermaster")>
Public Class Carrier
    Implements ICarrier

    <Column("CarrierAdd1", TypeName:="text")>
    Public Property Add1 As String Implements ICarrier.Add1
    <Column("CarrierAdd2", TypeName:="text")>
    Public Property Add2 As String Implements ICarrier.Add2
    <Column("CarrierCity", TypeName:="text")>
    Public Property City As String Implements ICarrier.City
    Public Property Comments As String Implements ICarrier.Comments
    <Column("CarrierContact", TypeName:="text")>
    Public Property Contact As String Implements ICarrier.Contact
    Public Property Id As Integer Implements ICarrier.Id
    <Column("CarrierName", TypeName:="text")>
    Public Property Name As String Implements ICarrier.Name
    <Column("CarrierPhone", TypeName:="text")>
    Public Property Phone As String Implements ICarrier.Phone
    Public Property Scac As String Implements ICarrier.Scac
    <Column("CarrierState", TypeName:="text")>
    Public Property State As String Implements ICarrier.State
    <Column("CarrierZip", TypeName:="text")>
    Public Property Zip As String Implements ICarrier.Zip
End Class

Public Interface ICarrier
    Property Id As Integer
    Property Scac As String
    Property Name As String
    Property Add1 As String
    Property Add2 As String
    Property City As String
    Property State As String
    Property Zip As String
    Property Phone As String
    Property Comments As String
    Property Contact As String
End Interface
