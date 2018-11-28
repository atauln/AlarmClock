<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AlarmClockDashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AlarmClockDashboard))
        Me.GroupBoxAlarm1 = New System.Windows.Forms.GroupBox()
        Me.btnAlarm1Enable = New System.Windows.Forms.Button()
        Me.udMINAlarm1 = New System.Windows.Forms.NumericUpDown()
        Me.udHRAlarm1 = New System.Windows.Forms.NumericUpDown()
        Me.dtpAlarm1 = New System.Windows.Forms.DateTimePicker()
        Me.txtAlarm1Name = New System.Windows.Forms.TextBox()
        Me.lblTimeDisplay = New System.Windows.Forms.Label()
        Me.TimeDetector = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBoxAlarm2 = New System.Windows.Forms.GroupBox()
        Me.btnAlarm2Enable = New System.Windows.Forms.Button()
        Me.udMINAlarm2 = New System.Windows.Forms.NumericUpDown()
        Me.udHRAlarm2 = New System.Windows.Forms.NumericUpDown()
        Me.dtpAlarm2 = New System.Windows.Forms.DateTimePicker()
        Me.txtAlarm2Name = New System.Windows.Forms.TextBox()
        Me.StopwatchTimer = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBoxStopwatch = New System.Windows.Forms.GroupBox()
        Me.btnResetStopW = New System.Windows.Forms.Button()
        Me.btnStopStopW = New System.Windows.Forms.Button()
        Me.btnStartStopW = New System.Windows.Forms.Button()
        Me.lblStopwatch = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblTimer = New System.Windows.Forms.Label()
        Me.btnResetTimer = New System.Windows.Forms.Button()
        Me.btnPauseContinueTimer = New System.Windows.Forms.Button()
        Me.btnStartTimer = New System.Windows.Forms.Button()
        Me.udSECTimer = New System.Windows.Forms.NumericUpDown()
        Me.udMinTimer = New System.Windows.Forms.NumericUpDown()
        Me.udHRTimer = New System.Windows.Forms.NumericUpDown()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.lnkWebsite = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBoxAlarm1.SuspendLayout()
        CType(Me.udMINAlarm1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.udHRAlarm1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxAlarm2.SuspendLayout()
        CType(Me.udMINAlarm2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.udHRAlarm2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxStopwatch.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.udSECTimer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.udMinTimer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.udHRTimer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxAlarm1
        '
        Me.GroupBoxAlarm1.BackColor = System.Drawing.Color.White
        Me.GroupBoxAlarm1.Controls.Add(Me.btnAlarm1Enable)
        Me.GroupBoxAlarm1.Controls.Add(Me.udMINAlarm1)
        Me.GroupBoxAlarm1.Controls.Add(Me.udHRAlarm1)
        Me.GroupBoxAlarm1.Controls.Add(Me.dtpAlarm1)
        Me.GroupBoxAlarm1.Controls.Add(Me.txtAlarm1Name)
        Me.GroupBoxAlarm1.Location = New System.Drawing.Point(11, 11)
        Me.GroupBoxAlarm1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBoxAlarm1.Name = "GroupBoxAlarm1"
        Me.GroupBoxAlarm1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBoxAlarm1.Size = New System.Drawing.Size(118, 244)
        Me.GroupBoxAlarm1.TabIndex = 1
        Me.GroupBoxAlarm1.TabStop = False
        Me.GroupBoxAlarm1.Text = "Alarm 1 Properties"
        '
        'btnAlarm1Enable
        '
        Me.btnAlarm1Enable.BackColor = System.Drawing.Color.Red
        Me.btnAlarm1Enable.Location = New System.Drawing.Point(15, 115)
        Me.btnAlarm1Enable.Name = "btnAlarm1Enable"
        Me.btnAlarm1Enable.Size = New System.Drawing.Size(89, 122)
        Me.btnAlarm1Enable.TabIndex = 4
        Me.btnAlarm1Enable.Text = "Disabled"
        Me.btnAlarm1Enable.UseVisualStyleBackColor = False
        '
        'udMINAlarm1
        '
        Me.udMINAlarm1.Location = New System.Drawing.Point(15, 90)
        Me.udMINAlarm1.Margin = New System.Windows.Forms.Padding(2)
        Me.udMINAlarm1.Name = "udMINAlarm1"
        Me.udMINAlarm1.Size = New System.Drawing.Size(90, 20)
        Me.udMINAlarm1.TabIndex = 2
        '
        'udHRAlarm1
        '
        Me.udHRAlarm1.Location = New System.Drawing.Point(15, 67)
        Me.udHRAlarm1.Margin = New System.Windows.Forms.Padding(2)
        Me.udHRAlarm1.Name = "udHRAlarm1"
        Me.udHRAlarm1.Size = New System.Drawing.Size(90, 20)
        Me.udHRAlarm1.TabIndex = 3
        '
        'dtpAlarm1
        '
        Me.dtpAlarm1.CustomFormat = "'MM'/'dd'/'yyyy'"
        Me.dtpAlarm1.Location = New System.Drawing.Point(15, 42)
        Me.dtpAlarm1.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpAlarm1.Name = "dtpAlarm1"
        Me.dtpAlarm1.Size = New System.Drawing.Size(92, 20)
        Me.dtpAlarm1.TabIndex = 1
        '
        'txtAlarm1Name
        '
        Me.txtAlarm1Name.Location = New System.Drawing.Point(15, 17)
        Me.txtAlarm1Name.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAlarm1Name.Name = "txtAlarm1Name"
        Me.txtAlarm1Name.Size = New System.Drawing.Size(92, 20)
        Me.txtAlarm1Name.TabIndex = 0
        Me.txtAlarm1Name.Text = "Alarm Name"
        '
        'lblTimeDisplay
        '
        Me.lblTimeDisplay.Location = New System.Drawing.Point(488, 7)
        Me.lblTimeDisplay.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTimeDisplay.Name = "lblTimeDisplay"
        Me.lblTimeDisplay.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblTimeDisplay.Size = New System.Drawing.Size(107, 18)
        Me.lblTimeDisplay.TabIndex = 0
        '
        'TimeDetector
        '
        Me.TimeDetector.Enabled = True
        Me.TimeDetector.Interval = 1000
        '
        'GroupBoxAlarm2
        '
        Me.GroupBoxAlarm2.BackColor = System.Drawing.Color.White
        Me.GroupBoxAlarm2.Controls.Add(Me.btnAlarm2Enable)
        Me.GroupBoxAlarm2.Controls.Add(Me.udMINAlarm2)
        Me.GroupBoxAlarm2.Controls.Add(Me.udHRAlarm2)
        Me.GroupBoxAlarm2.Controls.Add(Me.dtpAlarm2)
        Me.GroupBoxAlarm2.Controls.Add(Me.txtAlarm2Name)
        Me.GroupBoxAlarm2.Location = New System.Drawing.Point(133, 11)
        Me.GroupBoxAlarm2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBoxAlarm2.Name = "GroupBoxAlarm2"
        Me.GroupBoxAlarm2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBoxAlarm2.Size = New System.Drawing.Size(118, 244)
        Me.GroupBoxAlarm2.TabIndex = 5
        Me.GroupBoxAlarm2.TabStop = False
        Me.GroupBoxAlarm2.Text = "Alarm 2 Properties"
        '
        'btnAlarm2Enable
        '
        Me.btnAlarm2Enable.BackColor = System.Drawing.Color.Red
        Me.btnAlarm2Enable.Location = New System.Drawing.Point(15, 115)
        Me.btnAlarm2Enable.Name = "btnAlarm2Enable"
        Me.btnAlarm2Enable.Size = New System.Drawing.Size(89, 122)
        Me.btnAlarm2Enable.TabIndex = 4
        Me.btnAlarm2Enable.Text = "Disabled"
        Me.btnAlarm2Enable.UseVisualStyleBackColor = False
        '
        'udMINAlarm2
        '
        Me.udMINAlarm2.Location = New System.Drawing.Point(15, 90)
        Me.udMINAlarm2.Margin = New System.Windows.Forms.Padding(2)
        Me.udMINAlarm2.Name = "udMINAlarm2"
        Me.udMINAlarm2.Size = New System.Drawing.Size(90, 20)
        Me.udMINAlarm2.TabIndex = 2
        '
        'udHRAlarm2
        '
        Me.udHRAlarm2.Location = New System.Drawing.Point(15, 67)
        Me.udHRAlarm2.Margin = New System.Windows.Forms.Padding(2)
        Me.udHRAlarm2.Name = "udHRAlarm2"
        Me.udHRAlarm2.Size = New System.Drawing.Size(90, 20)
        Me.udHRAlarm2.TabIndex = 3
        '
        'dtpAlarm2
        '
        Me.dtpAlarm2.CustomFormat = "'MM'/'dd'/'yyyy'"
        Me.dtpAlarm2.Location = New System.Drawing.Point(15, 42)
        Me.dtpAlarm2.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpAlarm2.Name = "dtpAlarm2"
        Me.dtpAlarm2.Size = New System.Drawing.Size(92, 20)
        Me.dtpAlarm2.TabIndex = 1
        '
        'txtAlarm2Name
        '
        Me.txtAlarm2Name.Location = New System.Drawing.Point(15, 17)
        Me.txtAlarm2Name.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAlarm2Name.Name = "txtAlarm2Name"
        Me.txtAlarm2Name.Size = New System.Drawing.Size(92, 20)
        Me.txtAlarm2Name.TabIndex = 0
        Me.txtAlarm2Name.Text = "Alarm Name"
        '
        'StopwatchTimer
        '
        '
        'GroupBoxStopwatch
        '
        Me.GroupBoxStopwatch.BackColor = System.Drawing.Color.White
        Me.GroupBoxStopwatch.Controls.Add(Me.btnResetStopW)
        Me.GroupBoxStopwatch.Controls.Add(Me.btnStopStopW)
        Me.GroupBoxStopwatch.Controls.Add(Me.btnStartStopW)
        Me.GroupBoxStopwatch.Controls.Add(Me.lblStopwatch)
        Me.GroupBoxStopwatch.Location = New System.Drawing.Point(255, 11)
        Me.GroupBoxStopwatch.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBoxStopwatch.Name = "GroupBoxStopwatch"
        Me.GroupBoxStopwatch.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBoxStopwatch.Size = New System.Drawing.Size(118, 244)
        Me.GroupBoxStopwatch.TabIndex = 6
        Me.GroupBoxStopwatch.TabStop = False
        Me.GroupBoxStopwatch.Text = "Stopwatch"
        '
        'btnResetStopW
        '
        Me.btnResetStopW.BackColor = System.Drawing.Color.Red
        Me.btnResetStopW.Location = New System.Drawing.Point(4, 184)
        Me.btnResetStopW.Name = "btnResetStopW"
        Me.btnResetStopW.Size = New System.Drawing.Size(108, 50)
        Me.btnResetStopW.TabIndex = 3
        Me.btnResetStopW.Text = "RESET"
        Me.btnResetStopW.UseVisualStyleBackColor = False
        '
        'btnStopStopW
        '
        Me.btnStopStopW.BackColor = System.Drawing.Color.Red
        Me.btnStopStopW.Location = New System.Drawing.Point(5, 129)
        Me.btnStopStopW.Name = "btnStopStopW"
        Me.btnStopStopW.Size = New System.Drawing.Size(108, 50)
        Me.btnStopStopW.TabIndex = 2
        Me.btnStopStopW.Text = "PAUSE"
        Me.btnStopStopW.UseVisualStyleBackColor = False
        '
        'btnStartStopW
        '
        Me.btnStartStopW.BackColor = System.Drawing.Color.Lime
        Me.btnStartStopW.Location = New System.Drawing.Point(5, 73)
        Me.btnStartStopW.Name = "btnStartStopW"
        Me.btnStartStopW.Size = New System.Drawing.Size(108, 50)
        Me.btnStartStopW.TabIndex = 1
        Me.btnStartStopW.Text = "START"
        Me.btnStartStopW.UseVisualStyleBackColor = False
        '
        'lblStopwatch
        '
        Me.lblStopwatch.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStopwatch.Location = New System.Drawing.Point(5, 15)
        Me.lblStopwatch.Name = "lblStopwatch"
        Me.lblStopwatch.Size = New System.Drawing.Size(108, 66)
        Me.lblStopwatch.TabIndex = 0
        Me.lblStopwatch.Text = "0s"
        Me.lblStopwatch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.lblTimer)
        Me.GroupBox1.Controls.Add(Me.btnResetTimer)
        Me.GroupBox1.Controls.Add(Me.btnPauseContinueTimer)
        Me.GroupBox1.Controls.Add(Me.btnStartTimer)
        Me.GroupBox1.Controls.Add(Me.udSECTimer)
        Me.GroupBox1.Controls.Add(Me.udMinTimer)
        Me.GroupBox1.Controls.Add(Me.udHRTimer)
        Me.GroupBox1.Location = New System.Drawing.Point(377, 11)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(118, 244)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Timer"
        '
        'lblTimer
        '
        Me.lblTimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimer.Location = New System.Drawing.Point(5, 15)
        Me.lblTimer.Name = "lblTimer"
        Me.lblTimer.Size = New System.Drawing.Size(108, 29)
        Me.lblTimer.TabIndex = 4
        Me.lblTimer.Text = "0:00:00"
        Me.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnResetTimer
        '
        Me.btnResetTimer.BackColor = System.Drawing.Color.Red
        Me.btnResetTimer.Location = New System.Drawing.Point(5, 198)
        Me.btnResetTimer.Name = "btnResetTimer"
        Me.btnResetTimer.Size = New System.Drawing.Size(108, 35)
        Me.btnResetTimer.TabIndex = 7
        Me.btnResetTimer.Text = "RESET"
        Me.btnResetTimer.UseVisualStyleBackColor = False
        '
        'btnPauseContinueTimer
        '
        Me.btnPauseContinueTimer.BackColor = System.Drawing.Color.Red
        Me.btnPauseContinueTimer.Location = New System.Drawing.Point(5, 159)
        Me.btnPauseContinueTimer.Name = "btnPauseContinueTimer"
        Me.btnPauseContinueTimer.Size = New System.Drawing.Size(108, 35)
        Me.btnPauseContinueTimer.TabIndex = 6
        Me.btnPauseContinueTimer.Text = "PAUSE"
        Me.btnPauseContinueTimer.UseVisualStyleBackColor = False
        '
        'btnStartTimer
        '
        Me.btnStartTimer.BackColor = System.Drawing.Color.Lime
        Me.btnStartTimer.Location = New System.Drawing.Point(5, 118)
        Me.btnStartTimer.Name = "btnStartTimer"
        Me.btnStartTimer.Size = New System.Drawing.Size(108, 35)
        Me.btnStartTimer.TabIndex = 5
        Me.btnStartTimer.Text = "START"
        Me.btnStartTimer.UseVisualStyleBackColor = False
        '
        'udSECTimer
        '
        Me.udSECTimer.Location = New System.Drawing.Point(14, 92)
        Me.udSECTimer.Margin = New System.Windows.Forms.Padding(2)
        Me.udSECTimer.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.udSECTimer.Name = "udSECTimer"
        Me.udSECTimer.Size = New System.Drawing.Size(90, 20)
        Me.udSECTimer.TabIndex = 2
        '
        'udMinTimer
        '
        Me.udMinTimer.Location = New System.Drawing.Point(14, 69)
        Me.udMinTimer.Margin = New System.Windows.Forms.Padding(2)
        Me.udMinTimer.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.udMinTimer.Name = "udMinTimer"
        Me.udMinTimer.Size = New System.Drawing.Size(90, 20)
        Me.udMinTimer.TabIndex = 1
        '
        'udHRTimer
        '
        Me.udHRTimer.Location = New System.Drawing.Point(14, 46)
        Me.udHRTimer.Margin = New System.Windows.Forms.Padding(2)
        Me.udHRTimer.Maximum = New Decimal(New Integer() {9, 0, 0, 0})
        Me.udHRTimer.Name = "udHRTimer"
        Me.udHRTimer.Size = New System.Drawing.Size(90, 20)
        Me.udHRTimer.TabIndex = 0
        '
        'Timer
        '
        Me.Timer.Interval = 1000
        '
        'lnkWebsite
        '
        Me.lnkWebsite.Location = New System.Drawing.Point(507, 235)
        Me.lnkWebsite.Name = "lnkWebsite"
        Me.lnkWebsite.Size = New System.Drawing.Size(85, 20)
        Me.lnkWebsite.TabIndex = 8
        Me.lnkWebsite.TabStop = True
        Me.lnkWebsite.Text = "Visit my website!"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.Location = New System.Drawing.Point(510, 115)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(91, 17)
        Me.LinkLabel1.TabIndex = 9
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Timer"
        Me.LinkLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LinkLabel2
        '
        Me.LinkLabel2.Location = New System.Drawing.Point(510, 129)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(91, 17)
        Me.LinkLabel2.TabIndex = 10
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Stopwatch"
        Me.LinkLabel2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(507, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Independent Tabs"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'AlarmClockDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(604, 265)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.lnkWebsite)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBoxStopwatch)
        Me.Controls.Add(Me.GroupBoxAlarm2)
        Me.Controls.Add(Me.GroupBoxAlarm1)
        Me.Controls.Add(Me.lblTimeDisplay)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "AlarmClockDashboard"
        Me.Text = "The Ultra Clock (by MrTheUnknown)"
        Me.GroupBoxAlarm1.ResumeLayout(False)
        Me.GroupBoxAlarm1.PerformLayout()
        CType(Me.udMINAlarm1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.udHRAlarm1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxAlarm2.ResumeLayout(False)
        Me.GroupBoxAlarm2.PerformLayout()
        CType(Me.udMINAlarm2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.udHRAlarm2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxStopwatch.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.udSECTimer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.udMinTimer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.udHRTimer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TimeDetector As Timer
    Friend WithEvents lblTimeDisplay As Label
    Friend WithEvents GroupBoxAlarm1 As GroupBox
    Friend WithEvents txtAlarm1Name As TextBox
    Friend WithEvents dtpAlarm1 As DateTimePicker
    Friend WithEvents udMINAlarm1 As NumericUpDown
    Friend WithEvents udHRAlarm1 As NumericUpDown
    Friend WithEvents btnAlarm1Enable As Button
    Friend WithEvents GroupBoxAlarm2 As GroupBox
    Friend WithEvents btnAlarm2Enable As Button
    Friend WithEvents udMINAlarm2 As NumericUpDown
    Friend WithEvents udHRAlarm2 As NumericUpDown
    Friend WithEvents dtpAlarm2 As DateTimePicker
    Friend WithEvents txtAlarm2Name As TextBox
    Friend WithEvents StopwatchTimer As Timer
    Friend WithEvents GroupBoxStopwatch As GroupBox
    Friend WithEvents btnResetStopW As Button
    Friend WithEvents btnStopStopW As Button
    Friend WithEvents btnStartStopW As Button
    Friend WithEvents lblStopwatch As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnPauseContinueTimer As Button
    Friend WithEvents btnStartTimer As Button
    Friend WithEvents udSECTimer As NumericUpDown
    Friend WithEvents udMinTimer As NumericUpDown
    Friend WithEvents udHRTimer As NumericUpDown
    Friend WithEvents btnResetTimer As Button
    Friend WithEvents Timer As Timer
    Friend WithEvents lblTimer As Label
    Friend WithEvents lnkWebsite As LinkLabel
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents Label1 As Label
End Class
