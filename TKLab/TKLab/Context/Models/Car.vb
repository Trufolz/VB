Namespace Context
    Public Class Car
        Public Property Id As Integer
        Public Property BrandId As Integer
        Public Property Model As String
        Public Property Year As Integer
        Public Property ColorId As Integer
        Public Property HorsePower As Integer
        Public Property EngineVolume As Integer
        Public Property FuelId As Integer
        Public Property Price As Integer
        Public Property Rating As Integer
        Public Property ImageId As Integer

        Public Overridable Property Brand As Brand
        Public Overridable Property Color As Color
        Public Overridable Property Fuel As Fuel
        Public Overridable Property Image As Image
    End Class
End Namespace