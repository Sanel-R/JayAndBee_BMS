Public Class UpdateEmployee

    Private Sub btnAddEmployee_Click(sender As Object, e As EventArgs) Handles btnAddEmployee.Click
        Dim answer As Integer = MsgBox("Are you sure you want to add this employee", MsgBoxStyle.YesNo, " Save confirmation")

        If (answer = MsgBoxResult.Yes) Then

            Try

                If (validateInput()) Then
                    'Adding employee details
                    EmployeeTableAdapter.InsertEmployee(txtFName.Text, txtLName.Text, CBGender.Text, MBPhoneNo.Text, txtAddress.Text,
                                                        txtEmail.Text, txtUserName.Text, txtPassWd.Text, txtOccupType.Text, CBStatus.Text)

                    MsgBox("Successfully added")
                    Clear() ' this method clear all the textbox 
                Else

                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If


    End Sub

    Private Sub UpdateEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnAddEmployee.Enabled = False
        btnDeleteEmployee.Enabled = False
        btnUpdateEmployee.Enabled = False
        'TODO: This line of code loads data into the 'Group26DataSet.Booking' table. You can move, or remove it, as needed.
        Me.BookingTableAdapter.Fill(Me.Group26DataSet.Booking)
        'TODO: This line of code loads data into the 'Group26DataSet.Employee' table. You can move, or remove it, as needed.
        '' Me.EmployeeTableAdapter.Fill(Me.Group26DataSet.Employee)



    End Sub

    Private Function validateInput() As Boolean

        Return True
    End Function

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        Me.EmployeeTableAdapter.Fill(Me.Group26DataSet.Employee, CInt(txtEmpIDSearch.Text))

    End Sub

    Private Sub btnUpdateEmployee_Click(sender As Object, e As EventArgs)

        Me.Validate()
        Me.EmployeeBindingSource.EndEdit()
        Me.EmployeeTableAdapter.FillBy(Me.Group26DataSet.Employee, txtEmpIDSearch.Text)

    End Sub

    Private Sub CBAction_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBAction.SelectedIndexChanged
        If (CBAction.Text.Equals("Add New Employee")) Then
            Clear()
            EnableAll()
            Dim pk As Integer = EmployeeTableAdapter.getPK()
            txtEmpID.Text = pk
            GBSearch.Visible = False
            btnAddEmployee.Enabled = True
            btnUpdateEmployee.Enabled = False
            btnDeleteEmployee.Enabled = False
            lblConfirmPassWd.Visible = True
            confirmPassTxt.Visible = True
            lblConfirmPassWd.Text = "Confirm Password"
            lblPasswd.Text = "Password"


        ElseIf CBAction.Text.Equals("Update Employee") Then
            Clear()
            EnableAll()
            GBSearch.Visible = True
            btnUpdateEmployee.Enabled = True
            btnAddEmployee.Enabled = False
            btnDeleteEmployee.Enabled = False
            lblConfirmPassWd.Visible = True
            confirmPassTxt.Visible = True
            lblConfirmPassWd.Text = "Confirm New Password"
            lblPasswd.Text = "New Password"


        Else
            Clear()
            DisableAll()
            GBSearch.Visible = True
            btnDeleteEmployee.Enabled = True
            btnUpdateEmployee.Enabled = False
            btnAddEmployee.Enabled = False
            lblConfirmPassWd.Text = "Confirm Password"
            lblPasswd.Text = "Password"
            lblConfirmPassWd.Visible = False
            confirmPassTxt.Visible = False
            txtPassWd.PasswordChar = ""

        End If

    End Sub

    Private Sub Clear()
        txtEmpID.Clear()
        txtEmpIDSearch.Clear()
        txtFName.Clear()
        txtLName.Clear()
        MBPhoneNo.Clear()
        txtEmail.Clear()
        txtOccupType.Clear()
        txtPassWd.Clear()
        confirmPassTxt.Clear()
        txtUserName.Clear()
        txtAddress.Clear()
        CBGender.Text = "Select"
        CBStatus.Text = "Select"
    End Sub

    Private Sub EnableAll()
        CBGender.Enabled = True
        CBStatus.Enabled = True
        confirmPassTxt.Enabled = True
        txtAddress.Enabled = True
        txtEmail.Enabled = True
        txtEmpID.Enabled = True
        txtFName.Enabled = True
        txtLName.Enabled = True
        txtOccupType.Enabled = True
        txtUserName.Enabled = True
        txtPassWd.Enabled = True
        MBPhoneNo.Enabled = True
    End Sub

    Private Sub DisableAll()
        CBGender.Enabled = False
        CBStatus.Enabled = False
        confirmPassTxt.Enabled = False
        txtAddress.Enabled = False
        txtEmail.Enabled = False
        txtEmpID.Enabled = False
        txtFName.Enabled = False
        txtLName.Enabled = False
        txtOccupType.Enabled = False
        txtUserName.Enabled = False
        txtPassWd.Enabled = False
        MBPhoneNo.Enabled = False
    End Sub

    Private Sub btnUpdateEmployee_Click_1(sender As Object, e As EventArgs) Handles btnUpdateEmployee.Click

        Dim response As Integer = MsgBox("Are you sure you wish to update employee details?", MsgBoxStyle.YesNo)

        If response.Equals(MsgBoxResult.Yes) Then
            EmployeeTableAdapter.UpdateEmployee(txtFName.Text, txtLName.Text, CBGender.Text, MBPhoneNo.Text, txtAddress.Text, txtEmail.Text,
            txtUserName.Text, txtPassWd.Text, txtOccupType.Text, CBStatus.Text, CInt(txtEmpID.Text), CInt(txtEmpIDSearch.Text))
            MsgBox("Updated Successfully", MsgBoxStyle.MsgBoxRight)
            Clear()

        End If


    End Sub

    Private Sub btnDeleteEmployee_Click(sender As Object, e As EventArgs) Handles btnDeleteEmployee.Click
        Dim response As Integer = MsgBox("Are you sure you want to archive employee number " & txtEmpIDSearch.Text & "? Archiving will change the employee's UserName, Password, Occupation and Employment Status.", MsgBoxStyle.YesNo)

        If response.Equals(MsgBoxResult.Yes) Then
            EmployeeTableAdapter.ArchiveEmployee(txtEmpIDSearch.Text)
            MsgBox("Employee successfully archived!", MsgBoxStyle.OkOnly)
            Clear()
        End If
    End Sub

    Private Sub SplitContainer1_SplitterMoved(sender As Object, e As SplitterEventArgs) Handles SplitContainer1.SplitterMoved

    End Sub
End Class