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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PeriodS
        '
        Me.PeriodS.AutoSize = True
        Me.PeriodS.BackColor = System.Drawing.Color.Transparent
        Me.PeriodS.Location = New System.Drawing.Point(24, 13)
        Me.PeriodS.Name = "PeriodS"
        Me.PeriodS.Size = New System.Drawing.Size(65, 13)
        Me.PeriodS.TabIndex = 0
        Me.PeriodS.Text = "Period Start:"
        '
        'PeriodE
        '
        Me.PeriodE.AutoSize = True
        Me.PeriodE.BackColor = System.Drawing.Color.Transparent
        Me.PeriodE.Location = New System.Drawing.Point(238, 13)
        Me.PeriodE.Name = "PeriodE"
        Me.PeriodE.Size = New System.Drawing.Size(62, 13)
        Me.PeriodE.TabIndex = 1
        Me.PeriodE.Text = "Period End:"
        '
        'Hours
        '
        Me.Hours.AutoSize = True
        Me.Hours.BackColor = System.Drawing.Color.Transparent
        Me.Hours.Location = New System.Drawing.Point(6, 31)
        Me.Hours.Name = "Hours"
        Me.Hours.Size = New System.Drawing.Size(99, 13)
        Me.Hours.TabIndex = 4
        Me.Hours.Text = "No. Hours Worked:"
        '
        'Allowences
        '
        Me.Allowences.AutoSize = True
        Me.Allowences.BackColor = System.Drawing.Color.Transparent
        Me.Allowences.Location = New System.Drawing.Point(6, 63)
        Me.Allowences.Name = "Allowences"
        Me.Allowences.Size = New System.Drawing.Size(64, 13)
        Me.Allowences.TabIndex = 5
        Me.Allowences.Text = "Allowences:"
        '
        'Basic
        '
        Me.Basic.AutoSize = True
        Me.Basic.BackColor = System.Drawing.Color.Transparent
        Me.Basic.Location = New System.Drawing.Point(6, 101)
        Me.Basic.Name = "Basic"
        Me.Basic.Size = New System.Drawing.Size(102, 13)
        Me.Basic.TabIndex = 6
        Me.Basic.Text = "Basic Pay Per Hour:"
        '
        'Salary
        '
        Me.Salary.AutoSize = True
        Me.Salary.BackColor = System.Drawing.Color.Transparent
        Me.Salary.Location = New System.Drawing.Point(4, 137)
        Me.Salary.Name = "Salary"
        Me.Salary.Size = New System.Drawing.Size(66, 13)
        Me.Salary.TabIndex = 7
        Me.Salary.Text = "Total Salary:"
        '
        'Socso
        '
        Me.Socso.AutoSize = True
        Me.Socso.BackColor = System.Drawing.Color.Transparent
        Me.Socso.Location = New System.Drawing.Point(6, 63)
        Me.Socso.Name = "Socso"
        Me.Socso.Size = New System.Drawing.Size(64, 13)
        Me.Socso.TabIndex = 9
        Me.Socso.Text = "SOCSO (%):"
        '
        'Tax
        '
        Me.Tax.AutoSize = True
        Me.Tax.BackColor = System.Drawing.Color.Transparent
        Me.Tax.Location = New System.Drawing.Point(6, 101)
        Me.Tax.Name = "Tax"
        Me.Tax.Size = New System.Drawing.Size(83, 13)
        Me.Tax.TabIndex = 10
        Me.Tax.Text = "Income Tax (%):"
        '
        'Insurance
        '
        Me.Insurance.AutoSize = True
        Me.Insurance.BackColor = System.Drawing.Color.Transparent
        Me.Insurance.Location = New System.Drawing.Point(6, 137)
        Me.Insurance.Name = "Insurance"
        Me.Insurance.Size = New System.Drawing.Size(134, 13)
        Me.Insurance.TabIndex = 11
        Me.Insurance.Text = "Employment Insurance (%):" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Total
        '
        Me.Total.AutoSize = True
        Me.Total.BackColor = System.Drawing.Color.Transparent
        Me.Total.Location = New System.Drawing.Point(9, 325)
        Me.Total.Name = "Total"
        Me.Total.Size = New System.Drawing.Size(112, 13)
        Me.Total.TabIndex = 12
        Me.Total.Text = "TOTAL DEDUCTION:"
        '
        'NetPay
        '
        Me.NetPay.AutoSize = True
        Me.NetPay.BackColor = System.Drawing.Color.Transparent
        Me.NetPay.Location = New System.Drawing.Point(9, 357)
        Me.NetPay.Name = "NetPay"
        Me.NetPay.Size = New System.Drawing.Size(114, 13)
        Me.NetPay.TabIndex = 13
        Me.NetPay.Text = "Net Pay for the Period:"
        '
        'HoursTB
        '
        Me.HoursTB.Location = New System.Drawing.Point(114, 24)
        Me.HoursTB.Name = "HoursTB"
        Me.HoursTB.Size = New System.Drawing.Size(100, 20)
        Me.HoursTB.TabIndex = 14
        '
        'AllowencesTB
        '
        Me.AllowencesTB.Location = New System.Drawing.Point(114, 60)
        Me.AllowencesTB.Name = "AllowencesTB"
        Me.AllowencesTB.Size = New System.Drawing.Size(100, 20)
        Me.AllowencesTB.TabIndex = 15
        '
        'BasicTB
        '
        Me.BasicTB.Location = New System.Drawing.Point(114, 98)
        Me.BasicTB.Name = "BasicTB"
        Me.BasicTB.Size = New System.Drawing.Size(100, 20)
        Me.BasicTB.TabIndex = 16
        '
        'SalaryTB
        '
        Me.SalaryTB.Location = New System.Drawing.Point(114, 134)
        Me.SalaryTB.Name = "SalaryTB"
        Me.SalaryTB.ReadOnly = True
        Me.SalaryTB.Size = New System.Drawing.Size(100, 20)
        Me.SalaryTB.TabIndex = 17
        '
        'TaxTB
        '
        Me.TaxTB.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.TaxTB.Location = New System.Drawing.Point(146, 98)
        Me.TaxTB.Name = "TaxTB"
        Me.TaxTB.ReadOnly = True
        Me.TaxTB.Size = New System.Drawing.Size(100, 20)
        Me.TaxTB.TabIndex = 19
        Me.TaxTB.Text = "3"
        '
        'InsuranceTB
        '
        Me.InsuranceTB.Location = New System.Drawing.Point(146, 134)
        Me.InsuranceTB.Name = "InsuranceTB"
        Me.InsuranceTB.Size = New System.Drawing.Size(100, 20)
        Me.InsuranceTB.TabIndex = 20
        '
        'NetPayTB
        '
        Me.NetPayTB.Location = New System.Drawing.Point(132, 354)
        Me.NetPayTB.Name = "NetPayTB"
        Me.NetPayTB.ReadOnly = True
        Me.NetPayTB.Size = New System.Drawing.Size(100, 20)
        Me.NetPayTB.TabIndex = 21
        '
        'TotalTB
        '
        Me.TotalTB.Location = New System.Drawing.Point(132, 322)
        Me.TotalTB.Name = "TotalTB"
        Me.TotalTB.ReadOnly = True
        Me.TotalTB.Size = New System.Drawing.Size(100, 20)
        Me.TotalTB.TabIndex = 22
        '
        'CalculateB
        '
        Me.CalculateB.BackColor = System.Drawing.Color.Transparent
        Me.CalculateB.Location = New System.Drawing.Point(12, 274)
        Me.CalculateB.Name = "CalculateB"
        Me.CalculateB.Size = New System.Drawing.Size(83, 31)
        Me.CalculateB.TabIndex = 23
        Me.CalculateB.Text = "Calculate"
        Me.CalculateB.UseVisualStyleBackColor = False
        '
        'CloseB
        '
        Me.CloseB.BackColor = System.Drawing.Color.Transparent
        Me.CloseB.Location = New System.Drawing.Point(501, 325)
        Me.CloseB.Name = "CloseB"
        Me.CloseB.Size = New System.Drawing.Size(77, 29)
        Me.CloseB.TabIndex = 25
        Me.CloseB.Text = "Close"
        Me.CloseB.UseVisualStyleBackColor = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(26, 29)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(2)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(184, 20)
        Me.DateTimePicker1.TabIndex = 26
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(241, 29)
        Me.DateTimePicker2.Margin = New System.Windows.Forms.Padding(2)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(192, 20)
        Me.DateTimePicker2.TabIndex = 27
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(189, 350)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 28
        '
        'ComboBox1
        '
        Me.ComboBox1.AllowDrop = True
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"3", "4", "5"})
        Me.ComboBox1.Location = New System.Drawing.Point(145, 60)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(101, 21)
        Me.ComboBox1.TabIndex = 29
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(624, 84)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 30
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(624, 114)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 13)
        Me.Label3.TabIndex = 31
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(624, 145)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 13)
        Me.Label4.TabIndex = 32
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(624, 176)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 13)
        Me.Label5.TabIndex = 33
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Hours)
        Me.GroupBox1.Controls.Add(Me.HoursTB)
        Me.GroupBox1.Controls.Add(Me.AllowencesTB)
        Me.GroupBox1.Controls.Add(Me.BasicTB)
        Me.GroupBox1.Controls.Add(Me.SalaryTB)
        Me.GroupBox1.Controls.Add(Me.Allowences)
        Me.GroupBox1.Controls.Add(Me.Basic)
        Me.GroupBox1.Controls.Add(Me.Salary)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 84)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(236, 173)
        Me.GroupBox1.TabIndex = 34
        Me.GroupBox1.TabStop = False
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
        Me.GroupBox2.Location = New System.Drawing.Point(367, 84)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(257, 173)
        Me.GroupBox2.TabIndex = 35
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "DEDUCTION"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(626, 402)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
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
        Me.Name = "Form1"
        Me.Text = "Form1"
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
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
End Class
