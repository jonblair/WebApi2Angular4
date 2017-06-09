Imports System.Text
Imports System.Globalization

Public NotInheritable Class StringHelper

    Public Shared Function GenerateRandomString(r As Random) As String
        Dim s As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789"
        Dim sb As New StringBuilder
        Dim cnt As Integer = r.Next(15, 25)
        For i As Integer = 1 To cnt
            Dim idx As Integer = r.Next(0, s.Length)
            sb.Append(s.Substring(idx, 1))
        Next

        Return sb.ToString()
    End Function

    Public Shared Function TitleCase(ByVal input As String) As String
        Dim TextInfo As TextInfo = New CultureInfo("en-US", False).TextInfo

        Return TextInfo.ToTitleCase(input)
    End Function
End Class
