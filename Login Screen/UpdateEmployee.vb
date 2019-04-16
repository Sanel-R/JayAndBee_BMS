Public Class UpdateEmployee


    Private Sub btnAddEmployee_Click(sender As Object, e As EventArgs) 
        Dim answer As Integer = MsgBox("Are you sure you want to add this employee", MsgBoxStyle.YesNo, " Save confirmation")

        If (answer = MsgBoxResult.Yes) Then

            Try

                If (Validate()) Then
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

        txtFName.Clear()
        txtLName.Clear()
        txtOccupType.Clear()
        txtPassWd.Clear()
        txtUserName.Clear()
        txtAddress.Clear()
        CBGender.Refresh()

    End Sub


    Private Function validate1() As Boolean
        Dim count As Integer = 0



        'If (confirmPassTxt.Text.Equals(txtPassWd.Text) And (CInt(MBPhoneNo.Text = True) And (MBPhoneNo.Text = 10)) And (txtFName.Text <> "") And (txtLName.Text <> "") And Reg) Then

        'End If

        Return True
    End Function

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        Me.EmployeeTableAdapter.FillBy(Me.Group26DataSet.Employee, CInt(TextBox1.Text))


    End Sub

    Private Sub btnUpdateEmployee_Click(sender As Object, e As EventArgs) 

        Me.validate()
        Me.EmployeeBindingSource.EndEdit()
        Me.EmployeeTableAdapter.Fill(Me.Group26DataSet.Employee)
    End Sub

    Private Sub CBAction_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBAction.SelectedIndexChanged
        If (CBAction.Text.Equals("Add New Employee")) Then
            Dim pk As Integer = EmployeeTableAdapter.getPK()
            txtEmpID.Text = pk
            GBSearch.Visible = False
            btnAddEmployee.Enabled = True
            btnUpdateEmployee.Enabled = False
        Else
            GBSearch.Visible = True
            txtEmpID.Text = ""
            btnUpdateEmployee.Enabled = True
            btnAddEmployee.Enabled = False
        End If

    End Sub
End Class