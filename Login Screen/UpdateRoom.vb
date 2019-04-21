Public Class UpdateRoom

    Private Sub SplitContainer1_Panel1_Paint(sender As Object, e As PaintEventArgs) Handles SplitContainer1.Panel1.Paint

    End Sub

    Private Sub SplitContainer1_Panel2_Paint(sender As Object, e As PaintEventArgs) Handles SplitContainer1.Panel2.Paint

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim Guest_ID As Integer
        ''Dim Check_Out_Date As Integer
        Guest_ID = InputBox("Enter Reservation Guest ID")
        MessageBox.Show("Guest Name: John Smith" & vbCrLf & "Room No: 14" & vbCrLf & "Check-In Date: 2019-04-01 12:30:00" & vbCrLf & "Check-Out Date: 2019-04-12 10:00:00")



    End Sub
End Class