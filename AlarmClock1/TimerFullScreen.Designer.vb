<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TimerFullScreen
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
        Me.lblTimer = New System.Windows.Forms.Label()
        Me.btnResetTimer = New System.Windows.Forms.Button()
        Me.btnPauseContinueTimer = New System.Windows.Forms.Button()
        Me.btnStartTimer = New System.Windows.Forms.Button()
        Me.udSECTimer = New System.Windows.Forms.NumericUpDown()
        Me.udMinTimer = New System.Windows.Forms.NumericUpDown()
        Me.udHRTimer = New System.Windows.Forms.NumericUpDown()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.udSECTimer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.udMinTimer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.udHRTimer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.GroupBox1.Location = New System.Drawing.Point(86, 11)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(118, 244)
        Me.GroupBox1.TabIndex = 8
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
        'TimerFullScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(299, 262)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.Name = "TimerFullScreen"
        Me.Text = "Timer"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.udSECTimer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.udMinTimer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.udHRTimer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblTimer As Label
    Friend WithEvents btnResetTimer As Button
    Friend WithEvents btnPauseContinueTimer As Button
    Friend WithEvents btnStartTimer As Button
    Friend WithEvents udSECTimer As NumericUpDown
    Friend WithEvents udMinTimer As NumericUpDown
    Friend WithEvents udHRTimer As NumericUpDown
    Friend WithEvents Timer As Timer
End Class
