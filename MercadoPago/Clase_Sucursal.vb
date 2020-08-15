Public Class Clase_Location
    Public Property street_number As String
    Public Property street_name As String
    Public Property city_name As String
    Public Property state_name As String
    Public Property latitude As Double
    Public Property longitude As Double
    Public Property reference As String

End Class
<Serializable>
Public Class Clase_Sucursal
    Public Property name As String
    Public Property location As Clase_Location
    Public Property external_id As String


End Class
