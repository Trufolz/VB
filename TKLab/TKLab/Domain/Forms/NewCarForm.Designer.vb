<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewCarForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.FiltersPanel = New System.Windows.Forms.Panel()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.NewCarEngineVolumeInput = New System.Windows.Forms.NumericUpDown()
        Me.DismissButton = New System.Windows.Forms.Button()
        Me.NewCarBrandDropdown = New System.Windows.Forms.ComboBox()
        Me.NewCarHorsePowerInput = New System.Windows.Forms.NumericUpDown()
        Me.NewCarColorDropdown = New System.Windows.Forms.ComboBox()
        Me.ColorLabel = New System.Windows.Forms.Label()
        Me.NewCarFuelDropdown = New System.Windows.Forms.ComboBox()
        Me.FuelLabel = New System.Windows.Forms.Label()
        Me.BrandLabel = New System.Windows.Forms.Label()
        Me.ModelLabel = New System.Windows.Forms.Label()
        Me.EngineVolumeLabel = New System.Windows.Forms.Label()
        Me.YearLabel = New System.Windows.Forms.Label()
        Me.HorsePowerLabel = New System.Windows.Forms.Label()
        Me.NewCarYearDropdown = New System.Windows.Forms.ComboBox()
        Me.NewCarModelInput = New System.Windows.Forms.TextBox()
        Me.NewCarPriceInput = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FiltersPanel.SuspendLayout()
        CType(Me.NewCarEngineVolumeInput, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NewCarHorsePowerInput, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NewCarPriceInput, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FiltersPanel
        '
        Me.FiltersPanel.BackColor = System.Drawing.SystemColors.Window
        Me.FiltersPanel.Controls.Add(Me.NewCarPriceInput)
        Me.FiltersPanel.Controls.Add(Me.Label1)
        Me.FiltersPanel.Controls.Add(Me.AddButton)
        Me.FiltersPanel.Controls.Add(Me.NewCarEngineVolumeInput)
        Me.FiltersPanel.Controls.Add(Me.DismissButton)
        Me.FiltersPanel.Controls.Add(Me.NewCarBrandDropdown)
        Me.FiltersPanel.Controls.Add(Me.NewCarHorsePowerInput)
        Me.FiltersPanel.Controls.Add(Me.NewCarColorDropdown)
        Me.FiltersPanel.Controls.Add(Me.ColorLabel)
        Me.FiltersPanel.Controls.Add(Me.NewCarFuelDropdown)
        Me.FiltersPanel.Controls.Add(Me.FuelLabel)
        Me.FiltersPanel.Controls.Add(Me.BrandLabel)
        Me.FiltersPanel.Controls.Add(Me.ModelLabel)
        Me.FiltersPanel.Controls.Add(Me.EngineVolumeLabel)
        Me.FiltersPanel.Controls.Add(Me.YearLabel)
        Me.FiltersPanel.Controls.Add(Me.HorsePowerLabel)
        Me.FiltersPanel.Controls.Add(Me.NewCarYearDropdown)
        Me.FiltersPanel.Controls.Add(Me.NewCarModelInput)
        Me.FiltersPanel.Location = New System.Drawing.Point(12, 12)
        Me.FiltersPanel.Name = "FiltersPanel"
        Me.FiltersPanel.Size = New System.Drawing.Size(196, 415)
        Me.FiltersPanel.TabIndex = 34
        '
        'AddButton
        '
        Me.AddButton.Location = New System.Drawing.Point(14, 370)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(77, 25)
        Me.AddButton.TabIndex = 35
        Me.AddButton.Text = "Add"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'NewCarEngineVolumeInput
        '
        Me.NewCarEngineVolumeInput.Location = New System.Drawing.Point(14, 175)
        Me.NewCarEngineVolumeInput.Name = "NewCarEngineVolumeInput"
        Me.NewCarEngineVolumeInput.Size = New System.Drawing.Size(53, 20)
        Me.NewCarEngineVolumeInput.TabIndex = 39
        '
        'DismissButton
        '
        Me.DismissButton.Location = New System.Drawing.Point(103, 370)
        Me.DismissButton.Name = "DismissButton"
        Me.DismissButton.Size = New System.Drawing.Size(77, 25)
        Me.DismissButton.TabIndex = 34
        Me.DismissButton.Text = "Cancel"
        Me.DismissButton.UseVisualStyleBackColor = True
        '
        'NewCarBrandDropdown
        '
        Me.NewCarBrandDropdown.BackColor = System.Drawing.SystemColors.Window
        Me.NewCarBrandDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.NewCarBrandDropdown.FormattingEnabled = True
        Me.NewCarBrandDropdown.Location = New System.Drawing.Point(14, 24)
        Me.NewCarBrandDropdown.Name = "NewCarBrandDropdown"
        Me.NewCarBrandDropdown.Size = New System.Drawing.Size(166, 21)
        Me.NewCarBrandDropdown.TabIndex = 10
        '
        'NewCarHorsePowerInput
        '
        Me.NewCarHorsePowerInput.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NewCarHorsePowerInput.Location = New System.Drawing.Point(115, 175)
        Me.NewCarHorsePowerInput.Name = "NewCarHorsePowerInput"
        Me.NewCarHorsePowerInput.Size = New System.Drawing.Size(53, 20)
        Me.NewCarHorsePowerInput.TabIndex = 37
        '
        'NewCarColorDropdown
        '
        Me.NewCarColorDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.NewCarColorDropdown.FormattingEnabled = True
        Me.NewCarColorDropdown.Location = New System.Drawing.Point(14, 280)
        Me.NewCarColorDropdown.Name = "NewCarColorDropdown"
        Me.NewCarColorDropdown.Size = New System.Drawing.Size(166, 21)
        Me.NewCarColorDropdown.TabIndex = 5
        '
        'ColorLabel
        '
        Me.ColorLabel.AutoSize = True
        Me.ColorLabel.Location = New System.Drawing.Point(11, 264)
        Me.ColorLabel.Name = "ColorLabel"
        Me.ColorLabel.Size = New System.Drawing.Size(31, 13)
        Me.ColorLabel.TabIndex = 6
        Me.ColorLabel.Text = "Color"
        '
        'NewCarFuelDropdown
        '
        Me.NewCarFuelDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.NewCarFuelDropdown.FormattingEnabled = True
        Me.NewCarFuelDropdown.Location = New System.Drawing.Point(14, 228)
        Me.NewCarFuelDropdown.Name = "NewCarFuelDropdown"
        Me.NewCarFuelDropdown.Size = New System.Drawing.Size(166, 21)
        Me.NewCarFuelDropdown.TabIndex = 7
        '
        'FuelLabel
        '
        Me.FuelLabel.AutoSize = True
        Me.FuelLabel.Location = New System.Drawing.Point(11, 212)
        Me.FuelLabel.Name = "FuelLabel"
        Me.FuelLabel.Size = New System.Drawing.Size(27, 13)
        Me.FuelLabel.TabIndex = 8
        Me.FuelLabel.Text = "Fuel"
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
        Me.EngineVolumeLabel.Location = New System.Drawing.Point(11, 159)
        Me.EngineVolumeLabel.Name = "EngineVolumeLabel"
        Me.EngineVolumeLabel.Size = New System.Drawing.Size(84, 13)
        Me.EngineVolumeLabel.TabIndex = 25
        Me.EngineVolumeLabel.Text = "Engine Vol [cm³]"
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
        'HorsePowerLabel
        '
        Me.HorsePowerLabel.AutoSize = True
        Me.HorsePowerLabel.Location = New System.Drawing.Point(112, 159)
        Me.HorsePowerLabel.Name = "HorsePowerLabel"
        Me.HorsePowerLabel.Size = New System.Drawing.Size(47, 13)
        Me.HorsePowerLabel.TabIndex = 19
        Me.HorsePowerLabel.Text = "HP [KM]"
        '
        'NewCarYearDropdown
        '
        Me.NewCarYearDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.NewCarYearDropdown.FormattingEnabled = True
        Me.NewCarYearDropdown.Location = New System.Drawing.Point(14, 124)
        Me.NewCarYearDropdown.Name = "NewCarYearDropdown"
        Me.NewCarYearDropdown.Size = New System.Drawing.Size(53, 21)
        Me.NewCarYearDropdown.TabIndex = 17
        '
        'NewCarModelInput
        '
        Me.NewCarModelInput.Location = New System.Drawing.Point(14, 79)
        Me.NewCarModelInput.Name = "NewCarModelInput"
        Me.NewCarModelInput.Size = New System.Drawing.Size(166, 20)
        Me.NewCarModelInput.TabIndex = 12
        '
        'NewCarPriceInput
        '
        Me.NewCarPriceInput.Location = New System.Drawing.Point(14, 333)
        Me.NewCarPriceInput.Name = "NewCarPriceInput"
        Me.NewCarPriceInput.Size = New System.Drawing.Size(166, 20)
        Me.NewCarPriceInput.TabIndex = 41
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 317)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Price [PLN]"
        '
        'NewCarForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(223, 442)
        Me.Controls.Add(Me.FiltersPanel)
        Me.Name = "NewCarForm"
        Me.Text = "Add a new car"
        Me.FiltersPanel.ResumeLayout(False)
        Me.FiltersPanel.PerformLayout()
        CType(Me.NewCarEngineVolumeInput, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NewCarHorsePowerInput, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NewCarPriceInput, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FiltersPanel As System.Windows.Forms.Panel
    Friend WithEvents AddButton As System.Windows.Forms.Button
    Friend WithEvents NewCarEngineVolumeInput As System.Windows.Forms.NumericUpDown
    Friend WithEvents DismissButton As System.Windows.Forms.Button
    Friend WithEvents NewCarBrandDropdown As System.Windows.Forms.ComboBox
    Friend WithEvents NewCarHorsePowerInput As System.Windows.Forms.NumericUpDown
    Friend WithEvents NewCarColorDropdown As System.Windows.Forms.ComboBox
    Friend WithEvents ColorLabel As System.Windows.Forms.Label
    Friend WithEvents NewCarFuelDropdown As System.Windows.Forms.ComboBox
    Friend WithEvents FuelLabel As System.Windows.Forms.Label
    Friend WithEvents BrandLabel As System.Windows.Forms.Label
    Friend WithEvents ModelLabel As System.Windows.Forms.Label
    Friend WithEvents EngineVolumeLabel As System.Windows.Forms.Label
    Friend WithEvents YearLabel As System.Windows.Forms.Label
    Friend WithEvents HorsePowerLabel As System.Windows.Forms.Label
    Friend WithEvents NewCarYearDropdown As System.Windows.Forms.ComboBox
    Friend WithEvents NewCarModelInput As System.Windows.Forms.TextBox
    Friend WithEvents NewCarPriceInput As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
