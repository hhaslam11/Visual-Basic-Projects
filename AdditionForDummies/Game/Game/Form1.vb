Public Class frm1
    Dim blk() As PictureBox
    Dim paddleX As Integer
    Dim timeLeft As Integer = 9 '9
    Dim doContinue As Boolean = True
    Dim lose As Boolean = False
    Dim ballX, ballY, ballDX, ballDY As Integer
    Const paddleY As Integer = 550
    Const SPEED As Integer = 7

    Private Sub frm1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        'Paddle Left
        If e.KeyCode = Keys.Left Then
            paddleX -= SPEED
            paddle.SetBounds(paddleX, paddleY, paddle.Width, paddle.Height)
        End If
        'Paddle Right
        If e.KeyCode = Keys.Right Then
            paddleX += SPEED
            paddle.SetBounds(paddleX, paddleY, paddle.Width, paddle.Height)
        End If
        'Escape/Exit
        If e.KeyCode = Keys.Escape Then
            doContinue = False
        End If

    End Sub

    Private Sub frm1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Set PictureBoxes to array
        blk = New PictureBox() {blk1, blk2, blk3, blk4, blk5, blk6, blk7, blk8, blk9, blk10, blk11, blk12, blk13, blk14, blk15, blk16, blk17, _
                                blk18, blk19, blk20, blk21, blk22, blk23, blk24, blk25, blk26, blk27, blk28, blk29, blk30, blk31, blk32, blk33, _
                                blk34, blk35}
        'Make blocks visible
        For i = 0 To blk.Length - 1
            blk(i).Visible = True
        Next

    End Sub

    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        btnStart.Visible = False
        paddle.SetBounds(paddleX, paddleY, paddle.Width, paddle.Height)
        paddle.Visible = True

        'Display Lives
        imgBalls.Image = imglBalls.Images(2)


        While doContinue = True 'Timer
            Delay(1)
            txtTime.Text = "Time Left: " & timeLeft
            timeLeft -= 1
            If timeLeft < 0 Then
                lose = True
                doContinue = False
            End If

        End While

        'Lose
        If lose = True Then
            paddle.Visible = False
            MessageBox.Show("You Ran Out Of Time!", "You Have Lost")
        End If

        'Close
        Me.Close()

    End Sub
    Sub Delay(ByVal dblSecs As Double) 'Delay
        Const OneSec As Double = 1.0# / (1440.0# * 60.0#)
        Dim dblWaitTil As Date
        Now.AddSeconds(OneSec)
        dblWaitTil = Now.AddSeconds(OneSec).AddSeconds(dblSecs)
        Do Until Now > dblWaitTil
            Application.DoEvents()
        Loop
    End Sub
    Sub Ball(ByVal intX As Integer, ByVal intY As Integer) 'Move The Ball



    End Sub
End Class

'imglBalls
'0 - 1 Left
'1 - 2 Left
'2 - 3 Left