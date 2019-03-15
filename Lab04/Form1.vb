' **************************************************************************************************************************************************/
' * Lab 4: Car Inventory
' * Program: Lab0                          
' * Course: NET DEVELOPMENT I (NETD-2202)                                                                 
' * Author:      Natan Colavite Dellagiustina  - 100722419                                    
' * Date:        March 15th, 2019 
' *                                                                                
' * Description:                                                                    
' *              This program will prompt the user a form application, where they must select a car by its make, model, year and price.
' *              Also, an option will be available for them to check if the car is a new one. The program will then prompt the user the selected car
' *              in a list, where it is possible to check and edit it or add a new car to the list. The user must fill and combo and text boxes in
' *              order to the program work. The user can reset the form by clicking the Reset button and Exit by clicking in the Exit button any time.
' **************************************************************************************************************************************************/

Option Strict On
Public Class frmCarInventory
    Const MINIMUM_PRICE As Double = 0.0
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close the form
        Me.Close()
    End Sub

    Private carList As New SortedList           ' Collection of all the carList in the list
    Private currentCar As String = String.Empty ' Current selected car
    Private editMode As Boolean = False

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        Dim car As Car                 ' Declare a Car class
        Dim carItem As ListViewItem    ' Declare a ListViewItem class

        ' Validation for the data - calling the function
        If IsValidInput() = True Then
            editMode = True
            lblResult.Text = "It worked!"

            ' In case the validation passed, it will create a new object using the constructor and add it to the list
            If currentCar.Trim.Length = 0 Then
                car = New Car(cmbMake.Text, txtModel.Text, cmbYear.Text, CDbl(txtPrice.Text), chkNew.Checked)
                carList.Add(car.IdentificationNumber.ToString(), car)
            Else
                ' In case the user selected something from the list, it will update it according to the new selection
                car = CType(carList.Item(currentCar), Car)
                car.Make = cmbMake.Text
                car.Model = txtModel.Text
                car.Year = cmbYear.Text
                car.Price = CDbl(txtPrice.Text)
                car.cNew = chkNew.Checked
            End If
            ' Clear the items from the listview control
            lvwCars.Items.Clear()
            ' Loop for new entries and add it to the list
            For Each carEntry As DictionaryEntry In carList
                ' Instantiate a new ListViewItem
                carItem = New ListViewItem()
                ' Get the car from the list
                car = CType(carEntry.Value, Car)
                ' Assign values for all subitems and checks
                carItem.Checked = car.cNew
                carItem.SubItems.Add(car.IdentificationNumber.ToString())
                carItem.SubItems.Add(car.Make)
                carItem.SubItems.Add(car.Model)
                carItem.SubItems.Add(car.Year)
                carItem.SubItems.Add(car.Price.ToString("C"))
                ' Add the items to the listview
                lvwCars.Items.Add(carItem)

            Next carEntry
            ' Clear controls
            Reset()
            editMode = False

        End If
    End Sub

    Private Sub Reset()
        ' Reset function
        cmbMake.SelectedIndex = -1
        txtModel.Text = String.Empty
        cmbYear.SelectedIndex = -1
        txtPrice.Text = String.Empty
        chkNew.Checked = False
        lblResult.Text = String.Empty
        currentCar = String.Empty

    End Sub
    ' IsValidInput Function - validates the data in each control to ensure that the user has entered appropriate values
    Private Function IsValidInput() As Boolean

        Dim priceIsRight As Double
        Dim returnValue As Boolean = True
        Dim outputMessage As String = String.Empty
        ' check if the make has been selected
        If cmbMake.SelectedIndex = -1 Then
            ' If not set the error message and set the return value to false
            outputMessage += "Please select the car's Make." & vbCrLf
            returnValue = False

        End If
        ' check if the model has been enterd
        If txtModel.Text.Trim.Length = 0 Then
            ' If not set the error message and set the return value to false
            outputMessage += "Please enter the model of the car." & vbCrLf
            returnValue = False

        End If
        ' check if the year has been selected
        If cmbYear.SelectedIndex = -1 Then
            ' If not set the error message and set the return value to false
            outputMessage += "Please select the car's year." & vbCrLf
            returnValue = False

        End If
        ' check if the price has been entered
        If txtPrice.Text.Trim.Length = 0 Then
            ' If not set the error message and set the return value to false
            outputMessage += "Please enter the price of the car." & vbCrLf
            returnValue = False
        Else
            ' Check if the number is actually a number and it is higher than zero
            If (Double.TryParse(txtPrice.Text.Trim, priceIsRight) = False OrElse priceIsRight < MINIMUM_PRICE) Then
                txtPrice.Clear()
                txtPrice.Focus()
                outputMessage += "The price of the car must be a real number and must be higher than " & MINIMUM_PRICE & "."
            End If
        End If

        ' If else to check if there's any false return (or error)
        If returnValue = False Then

            ' Show the message(s) to the user
            lblResult.Text = "ERRORS" & vbCrLf & outputMessage

        End If
        Return returnValue

    End Function

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ' Call the reset function
        Reset()
    End Sub
    ' lvwCustomers_ItemCheck - used to prevent the user from checking the check box in the list view if it is not in edit mode 
    Private Sub lvwCars_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles lvwCars.ItemCheck

        If editMode = False Then
            e.NewValue = e.CurrentValue

        End If
    End Sub

    ' lvwCustomers_SelectedIndexChanged - when the user selected a row in the list it will populate the fields for editing
    Private Sub lvwCars_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvwCars.SelectedIndexChanged
        ' Constant that represents the index of the subitem in the list that holds the car identification number 
        Const identificationSubItemIndex As Integer = 1
        ' Get the car identification number 
        currentCar = lvwCars.Items(lvwCars.FocusedItem.Index).SubItems(identificationSubItemIndex).Text
        ' Use the car identification number to get the car from the collection object
        Dim car As Car = CType(carList.Item(currentCar), Car)
        ' Set the controls on the form
        cmbMake.Text = car.Make
        txtModel.Text = car.Model
        txtPrice.Text = CType(car.Price, String)
        cmbYear.Text = car.Year
        chkNew.Checked = car.cNew

        lblResult.Text = car.GetSalutation()

    End Sub

End Class
