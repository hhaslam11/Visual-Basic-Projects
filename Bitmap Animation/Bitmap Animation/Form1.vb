Public Class Form1
    Dim intX, intY, intHeight, intWidth As Integer
    Dim blnGoRight As Boolean = False
    Dim blnGoDown As Boolean = False
    Dim blnGoLeft As Boolean = True
    Dim blnGoUp As Boolean = False
    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'define X,Y coordinates for picture
        intX = picPlane.Left
        intY = picPlane.Top
        'find height and width of picture
        intHeight = picPlane.Height
        intWidth = picPlane.Width
        picPlane.Visible = True 'make plane visible
        Timer1.Enabled = True 'start timer
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        'GO LEFT
        If (blnGoLeft = True) And (intX <= Me.Width) And (intX >= 2) Then
            intX -= 1 ' X decreases since we are moving right to left
            intY = 1
            If intX <= 1 Then
                blnGoLeft = False
                blnGoDown = True
            End If

        End If

        'GO DOWN
        If (blnGoDown = True) And (intY < Me.Height - (intHeight + 30)) And (intY >= 1) Then
            intX = 1
            intY += 1 'Y increases as we go down
            If intY >= Me.Height - (intHeight + 30) Then
                blnGoDown = False
                blnGoRight = True
            End If
        End If

        'GO RIGHT
        If (blnGoRight = True) And (intX >= 1) And (intX <= Me.Width - intWidth) Then
            intX += 1
            If intX >= (Me.Width - intWidth) Then
                blnGoRight = False
                blnGoUp = True
            End If
        End If

        'GO UP
        If (blnGoUp = True) And (intY <= Me.Height - (intHeight + 30)) And (intY >= 1) Then
            intY -= 1
            If intY <= 1 Then
                blnGoUp = False
                blnGoLeft = True
            End If
        End If
        picPlane.SetBounds(intX, intY, intWidth, intHeight)
    End Sub
End Class

'Kaleb Haslam
'Bitmap Animation B