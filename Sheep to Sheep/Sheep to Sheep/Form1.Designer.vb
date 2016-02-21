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
        Me.lblOutput = New System.Windows.Forms.Label
        Me.btnCount = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lblOutput
        '
        Me.lblOutput.Location = New System.Drawing.Point(28, 77)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(173, 209)
        Me.lblOutput.TabIndex = 0
        '
        'btnCount
        '
        Me.btnCount.Location = New System.Drawing.Point(76, 31)
        Me.btnCount.Name = "btnCount"
        Me.btnCount.Size = New System.Drawing.Size(75, 23)
        Me.btnCount.TabIndex = 1
        Me.btnCount.Text = "Count!"
        Me.btnCount.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(230, 309)
        Me.Controls.Add(Me.btnCount)
        Me.Controls.Add(Me.lblOutput)
        Me.Name = "Form1"
        Me.Text = "Sheep to Sheep"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblOutput As System.Windows.Forms.Label
    Friend WithEvents btnCount As System.Windows.Forms.Button

End Class
