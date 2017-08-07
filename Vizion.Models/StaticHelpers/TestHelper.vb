Imports Demo.Models

Public NotInheritable Class TestHelper
    Public Shared DefaultNumberOfTotalMockRecords As Integer = 50
    Public Shared DefaultMockUserPassword As String = "P@5Sw0rD.12345"

    Public Shared Function CreateTestUser(userId As Integer) As User
        Dim myTestUser As User = New User

        myTestUser.Id = userId
        myTestUser.FirstName = "Test"
        myTestUser.LastName = "User"
        myTestUser.CommonName = "CommonTest"
        myTestUser.Password = "password"
        myTestUser.UserName = String.Format("{0}{1}", myTestUser.FirstName + myTestUser.LastName, userId.ToString)
        myTestUser.Email = "testuser@email.com"

        Return myTestUser
    End Function
End Class
