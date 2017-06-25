Imports System.Security.Cryptography
Imports System.Text

Public NotInheritable Class EncryptionHelper
    Public Shared MaxSaltLength As Integer = 128
    Private Shared SaltCharsMix As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()_+=][}{<>"

    Public Shared Function Hash512(password As String) As String
        Dim salt As String = CreateRandomSalt()
        Dim convertedToBytes As Byte() = Encoding.UTF8.GetBytes(password & salt)
        Dim hashType As HashAlgorithm = New SHA512Managed()
        Dim hashBytes As Byte() = hashType.ComputeHash(convertedToBytes)
        Dim hashedResult As String = Convert.ToBase64String(hashBytes)

        Return hashedResult
    End Function

    Private Shared Function CreateRandomSalt() As String
        Dim SaltChars As String = ""
        Dim rnd As New Random
        Dim sb As New StringBuilder
        For i As Integer = 1 To MaxSaltLength
            Dim x As Integer = rnd.Next(0, SaltCharsMix.Length - 1)
            SaltChars &= (SaltCharsMix.Substring(x, 1))
        Next

        Return SaltChars
    End Function
End Class
