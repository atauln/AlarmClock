Public Class AlarmClockDashboard
#Region "Variables"
    Dim Alarm1Enabled = False
    Dim Alarm2Enabled = False
    Dim StopWatchTime = 0
    Public Property TimerSeconds As Integer
    Public Property TimerMinutes As Integer
    Public Property TimerHours As Integer
    Public Property TimerRemainderSecs As Integer
    Public Property TimerRemainderMins
#End Region
#Region "Timer for Alarms"
    Private Sub TimeDetector_Tick(sender As Object, e As EventArgs) Handles TimeDetector.Tick
        lblTimeDisplay.Text = TimeString
        Dim DateValueAlarm1 = FormatDateTime(dtpAlarm1.Value.ToString, DateFormat.ShortDate)
        If Now.ToString.Substring(0, 2) = DateValueAlarm1.Substring(0, 2) And Now.ToString.Substring(3, 2) = DateValueAlarm1.Substring(3, 2) And Now.ToString.Substring(6, 2) = DateValueAlarm1.Substring(6, 2) And TimeString.ToString.Substring(0, 2) = udHRAlarm1.Value And TimeString.ToString.Substring(3, 2) = udMINAlarm1.Value And Alarm1Enabled = True Then
            btnAlarm1Enable.Text = "Disabled"
            btnAlarm1Enable.BackColor = Color.Red
            Alarm1Enabled = False
            MsgBox("Your alarm, " + txtAlarm1Name.Text + " has been activated", , txtAlarm1Name.Text)
        End If
        If Now.ToString.Substring(0, 2) = FormatDateTime(dtpAlarm2.Value, DateFormat.ShortDate).Substring(0, 2) And Now.ToString.Substring(3, 2) = FormatDateTime(dtpAlarm2.Value, DateFormat.ShortDate).Substring(3, 2) And Now.ToString.Substring(6, 2) = FormatDateTime(dtpAlarm2.Value, DateFormat.ShortDate).Substring(6, 2) And TimeString.ToString.Substring(0, 2) = udHRAlarm2.Value And TimeString.ToString.Substring(3, 2) = udMINAlarm2.Value And Alarm2Enabled = True Then
            btnAlarm2Enable.Text = "Disabled"
            btnAlarm2Enable.BackColor = Color.Red
            Alarm2Enabled = False
            MsgBox("Your alarm, " + txtAlarm2Name.Text + " has been activated", , txtAlarm2Name.Text)
        End If
    End Sub
#End Region
#Region "Date Time Picker (Alarm 1)"
    'old method
    'update soon
    Private Sub dtpAlarm1_ValueChanged(sender As Object, e As EventArgs) Handles dtpAlarm1.ValueChanged
        Dim dtpDateTime1 = FormatDateTime(dtpAlarm1.Value.ToString, DateFormat.ShortDate)
    End Sub
#End Region
#Region "Form Load"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        udHRAlarm1.Value = TimeString.Substring(0, 2)
        udMINAlarm1.Value = TimeString.Substring(3, 2) - 1
        udHRAlarm2.Value = TimeString.Substring(0, 2)
        udMINAlarm2.Value = TimeString.Substring(3, 2) - 1
        My.Forms.TimerFullScreen.Visible = False
        My.Forms.StopwatchIndTab.Visible = False
    End Sub
#End Region
#Region "Alarm Enable Buttons"
    Private Sub btnAlarm1Enable_Click(sender As Object, e As EventArgs) Handles btnAlarm1Enable.Click
        If Alarm1Enabled = False Then
            Alarm1Enabled = True
            btnAlarm1Enable.Text = "Enabled"
            btnAlarm1Enable.BackColor = Color.Lime
        ElseIf Alarm1Enabled = True Then
            Alarm1Enabled = False
            btnAlarm1Enable.Text = "Disabled"
            btnAlarm1Enable.BackColor = Color.Red
        End If
    End Sub

    Private Sub btnAlarm2Enable_Click(sender As Object, e As EventArgs) Handles btnAlarm2Enable.Click
        If Alarm2Enabled = False Then
            Alarm2Enabled = True
            btnAlarm2Enable.Text = "Enabled"
            btnAlarm2Enable.BackColor = Color.Lime
        ElseIf Alarm1Enabled = True Then
            Alarm2Enabled = False
            btnAlarm2Enable.Text = "Disabled"
            btnAlarm2Enable.BackColor = Color.Red
        End If
    End Sub
#End Region
#Region "StopWatch"
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
#Region "Website"
    Private Sub lnkWebsite_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkWebsite.LinkClicked
        System.Diagnostics.Process.Start("http://www.ataulnoor75.wixsite.com/dominiontech")
    End Sub


#End Region
#Region "Independent Tabs"
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        My.Forms.TimerFullScreen.Visible = True
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        My.Forms.StopwatchIndTab.Visible = True
    End Sub
#End Region
End Class
