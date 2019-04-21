Imports System.Text.RegularExpressions

Public Class UpdateEmployee
    Private isPasswordValid As Boolean = True

    Private Sub ShowAll(ByVal toggle As Boolean)
        lblCheckMark1.Visible = toggle
        btnAddEmployee.Visible = toggle
        btnUpdateEmployee.Visible = toggle
        btnDeleteEmployee.Visible = toggle
        btnAddEmployee.Enabled = toggle
        btnDeleteEmployee.Enabled = toggle
        btnUpdateEmployee.Enabled = toggle
    End Sub


    Private Sub UpdateEmployee_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        lblUser.Text = Login.username & " (Manager)"
        ShowAll(False)
    End Sub

    Private Function ValidateInput() As Boolean

        Return True
    End Function

    Private Sub btnUpdateEmployee_Click(sender As Object, e As EventArgs)
        Me.Validate()
        EmployeeTableAdapter1.UpdateEmployee(txtFName.Text, txtLName.Text, CBGender.Text, MBPhoneNo.Text, txtAddress.Text, txtEmail.Text, txtUserName.Text,
                                txtPassWd.Text, txtOccupType.Text, CBStatus.Text, CInt(txtEmpID.Text), CInt(txtEmpIDSearch.Text))

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

    Private Sub btnSearch_Click_1(sender As Object, e As EventArgs) Handles btnSearch.Click

        Try
            If (EmployeeTableAdapter1.FInd(CInt(txtEmpIDSearch.Text)).Equals(CInt(txtEmpIDSearch.Text))) Then
                Me.EmployeeTableAdapter1.FillBy(Me.Group26DataSet1.Employee, CInt(txtEmpIDSearch.Text))
                If Not CBAction.Text.Equals("Add New Employee") Then
                    If (CBStatus.Text.Equals("Employment Terminated")) Then
                        txtOccupType.Text = "N/A"
                        txtUserName.Text = "N/A"
                        CBStatus.Text = "N/A"
                        txtPassWd.Text = ""
                    End If
                End If
            End If
        Catch null As System.NullReferenceException
            MsgBox("No employee with ID Number " & txtEmpIDSearch.Text & " was found!", MsgBoxStyle.OkOnly)
        Catch noImput As System.InvalidCastException
            MsgBox("Please enter an Employee Number", MsgBoxStyle.OkOnly)
        End Try
        lblPasswd.Text = "Password"
        confirmPassTxt.Visible = False
        lblConfirmPassWd.Visible = False
        checkmark1.Visible = False
        checkmark2.Visible = False
    End Sub

    Private Sub CBAction_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles CBAction.SelectedIndexChanged
        ShowAll(True)
        If (CBAction.Text.Equals("Add New Employee")) Then
            Clear()
            EnableAll()
            Dim pk As Integer = EmployeeTableAdapter1.getPK()
            txtEmpID.Text = pk
            GBSearch.Visible = False
            btnAddEmployee.Enabled = True
            btnUpdateEmployee.Enabled = False
            btnDeleteEmployee.Enabled = False
            lblConfirmPassWd.Visible = True
            confirmPassTxt.Visible = True
            checkmark1.Visible = False
            checkmark2.Visible = False
            lblConfirmPassWd.Text = "Confirm Password"
            lblPasswd.Text = "Password"


        ElseIf CBAction.Text.Equals("Update Employee") Then
            Clear()
            EnableAll()
            GBSearch.Visible = True
            btnUpdateEmployee.Enabled = True
            btnAddEmployee.Enabled = False
            btnDeleteEmployee.Enabled = False
            lblConfirmPassWd.Visible = False
            confirmPassTxt.Visible = False
            checkmark1.Visible = False
            checkmark2.Visible = False



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
            checkmark1.Visible = False
            checkmark2.Visible = False
            txtPassWd.PasswordChar = ""

        End If
    End Sub

    Private Sub btnLogout_Click_1(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub btnAddEmployee_Click(sender As Object, e As EventArgs) Handles btnAddEmployee.Click
        Dim answer As Integer = MsgBox("Are you sure you want to add this employee", MsgBoxStyle.YesNo, " Save confirmation")

        If (answer = MsgBoxResult.Yes) Then

            Try

                If (ValidateInput()) Then
                    'Adding employee details
                    EmployeeTableAdapter1.InsertEmployee(txtFName.Text, txtLName.Text, CBGender.Text, MBPhoneNo.Text, txtAddress.Text,
                    txtEmail.Text, txtUserName.Text, txtPassWd.Text, txtOccupType.Text, CBStatus.Text)

                    MsgBox("Successfully added")
                    Clear()
                Else

                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If
    End Sub

    Private Sub txtPassWd_TextChanged_1(sender As Object, e As EventArgs) Handles txtPassWd.TextChanged
        lblConfirmPassWd.Text = "Confirm New Password"
        lblPasswd.Text = "New Password"
        lblConfirmPassWd.Visible = True
        confirmPassTxt.Visible = True
        checkmark1.Visible = True
        checkmark2.Visible = True
        If confirmPassTxt.Text.Equals(txtPassWd.Text) And IsPasswordSecure() Then
            checkmark1.Image = My.Resources.download
            checkmark2.Image = My.Resources.download
        Else
            checkmark1.Image = My.Resources.g30896_512
            checkmark2.Image = My.Resources.g30896_512
            isPasswordValid = False
        End If
    End Sub

    Private Sub btnDeleteEmployee_Click(sender As Object, e As EventArgs) Handles btnDeleteEmployee.Click
        If CBStatus.Text = "N/A" Then
            MsgBox("Employee has already been archived!", MsgBoxStyle.OkOnly)
        Else
            Dim response As Integer = MsgBox("Are you sure you want to archive employee number " & txtFName.Text & " " & txtLName.Text & "? Archiving will change the employee's UserName, Password, Occupation and Employment Status.", MsgBoxStyle.YesNo)

            If response.Equals(MsgBoxResult.Yes) Then
                '  EmployeeTableAdapter.ArchiveEmployee(txtEmpIDSearch.Text)
                MsgBox("Employee successfully archived!", MsgBoxStyle.OkOnly)
                Clear()
            End If
        End If
    End Sub

    Private Sub btnUpdateEmployee_Click_1(sender As Object, e As EventArgs) Handles btnUpdateEmployee.Click
        Try
            If Integer.TryParse((txtEmpIDSearch.Text), CInt(txtEmpIDSearch.Text)).Equals(True) And isPasswordValid Then
                Dim response As Integer = MsgBox("Are you sure you wish to update employee details?", MsgBoxStyle.YesNo)
                If response.Equals(MsgBoxResult.Yes) Then
                    EmployeeTableAdapter1.UpdateEmployee(txtFName.Text, txtLName.Text, CBGender.Text, MBPhoneNo.Text, txtAddress.Text, txtEmail.Text,
                    txtUserName.Text, txtPassWd.Text, txtOccupType.Text, CBStatus.Text, CInt(txtEmpID.Text), CInt(txtEmpIDSearch.Text))
                    MsgBox("Updated Successfully", MsgBoxStyle.MsgBoxRight)
                    Clear()
                End If
                lblConfirmPassWd.Visible = False
                confirmPassTxt.Visible = False
                checkmark1.Visible = False
                checkmark2.Visible = False

            Else
                MsgBox("Unable to update employee information!", MsgBoxStyle.OkOnly)
            End If

        Catch ex As System.ArgumentException
            MsgBox("Please enter an Employee ID", MsgBoxStyle.OkOnly)
        Catch ex2 As System.InvalidCastException
            MsgBox("Please enter an Employee ID", MsgBoxStyle.OkOnly)
        End Try

    End Sub

    Private Sub confirmPassTxt_TextChanged(sender As Object, e As EventArgs) Handles confirmPassTxt.TextChanged
        checkmark1.Visible = True
        checkmark2.Visible = True
        If confirmPassTxt.Text.Equals(txtPassWd.Text) And IsPasswordSecure() Then
            checkmark1.Image = My.Resources.download
            checkmark2.Image = My.Resources.download
        Else
            checkmark1.Image = My.Resources.g30896_512
            checkmark2.Image = My.Resources.g30896_512
            isPasswordValid = False
        End If

    End Sub

    ' requires the password to be more than 6 characters in length and contain special characters
    Private Function IsPasswordSecure() As Boolean
        Return txtPassWd.Text.Length > 6 And Regex.IsMatch(txtPassWd.Text, "[`~!@#\$%\^&\*\(\)_\-\+=\{\}\[\]\\\|:;""'<>,\.\?/]")
    End Function
End Class
