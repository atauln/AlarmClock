<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StopwatchIndTab
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
        Me.GroupBoxStopwatch = New System.Windows.Forms.GroupBox()
        Me.btnResetStopW = New System.Windows.Forms.Button()
        Me.btnStopStopW = New System.Windows.Forms.Button()
        Me.btnStartStopW = New System.Windows.Forms.Button()
        Me.lblStopwatch = New System.Windows.Forms.Label()
        Me.StopwatchTimer = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBoxStopwatch.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBoxStopwatch
        '
        Me.GroupBoxStopwatch.BackColor = System.Drawing.Color.White
        Me.GroupBoxStopwatch.Controls.Add(Me.btnResetStopW)
        Me.GroupBoxStopwatch.Controls.Add(Me.btnStopStopW)
        Me.GroupBoxStopwatch.Controls.Add(Me.btnStartStopW)
        Me.GroupBoxStopwatch.Controls.Add(Me.lblStopwatch)
        Me.GroupBoxStopwatch.Location = New System.Drawing.Point(90, 9)
        Me.GroupBoxStopwatch.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBoxStopwatch.Name = "GroupBoxStopwatch"
        Me.GroupBoxStopwatch.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBoxStopwatch.Size = New System.Drawing.Size(118, 244)
        Me.GroupBoxStopwatch.TabIndex = 7
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
        'StopwatchTimer
        '
        '
        'StopwatchIndTab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(299, 261)
        Me.Controls.Add(Me.GroupBoxStopwatch)
        Me.Name = "StopwatchIndTab"
        Me.Text = "StopwatchIndTab"
        Me.GroupBoxStopwatch.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBoxStopwatch As GroupBox
    Friend WithEvents btnResetStopW As Button
    Friend WithEvents btnStopStopW As Button
    Friend WithEvents btnStartStopW As Button
    Friend WithEvents lblStopwatch As Label
    Friend WithEvents StopwatchTimer As Timer
End Class
