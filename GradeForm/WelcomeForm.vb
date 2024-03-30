Public Class WelcomeForm
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub GetStartedButton_Click(Sender As Object, e As EventArgs) Handles GetStartedButton.Click
        Dim unitsAndScoresForm As New UnitsAndScoresForm()
        unitsAndScoresForm.Show()
        Me.Hide()
    End Sub
End Class
