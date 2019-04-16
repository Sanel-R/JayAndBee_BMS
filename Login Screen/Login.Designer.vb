<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.cbOccupation = New System.Windows.Forms.ComboBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblLogin = New System.Windows.Forms.Label()
        Me.lblUserType = New System.Windows.Forms.Label()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lnkForget_Password = New System.Windows.Forms.LinkLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbOccupation
        '
        Me.cbOccupation.FormattingEnabled = True
        Me.cbOccupation.Items.AddRange(New Object() {"Employee", "Manager"})
        Me.cbOccupation.Location = New System.Drawing.Point(229, 233)
        Me.cbOccupation.Name = "cbOccupation"
        Me.cbOccupation.Size = New System.Drawing.Size(173, 21)
        Me.cbOccupation.TabIndex = 0
        Me.cbOccupation.Text = "Select Occupation"
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(229, 275)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(173, 20)
        Me.txtUsername.TabIndex = 1
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(229, 317)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(173, 20)
        Me.txtPassword.TabIndex = 2
        Me.txtPassword.Tag = ""
        '
        'lblLogin
        '
        Me.lblLogin.Font = New System.Drawing.Font("Modern No. 20", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogin.Location = New System.Drawing.Point(151, 172)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(230, 36)
        Me.lblLogin.TabIndex = 3
        Me.lblLogin.Text = "User Login"
        Me.lblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblUserType
        '
        Me.lblUserType.Location = New System.Drawing.Point(123, 236)
        Me.lblUserType.Name = "lblUserType"
        Me.lblUserType.Size = New System.Drawing.Size(100, 21)
        Me.lblUserType.TabIndex = 4
        Me.lblUserType.Text = "User Type"
        '
        'lblUserName
        '
        Me.lblUserName.Location = New System.Drawing.Point(123, 278)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(73, 21)
        Me.lblUserName.TabIndex = 5
        Me.lblUserName.Text = "ID"
        '
        'lblPassword
        '
        Me.lblPassword.Location = New System.Drawing.Point(123, 320)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(63, 21)
        Me.lblPassword.TabIndex = 6
        Me.lblPassword.Text = "Password"
        '
        'lnkForget_Password
        '
        Me.lnkForget_Password.AutoSize = True
        Me.lnkForget_Password.Location = New System.Drawing.Point(123, 341)
        Me.lnkForget_Password.Name = "lnkForget_Password"
        Me.lnkForget_Password.Size = New System.Drawing.Size(91, 13)
        Me.lnkForget_Password.TabIndex = 7
        Me.lnkForget_Password.TabStop = True
        Me.lnkForget_Password.Text = "Forget password?"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Login_Screen.My.Resources.Resources.logo_jay_and_bee
        Me.PictureBox1.Location = New System.Drawing.Point(115, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(293, 138)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(220, 364)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 29)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Login"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(556, 405)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lnkForget_Password)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblUserName)
        Me.Controls.Add(Me.lblUserType)
        Me.Controls.Add(Me.lblLogin)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.cbOccupation)
        Me.Name = "Login"
        Me.Text = "Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbOccupation As System.Windows.Forms.ComboBox
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblLogin As System.Windows.Forms.Label
    Friend WithEvents lblUserType As System.Windows.Forms.Label
    Friend WithEvents lblUserName As System.Windows.Forms.Label
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents lnkForget_Password As System.Windows.Forms.LinkLabel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
