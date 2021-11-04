Imports System.Data.OleDb
Imports System.Data


Public Class Form4
    Dim connection As New OleDbConnection(My.Settings.vbprojectConnectionString)
    Protected Overrides ReadOnly Property CreateParams As System.Windows.Forms.CreateParams
        Get
            Dim par As CreateParams = MyBase.CreateParams
            par.ClassStyle = (par.ClassStyle Or 512)
            Return par
        End Get
    End Property

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        If TBUsername.Text = Nothing Or TBPassword.Text = Nothing Then
            MsgBox("Enter Credentials", MsgBoxStyle.Exclamation)
        Else
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If
            Dim cmd As New OleDbCommand("Select count(*) from LogIn where Username=? and Password=?", connection)
            cmd.Parameters.AddWithValue("@1", OleDbType.VarChar).Value = TBUsername.Text
            cmd.Parameters.AddWithValue("@2", OleDbType.VarChar).Value = TBPassword.Text
            Dim count = Convert.ToInt32(cmd.ExecuteScalar())

            If (count > 0) Then
                MsgBox("Login Succeed", MsgBoxStyle.Information)
                Form2.Show()
                Me.Hide()
                TBUsername.Text = ""
                TBPassword.Text = ""
            Else
                MsgBox("Account not found, Check credentials", MsgBoxStyle.Critical)

            End If

        End If
    End Sub
End Class