<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PeriodS = New System.Windows.Forms.Label()
        Me.PeriodE = New System.Windows.Forms.Label()
        Me.Hours = New System.Windows.Forms.Label()
        Me.Allowences = New System.Windows.Forms.Label()
        Me.Basic = New System.Windows.Forms.Label()
        Me.Salary = New System.Windows.Forms.Label()
        Me.Socso = New System.Windows.Forms.Label()
        Me.Tax = New System.Windows.Forms.Label()
        Me.Insurance = New System.Windows.Forms.Label()
        Me.Total = New System.Windows.Forms.Label()
        Me.NetPay = New System.Windows.Forms.Label()
        Me.HoursTB = New System.Windows.Forms.TextBox()
        Me.AllowencesTB = New System.Windows.Forms.TextBox()
        Me.BasicTB = New System.Windows.Forms.TextBox()
        Me.SalaryTB = New System.Windows.Forms.TextBox()
        Me.TaxTB = New System.Windows.Forms.TextBox()
        Me.InsuranceTB = New System.Windows.Forms.TextBox()
        Me.NetPayTB = New System.Windows.Forms.TextBox()
        Me.TotalTB = New System.Windows.Forms.TextBox()
        Me.CalculateB = New System.Windows.Forms.Button()
        Me.CloseB = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbtotaldaywork = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.txtreceipt = New System.Windows.Forms.RichTextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PeriodS
        '
        Me.PeriodS.AutoSize = True
        Me.PeriodS.BackColor = System.Drawing.Color.Transparent
        Me.PeriodS.Location = New System.Drawing.Point(32, 81)
        Me.PeriodS.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.PeriodS.Name = "PeriodS"
        Me.PeriodS.Size = New System.Drawing.Size(87, 17)
        Me.PeriodS.TabIndex = 0
        Me.PeriodS.Text = "Period Start:"
        '
        'PeriodE
        '
        Me.PeriodE.AutoSize = True
        Me.PeriodE.BackColor = System.Drawing.Color.Transparent
        Me.PeriodE.Location = New System.Drawing.Point(317, 81)
        Me.PeriodE.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.PeriodE.Name = "PeriodE"
        Me.PeriodE.Size = New System.Drawing.Size(82, 17)
        Me.PeriodE.TabIndex = 1
        Me.PeriodE.Text = "Period End:"
        '
        'Hours
        '
        Me.Hours.AutoSize = True
        Me.Hours.BackColor = System.Drawing.Color.Transparent
        Me.Hours.Location = New System.Drawing.Point(16, 119)
        Me.Hours.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Hours.Name = "Hours"
        Me.Hours.Size = New System.Drawing.Size(129, 17)
        Me.Hours.TabIndex = 4
        Me.Hours.Text = "No. Hours Worked:"
        '
        'Allowences
        '
        Me.Allowences.AutoSize = True
        Me.Allowences.BackColor = System.Drawing.Color.Transparent
        Me.Allowences.Location = New System.Drawing.Point(16, 164)
        Me.Allowences.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Allowences.Name = "Allowences"
        Me.Allowences.Size = New System.Drawing.Size(82, 17)
        Me.Allowences.TabIndex = 5
        Me.Allowences.Text = "Allowences:"
        '
        'Basic
        '
        Me.Basic.AutoSize = True
        Me.Basic.BackColor = System.Drawing.Color.Transparent
        Me.Basic.Location = New System.Drawing.Point(16, 210)
        Me.Basic.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Basic.Name = "Basic"
        Me.Basic.Size = New System.Drawing.Size(135, 17)
        Me.Basic.TabIndex = 6
        Me.Basic.Text = "Basic Pay Per Hour:"
        '
        'Salary
        '
        Me.Salary.AutoSize = True
        Me.Salary.BackColor = System.Drawing.Color.Transparent
        Me.Salary.Location = New System.Drawing.Point(16, 256)
        Me.Salary.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Salary.Name = "Salary"
        Me.Salary.Size = New System.Drawing.Size(88, 17)
        Me.Salary.TabIndex = 7
        Me.Salary.Text = "Total Salary:"
        '
        'Socso
        '
        Me.Socso.AutoSize = True
        Me.Socso.BackColor = System.Drawing.Color.Transparent
        Me.Socso.Location = New System.Drawing.Point(8, 78)
        Me.Socso.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Socso.Name = "Socso"
        Me.Socso.Size = New System.Drawing.Size(87, 17)
        Me.Socso.TabIndex = 9
        Me.Socso.Text = "SOCSO (%):"
        '
        'Tax
        '
        Me.Tax.AutoSize = True
        Me.Tax.BackColor = System.Drawing.Color.Transparent
        Me.Tax.Location = New System.Drawing.Point(8, 124)
        Me.Tax.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Tax.Name = "Tax"
        Me.Tax.Size = New System.Drawing.Size(110, 17)
        Me.Tax.TabIndex = 10
        Me.Tax.Text = "Income Tax (%):"
        '
        'Insurance
        '
        Me.Insurance.AutoSize = True
        Me.Insurance.BackColor = System.Drawing.Color.Transparent
        Me.Insurance.Location = New System.Drawing.Point(8, 169)
        Me.Insurance.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Insurance.Name = "Insurance"
        Me.Insurance.Size = New System.Drawing.Size(181, 17)
        Me.Insurance.TabIndex = 11
        Me.Insurance.Text = "Employment Insurance (%):" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Total
        '
        Me.Total.AutoSize = True
        Me.Total.BackColor = System.Drawing.Color.Transparent
        Me.Total.Location = New System.Drawing.Point(12, 506)
        Me.Total.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Total.Name = "Total"
        Me.Total.Size = New System.Drawing.Size(143, 17)
        Me.Total.TabIndex = 12
        Me.Total.Text = "TOTAL DEDUCTION:"
        '
        'NetPay
        '
        Me.NetPay.AutoSize = True
        Me.NetPay.BackColor = System.Drawing.Color.Transparent
        Me.NetPay.Location = New System.Drawing.Point(12, 545)
        Me.NetPay.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.NetPay.Name = "NetPay"
        Me.NetPay.Size = New System.Drawing.Size(152, 17)
        Me.NetPay.TabIndex = 13
        Me.NetPay.Text = "Net Pay for the Period:"
        '
        'HoursTB
        '
        Me.HoursTB.Location = New System.Drawing.Point(160, 116)
        Me.HoursTB.Margin = New System.Windows.Forms.Padding(4)
        Me.HoursTB.Name = "HoursTB"
        Me.HoursTB.Size = New System.Drawing.Size(132, 22)
        Me.HoursTB.TabIndex = 1
        '
        'AllowencesTB
        '
        Me.AllowencesTB.Location = New System.Drawing.Point(160, 160)
        Me.AllowencesTB.Margin = New System.Windows.Forms.Padding(4)
        Me.AllowencesTB.Name = "AllowencesTB"
        Me.AllowencesTB.Size = New System.Drawing.Size(132, 22)
        Me.AllowencesTB.TabIndex = 2
        '
        'BasicTB
        '
        Me.BasicTB.Location = New System.Drawing.Point(160, 207)
        Me.BasicTB.Margin = New System.Windows.Forms.Padding(4)
        Me.BasicTB.Name = "BasicTB"
        Me.BasicTB.Size = New System.Drawing.Size(132, 22)
        Me.BasicTB.TabIndex = 3
        '
        'SalaryTB
        '
        Me.SalaryTB.Location = New System.Drawing.Point(160, 252)
        Me.SalaryTB.Margin = New System.Windows.Forms.Padding(4)
        Me.SalaryTB.Name = "SalaryTB"
        Me.SalaryTB.ReadOnly = True
        Me.SalaryTB.Size = New System.Drawing.Size(132, 22)
        Me.SalaryTB.TabIndex = 17
        '
        'TaxTB
        '
        Me.TaxTB.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.TaxTB.Location = New System.Drawing.Point(195, 121)
        Me.TaxTB.Margin = New System.Windows.Forms.Padding(4)
        Me.TaxTB.Name = "TaxTB"
        Me.TaxTB.ReadOnly = True
        Me.TaxTB.Size = New System.Drawing.Size(132, 22)
        Me.TaxTB.TabIndex = 19
        Me.TaxTB.Text = "3"
        '
        'InsuranceTB
        '
        Me.InsuranceTB.Location = New System.Drawing.Point(195, 165)
        Me.InsuranceTB.Margin = New System.Windows.Forms.Padding(4)
        Me.InsuranceTB.Name = "InsuranceTB"
        Me.InsuranceTB.Size = New System.Drawing.Size(132, 22)
        Me.InsuranceTB.TabIndex = 1
        '
        'NetPayTB
        '
        Me.NetPayTB.Location = New System.Drawing.Point(172, 545)
        Me.NetPayTB.Margin = New System.Windows.Forms.Padding(4)
        Me.NetPayTB.Name = "NetPayTB"
        Me.NetPayTB.ReadOnly = True
        Me.NetPayTB.Size = New System.Drawing.Size(132, 22)
        Me.NetPayTB.TabIndex = 21
        '
        'TotalTB
        '
        Me.TotalTB.Location = New System.Drawing.Point(172, 502)
        Me.TotalTB.Margin = New System.Windows.Forms.Padding(4)
        Me.TotalTB.Name = "TotalTB"
        Me.TotalTB.ReadOnly = True
        Me.TotalTB.Size = New System.Drawing.Size(132, 22)
        Me.TotalTB.TabIndex = 22
        '
        'CalculateB
        '
        Me.CalculateB.BackColor = System.Drawing.Color.Transparent
        Me.CalculateB.Location = New System.Drawing.Point(16, 446)
        Me.CalculateB.Margin = New System.Windows.Forms.Padding(4)
        Me.CalculateB.Name = "CalculateB"
        Me.CalculateB.Size = New System.Drawing.Size(111, 38)
        Me.CalculateB.TabIndex = 4
        Me.CalculateB.Text = "Calculate"
        Me.CalculateB.UseVisualStyleBackColor = False
        '
        'CloseB
        '
        Me.CloseB.BackColor = System.Drawing.Color.Transparent
        Me.CloseB.Location = New System.Drawing.Point(667, 526)
        Me.CloseB.Margin = New System.Windows.Forms.Padding(4)
        Me.CloseB.Name = "CloseB"
        Me.CloseB.Size = New System.Drawing.Size(103, 36)
        Me.CloseB.TabIndex = 6
        Me.CloseB.Text = "Close"
        Me.CloseB.UseVisualStyleBackColor = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(33, 103)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(244, 22)
        Me.DateTimePicker1.TabIndex = 0
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(321, 103)
        Me.DateTimePicker2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(255, 22)
        Me.DateTimePicker2.TabIndex = 1
        '
        'ComboBox1
        '
        Me.ComboBox1.AllowDrop = True
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"3", "4", "5"})
        Me.ComboBox1.Location = New System.Drawing.Point(193, 74)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(133, 24)
        Me.ComboBox1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.ComboBox2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.tbtotaldaywork)
        Me.GroupBox1.Controls.Add(Me.Hours)
        Me.GroupBox1.Controls.Add(Me.HoursTB)
        Me.GroupBox1.Controls.Add(Me.AllowencesTB)
        Me.GroupBox1.Controls.Add(Me.BasicTB)
        Me.GroupBox1.Controls.Add(Me.SalaryTB)
        Me.GroupBox1.Controls.Add(Me.Allowences)
        Me.GroupBox1.Controls.Add(Me.Basic)
        Me.GroupBox1.Controls.Add(Me.Salary)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 134)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(315, 295)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 26)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 17)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Employee Name:"
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(160, 22)
        Me.ComboBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(132, 24)
        Me.ComboBox2.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 17)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Total Days Work:"
        '
        'tbtotaldaywork
        '
        Me.tbtotaldaywork.Location = New System.Drawing.Point(160, 70)
        Me.tbtotaldaywork.Margin = New System.Windows.Forms.Padding(4)
        Me.tbtotaldaywork.Name = "tbtotaldaywork"
        Me.tbtotaldaywork.ReadOnly = True
        Me.tbtotaldaywork.Size = New System.Drawing.Size(132, 22)
        Me.tbtotaldaywork.TabIndex = 18
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.ComboBox1)
        Me.GroupBox2.Controls.Add(Me.TaxTB)
        Me.GroupBox2.Controls.Add(Me.InsuranceTB)
        Me.GroupBox2.Controls.Add(Me.Insurance)
        Me.GroupBox2.Controls.Add(Me.Tax)
        Me.GroupBox2.Controls.Add(Me.Socso)
        Me.GroupBox2.Location = New System.Drawing.Point(519, 217)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(343, 213)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "DEDUCTION"
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.Transparent
        Me.btnPrint.Location = New System.Drawing.Point(489, 526)
        Me.btnPrint.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(103, 36)
        Me.btnPrint.TabIndex = 5
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintDocument1
        '
        '
        'txtreceipt
        '
        Me.txtreceipt.Location = New System.Drawing.Point(728, 78)
        Me.txtreceipt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtreceipt.Name = "txtreceipt"
        Me.txtreceipt.Size = New System.Drawing.Size(105, 84)
        Me.txtreceipt.TabIndex = 0
        Me.txtreceipt.Text = ""
        Me.txtreceipt.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(889, 581)
        Me.Controls.Add(Me.txtreceipt)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.CloseB)
        Me.Controls.Add(Me.CalculateB)
        Me.Controls.Add(Me.TotalTB)
        Me.Controls.Add(Me.NetPayTB)
        Me.Controls.Add(Me.NetPay)
        Me.Controls.Add(Me.Total)
        Me.Controls.Add(Me.PeriodE)
        Me.Controls.Add(Me.PeriodS)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PeriodS As Label
    Friend WithEvents PeriodE As Label
    Friend WithEvents Hours As Label
    Friend WithEvents Allowences As Label
    Friend WithEvents Basic As Label
    Friend WithEvents Salary As Label
    Friend WithEvents Socso As Label
    Friend WithEvents Tax As Label
    Friend WithEvents Insurance As Label
    Friend WithEvents Total As Label
    Friend WithEvents NetPay As Label
    Friend WithEvents HoursTB As TextBox
    Friend WithEvents AllowencesTB As TextBox
    Friend WithEvents BasicTB As TextBox
    Friend WithEvents SalaryTB As TextBox
    Friend WithEvents TaxTB As TextBox
    Friend WithEvents InsuranceTB As TextBox
    Friend WithEvents NetPayTB As TextBox
    Friend WithEvents TotalTB As TextBox
    Friend WithEvents CalculateB As Button
    Friend WithEvents CloseB As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnPrint As Button
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents Label1 As Label
    Friend WithEvents tbtotaldaywork As TextBox
    Friend WithEvents txtreceipt As RichTextBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label2 As Label
End Class
