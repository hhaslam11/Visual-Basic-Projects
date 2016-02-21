<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSpeedTypingGame
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtDisplay = New System.Windows.Forms.TextBox
        Me.txtEntry = New System.Windows.Forms.TextBox
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnGo = New System.Windows.Forms.Button
        Me.btnDone = New System.Windows.Forms.Button
        Me.stbControl = New System.Windows.Forms.StatusStrip
        Me.tmrControl = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(421, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Instructions: Click on Go to begin. You will have 15 seconds to type the text dis" & _
            "played in" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "the Source Field text into the Enter Text Here field. Do so exactly a" & _
            "s shown!"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(49, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Source Text:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(49, 250)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Enter Text Here:"
        '
        'txtDisplay
        '
        Me.txtDisplay.Location = New System.Drawing.Point(52, 110)
        Me.txtDisplay.Multiline = True
        Me.txtDisplay.Name = "txtDisplay"
        Me.txtDisplay.ReadOnly = True
        Me.txtDisplay.Size = New System.Drawing.Size(531, 108)
        Me.txtDisplay.TabIndex = 3
        '
        'txtEntry
        '
        Me.txtEntry.Location = New System.Drawing.Point(52, 266)
        Me.txtEntry.Multiline = True
        Me.txtEntry.Name = "txtEntry"
        Me.txtEntry.ReadOnly = True
        Me.txtEntry.Size = New System.Drawing.Size(531, 108)
        Me.txtEntry.TabIndex = 4
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(508, 18)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnGo
        '
        Me.btnGo.Location = New System.Drawing.Point(52, 416)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(75, 23)
        Me.btnGo.TabIndex = 6
        Me.btnGo.Text = "&Go"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'btnDone
        '
        Me.btnDone.Location = New System.Drawing.Point(508, 416)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(75, 23)
        Me.btnDone.TabIndex = 7
        Me.btnDone.Text = "&Done"
        Me.btnDone.UseVisualStyleBackColor = True
        '
        'stbControl
        '
        Me.stbControl.Location = New System.Drawing.Point(0, 456)
        Me.stbControl.Name = "stbControl"
        Me.stbControl.Size = New System.Drawing.Size(618, 22)
        Me.stbControl.TabIndex = 8
        Me.stbControl.Text = "Speed Typing"
        '
        'tmrControl
        '
        Me.tmrControl.Interval = 1000
        '
        'frmSpeedTypingGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(618, 478)
        Me.Controls.Add(Me.stbControl)
        Me.Controls.Add(Me.btnDone)
        Me.Controls.Add(Me.btnGo)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.txtEntry)
        Me.Controls.Add(Me.txtDisplay)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmSpeedTypingGame"
        Me.Text = "Speed Typing Game"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDisplay As System.Windows.Forms.TextBox
    Friend WithEvents txtEntry As System.Windows.Forms.TextBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnGo As System.Windows.Forms.Button
    Friend WithEvents btnDone As System.Windows.Forms.Button
    Friend WithEvents stbControl As System.Windows.Forms.StatusStrip
    Friend WithEvents tmrControl As System.Windows.Forms.Timer

End Class
