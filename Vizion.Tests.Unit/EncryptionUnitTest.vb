Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports Vizion.Models
Imports Vizion.Repositories
Imports Vizion.Services

<TestClass()> Public Class EncryptionUnitTest

    <TestMethod()> Public Sub Encryption_PasswordIsCorrectLength()
        Dim saltTest As String = EncryptionHelper.Hash512(TestHelper.DefaultMockUserPassword)

        Assert.AreNotEqual(saltTest.Length, 1)
        Assert.AreNotEqual(saltTest.Length, EncryptionHelper.MaxSaltLength + 1)
    End Sub

    <TestMethod()> Public Sub Encryption_SamePasswordIsEqualHash()
        Dim saltTest As String = EncryptionHelper.Hash512(TestHelper.DefaultMockUserPassword)
        Dim saltTest2 As String = EncryptionHelper.Hash512(TestHelper.DefaultMockUserPassword)

        Assert.AreNotEqual(saltTest.Length, 1)
        Assert.AreNotEqual(saltTest.Length, EncryptionHelper.MaxSaltLength + 1)
        Assert.AreNotEqual(saltTest2.Length, 1)
        Assert.AreNotEqual(saltTest2.Length, EncryptionHelper.MaxSaltLength + 1)
        Assert.AreEqual(saltTest, saltTest2)
    End Sub

    <TestMethod()> Public Sub Encryption_DifferentPasswordIsNotEqualHash()
        Dim saltTest As String = EncryptionHelper.Hash512(TestHelper.DefaultMockUserPassword)
        Dim saltTest2 As String = EncryptionHelper.Hash512("SomeKindOfDifferentPassword")

        Assert.AreNotEqual(saltTest.Length, 1)
        Assert.AreNotEqual(saltTest.Length, EncryptionHelper.MaxSaltLength + 1)
        Assert.AreNotEqual(saltTest2.Length, 1)
        Assert.AreNotEqual(saltTest2.Length, EncryptionHelper.MaxSaltLength + 1)
        Assert.AreNotEqual(saltTest, saltTest2)
    End Sub

End Class