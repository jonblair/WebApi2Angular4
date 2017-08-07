Imports System.Text
Imports System.Globalization
Imports System.Threading

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
        Dim CultureInfo As CultureInfo = Thread.CurrentThread.CurrentCulture
        Dim textInfo As TextInfo = CultureInfo.TextInfo

        Return textInfo.ToTitleCase(input)
    End Function
End Class
