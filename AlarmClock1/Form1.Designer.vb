<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnAlarm1Enable = New System.Windows.Forms.Button()
        Me.udMINAlarm1 = New System.Windows.Forms.NumericUpDown()
        Me.udHRAlarm1 = New System.Windows.Forms.NumericUpDown()
        Me.dtpAlarm1 = New System.Windows.Forms.DateTimePicker()
        Me.txtAlarm1Name = New System.Windows.Forms.TextBox()
        Me.lblTimeDisplay = New System.Windows.Forms.Label()
        Me.TimeDetector = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.udMINAlarm1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.udHRAlarm1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.btnAlarm1Enable)
        Me.GroupBox1.Controls.Add(Me.udMINAlarm1)
        Me.GroupBox1.Controls.Add(Me.udHRAlarm1)
        Me.GroupBox1.Controls.Add(Me.dtpAlarm1)
        Me.GroupBox1.Controls.Add(Me.txtAlarm1Name)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 11)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(118, 313)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Alarm 1 Properties"
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
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(600, 337)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblTimeDisplay)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.udMINAlarm1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.udHRAlarm1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TimeDetector As Timer
    Friend WithEvents lblTimeDisplay As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtAlarm1Name As TextBox
    Friend WithEvents dtpAlarm1 As DateTimePicker
    Friend WithEvents udMINAlarm1 As NumericUpDown
    Friend WithEvents udHRAlarm1 As NumericUpDown
    Friend WithEvents btnAlarm1Enable As Button
End Class
