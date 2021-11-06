Public Class Form1
    Private Sub PeriodS_Click(sender As Object, e As EventArgs) Handles PeriodS.Click

    End Sub

    Private Sub Salary_Click(sender As Object, e As EventArgs) Handles Salary.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
            'total salary
            Label1.Text = totaldays
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
                        MsgBox("Please insert Employment Insurance from 1 to 100", MsgBoxStyle.Exclamation)
                    Else
                        totalsalarychange = Convert.ToDouble(totalsalary)

                        socso = Convert.ToDouble(ComboBox1.SelectedItem) / 100
                        Label2.Text = totalsalarychange
                        totalsalarychange = totalsalarychange - (totalsalarychange * socso)
                        Label3.Text = Math.Round(totalsalarychange, 2)

                        tax = Convert.ToDouble(TaxTB.Text) / 100
                        totalsalarychange = totalsalarychange - (totalsalarychange * tax)
                        Label4.Text = Math.Round(totalsalarychange, 2)

                        insurance = Convert.ToDouble(InsuranceTB.Text) / 100
                        totalsalarychange = totalsalarychange - (totalsalarychange * insurance)
                        Label5.Text = Math.Round(totalsalarychange, 2)


                        totaldeduction = totalsalary - totalsalarychange
                        TotalTB.Text = "RM " & totaldeduction.ToString("N2")

                        NetPayTB.Text = "RM " & (totalsalary - totaldeduction).ToString("N2")



                    End If
                End If
            End If

                Else
                Label1.Text = "error"
        End If

    End Sub

    Private Sub NetPay_Click(sender As Object, e As EventArgs) Handles NetPay.Click

    End Sub
End Class
