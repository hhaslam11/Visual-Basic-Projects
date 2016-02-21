Public Class frmClickRaceGame
    Dim intCounter As Integer = 0
    Dim intTimerCounter As Integer = 0
    Const intRemainingTime = 10

    Private Sub frmClickRaceGame_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ByVal e As System.EventArgs)
        btnClickMe1.Enabled = False
        btnClickMe2.Enabled = False
    End Sub

    Private Sub btnStartGame_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStartGame.Click
        ByVal e As System.EventArgs) Handles btnStartGame.Click
        intCounter = 0
        intTimerCounter = 0
        txtOutput.Text = ""
        btnClickMe1.Enabled = True
        btnClickMe2.Enabled = False
        Timer1.Enabled = True
    End Sub

    Private Sub btnExitGame_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExitGame.Click
        ByVal e As System.EventArgs) Handles btnExitGame.Click
        Me.Close()
    End Sub

    Private Sub btnClickMe1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClickMe1.Click
        ByVal e As System.EventArgs) Handles btnClickMe1.Click
        intCounter = intCounter + 1
        txtOutput.Text = intCounter
        btnClickMe1.Enabled = False
        btnClickMe2.Enabled = True
    End Sub

    Private Sub btnClickMe2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClickMe2.Click
        ByVal e As System.EventArgs) Handles btnClickMe2.Click
        intCounter = intCounter + 1
        txtOutput.Text = intCounter
        btnClickMe1.Enabled = True
        btnClickMe2.Enabled = False
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ByVal e As Sytem.EventArgs) Handles Timer1.Tick
        If intTimerCounter < 10 Then
            intTimerCounter = IntTimerCounter + 1
            txtRemainingTime.Text = intRemainingTime - intTimerCounter
        End If
        If intTimerCounter = 10 Then ' turn off the buttons
            btnClickMe1.Enabled = False
            btnClickMe2.Enabled = False
        End If
    End Sub
End Class
