﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class quadVertexParameters
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.aTextBox = New System.Windows.Forms.TextBox
        Me.hTextBox = New System.Windows.Forms.TextBox
        Me.kTextBox = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "a:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "h:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(16, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "k:"
        '
        'aTextBox
        '
        Me.aTextBox.Location = New System.Drawing.Point(27, 3)
        Me.aTextBox.Name = "aTextBox"
        Me.aTextBox.Size = New System.Drawing.Size(100, 20)
        Me.aTextBox.TabIndex = 3
        '
        'hTextBox
        '
        Me.hTextBox.Location = New System.Drawing.Point(27, 28)
        Me.hTextBox.Name = "hTextBox"
        Me.hTextBox.Size = New System.Drawing.Size(100, 20)
        Me.hTextBox.TabIndex = 4
        '
        'kTextBox
        '
        Me.kTextBox.Location = New System.Drawing.Point(27, 54)
        Me.kTextBox.Name = "kTextBox"
        Me.kTextBox.Size = New System.Drawing.Size(100, 20)
        Me.kTextBox.TabIndex = 5
        '
        'quadVertexParameters
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Goldenrod
        Me.Controls.Add(Me.kTextBox)
        Me.Controls.Add(Me.hTextBox)
        Me.Controls.Add(Me.aTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "quadVertexParameters"
        Me.Size = New System.Drawing.Size(229, 180)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents aTextBox As System.Windows.Forms.TextBox
    Friend WithEvents hTextBox As System.Windows.Forms.TextBox
    Friend WithEvents kTextBox As System.Windows.Forms.TextBox

End Class
