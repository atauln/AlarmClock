Public Class AlarmClockDashboard
#Region "Variables"
    Dim Alarm1Enabled = False
    Dim Alarm2Enabled = False
    Dim StopWatchTime = 0
#End Region
#Region "Timer for Alarms"
    Private Sub TimeDetector_Tick(sender As Object, e As EventArgs) Handles TimeDetector.Tick
        lblTimeDisplay.Text = TimeString
        Dim DateValueAlarm1 = FormatDateTime(dtpAlarm1.Value.ToString, DateFormat.ShortDate)
        If Now.ToString.Substring(0, 2) = DateValueAlarm1.Substring(0, 2) And Now.ToString.Substring(3, 2) = DateValueAlarm1.Substring(3, 2) And Now.ToString.Substring(6, 2) = DateValueAlarm1.Substring(6, 2) And TimeString.ToString.Substring(0, 2) = udHRAlarm1.Value And TimeString.ToString.Substring(3, 2) = udMINAlarm1.Value And Alarm1Enabled = True Then
            My.Computer.Audio.Play("C:\Users\Ataul\source\repos\AlarmClock1\AlarmClock1\Store_Door_Chime-Mike_Koenig-570742973.wav")
            btnAlarm1Enable.Text = "Disabled"
            btnAlarm1Enable.BackColor = Color.Red
            Alarm1Enabled = False
            MsgBox("Your alarm, " + txtAlarm1Name.Text + " has been activated", , txtAlarm1Name.Text)
        End If
        If Now.ToString.Substring(0, 2) = FormatDateTime(dtpAlarm2.Value, DateFormat.ShortDate).Substring(0, 2) And Now.ToString.Substring(3, 2) = FormatDateTime(dtpAlarm2.Value, DateFormat.ShortDate).Substring(3, 2) And Now.ToString.Substring(6, 2) = FormatDateTime(dtpAlarm2.Value, DateFormat.ShortDate).Substring(6, 2) And TimeString.ToString.Substring(0, 2) = udHRAlarm2.Value And TimeString.ToString.Substring(3, 2) = udMINAlarm2.Value And Alarm2Enabled = True Then
            My.Computer.Audio.Play("C:\Users\Ataul\source\repos\AlarmClock1\AlarmClock1\Store_Door_Chime-Mike_Koenig-570742973.wav")
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
    Private Sub Timer1Stopwatch_Tick(sender As Object, e As EventArgs) Handles Timer1Stopwatch.Tick
        StopWatchTime += 0.1
        StopWatchTime = Math.Round(StopWatchTime, 1)
        lblStopwatch.Text = StopWatchTime.ToString + "s"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        StopWatchTime = 0
        lblStopwatch.Text = StopWatchTime.ToString + "s"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Timer1Stopwatch.Enabled = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        Timer1Stopwatch.Enabled = False
    End Sub
#End Region
End Class
