Public Class Clase_Location
    Public Property street_number As String
    Public Property street_name As String
    Public Property city_name As String
    Public Property state_name As String
    Public Property latitude As Double
    Public Property longitude As Double
    Public Property reference As String
    Sub New(ByVal streetnumber As String, ByVal streetname As String, ByVal cityname As String, ByVal statename As String, ByVal lat As String, ByVal lon As String, ByVal refe As String)
        street_number = streetnumber
        street_name = streetname
        city_name = cityname
        state_name = statename
        latitude = lat
        longitude = lon
        reference = refe
    End Sub
End Class

Public Class Time_Openclose
    Public Property open As String
    Public Property close As String
    Sub New(ByVal opentime As String, ByVal closetime As String)
        open = opentime
        close = closetime
    End Sub
End Class
Public Class Business_Hours
    Public Property monday As New List(Of Time_Openclose)
    Public Property tuesday As New List(Of Time_Openclose)
    Public Property wednesday As New List(Of Time_Openclose)
    Public Property thursday As New List(Of Time_Openclose)
    Public Property friday As New List(Of Time_Openclose)
    Public Property saturday As New List(Of Time_Openclose)
    Public Property sunday As New List(Of Time_Openclose)

End Class

<Serializable>
Public Class Clase_Sucursal
    Public Property name As String
    Public Property location As Clase_Location
    Public Property external_id As String
    Public Property business_hours As Business_Hours


End Class
