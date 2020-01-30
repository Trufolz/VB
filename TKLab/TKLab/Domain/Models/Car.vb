Namespace Domain
    Public Class Car
        Public Property Id As Integer
        Public Property Brand As Brand
        Public Property Model As String
        Public Property Year As Integer
        Public Property Color As Color
        Public Property HorsePower As Integer
        Public Property EngineVolume As Integer
        Public Property Fuel As Fuel
        Public Property Price As Integer
        Public Property Rating As Integer
        Public Property Image As Image

        Public Overrides Function ToString() As String
            Return $"{Brand} {Model} {ParseToFloatingPointNumber(EngineVolume)} {Fuel} {HorsePower}HP {Year}"
        End Function

        Private Function ParseToFloatingPointNumber(num As Integer) As String
            Dim stringNum = (Convert.ToDecimal(num) / 1000).ToString()
            If stringNum.Contains(".") Then
                Return stringNum
            Else
                Return $"{stringNum}.0"
            End If
        End Function

    End Class
End Namespace