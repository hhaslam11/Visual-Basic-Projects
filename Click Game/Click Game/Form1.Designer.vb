<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClickRaceGame
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
        Me.components = New System.ComponentModel.Container
        Me.btnStartGame = New System.Windows.Forms.Button
        Me.btnExitGame = New System.Windows.Forms.Button
        Me.btnClickMe1 = New System.Windows.Forms.Button
        Me.btnClickMe2 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtRemainingTime = New System.Windows.Forms.TextBox
        Me.txtOutput = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'btnStartGame
        '
        Me.btnStartGame.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStartGame.Location = New System.Drawing.Point(36, 55)
        Me.btnStartGame.Name = "btnStartGame"
        Me.btnStartGame.Size = New System.Drawing.Size(75, 23)
        Me.btnStartGame.TabIndex = 0
        Me.btnStartGame.Text = "Start Game"
        Me.btnStartGame.UseVisualStyleBackColor = True
        '
        'btnExitGame
        '
        Me.btnExitGame.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExitGame.Location = New System.Drawing.Point(36, 108)
        Me.btnExitGame.Name = "btnExitGame"
        Me.btnExitGame.Size = New System.Drawing.Size(75, 23)
        Me.btnExitGame.TabIndex = 1
        Me.btnExitGame.Text = "Exit Game"
        Me.btnExitGame.UseVisualStyleBackColor = True
        '
        'btnClickMe1
        '
        Me.btnClickMe1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClickMe1.Location = New System.Drawing.Point(165, 152)
        Me.btnClickMe1.Name = "btnClickMe1"
        Me.btnClickMe1.Size = New System.Drawing.Size(101, 45)
        Me.btnClickMe1.TabIndex = 2
        Me.btnClickMe1.Text = "Click Me!"
        Me.btnClickMe1.UseVisualStyleBackColor = True
        '
        'btnClickMe2
        '
        Me.btnClickMe2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClickMe2.Location = New System.Drawing.Point(317, 152)
        Me.btnClickMe2.Name = "btnClickMe2"
        Me.btnClickMe2.Size = New System.Drawing.Size(114, 45)
        Me.btnClickMe2.TabIndex = 3
        Me.btnClickMe2.Text = "Click Me!"
        Me.btnClickMe2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(71, 259)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Number Of Clicks"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(412, 259)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Remaining Time"
        '
        'txtRemainingTime
        '
        Me.txtRemainingTime.Location = New System.Drawing.Point(415, 303)
        Me.txtRemainingTime.Name = "txtRemainingTime"
        Me.txtRemainingTime.ReadOnly = True
        Me.txtRemainingTime.Size = New System.Drawing.Size(100, 20)
        Me.txtRemainingTime.TabIndex = 6
        '
        'txtOutput
        '
        Me.txtOutput.Location = New System.Drawing.Point(74, 303)
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.ReadOnly = True
        Me.txtOutput.Size = New System.Drawing.Size(100, 20)
        Me.txtOutput.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(237, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(160, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Click Game - Kaleb Haslam"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'frmClickRaceGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(599, 410)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.txtRemainingTime)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnClickMe2)
        Me.Controls.Add(Me.btnClickMe1)
        Me.Controls.Add(Me.btnExitGame)
        Me.Controls.Add(Me.btnStartGame)
        Me.Name = "frmClickRaceGame"
        Me.Text = "Click Race Game"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnStartGame As System.Windows.Forms.Button
    Friend WithEvents btnExitGame As System.Windows.Forms.Button
    Friend WithEvents btnClickMe1 As System.Windows.Forms.Button
    Friend WithEvents btnClickMe2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtRemainingTime As System.Windows.Forms.TextBox
    Friend WithEvents txtOutput As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
