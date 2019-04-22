Public Class NewBooking
    Private Sub NewBooking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblUser.Text = Login.username
        lblGuestID.Text = GuestTableAdapter.GenNextID()

    End Sub

    Private Sub btnBooking_Click(sender As Object, e As EventArgs) Handles btnBooking.Click

        If ValidateInformation() Then
            ' Process guest
            GuestTableAdapter.NewGuest(cmbTitle.Text, txtLastName.Text, txtName.Text, mskPhoneNumber.Text, txtEmailAddress.Text)
            ' Process booking

        End If

    End Sub

    ' Checks if the information that has been entered can be processed
    Private Function ValidateInformation() As Boolean

        Return True
    End Function

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click

    End Sub
End Class