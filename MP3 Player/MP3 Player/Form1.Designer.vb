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
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer
        Me.rbtnSong1 = New System.Windows.Forms.RadioButton
        Me.rbtnSong2 = New System.Windows.Forms.RadioButton
        Me.rbtnSong3 = New System.Windows.Forms.RadioButton
        Me.rbtnSong4 = New System.Windows.Forms.RadioButton
        Me.btnPlay = New System.Windows.Forms.Button
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(56, 104)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(71, 23)
        Me.AxWindowsMediaPlayer1.TabIndex = 0
        Me.AxWindowsMediaPlayer1.Visible = False
        '
        'rbtnSong1
        '
        Me.rbtnSong1.AutoSize = True
        Me.rbtnSong1.Location = New System.Drawing.Point(52, 12)
        Me.rbtnSong1.Name = "rbtnSong1"
        Me.rbtnSong1.Size = New System.Drawing.Size(137, 17)
        Me.rbtnSong1.TabIndex = 1
        Me.rbtnSong1.TabStop = True
        Me.rbtnSong1.Text = "AC\DC - Thunderstruck"
        Me.rbtnSong1.UseVisualStyleBackColor = True
        '
        'rbtnSong2
        '
        Me.rbtnSong2.AutoSize = True
        Me.rbtnSong2.Location = New System.Drawing.Point(52, 35)
        Me.rbtnSong2.Name = "rbtnSong2"
        Me.rbtnSong2.Size = New System.Drawing.Size(137, 17)
        Me.rbtnSong2.TabIndex = 2
        Me.rbtnSong2.TabStop = True
        Me.rbtnSong2.Text = "AC\DC - Shoot To Thrill"
        Me.rbtnSong2.UseVisualStyleBackColor = True
        '
        'rbtnSong3
        '
        Me.rbtnSong3.AutoSize = True
        Me.rbtnSong3.Location = New System.Drawing.Point(52, 58)
        Me.rbtnSong3.Name = "rbtnSong3"
        Me.rbtnSong3.Size = New System.Drawing.Size(132, 17)
        Me.rbtnSong3.TabIndex = 3
        Me.rbtnSong3.TabStop = True
        Me.rbtnSong3.Text = "Bob Marley - Bad Boys"
        Me.rbtnSong3.UseVisualStyleBackColor = True
        '
        'rbtnSong4
        '
        Me.rbtnSong4.AutoSize = True
        Me.rbtnSong4.Location = New System.Drawing.Point(52, 81)
        Me.rbtnSong4.Name = "rbtnSong4"
        Me.rbtnSong4.Size = New System.Drawing.Size(131, 17)
        Me.rbtnSong4.TabIndex = 4
        Me.rbtnSong4.TabStop = True
        Me.rbtnSong4.Text = "Volbeat - Still Counting"
        Me.rbtnSong4.UseVisualStyleBackColor = True
        '
        'btnPlay
        '
        Me.btnPlay.Location = New System.Drawing.Point(52, 130)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(75, 23)
        Me.btnPlay.TabIndex = 5
        Me.btnPlay.Text = "Play Song!"
        Me.btnPlay.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(229, 159)
        Me.Controls.Add(Me.btnPlay)
        Me.Controls.Add(Me.rbtnSong4)
        Me.Controls.Add(Me.rbtnSong3)
        Me.Controls.Add(Me.rbtnSong2)
        Me.Controls.Add(Me.rbtnSong1)
        Me.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.Name = "Form1"
        Me.Text = "MP3 Player"
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents rbtnSong1 As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnSong2 As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnSong3 As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnSong4 As System.Windows.Forms.RadioButton
    Friend WithEvents btnPlay As System.Windows.Forms.Button

End Class
