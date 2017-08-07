Imports System.Linq.Expressions
Imports Demo.Repositories
Imports System.Data.Entity
Imports System
Imports System.Collections.Generic
Imports System.Linq


Public Interface IRepository(Of TEntity As Class)
    Function [Get](id As Integer) As TEntity
    Function GetAll(Optional records As Integer = 100) As IEnumerable(Of TEntity)
    Function Search(predicate As Expression(Of Func(Of TEntity, Boolean))) As IEnumerable(Of TEntity)
    Function [FirstOrDefault](predicate As Expression(Of Func(Of TEntity, Boolean))) As TEntity
    Sub [Add](entity As TEntity)
    Sub [AddRange](entities As IEnumerable(Of TEntity))
    Sub [Remove](entity As TEntity)
    Sub [RemoveRange](entities As IEnumerable(Of TEntity))
End Interface

Public Class Repository(Of TEntity As Class)
    Implements IRepository(Of TEntity)

    Protected ReadOnly Context As DbContext

    Public Sub New(context As DbContext)
        Me.Context = context
    End Sub

    Private Function [Get](id As Integer) As TEntity Implements IRepository(Of TEntity).Get
        Return Context.[Set](Of TEntity)().Find(id)
    End Function

    Private Function GetAll(Optional recordCount As Integer = 100) As IEnumerable(Of TEntity) Implements IRepository(Of TEntity).GetAll
        Return Context.[Set](Of TEntity)().ToList().Take(recordCount)
    End Function

    Private Function Search(predicate As Expression(Of Func(Of TEntity, Boolean))) As IEnumerable(Of TEntity) Implements IRepository(Of TEntity).Search
        Return Context.[Set](Of TEntity)().Where(predicate)
    End Function

    Private Function [FirstOrDefault](predicate As Expression(Of Func(Of TEntity, Boolean))) As TEntity Implements IRepository(Of TEntity).FirstOrDefault
        Return Context.[Set](Of TEntity)().FirstOrDefault(predicate)
    End Function

    Private Sub [Add](entity As TEntity) Implements IRepository(Of TEntity).Add
        Context.[Set](Of TEntity)().Add(entity)
    End Sub

    Private Sub [AddRange](entities As IEnumerable(Of TEntity)) Implements IRepository(Of TEntity).AddRange
        Context.[Set](Of TEntity)().AddRange(entities)
    End Sub

    Private Sub [Remove](entity As TEntity) Implements IRepository(Of TEntity).Remove
        Context.[Set](Of TEntity)().Remove(entity)
    End Sub

    Private Sub [RemoveRange](entities As IEnumerable(Of TEntity)) Implements IRepository(Of TEntity).RemoveRange
        Context.[Set](Of TEntity)().RemoveRange(entities)
    End Sub
End Class
