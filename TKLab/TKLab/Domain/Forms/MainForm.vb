Imports Komis.Context
Imports Komis.Utils
Imports Komis.Domain

Public Class MainForm
    Private Property SelectedCar As Domain.Car
    Private Property RadioButtons As List(Of RadioButton)
    Public Sub New()
        InitializeComponent()
        ConfigureComponentsOnInit()
        RadioButtons = New List(Of RadioButton) From {
            RatingButton1, RatingButton2, RatingButton3, RatingButton4, RatingButton5
        }
    End Sub

    'EVENT HANDLERS

    Private Sub BrandDropdown_Click(sender As Object, e As EventArgs) Handles BrandDropdown.SelectionChangeCommitted
        ModelInput.Enabled = True
    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        FetchCars()
    End Sub

    Private Sub ClearFiltersButton_Click(sender As Object, e As EventArgs) Handles ClearFiltersButton.Click
        ClearSelections()
    End Sub

    Private Sub CarList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CarList.SelectedIndexChanged
        SelectedCar = DirectCast(CarList.SelectedItem, Domain.Car)
        If SelectedCar IsNot Nothing Then
            CarImagePanel.Image = SelectedCar.Image.Content
            FillSelectedCarDetails()
            RatingPanel.Show()
            CheckRatingOnCarSelect()
            RemoveCarButton.Enabled = True
        Else
            HandleNoCarSelected()
        End If
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

    Private Sub AddCarButton_Click(sender As Object, e As EventArgs) Handles AddCarButton.Click
        NewCarForm.Show()
    End Sub

    Private Sub RemoveCarButton_Click(sender As Object, e As EventArgs) Handles RemoveCarButton.Click
        If SelectedCar IsNot Nothing Then
            Using context As New Context.CarContext()
                Dim carToRemove = context.Cars.SingleOrDefault(Function(car) car.Id = SelectedCar.Id)
                context.Cars.Remove(carToRemove)
                context.SaveChanges()
            End Using
            MsgBox(SelectedCar.Brand.Name + " " + SelectedCar.Model + " removed!")
            SelectedCar = Nothing
            FetchCars()
        End If
    End Sub

    'PRIVATE METHODS

    Private Sub ConfigureComponentsOnInit()
        Using context As New Context.CarContext()
            BrandDropdown.DataSource = context.Brands.ToList.Select(Function(brand) brand.ToDomain()).ToList
            YearFromDropdown.DataSource = GetYears()
            YearToDropdown.DataSource = GetYears()
            ColorDropdown.DataSource = context.Colors.ToList.Select(Function(color) color.ToDomain()).ToList
            FuelDropdown.DataSource = context.Fuels.ToList.Select(Function(fuel As Context.Fuel) fuel.ToDomain()).ToList
        End Using

        ClearFilters()
        RatingPanel.Hide()
        DetailsPanel.Hide()
        RemoveCarButton.Enabled = False
    End Sub

    Private Sub CheckRatingOnCarSelect()
        If SelectedCar.Rating >= 1 And SelectedCar.Rating <= 5 Then
            Dim buttonToCheck = RadioButtons.FirstOrDefault(Function(button) button.Text = SelectedCar.Rating.ToString())
            buttonToCheck.Checked = True
        End If
    End Sub

    Private Sub ClearSelections()
        ClearFilters()

        SelectedCar = Nothing
        CarList.SelectedItem = Nothing
        CarList.DataSource = Nothing
        CarList.Items.Clear()

        RatingPanel.Hide()
        DetailsPanel.Hide()
        RemoveCarButton.Enabled = False
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
        PriceFromInput.Text = Nothing
        PriceToInput.Text = Nothing
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
        SelectedCarPrice.Text = SelectedCar.Price.ToString
    End Sub

    Private Sub FetchCars()
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
            If Not String.IsNullOrEmpty(PriceFromInput.Text) Then
                cars = cars.Where(Function(car) car.Price >= Convert.ToInt32(PriceFromInput.Text)).ToList
            End If
            If Not String.IsNullOrEmpty(PriceToInput.Text) Then
                cars = cars.Where(Function(car) car.Price <= Convert.ToInt32(PriceToInput.Text)).ToList
            End If
            CarList.DataSource = cars.Select(Function(car) car.ToDomain()).ToList
            If CarList.DataSource.Count = 0 Then
                HandleNoCarSelected()
            End If
        End Using
    End Sub

    Private Sub HandleNoCarSelected()
        CarImagePanel.Image = Nothing
        DetailsPanel.Hide()
        RatingPanel.Hide()
        RemoveCarButton.Enabled = False
    End Sub
End Class
