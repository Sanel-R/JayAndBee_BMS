<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NewBooking
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.pbNotification = New System.Windows.Forms.PictureBox()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.pbNewbooking = New System.Windows.Forms.ProgressBar()
        Me.btnBooking = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.cmbBookingStatus = New System.Windows.Forms.ComboBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.rtbBookingConf = New System.Windows.Forms.RichTextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtNumberOfGuest = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cmbRoomType = New System.Windows.Forms.ComboBox()
        Me.mskArrivalDate = New System.Windows.Forms.MaskedTextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.mskDepartureDate = New System.Windows.Forms.MaskedTextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblGuestID = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbTitle = New System.Windows.Forms.ComboBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtEmailAddress = New System.Windows.Forms.TextBox()
        Me.mskPhoneNumber = New System.Windows.Forms.MaskedTextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Group26DataSet = New Login_Screen.group26DataSet()
        Me.GuestBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GuestTableAdapter = New Login_Screen.group26DataSetTableAdapters.GuestTableAdapter()
        Me.RoomTableAdapter1 = New Login_Screen.group26DataSetTableAdapters.RoomTableAdapter()
        Me.EmployeeTableAdapter1 = New Login_Screen.group26DataSetTableAdapters.EmployeeTableAdapter()
        Me.BookingTableAdapter1 = New Login_Screen.group26DataSetTableAdapters.BookingTableAdapter()
        Me.Panel2.SuspendLayout()
        CType(Me.pbNotification, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Group26DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GuestBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BackgroundImage = Global.Login_Screen.My.Resources.Resources._50_Beautiful_and_Minimalist_Presentation_Backgrounds_08
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.pbNotification)
        Me.Panel2.Controls.Add(Me.lblUser)
        Me.Panel2.Controls.Add(Me.PictureBox5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.PictureBox4)
        Me.Panel2.Controls.Add(Me.Label23)
        Me.Panel2.Controls.Add(Me.pbNewbooking)
        Me.Panel2.Controls.Add(Me.btnBooking)
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Location = New System.Drawing.Point(198, -1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(848, 567)
        Me.Panel2.TabIndex = 2
        '
        'pbNotification
        '
        Me.pbNotification.Image = Global.Login_Screen.My.Resources.Resources.bell_2
        Me.pbNotification.Location = New System.Drawing.Point(654, 15)
        Me.pbNotification.Name = "pbNotification"
        Me.pbNotification.Size = New System.Drawing.Size(26, 26)
        Me.pbNotification.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbNotification.TabIndex = 36
        Me.pbNotification.TabStop = False
        '
        'lblUser
        '
        Me.lblUser.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblUser.BackColor = System.Drawing.Color.Transparent
        Me.lblUser.Location = New System.Drawing.Point(714, 27)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblUser.Size = New System.Drawing.Size(60, 23)
        Me.lblUser.TabIndex = 35
        Me.lblUser.Text = "User Name"
        Me.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.Image = Global.Login_Screen.My.Resources.Resources.photo_512
        Me.PictureBox5.Location = New System.Drawing.Point(782, 7)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 32
        Me.PictureBox5.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(685, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 13)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "SIGNED IN AS"
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.Location = New System.Drawing.Point(1071, 309)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 31
        Me.PictureBox4.TabStop = False
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label23.Location = New System.Drawing.Point(243, 25)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(99, 16)
        Me.Label23.TabIndex = 9
        Me.Label23.Text = "Progress Bar"
        Me.Label23.Visible = False
        '
        'pbNewbooking
        '
        Me.pbNewbooking.Location = New System.Drawing.Point(348, 21)
        Me.pbNewbooking.Name = "pbNewbooking"
        Me.pbNewbooking.Size = New System.Drawing.Size(207, 20)
        Me.pbNewbooking.TabIndex = 8
        Me.pbNewbooking.Visible = False
        '
        'btnBooking
        '
        Me.btnBooking.Location = New System.Drawing.Point(366, 517)
        Me.btnBooking.Name = "btnBooking"
        Me.btnBooking.Size = New System.Drawing.Size(130, 40)
        Me.btnBooking.TabIndex = 7
        Me.btnBooking.Text = "Book"
        Me.btnBooking.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Panel5)
        Me.GroupBox1.Controls.Add(Me.Panel4)
        Me.GroupBox1.Controls.Add(Me.Panel3)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.lblTotal)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 59)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(818, 452)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.Controls.Add(Me.cmbBookingStatus)
        Me.Panel5.Controls.Add(Me.Label22)
        Me.Panel5.Controls.Add(Me.rtbBookingConf)
        Me.Panel5.Controls.Add(Me.Label21)
        Me.Panel5.Location = New System.Drawing.Point(451, 220)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(335, 155)
        Me.Panel5.TabIndex = 33
        '
        'cmbBookingStatus
        '
        Me.cmbBookingStatus.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Group26DataSet, "Booking.Booking_Status", True))
        Me.cmbBookingStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBookingStatus.FormattingEnabled = True
        Me.cmbBookingStatus.Items.AddRange(New Object() {"In Progress", "Complete"})
        Me.cmbBookingStatus.Location = New System.Drawing.Point(171, 20)
        Me.cmbBookingStatus.Name = "cmbBookingStatus"
        Me.cmbBookingStatus.Size = New System.Drawing.Size(126, 23)
        Me.cmbBookingStatus.TabIndex = 33
        Me.cmbBookingStatus.Text = "Select"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(24, 20)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(89, 15)
        Me.Label22.TabIndex = 32
        Me.Label22.Text = "Booking Status"
        '
        'rtbBookingConf
        '
        Me.rtbBookingConf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rtbBookingConf.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Group26DataSet, "Booking.Booking_confirmation", True))
        Me.rtbBookingConf.Location = New System.Drawing.Point(171, 48)
        Me.rtbBookingConf.Name = "rtbBookingConf"
        Me.rtbBookingConf.Size = New System.Drawing.Size(154, 82)
        Me.rtbBookingConf.TabIndex = 0
        Me.rtbBookingConf.Text = ""
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(24, 50)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(125, 15)
        Me.Label21.TabIndex = 31
        Me.Label21.Text = "Booking Confirmation"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Controls.Add(Me.Label14)
        Me.Panel4.Controls.Add(Me.Label13)
        Me.Panel4.Controls.Add(Me.txtNumberOfGuest)
        Me.Panel4.Controls.Add(Me.Label15)
        Me.Panel4.Controls.Add(Me.cmbRoomType)
        Me.Panel4.Controls.Add(Me.mskArrivalDate)
        Me.Panel4.Controls.Add(Me.Label17)
        Me.Panel4.Controls.Add(Me.mskDepartureDate)
        Me.Panel4.Location = New System.Drawing.Point(451, 44)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(335, 158)
        Me.Panel4.TabIndex = 32
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(24, 20)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(106, 15)
        Me.Label14.TabIndex = 24
        Me.Label14.Text = "Number of Guests"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(25, 50)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(69, 15)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "Arrival Date"
        '
        'txtNumberOfGuest
        '
        Me.txtNumberOfGuest.Location = New System.Drawing.Point(172, 19)
        Me.txtNumberOfGuest.Name = "txtNumberOfGuest"
        Me.txtNumberOfGuest.Size = New System.Drawing.Size(43, 20)
        Me.txtNumberOfGuest.TabIndex = 26
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(24, 80)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(91, 15)
        Me.Label15.TabIndex = 27
        Me.Label15.Text = "Departure Date"
        '
        'cmbRoomType
        '
        Me.cmbRoomType.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Group26DataSet, "Room.Room_type", True))
        Me.cmbRoomType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbRoomType.FormattingEnabled = True
        Me.cmbRoomType.Items.AddRange(New Object() {"Superior Quadruple Room", "Double Room", "Family Room", "Superior Queen", "Twin Room", "Superior King"})
        Me.cmbRoomType.Location = New System.Drawing.Point(172, 111)
        Me.cmbRoomType.Name = "cmbRoomType"
        Me.cmbRoomType.Size = New System.Drawing.Size(125, 23)
        Me.cmbRoomType.TabIndex = 31
        Me.cmbRoomType.Text = "Select"
        '
        'mskArrivalDate
        '
        Me.mskArrivalDate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Group26DataSet, "Booking.Arrival_date", True))
        Me.mskArrivalDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskArrivalDate.Location = New System.Drawing.Point(172, 49)
        Me.mskArrivalDate.Mask = "00/00/0000 90:00"
        Me.mskArrivalDate.Name = "mskArrivalDate"
        Me.mskArrivalDate.Size = New System.Drawing.Size(112, 21)
        Me.mskArrivalDate.TabIndex = 28
        Me.mskArrivalDate.ValidatingType = GetType(Date)
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(24, 112)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(70, 15)
        Me.Label17.TabIndex = 30
        Me.Label17.Text = "Room Type"
        '
        'mskDepartureDate
        '
        Me.mskDepartureDate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Group26DataSet, "Booking.Departure_date", True))
        Me.mskDepartureDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskDepartureDate.Location = New System.Drawing.Point(171, 79)
        Me.mskDepartureDate.Mask = "00/00/0000 90:00"
        Me.mskDepartureDate.Name = "mskDepartureDate"
        Me.mskDepartureDate.Size = New System.Drawing.Size(112, 21)
        Me.mskDepartureDate.TabIndex = 29
        Me.mskDepartureDate.ValidatingType = GetType(Date)
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.lblGuestID)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.cmbTitle)
        Me.Panel3.Controls.Add(Me.txtName)
        Me.Panel3.Controls.Add(Me.Label16)
        Me.Panel3.Controls.Add(Me.txtLastName)
        Me.Panel3.Controls.Add(Me.txtEmailAddress)
        Me.Panel3.Controls.Add(Me.mskPhoneNumber)
        Me.Panel3.Location = New System.Drawing.Point(24, 44)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(335, 214)
        Me.Panel3.TabIndex = 31
        '
        'lblGuestID
        '
        Me.lblGuestID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GuestBindingSource, "Guest_ID", True))
        Me.lblGuestID.Location = New System.Drawing.Point(169, 17)
        Me.lblGuestID.Name = "lblGuestID"
        Me.lblGuestID.Size = New System.Drawing.Size(61, 23)
        Me.lblGuestID.TabIndex = 39
        Me.lblGuestID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(23, 22)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 13)
        Me.Label10.TabIndex = 35
        Me.Label10.Text = "Guest ID"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(23, 82)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 13)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "First Name"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(23, 114)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 13)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Last Name"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(24, 146)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 13)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "Phone Number"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(24, 176)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 13)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "Email Address"
        '
        'cmbTitle
        '
        Me.cmbTitle.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GuestBindingSource, "Title", True))
        Me.cmbTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTitle.FormattingEnabled = True
        Me.cmbTitle.Items.AddRange(New Object() {"Mr", "Mrs", "Ms", "Dr", "Rev"})
        Me.cmbTitle.Location = New System.Drawing.Point(171, 47)
        Me.cmbTitle.Name = "cmbTitle"
        Me.cmbTitle.Size = New System.Drawing.Size(59, 23)
        Me.cmbTitle.TabIndex = 38
        '
        'txtName
        '
        Me.txtName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GuestBindingSource, "Name", True))
        Me.txtName.Location = New System.Drawing.Point(171, 79)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(141, 20)
        Me.txtName.TabIndex = 32
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(23, 52)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(27, 13)
        Me.Label16.TabIndex = 37
        Me.Label16.Text = "Title"
        '
        'txtLastName
        '
        Me.txtLastName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GuestBindingSource, "Surname", True))
        Me.txtLastName.Location = New System.Drawing.Point(171, 111)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(141, 20)
        Me.txtLastName.TabIndex = 33
        '
        'txtEmailAddress
        '
        Me.txtEmailAddress.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GuestBindingSource, "Email", True))
        Me.txtEmailAddress.Location = New System.Drawing.Point(171, 173)
        Me.txtEmailAddress.Name = "txtEmailAddress"
        Me.txtEmailAddress.Size = New System.Drawing.Size(141, 20)
        Me.txtEmailAddress.TabIndex = 34
        '
        'mskPhoneNumber
        '
        Me.mskPhoneNumber.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GuestBindingSource, "Phone_no", True))
        Me.mskPhoneNumber.Location = New System.Drawing.Point(171, 143)
        Me.mskPhoneNumber.Mask = "000-000-0000"
        Me.mskPhoneNumber.Name = "mskPhoneNumber"
        Me.mskPhoneNumber.Size = New System.Drawing.Size(80, 20)
        Me.mskPhoneNumber.TabIndex = 36
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(331, 404)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(91, 16)
        Me.Label19.TabIndex = 25
        Me.Label19.Text = "Amount Due"
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(428, 395)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(81, 35)
        Me.lblTotal.TabIndex = 24
        Me.lblTotal.Text = "R 2800"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblTotal.UseMnemonic = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label12.Location = New System.Drawing.Point(448, 16)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(145, 16)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Booking Information"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label11.Location = New System.Drawing.Point(21, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(150, 16)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Personal Information"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(11, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 16)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "NEW BOOKING"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.Login_Screen.My.Resources.Resources._50_Beautiful_and_Minimalist_Presentation_Backgrounds_08
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.btnLogout)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 567)
        Me.Panel1.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(35, 525)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 16)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Cleaning Service"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = Global.Login_Screen.My.Resources.Resources.clean
        Me.PictureBox3.Location = New System.Drawing.Point(14, 376)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(168, 146)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 39
        Me.PictureBox3.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(49, 357)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 16)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Room Status"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Login_Screen.My.Resources.Resources.update_room
        Me.PictureBox1.Location = New System.Drawing.Point(-1, 208)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(200, 146)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 37
        Me.PictureBox1.TabStop = False
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.Red
        Me.btnLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.Location = New System.Drawing.Point(-1, -1)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(200, 40)
        Me.btnLogout.TabIndex = 36
        Me.btnLogout.Text = "LOGOUT"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.Login_Screen.My.Resources.Resources.cal
        Me.PictureBox2.Location = New System.Drawing.Point(-1, 40)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(200, 146)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 32
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(41, 189)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 16)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "View Bookings"
        '
        'Group26DataSet
        '
        Me.Group26DataSet.DataSetName = "group26DataSet"
        Me.Group26DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GuestBindingSource
        '
        Me.GuestBindingSource.DataMember = "Guest"
        Me.GuestBindingSource.DataSource = Me.Group26DataSet
        '
        'GuestTableAdapter
        '
        Me.GuestTableAdapter.ClearBeforeFill = True
        '
        'RoomTableAdapter1
        '
        Me.RoomTableAdapter1.ClearBeforeFill = True
        '
        'EmployeeTableAdapter1
        '
        Me.EmployeeTableAdapter1.ClearBeforeFill = True
        '
        'BookingTableAdapter1
        '
        Me.BookingTableAdapter1.ClearBeforeFill = True
        '
        'NewBooking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1046, 567)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "NewBooking"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NewBooking"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.pbNotification, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Group26DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GuestBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnLogout As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label23 As Label
    Friend WithEvents pbNewbooking As ProgressBar
    Friend WithEvents btnBooking As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmbBookingStatus As ComboBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents rtbBookingConf As RichTextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtNumberOfGuest As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents cmbRoomType As ComboBox
    Friend WithEvents mskArrivalDate As MaskedTextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents mskDepartureDate As MaskedTextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblGuestID As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents cmbTitle As ComboBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtEmailAddress As TextBox
    Friend WithEvents mskPhoneNumber As MaskedTextBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents pbNotification As PictureBox
    Friend WithEvents lblUser As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Group26DataSet As group26DataSet
    Friend WithEvents GuestBindingSource As BindingSource
    Friend WithEvents GuestTableAdapter As group26DataSetTableAdapters.GuestTableAdapter
    Friend WithEvents RoomTableAdapter1 As group26DataSetTableAdapters.RoomTableAdapter
    Friend WithEvents EmployeeTableAdapter1 As group26DataSetTableAdapters.EmployeeTableAdapter
    Friend WithEvents BookingTableAdapter1 As group26DataSetTableAdapters.BookingTableAdapter
End Class
