Imports System.Web.Http
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Serialization

Public Class WebApiApplication : Inherits System.Web.HttpApplication

    Protected Sub Application_Start()
        GlobalConfiguration.Configure(AddressOf WebApiConfig.Register)
        'formatting json
        Dim formatters = GlobalConfiguration.Configuration.Formatters
        Dim jsonFormatter = formatters.JsonFormatter
        Dim settings = jsonFormatter.SerializerSettings
        settings.Formatting = Formatting.Indented
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
    End Sub

End Class
