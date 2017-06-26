Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Net
Imports System.Net.Http
Imports System.Net.Http.Headers
Imports System.Threading
Imports System.Threading.Tasks
Imports System.Web.Http
Imports System.Web.Http.Cors

Public Module WebApiConfig
    Public Sub Register(ByVal config As HttpConfiguration)
        'Web API configuration and services
        config.Formatters.JsonFormatter.SupportedMediaTypes.Add(New MediaTypeHeaderValue("text/html")) 'return json by default

        'CORS is for when a client requests access to a resource from a different domain than where the resource originates
        Dim cors = New EnableCorsAttribute("*", "*", "*")
        config.EnableCors(cors)
        config.MessageHandlers.Add(New PreflightRequestsHandler())

        'Web API routes
        config.MapHttpAttributeRoutes()
        config.Routes.MapHttpRoute(
            name:="DefaultApi",
            routeTemplate:="api/{controller}/{id}",
            defaults:=New With {.id = RouteParameter.Optional})
    End Sub



    Public Class PreflightRequestsHandler : Inherits DelegatingHandler

        Protected Overrides Function SendAsync(request As HttpRequestMessage, cancellationToken As CancellationToken) As Task(Of HttpResponseMessage)
            If request.Headers.Contains("Origin") AndAlso request.Method.Method = "OPTIONS" Then
                Dim response = New HttpResponseMessage() With {.StatusCode = HttpStatusCode.OK}
                response.Headers.Add("Access-Control-Allow-Origin", "*")
                response.Headers.Add("Access-Control-Allow-Headers", "Origin, Content-Type, Accept, Authorization")
                response.Headers.Add("Access-Control-Allow-Methods", "*")
                Dim tsc = New TaskCompletionSource(Of HttpResponseMessage)()
                tsc.SetResult(response)
                Return tsc.Task
            End If
            Return MyBase.SendAsync(request, cancellationToken)
        End Function
    End Class



End Module
