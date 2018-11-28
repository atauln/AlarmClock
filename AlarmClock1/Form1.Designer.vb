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
        Me.Timer1Stopwatch = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBoxStopwatch = New System.Windows.Forms.GroupBox()
        Me.btnResetStopW = New System.Windows.Forms.Button()
        Me.btnStopStopW = New System.Windows.Forms.Button()
        Me.btnStartStopW = New System.Windows.Forms.Button()
        Me.lblStopwatch = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnResetTimer = New System.Windows.Forms.Button()
        Me.btnPauseContinueTimer = New System.Windows.Forms.Button()
        Me.btnStartTimer = New System.Windows.Forms.Button()
        Me.udSECTimer = New System.Windows.Forms.NumericUpDown()
        Me.udMinTimer = New System.Windows.Forms.NumericUpDown()
        Me.udHRTimer = New System.Windows.Forms.NumericUpDown()
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
        Me.GroupBoxAlarm1.Location = New System.Drawing.Point(15, 14)
        Me.GroupBoxAlarm1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBoxAlarm1.Name = "GroupBoxAlarm1"
        Me.GroupBoxAlarm1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBoxAlarm1.Size = New System.Drawing.Size(157, 300)
        Me.GroupBoxAlarm1.TabIndex = 1
        Me.GroupBoxAlarm1.TabStop = False
        Me.GroupBoxAlarm1.Text = "Alarm 1 Properties"
        '
        'btnAlarm1Enable
        '
        Me.btnAlarm1Enable.BackColor = System.Drawing.Color.Red
        Me.btnAlarm1Enable.Location = New System.Drawing.Point(20, 142)
        Me.btnAlarm1Enable.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAlarm1Enable.Name = "btnAlarm1Enable"
        Me.btnAlarm1Enable.Size = New System.Drawing.Size(119, 150)
        Me.btnAlarm1Enable.TabIndex = 4
        Me.btnAlarm1Enable.Text = "Disabled"
        Me.btnAlarm1Enable.UseVisualStyleBackColor = False
        '
        'udMINAlarm1
        '
        Me.udMINAlarm1.Location = New System.Drawing.Point(20, 111)
        Me.udMINAlarm1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.udMINAlarm1.Name = "udMINAlarm1"
        Me.udMINAlarm1.Size = New System.Drawing.Size(120, 22)
        Me.udMINAlarm1.TabIndex = 2
        '
        'udHRAlarm1
        '
        Me.udHRAlarm1.Location = New System.Drawing.Point(20, 82)
        Me.udHRAlarm1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.udHRAlarm1.Name = "udHRAlarm1"
        Me.udHRAlarm1.Size = New System.Drawing.Size(120, 22)
        Me.udHRAlarm1.TabIndex = 3
        '
        'dtpAlarm1
        '
        Me.dtpAlarm1.CustomFormat = "'MM'/'dd'/'yyyy'"
        Me.dtpAlarm1.Location = New System.Drawing.Point(20, 52)
        Me.dtpAlarm1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtpAlarm1.Name = "dtpAlarm1"
        Me.dtpAlarm1.Size = New System.Drawing.Size(121, 22)
        Me.dtpAlarm1.TabIndex = 1
        '
        'txtAlarm1Name
        '
        Me.txtAlarm1Name.Location = New System.Drawing.Point(20, 21)
        Me.txtAlarm1Name.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAlarm1Name.Name = "txtAlarm1Name"
        Me.txtAlarm1Name.Size = New System.Drawing.Size(121, 22)
        Me.txtAlarm1Name.TabIndex = 0
        Me.txtAlarm1Name.Text = "Alarm Name"
        '
        'lblTimeDisplay
        '
        Me.lblTimeDisplay.Location = New System.Drawing.Point(651, 9)
        Me.lblTimeDisplay.Name = "lblTimeDisplay"
        Me.lblTimeDisplay.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblTimeDisplay.Size = New System.Drawing.Size(143, 22)
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
        Me.GroupBoxAlarm2.Location = New System.Drawing.Point(177, 14)
        Me.GroupBoxAlarm2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBoxAlarm2.Name = "GroupBoxAlarm2"
        Me.GroupBoxAlarm2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBoxAlarm2.Size = New System.Drawing.Size(157, 300)
        Me.GroupBoxAlarm2.TabIndex = 5
        Me.GroupBoxAlarm2.TabStop = False
        Me.GroupBoxAlarm2.Text = "Alarm 2 Properties"
        '
        'btnAlarm2Enable
        '
        Me.btnAlarm2Enable.BackColor = System.Drawing.Color.Red
        Me.btnAlarm2Enable.Location = New System.Drawing.Point(20, 142)
        Me.btnAlarm2Enable.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAlarm2Enable.Name = "btnAlarm2Enable"
        Me.btnAlarm2Enable.Size = New System.Drawing.Size(119, 150)
        Me.btnAlarm2Enable.TabIndex = 4
        Me.btnAlarm2Enable.Text = "Disabled"
        Me.btnAlarm2Enable.UseVisualStyleBackColor = False
        '
        'udMINAlarm2
        '
        Me.udMINAlarm2.Location = New System.Drawing.Point(20, 111)
        Me.udMINAlarm2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.udMINAlarm2.Name = "udMINAlarm2"
        Me.udMINAlarm2.Size = New System.Drawing.Size(120, 22)
        Me.udMINAlarm2.TabIndex = 2
        '
        'udHRAlarm2
        '
        Me.udHRAlarm2.Location = New System.Drawing.Point(20, 82)
        Me.udHRAlarm2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.udHRAlarm2.Name = "udHRAlarm2"
        Me.udHRAlarm2.Size = New System.Drawing.Size(120, 22)
        Me.udHRAlarm2.TabIndex = 3
        '
        'dtpAlarm2
        '
        Me.dtpAlarm2.CustomFormat = "'MM'/'dd'/'yyyy'"
        Me.dtpAlarm2.Location = New System.Drawing.Point(20, 52)
        Me.dtpAlarm2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtpAlarm2.Name = "dtpAlarm2"
        Me.dtpAlarm2.Size = New System.Drawing.Size(121, 22)
        Me.dtpAlarm2.TabIndex = 1
        '
        'txtAlarm2Name
        '
        Me.txtAlarm2Name.Location = New System.Drawing.Point(20, 21)
        Me.txtAlarm2Name.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAlarm2Name.Name = "txtAlarm2Name"
        Me.txtAlarm2Name.Size = New System.Drawing.Size(121, 22)
        Me.txtAlarm2Name.TabIndex = 0
        Me.txtAlarm2Name.Text = "Alarm Name"
        '
        'Timer1Stopwatch
        '
        '
        'GroupBoxStopwatch
        '
        Me.GroupBoxStopwatch.BackColor = System.Drawing.Color.White
        Me.GroupBoxStopwatch.Controls.Add(Me.btnResetStopW)
        Me.GroupBoxStopwatch.Controls.Add(Me.btnStopStopW)
        Me.GroupBoxStopwatch.Controls.Add(Me.btnStartStopW)
        Me.GroupBoxStopwatch.Controls.Add(Me.lblStopwatch)
        Me.GroupBoxStopwatch.Location = New System.Drawing.Point(340, 14)
        Me.GroupBoxStopwatch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBoxStopwatch.Name = "GroupBoxStopwatch"
        Me.GroupBoxStopwatch.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBoxStopwatch.Size = New System.Drawing.Size(157, 300)
        Me.GroupBoxStopwatch.TabIndex = 6
        Me.GroupBoxStopwatch.TabStop = False
        Me.GroupBoxStopwatch.Text = "Stopwatch"
        '
        'btnResetStopW
        '
        Me.btnResetStopW.BackColor = System.Drawing.Color.Red
        Me.btnResetStopW.Location = New System.Drawing.Point(5, 227)
        Me.btnResetStopW.Margin = New System.Windows.Forms.Padding(4)
        Me.btnResetStopW.Name = "btnResetStopW"
        Me.btnResetStopW.Size = New System.Drawing.Size(144, 62)
        Me.btnResetStopW.TabIndex = 3
        Me.btnResetStopW.Text = "RESET"
        Me.btnResetStopW.UseVisualStyleBackColor = False
        '
        'btnStopStopW
        '
        Me.btnStopStopW.BackColor = System.Drawing.Color.Red
        Me.btnStopStopW.Location = New System.Drawing.Point(7, 159)
        Me.btnStopStopW.Margin = New System.Windows.Forms.Padding(4)
        Me.btnStopStopW.Name = "btnStopStopW"
        Me.btnStopStopW.Size = New System.Drawing.Size(144, 62)
        Me.btnStopStopW.TabIndex = 2
        Me.btnStopStopW.Text = "STOP"
        Me.btnStopStopW.UseVisualStyleBackColor = False
        '
        'btnStartStopW
        '
        Me.btnStartStopW.BackColor = System.Drawing.Color.Lime
        Me.btnStartStopW.Location = New System.Drawing.Point(7, 90)
        Me.btnStartStopW.Margin = New System.Windows.Forms.Padding(4)
        Me.btnStartStopW.Name = "btnStartStopW"
        Me.btnStartStopW.Size = New System.Drawing.Size(144, 62)
        Me.btnStartStopW.TabIndex = 1
        Me.btnStartStopW.Text = "START"
        Me.btnStartStopW.UseVisualStyleBackColor = False
        '
        'lblStopwatch
        '
        Me.lblStopwatch.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStopwatch.Location = New System.Drawing.Point(7, 18)
        Me.lblStopwatch.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStopwatch.Name = "lblStopwatch"
        Me.lblStopwatch.Size = New System.Drawing.Size(144, 81)
        Me.lblStopwatch.TabIndex = 0
        Me.lblStopwatch.Text = "0.00s"
        Me.lblStopwatch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.btnResetTimer)
        Me.GroupBox1.Controls.Add(Me.btnPauseContinueTimer)
        Me.GroupBox1.Controls.Add(Me.btnStartTimer)
        Me.GroupBox1.Controls.Add(Me.udSECTimer)
        Me.GroupBox1.Controls.Add(Me.udMinTimer)
        Me.GroupBox1.Controls.Add(Me.udHRTimer)
        Me.GroupBox1.Location = New System.Drawing.Point(503, 14)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(157, 300)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Timer"
        '
        'btnResetTimer
        '
        Me.btnResetTimer.BackColor = System.Drawing.Color.Red
        Me.btnResetTimer.Location = New System.Drawing.Point(7, 244)
        Me.btnResetTimer.Margin = New System.Windows.Forms.Padding(4)
        Me.btnResetTimer.Name = "btnResetTimer"
        Me.btnResetTimer.Size = New System.Drawing.Size(144, 43)
        Me.btnResetTimer.TabIndex = 7
        Me.btnResetTimer.Text = "RESET"
        Me.btnResetTimer.UseVisualStyleBackColor = False
        '
        'btnPauseContinueTimer
        '
        Me.btnPauseContinueTimer.BackColor = System.Drawing.Color.Red
        Me.btnPauseContinueTimer.Location = New System.Drawing.Point(7, 193)
        Me.btnPauseContinueTimer.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPauseContinueTimer.Name = "btnPauseContinueTimer"
        Me.btnPauseContinueTimer.Size = New System.Drawing.Size(144, 43)
        Me.btnPauseContinueTimer.TabIndex = 6
        Me.btnPauseContinueTimer.Text = "PAUSE"
        Me.btnPauseContinueTimer.UseVisualStyleBackColor = False
        '
        'btnStartTimer
        '
        Me.btnStartTimer.BackColor = System.Drawing.Color.Lime
        Me.btnStartTimer.Location = New System.Drawing.Point(6, 142)
        Me.btnStartTimer.Margin = New System.Windows.Forms.Padding(4)
        Me.btnStartTimer.Name = "btnStartTimer"
        Me.btnStartTimer.Size = New System.Drawing.Size(144, 43)
        Me.btnStartTimer.TabIndex = 5
        Me.btnStartTimer.Text = "START"
        Me.btnStartTimer.UseVisualStyleBackColor = False
        '
        'udSECTimer
        '
        Me.udSECTimer.Location = New System.Drawing.Point(18, 108)
        Me.udSECTimer.Name = "udSECTimer"
        Me.udSECTimer.Size = New System.Drawing.Size(120, 22)
        Me.udSECTimer.TabIndex = 2
        '
        'udMinTimer
        '
        Me.udMinTimer.Location = New System.Drawing.Point(18, 80)
        Me.udMinTimer.Name = "udMinTimer"
        Me.udMinTimer.Size = New System.Drawing.Size(120, 22)
        Me.udMinTimer.TabIndex = 1
        '
        'udHRTimer
        '
        Me.udHRTimer.Location = New System.Drawing.Point(18, 52)
        Me.udHRTimer.Name = "udHRTimer"
        Me.udHRTimer.Size = New System.Drawing.Size(120, 22)
        Me.udHRTimer.TabIndex = 0
        '
        'AlarmClockDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(806, 326)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBoxStopwatch)
        Me.Controls.Add(Me.GroupBoxAlarm2)
        Me.Controls.Add(Me.GroupBoxAlarm1)
        Me.Controls.Add(Me.lblTimeDisplay)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
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
    Friend WithEvents Timer1Stopwatch As Timer
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
End Class
