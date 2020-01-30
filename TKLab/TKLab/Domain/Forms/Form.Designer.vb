<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form))
        Me.ModelInput = New System.Windows.Forms.TextBox()
        Me.YearToDropdown = New System.Windows.Forms.ComboBox()
        Me.YearFromDropdown = New System.Windows.Forms.ComboBox()
        Me.HorsePowerLabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.HorsePowerToLabel = New System.Windows.Forms.Label()
        Me.YearLabel = New System.Windows.Forms.Label()
        Me.YearFromLabel = New System.Windows.Forms.Label()
        Me.HorsePowerFromLabel = New System.Windows.Forms.Label()
        Me.EngineVolumeLabel = New System.Windows.Forms.Label()
        Me.ModelLabel = New System.Windows.Forms.Label()
        Me.EngineVolumeToLabel = New System.Windows.Forms.Label()
        Me.BrandLabel = New System.Windows.Forms.Label()
        Me.EngineVolumeFromLabel = New System.Windows.Forms.Label()
        Me.FuelLabel = New System.Windows.Forms.Label()
        Me.HorsePowerFromInput = New System.Windows.Forms.TextBox()
        Me.FuelDropdown = New System.Windows.Forms.ComboBox()
        Me.HorsePowerToInput = New System.Windows.Forms.TextBox()
        Me.ColorLabel = New System.Windows.Forms.Label()
        Me.EngineVolumeFromInput = New System.Windows.Forms.TextBox()
        Me.ColorDropdown = New System.Windows.Forms.ComboBox()
        Me.EngineVolumeToInput = New System.Windows.Forms.TextBox()
        Me.BrandDropdown = New System.Windows.Forms.ComboBox()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.FiltersPanel = New System.Windows.Forms.Panel()
        Me.ClearFiltersButton = New System.Windows.Forms.Button()
        Me.ListPanel = New System.Windows.Forms.Panel()
        Me.CarList = New System.Windows.Forms.ListBox()
        Me.CarImagePanel = New System.Windows.Forms.PictureBox()
        Me.AddCarButton = New System.Windows.Forms.Button()
        Me.RemoveCarButton = New System.Windows.Forms.Button()
        Me.FiltersPanel.SuspendLayout()
        Me.ListPanel.SuspendLayout()
        CType(Me.CarImagePanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ModelInput
        '
        Me.ModelInput.Location = New System.Drawing.Point(14, 79)
        Me.ModelInput.Name = "ModelInput"
        Me.ModelInput.Size = New System.Drawing.Size(166, 20)
        Me.ModelInput.TabIndex = 12
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
        'YearFromDropdown
        '
        Me.YearFromDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.YearFromDropdown.FormattingEnabled = True
        Me.YearFromDropdown.Location = New System.Drawing.Point(46, 125)
        Me.YearFromDropdown.Name = "YearFromDropdown"
        Me.YearFromDropdown.Size = New System.Drawing.Size(53, 21)
        Me.YearFromDropdown.TabIndex = 17
        '
        'HorsePowerLabel
        '
        Me.HorsePowerLabel.AutoSize = True
        Me.HorsePowerLabel.Location = New System.Drawing.Point(11, 159)
        Me.HorsePowerLabel.Name = "HorsePowerLabel"
        Me.HorsePowerLabel.Size = New System.Drawing.Size(68, 13)
        Me.HorsePowerLabel.TabIndex = 19
        Me.HorsePowerLabel.Text = "Horse Power"
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
        'HorsePowerToLabel
        '
        Me.HorsePowerToLabel.AutoSize = True
        Me.HorsePowerToLabel.Location = New System.Drawing.Point(105, 179)
        Me.HorsePowerToLabel.Name = "HorsePowerToLabel"
        Me.HorsePowerToLabel.Size = New System.Drawing.Size(16, 13)
        Me.HorsePowerToLabel.TabIndex = 20
        Me.HorsePowerToLabel.Text = "to"
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
        'YearFromLabel
        '
        Me.YearFromLabel.AutoSize = True
        Me.YearFromLabel.Location = New System.Drawing.Point(15, 128)
        Me.YearFromLabel.Name = "YearFromLabel"
        Me.YearFromLabel.Size = New System.Drawing.Size(27, 13)
        Me.YearFromLabel.TabIndex = 23
        Me.YearFromLabel.Text = "from"
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
        'EngineVolumeLabel
        '
        Me.EngineVolumeLabel.AutoSize = True
        Me.EngineVolumeLabel.Location = New System.Drawing.Point(13, 214)
        Me.EngineVolumeLabel.Name = "EngineVolumeLabel"
        Me.EngineVolumeLabel.Size = New System.Drawing.Size(78, 13)
        Me.EngineVolumeLabel.TabIndex = 25
        Me.EngineVolumeLabel.Text = "Engine Volume"
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
        'EngineVolumeToLabel
        '
        Me.EngineVolumeToLabel.AutoSize = True
        Me.EngineVolumeToLabel.Location = New System.Drawing.Point(105, 233)
        Me.EngineVolumeToLabel.Name = "EngineVolumeToLabel"
        Me.EngineVolumeToLabel.Size = New System.Drawing.Size(16, 13)
        Me.EngineVolumeToLabel.TabIndex = 26
        Me.EngineVolumeToLabel.Text = "to"
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
        'EngineVolumeFromLabel
        '
        Me.EngineVolumeFromLabel.AutoSize = True
        Me.EngineVolumeFromLabel.Location = New System.Drawing.Point(13, 233)
        Me.EngineVolumeFromLabel.Name = "EngineVolumeFromLabel"
        Me.EngineVolumeFromLabel.Size = New System.Drawing.Size(27, 13)
        Me.EngineVolumeFromLabel.TabIndex = 29
        Me.EngineVolumeFromLabel.Text = "from"
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
        'HorsePowerFromInput
        '
        Me.HorsePowerFromInput.Location = New System.Drawing.Point(46, 175)
        Me.HorsePowerFromInput.Name = "HorsePowerFromInput"
        Me.HorsePowerFromInput.Size = New System.Drawing.Size(53, 20)
        Me.HorsePowerFromInput.TabIndex = 30
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
        'HorsePowerToInput
        '
        Me.HorsePowerToInput.Location = New System.Drawing.Point(127, 175)
        Me.HorsePowerToInput.Name = "HorsePowerToInput"
        Me.HorsePowerToInput.Size = New System.Drawing.Size(53, 20)
        Me.HorsePowerToInput.TabIndex = 31
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
        'EngineVolumeFromInput
        '
        Me.EngineVolumeFromInput.Location = New System.Drawing.Point(46, 230)
        Me.EngineVolumeFromInput.Name = "EngineVolumeFromInput"
        Me.EngineVolumeFromInput.Size = New System.Drawing.Size(53, 20)
        Me.EngineVolumeFromInput.TabIndex = 32
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
        'EngineVolumeToInput
        '
        Me.EngineVolumeToInput.Location = New System.Drawing.Point(127, 230)
        Me.EngineVolumeToInput.Name = "EngineVolumeToInput"
        Me.EngineVolumeToInput.Size = New System.Drawing.Size(53, 20)
        Me.EngineVolumeToInput.TabIndex = 33
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
        'SearchButton
        '
        Me.SearchButton.Location = New System.Drawing.Point(103, 370)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(77, 25)
        Me.SearchButton.TabIndex = 34
        Me.SearchButton.Text = "Search"
        Me.SearchButton.UseVisualStyleBackColor = True
        '
        'FiltersPanel
        '
        Me.FiltersPanel.BackColor = System.Drawing.SystemColors.Window
        Me.FiltersPanel.Controls.Add(Me.ClearFiltersButton)
        Me.FiltersPanel.Controls.Add(Me.SearchButton)
        Me.FiltersPanel.Controls.Add(Me.BrandDropdown)
        Me.FiltersPanel.Controls.Add(Me.EngineVolumeToInput)
        Me.FiltersPanel.Controls.Add(Me.ColorDropdown)
        Me.FiltersPanel.Controls.Add(Me.EngineVolumeFromInput)
        Me.FiltersPanel.Controls.Add(Me.ColorLabel)
        Me.FiltersPanel.Controls.Add(Me.HorsePowerToInput)
        Me.FiltersPanel.Controls.Add(Me.FuelDropdown)
        Me.FiltersPanel.Controls.Add(Me.HorsePowerFromInput)
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
        Me.FiltersPanel.Location = New System.Drawing.Point(12, 12)
        Me.FiltersPanel.Name = "FiltersPanel"
        Me.FiltersPanel.Size = New System.Drawing.Size(196, 415)
        Me.FiltersPanel.TabIndex = 34
        '
        'ClearFiltersButton
        '
        Me.ClearFiltersButton.Location = New System.Drawing.Point(14, 370)
        Me.ClearFiltersButton.Name = "ClearFiltersButton"
        Me.ClearFiltersButton.Size = New System.Drawing.Size(77, 25)
        Me.ClearFiltersButton.TabIndex = 35
        Me.ClearFiltersButton.Text = "Clear Filters"
        Me.ClearFiltersButton.UseVisualStyleBackColor = True
        '
        'ListPanel
        '
        Me.ListPanel.BackColor = System.Drawing.SystemColors.Window
        Me.ListPanel.Controls.Add(Me.CarList)
        Me.ListPanel.Location = New System.Drawing.Point(223, 12)
        Me.ListPanel.Name = "ListPanel"
        Me.ListPanel.Size = New System.Drawing.Size(400, 355)
        Me.ListPanel.TabIndex = 35
        '
        'CarList
        '
        Me.CarList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CarList.FormattingEnabled = True
        Me.CarList.Location = New System.Drawing.Point(3, 3)
        Me.CarList.Name = "CarList"
        Me.CarList.ScrollAlwaysVisible = True
        Me.CarList.Size = New System.Drawing.Size(394, 351)
        Me.CarList.TabIndex = 0
        '
        'CarImagePanel
        '
        Me.CarImagePanel.Location = New System.Drawing.Point(638, 12)
        Me.CarImagePanel.Name = "CarImagePanel"
        Me.CarImagePanel.Size = New System.Drawing.Size(590, 415)
        Me.CarImagePanel.TabIndex = 36
        Me.CarImagePanel.TabStop = False
        '
        'AddCarButton
        '
        Me.AddCarButton.BackColor = System.Drawing.Color.LightGray
        Me.AddCarButton.Location = New System.Drawing.Point(223, 382)
        Me.AddCarButton.Name = "AddCarButton"
        Me.AddCarButton.Size = New System.Drawing.Size(192, 45)
        Me.AddCarButton.TabIndex = 35
        Me.AddCarButton.Text = "Add"
        Me.AddCarButton.UseVisualStyleBackColor = False
        '
        'RemoveCarButton
        '
        Me.RemoveCarButton.BackColor = System.Drawing.Color.LightGray
        Me.RemoveCarButton.Location = New System.Drawing.Point(431, 382)
        Me.RemoveCarButton.Name = "RemoveCarButton"
        Me.RemoveCarButton.Size = New System.Drawing.Size(192, 45)
        Me.RemoveCarButton.TabIndex = 36
        Me.RemoveCarButton.Text = "Remove"
        Me.RemoveCarButton.UseVisualStyleBackColor = False
        '
        'Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1239, 440)
        Me.Controls.Add(Me.RemoveCarButton)
        Me.Controls.Add(Me.CarImagePanel)
        Me.Controls.Add(Me.AddCarButton)
        Me.Controls.Add(Me.ListPanel)
        Me.Controls.Add(Me.FiltersPanel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form"
        Me.Text = "Komis"
        Me.FiltersPanel.ResumeLayout(False)
        Me.FiltersPanel.PerformLayout()
        Me.ListPanel.ResumeLayout(False)
        CType(Me.CarImagePanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ModelInput As TextBox
    Friend WithEvents YearToDropdown As ComboBox
    Friend WithEvents YearFromDropdown As ComboBox
    Friend WithEvents HorsePowerLabel As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents HorsePowerToLabel As Label
    Friend WithEvents YearLabel As Label
    Friend WithEvents YearFromLabel As Label
    Friend WithEvents HorsePowerFromLabel As Label
    Friend WithEvents EngineVolumeLabel As Label
    Friend WithEvents ModelLabel As Label
    Friend WithEvents EngineVolumeToLabel As Label
    Friend WithEvents BrandLabel As Label
    Friend WithEvents EngineVolumeFromLabel As Label
    Friend WithEvents FuelLabel As Label
    Friend WithEvents HorsePowerFromInput As TextBox
    Friend WithEvents FuelDropdown As ComboBox
    Friend WithEvents HorsePowerToInput As TextBox
    Friend WithEvents ColorLabel As Label
    Friend WithEvents EngineVolumeFromInput As TextBox
    Friend WithEvents ColorDropdown As ComboBox
    Friend WithEvents EngineVolumeToInput As TextBox
    Friend WithEvents BrandDropdown As ComboBox
    Friend WithEvents SearchButton As Button
    Friend WithEvents FiltersPanel As Panel
    Friend WithEvents ListPanel As Panel
    Friend WithEvents CarList As ListBox
    Friend WithEvents AddCarButton As Button
    Friend WithEvents CarImagePanel As PictureBox
    Friend WithEvents RemoveCarButton As Button
    Friend WithEvents ClearFiltersButton As Button
End Class
