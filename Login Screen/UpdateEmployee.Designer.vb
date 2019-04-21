<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UpdateEmployee
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UpdateEmployee))
        Me.Group26DataSet1 = New Login_Screen.group26DataSet()
        Me.EmployeeTableAdapter1 = New Login_Screen.group26DataSetTableAdapters.EmployeeTableAdapter()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.lblCheckMark1 = New System.Windows.Forms.Panel()
        Me.checkmark2 = New System.Windows.Forms.PictureBox()
        Me.checkmark1 = New System.Windows.Forms.PictureBox()
        Me.CBStatus = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.confirmPassTxt = New System.Windows.Forms.TextBox()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.MBPhoneNo = New System.Windows.Forms.MaskedTextBox()
        Me.CBGender = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblConfirmPassWd = New System.Windows.Forms.Label()
        Me.txtPassWd = New System.Windows.Forms.TextBox()
        Me.lblPasswd = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtLName = New System.Windows.Forms.TextBox()
        Me.txtFName = New System.Windows.Forms.TextBox()
        Me.txtOccupType = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtEmpID = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnUpdateEmployee = New System.Windows.Forms.Button()
        Me.GBSearch = New System.Windows.Forms.GroupBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtEmpIDSearch = New System.Windows.Forms.TextBox()
        Me.btnDeleteEmployee = New System.Windows.Forms.Button()
        Me.btnAddEmployee = New System.Windows.Forms.Button()
        Me.CBAction = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.Group26DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lblCheckMark1.SuspendLayout()
        CType(Me.checkmark2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.checkmark1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBSearch.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Group26DataSet1
        '
        Me.Group26DataSet1.DataSetName = "group26DataSet"
        Me.Group26DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmployeeTableAdapter1
        '
        Me.EmployeeTableAdapter1.ClearBeforeFill = True
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = Global.Login_Screen.My.Resources.Resources._50_Beautiful_and_Minimalist_Presentation_Backgrounds_08
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.lblUser)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.PictureBox4)
        Me.Panel2.Controls.Add(Me.lblCheckMark1)
        Me.Panel2.Controls.Add(Me.btnUpdateEmployee)
        Me.Panel2.Controls.Add(Me.GBSearch)
        Me.Panel2.Controls.Add(Me.btnDeleteEmployee)
        Me.Panel2.Controls.Add(Me.btnAddEmployee)
        Me.Panel2.Controls.Add(Me.CBAction)
        Me.Panel2.Location = New System.Drawing.Point(200, 1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(848, 567)
        Me.Panel2.TabIndex = 0
        '
        'lblUser
        '
        Me.lblUser.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblUser.BackColor = System.Drawing.Color.Transparent
        Me.lblUser.Location = New System.Drawing.Point(707, 28)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblUser.Size = New System.Drawing.Size(60, 23)
        Me.lblUser.TabIndex = 39
        Me.lblUser.Text = "Label17"
        Me.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(678, 16)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(91, 13)
        Me.Label14.TabIndex = 38
        Me.Label14.Text = "SIGNED IN AS"
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.BackgroundImage = Global.Login_Screen.My.Resources.Resources.photo_5121
        Me.PictureBox4.Image = Global.Login_Screen.My.Resources.Resources.photo_5122
        Me.PictureBox4.Location = New System.Drawing.Point(775, 9)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 37
        Me.PictureBox4.TabStop = False
        '
        'lblCheckMark1
        '
        Me.lblCheckMark1.BackColor = System.Drawing.Color.White
        Me.lblCheckMark1.Controls.Add(Me.checkmark2)
        Me.lblCheckMark1.Controls.Add(Me.checkmark1)
        Me.lblCheckMark1.Controls.Add(Me.CBStatus)
        Me.lblCheckMark1.Controls.Add(Me.Label4)
        Me.lblCheckMark1.Controls.Add(Me.Label16)
        Me.lblCheckMark1.Controls.Add(Me.confirmPassTxt)
        Me.lblCheckMark1.Controls.Add(Me.txtUserName)
        Me.lblCheckMark1.Controls.Add(Me.Label6)
        Me.lblCheckMark1.Controls.Add(Me.MBPhoneNo)
        Me.lblCheckMark1.Controls.Add(Me.CBGender)
        Me.lblCheckMark1.Controls.Add(Me.Label15)
        Me.lblCheckMark1.Controls.Add(Me.lblConfirmPassWd)
        Me.lblCheckMark1.Controls.Add(Me.txtPassWd)
        Me.lblCheckMark1.Controls.Add(Me.lblPasswd)
        Me.lblCheckMark1.Controls.Add(Me.txtAddress)
        Me.lblCheckMark1.Controls.Add(Me.txtEmail)
        Me.lblCheckMark1.Controls.Add(Me.txtLName)
        Me.lblCheckMark1.Controls.Add(Me.txtFName)
        Me.lblCheckMark1.Controls.Add(Me.txtOccupType)
        Me.lblCheckMark1.Controls.Add(Me.Label13)
        Me.lblCheckMark1.Controls.Add(Me.Label12)
        Me.lblCheckMark1.Controls.Add(Me.txtEmpID)
        Me.lblCheckMark1.Controls.Add(Me.Label11)
        Me.lblCheckMark1.Controls.Add(Me.Label10)
        Me.lblCheckMark1.Controls.Add(Me.Label9)
        Me.lblCheckMark1.Controls.Add(Me.Label8)
        Me.lblCheckMark1.Controls.Add(Me.Label7)
        Me.lblCheckMark1.Location = New System.Drawing.Point(24, 67)
        Me.lblCheckMark1.Name = "lblCheckMark1"
        Me.lblCheckMark1.Size = New System.Drawing.Size(799, 446)
        Me.lblCheckMark1.TabIndex = 31
        '
        'checkmark2
        '
        Me.checkmark2.Location = New System.Drawing.Point(358, 323)
        Me.checkmark2.Name = "checkmark2"
        Me.checkmark2.Size = New System.Drawing.Size(12, 12)
        Me.checkmark2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.checkmark2.TabIndex = 55
        Me.checkmark2.TabStop = False
        Me.checkmark2.Visible = False
        Me.checkmark2.WaitOnLoad = True
        '
        'checkmark1
        '
        Me.checkmark1.Location = New System.Drawing.Point(358, 293)
        Me.checkmark1.Name = "checkmark1"
        Me.checkmark1.Size = New System.Drawing.Size(12, 12)
        Me.checkmark1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.checkmark1.TabIndex = 54
        Me.checkmark1.TabStop = False
        Me.checkmark1.Visible = False
        Me.checkmark1.WaitOnLoad = True
        '
        'CBStatus
        '
        Me.CBStatus.BackColor = System.Drawing.Color.White
        Me.CBStatus.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Group26DataSet1, "Employee.Employee_status", True))
        Me.CBStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBStatus.FormattingEnabled = True
        Me.CBStatus.Items.AddRange(New Object() {"Fully Employed", "Employment Terminated"})
        Me.CBStatus.Location = New System.Drawing.Point(196, 167)
        Me.CBStatus.Name = "CBStatus"
        Me.CBStatus.Size = New System.Drawing.Size(121, 21)
        Me.CBStatus.TabIndex = 50
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 167)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 13)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "Employment Status"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(363, 319)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(0, 13)
        Me.Label16.TabIndex = 49
        '
        'confirmPassTxt
        '
        Me.confirmPassTxt.Location = New System.Drawing.Point(196, 319)
        Me.confirmPassTxt.Name = "confirmPassTxt"
        Me.confirmPassTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.confirmPassTxt.Size = New System.Drawing.Size(160, 20)
        Me.confirmPassTxt.TabIndex = 43
        '
        'txtUserName
        '
        Me.txtUserName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Group26DataSet1, "Employee.User_name", True))
        Me.txtUserName.Location = New System.Drawing.Point(196, 256)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(160, 20)
        Me.txtUserName.TabIndex = 41
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(19, 256)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = "Username"
        '
        'MBPhoneNo
        '
        Me.MBPhoneNo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Group26DataSet1, "Employee.Phone_no", True))
        Me.MBPhoneNo.Location = New System.Drawing.Point(196, 196)
        Me.MBPhoneNo.Mask = "000-000-0000"
        Me.MBPhoneNo.Name = "MBPhoneNo"
        Me.MBPhoneNo.Size = New System.Drawing.Size(82, 20)
        Me.MBPhoneNo.TabIndex = 39
        '
        'CBGender
        '
        Me.CBGender.BackColor = System.Drawing.Color.White
        Me.CBGender.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Group26DataSet1, "Employee.Gender", True))
        Me.CBGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBGender.FormattingEnabled = True
        Me.CBGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.CBGender.Location = New System.Drawing.Point(196, 138)
        Me.CBGender.Name = "CBGender"
        Me.CBGender.Size = New System.Drawing.Size(121, 21)
        Me.CBGender.TabIndex = 38
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(19, 138)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(42, 13)
        Me.Label15.TabIndex = 47
        Me.Label15.Text = "Gender"
        '
        'lblConfirmPassWd
        '
        Me.lblConfirmPassWd.AutoSize = True
        Me.lblConfirmPassWd.Location = New System.Drawing.Point(19, 316)
        Me.lblConfirmPassWd.Name = "lblConfirmPassWd"
        Me.lblConfirmPassWd.Size = New System.Drawing.Size(91, 13)
        Me.lblConfirmPassWd.TabIndex = 46
        Me.lblConfirmPassWd.Text = "Confirm Password"
        '
        'txtPassWd
        '
        Me.txtPassWd.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Group26DataSet1, "Employee.Password", True))
        Me.txtPassWd.Location = New System.Drawing.Point(196, 289)
        Me.txtPassWd.Name = "txtPassWd"
        Me.txtPassWd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassWd.Size = New System.Drawing.Size(160, 20)
        Me.txtPassWd.TabIndex = 42
        '
        'lblPasswd
        '
        Me.lblPasswd.AutoSize = True
        Me.lblPasswd.Location = New System.Drawing.Point(19, 289)
        Me.lblPasswd.Name = "lblPasswd"
        Me.lblPasswd.Size = New System.Drawing.Size(53, 13)
        Me.lblPasswd.TabIndex = 45
        Me.lblPasswd.Text = "Password"
        '
        'txtAddress
        '
        Me.txtAddress.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Group26DataSet1, "Employee.Physical_address", True))
        Me.txtAddress.Location = New System.Drawing.Point(196, 349)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(241, 91)
        Me.txtAddress.TabIndex = 44
        '
        'txtEmail
        '
        Me.txtEmail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Group26DataSet1, "Employee.Email_address", True))
        Me.txtEmail.HideSelection = False
        Me.txtEmail.Location = New System.Drawing.Point(196, 225)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(160, 20)
        Me.txtEmail.TabIndex = 40
        '
        'txtLName
        '
        Me.txtLName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Group26DataSet1, "Employee.Surname", True))
        Me.txtLName.Location = New System.Drawing.Point(196, 106)
        Me.txtLName.Name = "txtLName"
        Me.txtLName.Size = New System.Drawing.Size(160, 20)
        Me.txtLName.TabIndex = 37
        '
        'txtFName
        '
        Me.txtFName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Group26DataSet1, "Employee.Name", True))
        Me.txtFName.Location = New System.Drawing.Point(196, 73)
        Me.txtFName.Name = "txtFName"
        Me.txtFName.Size = New System.Drawing.Size(160, 20)
        Me.txtFName.TabIndex = 34
        '
        'txtOccupType
        '
        Me.txtOccupType.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Group26DataSet1, "Employee.Occupation_type", True))
        Me.txtOccupType.Location = New System.Drawing.Point(196, 44)
        Me.txtOccupType.Name = "txtOccupType"
        Me.txtOccupType.Size = New System.Drawing.Size(160, 20)
        Me.txtOccupType.TabIndex = 33
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(19, 225)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(32, 13)
        Me.Label13.TabIndex = 36
        Me.Label13.Text = "Email"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(19, 44)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(89, 13)
        Me.Label12.TabIndex = 35
        Me.Label12.Text = "Occupation Type"
        '
        'txtEmpID
        '
        Me.txtEmpID.BackColor = System.Drawing.Color.White
        Me.txtEmpID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEmpID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Group26DataSet1, "Employee.Employee_ID", True))
        Me.txtEmpID.Location = New System.Drawing.Point(196, 15)
        Me.txtEmpID.Name = "txtEmpID"
        Me.txtEmpID.ReadOnly = True
        Me.txtEmpID.Size = New System.Drawing.Size(160, 13)
        Me.txtEmpID.TabIndex = 30
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(19, 349)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(87, 13)
        Me.Label11.TabIndex = 32
        Me.Label11.Text = "Physical Address"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(19, 15)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 13)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "Employee ID"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(19, 196)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 13)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Phone Number"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(19, 106)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 13)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Surname"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(19, 73)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Name"
        '
        'btnUpdateEmployee
        '
        Me.btnUpdateEmployee.Location = New System.Drawing.Point(370, 519)
        Me.btnUpdateEmployee.Name = "btnUpdateEmployee"
        Me.btnUpdateEmployee.Size = New System.Drawing.Size(120, 38)
        Me.btnUpdateEmployee.TabIndex = 35
        Me.btnUpdateEmployee.Text = "Update Employee"
        Me.btnUpdateEmployee.UseVisualStyleBackColor = True
        '
        'GBSearch
        '
        Me.GBSearch.BackColor = System.Drawing.Color.Transparent
        Me.GBSearch.Controls.Add(Me.btnSearch)
        Me.GBSearch.Controls.Add(Me.Label5)
        Me.GBSearch.Controls.Add(Me.txtEmpIDSearch)
        Me.GBSearch.Location = New System.Drawing.Point(239, 14)
        Me.GBSearch.Name = "GBSearch"
        Me.GBSearch.Size = New System.Drawing.Size(351, 45)
        Me.GBSearch.TabIndex = 33
        Me.GBSearch.TabStop = False
        Me.GBSearch.Visible = False
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(257, 13)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 6
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Employee ID"
        '
        'txtEmpIDSearch
        '
        Me.txtEmpIDSearch.Location = New System.Drawing.Point(79, 14)
        Me.txtEmpIDSearch.Name = "txtEmpIDSearch"
        Me.txtEmpIDSearch.Size = New System.Drawing.Size(160, 20)
        Me.txtEmpIDSearch.TabIndex = 2
        '
        'btnDeleteEmployee
        '
        Me.btnDeleteEmployee.Location = New System.Drawing.Point(529, 519)
        Me.btnDeleteEmployee.Name = "btnDeleteEmployee"
        Me.btnDeleteEmployee.Size = New System.Drawing.Size(120, 38)
        Me.btnDeleteEmployee.TabIndex = 36
        Me.btnDeleteEmployee.Text = "Archive Employee"
        Me.btnDeleteEmployee.UseVisualStyleBackColor = True
        '
        'btnAddEmployee
        '
        Me.btnAddEmployee.Location = New System.Drawing.Point(214, 519)
        Me.btnAddEmployee.Name = "btnAddEmployee"
        Me.btnAddEmployee.Size = New System.Drawing.Size(120, 38)
        Me.btnAddEmployee.TabIndex = 34
        Me.btnAddEmployee.Text = "Add Employee"
        Me.btnAddEmployee.UseVisualStyleBackColor = True
        '
        'CBAction
        '
        Me.CBAction.AutoCompleteCustomSource.AddRange(New String() {"Add New Employee", "Update Employee"})
        Me.CBAction.BackColor = System.Drawing.Color.White
        Me.CBAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBAction.FormattingEnabled = True
        Me.CBAction.Items.AddRange(New Object() {"Add New Employee", "Update Employee", "Archive Employee"})
        Me.CBAction.Location = New System.Drawing.Point(24, 28)
        Me.CBAction.Name = "CBAction"
        Me.CBAction.Size = New System.Drawing.Size(140, 21)
        Me.CBAction.TabIndex = 32
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.Login_Screen.My.Resources.Resources._50_Beautiful_and_Minimalist_Presentation_Backgrounds_08
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnLogout)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(2, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 567)
        Me.Panel1.TabIndex = 0
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.Red
        Me.btnLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.Location = New System.Drawing.Point(-2, -1)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(199, 41)
        Me.btnLogout.TabIndex = 36
        Me.btnLogout.Text = "LOGOUT"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = Global.Login_Screen.My.Resources.Resources.report__2_
        Me.PictureBox3.Location = New System.Drawing.Point(-1, 391)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(199, 156)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 35
        Me.PictureBox3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Login_Screen.My.Resources.Resources.employee_update
        Me.PictureBox1.Location = New System.Drawing.Point(-1, 209)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(200, 156)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 34
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(66, 550)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 16)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Reports"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.Login_Screen.My.Resources.Resources.cal1
        Me.PictureBox2.Location = New System.Drawing.Point(-1, 41)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(200, 146)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 32
        Me.PictureBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(32, 368)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 16)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Update Employee"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(42, 190)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 16)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "View Bookings"
        '
        'UpdateEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(1046, 567)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "UpdateEmployee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Jay and Bee - Management | Update Employee"
        CType(Me.Group26DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lblCheckMark1.ResumeLayout(False)
        Me.lblCheckMark1.PerformLayout()
        CType(Me.checkmark2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.checkmark1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBSearch.ResumeLayout(False)
        Me.GBSearch.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnLogout As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblUser As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents lblCheckMark1 As Panel
    Friend WithEvents CBStatus As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents confirmPassTxt As TextBox
    Friend WithEvents txtUserName As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents MBPhoneNo As MaskedTextBox
    Friend WithEvents CBGender As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents lblConfirmPassWd As Label
    Friend WithEvents txtPassWd As TextBox
    Friend WithEvents lblPasswd As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtLName As TextBox
    Friend WithEvents txtFName As TextBox
    Friend WithEvents txtOccupType As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtEmpID As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnUpdateEmployee As Button
    Friend WithEvents GBSearch As GroupBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtEmpIDSearch As TextBox
    Friend WithEvents btnDeleteEmployee As Button
    Friend WithEvents btnAddEmployee As Button
    Friend WithEvents CBAction As ComboBox
    Friend WithEvents Group26DataSet1 As group26DataSet
    Friend WithEvents EmployeeTableAdapter1 As group26DataSetTableAdapters.EmployeeTableAdapter
    Friend WithEvents checkmark2 As PictureBox
    Friend WithEvents checkmark1 As PictureBox
End Class
