Public Class Form1
    Dim blnClose As Boolean = False
    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            blnClose = True
        End If
    End Sub

    Private Sub Form1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        'Create graphics object
        Dim gr As Graphics = e.Graphics
        Dim intHeight As Integer

        'now draw house
        gr.DrawRectangle(Pens.Brown, 100, 200, 200, 200)
        'roof
        gr.DrawLine(Pens.Brown, 100, 200, 200, 120)
        gr.DrawLine(Pens.Brown, 200, 120, 300, 200)
        'door
        gr.FillRectangle(Brushes.Black, 180, 320, 40, 80)
        'doorknob
        gr.FillEllipse(Brushes.White, 210, 360, 4, 4)
        'First Window
        gr.FillRectangle(Brushes.Blue, 125, 245, 40, 40)
        'Second Window
        gr.FillRectangle(Brushes.Blue, 230, 245, 40, 40)
        'Tree
        gr.DrawLine(Pens.BurlyWood, 409, 266, 409, 400)
        'top branch
        gr.DrawLine(Pens.Green, 409, 266, 365, 300)
        gr.DrawLine(Pens.Green, 409, 266, 453, 300)
        'middle branch
        gr.DrawLine(Pens.Green, 409, 298, 365, 332)
        gr.DrawLine(Pens.Green, 409, 298, 453, 332)
        'bottom branch
        gr.DrawLine(Pens.Green, 409, 330, 365, 364)
        gr.DrawLine(Pens.Green, 409, 330, 453, 364)
        'Sun
        gr.FillEllipse(Brushes.Yellow, 464, 24, 100, 100)
        'eyes
        gr.FillEllipse(Brushes.Black, 477, 54, 20, 20)
        gr.FillEllipse(Brushes.Black, 530, 54, 20, 20)
        'mouth
        gr.DrawArc(Pens.Red, 490, 91, 50, 5, 0, 180)
        gr.DrawArc(Pens.Red, 490, 84, 50, 20, 0, 180)
        'tongue
        Do
            For intHeight = 5 To 25
                gr.DrawArc(Pens.Red, 500, 92, 30, intHeight, 0, 180)
                Delay(0.1)
            Next
            For intHeight = 25 To 5 Step -1
                gr.DrawArc(Pens.Yellow, 500, 92, 30, intHeight, 0, 180)
                Delay(0.1)
                're-draw mouth
                gr.DrawArc(Pens.Red, 490, 91, 50, 5, 0, 180)
                gr.DrawArc(Pens.Red, 490, 84, 50, 20, 0, 180)
            Next
        Loop Until blnClose = True
        'Font = New Font("Comic Sans MS", 24)
        gr.DrawString("Blah!!!", Font, Brushes.Blue, 480, 160)

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
'House