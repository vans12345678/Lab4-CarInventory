'*****  Lab 4 - Car Viewer                                                                  *****'
'*****  Name: Andre Agrippa                                                                 *****'
'*****                                                                                      *****'
'*****  Purpose: The user can enter car make, model, year, price and                        *****'
'*****           whether it's new. The user's valid entries will be shown                   *****'
'*****           in the list view, otherwise, the errors will be shown in                   *****'
'*****           the output label at the bottom.                                            *****'
'*****                                                                                      *****'
'*****           This program uses the "Car.vb" class                                       *****'
'*****                                                                                      *****'
'*****  Date: 03/15/2020                                                                    *****'
'*****  Class: NETD 2202 

Option Strict On
Public Class frmCarViewer

#Region "Variables"
    Dim selectedCar As Car                  'Declare car class object
    Dim isCarSelected As Boolean = False    'Determine if car is being selected
    Dim isAddingToListView As Boolean = False 'Determine if you are adding to listview
    Dim carList As New List(Of Car)           'Declare new list of objet car
#End Region

#Region "Event Handlers"

    ''' <summary>
    ''' Closes form without further action
    ''' </summary>
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    ''' <summary>
    ''' Returns form to default state by calling SetDefaults()
    ''' </summary>
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        SetDefaults()
    End Sub

    ''' <summary>
    ''' Will enter a new car entry to the list if the data is valid, otherwise will show errors
    ''' </summary>
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        'If user input valid 
        If IsValidInput() = True Then

            'If a car is selected
            If Not isCarSelected Then

                'Create a new car and add items to list
                selectedCar = New Car(cmbMake.Text, txtModel.Text, Convert.ToInt32(nudYear.Value), Convert.ToDecimal(txtPrice.Text), chkNew.Checked)
                carList.Add(selectedCar)

                'Else if there is a car that already exists, edit it
            ElseIf selectedCar.ID > 0 Then

                'Update the existing car based on entered values
                selectedCar.Make = cmbMake.Text
                selectedCar.Model = txtModel.Text
                selectedCar.Year = Convert.ToInt32(nudYear.Value)
                selectedCar.Price = Convert.ToDecimal(txtPrice.Text)
                selectedCar.IsNew = chkNew.Checked

            End If

            SetDefaults()

        End If

    End Sub
    ''' <summary>
    ''' Event handler for when a character is selected in the ListView
    ''' </summary>
    Private Sub lvwCars_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvwCars.SelectedIndexChanged

        If lvwCars.SelectedIndices.Count = 1 Then

            'Edits based on user entries
            selectedCar = carList(lvwCars.SelectedIndices(0))
            isCarSelected = True
            cmbMake.Text = selectedCar.Make
            txtModel.Text = selectedCar.Model
            txtPrice.Text = selectedCar.Price.ToString
            chkNew.Checked = selectedCar.IsNew

        Else
            isCarSelected = False
        End If

    End Sub
    ''' <summary>
    ''' Stops you from checking a box
    ''' </summary>
    Private Sub lvwCars_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles lvwCars.ItemCheck

        ' If we're not currently adding characters to the list
        If Not isAddingToListView Then

            ' Maintain the old checkbox value
            e.NewValue = e.CurrentValue

        End If

    End Sub

#End Region

#Region "Procedures"

    ''' <summary>
    ''' If the form has valid input, clear all entries and populate list 
    ''' </summary>
    Private Sub SetDefaults()

        'clear textboxes and combo box
        txtModel.Clear()
        txtPrice.Clear()
        cmbMake.SelectedIndex = -1


        chkNew.Checked = False
        lblOutput.Text = String.Empty

        'Populate list view
        PopulateList()

        isCarSelected = False

        cmbMake.Focus()

    End Sub


    ''' <summary>
    ''' The IsValidInput() function validates data in each control so that the all the data types are correct
    ''' </summary>
    ''' <returns>Boolean</returns>
    Private Function IsValidInput() As Boolean

        Dim isValid As Boolean = True
        Dim outputMessage As String = String.Empty
        Dim priceInput As Decimal

        'If make has an empty entry
        If cmbMake.Text.Trim.Length = 0 Then

            'Set make error message, focus on where error is
            outputMessage += "Please enter a Make." & vbCrLf
            cmbMake.Focus()
            cmbMake.SelectAll()
            'entry is now invalid
            isValid = False

        End If
        'If model has an empty entry
        If txtModel.Text.Trim.Length = 0 Then

            'Set Model error message, focus on where error is
            outputMessage += "Please enter a Model." & vbCrLf
            txtModel.Focus()
            txtModel.SelectAll()
            'entry is now invalid
            isValid = False

        End If
        'If price is not a decimal number/is empty
        If Not Decimal.TryParse(txtPrice.Text, priceInput) Then

            'Set price error message, focus on where error is
            outputMessage += "Please enter a price. Must be a decimal number greater than 0." & vbCrLf
            txtPrice.Focus()
            txtPrice.SelectAll()
            'entry is now invalid
            isValid = False

            'Else if price is less than 0
        ElseIf Convert.ToInt32(txtPrice.Text) < 0 Then

            'Set Price error message, focus on where error is
            outputMessage += "Price must be greater than 0"
            txtPrice.Focus()
            txtPrice.SelectAll()
            'entry is now invalid
            isValid = False

        End If

        'If there is an error, display error(s)
        If Not isValid Then
            lblOutput.Text = "ERRORS: " & vbCrLf & outputMessage
        End If

        Return isValid

    End Function

    ''' <summary>
    ''' This function clears and repopulates carItem ListView control
    ''' </summary>
    Sub PopulateList()

        lvwCars.Items.Clear()

        For index As Integer = 0 To carList.Count - 1

            'initialize new ListViewItem called carItem
            Dim carItem As New ListViewItem()

            lvwCars.CheckBoxes = True
            'assign the values to the checked control + sub items
            carItem.SubItems.Add(carList(index).ID.ToString)
            carItem.SubItems.Add(carList(index).Make)
            carItem.SubItems.Add(carList(index).Model)
            carItem.SubItems.Add(carList(index).Year.ToString)
            carItem.SubItems.Add(carList(index).Price.ToString("c"))
            carItem.Checked = carList(index).IsNew

            'Begin adding cars to the ListView
            isAddingToListView = True

            'Add new instantiated and populated ListViewItem to the listview control
            lvwCars.Items.Add(carItem)

            'Done adding cars to ListView
            isAddingToListView = False

        Next

    End Sub


#End Region

End Class
