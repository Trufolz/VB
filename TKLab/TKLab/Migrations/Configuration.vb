Imports System.Data.Entity.Migrations
Imports Komis.Context

Namespace Migrations

    Friend NotInheritable Class Configuration
        Inherits DbMigrationsConfiguration(Of Context.CarContext)

        Public Sub New()
            AutomaticMigrationsEnabled = False
        End Sub

        Protected Overrides Sub Seed(context As Context.CarContext)
            If Not context.Brands.Any Then
                Dim brands = New List(Of Brand)() From {
                    New Brand() With {.Name = "Volkswagen"},
                    New Brand() With {.Name = "Alfa Romeo"}
                }
                context.Brands.AddRange(brands)
                context.SaveChanges()
            End If

            If Not context.Colors.Any Then
                Dim colors = New List(Of Color)() From {
                    New Color() With {.Name = "Silver"},
                    New Color() With {.Name = "Black"}
                }
                context.Colors.AddRange(colors)
                context.SaveChanges()
            End If

            If Not context.Fuels.Any Then
                Dim fuels = New List(Of Fuel)() From {
                    New Fuel() With {.Name = "Diesel"},
                    New Fuel() With {.Name = "Gasoline"},
                    New Fuel() With {.Name = "Hybrid"},
                    New Fuel() With {.Name = "Electric"}
                }
                context.Fuels.AddRange(fuels)
                context.SaveChanges()
            End If

            If Not context.Images.Any Then
                Dim alfa As Domain.Image = New Domain.Image With {.Content = My.Resources.alfa159}
                Dim bora As Domain.Image = New Domain.Image With {.Content = My.Resources.vwbora}
                Dim deafultCar As Domain.Image = New Domain.Image With {.Content = My.Resources.deafultcar}

                Dim images = New List(Of Context.Image)() From {
                    New Context.Image() With {.Content = bora.ToContext().Content},
                    New Context.Image() With {.Content = alfa.ToContext().Content},
                    New Context.Image() With {.Content = deafultCar.ToContext().Content}
                }
                context.Images.AddRange(images)
                context.SaveChanges()
            End If

            If Not context.Cars.Any Then
                Dim cars = New List(Of Car)() From {
                    New Car() With {
                        .BrandId = 1,
                        .Model = "Bora",
                        .Year = 2000,
                        .ColorId = 1,
                        .HorsePower = 110,
                        .EngineVolume = 1900,
                        .FuelId = 1,
                        .Price = 4900,
                        .Rating = 1,
                        .ImageId = 1
                    },
                    New Car() With {
                        .BrandId = 2,
                        .Model = "159",
                        .Year = 2009,
                        .ColorId = 2,
                        .HorsePower = 170,
                        .EngineVolume = 2000,
                        .FuelId = 1,
                        .Price = 25000,
                        .Rating = 5,
                        .ImageId = 2
                    }
                }
                context.Cars.AddRange(cars)
                context.SaveChanges()
            End If
        End Sub
    End Class
End Namespace
