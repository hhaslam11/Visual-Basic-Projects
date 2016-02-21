Public Class Form1

    Dim dblPercent As Double

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click

        Me.Close()

    End Sub

    Private Sub CalculateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculateToolStripMenuItem.Click

        dblPercent = txtInput.Text

        If dblPercent > 90 Then
            MessageBox.Show("High honours", "Honour Rolls", MessageBoxButtons.OK)
        ElseIf dblPercent >= 80 Then
            MessageBox.Show("Honours", "Honour Rolls", MessageBoxButtons.OK)
        ElseIf dblPercent >= 60 Then
            MessageBox.Show("Satisfactory", "Honour Rolls", MessageBoxButtons.OK)
        Else
            MessageBox.Show("Needs improvment", "Honour Rolls", MessageBoxButtons.OK)
        End If

    End Sub
End Class

' Kaleb Haslam
' Honour Roll Calculator
