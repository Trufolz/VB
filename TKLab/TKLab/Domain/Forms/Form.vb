Imports Komis.Context
Imports Komis.Utils
Imports Komis.Domain

Public Class Form
    Private Property SelectedCar As Domain.Car
    Private Property RadioButtons As List(Of RadioButton)
    Public Sub New()
        InitializeComponent()
        ConfigureComponents()
        RadioButtons = New List(Of RadioButton) From {
            RatingButton1, RatingButton2, RatingButton3, RatingButton4, RatingButton5
        }
    End Sub

    Private Sub BrandDropdown_Click(sender As Object, e As EventArgs) Handles BrandDropdown.SelectionChangeCommitted
        ModelInput.Enabled = True
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

    Private Sub ConfigureComponents()
        Using context As New Context.CarContext()
            BrandDropdown.DataSource = context.Brands.ToList.Select(Function(brand) brand.ToDomain()).ToList
            YearFromDropdown.DataSource = GetYears()
            YearToDropdown.DataSource = GetYears()
            ColorDropdown.DataSource = context.Colors.ToList.Select(Function(color) color.ToDomain()).ToList
            FuelDropdown.DataSource = context.Fuels.ToList.Select(Function(fuel) fuel.ToDomain()).ToList
        End Using

        ClearFilters()
        RatingPanel.Hide()
        DetailsPanel.Hide()
    End Sub

    Private Sub ClearFiltersButton_Click(sender As Object, e As EventArgs) Handles ClearFiltersButton.Click
        ClearSelections()
    End Sub

    Private Sub ClearSelections()
        ClearFilters()

        SelectedCar = Nothing
        CarList.SelectedItem = Nothing
        CarList.DataSource = Nothing
        CarList.Items.Clear()

        RatingPanel.Hide()
        DetailsPanel.Hide()
    End Sub

    Private Sub ClearFilters()
        BrandDropdown.SelectedItem = Nothing
        ModelInput.Enabled = False
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
        SelectedCar = DirectCast(CarList.SelectedItem, Domain.Car)
        If SelectedCar IsNot Nothing Then
            CarImagePanel.Image = SelectedCar.Image.Content
            FillSelectedCarDetails()
            RatingPanel.Show()
            CheckRatingOnCarSelect()
        Else
            CarImagePanel.Image = Nothing
            DetailsPanel.Hide()
            RatingPanel.Hide()
        End If
    End Sub

    Private Sub CheckRatingOnCarSelect()
        If SelectedCar.Rating >= 1 And SelectedCar.Rating <= 5 Then
            Dim buttonToCheck = RadioButtons.FirstOrDefault(Function(button) button.Text = SelectedCar.Rating.ToString())
            buttonToCheck.Checked = True
        End If
    End Sub

    Private Sub FillSelectedCarDetails()
        DetailsPanel.Show()
        SelectedCarBrand.Text = SelectedCar.Brand.Name
        SelectedCarModel.Text = SelectedCar.Model
        SelectedCarYear.Text = SelectedCar.Year.ToString
        SelectedCarHorsePower.Text = SelectedCar.HorsePower.ToString
        SelectedCarEngineVolume.Text = SelectedCar.EngineVolume.ToString
        SelectedCarFuel.Text = SelectedCar.Fuel.Name
        SelectedCarColor.Text = SelectedCar.Color.Name
    End Sub

    Private Sub RatingButton_CheckedChanged(sender As Object, e As EventArgs) Handles RatingButton1.CheckedChanged, RatingButton2.CheckedChanged, RatingButton3.CheckedChanged, RatingButton4.CheckedChanged, RatingButton5.CheckedChanged
        RadioButtons.Where(Function(button) button.Text IsNot sender.Text).ToList.ForEach(Function(button) button.Checked = False)
        SelectedCar.Rating = Convert.ToInt32(sender.Text)
    End Sub

    Private Sub SubmitRatingButton_Click(sender As Object, e As EventArgs) Handles SubmitRatingButton.Click
        If RadioButtons.Any(Function(button) button.Checked = True) Then
            Using context As New Context.CarContext()
                context.Cars.SingleOrDefault(Function(car) car.Id = SelectedCar.Id).Rating = SelectedCar.Rating
                context.SaveChanges()
            End Using
            MsgBox("Rate saved!")
        End If
    End Sub

End Class
