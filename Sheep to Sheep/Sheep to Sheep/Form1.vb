Public Class Form1

    Private Sub btnCount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCount.Click

        lblOutput.Text = ""
        Dim intCount As Integer
        For intCount = 0 To 10 ' Step 1
            lblOutput.Text = lblOutput.Text + CStr(intCount) + " Sheep" + ControlChars.NewLine
            Delay(0.7)
        Next

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
'Sheep To Sheep