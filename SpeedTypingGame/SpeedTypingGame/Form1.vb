Public Class frmSpeedTypingGame
    Dim intWrong As Integer = 0  'number of strikes made
    Dim intCount As Integer = 0  ' number of tries the player has 							‘made
    Dim intTimer As Integer = 0  'amount of time elapsed

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGo.Click
        If intCount = 0 Then txtDisplay.Text = "Once upon a time there were three little pigs."
        If intCount = 1 Then txtDisplay.Text = "In days gone by times were hard but the people were strong."
        If intCount = 2 Then txtDisplay.Text = "Once in a while something special happens even to the worst of people."
        If intCount = 3 Then txtDisplay.Text = "When injustice rears its head, it is the duty of all good citizens to object."
        If intCount = 4 Then txtDisplay.Text = "It is said that in the end there can only be one.  Let that one be the Mighty Molly"

        btnDone.Enabled = True
        btnGo.Enabled = True
        txtEntry.ReadOnly = False
        tmrControl.Enabled = True
        intTimer = 0    ' reset timer to 0
        txtEntry.Focus()  'Make txtEntry have the focus again
    End Sub

    Private Sub btnDone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDone.Click
        stbControl.Text = ""
        tmrControl.Enabled = False
        If txtEntry.Text = "" Then
            MessageBox.Show("Error:  You must enter something!!")
            txtEntry.Text = ""
            txtDisplay.Text = ""
            btnDone.Enabled = False
            btnGo.Enabled = True
            txtEntry.ReadOnly = True
            intTimer = 0
            btnGo.Focus() ' give the Go button the focus
            Return
        End If
        If txtEntry.Text = txtDisplay.Text Then
            MessageBox.Show("Match!  You typed in the string correctly!")
            intCount = intCount + 1
            intTimer = 0
        Else
            MessageBox.Show("Strike " & intWrong + 1 & " - You made at least one typo.")
            intWrong = intWrong + 1
            intTimer = 0
        End If
        txtEntry.Text = ""
        txtDisplay.Text = ""
        btnDone.Enabled = False
        btnGo.Enabled = True
        txtEntry.ReadOnly = True
        btnGo.Focus()
        If intWrong = 3 Then
            If intCount < 2 Then
                MessageBox.Show("Game over. Your typing skill level is:  Beginner.  Please play again!")
                intCount = 0
                intWrong = 0
                Return
            End If
            If intCount < 4 Then
                MessageBox.Show("Game over.  Your typing skill level is:  Intermediate.  Please play again!")
                intCount = 0
                intWrong = 0
                Return
            End If
            If intCount < 5 Then
                MessageBox.Show("Game over.  Your typing skill level is:  Advanced.  Please play again.")
                intCount = 0
                intWrong = 0
                Return
            End If
        End If
        If intCount = 5 Then
            MessageBox.Show("Game complete.  Your typing skill level is:  Expert.  Please play again.")
            intCount = 0
            intWrong = 0
        End If
    End Sub

    Private Sub tmrControl_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrControl.Tick
        intTimer = intTimer + 1
        stbControl.Text = "Seconds remaining:  " & (15 - intTimer)
        If intTimer = 15 Then
            intWrong = intWrong + 1
            tmrControl.Enabled = False
            stbControl.Text = ""
            MessageBox.Show("Strike " & intWrong & " - Time is up.  Please try again.")
            txtEntry.Text = ""
            txtDisplay.Text = ""
            btnDone.Enabled = False
            btnGo.Enabled = True
            txtEntry.ReadOnly = True
            If intWrong = 3 Then
                If intCount < 2 Then
                    MessageBox.Show("Game over.  Your typing skill level is:  Beginner.  Please play again!")
                    intCount = 0
                    intWrong = 0
                    Return
                End If
                If intCount < 4 Then
                    MessageBox.Show("Game over.  Your typing skill level is:  Intermediate.  Please play again!")
                    intCount = 0
                    intWrong = 0
                    Return
                End If
                If intCount < 5 Then
                    MessageBox.Show("Game over.  Your typing skill level is:  Advanced.  Please play again.")
                    intCount = 0
                    intWrong = 0
                    Return
                End If
            End If

            If intCount = 5 Then
                MessageBox.Show("Game complete.  Your typing skill level is:  Expert.  Please play again.")
                intCount = 0
                intWrong = 0
            End If
        End If
    End Sub
End Class


' *********************
' *    Kaleb Haslam   *
' * Speed Typing Game *
' *********************
