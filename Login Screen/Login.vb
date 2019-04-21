Public Class Login
    Friend username As String


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Try
            If EmployeeTableAdapter1.GetPassword((txtUsername.Text)).Equals(txtPassword.Text) And
                EmployeeTableAdapter1.GetOccupation((txtUsername.Text)).Equals(cbOccupation.Text) Then
                MsgBox("Redirecting you to the Management interface", MsgBoxStyle.OkOnly)
                Me.Hide()
                username = EmployeeTableAdapter1.GetNames(txtUsername.Text)
                If cbOccupation.Text.Equals("Employee") Then

                ElseIf cbOccupation.Text.Equals("Manager") Then
                    UpdateEmployee.Show()
                End If
            Else
                MsgBox("Login Unauthorized!", "Error", MsgBoxStyle.OkOnly)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
