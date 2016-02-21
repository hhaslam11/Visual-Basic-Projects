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
        Me.txtInput = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtOutput = New System.Windows.Forms.TextBox
        Me.btnCalc = New System.Windows.Forms.Button
        Me.rbtnSun = New System.Windows.Forms.RadioButton
        Me.rbtnMoon = New System.Windows.Forms.RadioButton
        Me.rbtnVenus = New System.Windows.Forms.RadioButton
        Me.rbtnSaturn = New System.Windows.Forms.RadioButton
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(46, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 38)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "This program will calculate your" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "weight on various planets."
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(141, 70)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(37, 20)
        Me.txtInput.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Weight"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbtnSaturn)
        Me.GroupBox1.Controls.Add(Me.rbtnVenus)
        Me.GroupBox1.Controls.Add(Me.rbtnMoon)
        Me.GroupBox1.Controls.Add(Me.rbtnSun)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(60, 121)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(149, 126)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = """Planet"""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 272)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Planetary Weight"
        '
        'txtOutput
        '
        Me.txtOutput.Location = New System.Drawing.Point(141, 272)
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.ReadOnly = True
        Me.txtOutput.Size = New System.Drawing.Size(37, 20)
        Me.txtOutput.TabIndex = 4
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(39, 318)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(175, 43)
        Me.btnCalc.TabIndex = 6
        Me.btnCalc.Text = "Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'rbtnSun
        '
        Me.rbtnSun.AutoSize = True
        Me.rbtnSun.Location = New System.Drawing.Point(7, 30)
        Me.rbtnSun.Name = "rbtnSun"
        Me.rbtnSun.Size = New System.Drawing.Size(44, 17)
        Me.rbtnSun.TabIndex = 0
        Me.rbtnSun.TabStop = True
        Me.rbtnSun.Text = "Sun"
        Me.rbtnSun.UseVisualStyleBackColor = True
        '
        'rbtnMoon
        '
        Me.rbtnMoon.AutoSize = True
        Me.rbtnMoon.Location = New System.Drawing.Point(6, 53)
        Me.rbtnMoon.Name = "rbtnMoon"
        Me.rbtnMoon.Size = New System.Drawing.Size(52, 17)
        Me.rbtnMoon.TabIndex = 1
        Me.rbtnMoon.TabStop = True
        Me.rbtnMoon.Text = "Moon"
        Me.rbtnMoon.UseVisualStyleBackColor = True
        '
        'rbtnVenus
        '
        Me.rbtnVenus.AutoSize = True
        Me.rbtnVenus.Location = New System.Drawing.Point(6, 76)
        Me.rbtnVenus.Name = "rbtnVenus"
        Me.rbtnVenus.Size = New System.Drawing.Size(55, 17)
        Me.rbtnVenus.TabIndex = 2
        Me.rbtnVenus.TabStop = True
        Me.rbtnVenus.Text = "Venus"
        Me.rbtnVenus.UseVisualStyleBackColor = True
        '
        'rbtnSaturn
        '
        Me.rbtnSaturn.AutoSize = True
        Me.rbtnSaturn.Location = New System.Drawing.Point(6, 99)
        Me.rbtnSaturn.Name = "rbtnSaturn"
        Me.rbtnSaturn.Size = New System.Drawing.Size(56, 17)
        Me.rbtnSaturn.TabIndex = 3
        Me.rbtnSaturn.TabStop = True
        Me.rbtnSaturn.Text = "Saturn"
        Me.rbtnSaturn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(258, 382)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Planetary Weight"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtInput As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbtnVenus As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnMoon As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnSun As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtOutput As System.Windows.Forms.TextBox
    Friend WithEvents btnCalc As System.Windows.Forms.Button
    Friend WithEvents rbtnSaturn As System.Windows.Forms.RadioButton

End Class
