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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UpdateEmployee))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.mnLogout = New System.Windows.Forms.MenuStrip()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pbViewBookings = New System.Windows.Forms.PictureBox()
        Me.GBSearch = New System.Windows.Forms.GroupBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.confirmPassTxt = New System.Windows.Forms.TextBox()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.EmployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Group26DataSet = New Login_Screen.group26DataSet()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.MBPhoneNo = New System.Windows.Forms.MaskedTextBox()
        Me.CBGender = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtPassWd = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
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
        Me.CBAction = New System.Windows.Forms.ComboBox()
        Me.EmployeeTableAdapter = New Login_Screen.group26DataSetTableAdapters.EmployeeTableAdapter()
        Me.FKBookingEmployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BookingTableAdapter = New Login_Screen.group26DataSetTableAdapters.BookingTableAdapter()
        Me.EmployeeBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterManager = New Login_Screen.group26DataSetTableAdapters.TableAdapterManager()
        Me.EmployeeBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnUpdateEmployee = New System.Windows.Forms.Button()
        Me.btnDeleteEmployee = New System.Windows.Forms.Button()
        Me.btnAddEmployee = New System.Windows.Forms.Button()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnLogout.SuspendLayout()
        CType(Me.pbViewBookings, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBSearch.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Group26DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FKBookingEmployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.PictureBox3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.PictureBox1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.PictureBox2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.mnLogout)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.pbViewBookings)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnUpdateEmployee)
        Me.SplitContainer1.Panel2.Controls.Add(Me.GBSearch)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnDeleteEmployee)
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnAddEmployee)
        Me.SplitContainer1.Panel2.Controls.Add(Me.CBAction)
        Me.SplitContainer1.Size = New System.Drawing.Size(1046, 567)
        Me.SplitContainer1.SplitterDistance = 196
        Me.SplitContainer1.TabIndex = 2
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(15, 369)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(178, 102)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 27
        Me.PictureBox3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 216)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(178, 102)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(67, 474)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 16)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Reports"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(15, 65)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(178, 102)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 23
        Me.PictureBox2.TabStop = False
        '
        'mnLogout
        '
        Me.mnLogout.AutoSize = False
        Me.mnLogout.Dock = System.Windows.Forms.DockStyle.None
        Me.mnLogout.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogoutToolStripMenuItem})
        Me.mnLogout.Location = New System.Drawing.Point(12, 9)
        Me.mnLogout.Name = "mnLogout"
        Me.mnLogout.Size = New System.Drawing.Size(178, 24)
        Me.mnLogout.TabIndex = 22
        Me.mnLogout.Text = "Logout"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(35, 321)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 16)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Update Employee"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(47, 170)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 16)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "View Bookings"
        '
        'pbViewBookings
        '
        Me.pbViewBookings.Image = CType(resources.GetObject("pbViewBookings.Image"), System.Drawing.Image)
        Me.pbViewBookings.Location = New System.Drawing.Point(12, 65)
        Me.pbViewBookings.Name = "pbViewBookings"
        Me.pbViewBookings.Size = New System.Drawing.Size(0, 0)
        Me.pbViewBookings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbViewBookings.TabIndex = 14
        Me.pbViewBookings.TabStop = False
        '
        'GBSearch
        '
        Me.GBSearch.Controls.Add(Me.btnSearch)
        Me.GBSearch.Controls.Add(Me.Label5)
        Me.GBSearch.Controls.Add(Me.TextBox1)
        Me.GBSearch.Location = New System.Drawing.Point(451, 12)
        Me.GBSearch.Name = "GBSearch"
        Me.GBSearch.Size = New System.Drawing.Size(366, 45)
        Me.GBSearch.TabIndex = 6
        Me.GBSearch.TabStop = False
        Me.GBSearch.Visible = False
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(268, 14)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 6
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Employee ID"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(90, 15)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(160, 20)
        Me.TextBox1.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.confirmPassTxt)
        Me.GroupBox1.Controls.Add(Me.txtUserName)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.MBPhoneNo)
        Me.GroupBox1.Controls.Add(Me.CBGender)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.txtPassWd)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtAddress)
        Me.GroupBox1.Controls.Add(Me.txtEmail)
        Me.GroupBox1.Controls.Add(Me.txtLName)
        Me.GroupBox1.Controls.Add(Me.txtFName)
        Me.GroupBox1.Controls.Add(Me.txtOccupType)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtEmpID)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 65)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(799, 436)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(412, 303)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(0, 13)
        Me.Label16.TabIndex = 24
        '
        'confirmPassTxt
        '
        Me.confirmPassTxt.Location = New System.Drawing.Point(245, 303)
        Me.confirmPassTxt.Name = "confirmPassTxt"
        Me.confirmPassTxt.Size = New System.Drawing.Size(160, 20)
        Me.confirmPassTxt.TabIndex = 12
        '
        'txtUserName
        '
        Me.txtUserName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "User_name", True))
        Me.txtUserName.Location = New System.Drawing.Point(245, 240)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(160, 20)
        Me.txtUserName.TabIndex = 10
        '
        'EmployeeBindingSource
        '
        Me.EmployeeBindingSource.DataMember = "Employee"
        Me.EmployeeBindingSource.DataSource = Me.Group26DataSet
        '
        'Group26DataSet
        '
        Me.Group26DataSet.DataSetName = "group26DataSet"
        Me.Group26DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(31, 243)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 13)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "User Name"
        '
        'MBPhoneNo
        '
        Me.MBPhoneNo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "Phone_no", True))
        Me.MBPhoneNo.Location = New System.Drawing.Point(245, 180)
        Me.MBPhoneNo.Mask = "000-000-0000"
        Me.MBPhoneNo.Name = "MBPhoneNo"
        Me.MBPhoneNo.Size = New System.Drawing.Size(82, 20)
        Me.MBPhoneNo.TabIndex = 8
        '
        'CBGender
        '
        Me.CBGender.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "Gender", True))
        Me.CBGender.FormattingEnabled = True
        Me.CBGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.CBGender.Location = New System.Drawing.Point(245, 148)
        Me.CBGender.Name = "CBGender"
        Me.CBGender.Size = New System.Drawing.Size(121, 21)
        Me.CBGender.TabIndex = 7
        Me.CBGender.Text = "Select"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(31, 151)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(42, 13)
        Me.Label15.TabIndex = 20
        Me.Label15.Text = "Gender"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(31, 303)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(91, 13)
        Me.Label14.TabIndex = 18
        Me.Label14.Text = "Confirm Password"
        '
        'txtPassWd
        '
        Me.txtPassWd.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "Password", True))
        Me.txtPassWd.Location = New System.Drawing.Point(245, 273)
        Me.txtPassWd.Name = "txtPassWd"
        Me.txtPassWd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassWd.Size = New System.Drawing.Size(160, 20)
        Me.txtPassWd.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 276)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Password"
        '
        'txtAddress
        '
        Me.txtAddress.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "Physical_address", True))
        Me.txtAddress.Location = New System.Drawing.Point(245, 333)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(241, 91)
        Me.txtAddress.TabIndex = 13
        '
        'txtEmail
        '
        Me.txtEmail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "Email_address", True))
        Me.txtEmail.Location = New System.Drawing.Point(245, 209)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(160, 20)
        Me.txtEmail.TabIndex = 9
        '
        'txtLName
        '
        Me.txtLName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "Surname", True))
        Me.txtLName.Location = New System.Drawing.Point(245, 116)
        Me.txtLName.Name = "txtLName"
        Me.txtLName.Size = New System.Drawing.Size(160, 20)
        Me.txtLName.TabIndex = 6
        '
        'txtFName
        '
        Me.txtFName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "Name", True))
        Me.txtFName.Location = New System.Drawing.Point(245, 83)
        Me.txtFName.Name = "txtFName"
        Me.txtFName.Size = New System.Drawing.Size(160, 20)
        Me.txtFName.TabIndex = 5
        '
        'txtOccupType
        '
        Me.txtOccupType.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "Occupation_type", True))
        Me.txtOccupType.Location = New System.Drawing.Point(245, 54)
        Me.txtOccupType.Name = "txtOccupType"
        Me.txtOccupType.Size = New System.Drawing.Size(160, 20)
        Me.txtOccupType.TabIndex = 4
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(31, 212)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(32, 13)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "Email"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(31, 57)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(89, 13)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "Occupation Type"
        '
        'txtEmpID
        '
        Me.txtEmpID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEmpID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "Employee_ID", True))
        Me.txtEmpID.Location = New System.Drawing.Point(245, 25)
        Me.txtEmpID.Name = "txtEmpID"
        Me.txtEmpID.Size = New System.Drawing.Size(160, 13)
        Me.txtEmpID.TabIndex = 3
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(31, 336)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(87, 13)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Physical Address"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(31, 28)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 13)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Employee ID"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(31, 183)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Phone Number"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(31, 119)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Surname"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(29, 86)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Name"
        '
        'CBAction
        '
        Me.CBAction.AutoCompleteCustomSource.AddRange(New String() {"Add New Employee", "Update Employee"})
        Me.CBAction.FormattingEnabled = True
        Me.CBAction.Items.AddRange(New Object() {"Add New Employee", "Update Employee ", "Remove Employee"})
        Me.CBAction.Location = New System.Drawing.Point(18, 26)
        Me.CBAction.Name = "CBAction"
        Me.CBAction.Size = New System.Drawing.Size(140, 21)
        Me.CBAction.TabIndex = 1
        Me.CBAction.Text = "Select Action"
        '
        'EmployeeTableAdapter
        '
        Me.EmployeeTableAdapter.ClearBeforeFill = True
        '
        'FKBookingEmployeeBindingSource
        '
        Me.FKBookingEmployeeBindingSource.DataMember = "FK_Booking_Employee"
        Me.FKBookingEmployeeBindingSource.DataSource = Me.EmployeeBindingSource
        '
        'BookingTableAdapter
        '
        Me.BookingTableAdapter.ClearBeforeFill = True
        '
        'EmployeeBindingSource1
        '
        Me.EmployeeBindingSource1.DataMember = "Employee"
        Me.EmployeeBindingSource1.DataSource = Me.Group26DataSet
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.Additional_ServiceTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BookingTableAdapter = Me.BookingTableAdapter
        Me.TableAdapterManager.EmployeeTableAdapter = Me.EmployeeTableAdapter
        Me.TableAdapterManager.GuestTableAdapter = Nothing
        Me.TableAdapterManager.PaymentTableAdapter = Nothing
        Me.TableAdapterManager.RoomTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Login_Screen.group26DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'EmployeeBindingSource2
        '
        Me.EmployeeBindingSource2.DataMember = "Employee"
        Me.EmployeeBindingSource2.DataSource = Me.Group26DataSet
        '
        'btnUpdateEmployee
        '
        Me.btnUpdateEmployee.Location = New System.Drawing.Point(357, 517)
        Me.btnUpdateEmployee.Name = "btnUpdateEmployee"
        Me.btnUpdateEmployee.Size = New System.Drawing.Size(120, 38)
        Me.btnUpdateEmployee.TabIndex = 26
        Me.btnUpdateEmployee.Text = "Update Employee"
        Me.btnUpdateEmployee.UseVisualStyleBackColor = True
        '
        'btnDeleteEmployee
        '
        Me.btnDeleteEmployee.Location = New System.Drawing.Point(537, 517)
        Me.btnDeleteEmployee.Name = "btnDeleteEmployee"
        Me.btnDeleteEmployee.Size = New System.Drawing.Size(120, 38)
        Me.btnDeleteEmployee.TabIndex = 27
        Me.btnDeleteEmployee.Text = "Delete Employee"
        Me.btnDeleteEmployee.UseVisualStyleBackColor = True
        '
        'btnAddEmployee
        '
        Me.btnAddEmployee.Location = New System.Drawing.Point(186, 517)
        Me.btnAddEmployee.Name = "btnAddEmployee"
        Me.btnAddEmployee.Size = New System.Drawing.Size(120, 38)
        Me.btnAddEmployee.TabIndex = 25
        Me.btnAddEmployee.Text = "Add Employee"
        Me.btnAddEmployee.UseVisualStyleBackColor = True
        '
        'UpdateEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1046, 567)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "UpdateEmployee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Update Employee"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnLogout.ResumeLayout(False)
        Me.mnLogout.PerformLayout()
        CType(Me.pbViewBookings, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBSearch.ResumeLayout(False)
        Me.GBSearch.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Group26DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FKBookingEmployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pbViewBookings As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents CBAction As System.Windows.Forms.ComboBox
    Friend WithEvents txtEmpID As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtLName As System.Windows.Forms.TextBox
    Friend WithEvents txtFName As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtPassWd As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents MBPhoneNo As System.Windows.Forms.MaskedTextBox
    Friend WithEvents CBGender As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents mnLogout As MenuStrip
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Group26DataSet As group26DataSet
    Friend WithEvents EmployeeBindingSource As BindingSource
    Friend WithEvents EmployeeTableAdapter As group26DataSetTableAdapters.EmployeeTableAdapter
    Friend WithEvents txtUserName As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents confirmPassTxt As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtOccupType As TextBox
    Friend WithEvents FKBookingEmployeeBindingSource As BindingSource
    Friend WithEvents BookingTableAdapter As group26DataSetTableAdapters.BookingTableAdapter
    Friend WithEvents EmployeeBindingSource1 As BindingSource
    Friend WithEvents EmployeeBindingSource2 As BindingSource
    Friend WithEvents TableAdapterManager As group26DataSetTableAdapters.TableAdapterManager
    Friend WithEvents GBSearch As GroupBox
    Friend WithEvents btnUpdateEmployee As Button
    Friend WithEvents btnDeleteEmployee As Button
    Friend WithEvents btnAddEmployee As Button
End Class
