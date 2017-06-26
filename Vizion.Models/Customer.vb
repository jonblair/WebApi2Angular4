Imports System.ComponentModel.DataAnnotations.Schema
Imports Vizion.Models

<Table("customermaster")>
Public Class Customer
    Implements ICustomer

    Public Sub New()

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

#Region "Mapped"
    Public Property Id As Integer Implements ICustomer.Id
    <Column("Customer", TypeName:="text")>
    Public Property CustomerNameId As String Implements ICustomer.CustomerNameId
    <Column("CustomerName", TypeName:="text")>
    Public Property Name As String Implements ICustomer.Name
    <Column("CustomerAdd1", TypeName:="text")>
    Public Property Address1 As String Implements ICustomer.Address1
    <Column("CustomerAdd2", TypeName:="text")>
    Public Property Address2 As String Implements ICustomer.Address2
    <Column("CustomerCity", TypeName:="text")>
    Public Property City As String Implements ICustomer.City
    <Column("CustomerState", TypeName:="text")>
    Public Property State As String Implements ICustomer.State
    <Column("CustomerZip", TypeName:="text")>
    Public Property Zip As String Implements ICustomer.Zip
    <Column("CustomerPhone", TypeName:="text")>
    Public Property Phone As String Implements ICustomer.Phone
    <Column("CustomerFax", TypeName:="text")>
    Public Property Fax As String Implements ICustomer.Fax
    <Column("CustomerContact", TypeName:="text")>
    Public Property Contact As String Implements ICustomer.Contact
#End Region

#Region "Not Mapped"

#End Region

End Class

Public Interface ICustomer
    Property Id As Integer
    Property CustomerNameId As String
    Property Name As String
    Property Address1 As String
    Property Address2 As String
    Property City As String
    Property State As String
    Property Zip As String
    Property Phone As String
    Property Fax As String
    Property Contact As String
End Interface
