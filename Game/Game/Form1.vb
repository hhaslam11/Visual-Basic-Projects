Public Class frm1

    Dim blk() As PictureBox
    Dim paddleX As Integer
    Dim timeLeft As Integer = 299
    Dim doContinue As Boolean = True
    Dim lose As Boolean = False
    Dim win As Boolean = False
    Dim strMessage As String
    Dim ballX, ballY, ballDX, ballDY As Integer
    Const paddleY As Integer = 550
    Dim SPEED As Integer = 10
    Dim CurrentBallsLeft As Integer = 3

    Private Sub frm1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        'Paddle Left
        If e.KeyCode = Keys.Left Then
            If paddleX <= 1 Then
                SPEED = 0
            Else
                SPEED = -10
            End If
        End If

        'Paddle Right
        If e.KeyCode = Keys.Right Then
            If paddleX >= Me.Width - paddle.Width - 18 Then
                SPEED = 0
            Else
                SPEED = +10
            End If
        End If

        'Move Paddle
        paddleX += SPEED
        paddle.SetBounds(paddleX, paddleY, paddle.Width, paddle.Height)

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

    End Sub

    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        btnStart.Visible = False 'Make button invisible
        paddle.SetBounds(paddleX, paddleY, paddle.Width, paddle.Height) 'Move Paddle
        paddle.Visible = True 'Make paddle visible
        ballX = 200
        ballY = 275
        ballDX = -2
        ballDY = 2
        tmrBall.Enabled = True 'Enable Timer
        imgBall.Visible = True 'Make ball visible

        'Make blocks visible
        For i = 0 To blk.Length - 1
            blk(i).Visible = True
        Next

        'Display Lives
        imgBalls.Image = imglBalls.Images(3)

        'Timer
        While doContinue = True
            Delay(1)
            txtTime.Text = "Time Left: " & timeLeft
            timeLeft -= 1
            If timeLeft < 0 Then
                lose = True
                doContinue = False
            End If

            For i = 0 To blk.Length - 1
                'TODO Test all values in blk() for Visible = false
            Next

        End While

            'Lose
            If lose = True Then

                'Get strMessage
                If timeLeft < 0 Then
                    strMessage = "You've ran out of time!"
                ElseIf CurrentBallsLeft <= 0 Then
                    strMessage = "You've ran out of lives!"
                End If

                'Make items invisible
                paddle.Visible = False
                imgBall.Visible = False
                For i = 0 To blk.Length - 1
                    blk(i).Visible = False
                Next

                MessageBox.Show(strMessage, "You Have Lost")

            End If

            'Win
            If win = True Then

                'Make items invisible
                paddle.Visible = False
                imgBall.Visible = False
                For i = 0 To blk.Length - 1
                    blk(i).Visible = False
                Next

                MessageBox.Show("congratulations, You've Won!", "You Won!")

            End If

            'Close
            Me.Close()

    End Sub


    Private Sub tmrBall_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrBall.Tick

        'Hit Right
        If ballX >= Me.Width - imgBall.Width Then
            ballDX = -1 * Int(Rnd() * 3) + 1
        End If

        'Hit Left
        If ballX < 1 Then
            ballDX = Int(Rnd() * 3) + 1
        End If

        'Hit Top
        If ballY < 1 Then
            ballDY = Int(Rnd() * 3) + 1
        End If

        'Hit Bottom
        If ballY >= Me.Height - (imgBall.Height) Then
            ballY = Me.Height - imgBall.Height
            lblBallY.Text = CStr(ballY)
            ballDY = -1 * Int(Rnd() * 3) + 1
            lives(CurrentBallsLeft)
        End If

        'Hit paddle
        If (ballX >= paddleX) And (ballX <= paddleX + paddle.Width - imgBall.Width) And (ballY <= paddleY + paddle.Height) And (ballY >= paddleY + paddle.Height - imgBall.Height) Then
            ballDY = -1 * Int(Rnd() * 3) + 1
        End If

        'Hit block
        For i = 0 To blk.Length - 1
            If imgBall.Bounds.IntersectsWith(blk(i).Bounds) And blk(i).Visible = True Then
                blk(i).Visible = False
                ballDY = Int(Rnd() * 3) + 1
            End If
        Next

        'Move Ball 
        ballX += ballDX
        ballY += ballDY
        imgBall.SetBounds(ballX, ballY, imgBall.Width, imgBall.Height)

    End Sub


    Sub lives(ByRef CurrentBallsLeft As Integer)
        Dim ballLeft As Integer
        ballLeft = CurrentBallsLeft
        'Lose Life
        If ballLeft <= 0 Then
            imgBalls.Image = imglBalls.Images(0)
            lose = True
            doContinue = False
        Else
            ballLeft -= 1
            CurrentBallsLeft = ballLeft
            Select Case ballLeft
                Case 3
                    imgBalls.Image = imglBalls.Images(3)
                Case 2
                    imgBalls.Image = imglBalls.Images(2)
                Case 1
                    imgBalls.Image = imglBalls.Images(1)
            End Select
        End If

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

End Class

'Colision Code
'If Sonic.Bounds.IntersectsWith(ground.Bounds) Then detection.Text = "Collision"
