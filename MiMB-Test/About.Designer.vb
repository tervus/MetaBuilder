﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class About
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(About))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(466, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mission:Impossible Meta Builder"
        '
        'btnOk
        '
        Me.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.Location = New System.Drawing.Point(168, 107)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(150, 50)
        Me.btnOk.TabIndex = 1
        Me.btnOk.Text = "OK"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVersion.Location = New System.Drawing.Point(131, 54)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(225, 33)
        Me.lblVersion.TabIndex = 2
        Me.lblVersion.Text = "Version 1.0.0.2"
        '
        'About
        '
        Me.AcceptButton = Me.btnOk
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(476, 169)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "About"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "About"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnOk As Button
    Friend WithEvents lblVersion As Label
End Class
