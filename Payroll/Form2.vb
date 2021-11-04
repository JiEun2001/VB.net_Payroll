Public Class Form2

    Protected Overrides ReadOnly Property CreateParams As System.Windows.Forms.CreateParams
        Get
            Dim par As CreateParams = MyBase.CreateParams
            par.ClassStyle = (par.ClassStyle Or 512)
            Return par
        End Get
    End Property
    Private Sub Calculatorbtn_Click(sender As Object, e As EventArgs) Handles Calculatorbtn.Click

        Form1.Show()
        Me.Hide()

    End Sub

    Private Sub Exitbtn_Click(sender As Object, e As EventArgs) Handles Exitbtn.Click
        Form4.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form3.Show()
        Me.Hide()
    End Sub
End Class