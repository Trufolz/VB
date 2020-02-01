<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.ListPanel = New System.Windows.Forms.Panel()
        Me.CarList = New System.Windows.Forms.ListBox()
        Me.AddCarButton = New System.Windows.Forms.Button()
        Me.RemoveCarButton = New System.Windows.Forms.Button()
        Me.RatingButton1 = New System.Windows.Forms.RadioButton()
        Me.RatingPanel = New System.Windows.Forms.Panel()
        Me.SubmitRatingButton = New System.Windows.Forms.Button()
        Me.RatingLabel = New System.Windows.Forms.Label()
        Me.RatingButton5 = New System.Windows.Forms.RadioButton()
        Me.RatingButton4 = New System.Windows.Forms.RadioButton()
        Me.RatingButton3 = New System.Windows.Forms.RadioButton()
        Me.RatingButton2 = New System.Windows.Forms.RadioButton()
        Me.DetailsPanel = New System.Windows.Forms.Panel()
        Me.SelectedCarPrice = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SelectedCarColor = New System.Windows.Forms.Label()
        Me.DetailsBrandLabel = New System.Windows.Forms.Label()
        Me.DetailsColorLabel = New System.Windows.Forms.Label()
        Me.SelectedCarBrand = New System.Windows.Forms.Label()
        Me.SelectedCarFuel = New System.Windows.Forms.Label()
        Me.DetailsModelLabel = New System.Windows.Forms.Label()
        Me.DetailsFuelLabel = New System.Windows.Forms.Label()
        Me.SelectedCarModel = New System.Windows.Forms.Label()
        Me.SelectedCarEngineVolume = New System.Windows.Forms.Label()
        Me.DetailsYearLabel = New System.Windows.Forms.Label()
        Me.DetailsEngineVolumeLabel = New System.Windows.Forms.Label()
        Me.SelectedCarYear = New System.Windows.Forms.Label()
        Me.SelectedCarHorsePower = New System.Windows.Forms.Label()
        Me.DetailsHorsePowerLabel = New System.Windows.Forms.Label()
        Me.FiltersPanel = New System.Windows.Forms.Panel()
        Me.PriceToInput = New System.Windows.Forms.NumericUpDown()
        Me.PriceFromInput = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.EngineVolumeToInput = New System.Windows.Forms.NumericUpDown()
        Me.ClearFiltersButton = New System.Windows.Forms.Button()
        Me.EngineVolumeFromInput = New System.Windows.Forms.NumericUpDown()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.HorsePowerToInput = New System.Windows.Forms.NumericUpDown()
        Me.BrandDropdown = New System.Windows.Forms.ComboBox()
        Me.HorsePowerFromInput = New System.Windows.Forms.NumericUpDown()
        Me.ColorDropdown = New System.Windows.Forms.ComboBox()
        Me.ColorLabel = New System.Windows.Forms.Label()
        Me.FuelDropdown = New System.Windows.Forms.ComboBox()
        Me.FuelLabel = New System.Windows.Forms.Label()
        Me.EngineVolumeFromLabel = New System.Windows.Forms.Label()
        Me.BrandLabel = New System.Windows.Forms.Label()
        Me.EngineVolumeToLabel = New System.Windows.Forms.Label()
        Me.ModelLabel = New System.Windows.Forms.Label()
        Me.EngineVolumeLabel = New System.Windows.Forms.Label()
        Me.HorsePowerFromLabel = New System.Windows.Forms.Label()
        Me.YearFromLabel = New System.Windows.Forms.Label()
        Me.YearLabel = New System.Windows.Forms.Label()
        Me.HorsePowerToLabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.HorsePowerLabel = New System.Windows.Forms.Label()
        Me.YearFromDropdown = New System.Windows.Forms.ComboBox()
        Me.YearToDropdown = New System.Windows.Forms.ComboBox()
        Me.ModelInput = New System.Windows.Forms.TextBox()
        Me.AddRemovePanel = New System.Windows.Forms.Panel()
        Me.CarImagePanel = New System.Windows.Forms.PictureBox()
        Me.ListPanel.SuspendLayout()
        Me.RatingPanel.SuspendLayout()
        Me.DetailsPanel.SuspendLayout()
        Me.FiltersPanel.SuspendLayout()
        CType(Me.PriceToInput, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PriceFromInput, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EngineVolumeToInput, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EngineVolumeFromInput, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HorsePowerToInput, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HorsePowerFromInput, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AddRemovePanel.SuspendLayout()
        CType(Me.CarImagePanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListPanel
        '
        Me.ListPanel.BackColor = System.Drawing.SystemColors.Window
        Me.ListPanel.Controls.Add(Me.CarList)
        Me.ListPanel.Location = New System.Drawing.Point(223, 12)
        Me.ListPanel.Name = "ListPanel"
        Me.ListPanel.Size = New System.Drawing.Size(374, 467)
        Me.ListPanel.TabIndex = 35
        '
        'CarList
        '
        Me.CarList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CarList.FormattingEnabled = True
        Me.CarList.Location = New System.Drawing.Point(3, 8)
        Me.CarList.Name = "CarList"
        Me.CarList.ScrollAlwaysVisible = True
        Me.CarList.Size = New System.Drawing.Size(368, 455)
        Me.CarList.TabIndex = 0
        '
        'AddCarButton
        '
        Me.AddCarButton.BackColor = System.Drawing.Color.LightGray
        Me.AddCarButton.Location = New System.Drawing.Point(6, 8)
        Me.AddCarButton.Name = "AddCarButton"
        Me.AddCarButton.Size = New System.Drawing.Size(101, 29)
        Me.AddCarButton.TabIndex = 35
        Me.AddCarButton.Text = "Add"
        Me.AddCarButton.UseVisualStyleBackColor = False
        '
        'RemoveCarButton
        '
        Me.RemoveCarButton.BackColor = System.Drawing.Color.LightGray
        Me.RemoveCarButton.Location = New System.Drawing.Point(7, 43)
        Me.RemoveCarButton.Name = "RemoveCarButton"
        Me.RemoveCarButton.Size = New System.Drawing.Size(100, 29)
        Me.RemoveCarButton.TabIndex = 36
        Me.RemoveCarButton.Text = "Remove"
        Me.RemoveCarButton.UseVisualStyleBackColor = False
        '
        'RatingButton1
        '
        Me.RatingButton1.AutoSize = True
        Me.RatingButton1.Location = New System.Drawing.Point(13, 28)
        Me.RatingButton1.Name = "RatingButton1"
        Me.RatingButton1.Size = New System.Drawing.Size(31, 17)
        Me.RatingButton1.TabIndex = 37
        Me.RatingButton1.TabStop = True
        Me.RatingButton1.Tag = ""
        Me.RatingButton1.Text = "1"
        Me.RatingButton1.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.RatingButton1.UseVisualStyleBackColor = True
        '
        'RatingPanel
        '
        Me.RatingPanel.Controls.Add(Me.SubmitRatingButton)
        Me.RatingPanel.Controls.Add(Me.RatingLabel)
        Me.RatingPanel.Controls.Add(Me.RatingButton5)
        Me.RatingPanel.Controls.Add(Me.RatingButton4)
        Me.RatingPanel.Controls.Add(Me.RatingButton3)
        Me.RatingPanel.Controls.Add(Me.RatingButton2)
        Me.RatingPanel.Controls.Add(Me.RatingButton1)
        Me.RatingPanel.Location = New System.Drawing.Point(758, 30)
        Me.RatingPanel.Name = "RatingPanel"
        Me.RatingPanel.Size = New System.Drawing.Size(55, 173)
        Me.RatingPanel.TabIndex = 38
        '
        'SubmitRatingButton
        '
        Me.SubmitRatingButton.Location = New System.Drawing.Point(9, 142)
        Me.SubmitRatingButton.Name = "SubmitRatingButton"
        Me.SubmitRatingButton.Size = New System.Drawing.Size(35, 23)
        Me.SubmitRatingButton.TabIndex = 42
        Me.SubmitRatingButton.Text = "OK"
        Me.SubmitRatingButton.UseVisualStyleBackColor = True
        '
        'RatingLabel
        '
        Me.RatingLabel.AutoSize = True
        Me.RatingLabel.Location = New System.Drawing.Point(10, 8)
        Me.RatingLabel.Name = "RatingLabel"
        Me.RatingLabel.Size = New System.Drawing.Size(30, 13)
        Me.RatingLabel.TabIndex = 41
        Me.RatingLabel.Text = "Rate"
        '
        'RatingButton5
        '
        Me.RatingButton5.AutoSize = True
        Me.RatingButton5.Location = New System.Drawing.Point(13, 119)
        Me.RatingButton5.Name = "RatingButton5"
        Me.RatingButton5.Size = New System.Drawing.Size(31, 17)
        Me.RatingButton5.TabIndex = 40
        Me.RatingButton5.TabStop = True
        Me.RatingButton5.Tag = ""
        Me.RatingButton5.Text = "5"
        Me.RatingButton5.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.RatingButton5.UseVisualStyleBackColor = True
        '
        'RatingButton4
        '
        Me.RatingButton4.AutoSize = True
        Me.RatingButton4.Location = New System.Drawing.Point(13, 96)
        Me.RatingButton4.Name = "RatingButton4"
        Me.RatingButton4.Size = New System.Drawing.Size(31, 17)
        Me.RatingButton4.TabIndex = 39
        Me.RatingButton4.TabStop = True
        Me.RatingButton4.Tag = ""
        Me.RatingButton4.Text = "4"
        Me.RatingButton4.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.RatingButton4.UseVisualStyleBackColor = True
        '
        'RatingButton3
        '
        Me.RatingButton3.AutoSize = True
        Me.RatingButton3.Location = New System.Drawing.Point(13, 73)
        Me.RatingButton3.Name = "RatingButton3"
        Me.RatingButton3.Size = New System.Drawing.Size(31, 17)
        Me.RatingButton3.TabIndex = 39
        Me.RatingButton3.TabStop = True
        Me.RatingButton3.Tag = ""
        Me.RatingButton3.Text = "3"
        Me.RatingButton3.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.RatingButton3.UseVisualStyleBackColor = True
        '
        'RatingButton2
        '
        Me.RatingButton2.AutoSize = True
        Me.RatingButton2.Location = New System.Drawing.Point(13, 50)
        Me.RatingButton2.Name = "RatingButton2"
        Me.RatingButton2.Size = New System.Drawing.Size(31, 17)
        Me.RatingButton2.TabIndex = 38
        Me.RatingButton2.TabStop = True
        Me.RatingButton2.Tag = ""
        Me.RatingButton2.Text = "2"
        Me.RatingButton2.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.RatingButton2.UseVisualStyleBackColor = True
        '
        'DetailsPanel
        '
        Me.DetailsPanel.Controls.Add(Me.SelectedCarPrice)
        Me.DetailsPanel.Controls.Add(Me.Label6)
        Me.DetailsPanel.Controls.Add(Me.SelectedCarColor)
        Me.DetailsPanel.Controls.Add(Me.DetailsBrandLabel)
        Me.DetailsPanel.Controls.Add(Me.DetailsColorLabel)
        Me.DetailsPanel.Controls.Add(Me.SelectedCarBrand)
        Me.DetailsPanel.Controls.Add(Me.SelectedCarFuel)
        Me.DetailsPanel.Controls.Add(Me.DetailsModelLabel)
        Me.DetailsPanel.Controls.Add(Me.DetailsFuelLabel)
        Me.DetailsPanel.Controls.Add(Me.SelectedCarModel)
        Me.DetailsPanel.Controls.Add(Me.SelectedCarEngineVolume)
        Me.DetailsPanel.Controls.Add(Me.DetailsYearLabel)
        Me.DetailsPanel.Controls.Add(Me.DetailsEngineVolumeLabel)
        Me.DetailsPanel.Controls.Add(Me.SelectedCarYear)
        Me.DetailsPanel.Controls.Add(Me.SelectedCarHorsePower)
        Me.DetailsPanel.Controls.Add(Me.DetailsHorsePowerLabel)
        Me.DetailsPanel.Location = New System.Drawing.Point(615, 13)
        Me.DetailsPanel.Name = "DetailsPanel"
        Me.DetailsPanel.Size = New System.Drawing.Size(112, 391)
        Me.DetailsPanel.TabIndex = 39
        '
        'SelectedCarPrice
        '
        Me.SelectedCarPrice.AutoSize = True
        Me.SelectedCarPrice.Location = New System.Drawing.Point(3, 372)
        Me.SelectedCarPrice.Name = "SelectedCarPrice"
        Me.SelectedCarPrice.Size = New System.Drawing.Size(31, 13)
        Me.SelectedCarPrice.TabIndex = 56
        Me.SelectedCarPrice.Text = "Price"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 350)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 55
        Me.Label6.Text = "Price [PLN]"
        '
        'SelectedCarColor
        '
        Me.SelectedCarColor.AutoSize = True
        Me.SelectedCarColor.Location = New System.Drawing.Point(3, 325)
        Me.SelectedCarColor.Name = "SelectedCarColor"
        Me.SelectedCarColor.Size = New System.Drawing.Size(31, 13)
        Me.SelectedCarColor.TabIndex = 54
        Me.SelectedCarColor.Text = "Color"
        '
        'DetailsBrandLabel
        '
        Me.DetailsBrandLabel.AutoSize = True
        Me.DetailsBrandLabel.Location = New System.Drawing.Point(3, 7)
        Me.DetailsBrandLabel.Name = "DetailsBrandLabel"
        Me.DetailsBrandLabel.Size = New System.Drawing.Size(35, 13)
        Me.DetailsBrandLabel.TabIndex = 41
        Me.DetailsBrandLabel.Text = "Brand"
        '
        'DetailsColorLabel
        '
        Me.DetailsColorLabel.AutoSize = True
        Me.DetailsColorLabel.Location = New System.Drawing.Point(3, 303)
        Me.DetailsColorLabel.Name = "DetailsColorLabel"
        Me.DetailsColorLabel.Size = New System.Drawing.Size(31, 13)
        Me.DetailsColorLabel.TabIndex = 53
        Me.DetailsColorLabel.Text = "Color"
        '
        'SelectedCarBrand
        '
        Me.SelectedCarBrand.AutoSize = True
        Me.SelectedCarBrand.Location = New System.Drawing.Point(3, 29)
        Me.SelectedCarBrand.Name = "SelectedCarBrand"
        Me.SelectedCarBrand.Size = New System.Drawing.Size(35, 13)
        Me.SelectedCarBrand.TabIndex = 42
        Me.SelectedCarBrand.Text = "Brand"
        '
        'SelectedCarFuel
        '
        Me.SelectedCarFuel.AutoSize = True
        Me.SelectedCarFuel.Location = New System.Drawing.Point(2, 275)
        Me.SelectedCarFuel.Name = "SelectedCarFuel"
        Me.SelectedCarFuel.Size = New System.Drawing.Size(27, 13)
        Me.SelectedCarFuel.TabIndex = 52
        Me.SelectedCarFuel.Text = "Fuel"
        '
        'DetailsModelLabel
        '
        Me.DetailsModelLabel.AutoSize = True
        Me.DetailsModelLabel.Location = New System.Drawing.Point(2, 57)
        Me.DetailsModelLabel.Name = "DetailsModelLabel"
        Me.DetailsModelLabel.Size = New System.Drawing.Size(36, 13)
        Me.DetailsModelLabel.TabIndex = 43
        Me.DetailsModelLabel.Text = "Model"
        '
        'DetailsFuelLabel
        '
        Me.DetailsFuelLabel.AutoSize = True
        Me.DetailsFuelLabel.Location = New System.Drawing.Point(2, 253)
        Me.DetailsFuelLabel.Name = "DetailsFuelLabel"
        Me.DetailsFuelLabel.Size = New System.Drawing.Size(27, 13)
        Me.DetailsFuelLabel.TabIndex = 51
        Me.DetailsFuelLabel.Text = "Fuel"
        '
        'SelectedCarModel
        '
        Me.SelectedCarModel.AutoSize = True
        Me.SelectedCarModel.Location = New System.Drawing.Point(2, 79)
        Me.SelectedCarModel.Name = "SelectedCarModel"
        Me.SelectedCarModel.Size = New System.Drawing.Size(36, 13)
        Me.SelectedCarModel.TabIndex = 44
        Me.SelectedCarModel.Text = "Model"
        '
        'SelectedCarEngineVolume
        '
        Me.SelectedCarEngineVolume.AutoSize = True
        Me.SelectedCarEngineVolume.Location = New System.Drawing.Point(2, 225)
        Me.SelectedCarEngineVolume.Name = "SelectedCarEngineVolume"
        Me.SelectedCarEngineVolume.Size = New System.Drawing.Size(78, 13)
        Me.SelectedCarEngineVolume.TabIndex = 50
        Me.SelectedCarEngineVolume.Text = "Engine Volume"
        '
        'DetailsYearLabel
        '
        Me.DetailsYearLabel.AutoSize = True
        Me.DetailsYearLabel.Location = New System.Drawing.Point(3, 106)
        Me.DetailsYearLabel.Name = "DetailsYearLabel"
        Me.DetailsYearLabel.Size = New System.Drawing.Size(29, 13)
        Me.DetailsYearLabel.TabIndex = 45
        Me.DetailsYearLabel.Text = "Year"
        '
        'DetailsEngineVolumeLabel
        '
        Me.DetailsEngineVolumeLabel.AutoSize = True
        Me.DetailsEngineVolumeLabel.Location = New System.Drawing.Point(2, 203)
        Me.DetailsEngineVolumeLabel.Name = "DetailsEngineVolumeLabel"
        Me.DetailsEngineVolumeLabel.Size = New System.Drawing.Size(104, 13)
        Me.DetailsEngineVolumeLabel.TabIndex = 49
        Me.DetailsEngineVolumeLabel.Text = "Engine Volume [cm³]"
        '
        'SelectedCarYear
        '
        Me.SelectedCarYear.AutoSize = True
        Me.SelectedCarYear.Location = New System.Drawing.Point(3, 128)
        Me.SelectedCarYear.Name = "SelectedCarYear"
        Me.SelectedCarYear.Size = New System.Drawing.Size(29, 13)
        Me.SelectedCarYear.TabIndex = 46
        Me.SelectedCarYear.Text = "Year"
        '
        'SelectedCarHorsePower
        '
        Me.SelectedCarHorsePower.AutoSize = True
        Me.SelectedCarHorsePower.Location = New System.Drawing.Point(2, 177)
        Me.SelectedCarHorsePower.Name = "SelectedCarHorsePower"
        Me.SelectedCarHorsePower.Size = New System.Drawing.Size(68, 13)
        Me.SelectedCarHorsePower.TabIndex = 48
        Me.SelectedCarHorsePower.Text = "Horse Power"
        '
        'DetailsHorsePowerLabel
        '
        Me.DetailsHorsePowerLabel.AutoSize = True
        Me.DetailsHorsePowerLabel.Location = New System.Drawing.Point(2, 155)
        Me.DetailsHorsePowerLabel.Name = "DetailsHorsePowerLabel"
        Me.DetailsHorsePowerLabel.Size = New System.Drawing.Size(93, 13)
        Me.DetailsHorsePowerLabel.TabIndex = 47
        Me.DetailsHorsePowerLabel.Text = "Horse Power [KM]"
        '
        'FiltersPanel
        '
        Me.FiltersPanel.BackColor = System.Drawing.SystemColors.Window
        Me.FiltersPanel.Controls.Add(Me.PriceToInput)
        Me.FiltersPanel.Controls.Add(Me.PriceFromInput)
        Me.FiltersPanel.Controls.Add(Me.Label1)
        Me.FiltersPanel.Controls.Add(Me.Label3)
        Me.FiltersPanel.Controls.Add(Me.Label4)
        Me.FiltersPanel.Controls.Add(Me.EngineVolumeToInput)
        Me.FiltersPanel.Controls.Add(Me.ClearFiltersButton)
        Me.FiltersPanel.Controls.Add(Me.EngineVolumeFromInput)
        Me.FiltersPanel.Controls.Add(Me.SearchButton)
        Me.FiltersPanel.Controls.Add(Me.HorsePowerToInput)
        Me.FiltersPanel.Controls.Add(Me.BrandDropdown)
        Me.FiltersPanel.Controls.Add(Me.HorsePowerFromInput)
        Me.FiltersPanel.Controls.Add(Me.ColorDropdown)
        Me.FiltersPanel.Controls.Add(Me.ColorLabel)
        Me.FiltersPanel.Controls.Add(Me.FuelDropdown)
        Me.FiltersPanel.Controls.Add(Me.FuelLabel)
        Me.FiltersPanel.Controls.Add(Me.EngineVolumeFromLabel)
        Me.FiltersPanel.Controls.Add(Me.BrandLabel)
        Me.FiltersPanel.Controls.Add(Me.EngineVolumeToLabel)
        Me.FiltersPanel.Controls.Add(Me.ModelLabel)
        Me.FiltersPanel.Controls.Add(Me.EngineVolumeLabel)
        Me.FiltersPanel.Controls.Add(Me.HorsePowerFromLabel)
        Me.FiltersPanel.Controls.Add(Me.YearFromLabel)
        Me.FiltersPanel.Controls.Add(Me.YearLabel)
        Me.FiltersPanel.Controls.Add(Me.HorsePowerToLabel)
        Me.FiltersPanel.Controls.Add(Me.Label2)
        Me.FiltersPanel.Controls.Add(Me.HorsePowerLabel)
        Me.FiltersPanel.Controls.Add(Me.YearFromDropdown)
        Me.FiltersPanel.Controls.Add(Me.YearToDropdown)
        Me.FiltersPanel.Controls.Add(Me.ModelInput)
        Me.FiltersPanel.Location = New System.Drawing.Point(12, 13)
        Me.FiltersPanel.Name = "FiltersPanel"
        Me.FiltersPanel.Size = New System.Drawing.Size(192, 467)
        Me.FiltersPanel.TabIndex = 34
        '
        'PriceToInput
        '
        Me.PriceToInput.Increment = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.PriceToInput.Location = New System.Drawing.Point(129, 385)
        Me.PriceToInput.Maximum = New Decimal(New Integer() {99999999, 0, 0, 0})
        Me.PriceToInput.Name = "PriceToInput"
        Me.PriceToInput.Size = New System.Drawing.Size(53, 20)
        Me.PriceToInput.TabIndex = 45
        '
        'PriceFromInput
        '
        Me.PriceFromInput.Increment = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.PriceFromInput.Location = New System.Drawing.Point(48, 385)
        Me.PriceFromInput.Maximum = New Decimal(New Integer() {99999999, 0, 0, 0})
        Me.PriceFromInput.Name = "PriceFromInput"
        Me.PriceFromInput.Size = New System.Drawing.Size(53, 20)
        Me.PriceFromInput.TabIndex = 44
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 387)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "from"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(107, 387)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(16, 13)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "to"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 368)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "Price"
        '
        'EngineVolumeToInput
        '
        Me.EngineVolumeToInput.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.EngineVolumeToInput.Location = New System.Drawing.Point(127, 231)
        Me.EngineVolumeToInput.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        Me.EngineVolumeToInput.Name = "EngineVolumeToInput"
        Me.EngineVolumeToInput.Size = New System.Drawing.Size(53, 20)
        Me.EngineVolumeToInput.TabIndex = 40
        '
        'ClearFiltersButton
        '
        Me.ClearFiltersButton.Location = New System.Drawing.Point(14, 420)
        Me.ClearFiltersButton.Name = "ClearFiltersButton"
        Me.ClearFiltersButton.Size = New System.Drawing.Size(77, 25)
        Me.ClearFiltersButton.TabIndex = 35
        Me.ClearFiltersButton.Text = "Clear Filters"
        Me.ClearFiltersButton.UseVisualStyleBackColor = True
        '
        'EngineVolumeFromInput
        '
        Me.EngineVolumeFromInput.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.EngineVolumeFromInput.Location = New System.Drawing.Point(46, 231)
        Me.EngineVolumeFromInput.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        Me.EngineVolumeFromInput.Name = "EngineVolumeFromInput"
        Me.EngineVolumeFromInput.Size = New System.Drawing.Size(53, 20)
        Me.EngineVolumeFromInput.TabIndex = 39
        '
        'SearchButton
        '
        Me.SearchButton.Location = New System.Drawing.Point(103, 420)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(77, 25)
        Me.SearchButton.TabIndex = 34
        Me.SearchButton.Text = "Search"
        Me.SearchButton.UseVisualStyleBackColor = True
        '
        'HorsePowerToInput
        '
        Me.HorsePowerToInput.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.HorsePowerToInput.Location = New System.Drawing.Point(127, 177)
        Me.HorsePowerToInput.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.HorsePowerToInput.Name = "HorsePowerToInput"
        Me.HorsePowerToInput.Size = New System.Drawing.Size(53, 20)
        Me.HorsePowerToInput.TabIndex = 38
        '
        'BrandDropdown
        '
        Me.BrandDropdown.BackColor = System.Drawing.SystemColors.Window
        Me.BrandDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BrandDropdown.FormattingEnabled = True
        Me.BrandDropdown.Location = New System.Drawing.Point(14, 24)
        Me.BrandDropdown.Name = "BrandDropdown"
        Me.BrandDropdown.Size = New System.Drawing.Size(166, 21)
        Me.BrandDropdown.TabIndex = 10
        '
        'HorsePowerFromInput
        '
        Me.HorsePowerFromInput.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.HorsePowerFromInput.Location = New System.Drawing.Point(46, 177)
        Me.HorsePowerFromInput.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.HorsePowerFromInput.Name = "HorsePowerFromInput"
        Me.HorsePowerFromInput.Size = New System.Drawing.Size(53, 20)
        Me.HorsePowerFromInput.TabIndex = 37
        '
        'ColorDropdown
        '
        Me.ColorDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ColorDropdown.FormattingEnabled = True
        Me.ColorDropdown.Location = New System.Drawing.Point(14, 334)
        Me.ColorDropdown.Name = "ColorDropdown"
        Me.ColorDropdown.Size = New System.Drawing.Size(166, 21)
        Me.ColorDropdown.TabIndex = 5
        '
        'ColorLabel
        '
        Me.ColorLabel.AutoSize = True
        Me.ColorLabel.Location = New System.Drawing.Point(11, 318)
        Me.ColorLabel.Name = "ColorLabel"
        Me.ColorLabel.Size = New System.Drawing.Size(31, 13)
        Me.ColorLabel.TabIndex = 6
        Me.ColorLabel.Text = "Color"
        '
        'FuelDropdown
        '
        Me.FuelDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.FuelDropdown.FormattingEnabled = True
        Me.FuelDropdown.Location = New System.Drawing.Point(14, 282)
        Me.FuelDropdown.Name = "FuelDropdown"
        Me.FuelDropdown.Size = New System.Drawing.Size(166, 21)
        Me.FuelDropdown.TabIndex = 7
        '
        'FuelLabel
        '
        Me.FuelLabel.AutoSize = True
        Me.FuelLabel.Location = New System.Drawing.Point(11, 266)
        Me.FuelLabel.Name = "FuelLabel"
        Me.FuelLabel.Size = New System.Drawing.Size(27, 13)
        Me.FuelLabel.TabIndex = 8
        Me.FuelLabel.Text = "Fuel"
        '
        'EngineVolumeFromLabel
        '
        Me.EngineVolumeFromLabel.AutoSize = True
        Me.EngineVolumeFromLabel.Location = New System.Drawing.Point(13, 233)
        Me.EngineVolumeFromLabel.Name = "EngineVolumeFromLabel"
        Me.EngineVolumeFromLabel.Size = New System.Drawing.Size(27, 13)
        Me.EngineVolumeFromLabel.TabIndex = 29
        Me.EngineVolumeFromLabel.Text = "from"
        '
        'BrandLabel
        '
        Me.BrandLabel.AutoSize = True
        Me.BrandLabel.Location = New System.Drawing.Point(11, 8)
        Me.BrandLabel.Name = "BrandLabel"
        Me.BrandLabel.Size = New System.Drawing.Size(35, 13)
        Me.BrandLabel.TabIndex = 9
        Me.BrandLabel.Text = "Brand"
        '
        'EngineVolumeToLabel
        '
        Me.EngineVolumeToLabel.AutoSize = True
        Me.EngineVolumeToLabel.Location = New System.Drawing.Point(105, 233)
        Me.EngineVolumeToLabel.Name = "EngineVolumeToLabel"
        Me.EngineVolumeToLabel.Size = New System.Drawing.Size(16, 13)
        Me.EngineVolumeToLabel.TabIndex = 26
        Me.EngineVolumeToLabel.Text = "to"
        '
        'ModelLabel
        '
        Me.ModelLabel.AutoSize = True
        Me.ModelLabel.Location = New System.Drawing.Point(11, 62)
        Me.ModelLabel.Name = "ModelLabel"
        Me.ModelLabel.Size = New System.Drawing.Size(36, 13)
        Me.ModelLabel.TabIndex = 11
        Me.ModelLabel.Text = "Model"
        '
        'EngineVolumeLabel
        '
        Me.EngineVolumeLabel.AutoSize = True
        Me.EngineVolumeLabel.Location = New System.Drawing.Point(13, 214)
        Me.EngineVolumeLabel.Name = "EngineVolumeLabel"
        Me.EngineVolumeLabel.Size = New System.Drawing.Size(104, 13)
        Me.EngineVolumeLabel.TabIndex = 25
        Me.EngineVolumeLabel.Text = "Engine Volume [cm³]"
        '
        'HorsePowerFromLabel
        '
        Me.HorsePowerFromLabel.AutoSize = True
        Me.HorsePowerFromLabel.Location = New System.Drawing.Point(13, 179)
        Me.HorsePowerFromLabel.Name = "HorsePowerFromLabel"
        Me.HorsePowerFromLabel.Size = New System.Drawing.Size(27, 13)
        Me.HorsePowerFromLabel.TabIndex = 24
        Me.HorsePowerFromLabel.Text = "from"
        '
        'YearFromLabel
        '
        Me.YearFromLabel.AutoSize = True
        Me.YearFromLabel.Location = New System.Drawing.Point(15, 128)
        Me.YearFromLabel.Name = "YearFromLabel"
        Me.YearFromLabel.Size = New System.Drawing.Size(27, 13)
        Me.YearFromLabel.TabIndex = 23
        Me.YearFromLabel.Text = "from"
        '
        'YearLabel
        '
        Me.YearLabel.AutoSize = True
        Me.YearLabel.Location = New System.Drawing.Point(11, 108)
        Me.YearLabel.Name = "YearLabel"
        Me.YearLabel.Size = New System.Drawing.Size(29, 13)
        Me.YearLabel.TabIndex = 14
        Me.YearLabel.Text = "Year"
        '
        'HorsePowerToLabel
        '
        Me.HorsePowerToLabel.AutoSize = True
        Me.HorsePowerToLabel.Location = New System.Drawing.Point(105, 179)
        Me.HorsePowerToLabel.Name = "HorsePowerToLabel"
        Me.HorsePowerToLabel.Size = New System.Drawing.Size(16, 13)
        Me.HorsePowerToLabel.TabIndex = 20
        Me.HorsePowerToLabel.Text = "to"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(105, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "to"
        '
        'HorsePowerLabel
        '
        Me.HorsePowerLabel.AutoSize = True
        Me.HorsePowerLabel.Location = New System.Drawing.Point(11, 159)
        Me.HorsePowerLabel.Name = "HorsePowerLabel"
        Me.HorsePowerLabel.Size = New System.Drawing.Size(93, 13)
        Me.HorsePowerLabel.TabIndex = 19
        Me.HorsePowerLabel.Text = "Horse Power [KM]"
        '
        'YearFromDropdown
        '
        Me.YearFromDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.YearFromDropdown.FormattingEnabled = True
        Me.YearFromDropdown.Location = New System.Drawing.Point(46, 125)
        Me.YearFromDropdown.Name = "YearFromDropdown"
        Me.YearFromDropdown.Size = New System.Drawing.Size(53, 21)
        Me.YearFromDropdown.TabIndex = 17
        '
        'YearToDropdown
        '
        Me.YearToDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.YearToDropdown.FormattingEnabled = True
        Me.YearToDropdown.Location = New System.Drawing.Point(127, 125)
        Me.YearToDropdown.Name = "YearToDropdown"
        Me.YearToDropdown.Size = New System.Drawing.Size(53, 21)
        Me.YearToDropdown.TabIndex = 18
        '
        'ModelInput
        '
        Me.ModelInput.Location = New System.Drawing.Point(14, 79)
        Me.ModelInput.Name = "ModelInput"
        Me.ModelInput.Size = New System.Drawing.Size(166, 20)
        Me.ModelInput.TabIndex = 12
        '
        'AddRemovePanel
        '
        Me.AddRemovePanel.Controls.Add(Me.AddCarButton)
        Me.AddRemovePanel.Controls.Add(Me.RemoveCarButton)
        Me.AddRemovePanel.Location = New System.Drawing.Point(614, 402)
        Me.AddRemovePanel.Name = "AddRemovePanel"
        Me.AddRemovePanel.Size = New System.Drawing.Size(113, 77)
        Me.AddRemovePanel.TabIndex = 41
        '
        'CarImagePanel
        '
        Me.CarImagePanel.Location = New System.Drawing.Point(743, 13)
        Me.CarImagePanel.Name = "CarImagePanel"
        Me.CarImagePanel.Size = New System.Drawing.Size(590, 466)
        Me.CarImagePanel.TabIndex = 36
        Me.CarImagePanel.TabStop = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1347, 492)
        Me.Controls.Add(Me.FiltersPanel)
        Me.Controls.Add(Me.AddRemovePanel)
        Me.Controls.Add(Me.DetailsPanel)
        Me.Controls.Add(Me.RatingPanel)
        Me.Controls.Add(Me.CarImagePanel)
        Me.Controls.Add(Me.ListPanel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.Text = "Komis"
        Me.ListPanel.ResumeLayout(False)
        Me.RatingPanel.ResumeLayout(False)
        Me.RatingPanel.PerformLayout()
        Me.DetailsPanel.ResumeLayout(False)
        Me.DetailsPanel.PerformLayout()
        Me.FiltersPanel.ResumeLayout(False)
        Me.FiltersPanel.PerformLayout()
        CType(Me.PriceToInput, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PriceFromInput, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EngineVolumeToInput, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EngineVolumeFromInput, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HorsePowerToInput, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HorsePowerFromInput, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AddRemovePanel.ResumeLayout(False)
        CType(Me.CarImagePanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListPanel As Panel
    Friend WithEvents CarList As ListBox
    Friend WithEvents AddCarButton As Button
    Friend WithEvents CarImagePanel As PictureBox
    Friend WithEvents RemoveCarButton As Button
    Friend WithEvents RatingButton1 As RadioButton
    Friend WithEvents RatingPanel As Panel
    Friend WithEvents SubmitRatingButton As Button
    Friend WithEvents RatingLabel As Label
    Friend WithEvents RatingButton5 As RadioButton
    Friend WithEvents RatingButton4 As RadioButton
    Friend WithEvents RatingButton3 As RadioButton
    Friend WithEvents RatingButton2 As RadioButton
    Friend WithEvents DetailsPanel As Panel
    Friend WithEvents DetailsBrandLabel As Label
    Friend WithEvents SelectedCarYear As Label
    Friend WithEvents DetailsModelLabel As Label
    Friend WithEvents SelectedCarModel As Label
    Friend WithEvents DetailsYearLabel As Label
    Friend WithEvents SelectedCarBrand As Label
    Friend WithEvents SelectedCarFuel As Label
    Friend WithEvents DetailsFuelLabel As Label
    Friend WithEvents SelectedCarEngineVolume As Label
    Friend WithEvents DetailsEngineVolumeLabel As Label
    Friend WithEvents SelectedCarHorsePower As Label
    Friend WithEvents DetailsHorsePowerLabel As Label
    Friend WithEvents SelectedCarColor As Label
    Friend WithEvents DetailsColorLabel As Label
    Friend WithEvents FiltersPanel As System.Windows.Forms.Panel
    Friend WithEvents PriceToInput As System.Windows.Forms.NumericUpDown
    Friend WithEvents PriceFromInput As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents EngineVolumeToInput As System.Windows.Forms.NumericUpDown
    Friend WithEvents ClearFiltersButton As System.Windows.Forms.Button
    Friend WithEvents EngineVolumeFromInput As System.Windows.Forms.NumericUpDown
    Friend WithEvents SearchButton As System.Windows.Forms.Button
    Friend WithEvents HorsePowerToInput As System.Windows.Forms.NumericUpDown
    Friend WithEvents BrandDropdown As System.Windows.Forms.ComboBox
    Friend WithEvents HorsePowerFromInput As System.Windows.Forms.NumericUpDown
    Friend WithEvents ColorDropdown As System.Windows.Forms.ComboBox
    Friend WithEvents ColorLabel As System.Windows.Forms.Label
    Friend WithEvents FuelDropdown As System.Windows.Forms.ComboBox
    Friend WithEvents FuelLabel As System.Windows.Forms.Label
    Friend WithEvents EngineVolumeFromLabel As System.Windows.Forms.Label
    Friend WithEvents BrandLabel As System.Windows.Forms.Label
    Friend WithEvents EngineVolumeToLabel As System.Windows.Forms.Label
    Friend WithEvents ModelLabel As System.Windows.Forms.Label
    Friend WithEvents EngineVolumeLabel As System.Windows.Forms.Label
    Friend WithEvents HorsePowerFromLabel As System.Windows.Forms.Label
    Friend WithEvents YearFromLabel As System.Windows.Forms.Label
    Friend WithEvents YearLabel As System.Windows.Forms.Label
    Friend WithEvents HorsePowerToLabel As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents HorsePowerLabel As System.Windows.Forms.Label
    Friend WithEvents YearFromDropdown As System.Windows.Forms.ComboBox
    Friend WithEvents YearToDropdown As System.Windows.Forms.ComboBox
    Friend WithEvents ModelInput As System.Windows.Forms.TextBox
    Friend WithEvents AddRemovePanel As System.Windows.Forms.Panel
    Friend WithEvents SelectedCarPrice As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
