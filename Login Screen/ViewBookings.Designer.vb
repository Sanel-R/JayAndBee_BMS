<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewBookings
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pbMealService = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.mnLogout = New System.Windows.Forms.MenuStrip()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pbViewBookings = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pbCleaningService = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.pbMealService, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnLogout.SuspendLayout()
        CType(Me.pbViewBookings, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCleaningService, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(42, 542)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 16)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Update Room"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.pbMealService)
        Me.SplitContainer1.Panel1.Controls.Add(Me.PictureBox2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.mnLogout)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.pbViewBookings)
        Me.SplitContainer1.Panel1.Controls.Add(Me.PictureBox1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.pbCleaningService)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Button1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.PictureBox3)
        Me.SplitContainer1.Size = New System.Drawing.Size(1046, 567)
        Me.SplitContainer1.SplitterDistance = 196
        Me.SplitContainer1.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(25, 418)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(143, 16)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Additional Services"
        '
        'pbMealService
        '
        Me.pbMealService.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbMealService.Image = Global.Login_Screen.My.Resources.Resources.additional_services
        Me.pbMealService.Location = New System.Drawing.Point(12, 313)
        Me.pbMealService.Name = "pbMealService"
        Me.pbMealService.Size = New System.Drawing.Size(178, 102)
        Me.pbMealService.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbMealService.TabIndex = 24
        Me.pbMealService.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Login_Screen.My.Resources.Resources.calander
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
        Me.Label2.Location = New System.Drawing.Point(42, 294)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 16)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Cleaning Service"
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
        Me.pbViewBookings.Image = Global.Login_Screen.My.Resources.Resources.calander
        Me.pbViewBookings.Location = New System.Drawing.Point(12, 65)
        Me.pbViewBookings.Name = "pbViewBookings"
        Me.pbViewBookings.Size = New System.Drawing.Size(0, 0)
        Me.pbViewBookings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbViewBookings.TabIndex = 14
        Me.pbViewBookings.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Login_Screen.My.Resources.Resources.Update
        Me.PictureBox1.Location = New System.Drawing.Point(12, 437)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(178, 102)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'pbCleaningService
        '
        Me.pbCleaningService.Image = Global.Login_Screen.My.Resources.Resources.cleaning_Image
        Me.pbCleaningService.Location = New System.Drawing.Point(12, 189)
        Me.pbCleaningService.Name = "pbCleaningService"
        Me.pbCleaningService.Size = New System.Drawing.Size(178, 102)
        Me.pbCleaningService.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbCleaningService.TabIndex = 15
        Me.pbCleaningService.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(351, 510)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(133, 45)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Add New Booking"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Login_Screen.My.Resources.Resources.hotel_calendar
        Me.PictureBox3.Location = New System.Drawing.Point(-1, 0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(844, 493)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 0
        Me.PictureBox3.TabStop = False
        '
        'ViewBookings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1046, 567)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "ViewBookings"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.pbMealService, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnLogout.ResumeLayout(False)
        Me.mnLogout.PerformLayout()
        CType(Me.pbViewBookings, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCleaningService, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pbMealService As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents pbViewBookings As System.Windows.Forms.PictureBox
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents mnLogout As System.Windows.Forms.MenuStrip
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents pbCleaningService As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
