Public Class Form1
    Dim CurrentTime = TimeString

    'Alarm 1 variables
    Dim Alarm1Enabled = False

    Private Sub TimeDetector_Tick(sender As Object, e As EventArgs) Handles TimeDetector.Tick
        CurrentTime = TimeString
        lblTimeDisplay.Text = CurrentTime
        Dim TimeStringVal = TimeString.ToString
        Dim DateValueAlarm1 = FormatDateTime(dtpAlarm1.Value.ToString, DateFormat.ShortDate)
        If Now.ToString.Substring(0, 2) = DateValueAlarm1.Substring(0, 2) And Now.ToString.Substring(3, 2) = DateValueAlarm1.Substring(3, 2) And Now.ToString.Substring(6, 2) = DateValueAlarm1.Substring(6, 2) And TimeString.ToString.Substring(0, 2) = udHRAlarm1.Value And TimeString.ToString.Substring(3, 2) = udMINAlarm1.Value And Alarm1Enabled = True Then
            My.Computer.Audio.Play("C:\Users\NoorA23\Source\Repos\AlarmClock\AlarmClock1\Store_Door_Chime-Mike_Koenig-570742973.wav")
            btnAlarm1Enable.Text = "Disabled"
            btnAlarm1Enable.BackColor = Color.Red
            Alarm1Enabled = False
            MsgBox("Your alarm, " + txtAlarm1Name.Text + "has been activated", , txtAlarm1Name.Text)

        End If
    End Sub

    Private Sub txtAlarm1Name_TextChanged(sender As Object, e As EventArgs) Handles txtAlarm1Name.TextChanged
        Dim Alarm1Name = txtAlarm1Name.Text
    End Sub

    Private Sub dtpAlarm1_ValueChanged(sender As Object, e As EventArgs) Handles dtpAlarm1.ValueChanged
        Dim dtpDateTime1 = FormatDateTime(dtpAlarm1.Value.ToString, DateFormat.ShortDate)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        udHRAlarm1.Value = TimeString.Substring(0, 2)
        udMINAlarm1.Value = TimeString.Substring(3, 2)
    End Sub

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
End Class
