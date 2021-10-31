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

End Class
