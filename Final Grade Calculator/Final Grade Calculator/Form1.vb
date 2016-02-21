Public Class Form1

    'Kaleb

    Dim strStudent As String = ""
    Dim dblPercent As Double = 0
    Dim strPercent As String = ""
    Dim dblSum As Double = 0
    Dim intCounter As Integer = 0 'number of entries made
    Dim dblAverage As Double = 0

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        strStudent = InputBox("Enter student name:", "Student Name")
        Do Until strPercent.ToLower = "quit"
            strPercent = InputBox("Enter student percentage (Type 'quit' to exit)", "Student Grade")
            If strPercent.ToLower <> "quit" Then
                intCounter += 1
                dblPercent = CDbl(strPercent)
                dblSum += dblPercent
            End If
        Loop
        dblAverage = dblSum / intCounter
        MessageBox.Show(strStudent & ", your average is " & CStr(dblAverage), "Final Mark", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close() 'form closes automatically

    End Sub
End Class
