Option Strict On

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCarInventory
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
        Me.components = New System.ComponentModel.Container()
        Me.lvwCars = New System.Windows.Forms.ListView()
        Me.colNew = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colMake = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colModel = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colYear = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colPrice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chkNew = New System.Windows.Forms.CheckBox()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblModel = New System.Windows.Forms.Label()
        Me.lblMake = New System.Windows.Forms.Label()
        Me.cmbMake = New System.Windows.Forms.ComboBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtModel = New System.Windows.Forms.TextBox()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.cmbYear = New System.Windows.Forms.ComboBox()
        Me.carInventoryToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'lvwCars
        '
        Me.lvwCars.CheckBoxes = True
        Me.lvwCars.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colNew, Me.colID, Me.colMake, Me.colModel, Me.colYear, Me.colPrice})
        Me.lvwCars.FullRowSelect = True
        Me.lvwCars.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvwCars.Location = New System.Drawing.Point(7, 135)
        Me.lvwCars.MultiSelect = False
        Me.lvwCars.Name = "lvwCars"
        Me.lvwCars.Size = New System.Drawing.Size(330, 246)
        Me.lvwCars.TabIndex = 9
        Me.carInventoryToolTip.SetToolTip(Me.lvwCars, "Select a car to make modifications")
        Me.lvwCars.UseCompatibleStateImageBehavior = False
        Me.lvwCars.View = System.Windows.Forms.View.Details
        '
        'colNew
        '
        Me.colNew.Text = "New"
        Me.colNew.Width = 48
        '
        'colID
        '
        Me.colID.Text = "ID"
        Me.colID.Width = 36
        '
        'colMake
        '
        Me.colMake.Text = "Make"
        '
        'colModel
        '
        Me.colModel.Text = "Model"
        '
        'colYear
        '
        Me.colYear.Text = "Year"
        Me.colYear.Width = 41
        '
        'colPrice
        '
        Me.colPrice.Text = "Price"
        Me.colPrice.Width = 84
        '
        'chkNew
        '
        Me.chkNew.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkNew.Location = New System.Drawing.Point(39, 110)
        Me.chkNew.Name = "chkNew"
        Me.chkNew.Size = New System.Drawing.Size(58, 24)
        Me.chkNew.TabIndex = 8
        Me.chkNew.Text = "&New:"
        Me.chkNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.carInventoryToolTip.SetToolTip(Me.chkNew, "Select if the car is a new one")
        Me.chkNew.UseVisualStyleBackColor = True
        '
        'lblPrice
        '
        Me.lblPrice.Location = New System.Drawing.Point(12, 90)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(66, 13)
        Me.lblPrice.TabIndex = 6
        Me.lblPrice.Text = "&Price:"
        Me.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblModel
        '
        Me.lblModel.Location = New System.Drawing.Point(12, 36)
        Me.lblModel.Name = "lblModel"
        Me.lblModel.Size = New System.Drawing.Size(66, 13)
        Me.lblModel.TabIndex = 2
        Me.lblModel.Text = "M&odel:"
        Me.lblModel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblModel.UseWaitCursor = True
        '
        'lblMake
        '
        Me.lblMake.Location = New System.Drawing.Point(12, 9)
        Me.lblMake.Name = "lblMake"
        Me.lblMake.Size = New System.Drawing.Size(66, 13)
        Me.lblMake.TabIndex = 0
        Me.lblMake.Text = "&Make: "
        Me.lblMake.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbMake
        '
        Me.cmbMake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMake.FormattingEnabled = True
        Me.cmbMake.Items.AddRange(New Object() {"Alfa Romeo", "Audi", "BMW", "Chevrolet", "Chrysler", "Citroen", "Dodge", "Ferrari", "Fiat", "Ford", "GMC", "Honda", "Hyundai", "Jaguar", "Jeep", "Kia", "Lamborghini", "Land Rover", "Lexus", "Lifan", "Lotus", "Mazda", "Mercedes-Benz", "Mitsubishi", "Nissan", "Peugeot", "Porsche", "Range Rover", "Renault", "Subaru", "Suzuki", "Tesla", "Toyota", "Volkswagen", "Volvo"})
        Me.cmbMake.Location = New System.Drawing.Point(84, 9)
        Me.cmbMake.Name = "cmbMake"
        Me.cmbMake.Size = New System.Drawing.Size(121, 21)
        Me.cmbMake.TabIndex = 1
        Me.carInventoryToolTip.SetToolTip(Me.cmbMake, "Select the make of the car")
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(84, 87)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(121, 20)
        Me.txtPrice.TabIndex = 7
        Me.carInventoryToolTip.SetToolTip(Me.txtPrice, "Insert the price of the car")
        '
        'txtModel
        '
        Me.txtModel.Location = New System.Drawing.Point(84, 36)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.Size = New System.Drawing.Size(121, 20)
        Me.txtModel.TabIndex = 3
        Me.carInventoryToolTip.SetToolTip(Me.txtModel, "Insert the model of the car")
        '
        'lblResult
        '
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResult.Location = New System.Drawing.Point(7, 378)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(330, 60)
        Me.lblResult.TabIndex = 10
        Me.carInventoryToolTip.SetToolTip(Me.lblResult, "An error or success message display label")
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(262, 443)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 13
        Me.btnExit.Text = "E&xit"
        Me.carInventoryToolTip.SetToolTip(Me.btnExit, "Exits program")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(181, 443)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 12
        Me.btnReset.Text = "&Reset"
        Me.carInventoryToolTip.SetToolTip(Me.btnReset, "Resets the form")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(100, 443)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(75, 23)
        Me.btnEnter.TabIndex = 11
        Me.btnEnter.Text = "&Enter"
        Me.carInventoryToolTip.SetToolTip(Me.btnEnter, "Enters the car in the list")
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'lblYear
        '
        Me.lblYear.Location = New System.Drawing.Point(12, 62)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(66, 13)
        Me.lblYear.TabIndex = 4
        Me.lblYear.Text = "&Year:"
        Me.lblYear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbYear
        '
        Me.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbYear.FormattingEnabled = True
        Me.cmbYear.Items.AddRange(New Object() {"1998", "1999", "2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019"})
        Me.cmbYear.Location = New System.Drawing.Point(84, 62)
        Me.cmbYear.Name = "cmbYear"
        Me.cmbYear.Size = New System.Drawing.Size(121, 21)
        Me.cmbYear.TabIndex = 5
        Me.carInventoryToolTip.SetToolTip(Me.cmbYear, "Select the year of the car")
        '
        'frmCarInventory
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(344, 474)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.cmbYear)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.lvwCars)
        Me.Controls.Add(Me.chkNew)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblModel)
        Me.Controls.Add(Me.lblMake)
        Me.Controls.Add(Me.cmbMake)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtModel)
        Me.Name = "frmCarInventory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Car Inventory"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lvwCars As ListView
    Friend WithEvents colNew As ColumnHeader
    Friend WithEvents colID As ColumnHeader
    Friend WithEvents colMake As ColumnHeader
    Friend WithEvents colModel As ColumnHeader
    Friend WithEvents colYear As ColumnHeader
    Friend WithEvents chkNew As CheckBox
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblModel As Label
    Friend WithEvents lblMake As Label
    Friend WithEvents cmbMake As ComboBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtModel As TextBox
    Friend WithEvents lblResult As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnEnter As Button
    Friend WithEvents lblYear As Label
    Friend WithEvents cmbYear As ComboBox
    Friend WithEvents colPrice As ColumnHeader
    Friend WithEvents carInventoryToolTip As ToolTip


End Class
