Imports System.Net
Imports System.Net.Http

Public Class Form1

    Dim Token As String = "APP_USR-5657127103804050-061610-c60964b72c27c20faf9283746fa94d21-65209989"
    Dim Collector_Id As String = "65209989"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls Or SecurityProtocolType.Tls11 Or SecurityProtocolType.Tls12
    End Sub

    Private Sub B_Generar_Usuario_Click(sender As Object, e As EventArgs) Handles B_Generar_Usuario.Click
        Dim objectRequest = New Clase_Usuario()
        objectRequest.site_id = "MLA"

        Dim content = New StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(objectRequest))

        Dim client = New HttpClient()
        Dim result = client.PostAsync("https://api.mercadopago.com/users/test_user?access_token=" & Token, content).Result.Content.ReadAsStringAsync().Result

        Dim response = Newtonsoft.Json.JsonConvert.DeserializeObject(Of Clase_Usuario_Respuesta)(result)

        If InStr(result, "error", CompareMethod.Text) = 0 Then
            TB_Respuesta.Text &= "Id: " & response.id & vbCrLf
            TB_Respuesta.Text &= "Nickname: " & response.nickname & vbCrLf
            TB_Respuesta.Text &= "Contraseña: " & response.password & vbCrLf
            TB_Respuesta.Text &= "Status: " & response.site_status & vbCrLf
            TB_Respuesta.Text &= "EMail: " & response.email & vbCrLf
        Else
            TB_Respuesta.Text &= result
        End If
    End Sub

    Private Sub B_Generar_Sucursal_Click(sender As Object, e As EventArgs) Handles B_Generar_Sucursal.Click
        Dim objectRequest = New Clase_Sucursal()
        objectRequest.name = "Prueba"
        objectRequest.location = New Clase_Location()
        objectRequest.location.street_number = 3039
        objectRequest.location.street_name = "Caseros"
        objectRequest.location.city_name = "Cochengo"
        objectRequest.location.state_name = "Canelones"
        objectRequest.location.latitude = -32.8897322
        objectRequest.location.longitude = -68.8443275
        objectRequest.location.reference = "3er Piso"
        Dim content = New StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(objectRequest))

        Dim client = New HttpClient()
        Dim result = client.PostAsync("https://api.mercadopago.com/users/" & Collector_Id & "/stores?access_token=" & Token, content).Result.Content.ReadAsStringAsync().Result
        '   TB_Respuesta.Text = result

        Dim response = Newtonsoft.Json.JsonConvert.DeserializeObject(Of Clase_Sucursal_Respuesta)(result)

        If InStr(result, "error", CompareMethod.Text) = 0 Then
            TB_Respuesta.Text &= "Id: " & response.id & vbCrLf
            TB_Respuesta.Text &= "name: " & response.name & vbCrLf
            TB_Respuesta.Text &= "Date creation: " & response.date_creation & vbCrLf

            TB_Respuesta.Text &= "location: " & response.location.street_number & vbCrLf
            TB_Respuesta.Text &= "reference: " & response.location.reference & vbCrLf
            TB_Respuesta.Text &= "latitude: " & response.location.latitude & vbCrLf
            TB_Respuesta.Text &= "longitude: " & response.location.longitude & vbCrLf
        Else
            TB_Respuesta.Text &= result
        End If
    End Sub
End Class
