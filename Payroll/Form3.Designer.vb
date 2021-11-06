<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
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
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbPosition = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbPhoneNumber = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbTimeSchedule = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbID = New System.Windows.Forms.TextBox()
        Me.VbprojectDataSet = New Payroll.vbprojectDataSet()
        Me.VbprojectDataSet1 = New Payroll.vbprojectDataSet1()
        Me.VbprojectDataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployeeTableAdapter = New Payroll.vbprojectDataSet1TableAdapters.EmployeeTableAdapter()
        Me.EmployeeBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnClear = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.VbprojectDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VbprojectDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VbprojectDataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(338, 13)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(635, 307)
        Me.DataGridView1.TabIndex = 0
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(127, 368)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(389, 368)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(530, 368)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 3
        Me.btnDelete.Text = "Button3"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(870, 440)
        Me.Button4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "Button4"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.tbPosition)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.tbPhoneNumber)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.tbTimeSchedule)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.tbName)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.tbID)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(319, 307)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 176)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 17)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Label5"
        '
        'tbPosition
        '
        Me.tbPosition.Location = New System.Drawing.Point(78, 176)
        Me.tbPosition.Name = "tbPosition"
        Me.tbPosition.Size = New System.Drawing.Size(188, 22)
        Me.tbPosition.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 148)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Label4"
        '
        'tbPhoneNumber
        '
        Me.tbPhoneNumber.Location = New System.Drawing.Point(78, 148)
        Me.tbPhoneNumber.Name = "tbPhoneNumber"
        Me.tbPhoneNumber.Size = New System.Drawing.Size(188, 22)
        Me.tbPhoneNumber.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Label3"
        '
        'tbTimeSchedule
        '
        Me.tbTimeSchedule.Location = New System.Drawing.Point(78, 120)
        Me.tbTimeSchedule.Name = "tbTimeSchedule"
        Me.tbTimeSchedule.Size = New System.Drawing.Size(188, 22)
        Me.tbTimeSchedule.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Label2"
        '
        'tbName
        '
        Me.tbName.Location = New System.Drawing.Point(78, 92)
        Me.tbName.Name = "tbName"
        Me.tbName.Size = New System.Drawing.Size(188, 22)
        Me.tbName.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Label1"
        '
        'tbID
        '
        Me.tbID.Location = New System.Drawing.Point(78, 64)
        Me.tbID.Name = "tbID"
        Me.tbID.Size = New System.Drawing.Size(188, 22)
        Me.tbID.TabIndex = 0
        '
        'VbprojectDataSet
        '
        Me.VbprojectDataSet.DataSetName = "vbprojectDataSet"
        Me.VbprojectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VbprojectDataSet1
        '
        Me.VbprojectDataSet1.DataSetName = "vbprojectDataSet1"
        Me.VbprojectDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VbprojectDataSet1BindingSource
        '
        Me.VbprojectDataSet1BindingSource.DataSource = Me.VbprojectDataSet1
        Me.VbprojectDataSet1BindingSource.Position = 0
        '
        'EmployeeBindingSource
        '
        Me.EmployeeBindingSource.DataMember = "Employee"
        Me.EmployeeBindingSource.DataSource = Me.VbprojectDataSet1BindingSource
        '
        'EmployeeTableAdapter
        '
        Me.EmployeeTableAdapter.ClearBeforeFill = True
        '
        'EmployeeBindingSource1
        '
        Me.EmployeeBindingSource1.DataMember = "Employee"
        Me.EmployeeBindingSource1.DataSource = Me.VbprojectDataSet1BindingSource
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(267, 368)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 561)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.DataGridView1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.VbprojectDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VbprojectDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VbprojectDataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnAdd As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tbPosition As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tbPhoneNumber As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbTimeSchedule As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tbName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tbID As TextBox
    Friend WithEvents VbprojectDataSet As vbprojectDataSet
    Friend WithEvents VbprojectDataSet1 As vbprojectDataSet1
    Friend WithEvents VbprojectDataSet1BindingSource As BindingSource
    Friend WithEvents EmployeeBindingSource As BindingSource
    Friend WithEvents EmployeeTableAdapter As vbprojectDataSet1TableAdapters.EmployeeTableAdapter
    Friend WithEvents EmployeeBindingSource1 As BindingSource
    Friend WithEvents btnClear As Button
End Class
