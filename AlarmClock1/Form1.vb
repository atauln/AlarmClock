Public Class Form1
    Dim CurrentTime = Now
    Private Sub TimeDetector_Tick(sender As Object, e As EventArgs) Handles TimeDetector.Tick
        CurrentTime = Now
        lblTimeDisplay.Text = CurrentTime
    End Sub
End Class
