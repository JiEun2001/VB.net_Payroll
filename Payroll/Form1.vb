Imports System.Data.OleDb
Public Class Form1
    Dim connection As New OleDbConnection(My.Settings.vbprojectConnectionString)
    Private Sub PeriodS_Click(sender As Object, e As EventArgs) Handles PeriodS.Click

    End Sub

    Private Sub Salary_Click(sender As Object, e As EventArgs) Handles Salary.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection.Open()
        Dim cmd1 As New OleDbCommand("Select EmployeeName from Employee", connection)
        Dim dr As OleDbDataReader = cmd1.ExecuteReader
        While dr.Read
            ComboBox2.Items.Add(dr(0).ToString)
        End While
        dr.Close()
        connection.Close()
    End Sub

    Private Sub CloseB_Click(sender As Object, e As EventArgs) Handles CloseB.Click
        Me.Close()
        Form2.Show()
    End Sub

    Protected Overrides ReadOnly Property CreateParams As System.Windows.Forms.CreateParams
        Get
            Dim par As CreateParams = MyBase.CreateParams
            par.ClassStyle = (par.ClassStyle Or 512)
            Return par
        End Get
    End Property

    Private Sub CalculateB_Click(sender As Object, e As EventArgs) Handles CalculateB.Click
        '2 date
        Dim borrow As DateTime = Convert.ToDateTime(DateTimePicker1.Text)
        Dim back As DateTime = Convert.ToDateTime(DateTimePicker2.Text)
        Dim countdays As TimeSpan = back.Subtract(borrow)
        Dim totaldays = Convert.ToInt32(countdays.Days) + 1

        Dim totalsalary As Integer
        Dim totalsalarychange As Double
        Dim socso As Double
        Dim tax As Double
        Dim insurance As Double
        Dim totaldeduction As Double


        'Label1.Text = totaldays
        If Convert.ToInt32(countdays.Days) >= 0 Then
            If ComboBox2.SelectedItem = "" Then
                MsgBox("Please choose Employee!", MsgBoxStyle.Exclamation)
            Else

                'total salary
                tbtotaldaywork.Text = totaldays
                If AllowencesTB.Text.Equals("") Then
                    AllowencesTB.Text = "0"
                End If
                Try
                    totalsalary = ((totaldays * HoursTB.Text) * BasicTB.Text) + AllowencesTB.Text
                Catch ex As Exception
                    MsgBox("Pleaase insert all data", MsgBoxStyle.Exclamation)
                End Try
                SalaryTB.Text = totalsalary.ToString

                'total deduction
                If ComboBox1.Text.Equals("") Then
                    MsgBox("Please choose SOCSO %!", MsgBoxStyle.Exclamation)
                Else
                    If InsuranceTB.Text.Equals("") Then
                        MsgBox("Please Employment Insurance!", MsgBoxStyle.Exclamation)
                    Else

                        If CInt(InsuranceTB.Text) < 0 Or CInt(InsuranceTB.Text) > 100 Then
                            MsgBox("Please insert Employment Insurance from 0 to 100", MsgBoxStyle.Exclamation)
                        Else
                            totalsalarychange = Convert.ToDouble(totalsalary)

                            socso = Convert.ToDouble(ComboBox1.SelectedItem) / 100
                            'Label2.Text = totalsalarychange
                            totalsalarychange = totalsalarychange - (totalsalarychange * socso)
                            'Label3.Text = Math.Round(totalsalarychange, 2)

                            tax = Convert.ToDouble(TaxTB.Text) / 100
                            totalsalarychange = totalsalarychange - (totalsalarychange * tax)
                            'Label4.Text = Math.Round(totalsalarychange, 2)

                            insurance = Convert.ToDouble(InsuranceTB.Text) / 100
                            totalsalarychange = totalsalarychange - (totalsalarychange * insurance)
                            'Label5.Text = Math.Round(totalsalarychange, 2)


                            totaldeduction = totalsalary - totalsalarychange
                            TotalTB.Text = "RM " & totaldeduction.ToString("N2")

                            NetPayTB.Text = "RM " & (totalsalary - totaldeduction).ToString("N2")



                        End If
                    End If
                End If
            End If


        Else
            Label1.Text = "Check the dates"
        End If

    End Sub

    Private Sub NetPay_Click(sender As Object, e As EventArgs) Handles NetPay.Click

    End Sub





    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        txtreceipt.Text = ""

        txtreceipt.AppendText("" + vbNewLine)
        txtreceipt.AppendText("" + vbNewLine)

        txtreceipt.AppendText(vbTab + vbTab + vbTab + vbTab + vbTab & "PAY-SLIP" + vbNewLine)
        txtreceipt.AppendText("" + vbNewLine)
        txtreceipt.AppendText("" + vbNewLine)
        txtreceipt.AppendText("Employee Name: " + ComboBox2.SelectedItem.ToString.ToUpper + vbNewLine)
        txtreceipt.AppendText("" + vbNewLine)
        txtreceipt.AppendText("Period Start:" + vbTab + DateTimePicker1.Value.Date + vbNewLine)
        txtreceipt.AppendText("Period End:" + vbTab + DateTimePicker2.Value.Date + vbNewLine)
        txtreceipt.AppendText("= = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = " + vbNewLine)
        txtreceipt.AppendText(vbTab + vbTab + vbTab + vbTab + vbTab & "SALARY INFO" + vbNewLine)
        txtreceipt.AppendText("Total Days Work: " + vbTab + tbtotaldaywork.Text + vbNewLine)
        txtreceipt.AppendText("No. Hours of Work:" + vbTab + HoursTB.Text + vbNewLine)
        txtreceipt.AppendText("Allowences:" + vbTab + vbTab + AllowencesTB.Text + vbNewLine)
        txtreceipt.AppendText("Basic Pay Per Hour:" + vbTab + BasicTB.Text + vbNewLine)
        txtreceipt.AppendText("" + vbNewLine)
        txtreceipt.AppendText("" + vbNewLine)
        txtreceipt.AppendText("Total Salary:" + vbTab + SalaryTB.Text + vbNewLine)
        txtreceipt.AppendText("= = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = " + vbNewLine)
        txtreceipt.AppendText(vbTab + vbTab + vbTab + vbTab + vbTab & "DEDUCTION" + vbNewLine)
        txtreceipt.AppendText("SOCSO Percentage:" + vbTab + ComboBox1.SelectedItem + "%" + vbNewLine)
        txtreceipt.AppendText("Income Tax:" + vbTab + vbTab + TaxTB.Text + "%" + vbNewLine)
        txtreceipt.AppendText("Employment Insurance" + vbTab + InsuranceTB.Text + "%" + vbNewLine)
        txtreceipt.AppendText("" + vbNewLine)
        txtreceipt.AppendText("" + vbNewLine)
        txtreceipt.AppendText("Total Deduction:" + vbTab + TotalTB.Text + vbTab + "Total Net Pay:" + vbTab + NetPayTB.Text + vbNewLine)
        txtreceipt.AppendText("= = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = " + vbNewLine)
        txtreceipt.AppendText(vbTab & "Due Date: " + DateTime.Now.ToString("dd/MM/yyyy") & vbTab + vbTab + vbTab + vbTab + vbTab + vbTab & "Time: " & DateTime.Now.ToString("HH:mm:ss") + vbNewLine)
        txtreceipt.AppendText("= = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = " + vbNewLine)
        'txtreceipt.AppendText()
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        'Dim fnttext As Font = txtreceipt.Font
        e.Graphics.DrawString(txtreceipt.Text, Font, Brushes.Black, 140, 140)

    End Sub

    Private Sub Total_Click(sender As Object, e As EventArgs) Handles Total.Click

    End Sub

    Private Sub AllowencesTB_TextChanged(sender As Object, e As EventArgs) Handles AllowencesTB.TextChanged

    End Sub
End Class
