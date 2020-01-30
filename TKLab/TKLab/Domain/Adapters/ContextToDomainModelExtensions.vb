Imports System.IO
Imports System.Runtime.CompilerServices
Imports Komis.Context

Public Module ContextToDomainModelExtensions
    <Extension()>
    Public Function ToDomain(ByVal contextCar As Car) As Domain.Car
        Return New Domain.Car With {
            .Id = contextCar.Id,
            .Brand = contextCar.Brand.ToDomain(),
            .Color = contextCar.Color.ToDomain(),
            .EngineVolume = contextCar.EngineVolume,
            .Fuel = contextCar.Fuel.ToDomain(),
            .HorsePower = contextCar.HorsePower,
            .Model = contextCar.Model,
            .Price = contextCar.Price,
            .Rating = contextCar.Rating,
            .Year = contextCar.Year,
            .Image = contextCar.Image.ToDomain()
        }
    End Function

    <Extension()>
    Public Function ToDomain(ByVal contextBrand As Brand) As Domain.Brand
        Return New Domain.Brand With {
            .Id = contextBrand.Id,
            .Name = contextBrand.Name
        }
    End Function

    <Extension()>
    Public Function ToDomain(ByVal contextColor As Color) As Domain.Color
        Return New Domain.Color With {
            .Id = contextColor.Id,
            .Name = contextColor.Name
        }
    End Function

    <Extension()>
    Public Function ToDomain(ByVal contextFuel As Fuel) As Domain.Fuel
        Return New Domain.Fuel With {
            .Id = contextFuel.Id,
            .Name = contextFuel.Name
        }
    End Function

    <Extension()>
    Public Function ToDomain(ByVal contextImage As Context.Image) As Domain.Image
        'Dim imageConverter As New ImageConverter()
        'Dim content As Drawing.Image = DirectCast(imageConverter.ConvertTo(contextImage.Content, GetType(Drawing.Image)), Drawing.Image)
        'Return New Domain.Image With {
        '    .Id = contextImage.Id,
        '    .Content = content
        '}
        Using memoryStream As New MemoryStream(contextImage.Content)
            Return New Domain.Image With
            {
                .Content = Drawing.Image.FromStream(memoryStream)
            }
        End Using
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
