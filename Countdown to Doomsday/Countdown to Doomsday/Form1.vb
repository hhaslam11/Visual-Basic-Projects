Public Class Form1

    Private Sub btnCount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCount.Click
        Dim intCount As Integer
        btnCount.Visible = False
        For intCount = 10 To 0 Step -1
            lblOutput.Text = CStr(intCount)
            Delay(1)
        Next
        lblOutput.Visible = False
        picExplosion.Visible = True

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
'Count down to Doomsday