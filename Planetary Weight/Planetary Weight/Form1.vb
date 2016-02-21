Public Class Form1

    'Variables
    Dim intChoice As Integer
    Dim dblWeight, dblOutput As Double

    Private Sub btnCalc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalc.Click

        'Get input
        dblWeight = txtInput.Text

        'Get Ouput
        Select Case intChoice
            Case 0
                dblOutput = dblWeight * 27.4
            Case 1
                dblOutput = dblWeight * 0.17
            Case 2
                dblOutput = dblWeight * 0.88
            Case 3
                dblOutput = dblWeight * 1.15
        End Select
        txtOutput.Text = CStr(dblOutput)

    End Sub

    Private Sub rbtnSun_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtnSun.CheckedChanged
        intChoice = 0
    End Sub

    Private Sub rbtnMoon_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtnMoon.CheckedChanged
        intChoice = 1
    End Sub

    Private Sub rbtnVenus_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtnVenus.CheckedChanged
        intChoice = 2
    End Sub

    Private Sub rbtnSaturn_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtnSaturn.CheckedChanged
        intChoice = 3
    End Sub
End Class


'Kaleb Haslam
'Planetary Weight