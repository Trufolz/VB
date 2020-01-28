Imports Komis.CarContext
Imports Komis.Models
Imports Komis.Utils

Public Class Form
    Private _formData As FiltersFormDropdownData = New FiltersFormDropdownData()
    Private _repository As Repository = New Repository()

    Public ReadOnly Property FormData()
        Get
            Return _formData
        End Get
    End Property

    Public ReadOnly Property Repository() As Repository
        Get
            Return _repository
        End Get
    End Property

    Public Sub New()
        InitializeComponent()
        ConfigureFilters()
        Repository.Seed()
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
        CarList.DataSource = Repository.GetCars()
    End Sub

    Private Sub ConfigureFilters()
        BrandDropdown.DataSource = FormData.Brands()
        YearFromDropdown.DataSource = FormData.Years()
        YearToDropdown.DataSource = FormData.Years()
        ColorDropdown.DataSource = FormData.Colors()
        FuelDropdown.DataSource = FormData.FuelTypes()

        BrandDropdown.SelectedItem = Nothing
        YearFromDropdown.SelectedItem = Nothing
        YearToDropdown.SelectedItem = Nothing
        ColorDropdown.SelectedItem = Nothing
        FuelDropdown.SelectedItem = Nothing

        ModelLabel.Hide()
        ModelInput.Hide()
    End Sub
End Class
