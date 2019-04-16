<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Meal_Service
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.mnLogout = New System.Windows.Forms.MenuStrip()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.pbViewBookings = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pbCleaningService = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pbMealService = New System.Windows.Forms.PictureBox()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.mnLogout.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbViewBookings, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCleaningService, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbMealService, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.PictureBox2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.pbMealService)
        Me.SplitContainer1.Panel1.Controls.Add(Me.mnLogout)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.pbViewBookings)
        Me.SplitContainer1.Panel1.Controls.Add(Me.PictureBox1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.pbCleaningService)
        Me.SplitContainer1.Size = New System.Drawing.Size(1046, 567)
        Me.SplitContainer1.SplitterDistance = 196
        Me.SplitContainer1.TabIndex = 2
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(28, 418)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(143, 16)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Additional Services"
        '
        'pbMealService
        '
        Me.pbMealService.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbMealService.Image = Global.Login_Screen.My.Resources.Resources.additional_services
        Me.pbMealService.Location = New System.Drawing.Point(15, 313)
        Me.pbMealService.Name = "pbMealService"
        Me.pbMealService.Size = New System.Drawing.Size(178, 102)
        Me.pbMealService.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbMealService.TabIndex = 21
        Me.pbMealService.TabStop = False
        '
        'Meal_Service
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1046, 567)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "Meal_Service"
        Me.Text = "Meal_Service"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.mnLogout.ResumeLayout(False)
        Me.mnLogout.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbViewBookings, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCleaningService, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbMealService, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents mnLogout As System.Windows.Forms.MenuStrip
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pbViewBookings As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents pbCleaningService As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents pbMealService As System.Windows.Forms.PictureBox
End Class
