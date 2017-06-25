﻿Imports Vizion.Models
Imports Vizion.Repositories
Imports System.Data.Entity

Public Class InventoryRepository : Inherits Repository(Of Inventory)
    Implements IInventoryRepository

    Public Sub New(context As DbContext)
        MyBase.New(context)
    End Sub

    Public ReadOnly Property _dbContext() As DbContext
        Get
            Return TryCast(Context, DbContext)
        End Get
    End Property
End Class