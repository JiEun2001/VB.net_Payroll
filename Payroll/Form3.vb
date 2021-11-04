Public Class Form3
    Protected Overrides ReadOnly Property CreateParams As System.Windows.Forms.CreateParams
        Get
            Dim par As CreateParams = MyBase.CreateParams
            par.ClassStyle = (par.ClassStyle Or 512)
            Return par
        End Get
    End Property
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form2.Show()
        Me.Close()
    End Sub
End Class