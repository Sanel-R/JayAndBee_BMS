Public Class UpdateEmployee



    Private Sub btnAddEmployee_Click(sender As Object, e As EventArgs) Handles btnAddEmployee.Click
        Dim answer As Integer = MsgBox("Are you sure you want to add this employee", MsgBoxStyle.YesNo, " Save confirmation")

        If (answer = MsgBoxResult.Yes) Then

            Try

                If (validate1()) Then
                    'Adding employee details
                    EmployeeTableAdapter.InsertEmployee(txtFName.Text, txtLName.Text, CBGender.Text, MBPhoneNo.Text, txtAddress.Text, txtEmail.Text, txtUserName.Text, txtPassWd.Text, txtOccupType.Text)

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

    End Sub


    Private Function validate1() As Boolean
        Dim count As Integer = 0



        'If (confirmPassTxt.Text.Equals(txtPassWd.Text) And (CInt(MBPhoneNo.Text = True) And (MBPhoneNo.Text = 10)) And (txtFName.Text <> "") And (txtLName.Text <> "") And Reg) Then

        'End If

        Return True
    End Function

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        Me.EmployeeTableAdapter.FillBy(Me.Group26DataSet.Employee, CInt(txtEmpIDSearch.Text))


    End Sub

    Private Sub btnUpdateEmployee_Click(sender As Object, e As EventArgs)

        Me.Validate()
        Me.EmployeeBindingSource.EndEdit()
        Me.EmployeeTableAdapter.FillBy(Me.Group26DataSet.Employee, txtEmpIDSearch.Text)




    End Sub

    Private Sub CBAction_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBAction.SelectedIndexChanged
        If (CBAction.Text.Equals("Add New Employee")) Then
            Clear()
            Dim pk As Integer = EmployeeTableAdapter.getPK()
            txtEmpID.Text = pk
            GBSearch.Visible = False
            btnAddEmployee.Enabled = True
            btnUpdateEmployee.Enabled = False
            lblConfirmPassWd.Text = "Confirm Password"
            lblPasswd.Text = "Password"


        Else
            Clear()
            GBSearch.Visible = True
            txtEmpID.Text = ""
            btnUpdateEmployee.Enabled = True
            btnAddEmployee.Enabled = False
            lblConfirmPassWd.Text = "Confirm New Password"
            lblPasswd.Text = "New Password"

        End If

    End Sub

    Private Sub btnUpdateEmployee_Click_1(sender As Object, e As EventArgs) Handles btnUpdateEmployee.Click

        Dim response As Integer = MsgBox("Are you sure you wish to update employee details?", MsgBoxStyle.YesNo)

        If response.Equals(MsgBoxResult.Yes) Then
            EmployeeTableAdapter.UpdateEmployee(txtFName.Text, txtLName.Text, CBGender.Text, MBPhoneNo.Text, txtAddress.Text, txtEmail.Text,
            txtUserName.Text, txtPassWd.Text, txtOccupType.Text, txtEmpID.Text, txtEmpIDSearch.Text)
            MsgBox("Updated Successfully", MsgBoxStyle.MsgBoxRight)
            Clear()

        End If


    End Sub
End Class