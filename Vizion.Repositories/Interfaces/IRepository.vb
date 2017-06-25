Imports System.Linq.Expressions

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