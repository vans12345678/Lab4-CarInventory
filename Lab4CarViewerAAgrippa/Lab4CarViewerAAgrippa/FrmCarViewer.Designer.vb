<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCarViewer
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
        Me.components = New System.ComponentModel.Container()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.chkNew = New System.Windows.Forms.CheckBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtModel = New System.Windows.Forms.TextBox()
        Me.lvwCars = New System.Windows.Forms.ListView()
        Me.colNew = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colMake = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colModel = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colYear = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colPrice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmbMake = New System.Windows.Forms.ComboBox()
        Me.lblNew = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblModel = New System.Windows.Forms.Label()
        Me.lblMake = New System.Windows.Forms.Label()
        Me.nudYear = New System.Windows.Forms.NumericUpDown()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.tipCarInventory = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.nudYear, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(517, 452)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(72, 32)
        Me.btnExit.TabIndex = 14
        Me.btnExit.Text = "E&xit"
        Me.tipCarInventory.SetToolTip(Me.btnExit, " Closes the form without further action")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(404, 452)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(2)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(72, 32)
        Me.btnReset.TabIndex = 13
        Me.btnReset.Text = "&Reset"
        Me.tipCarInventory.SetToolTip(Me.btnReset, "Resets form to the default state")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(284, 452)
        Me.btnEnter.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(72, 32)
        Me.btnEnter.TabIndex = 12
        Me.btnEnter.Text = "&Enter"
        Me.tipCarInventory.SetToolTip(Me.btnEnter, "Enters data to list view")
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'chkNew
        '
        Me.chkNew.AutoSize = True
        Me.chkNew.Location = New System.Drawing.Point(152, 146)
        Me.chkNew.Margin = New System.Windows.Forms.Padding(2)
        Me.chkNew.Name = "chkNew"
        Me.chkNew.Size = New System.Drawing.Size(15, 14)
        Me.chkNew.TabIndex = 9
        Me.tipCarInventory.SetToolTip(Me.chkNew, "Car new check box")
        Me.chkNew.UseVisualStyleBackColor = True
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(152, 115)
        Me.txtPrice.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPrice.Multiline = True
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(112, 22)
        Me.txtPrice.TabIndex = 7
        Me.tipCarInventory.SetToolTip(Me.txtPrice, "Car price textbox, must be a decimal number")
        '
        'txtModel
        '
        Me.txtModel.Location = New System.Drawing.Point(152, 50)
        Me.txtModel.Margin = New System.Windows.Forms.Padding(2)
        Me.txtModel.Multiline = True
        Me.txtModel.Name = "txtModel"
        Me.txtModel.Size = New System.Drawing.Size(112, 22)
        Me.txtModel.TabIndex = 3
        Me.tipCarInventory.SetToolTip(Me.txtModel, "Car model text input")
        '
        'lvwCars
        '
        Me.lvwCars.CheckBoxes = True
        Me.lvwCars.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colNew, Me.colID, Me.colMake, Me.colModel, Me.colYear, Me.colPrice})
        Me.lvwCars.FullRowSelect = True
        Me.lvwCars.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvwCars.HideSelection = False
        Me.lvwCars.Location = New System.Drawing.Point(33, 178)
        Me.lvwCars.Margin = New System.Windows.Forms.Padding(2)
        Me.lvwCars.MultiSelect = False
        Me.lvwCars.Name = "lvwCars"
        Me.lvwCars.Size = New System.Drawing.Size(558, 175)
        Me.lvwCars.TabIndex = 10
        Me.tipCarInventory.SetToolTip(Me.lvwCars, "List of all car entries will be shown here")
        Me.lvwCars.UseCompatibleStateImageBehavior = False
        Me.lvwCars.View = System.Windows.Forms.View.Details
        '
        'colNew
        '
        Me.colNew.Text = "New"
        Me.colNew.Width = 75
        '
        'colID
        '
        Me.colID.Text = "ID"
        Me.colID.Width = 100
        '
        'colMake
        '
        Me.colMake.Text = "Make"
        Me.colMake.Width = 100
        '
        'colModel
        '
        Me.colModel.Text = "Model"
        Me.colModel.Width = 100
        '
        'colYear
        '
        Me.colYear.Text = "Year"
        Me.colYear.Width = 100
        '
        'colPrice
        '
        Me.colPrice.Text = "Price"
        Me.colPrice.Width = 100
        '
        'cmbMake
        '
        Me.cmbMake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMake.FormattingEnabled = True
        Me.cmbMake.Items.AddRange(New Object() {"Volkswagen", "Nissan", "Honda", "Subaru", "Lexus", "Hyundai"})
        Me.cmbMake.Location = New System.Drawing.Point(152, 16)
        Me.cmbMake.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbMake.Name = "cmbMake"
        Me.cmbMake.Size = New System.Drawing.Size(112, 21)
        Me.cmbMake.TabIndex = 1
        Me.tipCarInventory.SetToolTip(Me.cmbMake, "Car make combo box")
        '
        'lblNew
        '
        Me.lblNew.Location = New System.Drawing.Point(91, 146)
        Me.lblNew.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNew.Name = "lblNew"
        Me.lblNew.Size = New System.Drawing.Size(32, 13)
        Me.lblNew.TabIndex = 8
        Me.lblNew.Text = "&New:"
        Me.tipCarInventory.SetToolTip(Me.lblNew, "Car new entry")
        '
        'lblPrice
        '
        Me.lblPrice.Location = New System.Drawing.Point(87, 115)
        Me.lblPrice.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(34, 13)
        Me.lblPrice.TabIndex = 6
        Me.lblPrice.Text = "&Price:"
        Me.tipCarInventory.SetToolTip(Me.lblPrice, "Car price entry")
        '
        'lblYear
        '
        Me.lblYear.Location = New System.Drawing.Point(89, 84)
        Me.lblYear.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(32, 13)
        Me.lblYear.TabIndex = 4
        Me.lblYear.Text = "&Year:"
        Me.tipCarInventory.SetToolTip(Me.lblYear, "Car year entry")
        '
        'lblModel
        '
        Me.lblModel.Location = New System.Drawing.Point(83, 52)
        Me.lblModel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblModel.Name = "lblModel"
        Me.lblModel.Size = New System.Drawing.Size(39, 13)
        Me.lblModel.TabIndex = 2
        Me.lblModel.Text = "&Model:"
        Me.tipCarInventory.SetToolTip(Me.lblModel, "Car model entry")
        '
        'lblMake
        '
        Me.lblMake.Location = New System.Drawing.Point(85, 16)
        Me.lblMake.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblMake.Name = "lblMake"
        Me.lblMake.Size = New System.Drawing.Size(37, 13)
        Me.lblMake.TabIndex = 0
        Me.lblMake.Text = "M&ake:"
        Me.tipCarInventory.SetToolTip(Me.lblMake, "Car make entry")
        '
        'nudYear
        '
        Me.nudYear.Location = New System.Drawing.Point(152, 82)
        Me.nudYear.Maximum = New Decimal(New Integer() {2020, 0, 0, 0})
        Me.nudYear.Minimum = New Decimal(New Integer() {1920, 0, 0, 0})
        Me.nudYear.Name = "nudYear"
        Me.nudYear.Size = New System.Drawing.Size(112, 20)
        Me.nudYear.TabIndex = 5
        Me.tipCarInventory.SetToolTip(Me.nudYear, "Car year numeric up down")
        Me.nudYear.Value = New Decimal(New Integer() {2000, 0, 0, 0})
        '
        'lblOutput
        '
        Me.lblOutput.BackColor = System.Drawing.SystemColors.Control
        Me.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOutput.ForeColor = System.Drawing.Color.Black
        Me.lblOutput.Location = New System.Drawing.Point(33, 368)
        Me.lblOutput.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(556, 69)
        Me.lblOutput.TabIndex = 11
        Me.tipCarInventory.SetToolTip(Me.lblOutput, "Output's any errors encountered")
        '
        'frmCarViewer
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(607, 510)
        Me.Controls.Add(Me.nudYear)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.chkNew)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtModel)
        Me.Controls.Add(Me.lvwCars)
        Me.Controls.Add(Me.cmbMake)
        Me.Controls.Add(Me.lblNew)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.lblModel)
        Me.Controls.Add(Me.lblMake)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCarViewer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Car Viewer"
        CType(Me.nudYear, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnEnter As Button
    Friend WithEvents chkNew As CheckBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtModel As TextBox
    Friend WithEvents lvwCars As ListView
    Friend WithEvents colID As ColumnHeader
    Friend WithEvents colNew As ColumnHeader
    Friend WithEvents colMake As ColumnHeader
    Friend WithEvents colModel As ColumnHeader
    Friend WithEvents colYear As ColumnHeader
    Friend WithEvents colPrice As ColumnHeader
    Friend WithEvents cmbMake As ComboBox
    Friend WithEvents lblNew As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblYear As Label
    Friend WithEvents lblModel As Label
    Friend WithEvents lblMake As Label
    Friend WithEvents nudYear As NumericUpDown
    Friend WithEvents lblOutput As Label
    Friend WithEvents tipCarInventory As ToolTip
End Class
