Imports Komis.Models
Imports System.Linq

Namespace CarContext
    Public Class Repository
        Public Sub Seed()
            If Not GetCars().Any Then
                Dim cars = New List(Of Car)() From {
                    New Car() With {
                        .Brand = Brand.Volkswagen,
                        .Model = "Bora",
                        .Year = 2000,
                        .Color = Color.Silver,
                        .HorsePower = 110,
                        .EngineVolume = 1900,
                        .Fuel = Fuel.Diesel,
                        .Price = 4900,
                        .Rating = 1
                    },
                    New Car() With {
                        .Brand = Brand.AlfaRomeo,
                        .Model = "159",
                        .Year = 2009,
                        .Color = Color.Black,
                        .HorsePower = 170,
                        .EngineVolume = 2000,
                        .Fuel = Fuel.Diesel,
                        .Price = 25000,
                        .Rating = 5
                    }
                }
                Using context As New Context.CarContext()
                    cars.ForEach(Function(s) context.Cars.Add(s))
                    context.SaveChanges()
                End Using
            End If
        End Sub

        Public Function GetCars() As List(Of Car)
            Dim result As List(Of Car)
            Using context As New Context.CarContext()
                result = context.Cars.ToList()
            End Using
            Return result
        End Function

        Public Sub AddCar(car As Car)
            Using context As New Context.CarContext()
                context.Cars.Add(car)
                context.SaveChanges()
            End Using
        End Sub

        Public Sub RemoveCar(car As Car)
            Using context As New Context.CarContext()
                context.Cars.Remove(car)
                context.SaveChanges()
            End Using
        End Sub
    End Class
End Namespace