Public Class NewBooking

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged

    End Sub

    Private Sub NewBooking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Group26DataSet.Guest' table. You can move, or remove it, as needed.
        lblUser.Text = Login.username
        lblGuestID.Text = GuestTableAdapter.GenNextID()
        Me.GuestTableAdapter.Fill(Me.Group26DataSet.Guest)

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class