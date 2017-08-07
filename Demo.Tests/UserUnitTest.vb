Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports Demo.Models
Imports Demo.Repositories
Imports Moq

<TestClass()> Public Class UserUnitTest
    Private myMockUsers As New List(Of User)
    Private myMockUser As User
    Private myMockUserRepo As Mock(Of IUserRepository)

    '<TestMethod()> Public Sub UserRepo_RecordTotalsTest()
    '    myMockUsers = New MockUserRepository(200).GetUsers().ToList()
    '    Assert.AreEqual(myMockUsers.Count, 200)
    '    Assert.AreNotEqual(myMockUsers.Count, 0)

    '    myMockUsers = New MockUserRepository(100).GetUsers().ToList()
    '    Assert.AreEqual(myMockUsers.Count, 100)
    '    Assert.AreNotEqual(myMockUsers.Count, 0)

    '    myMockUsers = New MockUserRepository(150).GetUsers().ToList()
    '    Assert.AreEqual(myMockUsers.Count, 150)
    '    Assert.AreNotEqual(myMockUsers.Count, 0)

    '    myMockUsers = New MockUserRepository(5).GetUsers().ToList()
    '    Assert.AreEqual(myMockUsers.Count, 5)
    '    Assert.AreNotEqual(myMockUsers.Count, 0)

    '    Assert.IsNotNull(myMockUsers)
    'End Sub

    '<TestMethod()> Public Sub UserRepo_GetAllUsers()
    '    myMockUsers = New MockUserRepository(TestHelper.DefaultNumberOfTotalMockRecords).GetUsers().ToList()

    '    Assert.IsNotNull(myMockUsers)
    '    Assert.AreNotEqual(myMockUsers.Count, 0)
    '    Assert.AreEqual(myMockUsers.Count, TestHelper.DefaultNumberOfTotalMockRecords)
    'End Sub

    '<TestMethod()> Public Sub UserRepo_GetUserById()
    '    myMockUser = New MockUserRepository(TestHelper.DefaultNumberOfTotalMockRecords).GetUserByID(5)

    '    Assert.IsNotNull(myMockUser)
    '    Assert.AreNotEqual(myMockUser.Id, 0)
    '    Assert.AreEqual(myMockUser.Id, 5)
    'End Sub

    '<TestMethod()> Public Sub UserRepo_UserInsert()
    '    myMockUserRepo = New MockUserRepository(TestHelper.DefaultNumberOfTotalMockRecords)
    '    myMockUsers = myMockUserRepo.GetUsers().ToList()

    '    Dim myMockUser As New User
    '    myMockUser.Id = myMockUsers.Count + 1

    '    myMockUserRepo.InsertUser(myMockUser)
    '    myMockUsers = myMockUserRepo.GetUsers().ToList()

    '    Assert.IsNotNull(myMockUser)
    '    Assert.IsNotNull(myMockUsers)
    '    Assert.AreNotEqual(myMockUser.Id, 0)
    '    Assert.AreNotEqual(myMockUsers.Count, TestHelper.DefaultNumberOfTotalMockRecords)
    '    Assert.AreEqual(myMockUsers(TestHelper.DefaultNumberOfTotalMockRecords).Id, TestHelper.DefaultNumberOfTotalMockRecords + 1)
    'End Sub

    '<TestMethod()> Public Sub UserRepo_UserDelete()
    '    myMockUserRepo = New MockUserRepository(TestHelper.DefaultNumberOfTotalMockRecords)
    '    myMockUsers = myMockUserRepo.GetUsers().ToList()

    '    myMockUserRepo.DeleteUser(5)
    '    myMockUsers = myMockUserRepo.GetUsers().ToList()

    '    Assert.IsNotNull(myMockUsers)
    '    Assert.AreNotEqual(myMockUsers.Count, 0)
    '    Assert.AreEqual(myMockUsers.Count, TestHelper.DefaultNumberOfTotalMockRecords - 1)
    '    Assert.AreEqual(myMockUsers.Where(Function(x) x.Id = 5).ToList().Count(), 0)
    'End Sub
End Class