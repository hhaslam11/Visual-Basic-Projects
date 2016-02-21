Public Class Form1
    Private Sub Form1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        'Create graphics object
        Dim gr As Graphics = e.Graphics
        'Blue Ring
        gr.DrawEllipse(Pens.Blue, 50, 50, 70, 70)
        'Red Ring
        gr.DrawEllipse(Pens.Red, 150, 50, 70, 70)
        'Black Ring
        gr.DrawEllipse(Pens.Black, 250, 50, 70, 70)
        'Yellow Ring
        gr.DrawEllipse(Pens.Yellow, 100, 75, 70, 70)
        'Green Ring
        gr.DrawEllipse(Pens.Green, 200, 75, 70, 70)
    End Sub
End Class

'Kaleb Haslam
'Olympic Rings
