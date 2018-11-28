Public Class StopwatchIndTab
#Region "Variables"
    Dim StopWatchTime = 0
#End Region
#Region "Stopwatch"
    Private Sub Timer1Stopwatch_Tick(sender As Object, e As EventArgs) Handles StopwatchTimer.Tick
        StopWatchTime += 0.1
        StopWatchTime = Math.Round(StopWatchTime, 1)
        lblStopwatch.Text = StopWatchTime.ToString + "s"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnResetStopW.Click
        StopWatchTime = 0
        lblStopwatch.Text = StopWatchTime.ToString + "s"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnStartStopW.Click
        StopwatchTimer.Enabled = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnStopStopW.Click
        StopwatchTimer.Enabled = False
    End Sub
#End Region
End Class