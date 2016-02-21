<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm1))
        Me.paddle = New System.Windows.Forms.PictureBox
        Me.blk15 = New System.Windows.Forms.PictureBox
        Me.blk8 = New System.Windows.Forms.PictureBox
        Me.blk29 = New System.Windows.Forms.PictureBox
        Me.btnStart = New System.Windows.Forms.Button
        Me.txtTime = New System.Windows.Forms.Label
        Me.blk9 = New System.Windows.Forms.PictureBox
        Me.blk10 = New System.Windows.Forms.PictureBox
        Me.blk11 = New System.Windows.Forms.PictureBox
        Me.blk12 = New System.Windows.Forms.PictureBox
        Me.blk13 = New System.Windows.Forms.PictureBox
        Me.blk14 = New System.Windows.Forms.PictureBox
        Me.blk16 = New System.Windows.Forms.PictureBox
        Me.blk17 = New System.Windows.Forms.PictureBox
        Me.blk18 = New System.Windows.Forms.PictureBox
        Me.blk19 = New System.Windows.Forms.PictureBox
        Me.blk20 = New System.Windows.Forms.PictureBox
        Me.blk21 = New System.Windows.Forms.PictureBox
        Me.blk28 = New System.Windows.Forms.PictureBox
        Me.blk27 = New System.Windows.Forms.PictureBox
        Me.blk26 = New System.Windows.Forms.PictureBox
        Me.blk25 = New System.Windows.Forms.PictureBox
        Me.blk24 = New System.Windows.Forms.PictureBox
        Me.blk23 = New System.Windows.Forms.PictureBox
        Me.blk22 = New System.Windows.Forms.PictureBox
        Me.blk7 = New System.Windows.Forms.PictureBox
        Me.blk6 = New System.Windows.Forms.PictureBox
        Me.blk5 = New System.Windows.Forms.PictureBox
        Me.blk4 = New System.Windows.Forms.PictureBox
        Me.blk3 = New System.Windows.Forms.PictureBox
        Me.blk2 = New System.Windows.Forms.PictureBox
        Me.blk1 = New System.Windows.Forms.PictureBox
        Me.blk30 = New System.Windows.Forms.PictureBox
        Me.blk31 = New System.Windows.Forms.PictureBox
        Me.blk34 = New System.Windows.Forms.PictureBox
        Me.blk33 = New System.Windows.Forms.PictureBox
        Me.blk32 = New System.Windows.Forms.PictureBox
        Me.blk35 = New System.Windows.Forms.PictureBox
        Me.imglBalls = New System.Windows.Forms.ImageList(Me.components)
        Me.imgBalls = New System.Windows.Forms.PictureBox
        CType(Me.paddle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.blk15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.blk8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.blk29, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.blk9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.blk10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.blk11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.blk12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.blk13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.blk14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.blk16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.blk17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.blk18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.blk19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.blk20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.blk21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.blk28, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.blk27, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.blk26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.blk25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.blk24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.blk23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.blk22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.blk7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.blk6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.blk5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.blk4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.blk3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.blk2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.blk1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.blk30, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.blk31, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.blk34, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.blk33, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.blk32, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.blk35, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgBalls, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'paddle
        '
        Me.paddle.Image = Global.Game.My.Resources.Resources.paddle
        resources.ApplyResources(Me.paddle, "paddle")
        Me.paddle.Name = "paddle"
        Me.paddle.TabStop = False
        '
        'blk15
        '
        Me.blk15.Image = Global.Game.My.Resources.Resources.blk_Red
        resources.ApplyResources(Me.blk15, "blk15")
        Me.blk15.Name = "blk15"
        Me.blk15.TabStop = False
        '
        'blk8
        '
        Me.blk8.Image = Global.Game.My.Resources.Resources.blk_Blue
        resources.ApplyResources(Me.blk8, "blk8")
        Me.blk8.Name = "blk8"
        Me.blk8.TabStop = False
        '
        'blk29
        '
        Me.blk29.Image = Global.Game.My.Resources.Resources.blk_Green
        resources.ApplyResources(Me.blk29, "blk29")
        Me.blk29.Name = "blk29"
        Me.blk29.TabStop = False
        '
        'btnStart
        '
        resources.ApplyResources(Me.btnStart, "btnStart")
        Me.btnStart.Name = "btnStart"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'txtTime
        '
        resources.ApplyResources(Me.txtTime, "txtTime")
        Me.txtTime.Name = "txtTime"
        '
        'blk9
        '
        Me.blk9.Image = Global.Game.My.Resources.Resources.blk_Blue
        resources.ApplyResources(Me.blk9, "blk9")
        Me.blk9.Name = "blk9"
        Me.blk9.TabStop = False
        '
        'blk10
        '
        Me.blk10.Image = Global.Game.My.Resources.Resources.blk_Blue
        resources.ApplyResources(Me.blk10, "blk10")
        Me.blk10.Name = "blk10"
        Me.blk10.TabStop = False
        '
        'blk11
        '
        Me.blk11.Image = Global.Game.My.Resources.Resources.blk_Blue
        resources.ApplyResources(Me.blk11, "blk11")
        Me.blk11.Name = "blk11"
        Me.blk11.TabStop = False
        '
        'blk12
        '
        Me.blk12.Image = Global.Game.My.Resources.Resources.blk_Blue
        resources.ApplyResources(Me.blk12, "blk12")
        Me.blk12.Name = "blk12"
        Me.blk12.TabStop = False
        '
        'blk13
        '
        Me.blk13.Image = Global.Game.My.Resources.Resources.blk_Blue
        resources.ApplyResources(Me.blk13, "blk13")
        Me.blk13.Name = "blk13"
        Me.blk13.TabStop = False
        '
        'blk14
        '
        Me.blk14.Image = Global.Game.My.Resources.Resources.blk_Blue
        resources.ApplyResources(Me.blk14, "blk14")
        Me.blk14.Name = "blk14"
        Me.blk14.TabStop = False
        '
        'blk16
        '
        Me.blk16.Image = Global.Game.My.Resources.Resources.blk_Red
        resources.ApplyResources(Me.blk16, "blk16")
        Me.blk16.Name = "blk16"
        Me.blk16.TabStop = False
        '
        'blk17
        '
        Me.blk17.Image = Global.Game.My.Resources.Resources.blk_Red
        resources.ApplyResources(Me.blk17, "blk17")
        Me.blk17.Name = "blk17"
        Me.blk17.TabStop = False
        '
        'blk18
        '
        Me.blk18.Image = Global.Game.My.Resources.Resources.blk_Red
        resources.ApplyResources(Me.blk18, "blk18")
        Me.blk18.Name = "blk18"
        Me.blk18.TabStop = False
        '
        'blk19
        '
        Me.blk19.Image = Global.Game.My.Resources.Resources.blk_Red
        resources.ApplyResources(Me.blk19, "blk19")
        Me.blk19.Name = "blk19"
        Me.blk19.TabStop = False
        '
        'blk20
        '
        Me.blk20.Image = Global.Game.My.Resources.Resources.blk_Red
        resources.ApplyResources(Me.blk20, "blk20")
        Me.blk20.Name = "blk20"
        Me.blk20.TabStop = False
        '
        'blk21
        '
        Me.blk21.Image = Global.Game.My.Resources.Resources.blk_Red
        resources.ApplyResources(Me.blk21, "blk21")
        Me.blk21.Name = "blk21"
        Me.blk21.TabStop = False
        '
        'blk28
        '
        Me.blk28.Image = Global.Game.My.Resources.Resources.blk_Red
        resources.ApplyResources(Me.blk28, "blk28")
        Me.blk28.Name = "blk28"
        Me.blk28.TabStop = False
        '
        'blk27
        '
        Me.blk27.Image = Global.Game.My.Resources.Resources.blk_Red
        resources.ApplyResources(Me.blk27, "blk27")
        Me.blk27.Name = "blk27"
        Me.blk27.TabStop = False
        '
        'blk26
        '
        Me.blk26.Image = Global.Game.My.Resources.Resources.blk_Red
        resources.ApplyResources(Me.blk26, "blk26")
        Me.blk26.Name = "blk26"
        Me.blk26.TabStop = False
        '
        'blk25
        '
        Me.blk25.Image = Global.Game.My.Resources.Resources.blk_Red
        resources.ApplyResources(Me.blk25, "blk25")
        Me.blk25.Name = "blk25"
        Me.blk25.TabStop = False
        '
        'blk24
        '
        Me.blk24.Image = Global.Game.My.Resources.Resources.blk_Red
        resources.ApplyResources(Me.blk24, "blk24")
        Me.blk24.Name = "blk24"
        Me.blk24.TabStop = False
        '
        'blk23
        '
        Me.blk23.Image = Global.Game.My.Resources.Resources.blk_Red
        resources.ApplyResources(Me.blk23, "blk23")
        Me.blk23.Name = "blk23"
        Me.blk23.TabStop = False
        '
        'blk22
        '
        Me.blk22.Image = Global.Game.My.Resources.Resources.blk_Red
        resources.ApplyResources(Me.blk22, "blk22")
        Me.blk22.Name = "blk22"
        Me.blk22.TabStop = False
        '
        'blk7
        '
        Me.blk7.Image = Global.Game.My.Resources.Resources.blk_Blue
        resources.ApplyResources(Me.blk7, "blk7")
        Me.blk7.Name = "blk7"
        Me.blk7.TabStop = False
        '
        'blk6
        '
        Me.blk6.Image = Global.Game.My.Resources.Resources.blk_Blue
        resources.ApplyResources(Me.blk6, "blk6")
        Me.blk6.Name = "blk6"
        Me.blk6.TabStop = False
        '
        'blk5
        '
        Me.blk5.Image = Global.Game.My.Resources.Resources.blk_Blue
        resources.ApplyResources(Me.blk5, "blk5")
        Me.blk5.Name = "blk5"
        Me.blk5.TabStop = False
        '
        'blk4
        '
        Me.blk4.Image = Global.Game.My.Resources.Resources.blk_Blue
        resources.ApplyResources(Me.blk4, "blk4")
        Me.blk4.Name = "blk4"
        Me.blk4.TabStop = False
        '
        'blk3
        '
        Me.blk3.Image = Global.Game.My.Resources.Resources.blk_Blue
        resources.ApplyResources(Me.blk3, "blk3")
        Me.blk3.Name = "blk3"
        Me.blk3.TabStop = False
        '
        'blk2
        '
        Me.blk2.Image = Global.Game.My.Resources.Resources.blk_Blue
        resources.ApplyResources(Me.blk2, "blk2")
        Me.blk2.Name = "blk2"
        Me.blk2.TabStop = False
        '
        'blk1
        '
        Me.blk1.Image = Global.Game.My.Resources.Resources.blk_Blue
        resources.ApplyResources(Me.blk1, "blk1")
        Me.blk1.Name = "blk1"
        Me.blk1.TabStop = False
        '
        'blk30
        '
        Me.blk30.Image = Global.Game.My.Resources.Resources.blk_Green
        resources.ApplyResources(Me.blk30, "blk30")
        Me.blk30.Name = "blk30"
        Me.blk30.TabStop = False
        '
        'blk31
        '
        Me.blk31.Image = Global.Game.My.Resources.Resources.blk_Green
        resources.ApplyResources(Me.blk31, "blk31")
        Me.blk31.Name = "blk31"
        Me.blk31.TabStop = False
        '
        'blk34
        '
        Me.blk34.Image = Global.Game.My.Resources.Resources.blk_Green
        resources.ApplyResources(Me.blk34, "blk34")
        Me.blk34.Name = "blk34"
        Me.blk34.TabStop = False
        '
        'blk33
        '
        Me.blk33.Image = Global.Game.My.Resources.Resources.blk_Green
        resources.ApplyResources(Me.blk33, "blk33")
        Me.blk33.Name = "blk33"
        Me.blk33.TabStop = False
        '
        'blk32
        '
        Me.blk32.Image = Global.Game.My.Resources.Resources.blk_Green
        resources.ApplyResources(Me.blk32, "blk32")
        Me.blk32.Name = "blk32"
        Me.blk32.TabStop = False
        '
        'blk35
        '
        Me.blk35.Image = Global.Game.My.Resources.Resources.blk_Green
        resources.ApplyResources(Me.blk35, "blk35")
        Me.blk35.Name = "blk35"
        Me.blk35.TabStop = False
        '
        'imglBalls
        '
        Me.imglBalls.ImageStream = CType(resources.GetObject("imglBalls.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imglBalls.TransparentColor = System.Drawing.Color.Transparent
        Me.imglBalls.Images.SetKeyName(0, "1.png")
        Me.imglBalls.Images.SetKeyName(1, "2.png")
        Me.imglBalls.Images.SetKeyName(2, "3.png")
        '
        'imgBalls
        '
        resources.ApplyResources(Me.imgBalls, "imgBalls")
        Me.imgBalls.Name = "imgBalls"
        Me.imgBalls.TabStop = False
        '
        'frm1
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.imgBalls)
        Me.Controls.Add(Me.blk35)
        Me.Controls.Add(Me.blk34)
        Me.Controls.Add(Me.blk33)
        Me.Controls.Add(Me.blk32)
        Me.Controls.Add(Me.blk31)
        Me.Controls.Add(Me.blk30)
        Me.Controls.Add(Me.blk7)
        Me.Controls.Add(Me.blk6)
        Me.Controls.Add(Me.blk5)
        Me.Controls.Add(Me.blk4)
        Me.Controls.Add(Me.blk3)
        Me.Controls.Add(Me.blk2)
        Me.Controls.Add(Me.blk1)
        Me.Controls.Add(Me.blk28)
        Me.Controls.Add(Me.blk27)
        Me.Controls.Add(Me.blk26)
        Me.Controls.Add(Me.blk25)
        Me.Controls.Add(Me.blk24)
        Me.Controls.Add(Me.blk23)
        Me.Controls.Add(Me.blk22)
        Me.Controls.Add(Me.blk21)
        Me.Controls.Add(Me.blk20)
        Me.Controls.Add(Me.blk19)
        Me.Controls.Add(Me.blk18)
        Me.Controls.Add(Me.blk17)
        Me.Controls.Add(Me.blk16)
        Me.Controls.Add(Me.blk14)
        Me.Controls.Add(Me.blk13)
        Me.Controls.Add(Me.blk12)
        Me.Controls.Add(Me.blk11)
        Me.Controls.Add(Me.blk10)
        Me.Controls.Add(Me.blk9)
        Me.Controls.Add(Me.txtTime)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.paddle)
        Me.Controls.Add(Me.blk15)
        Me.Controls.Add(Me.blk8)
        Me.Controls.Add(Me.blk29)
        Me.Cursor = System.Windows.Forms.Cursors.NoMove2D
        Me.KeyPreview = True
        Me.Name = "frm1"
        Me.ShowIcon = False
        CType(Me.paddle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.blk15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.blk8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.blk29, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.blk9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.blk10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.blk11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.blk12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.blk13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.blk14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.blk16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.blk17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.blk18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.blk19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.blk20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.blk21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.blk28, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.blk27, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.blk26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.blk25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.blk24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.blk23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.blk22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.blk7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.blk6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.blk5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.blk4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.blk3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.blk2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.blk1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.blk30, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.blk31, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.blk34, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.blk33, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.blk32, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.blk35, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgBalls, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents blk8 As System.Windows.Forms.PictureBox
    Friend WithEvents blk15 As System.Windows.Forms.PictureBox
    Friend WithEvents blk29 As System.Windows.Forms.PictureBox
    Friend WithEvents paddle As System.Windows.Forms.PictureBox
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents txtTime As System.Windows.Forms.Label
    Friend WithEvents blk9 As System.Windows.Forms.PictureBox
    Friend WithEvents blk10 As System.Windows.Forms.PictureBox
    Friend WithEvents blk11 As System.Windows.Forms.PictureBox
    Friend WithEvents blk12 As System.Windows.Forms.PictureBox
    Friend WithEvents blk13 As System.Windows.Forms.PictureBox
    Friend WithEvents blk14 As System.Windows.Forms.PictureBox
    Friend WithEvents blk16 As System.Windows.Forms.PictureBox
    Friend WithEvents blk17 As System.Windows.Forms.PictureBox
    Friend WithEvents blk18 As System.Windows.Forms.PictureBox
    Friend WithEvents blk19 As System.Windows.Forms.PictureBox
    Friend WithEvents blk20 As System.Windows.Forms.PictureBox
    Friend WithEvents blk21 As System.Windows.Forms.PictureBox
    Friend WithEvents blk28 As System.Windows.Forms.PictureBox
    Friend WithEvents blk27 As System.Windows.Forms.PictureBox
    Friend WithEvents blk26 As System.Windows.Forms.PictureBox
    Friend WithEvents blk25 As System.Windows.Forms.PictureBox
    Friend WithEvents blk24 As System.Windows.Forms.PictureBox
    Friend WithEvents blk23 As System.Windows.Forms.PictureBox
    Friend WithEvents blk22 As System.Windows.Forms.PictureBox
    Friend WithEvents blk7 As System.Windows.Forms.PictureBox
    Friend WithEvents blk6 As System.Windows.Forms.PictureBox
    Friend WithEvents blk5 As System.Windows.Forms.PictureBox
    Friend WithEvents blk4 As System.Windows.Forms.PictureBox
    Friend WithEvents blk3 As System.Windows.Forms.PictureBox
    Friend WithEvents blk2 As System.Windows.Forms.PictureBox
    Friend WithEvents blk1 As System.Windows.Forms.PictureBox
    Friend WithEvents blk30 As System.Windows.Forms.PictureBox
    Friend WithEvents blk31 As System.Windows.Forms.PictureBox
    Friend WithEvents blk34 As System.Windows.Forms.PictureBox
    Friend WithEvents blk33 As System.Windows.Forms.PictureBox
    Friend WithEvents blk32 As System.Windows.Forms.PictureBox
    Friend WithEvents blk35 As System.Windows.Forms.PictureBox
    Friend WithEvents imglBalls As System.Windows.Forms.ImageList
    Friend WithEvents imgBalls As System.Windows.Forms.PictureBox

End Class
