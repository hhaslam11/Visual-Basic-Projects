Public Class Form1

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click

        'Clear the text boxes
        txtName.Clear() ' clear the contents
        txtName.Focus() ' give it the focus
        txtMessage.Clear() 'clear the message textbox
        txtOutPut.Text = ""

    End Sub

    Private Sub ClearMenuToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearMenuToolStripMenuItem.Click
        'Clear the text boxes
        txtName.Clear() ' clear the contents
        txtName.Focus() ' give it the focus
        txtMessage.Clear() 'clear the message textbox
        txtOutPut.Text = ""
    End Sub

    Private Sub GoodbyeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GoodbyeToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnDisplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplay.Click
        txtOutPut.Text = txtName.Text & ": " & txtMessage.Text
    End Sub

    Private Sub radBlack_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radBlack.CheckedChanged
        txtOutPut.ForeColor = Color.Black
    End Sub

    Private Sub radBlue_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radBlue.CheckedChanged
        txtOutPut.ForeColor = Color.Blue
    End Sub

    Private Sub radGreen_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radGreen.CheckedChanged
        txtOutPut.ForeColor = Color.Green
    End Sub

    Private Sub radRed_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radRed.CheckedChanged
        txtOutPut.ForeColor = Color.Red
    End Sub

    Private Sub picBig_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picBig.Click
        picBig.Visible = False
        picSmall.Visible = True
    End Sub

    Private Sub picSmall_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picSmall.Click
        picBig.Visible = True
        picSmall.Visible = False
    End Sub

    Private Sub chkVisible_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkVisible.CheckedChanged
        txtOutPut.Visible = chkVisible.Checked
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        chkVisible.Checked = True 'Added this to make it checked by defualt

    End Sub

    Private Sub btnMessageBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMessageBox.Click

        'Message Box
        MessageBox.Show("This is a message box!", "This is a title", MessageBoxButtons.OK,MessageBoxIcon.Information)

    End Sub
End Class


'           ********************************
'           *         Kaleb Haslam         *
'           * Splash Screen / Message Box  *
'           ********************************