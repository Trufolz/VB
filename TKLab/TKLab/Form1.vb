Public Class YearToLabel
    Private _formData As FormData = New FormData()
    Public ReadOnly Property FormData()
        Get
            Return _formData
        End Get
    End Property
    Public Sub New()
        InitializeComponent()

        BrandDropdown.DataSource = FormData.Brands()
        BrandDropdown.SelectedItem = Nothing

        ModelLabel.Hide()
        ModelDropdown.Hide()
        ModelInput.Hide()

        YearFromDropdown.DataSource = FormData.Years()
        YearFromDropdown.SelectedItem = Nothing

        YearToDropdown.DataSource = FormData.Years()
        YearToDropdown.SelectedItem = Nothing

        ColorDropdown.DataSource = FormData.Colors()
        ColorDropdown.SelectedItem = Nothing

        FuelDropdown.DataSource = FormData.FuelTypes()
        FuelDropdown.SelectedItem = Nothing
    End Sub

    Private Sub BrandDropdown_Click(sender As Object, e As EventArgs) Handles BrandDropdown.SelectionChangeCommitted
        ModelLabel.Show()
        Select Case BrandDropdown.SelectedItem
            Case Brand.Volkswagen
                FillModelDropdown(FormData.VolkswagenModels())
            Case Brand.Skoda
                FillModelDropdown(FormData.SkodaModels())
            Case Brand.Toyota
                FillModelDropdown(FormData.ToyotaModels())
            Case Brand.Audi
                FillModelDropdown(FormData.AudiModels())
            Case Else
                ModelDropdown.Hide()
                ModelDropdown.SelectedItem = Nothing
                ModelInput.Show()
        End Select

        If BrandDropdown.SelectedItem.Equals(Brand.Volkswagen) Then
            ModelDropdown.DataSource = FormData.VolkswagenModels()
            ModelDropdown.SelectedItem = Nothing
        End If
    End Sub

    Private Sub FillModelDropdown(data As Array)
        ModelInput.Hide()
        ModelDropdown.Show()
        ModelDropdown.DataSource = data
        ModelDropdown.SelectedItem = Nothing
    End Sub

    Private Sub ValidateInput(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles HorsePowerFromInput.KeyDown, HorsePowerToInput.KeyDown, EngineVolumeFromInput.KeyDown, EngineVolumeToInput.KeyDown
        Dim isDigit As Boolean =
            Char.IsDigit(ChrW(e.KeyValue)) Or
            e.KeyCode >= Keys.NumPad0 And
            e.KeyCode <= Keys.NumPad9
        e.Handled = isDigit
    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click

    End Sub

End Class
