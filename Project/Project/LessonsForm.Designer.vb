﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LessonsForm
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
        Me.lessonsPanel = New System.Windows.Forms.Panel
        Me.SuspendLayout()
        '
        'lessonsPanel
        '
        Me.lessonsPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lessonsPanel.Location = New System.Drawing.Point(0, 0)
        Me.lessonsPanel.Name = "lessonsPanel"
        Me.lessonsPanel.Size = New System.Drawing.Size(550, 500)
        Me.lessonsPanel.TabIndex = 0
        '
        'LessonsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Goldenrod
        Me.ClientSize = New System.Drawing.Size(550, 500)
        Me.Controls.Add(Me.lessonsPanel)
        Me.Name = "LessonsForm"
        Me.Text = "LessonsForm"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lessonsPanel As System.Windows.Forms.Panel
End Class
