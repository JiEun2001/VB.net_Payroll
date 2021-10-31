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
        Me.Close()
    End Sub


End Class