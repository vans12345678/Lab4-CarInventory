'*****  Car.vb                                                                              *****'
'*****  Name: Andre Agrippa                                                                 *****'
'*****                                                                                      *****'
'*****  Purpose: Class that initializes object Car which has carIdentificationNumber,       *****'
'*****           carMake, carModel, carYear, carPrice, carNewStatus and carCount            *****'
'*****           as data that the car will have.                                            *****'
'*****                                                                                      *****'
'*****                                                                                      *****'
'*****  Date: 03/15/2020                                                                    *****'
'*****  Class: NETD 2202 

Option Strict On


Public Class Car

#Region "Variable Declarations"
    Private Shared carCount As Integer = 0
    Private carIdentificationNumber As Integer
    Private carMake As String = ""
    Private carModel As String = ""
    Private carYear As Integer = 0
    Private carPrice As Decimal = 0.0D
    Private carNewStatus As Boolean = True
#End Region
#Region "Constructors"
    'Default constructor for the car class; maintains a class count variable
    Friend Sub New()
        carCount += 1
        carIdentificationNumber = carCount
    End Sub

    ''' <summary>
    ''' Parametrizzed constructor for the car class. sets several instance variables based on values passed in
    ''' </summary>
    ''' <param name="makeValue"></param>
    ''' <param name="modelValue"></param>
    ''' <param name="yearValue"></param>
    ''' <param name="priceValue"></param>
    ''' <param name="statusValue"> boolean value indicating whether the car is new or not </param>
    Friend Sub New(makeValue As String, modelValue As String, yearValue As Integer, priceValue As Decimal, statusValue As Boolean)
        Me.New()
        carMake = makeValue
        carModel = modelValue
        carYear = yearValue
        carPrice = priceValue
        carNewStatus = statusValue
    End Sub


#End Region

#Region "Properties"
    ''' <summary>
    ''' Returns the number of car objects
    ''' </summary>
    ''' <returns>the number of car objects</returns>
    Friend Shared ReadOnly Property Count As Integer
        Get
            Return carCount
        End Get
    End Property
    ''' <summary>
    ''' Get a car's ID
    ''' </summary>
    ''' <returns>A car's identification number</returns>
    Friend ReadOnly Property ID() As Integer
        Get
            Return carIdentificationNumber
        End Get
    End Property
    ''' <summary>
    ''' Gets and sets a car's object's manufacturer
    ''' </summary>
    ''' <returns></returns>
    Friend Property Make() As String
        Get
            Return carMake
        End Get

        Set(ByVal value As String)
            carMake = value
        End Set
    End Property
    ''' <summary>
    ''' Get and sets a car's object model
    ''' </summary>
    ''' <returns> A car's model as string</returns>
    Friend Property Model() As String
        Get
            Return carModel
        End Get

        Set(ByVal value As String)
            carModel = value
        End Set
    End Property
    ''' <summary>
    ''' Gets abd set's a car's object year
    ''' </summary>
    ''' <returns></returns>
    Friend Property Year() As Integer
        Get
            Return carYear
        End Get

        Set(value As Integer)
            carYear = value
        End Set
    End Property
    ''' <summary>
    ''' Gets and sets a car's object price
    ''' </summary>
    ''' <returns>A car's price as a decimal value</returns>
    Friend Property Price() As Decimal
        Get
            Return carPrice
        End Get

        Set(ByVal value As Decimal)
            carPrice = value
        End Set
    End Property
    ''' <summary>
    ''' Gets and set's a value indicating whether the car is new or not (used)
    ''' </summary>
    ''' <returns>True if the car is new; False if the car is used</returns>
    Friend Property IsNew() As Boolean
        Get
            Return carNewStatus
        End Get

        Set(ByVal value As Boolean)
            carNewStatus = value
        End Set
    End Property
#End Region

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns>A string representing the car object’s data</returns>
#Region "Methods"
    Friend Function GetCarData() As String

        'Method 1 using inline if statement   Return IIf(carNewStatus, "New", "Used").ToString & " " & carYear.ToString() & " " & carMake & " " & carModel & " " & " for " & carPrice.ToString("c")

        'Method 2: Using regular if statement
        If carNewStatus = True Then
            Return "New " & " " & carYear.ToString() & " " & carMake & " " & carModel & " " & " for " & carPrice.ToString("c")
        Else
            Return "Used " & " " & carYear.ToString() & " " & carMake & " " & carModel & " " & " for " & carPrice.ToString("c")
        End If

    End Function
#End Region


End Class