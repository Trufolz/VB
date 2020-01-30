Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class InitialMigration
        Inherits DbMigration
    
        Public Overrides Sub Up()
            CreateTable(
                "dbo.Brands",
                Function(c) New With
                    {
                        .Id = c.Int(nullable := False, identity := True),
                        .Name = c.String(nullable := False)
                    }) _
                .PrimaryKey(Function(t) t.Id)
            
            CreateTable(
                "dbo.Cars",
                Function(c) New With
                    {
                        .Id = c.Int(nullable := False, identity := True),
                        .BrandId = c.Int(nullable := False),
                        .Model = c.String(nullable := False),
                        .Year = c.Int(nullable := False),
                        .ColorId = c.Int(nullable := False),
                        .HorsePower = c.Int(nullable := False),
                        .EngineVolume = c.Int(nullable := False),
                        .FuelId = c.Int(nullable := False),
                        .Price = c.Int(nullable := False),
                        .Rating = c.Int(),
                        .ImageId = c.Int(nullable := False)
                    }) _
                .PrimaryKey(Function(t) t.Id) _
                .ForeignKey("dbo.Brands", Function(t) t.BrandId, cascadeDelete := True) _
                .ForeignKey("dbo.Colors", Function(t) t.ColorId, cascadeDelete := True) _
                .ForeignKey("dbo.Fuels", Function(t) t.FuelId, cascadeDelete := True) _
                .ForeignKey("dbo.Images", Function(t) t.ImageId, cascadeDelete := True) _
                .Index(Function(t) t.BrandId) _
                .Index(Function(t) t.ColorId) _
                .Index(Function(t) t.FuelId) _
                .Index(Function(t) t.ImageId)
            
            CreateTable(
                "dbo.Colors",
                Function(c) New With
                    {
                        .Id = c.Int(nullable := False, identity := True),
                        .Name = c.String(nullable := False)
                    }) _
                .PrimaryKey(Function(t) t.Id)
            
            CreateTable(
                "dbo.Fuels",
                Function(c) New With
                    {
                        .Id = c.Int(nullable := False, identity := True),
                        .Name = c.String(nullable := False)
                    }) _
                .PrimaryKey(Function(t) t.Id)
            
            CreateTable(
                "dbo.Images",
                Function(c) New With
                    {
                        .Id = c.Int(nullable := False, identity := True),
                        .Content = c.Binary(nullable := False)
                    }) _
                .PrimaryKey(Function(t) t.Id)
            
        End Sub
        
        Public Overrides Sub Down()
            DropForeignKey("dbo.Cars", "ImageId", "dbo.Images")
            DropForeignKey("dbo.Cars", "FuelId", "dbo.Fuels")
            DropForeignKey("dbo.Cars", "ColorId", "dbo.Colors")
            DropForeignKey("dbo.Cars", "BrandId", "dbo.Brands")
            DropIndex("dbo.Cars", New String() { "ImageId" })
            DropIndex("dbo.Cars", New String() { "FuelId" })
            DropIndex("dbo.Cars", New String() { "ColorId" })
            DropIndex("dbo.Cars", New String() { "BrandId" })
            DropTable("dbo.Images")
            DropTable("dbo.Fuels")
            DropTable("dbo.Colors")
            DropTable("dbo.Cars")
            DropTable("dbo.Brands")
        End Sub
    End Class
End Namespace
