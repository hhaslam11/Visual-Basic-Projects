Public Class Form1

    Dim blnContinue As Boolean = True

    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            blnContinue = False
        End If
    End Sub
    Private Sub Form1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        'Create graphics object
        Dim gr As Graphics = e.Graphics
        'Body
        gr.DrawArc(Pens.Black, 5, 55, 200, 200, 210, 300)
        'Mouth
        gr.DrawLine(Pens.Red, 73, 150, 18, 105)
        gr.DrawLine(Pens.Red, 73, 150, 18, 203)
        'Blue Hat
        gr.FillRectangle(Brushes.Blue, 35, 20, 165, 42)
        'Red Hat
        gr.FillRectangle(Brushes.Red, 10, 40, 212, 42)
        'Eye
        gr.DrawEllipse(Pens.Black, 90, 90, 20, 20)
        'Tongue
        Do
            Dim intMove As Integer
            For intMove = 203 To 105 Step -1
                Delay(0.01)
                gr.DrawLine(Pens.Red, 73, 150, 18, intMove)
                gr.DrawLine(Pens.White, 73, 150, 18, intMove + 1)
                'Mouth
                gr.DrawLine(Pens.Red, 73, 150, 18, 105)
                gr.DrawLine(Pens.Red, 73, 150, 18, 203)
            Next
            For intMove = 105 To 203
                Delay(0.01)
                gr.DrawLine(Pens.Red, 73, 150, 18, intMove)
                gr.DrawLine(Pens.White, 73, 150, 18, intMove - 1)
                'Mouth
                gr.DrawLine(Pens.Red, 73, 150, 18, 105)
                gr.DrawLine(Pens.Red, 73, 150, 18, 203)
            Next

        Loop Until blnContinue = False

        'Close Form
        Me.Close()

    End Sub
    Sub Delay(ByVal dblSecs As Double)
        Const OneSec As Double = 1.0# / (1440.0# * 60.0#)
        Dim dblWaitTil As Date
        Now.AddSeconds(OneSec)
        dblWaitTil = Now.AddSeconds(OneSec).AddSeconds(dblSecs)
        Do Until Now > dblWaitTil
            Application.DoEvents() ' Allow windows messages to be processed
        Loop
    End Sub
End Class

'Kaleb Haslam
'Pacman