Imports System.ComponentModel.DataAnnotations.Schema
Imports Vizion.Models

<Table("customermaster")>
Public Class Customer
    Public Sub New()

    End Sub

#Region "Mapped"
    Public Property Id As Integer
    <Column("Customer", TypeName:="text")>
    Public Property CustomerNameId As String
    <Column("CustomerName", TypeName:="text")>
    Public Property Name As String
    <Column("CustomerAdd1", TypeName:="text")>
    Public Property Address1 As String
    <Column("CustomerAdd2", TypeName:="text")>
    Public Property Address2 As String
    <Column("CustomerCity", TypeName:="text")>
    Public Property City As String
    <Column("CustomerState", TypeName:="text")>
    Public Property State As String
    <Column("CustomerZip", TypeName:="text")>
    Public Property Zip As String
    <Column("CustomerPhone", TypeName:="text")>
    Public Property Phone As String
    <Column("CustomerFax", TypeName:="text")>
    Public Property Fax As String
    <Column("CustomerContact", TypeName:="text")>
    Public Property Contact As String
#End Region

#Region "Not Mapped"

#End Region
End Class
