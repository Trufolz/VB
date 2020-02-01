Imports System.Runtime.CompilerServices
Imports Komis.Context

Public Module DomainToContextExtensions
    <Extension()>
    Public Function ToContext(ByVal domainCar As Domain.Car) As Context.Car
        Return New Context.Car With {
            .BrandId = domainCar.Brand.Id,
            .ColorId = domainCar.Color.Id,
            .EngineVolume = domainCar.EngineVolume,
            .FuelId = domainCar.Fuel.Id,
            .HorsePower = domainCar.HorsePower,
            .Model = domainCar.Model,
            .Price = domainCar.Price,
            .Rating = domainCar.Rating,
            .Year = domainCar.Year,
            .ImageId = 3
        }
    End Function

    <Extension()>
    Public Function ToContext(ByVal domainImage As Domain.Image) As Context.Image
        Dim imageConverter As New ImageConverter()
        Dim content As Byte() = DirectCast(imageConverter.ConvertTo(domainImage.Content, GetType(Byte())), Byte())
        Return New Context.Image With {
            .Content = content
        }
    End Function
End Module
