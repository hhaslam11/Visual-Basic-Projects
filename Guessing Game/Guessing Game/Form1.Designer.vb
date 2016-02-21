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
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtGuessedNum = New System.Windows.Forms.TextBox
        Me.btnRightOrWrong = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(64, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 40)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Guess a number " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "between 1 and 100"
        '
        'txtGuessedNum
        '
        Me.txtGuessedNum.Location = New System.Drawing.Point(89, 112)
        Me.txtGuessedNum.Name = "txtGuessedNum"
        Me.txtGuessedNum.Size = New System.Drawing.Size(100, 20)
        Me.txtGuessedNum.TabIndex = 1
        '
        'btnRightOrWrong
        '
        Me.btnRightOrWrong.Location = New System.Drawing.Point(103, 167)
        Me.btnRightOrWrong.Name = "btnRightOrWrong"
        Me.btnRightOrWrong.Size = New System.Drawing.Size(75, 23)
        Me.btnRightOrWrong.TabIndex = 2
        Me.btnRightOrWrong.Text = "Am I right?"
        Me.btnRightOrWrong.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 225)
        Me.Controls.Add(Me.btnRightOrWrong)
        Me.Controls.Add(Me.txtGuessedNum)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Guessing Game"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtGuessedNum As System.Windows.Forms.TextBox
    Friend WithEvents btnRightOrWrong As System.Windows.Forms.Button

End Class
