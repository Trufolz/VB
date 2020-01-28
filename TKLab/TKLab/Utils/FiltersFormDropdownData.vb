Imports Komis.Models

Namespace Utils

    Public Class FiltersFormDropdownData
        Private _colors = System.Enum.GetValues(GetType(Color))
        Private _fuel = System.Enum.GetValues(GetType(Fuel))
        Private _brands = System.Enum.GetValues(GetType(Brand))
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

        Public ReadOnly Property Years()
            Get
                Return _years
            End Get
        End Property
    End Class
End Namespace

