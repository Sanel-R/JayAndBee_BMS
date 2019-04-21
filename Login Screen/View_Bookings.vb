Public Class View_Bookings
    Private Sub View_Bookings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Friend Sub FormSetUp(ByVal ChildForm As Form)
        ' Try
        'Me.ActiveMdiChild.Close()
        ' Catch ex As Exception
        ' End Try
        ' With ChildForm
        ' .MdiParent = Me
        ' .WindowState = FormWindowState.Maximized
        ' .Show()
        ' End With
    End Sub

    Private Overloads Function ActivateMdiChild() As Object
        Throw New NotImplementedException()
    End Function

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        FormSetUp(UpdateEmployee)
    End Sub
End Class