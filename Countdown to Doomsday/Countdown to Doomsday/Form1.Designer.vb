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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lblOutput = New System.Windows.Forms.Label
        Me.btnCount = New System.Windows.Forms.Button
        Me.picExplosion = New System.Windows.Forms.PictureBox
        CType(Me.picExplosion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblOutput
        '
        Me.lblOutput.AutoSize = True
        Me.lblOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 32.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutput.Location = New System.Drawing.Point(102, 65)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(72, 51)
        Me.lblOutput.TabIndex = 0
        Me.lblOutput.Text = "10"
        '
        'btnCount
        '
        Me.btnCount.Location = New System.Drawing.Point(105, 149)
        Me.btnCount.Name = "btnCount"
        Me.btnCount.Size = New System.Drawing.Size(75, 23)
        Me.btnCount.TabIndex = 1
        Me.btnCount.Text = "Count!"
        Me.btnCount.UseVisualStyleBackColor = True
        '
        'picExplosion
        '
        Me.picExplosion.Image = CType(resources.GetObject("picExplosion.Image"), System.Drawing.Image)
        Me.picExplosion.Location = New System.Drawing.Point(-3, 0)
        Me.picExplosion.Name = "picExplosion"
        Me.picExplosion.Size = New System.Drawing.Size(308, 236)
        Me.picExplosion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picExplosion.TabIndex = 2
        Me.picExplosion.TabStop = False
        Me.picExplosion.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(297, 231)
        Me.Controls.Add(Me.btnCount)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.picExplosion)
        Me.Name = "Form1"
        Me.Text = "Countdown to Doomsday!"
        CType(Me.picExplosion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblOutput As System.Windows.Forms.Label
    Friend WithEvents btnCount As System.Windows.Forms.Button
    Friend WithEvents picExplosion As System.Windows.Forms.PictureBox

End Class
