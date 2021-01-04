<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class lineParameters
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
        Me.slopeTextBox = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.bTextBox = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'slopeTextBox
        '
        Me.slopeTextBox.Location = New System.Drawing.Point(28, 5)
        Me.slopeTextBox.Name = "slopeTextBox"
        Me.slopeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.slopeTextBox.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "m:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "b:"
        '
        'bTextBox
        '
        Me.bTextBox.Location = New System.Drawing.Point(28, 35)
        Me.bTextBox.Name = "bTextBox"
        Me.bTextBox.Size = New System.Drawing.Size(100, 20)
        Me.bTextBox.TabIndex = 3
        '
        'lineParameters
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Goldenrod
        Me.Controls.Add(Me.bTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.slopeTextBox)
        Me.Name = "lineParameters"
        Me.Size = New System.Drawing.Size(229, 180)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents slopeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents bTextBox As System.Windows.Forms.TextBox

End Class
