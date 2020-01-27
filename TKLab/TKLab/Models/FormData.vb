Public Class FormData
    Private _colors = System.Enum.GetValues(GetType(Color))
    Private _fuel = System.Enum.GetValues(GetType(Fuel))
    Private _brands = System.Enum.GetValues(GetType(Brand))
    Private _volkswagenModels = System.Enum.GetValues(GetType(Volkswagen))
    Private _toyotaModels = System.Enum.GetValues(GetType(Toyota))
    Private _audiModels = System.Enum.GetValues(GetType(Audi))
    Private _skodaModels = System.Enum.GetValues(GetType(Skoda))
    Private _years = Enumerable.Range(1990, 31).ToArray

    Public ReadOnly Property Colors()
        Get
            Return _colors
        End Get
    End Property

    Public ReadOnly Property FuelTypes()
        Get
            Return _fuel
        End Get
    End Property

    Public ReadOnly Property Brands()
        Get
            Return _brands
        End Get
    End Property

    Public ReadOnly Property VolkswagenModels()
        Get
            Return _volkswagenModels
        End Get
    End Property

    Public ReadOnly Property AudiModels()
        Get
            Return _audiModels
        End Get
    End Property

    Public ReadOnly Property SkodaModels()
        Get
            Return _skodaModels
        End Get
    End Property

    Public ReadOnly Property ToyotaModels()
        Get
            Return _toyotaModels
        End Get
    End Property

    Public ReadOnly Property Years()
        Get
            Return _years
        End Get
    End Property
End Class
