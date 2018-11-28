Public Class TimerFullScreen
#Region "Variables"
    Public Property TimerSeconds As Integer
    Public Property TimerMinutes As Integer
    Public Property TimerHours As Integer
    Public Property TimerRemainderSecs As Integer
    Public Property TimerRemainderMins
#End Region
#Region "Timer"
    Private Sub btnStartTimer_Click(sender As Object, e As EventArgs) Handles btnStartTimer.Click
        TimerSeconds = udSECTimer.Value
        TimerMinutes = udMinTimer.Value
        TimerHours = udHRTimer.Value
        Timer.Enabled = True
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        If TimerSeconds < 0 Then
            TimerSeconds = 59
            TimerMinutes -= 1
            If TimerMinutes < 0 Then
                TimerMinutes = 59
                TimerHours -= 1
            End If
        End If
        If TimerHours = 0 And TimerMinutes = 0 And TimerSeconds = 0 Then
            lblTimer.Text = "0:00:00"
            Timer.Enabled = False
            MsgBox("Your timer has been activated", , "Timer")
        End If
        lblTimer.Text = TimerHours.ToString + ":" + TimerMinutes.ToString + ":" + TimerSeconds.ToString
        TimerSeconds -= 1
    End Sub

    Private Sub btnResetTimer_Click(sender As Object, e As EventArgs) Handles btnResetTimer.Click
        TimerSeconds = Nothing
        TimerMinutes = Nothing
        TimerHours = Nothing
        lblTimer.Text = "0:00:00"
        Timer.Enabled = False
        btnPauseContinueTimer.Text = "Continue"
        btnPauseContinueTimer.BackColor = Color.Lime
    End Sub

    Private Sub btnPauseContinueTimer_Click(sender As Object, e As EventArgs) Handles btnPauseContinueTimer.Click
        If btnPauseContinueTimer.Text = "PAUSE" Then
            Timer.Enabled = False
            btnPauseContinueTimer.BackColor = Color.Lime
            btnPauseContinueTimer.Text = "CONTINUE"
        ElseIf btnPauseContinueTimer.Text = "CONTINUE" Then
            Timer.Enabled = True
            btnPauseContinueTimer.BackColor = Color.Red
            btnPauseContinueTimer.Text = "CONTINUE"
        End If
    End Sub


#End Region
End Class