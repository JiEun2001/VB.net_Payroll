Imports System.Data.OleDb
Public Class Form3
    Dim connection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\Users\Awie\OneDrive\SEM 5\VB.Net\MyPayroll\VB.net_Payroll\Payroll\vbproject.accdb")
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
    Private Sub bind_data()
        Dim cmd1 As New OleDbCommand("Select * from Employee", connection)
        Dim da As New OleDbDataAdapter
        da.SelectCommand = cmd1
        Dim employeetable As New DataTable
        employeetable.Clear()
        da.Fill(employeetable)
        DataGridView1.DataSource = employeetable

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: This line of code loads data into the 'VbprojectDataSet1.Employee' table. You can move, or remove it, as needed.
        'Me.EmployeeTableAdapter.Fill(Me.VbprojectDataSet1.Employee)
        bind_data()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim strsql As String
        strsql = "Insert into Employee([ID],[EmployeeName],[TimeSchedule],[PhoneNumber],[Position])Values(@ID,@EmployeeName,@TimeSchedule,@PhoneNumber,@Position)"
        Dim cmd2 As New OleDbCommand(strsql, connection)
        Try
            cmd2.Parameters.AddWithValue("@ID", tbID.Text)
            cmd2.Parameters.AddWithValue("@EmployeeName", tbName.Text)
            cmd2.Parameters.AddWithValue("@TimeSchedule", tbTimeSchedule.Text)
            cmd2.Parameters.AddWithValue("@PhoneNumber", tbPhoneNumber.Text)
            cmd2.Parameters.AddWithValue("@Position", tbPosition.Text)
            connection.Open()
            cmd2.ExecuteNonQuery()
            connection.Close()
            bind_data()
        Catch ex As Exception
            MsgBox("Error" & ex.Message)
        End Try

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedrow As DataGridViewRow = DataGridView1.Rows(index)
        tbID.Text = selectedrow.Cells(0).Value.ToString
        tbName.Text = selectedrow.Cells(1).Value.ToString
        tbTimeSchedule.Text = selectedrow.Cells(2).Value.ToString
        tbPhoneNumber.Text = selectedrow.Cells(3).Value.ToString
        tbPosition.Text = selectedrow.Cells(4).Value.ToString
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim cmd4 As New OleDbCommand("Update Employee set [ID]='" & tbID.Text & "',[EmployeeName]='" & tbName.Text & "',[TimeSchedule]='" & tbTimeSchedule.Text & "',[PhoneNumber]='" & tbPhoneNumber.Text & "',[Position]='" & tbPosition.Text & "' where [id]=" & tbID.Text & "", connection)
        connection.Open()
        cmd4.ExecuteNonQuery()
        connection.Close()
        bind_data()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim cmd5 As New OleDbCommand("Delete from Employee where [ID]=@id", connection)
        cmd5.Parameters.AddWithValue("@ID", tbID.Text)
        connection.Open()
        cmd5.ExecuteNonQuery()
        connection.Close()
        bind_data()
        tbID.Text=""
        tbName.Text = ""
        tbTimeSchedule.Text = ""
        tbPhoneNumber.Text = ""
        tbPosition.Text = ""

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        tbID.Text = ""
        tbName.Text = ""
        tbTimeSchedule.Text = ""
        tbPhoneNumber.Text = ""
        tbPosition.Text = ""
    End Sub
End Class