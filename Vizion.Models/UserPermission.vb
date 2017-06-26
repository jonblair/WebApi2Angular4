Imports System.ComponentModel.DataAnnotations.Schema
Imports Vizion.Models

<Table("UserAccess")>
Public Class UserPermissions
    Implements IUserPermissions

    Public Sub New()

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub



#Region "Mapped"

#End Region

#Region "Not Mapped"

#End Region
End Class


Public Interface IUserPermissions

End Interface
