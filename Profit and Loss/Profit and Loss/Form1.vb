Public Class Form1

    'Varaiables
    Dim dblRevenue, dblRent, dblPayroll, dblUtilities, dblSupplies, dblOther, dblTotalExpenses, dblProfit, dblLoss, dblEP1, dblEP2, dblEP3, dblEP4, dblEP5 As Double

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click

        'Assign User Input To Variables
        dblRevenue = CDbl(txtRevenue.Text)
        dblRent = CDbl(txtRent.Text)
        dblPayroll = CDbl(txtPayroll.Text)
        dblUtilities = CDbl(txtUtilities.Text)
        dblSupplies = CDbl(txtSupplies.Text)
        dblOther = CDbl(txtOther.Text)

        'Calculate
        dblTotalExpenses = dblRent + dblPayroll + dblUtilities + dblSupplies + dblOther
        dblProfit = dblRevenue - dblTotalExpenses
        dblEP1 = dblRent / dblTotalExpenses
        dblEP2 = dblPayroll / dblTotalExpenses
        dblEP3 = dblUtilities / dblTotalExpenses
        dblEP4 = dblSupplies / dblTotalExpenses
        dblEP5 = dblOther / dblTotalExpenses



        'Display
        txtRevenue.Text = FormatCurrency(CStr(dblRevenue))
        txtRent.Text = FormatCurrency(CStr(dblRent))
        txtPayroll.Text = FormatCurrency(CStr(dblPayroll))
        txtUtilities.Text = FormatCurrency(CStr(dblUtilities))
        txtSupplies.Text = FormatCurrency(CStr(dblSupplies))
        txtOther.Text = FormatCurrency(CStr(dblOther))
        txtTotalExpense.Text = FormatCurrency(CStr(dblTotalExpenses))
        If dblProfit >= 0 Then
            txtProfit.Text = FormatCurrency(CStr(dblProfit))
        Else
            txtLoss.Text = FormatCurrency(CStr(dblProfit))
        End If
        txtEP1.Text = FormatPercent(CStr(dblEP1))
        txtEP2.Text = FormatPercent(CStr(dblEP2))
        txtEP3.Text = FormatPercent(CStr(dblEP3))
        txtEP4.Text = FormatPercent(CStr(dblEP4))
        txtEP5.Text = FormatPercent(CStr(dblEP5))

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click

        Me.Close() 'Close Program

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click

        'Clear text boxes
        txtRevenue.Text = ""
        txtRent.Text = ""
        txtPayroll.Text = ""
        txtUtilities.Text = ""
        txtSupplies.Text = ""
        txtOther.Text = ""
        txtTotalExpense.Text = ""
        txtProfit.Text = ""
        txtLoss.Text = ""
        txtEP1.Text = ""
        txtEP2.Text = ""
        txtEP3.Text = ""
        txtEP4.Text = ""
        txtEP5.Text = ""

    End Sub
End Class

'   *******************
'   *  Kaleb Haslam   *
'   * Profit and Loss *
'   *******************