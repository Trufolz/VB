Imports System
Imports System.Data.Entity
Imports System.Linq

Namespace Context
    Public Class CarContext
        Inherits DbContext

        Public Sub New()
            MyBase.New("name=CarContext")
        End Sub

        Public Property Cars() As DbSet(Of Car)
        Public Property Brands() As DbSet(Of Brand)
        Public Property Colors() As DbSet(Of Color)
        Public Property Fuels() As DbSet(Of Fuel)

        Protected Overrides Sub OnModelCreating(ByVal modelBuilder As DbModelBuilder)
            modelBuilder.Entity(Of Car).ToTable("Cars")
            modelBuilder.Entity(Of Brand).ToTable("Brands")
            modelBuilder.Entity(Of Color).ToTable("Colors")
            modelBuilder.Entity(Of Fuel).ToTable("Fuels")

            modelBuilder.Entity(Of Car).HasKey(Function(car) car.Id)
            modelBuilder.Entity(Of Car).HasRequired(Function(car) car.Brand)
            modelBuilder.Entity(Of Car).HasRequired(Function(car) car.Color)
            modelBuilder.Entity(Of Car).HasRequired(Function(car) car.Fuel)

            modelBuilder.Entity(Of Car).Property(Function(car) car.Id).IsRequired()
            modelBuilder.Entity(Of Car).Property(Function(car) car.Model).IsRequired()
            modelBuilder.Entity(Of Car).Property(Function(car) car.Year).IsRequired()
            modelBuilder.Entity(Of Car).Property(Function(car) car.HorsePower).IsRequired()
            modelBuilder.Entity(Of Car).Property(Function(car) car.EngineVolume).IsRequired()
            modelBuilder.Entity(Of Car).Property(Function(car) car.Price).IsRequired()
            modelBuilder.Entity(Of Car).Property(Function(car) car.Rating).IsOptional()

            modelBuilder.Entity(Of Brand).Property(Function(brand) brand.Name).IsRequired()
            modelBuilder.Entity(Of Color).Property(Function(color) color.Name).IsRequired()
            modelBuilder.Entity(Of Fuel).Property(Function(fuel) fuel.Name).IsRequired()
        End Sub
    End Class
End Namespace