Public Class Form1

    'Variables
    Dim strEmployee As String
    Dim dblRegHours, dblOvertimeHours, dblRegPay, dblOvertimePay, dblHours, dblRate, dblGrossPay, dblIncomeTax, dblPension, dblTotalDeductions, dblNetPay As Double
    Const dblTaxRate As Double = 0.33
    Const dblPRate As Double = 0.1

    Private Sub CalculateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculateToolStripMenuItem.Click

        'Assign input
        strEmployee = txtEmployee.Text
        dblHours = CDbl(txtHours.Text)
        dblRate = CDbl(txtRate.Text)

        'Calculate
        If dblHours > 40 Then

            dblOvertimeHours = dblHours - 40
            dblRegPay = dblRate * 40
            dblOvertimePay = dblRate * 1.5 * dblOvertimeHours
            dblRegHours = 40

        Else

            dblOvertimePay = 0
            dblRegPay = dblRate * dblHours
            dblRegHours = dblHours
            dblOvertimeHours = 0

        End If
        dblGrossPay = dblOvertimePay + dblRegPay
        dblIncomeTax = dblGrossPay * dblTaxRate
        dblPension = dblGrossPay * dblPRate
        dblTotalDeductions = dblIncomeTax + dblPension
        dblNetPay = dblGrossPay - dblTotalDeductions
        
        'Assign Output
        txtRegHours.Text = dblRegHours
        txtRegPay.Text = FormatCurrency(CStr(dblRegPay))
        txtOvertimeHours.Text = dblOvertimeHours
        txtOvertimePay.Text = FormatCurrency(CStr(dblOvertimePay))
        txtTotalDeductions.Text = FormatCurrency(CStr(dblTotalDeductions))
        txtGrossPay.Text = FormatCurrency(CStr(dblGrossPay))
        txtIncomeTax.Text = FormatCurrency(CStr(dblIncomeTax))
        txtNetPay.Text = FormatCurrency(CStr(dblNetPay))
        txtPension.Text = FormatCurrency(CStr(dblPension))
        txtTotalDeductions.Text = FormatCurrency(CStr(dblTotalDeductions))

        'Set Visible
        lblGrossPay.Visible = True
        lblIncomeTax.Visible = True
        lblNetPay.Visible = True
        lblPension.Visible = True
        lblTotalDeductions.Visible = True
        lblOvertimeHours.Visible = True
        lblOvertimePay.Visible = True
        lblRegHours.Visible = True
        lblRegPay.Visible = True
        txtOvertimeHours.Visible = True
        txtOvertimePay.Visible = True
        txtRegHours.Visible = True
        txtRegPay.Visible = True
        txtGrossPay.Visible = True
        txtIncomeTax.Visible = True
        txtNetPay.Visible = True
        txtPension.Visible = True
        txtTotalDeductions.Visible = True

    End Sub
    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click

        'Close Program
        Me.Close()

    End Sub
End Class


'   ****************
'   * Kaleb Haslam *
'   *Paystub Calc 2*
'   ****************