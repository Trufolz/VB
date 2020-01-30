Imports System.IO
Imports System.Linq
Imports Komis.Context

Namespace CarContext
    Public Class Repository
        Public Function GetCars() As IQueryable(Of Car)
            Dim result As IQueryable(Of Car)
            Using context As New Context.CarContext()
                result = context.Cars
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

        Private Function ConvertImageToByte(imagePath As String) As Byte()
            Dim image As Image = Image.FromFile(imagePath)
            Dim imageConverter As New ImageConverter()
            Dim imageByte As Byte() = DirectCast(imageConverter.ConvertTo(image, GetType(Byte())), Byte())
            Return imageByte
        End Function

        Private Function ConvertByteToImage(byteArray As Byte()) As Image
            Dim imageConverter As New ImageConverter()
            Dim image As Image = DirectCast(imageConverter.ConvertTo(byteArray, GetType(Image)), Image)
            Return image
        End Function
    End Class
End Namespace