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
        Me.PeriodS = New System.Windows.Forms.Label()
        Me.PeriodE = New System.Windows.Forms.Label()
        Me.PeriodSTB = New System.Windows.Forms.TextBox()
        Me.PeriodETB = New System.Windows.Forms.TextBox()
        Me.Hours = New System.Windows.Forms.Label()
        Me.Allowences = New System.Windows.Forms.Label()
        Me.Basic = New System.Windows.Forms.Label()
        Me.Salary = New System.Windows.Forms.Label()
        Me.Deduction = New System.Windows.Forms.Label()
        Me.Socso = New System.Windows.Forms.Label()
        Me.Tax = New System.Windows.Forms.Label()
        Me.Insurance = New System.Windows.Forms.Label()
        Me.Total = New System.Windows.Forms.Label()
        Me.NetPay = New System.Windows.Forms.Label()
        Me.HoursTB = New System.Windows.Forms.TextBox()
        Me.AllowencesTB = New System.Windows.Forms.TextBox()
        Me.BasicTB = New System.Windows.Forms.TextBox()
        Me.SalaryTB = New System.Windows.Forms.TextBox()
        Me.SocsoTB = New System.Windows.Forms.TextBox()
        Me.TaxTB = New System.Windows.Forms.TextBox()
        Me.InsuranceTB = New System.Windows.Forms.TextBox()
        Me.NetPayTB = New System.Windows.Forms.TextBox()
        Me.TotalTB = New System.Windows.Forms.TextBox()
        Me.CalculateB = New System.Windows.Forms.Button()
        Me.SaveB = New System.Windows.Forms.Button()
        Me.CloseB = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'PeriodS
        '
        Me.PeriodS.AutoSize = True
        Me.PeriodS.Location = New System.Drawing.Point(24, 13)
        Me.PeriodS.Name = "PeriodS"
        Me.PeriodS.Size = New System.Drawing.Size(65, 13)
        Me.PeriodS.TabIndex = 0
        Me.PeriodS.Text = "Period Start:"
        '
        'PeriodE
        '
        Me.PeriodE.AutoSize = True
        Me.PeriodE.Location = New System.Drawing.Point(187, 13)
        Me.PeriodE.Name = "PeriodE"
        Me.PeriodE.Size = New System.Drawing.Size(62, 13)
        Me.PeriodE.TabIndex = 1
        Me.PeriodE.Text = "Period End:"
        '
        'PeriodSTB
        '
        Me.PeriodSTB.Location = New System.Drawing.Point(27, 29)
        Me.PeriodSTB.Name = "PeriodSTB"
        Me.PeriodSTB.Size = New System.Drawing.Size(120, 20)
        Me.PeriodSTB.TabIndex = 2
        '
        'PeriodETB
        '
        Me.PeriodETB.Location = New System.Drawing.Point(190, 29)
        Me.PeriodETB.Name = "PeriodETB"
        Me.PeriodETB.Size = New System.Drawing.Size(119, 20)
        Me.PeriodETB.TabIndex = 3
        '
        'Hours
        '
        Me.Hours.AutoSize = True
        Me.Hours.Location = New System.Drawing.Point(24, 87)
        Me.Hours.Name = "Hours"
        Me.Hours.Size = New System.Drawing.Size(99, 13)
        Me.Hours.TabIndex = 4
        Me.Hours.Text = "No. Hours Worked:"
        '
        'Allowences
        '
        Me.Allowences.AutoSize = True
        Me.Allowences.Location = New System.Drawing.Point(24, 117)
        Me.Allowences.Name = "Allowences"
        Me.Allowences.Size = New System.Drawing.Size(64, 13)
        Me.Allowences.TabIndex = 5
        Me.Allowences.Text = "Allowences:"
        '
        'Basic
        '
        Me.Basic.AutoSize = True
        Me.Basic.Location = New System.Drawing.Point(24, 146)
        Me.Basic.Name = "Basic"
        Me.Basic.Size = New System.Drawing.Size(57, 13)
        Me.Basic.TabIndex = 6
        Me.Basic.Text = "Basic Pay:"
        '
        'Salary
        '
        Me.Salary.AutoSize = True
        Me.Salary.Location = New System.Drawing.Point(24, 176)
        Me.Salary.Name = "Salary"
        Me.Salary.Size = New System.Drawing.Size(66, 13)
        Me.Salary.TabIndex = 7
        Me.Salary.Text = "Total Salary:"
        '
        'Deduction
        '
        Me.Deduction.AutoSize = True
        Me.Deduction.Location = New System.Drawing.Point(368, 67)
        Me.Deduction.Name = "Deduction"
        Me.Deduction.Size = New System.Drawing.Size(71, 13)
        Me.Deduction.TabIndex = 8
        Me.Deduction.Text = "DEDUCTION"
        '
        'Socso
        '
        Me.Socso.AutoSize = True
        Me.Socso.Location = New System.Drawing.Point(368, 117)
        Me.Socso.Name = "Socso"
        Me.Socso.Size = New System.Drawing.Size(47, 13)
        Me.Socso.TabIndex = 9
        Me.Socso.Text = "SOCSO:"
        '
        'Tax
        '
        Me.Tax.AutoSize = True
        Me.Tax.Location = New System.Drawing.Point(368, 146)
        Me.Tax.Name = "Tax"
        Me.Tax.Size = New System.Drawing.Size(66, 13)
        Me.Tax.TabIndex = 10
        Me.Tax.Text = "Income Tax:"
        '
        'Insurance
        '
        Me.Insurance.AutoSize = True
        Me.Insurance.Location = New System.Drawing.Point(368, 176)
        Me.Insurance.Name = "Insurance"
        Me.Insurance.Size = New System.Drawing.Size(117, 13)
        Me.Insurance.TabIndex = 11
        Me.Insurance.Text = "Employment Insurance:"
        '
        'Total
        '
        Me.Total.AutoSize = True
        Me.Total.Location = New System.Drawing.Point(24, 272)
        Me.Total.Name = "Total"
        Me.Total.Size = New System.Drawing.Size(112, 13)
        Me.Total.TabIndex = 12
        Me.Total.Text = "TOTAL DEDUCTION:"
        '
        'NetPay
        '
        Me.NetPay.AutoSize = True
        Me.NetPay.Location = New System.Drawing.Point(24, 303)
        Me.NetPay.Name = "NetPay"
        Me.NetPay.Size = New System.Drawing.Size(114, 13)
        Me.NetPay.TabIndex = 13
        Me.NetPay.Text = "Net Pay for the Period:"
        '
        'HoursTB
        '
        Me.HoursTB.Location = New System.Drawing.Point(129, 84)
        Me.HoursTB.Name = "HoursTB"
        Me.HoursTB.Size = New System.Drawing.Size(100, 20)
        Me.HoursTB.TabIndex = 14
        '
        'AllowencesTB
        '
        Me.AllowencesTB.Location = New System.Drawing.Point(129, 114)
        Me.AllowencesTB.Name = "AllowencesTB"
        Me.AllowencesTB.Size = New System.Drawing.Size(100, 20)
        Me.AllowencesTB.TabIndex = 15
        '
        'BasicTB
        '
        Me.BasicTB.Location = New System.Drawing.Point(129, 143)
        Me.BasicTB.Name = "BasicTB"
        Me.BasicTB.Size = New System.Drawing.Size(100, 20)
        Me.BasicTB.TabIndex = 16
        '
        'SalaryTB
        '
        Me.SalaryTB.Location = New System.Drawing.Point(129, 173)
        Me.SalaryTB.Name = "SalaryTB"
        Me.SalaryTB.Size = New System.Drawing.Size(100, 20)
        Me.SalaryTB.TabIndex = 17
        '
        'SocsoTB
        '
        Me.SocsoTB.Location = New System.Drawing.Point(491, 114)
        Me.SocsoTB.Name = "SocsoTB"
        Me.SocsoTB.Size = New System.Drawing.Size(100, 20)
        Me.SocsoTB.TabIndex = 18
        '
        'TaxTB
        '
        Me.TaxTB.Location = New System.Drawing.Point(491, 143)
        Me.TaxTB.Name = "TaxTB"
        Me.TaxTB.Size = New System.Drawing.Size(100, 20)
        Me.TaxTB.TabIndex = 19
        '
        'InsuranceTB
        '
        Me.InsuranceTB.Location = New System.Drawing.Point(491, 173)
        Me.InsuranceTB.Name = "InsuranceTB"
        Me.InsuranceTB.Size = New System.Drawing.Size(100, 20)
        Me.InsuranceTB.TabIndex = 20
        '
        'NetPayTB
        '
        Me.NetPayTB.Location = New System.Drawing.Point(144, 300)
        Me.NetPayTB.Name = "NetPayTB"
        Me.NetPayTB.Size = New System.Drawing.Size(100, 20)
        Me.NetPayTB.TabIndex = 21
        '
        'TotalTB
        '
        Me.TotalTB.Location = New System.Drawing.Point(144, 269)
        Me.TotalTB.Name = "TotalTB"
        Me.TotalTB.Size = New System.Drawing.Size(100, 20)
        Me.TotalTB.TabIndex = 22
        '
        'CalculateB
        '
        Me.CalculateB.Location = New System.Drawing.Point(261, 215)
        Me.CalculateB.Name = "CalculateB"
        Me.CalculateB.Size = New System.Drawing.Size(75, 23)
        Me.CalculateB.TabIndex = 23
        Me.CalculateB.Text = "Calculate"
        Me.CalculateB.UseVisualStyleBackColor = True
        '
        'SaveB
        '
        Me.SaveB.Location = New System.Drawing.Point(435, 293)
        Me.SaveB.Name = "SaveB"
        Me.SaveB.Size = New System.Drawing.Size(75, 23)
        Me.SaveB.TabIndex = 24
        Me.SaveB.Text = "Save"
        Me.SaveB.UseVisualStyleBackColor = True
        '
        'CloseB
        '
        Me.CloseB.Location = New System.Drawing.Point(516, 293)
        Me.CloseB.Name = "CloseB"
        Me.CloseB.Size = New System.Drawing.Size(75, 23)
        Me.CloseB.TabIndex = 25
        Me.CloseB.Text = "Close"
        Me.CloseB.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.CloseB)
        Me.Controls.Add(Me.SaveB)
        Me.Controls.Add(Me.CalculateB)
        Me.Controls.Add(Me.TotalTB)
        Me.Controls.Add(Me.NetPayTB)
        Me.Controls.Add(Me.InsuranceTB)
        Me.Controls.Add(Me.TaxTB)
        Me.Controls.Add(Me.SocsoTB)
        Me.Controls.Add(Me.SalaryTB)
        Me.Controls.Add(Me.BasicTB)
        Me.Controls.Add(Me.AllowencesTB)
        Me.Controls.Add(Me.HoursTB)
        Me.Controls.Add(Me.NetPay)
        Me.Controls.Add(Me.Total)
        Me.Controls.Add(Me.Insurance)
        Me.Controls.Add(Me.Tax)
        Me.Controls.Add(Me.Socso)
        Me.Controls.Add(Me.Deduction)
        Me.Controls.Add(Me.Salary)
        Me.Controls.Add(Me.Basic)
        Me.Controls.Add(Me.Allowences)
        Me.Controls.Add(Me.Hours)
        Me.Controls.Add(Me.PeriodETB)
        Me.Controls.Add(Me.PeriodSTB)
        Me.Controls.Add(Me.PeriodE)
        Me.Controls.Add(Me.PeriodS)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PeriodS As Label
    Friend WithEvents PeriodE As Label
    Friend WithEvents PeriodSTB As TextBox
    Friend WithEvents PeriodETB As TextBox
    Friend WithEvents Hours As Label
    Friend WithEvents Allowences As Label
    Friend WithEvents Basic As Label
    Friend WithEvents Salary As Label
    Friend WithEvents Deduction As Label
    Friend WithEvents Socso As Label
    Friend WithEvents Tax As Label
    Friend WithEvents Insurance As Label
    Friend WithEvents Total As Label
    Friend WithEvents NetPay As Label
    Friend WithEvents HoursTB As TextBox
    Friend WithEvents AllowencesTB As TextBox
    Friend WithEvents BasicTB As TextBox
    Friend WithEvents SalaryTB As TextBox
    Friend WithEvents SocsoTB As TextBox
    Friend WithEvents TaxTB As TextBox
    Friend WithEvents InsuranceTB As TextBox
    Friend WithEvents NetPayTB As TextBox
    Friend WithEvents TotalTB As TextBox
    Friend WithEvents CalculateB As Button
    Friend WithEvents SaveB As Button
    Friend WithEvents CloseB As Button
End Class
