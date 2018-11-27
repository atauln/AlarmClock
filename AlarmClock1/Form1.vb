Public Class Form1
    Dim CurrentTime = TimeString
    Private Sub TimeDetector_Tick(sender As Object, e As EventArgs) Handles TimeDetector.Tick
        CurrentTime = TimeString
        lblTimeDisplay.Text = CurrentTime
        Dim NowTime = DateString
        Dim DateValueAlarm1 = FormatDateTime(dtpAlarm1.Value.ToString, DateFormat.ShortDate)
        If NowTime.Substring(0, 2) = DateValueAlarm1.Substring(0, 2) And NowTime.Substring(3, 2) = DateValueAlarm1.Substring(3, 2) And NowTime.Substring(6, 2) = DateValueAlarm1.Substring(6, 2) And CurrentTime.Substring(0, 2) = udHRAlarm1.Value And CurrentTime.Substring(3, 2) = udMINAlarm1.Value Then
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
End Class
