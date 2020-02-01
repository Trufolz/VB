Imports Komis.Utils
Imports Komis.Context

Public Class NewCarForm
    Private Property Inputs As List(Of Object)
    Public Sub New()
        InitializeComponent()
        ConfigureComponents()
        Inputs = New List(Of Object) From {
            NewCarBrandDropdown.SelectedItem,
            NewCarModelInput.Text,
            NewCarYearDropdown.SelectedItem,
            NewCarColorDropdown.SelectedItem,
            NewCarFuelDropdown.SelectedItem,
            NewCarHorsePowerInput.Value,
            NewCarEngineVolumeInput.Value,
            NewCarPriceInput.Value
        }
    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        If Inputs.All(Function(input) input IsNot Nothing) Then
            Dim newDomainCar = New Domain.Car With
            {
                .Brand = DirectCast(NewCarBrandDropdown.SelectedItem, Domain.Brand),
                .Model = NewCarModelInput.Text,
                .Year = DirectCast(NewCarYearDropdown.SelectedItem, Integer),
                .HorsePower = NewCarHorsePowerInput.Value,
                .EngineVolume = NewCarEngineVolumeInput.Value,
                .Fuel = DirectCast(NewCarFuelDropdown.SelectedItem, Domain.Fuel),
                .Color = DirectCast(NewCarColorDropdown.SelectedItem, Domain.Color),
                .Price = NewCarPriceInput.Value
            }

            Dim newContextCar = newDomainCar.ToContext()
            Using context As New Context.CarContext()
                context.Cars.Add(newContextCar)
                context.SaveChanges()
            End Using
            MainForm.CarList.DataSource.Add(newDomainCar)
            Hide()
            MsgBox(newDomainCar.Brand.Name + " " + newDomainCar.Model + " saved!")
        End If
    End Sub

    Private Sub DismissButton_Click(sender As Object, e As EventArgs) Handles DismissButton.Click
        Hide()
    End Sub

    Private Sub ConfigureComponents()
        Using context As New Context.CarContext()
            NewCarBrandDropdown.DataSource = context.Brands.ToList.Select(Function(brand) brand.ToDomain()).ToList
            NewCarYearDropdown.DataSource = GetYears()
            NewCarColorDropdown.DataSource = context.Colors.ToList.Select(Function(color) color.ToDomain()).ToList
            NewCarFuelDropdown.DataSource = context.Fuels.ToList.Select(Function(fuel) fuel.ToDomain()).ToList
        End Using
    End Sub
End Class