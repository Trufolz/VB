Imports Komis.Context
Imports Komis.Utils
Imports Komis.Domain

Public Class Form
    Public Sub New()
        InitializeComponent()
        ConfigureFilters()
    End Sub

    Private Sub BrandDropdown_Click(sender As Object, e As EventArgs) Handles BrandDropdown.SelectionChangeCommitted
        ModelLabel.Show()
        ModelInput.Show()
    End Sub

    Private Sub ValidateInput(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles HorsePowerFromInput.KeyDown, HorsePowerToInput.KeyDown, EngineVolumeFromInput.KeyDown, EngineVolumeToInput.KeyDown
        Dim isDigit As Boolean =
            Char.IsDigit(ChrW(e.KeyValue)) Or
            e.KeyCode >= Keys.NumPad0 And
            e.KeyCode <= Keys.NumPad9
        e.Handled = isDigit
    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        Dim cars As List(Of Context.Car)
        Using context As New Context.CarContext()
            cars = context.Cars.ToList 'It's the first and the last time I'm commiting this crime

            If BrandDropdown.SelectedItem IsNot Nothing Then
                cars = cars.Where(Function(car) car.BrandId = DirectCast(BrandDropdown.SelectedItem, Domain.Brand).Id).ToList
            End If
            If Not String.IsNullOrEmpty(ModelInput.Text) Then
                cars = cars.Where(Function(car) car.Model = ModelInput.Text).ToList
            End If
            If YearFromDropdown.SelectedItem IsNot Nothing Then
                cars = cars.Where(Function(car) car.Year >= Convert.ToInt32(YearFromDropdown.Text)).ToList
            End If
            If YearToDropdown.SelectedItem IsNot Nothing Then
                cars = cars.Where(Function(car) car.Year <= Convert.ToInt32(YearToDropdown.Text)).ToList
            End If
            If Not String.IsNullOrEmpty(HorsePowerFromInput.Text) Then
                cars = cars.Where(Function(car) car.HorsePower >= Convert.ToInt32(HorsePowerFromInput.Text)).ToList
            End If
            If Not String.IsNullOrEmpty(HorsePowerToInput.Text) Then
                cars = cars.Where(Function(car) car.HorsePower <= Convert.ToInt32(HorsePowerToInput.Text)).ToList
            End If
            If Not String.IsNullOrEmpty(EngineVolumeFromInput.Text) Then
                cars = cars.Where(Function(car) car.EngineVolume >= Convert.ToInt32(EngineVolumeFromInput.Text)).ToList
            End If
            If Not String.IsNullOrEmpty(EngineVolumeToInput.Text) Then
                cars = cars.Where(Function(car) car.EngineVolume <= Convert.ToInt32(EngineVolumeToInput.Text)).ToList
            End If
            If ColorDropdown.SelectedItem IsNot Nothing Then
                cars = cars.Where(Function(car) car.Color.Id = DirectCast(ColorDropdown.SelectedItem, Domain.Color).Id).ToList
            End If
            If FuelDropdown.SelectedItem IsNot Nothing Then
                cars = cars.Where(Function(car) car.Fuel.Id = DirectCast(FuelDropdown.SelectedItem, Domain.Fuel).Id).ToList
            End If
            CarList.DataSource = cars.Select(Function(car) car.ToDomain()).ToList
        End Using
    End Sub

    Private Sub ConfigureFilters()
        Using context As New Context.CarContext()
            BrandDropdown.DataSource = context.Brands.ToList.Select(Function(brand) brand.ToDomain()).ToList
            YearFromDropdown.DataSource = GetYears()
            YearToDropdown.DataSource = GetYears()
            ColorDropdown.DataSource = context.Colors.ToList.Select(Function(color) color.ToDomain()).ToList
            FuelDropdown.DataSource = context.Fuels.ToList.Select(Function(fuel) fuel.ToDomain()).ToList
        End Using

        BrandDropdown.SelectedItem = Nothing
        YearFromDropdown.SelectedItem = Nothing
        YearToDropdown.SelectedItem = Nothing
        ColorDropdown.SelectedItem = Nothing
        FuelDropdown.SelectedItem = Nothing

        ModelLabel.Hide()
        ModelInput.Hide()
    End Sub

    Private Sub ClearFiltersButton_Click(sender As Object, e As EventArgs) Handles ClearFiltersButton.Click
        BrandDropdown.SelectedItem = Nothing
        ModelInput.Text = Nothing
        YearFromDropdown.SelectedItem = Nothing
        YearToDropdown.SelectedItem = Nothing
        EngineVolumeFromInput.Text = Nothing
        EngineVolumeToInput.Text = Nothing
        HorsePowerFromInput.Text = Nothing
        HorsePowerToInput.Text = Nothing
        ColorDropdown.SelectedItem = Nothing
        FuelDropdown.SelectedItem = Nothing
    End Sub

    Private Sub CarList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CarList.SelectedIndexChanged
        CarImagePanel.Image = DirectCast(CarList.SelectedItem, Domain.Car).Image
    End Sub
End Class
