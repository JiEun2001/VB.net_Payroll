﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Calculatorbtn = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Exitbtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Calculatorbtn
        '
        Me.Calculatorbtn.BackColor = System.Drawing.Color.Transparent
        Me.Calculatorbtn.Location = New System.Drawing.Point(25, 88)
        Me.Calculatorbtn.Margin = New System.Windows.Forms.Padding(2)
        Me.Calculatorbtn.Name = "Calculatorbtn"
        Me.Calculatorbtn.Size = New System.Drawing.Size(125, 32)
        Me.Calculatorbtn.TabIndex = 0
        Me.Calculatorbtn.Text = "Net Salary Calculator"
        Me.Calculatorbtn.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Location = New System.Drawing.Point(222, 88)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(137, 32)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Employee"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Exitbtn
        '
        Me.Exitbtn.BackColor = System.Drawing.Color.Transparent
        Me.Exitbtn.Location = New System.Drawing.Point(154, 142)
        Me.Exitbtn.Margin = New System.Windows.Forms.Padding(2)
        Me.Exitbtn.Name = "Exitbtn"
        Me.Exitbtn.Size = New System.Drawing.Size(65, 30)
        Me.Exitbtn.TabIndex = 2
        Me.Exitbtn.Text = "Exit"
        Me.Exitbtn.UseVisualStyleBackColor = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(374, 254)
        Me.Controls.Add(Me.Exitbtn)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Calculatorbtn)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Calculatorbtn As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Exitbtn As Button
End Class
