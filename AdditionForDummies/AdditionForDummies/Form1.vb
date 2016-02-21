Public Class Form1
    'Variables
    Dim intFirstNum, intSecondNum, intAnswer As Integer
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        intFirstNum = CInt(txtFirstNum.Text)
        intSecondNum = CInt(txtSecondNum.Text) 'Add Variables and display answer
        intAnswer = intFirstNum + intSecondNum

        txtOutput.Text = intAnswer

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click

        txtFirstNum.Clear()
        txtSecondNum.Clear() 'Clear text
        txtOutput.Clear()

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click

        Me.Close() 'Exit program

    End Sub
End Class

'       ************************
'       *      Kaleb Haslam    *
'       * Addition For Dummies *
'       ************************