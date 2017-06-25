Imports System.ComponentModel.DataAnnotations.Schema
Imports Vizion.Models

<Table("UserAccess")>
Public Class UserPermission

    Public Sub New()

    End Sub

#Region "Mapped"

#End Region

#Region "Not Mapped"

#End Region


    Public Id As Integer
    Public ReportsAccess As Boolean
    Public ProductsAccess As Boolean
End Class
