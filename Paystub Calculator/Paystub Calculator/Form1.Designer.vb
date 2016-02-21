<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CalculateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblIncomeTax = New System.Windows.Forms.Label
        Me.lblTotalDeductions = New System.Windows.Forms.Label
        Me.lblPension = New System.Windows.Forms.Label
        Me.lblNetPay = New System.Windows.Forms.Label
        Me.txtEmployee = New System.Windows.Forms.TextBox
        Me.txtHours = New System.Windows.Forms.TextBox
        Me.txtRate = New System.Windows.Forms.TextBox
        Me.txtGrossPay = New System.Windows.Forms.TextBox
        Me.txtIncomeTax = New System.Windows.Forms.TextBox
        Me.txtPension = New System.Windows.Forms.TextBox
        Me.txtTotalDeductions = New System.Windows.Forms.TextBox
        Me.txtNetPay = New System.Windows.Forms.TextBox
        Me.lblGrossPay = New System.Windows.Forms.Label
        Me.lblRegPay = New System.Windows.Forms.Label
        Me.lblOvertimeHours = New System.Windows.Forms.Label
        Me.lblOvertimePay = New System.Windows.Forms.Label
        Me.lblRegHours = New System.Windows.Forms.Label
        Me.txtOvertimeHours = New System.Windows.Forms.TextBox
        Me.txtOvertimePay = New System.Windows.Forms.TextBox
        Me.txtRegPay = New System.Windows.Forms.TextBox
        Me.txtRegHours = New System.Windows.Forms.TextBox
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.CalculateToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(330, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'CalculateToolStripMenuItem
        '
        Me.CalculateToolStripMenuItem.Name = "CalculateToolStripMenuItem"
        Me.CalculateToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.CalculateToolStripMenuItem.Text = "&Calculate"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(68, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(211, 20)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Enter The Information Below"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(53, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Employee"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(53, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Hours"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(53, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Rate"
        '
        'lblIncomeTax
        '
        Me.lblIncomeTax.AutoSize = True
        Me.lblIncomeTax.Location = New System.Drawing.Point(53, 390)
        Me.lblIncomeTax.Name = "lblIncomeTax"
        Me.lblIncomeTax.Size = New System.Drawing.Size(63, 13)
        Me.lblIncomeTax.TabIndex = 15
        Me.lblIncomeTax.Text = "Income Tax"
        Me.lblIncomeTax.Visible = False
        '
        'lblTotalDeductions
        '
        Me.lblTotalDeductions.AutoSize = True
        Me.lblTotalDeductions.Location = New System.Drawing.Point(53, 440)
        Me.lblTotalDeductions.Name = "lblTotalDeductions"
        Me.lblTotalDeductions.Size = New System.Drawing.Size(88, 13)
        Me.lblTotalDeductions.TabIndex = 17
        Me.lblTotalDeductions.Text = "Total Deductions"
        Me.lblTotalDeductions.Visible = False
        '
        'lblPension
        '
        Me.lblPension.AutoSize = True
        Me.lblPension.Location = New System.Drawing.Point(53, 414)
        Me.lblPension.Name = "lblPension"
        Me.lblPension.Size = New System.Drawing.Size(45, 13)
        Me.lblPension.TabIndex = 16
        Me.lblPension.Text = "Pension"
        Me.lblPension.Visible = False
        '
        'lblNetPay
        '
        Me.lblNetPay.AutoSize = True
        Me.lblNetPay.Location = New System.Drawing.Point(53, 485)
        Me.lblNetPay.Name = "lblNetPay"
        Me.lblNetPay.Size = New System.Drawing.Size(45, 13)
        Me.lblNetPay.TabIndex = 18
        Me.lblNetPay.Text = "Net Pay"
        Me.lblNetPay.Visible = False
        '
        'txtEmployee
        '
        Me.txtEmployee.Location = New System.Drawing.Point(179, 87)
        Me.txtEmployee.Name = "txtEmployee"
        Me.txtEmployee.Size = New System.Drawing.Size(100, 20)
        Me.txtEmployee.TabIndex = 0
        '
        'txtHours
        '
        Me.txtHours.Location = New System.Drawing.Point(179, 116)
        Me.txtHours.Name = "txtHours"
        Me.txtHours.Size = New System.Drawing.Size(100, 20)
        Me.txtHours.TabIndex = 1
        '
        'txtRate
        '
        Me.txtRate.Location = New System.Drawing.Point(179, 147)
        Me.txtRate.Name = "txtRate"
        Me.txtRate.Size = New System.Drawing.Size(100, 20)
        Me.txtRate.TabIndex = 2
        '
        'txtGrossPay
        '
        Me.txtGrossPay.Location = New System.Drawing.Point(179, 338)
        Me.txtGrossPay.Name = "txtGrossPay"
        Me.txtGrossPay.ReadOnly = True
        Me.txtGrossPay.Size = New System.Drawing.Size(100, 20)
        Me.txtGrossPay.TabIndex = 4
        Me.txtGrossPay.Visible = False
        '
        'txtIncomeTax
        '
        Me.txtIncomeTax.Location = New System.Drawing.Point(179, 387)
        Me.txtIncomeTax.Name = "txtIncomeTax"
        Me.txtIncomeTax.ReadOnly = True
        Me.txtIncomeTax.Size = New System.Drawing.Size(100, 20)
        Me.txtIncomeTax.TabIndex = 6
        Me.txtIncomeTax.Visible = False
        '
        'txtPension
        '
        Me.txtPension.Location = New System.Drawing.Point(179, 411)
        Me.txtPension.Name = "txtPension"
        Me.txtPension.ReadOnly = True
        Me.txtPension.Size = New System.Drawing.Size(100, 20)
        Me.txtPension.TabIndex = 7
        Me.txtPension.Visible = False
        '
        'txtTotalDeductions
        '
        Me.txtTotalDeductions.Location = New System.Drawing.Point(179, 437)
        Me.txtTotalDeductions.Name = "txtTotalDeductions"
        Me.txtTotalDeductions.ReadOnly = True
        Me.txtTotalDeductions.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalDeductions.TabIndex = 8
        Me.txtTotalDeductions.Visible = False
        '
        'txtNetPay
        '
        Me.txtNetPay.Location = New System.Drawing.Point(179, 482)
        Me.txtNetPay.Name = "txtNetPay"
        Me.txtNetPay.ReadOnly = True
        Me.txtNetPay.Size = New System.Drawing.Size(100, 20)
        Me.txtNetPay.TabIndex = 9
        Me.txtNetPay.Visible = False
        '
        'lblGrossPay
        '
        Me.lblGrossPay.AutoSize = True
        Me.lblGrossPay.Location = New System.Drawing.Point(53, 341)
        Me.lblGrossPay.Name = "lblGrossPay"
        Me.lblGrossPay.Size = New System.Drawing.Size(55, 13)
        Me.lblGrossPay.TabIndex = 13
        Me.lblGrossPay.Text = "Gross Pay"
        Me.lblGrossPay.Visible = False
        '
        'lblRegPay
        '
        Me.lblRegPay.AutoSize = True
        Me.lblRegPay.Location = New System.Drawing.Point(53, 250)
        Me.lblRegPay.Name = "lblRegPay"
        Me.lblRegPay.Size = New System.Drawing.Size(65, 13)
        Me.lblRegPay.TabIndex = 20
        Me.lblRegPay.Text = "Regular Pay"
        Me.lblRegPay.Visible = False
        '
        'lblOvertimeHours
        '
        Me.lblOvertimeHours.AutoSize = True
        Me.lblOvertimeHours.Location = New System.Drawing.Point(53, 220)
        Me.lblOvertimeHours.Name = "lblOvertimeHours"
        Me.lblOvertimeHours.Size = New System.Drawing.Size(80, 13)
        Me.lblOvertimeHours.TabIndex = 21
        Me.lblOvertimeHours.Text = "Overtime Hours"
        Me.lblOvertimeHours.Visible = False
        '
        'lblOvertimePay
        '
        Me.lblOvertimePay.AutoSize = True
        Me.lblOvertimePay.Location = New System.Drawing.Point(53, 283)
        Me.lblOvertimePay.Name = "lblOvertimePay"
        Me.lblOvertimePay.Size = New System.Drawing.Size(70, 13)
        Me.lblOvertimePay.TabIndex = 22
        Me.lblOvertimePay.Text = "Overtime Pay"
        Me.lblOvertimePay.Visible = False
        '
        'lblRegHours
        '
        Me.lblRegHours.AutoSize = True
        Me.lblRegHours.Location = New System.Drawing.Point(53, 187)
        Me.lblRegHours.Name = "lblRegHours"
        Me.lblRegHours.Size = New System.Drawing.Size(75, 13)
        Me.lblRegHours.TabIndex = 23
        Me.lblRegHours.Text = "Regular Hours"
        Me.lblRegHours.Visible = False
        '
        'txtOvertimeHours
        '
        Me.txtOvertimeHours.Location = New System.Drawing.Point(179, 217)
        Me.txtOvertimeHours.Name = "txtOvertimeHours"
        Me.txtOvertimeHours.ReadOnly = True
        Me.txtOvertimeHours.Size = New System.Drawing.Size(100, 20)
        Me.txtOvertimeHours.TabIndex = 24
        Me.txtOvertimeHours.Visible = False
        '
        'txtOvertimePay
        '
        Me.txtOvertimePay.Location = New System.Drawing.Point(179, 280)
        Me.txtOvertimePay.Name = "txtOvertimePay"
        Me.txtOvertimePay.ReadOnly = True
        Me.txtOvertimePay.Size = New System.Drawing.Size(100, 20)
        Me.txtOvertimePay.TabIndex = 25
        Me.txtOvertimePay.Visible = False
        '
        'txtRegPay
        '
        Me.txtRegPay.Location = New System.Drawing.Point(179, 247)
        Me.txtRegPay.Name = "txtRegPay"
        Me.txtRegPay.ReadOnly = True
        Me.txtRegPay.Size = New System.Drawing.Size(100, 20)
        Me.txtRegPay.TabIndex = 26
        Me.txtRegPay.Visible = False
        '
        'txtRegHours
        '
        Me.txtRegHours.Location = New System.Drawing.Point(179, 184)
        Me.txtRegHours.Name = "txtRegHours"
        Me.txtRegHours.ReadOnly = True
        Me.txtRegHours.Size = New System.Drawing.Size(100, 20)
        Me.txtRegHours.TabIndex = 27
        Me.txtRegHours.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(330, 528)
        Me.Controls.Add(Me.txtRegHours)
        Me.Controls.Add(Me.txtRegPay)
        Me.Controls.Add(Me.txtOvertimePay)
        Me.Controls.Add(Me.txtOvertimeHours)
        Me.Controls.Add(Me.lblRegHours)
        Me.Controls.Add(Me.lblOvertimePay)
        Me.Controls.Add(Me.lblOvertimeHours)
        Me.Controls.Add(Me.lblRegPay)
        Me.Controls.Add(Me.txtNetPay)
        Me.Controls.Add(Me.txtTotalDeductions)
        Me.Controls.Add(Me.txtPension)
        Me.Controls.Add(Me.txtIncomeTax)
        Me.Controls.Add(Me.txtGrossPay)
        Me.Controls.Add(Me.txtRate)
        Me.Controls.Add(Me.txtHours)
        Me.Controls.Add(Me.txtEmployee)
        Me.Controls.Add(Me.lblNetPay)
        Me.Controls.Add(Me.lblPension)
        Me.Controls.Add(Me.lblTotalDeductions)
        Me.Controls.Add(Me.lblIncomeTax)
        Me.Controls.Add(Me.lblGrossPay)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Paystub Calculator"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CalculateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblIncomeTax As System.Windows.Forms.Label
    Friend WithEvents lblTotalDeductions As System.Windows.Forms.Label
    Friend WithEvents lblPension As System.Windows.Forms.Label
    Friend WithEvents lblNetPay As System.Windows.Forms.Label
    Friend WithEvents txtEmployee As System.Windows.Forms.TextBox
    Friend WithEvents txtHours As System.Windows.Forms.TextBox
    Friend WithEvents txtRate As System.Windows.Forms.TextBox
    Friend WithEvents txtGrossPay As System.Windows.Forms.TextBox
    Friend WithEvents txtIncomeTax As System.Windows.Forms.TextBox
    Friend WithEvents txtPension As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalDeductions As System.Windows.Forms.TextBox
    Friend WithEvents txtNetPay As System.Windows.Forms.TextBox
    Friend WithEvents lblGrossPay As System.Windows.Forms.Label
    Friend WithEvents lblRegPay As System.Windows.Forms.Label
    Friend WithEvents lblOvertimeHours As System.Windows.Forms.Label
    Friend WithEvents lblOvertimePay As System.Windows.Forms.Label
    Friend WithEvents lblRegHours As System.Windows.Forms.Label
    Friend WithEvents txtOvertimeHours As System.Windows.Forms.TextBox
    Friend WithEvents txtOvertimePay As System.Windows.Forms.TextBox
    Friend WithEvents txtRegPay As System.Windows.Forms.TextBox
    Friend WithEvents txtRegHours As System.Windows.Forms.TextBox

End Class
