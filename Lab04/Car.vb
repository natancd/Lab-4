' **************************************************************************************************************************************************/
' * Lab 4: Car Inventory
' * Program: Lab04                                    
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
Public Class Car

    Private Shared carCount As Integer          ' Static or shared private variable to hold the number of cars
    Private currentCar As Integer = 0           ' Private variable to hold the car's identification number
    Private carMake As String = String.Empty    ' Private variable to hold the car's make
    Private carModel As String = String.Empty   ' Private variable to hold the car's model
    Private carYear As String = String.Empty            ' Private variable to hold the car's year
    Private carPrice As Double = 0.0            ' Private variable to hold the car's price
    Private carNew As Boolean = False           ' Private variable to hold the car's status

    ' Constructor - Default - creates a new car object
    Public Sub New()

        carCount += 1           ' Increment the shared/static variable counter by 1
        currentCar = carCount   ' Assign the customers id

    End Sub

    ' Constructor - Parameterized - creates a new car object
    Public Sub New(make As String, model As String, year As String, price As Double, cNew As Boolean)

        Me.New()
        carMake = make      ' Set the car make
        carModel = model    ' Set the car model
        carYear = year      ' Set the car year
        carPrice = price    ' Set the car price
        carNew = cNew       ' Set the car status

    End Sub

    ' Count ReadOnly Property - Gets the number of car that have been instantiated/created
    Public ReadOnly Property Count() As Integer

        Get
            Return carCount
        End Get

    End Property

    ' IdentificationNumber ReadOnly Property - Gets a specific cars identification number
    Public ReadOnly Property IdentificationNumber() As Integer

        Get
            Return currentCar
        End Get

    End Property

    ' Make property - Gets and Sets the make of a car
    Public Property Make() As String

        Get
            Return carMake
        End Get
        Set(ByVal value As String)
            carMake = value
        End Set

    End Property

    ' Model property - Gets and Sets the model of a car
    Public Property Model() As String

        Get
            Return carModel
        End Get
        Set(ByVal value As String)
            carModel = value
        End Set

    End Property

    ' Year property - Gets and Sets the year of a car
    Public Property Year() As String

        Get
            Return carYear
        End Get
        Set(ByVal value As String)
            carYear = value
        End Set

    End Property

    ' Price property - Gets and Sets the price of a car
    Public Property Price() As Double

        Get
            Return CDbl(carPrice)
        End Get
        Set(ByVal value As Double)
            carPrice = value
        End Set

    End Property

    ' New Property - Gets and Sets the new status of a car
    Public Property cNew() As Boolean

        Get
            Return carNew
        End Get
        Set(ByVal value As Boolean)
            carNew = value
        End Set

    End Property

    ' GetCar is a function that describes the selected car based on the private properties within the class scope
    Public Function GetCar() As String
        Return "The selected car is a " & carYear & " " & carMake & " " & carModel & ", and its price is " & carPrice.ToString("C") & ". " & IIf(carNew = True, "It is a new car", "It is not a new car").ToString()
    End Function

End Class
