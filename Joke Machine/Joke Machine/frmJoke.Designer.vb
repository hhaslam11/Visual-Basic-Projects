<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmJoke
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
        Me.btnJoke1 = New System.Windows.Forms.Button
        Me.btnJoke2 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtOutPut = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'btnJoke1
        '
        Me.btnJoke1.Location = New System.Drawing.Point(54, 179)
        Me.btnJoke1.Name = "btnJoke1"
        Me.btnJoke1.Size = New System.Drawing.Size(75, 23)
        Me.btnJoke1.TabIndex = 0
        Me.btnJoke1.Text = "Joke 1"
        Me.btnJoke1.UseVisualStyleBackColor = True
        '
        'btnJoke2
        '
        Me.btnJoke2.Location = New System.Drawing.Point(291, 179)
        Me.btnJoke2.Name = "btnJoke2"
        Me.btnJoke2.Size = New System.Drawing.Size(75, 23)
        Me.btnJoke2.TabIndex = 1
        Me.btnJoke2.Text = "Joke 2"
        Me.btnJoke2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(126, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(172, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Joke Machine - Kaleb Haslam"
        '
        'txtOutPut
        '
        Me.txtOutPut.Location = New System.Drawing.Point(54, 79)
        Me.txtOutPut.Multiline = True
        Me.txtOutPut.Name = "txtOutPut"
        Me.txtOutPut.ReadOnly = True
        Me.txtOutPut.Size = New System.Drawing.Size(312, 64)
        Me.txtOutPut.TabIndex = 3
        '
        'frmJoke
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(432, 248)
        Me.Controls.Add(Me.txtOutPut)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnJoke2)
        Me.Controls.Add(Me.btnJoke1)
        Me.Name = "frmJoke"
        Me.Text = "Joke Machine"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnJoke1 As System.Windows.Forms.Button
    Friend WithEvents btnJoke2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtOutPut As System.Windows.Forms.TextBox

End Class
