Public Class Login
    Friend username As String


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Try
            If EmployeeTableAdapter1.GetPassword((txtUsername.Text)).Equals(txtPassword.Text) And
                EmployeeTableAdapter1.GetOccupation((txtUsername.Text)).Equals(cbOccupation.Text) And
                EmployeeTableAdapter1.FindBy(txtUsername.Text).Equals(txtUsername.Text) Then
                MessageBox.Show("Redirecting you to the Management interface")
                Me.Hide()
                username = EmployeeTableAdapter1.GetNames(txtUsername.Text)
                If cbOccupation.Text.Equals("Employee") Then

                ElseIf cbOccupation.Text.Equals("Manager") Then
                    UpdateEmployee.Show()
                End If
            Else
                MsgBox("Login Unauthorized!", "Error", MsgBoxStyle.OkOnly)
            End If
        Catch ex As System.ArgumentException
            MsgBox("The above information is required to login", MsgBoxStyle.OkOnly)
        Catch ex2 As System.NullReferenceException

            Try

                If Not EmployeeTableAdapter1.FindBy(txtUsername.Text).Equals("NULL") Then
                    MsgBox("Username does not exist", MsgBoxStyle.OkOnly)
                Else
                    MsgBox("The above information is required to login", MsgBoxStyle.OkOnly)
                End If
            Catch ex1 As Exception
                MsgBox("Username does not exist", MsgBoxStyle.OkOnly)
            End Try



        Catch ex3 As System.InvalidCastException
            MsgBox("Invalid password", MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
