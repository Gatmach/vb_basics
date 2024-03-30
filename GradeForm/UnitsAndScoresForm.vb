Public Class UnitsAndScoresForm
    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        Dim AverageAndGrade As New AverageAndGrade()
        AverageAndGrade.Show()
        Me.Hide()
    End Sub


End Class