Namespace Models

    Public Class Car
        Private _id As Integer
        Property Id As Integer
            Get
                Return _id
            End Get
            Set(ByVal value As Integer)
                _id = value
            End Set
        End Property

        Public _brand As Brand
        Property Brand As Brand
            Get
                Return _brand
            End Get
            Set(ByVal value As Brand)
                _brand = value
            End Set
        End Property

        Public _model As String
        Property Model As String
            Get
                Return _model
            End Get
            Set(ByVal value As String)
                _model = value
            End Set
        End Property

        Public _year As Integer
        Property Year As Integer
            Get
                Return _year
            End Get
            Set(ByVal value As Integer)
                _year = value
            End Set
        End Property

        Public _color As Color
        Property Color As Color
            Get
                Return _color
            End Get
            Set(ByVal value As Color)
                _color = value
            End Set
        End Property

        Public _horsePower As Integer
        Property HorsePower As Integer
            Get
                Return _horsePower
            End Get
            Set(ByVal value As Integer)
                _horsePower = value
            End Set
        End Property

        Public _engineVolume As Integer
        Property EngineVolume As Integer
            Get
                Return _engineVolume
            End Get
            Set(ByVal value As Integer)
                _engineVolume = value
            End Set
        End Property

        Public _fuel As Fuel
        Property Fuel As Fuel
            Get
                Return _fuel
            End Get
            Set(ByVal value As Fuel)
                _fuel = value
            End Set
        End Property

        Public _price As Integer
        Property Price As Integer
            Get
                Return _price
            End Get
            Set(ByVal value As Integer)
                _price = value
            End Set
        End Property

        Public _rating As Integer
        Property Rating As Integer
            Get
                Return _rating
            End Get
            Set(ByVal value As Integer)
                _rating = value
            End Set
        End Property

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

    Public Enum Fuel
        Diesel
        Gasoline
        Hybrid
        Electric
    End Enum

    Public Enum Color
        Black
        White
        Red
        Blue
        Silver
        Green
        Yellow
        Maroon
        Purple
    End Enum

    Public Enum Brand
        Fiat
        Volkswagen
        BMW
        Audi
        Skoda
        Seat
        Kia
        Hyundai
        Toyota
        Honda
        Nissan
        Peugeot
        Renault
        Citroen
        Volvo
        Ford
        AlfaRomeo
    End Enum
End Namespace