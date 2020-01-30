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
            .Image = contextCar.Image.ConvertToImage()
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
    Private Function ConvertToImage(ByVal byteArray As Byte()) As Image
        Dim imageConverter As New ImageConverter()
        Dim image As Image = DirectCast(imageConverter.ConvertTo(byteArray, GetType(Image)), Image)
        Return image
    End Function

    <Extension()>
    Private Function ConvertToByte(ByVal image As Image) As Byte()
        Dim imageConverter As New ImageConverter()
        Dim imageByte As Byte() = DirectCast(imageConverter.ConvertTo(image, GetType(Byte())), Byte())
        Return imageByte
    End Function
End Module
