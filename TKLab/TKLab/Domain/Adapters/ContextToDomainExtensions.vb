Imports System.IO
Imports System.Runtime.CompilerServices
Imports Komis.Context

Public Module ContextToDomainExtensions
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
    Public Function ToDomain(ByVal contextBrand As Context.Brand) As Domain.Brand
        Return New Domain.Brand With {
            .Id = contextBrand.Id,
            .Name = contextBrand.Name
        }
    End Function

    <Extension()>
    Public Function ToDomain(ByVal contextColor As Context.Color) As Domain.Color
        Return New Domain.Color With {
            .Id = contextColor.Id,
            .Name = contextColor.Name
        }
    End Function

    <Extension()>
    Public Function ToDomain(ByVal contextFuel As Context.Fuel) As Domain.Fuel
        Return New Domain.Fuel With {
            .Id = contextFuel.Id,
            .Name = contextFuel.Name
        }
    End Function

    <Extension()>
    Private Function ToDomain(ByVal contextImage As Context.Image) As Domain.Image
        Using memoryStream As New MemoryStream(contextImage.Content)
            Return New Domain.Image With
            {
                .Id = contextImage.Id,
                .Content = Drawing.Image.FromStream(memoryStream)
            }
        End Using
    End Function
End Module
