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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtMessage = New System.Windows.Forms.TextBox
        Me.txtName = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.radBlack = New System.Windows.Forms.RadioButton
        Me.radBlue = New System.Windows.Forms.RadioButton
        Me.radGreen = New System.Windows.Forms.RadioButton
        Me.radRed = New System.Windows.Forms.RadioButton
        Me.chkVisible = New System.Windows.Forms.CheckBox
        Me.txtOutPut = New System.Windows.Forms.TextBox
        Me.btnDisplay = New System.Windows.Forms.Button
        Me.btnClear = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.picBig = New System.Windows.Forms.PictureBox
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.picSmall = New System.Windows.Forms.PictureBox
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GoodbyeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ClearMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.btnMessageBox = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.picBig, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSmall, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtMessage)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(36, 38)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(516, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'txtMessage
        '
        Me.txtMessage.Location = New System.Drawing.Point(85, 62)
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.Size = New System.Drawing.Size(399, 20)
        Me.txtMessage.TabIndex = 3
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(85, 30)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(399, 20)
        Me.txtName.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "&Message"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Name"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.radBlack)
        Me.GroupBox2.Controls.Add(Me.radBlue)
        Me.GroupBox2.Controls.Add(Me.radGreen)
        Me.GroupBox2.Controls.Add(Me.radRed)
        Me.GroupBox2.Location = New System.Drawing.Point(36, 191)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(160, 138)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'radBlack
        '
        Me.radBlack.AutoSize = True
        Me.radBlack.Location = New System.Drawing.Point(33, 100)
        Me.radBlack.Name = "radBlack"
        Me.radBlack.Size = New System.Drawing.Size(52, 17)
        Me.radBlack.TabIndex = 3
        Me.radBlack.TabStop = True
        Me.radBlack.Text = "B&lack"
        Me.radBlack.UseVisualStyleBackColor = True
        '
        'radBlue
        '
        Me.radBlue.AutoSize = True
        Me.radBlue.Location = New System.Drawing.Point(33, 77)
        Me.radBlue.Name = "radBlue"
        Me.radBlue.Size = New System.Drawing.Size(46, 17)
        Me.radBlue.TabIndex = 2
        Me.radBlue.TabStop = True
        Me.radBlue.Text = "&Blue"
        Me.radBlue.UseVisualStyleBackColor = True
        '
        'radGreen
        '
        Me.radGreen.AutoSize = True
        Me.radGreen.Location = New System.Drawing.Point(33, 54)
        Me.radGreen.Name = "radGreen"
        Me.radGreen.Size = New System.Drawing.Size(54, 17)
        Me.radGreen.TabIndex = 1
        Me.radGreen.TabStop = True
        Me.radGreen.Text = "&Green"
        Me.radGreen.UseVisualStyleBackColor = True
        '
        'radRed
        '
        Me.radRed.AutoSize = True
        Me.radRed.Location = New System.Drawing.Point(33, 31)
        Me.radRed.Name = "radRed"
        Me.radRed.Size = New System.Drawing.Size(45, 17)
        Me.radRed.TabIndex = 0
        Me.radRed.TabStop = True
        Me.radRed.Text = "&Red"
        Me.radRed.UseVisualStyleBackColor = True
        '
        'chkVisible
        '
        Me.chkVisible.AutoSize = True
        Me.chkVisible.Location = New System.Drawing.Point(439, 191)
        Me.chkVisible.Name = "chkVisible"
        Me.chkVisible.Size = New System.Drawing.Size(102, 17)
        Me.chkVisible.TabIndex = 2
        Me.chkVisible.Text = "Message &Visible"
        Me.chkVisible.UseVisualStyleBackColor = True
        '
        'txtOutPut
        '
        Me.txtOutPut.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtOutPut.Location = New System.Drawing.Point(254, 214)
        Me.txtOutPut.Multiline = True
        Me.txtOutPut.Name = "txtOutPut"
        Me.txtOutPut.Size = New System.Drawing.Size(419, 115)
        Me.txtOutPut.TabIndex = 3
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(598, 47)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(75, 23)
        Me.btnDisplay.TabIndex = 4
        Me.btnDisplay.Text = "&Display"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(598, 85)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(598, 123)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'picBig
        '
        Me.picBig.Image = CType(resources.GetObject("picBig.Image"), System.Drawing.Image)
        Me.picBig.Location = New System.Drawing.Point(38, 374)
        Me.picBig.Name = "picBig"
        Me.picBig.Size = New System.Drawing.Size(157, 101)
        Me.picBig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBig.TabIndex = 7
        Me.picBig.TabStop = False
        Me.ToolTip1.SetToolTip(Me.picBig, "Click Here!")
        Me.picBig.Visible = False
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'picSmall
        '
        Me.picSmall.Image = CType(resources.GetObject("picSmall.Image"), System.Drawing.Image)
        Me.picSmall.Location = New System.Drawing.Point(69, 397)
        Me.picSmall.Name = "picSmall"
        Me.picSmall.Size = New System.Drawing.Size(88, 52)
        Me.picSmall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSmall.TabIndex = 8
        Me.picSmall.TabStop = False
        Me.ToolTip1.SetToolTip(Me.picSmall, "Click Here!")
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ClearMenuToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MenuStrip1.Size = New System.Drawing.Size(718, 24)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GoodbyeToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'GoodbyeToolStripMenuItem
        '
        Me.GoodbyeToolStripMenuItem.Name = "GoodbyeToolStripMenuItem"
        Me.GoodbyeToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.GoodbyeToolStripMenuItem.Text = "&Goodbye"
        '
        'ClearMenuToolStripMenuItem
        '
        Me.ClearMenuToolStripMenuItem.Name = "ClearMenuToolStripMenuItem"
        Me.ClearMenuToolStripMenuItem.Size = New System.Drawing.Size(95, 20)
        Me.ClearMenuToolStripMenuItem.Text = "Clear &Message"
        '
        'btnMessageBox
        '
        Me.btnMessageBox.Location = New System.Drawing.Point(399, 397)
        Me.btnMessageBox.Name = "btnMessageBox"
        Me.btnMessageBox.Size = New System.Drawing.Size(153, 65)
        Me.btnMessageBox.TabIndex = 11
        Me.btnMessageBox.Text = "Click Me!"
        Me.btnMessageBox.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AccessibleName = ""
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(718, 515)
        Me.Controls.Add(Me.btnMessageBox)
        Me.Controls.Add(Me.picSmall)
        Me.Controls.Add(Me.picBig)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.txtOutPut)
        Me.Controls.Add(Me.chkVisible)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "VBInterface"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.picBig, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSmall, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtMessage As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents radBlack As System.Windows.Forms.RadioButton
    Friend WithEvents radBlue As System.Windows.Forms.RadioButton
    Friend WithEvents radGreen As System.Windows.Forms.RadioButton
    Friend WithEvents radRed As System.Windows.Forms.RadioButton
    Friend WithEvents chkVisible As System.Windows.Forms.CheckBox
    Friend WithEvents txtOutPut As System.Windows.Forms.TextBox
    Friend WithEvents btnDisplay As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents picBig As System.Windows.Forms.PictureBox
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents picSmall As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearMenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GoodbyeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnMessageBox As System.Windows.Forms.Button

End Class
