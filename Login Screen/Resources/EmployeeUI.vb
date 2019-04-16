Public Class EmployeeUI

    Private Sub pbViewBookings_Click(sender As Object, e As EventArgs) Handles pbViewBookings.Click
        flMonthlyReview.Show()
    End Sub

    Private Sub pbCleaningService_Click(sender As Object, e As EventArgs) Handles pbCleaningService.Click
        CleaningService.Show()
        Me.Hide()
    End Sub

    Private Sub EmployeeUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub pbMealService_Click(sender As Object, e As EventArgs)
        Meal_Service.Show()
        Me.Hide()
    End Sub

    Private Sub pbUpdate_Click(sender As Object, e As EventArgs)
        AdditionalServicesMeals.Show()
        Me.Hide()
    End Sub
End Class