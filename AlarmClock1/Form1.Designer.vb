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
        Me.lblStopwatch = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.GroupBoxAlarm1.SuspendLayout()
        CType(Me.udMINAlarm1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.udHRAlarm1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxAlarm2.SuspendLayout()
        CType(Me.udMINAlarm2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.udHRAlarm2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxStopwatch.SuspendLayout()
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
        Me.GroupBoxAlarm1.Size = New System.Drawing.Size(118, 313)
        Me.GroupBoxAlarm1.TabIndex = 1
        Me.GroupBoxAlarm1.TabStop = False
        Me.GroupBoxAlarm1.Text = "Alarm 1 Properties"
        '
        'btnAlarm1Enable
        '
        Me.btnAlarm1Enable.BackColor = System.Drawing.Color.Red
        Me.btnAlarm1Enable.Location = New System.Drawing.Point(15, 175)
        Me.btnAlarm1Enable.Name = "btnAlarm1Enable"
        Me.btnAlarm1Enable.Size = New System.Drawing.Size(89, 122)
        Me.btnAlarm1Enable.TabIndex = 4
        Me.btnAlarm1Enable.Text = "Disabled"
        Me.btnAlarm1Enable.UseVisualStyleBackColor = False
        '
        'udMINAlarm1
        '
        Me.udMINAlarm1.Location = New System.Drawing.Point(15, 109)
        Me.udMINAlarm1.Margin = New System.Windows.Forms.Padding(2)
        Me.udMINAlarm1.Name = "udMINAlarm1"
        Me.udMINAlarm1.Size = New System.Drawing.Size(90, 20)
        Me.udMINAlarm1.TabIndex = 2
        '
        'udHRAlarm1
        '
        Me.udHRAlarm1.Location = New System.Drawing.Point(15, 85)
        Me.udHRAlarm1.Margin = New System.Windows.Forms.Padding(2)
        Me.udHRAlarm1.Name = "udHRAlarm1"
        Me.udHRAlarm1.Size = New System.Drawing.Size(90, 20)
        Me.udHRAlarm1.TabIndex = 3
        '
        'dtpAlarm1
        '
        Me.dtpAlarm1.CustomFormat = "'MM'/'dd'/'yyyy'"
        Me.dtpAlarm1.Location = New System.Drawing.Point(15, 61)
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
        Me.lblTimeDisplay.Location = New System.Drawing.Point(482, 9)
        Me.lblTimeDisplay.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTimeDisplay.Name = "lblTimeDisplay"
        Me.lblTimeDisplay.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblTimeDisplay.Size = New System.Drawing.Size(107, 18)
        Me.lblTimeDisplay.TabIndex = 0
        Me.lblTimeDisplay.Text = "Time updating..."
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
        Me.GroupBoxAlarm2.Size = New System.Drawing.Size(118, 313)
        Me.GroupBoxAlarm2.TabIndex = 5
        Me.GroupBoxAlarm2.TabStop = False
        Me.GroupBoxAlarm2.Text = "Alarm 2 Properties"
        '
        'btnAlarm2Enable
        '
        Me.btnAlarm2Enable.BackColor = System.Drawing.Color.Red
        Me.btnAlarm2Enable.Location = New System.Drawing.Point(15, 175)
        Me.btnAlarm2Enable.Name = "btnAlarm2Enable"
        Me.btnAlarm2Enable.Size = New System.Drawing.Size(89, 122)
        Me.btnAlarm2Enable.TabIndex = 4
        Me.btnAlarm2Enable.Text = "Disabled"
        Me.btnAlarm2Enable.UseVisualStyleBackColor = False
        '
        'udMINAlarm2
        '
        Me.udMINAlarm2.Location = New System.Drawing.Point(15, 109)
        Me.udMINAlarm2.Margin = New System.Windows.Forms.Padding(2)
        Me.udMINAlarm2.Name = "udMINAlarm2"
        Me.udMINAlarm2.Size = New System.Drawing.Size(90, 20)
        Me.udMINAlarm2.TabIndex = 2
        '
        'udHRAlarm2
        '
        Me.udHRAlarm2.Location = New System.Drawing.Point(15, 85)
        Me.udHRAlarm2.Margin = New System.Windows.Forms.Padding(2)
        Me.udHRAlarm2.Name = "udHRAlarm2"
        Me.udHRAlarm2.Size = New System.Drawing.Size(90, 20)
        Me.udHRAlarm2.TabIndex = 3
        '
        'dtpAlarm2
        '
        Me.dtpAlarm2.CustomFormat = "'MM'/'dd'/'yyyy'"
        Me.dtpAlarm2.Location = New System.Drawing.Point(15, 61)
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
        'Timer1Stopwatch
        '
        '
        'GroupBoxStopwatch
        '
        Me.GroupBoxStopwatch.BackColor = System.Drawing.Color.White
        Me.GroupBoxStopwatch.Controls.Add(Me.btnReset)
        Me.GroupBoxStopwatch.Controls.Add(Me.btnStop)
        Me.GroupBoxStopwatch.Controls.Add(Me.btnStart)
        Me.GroupBoxStopwatch.Controls.Add(Me.lblStopwatch)
        Me.GroupBoxStopwatch.Location = New System.Drawing.Point(255, 11)
        Me.GroupBoxStopwatch.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBoxStopwatch.Name = "GroupBoxStopwatch"
        Me.GroupBoxStopwatch.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBoxStopwatch.Size = New System.Drawing.Size(118, 313)
        Me.GroupBoxStopwatch.TabIndex = 6
        Me.GroupBoxStopwatch.TabStop = False
        Me.GroupBoxStopwatch.Text = "Stopwatch"
        '
        'lblStopwatch
        '
        Me.lblStopwatch.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStopwatch.Location = New System.Drawing.Point(5, 15)
        Me.lblStopwatch.Name = "lblStopwatch"
        Me.lblStopwatch.Size = New System.Drawing.Size(108, 66)
        Me.lblStopwatch.TabIndex = 0
        Me.lblStopwatch.Text = "0.00s"
        Me.lblStopwatch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.Color.Lime
        Me.btnStart.Location = New System.Drawing.Point(5, 85)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(108, 50)
        Me.btnStart.TabIndex = 1
        Me.btnStart.Text = "START"
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'btnStop
        '
        Me.btnStop.BackColor = System.Drawing.Color.Red
        Me.btnStop.Location = New System.Drawing.Point(5, 141)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(108, 50)
        Me.btnStop.TabIndex = 2
        Me.btnStop.Text = "STOP"
        Me.btnStop.UseVisualStyleBackColor = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.Red
        Me.btnReset.Location = New System.Drawing.Point(4, 197)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(108, 50)
        Me.btnReset.TabIndex = 3
        Me.btnReset.Text = "RESET"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'AlarmClockDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(600, 329)
        Me.Controls.Add(Me.GroupBoxStopwatch)
        Me.Controls.Add(Me.GroupBoxAlarm2)
        Me.Controls.Add(Me.GroupBoxAlarm1)
        Me.Controls.Add(Me.lblTimeDisplay)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
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
    Friend WithEvents btnReset As Button
    Friend WithEvents btnStop As Button
    Friend WithEvents btnStart As Button
    Friend WithEvents lblStopwatch As Label
End Class
