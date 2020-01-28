Imports System
Imports System.Data.Entity
Imports System.Linq
Imports Komis.Models

Namespace Context
    Public Class CarContext
        Inherits DbContext

        Public Sub New()
            MyBase.New("name=CarContext")
        End Sub

        Public Property Cars() As DbSet(Of Car)

        Protected Overrides Sub OnModelCreating(ByVal modelBuilder As DbModelBuilder)
            modelBuilder.Entity(Of Car).ToTable("Cars")
            modelBuilder.Entity(Of Car).HasKey(Function(car) car.Id)
            modelBuilder.Entity(Of Car).Property(Function(car) car.Id).IsRequired()
            modelBuilder.Entity(Of Car).Property(Function(car) car.Brand).IsRequired()
            modelBuilder.Entity(Of Car).Property(Function(car) car.Model).IsRequired()
            modelBuilder.Entity(Of Car).Property(Function(car) car.Year).IsRequired()
            modelBuilder.Entity(Of Car).Property(Function(car) car.Color).IsRequired()
            modelBuilder.Entity(Of Car).Property(Function(car) car.HorsePower).IsRequired()
            modelBuilder.Entity(Of Car).Property(Function(car) car.EngineVolume).IsRequired()
            modelBuilder.Entity(Of Car).Property(Function(car) car.Fuel).IsRequired()
            modelBuilder.Entity(Of Car).Property(Function(car) car.Price).IsRequired()
            modelBuilder.Entity(Of Car).Property(Function(car) car.Rating).IsOptional()
        End Sub
    End Class
End Namespace