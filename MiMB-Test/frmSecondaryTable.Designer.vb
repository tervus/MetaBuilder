﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSecondaryTable
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSecondaryTable))
        Me.cBoxType = New System.Windows.Forms.ComboBox()
        Me.lblCbox = New System.Windows.Forms.Label()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblTextOne = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.lblTextTwo = New System.Windows.Forms.Label()
        Me.lblTextThree = New System.Windows.Forms.Label()
        Me.cBoxAType = New System.Windows.Forms.ComboBox()
        Me.btnEmbedNav = New System.Windows.Forms.Button()
        Me.lblState = New System.Windows.Forms.Label()
        Me.cBoxMetaState = New System.Windows.Forms.ComboBox()
        Me.ofdSecondaryTable = New System.Windows.Forms.OpenFileDialog()
        Me.btnCreateMetaState = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cBoxType
        '
        Me.cBoxType.DropDownHeight = 150
        Me.cBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cBoxType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cBoxType.FormattingEnabled = True
        Me.cBoxType.IntegralHeight = False
        Me.cBoxType.Location = New System.Drawing.Point(15, 22)
        Me.cBoxType.MaxDropDownItems = 30
        Me.cBoxType.Name = "cBoxType"
        Me.cBoxType.Size = New System.Drawing.Size(387, 28)
        Me.cBoxType.TabIndex = 21
        '
        'lblCbox
        '
        Me.lblCbox.AutoSize = True
        Me.lblCbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCbox.Location = New System.Drawing.Point(12, 3)
        Me.lblCbox.Name = "lblCbox"
        Me.lblCbox.Size = New System.Drawing.Size(64, 16)
        Me.lblCbox.TabIndex = 23
        Me.lblCbox.Text = "Condition"
        '
        'btnOk
        '
        Me.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnOk.Location = New System.Drawing.Point(492, 23)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(100, 25)
        Me.btnOk.TabIndex = 24
        Me.btnOk.Text = "&Ok"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(492, 54)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(100, 25)
        Me.btnCancel.TabIndex = 25
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(15, 159)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(577, 20)
        Me.TextBox1.TabIndex = 26
        '
        'lblTextOne
        '
        Me.lblTextOne.AutoSize = True
        Me.lblTextOne.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTextOne.Location = New System.Drawing.Point(12, 140)
        Me.lblTextOne.Name = "lblTextOne"
        Me.lblTextOne.Size = New System.Drawing.Size(49, 16)
        Me.lblTextOne.TabIndex = 27
        Me.lblTextOne.Text = "Label1"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(15, 206)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(577, 20)
        Me.TextBox2.TabIndex = 28
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(15, 249)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(577, 20)
        Me.TextBox3.TabIndex = 29
        '
        'lblTextTwo
        '
        Me.lblTextTwo.AutoSize = True
        Me.lblTextTwo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTextTwo.Location = New System.Drawing.Point(12, 187)
        Me.lblTextTwo.Name = "lblTextTwo"
        Me.lblTextTwo.Size = New System.Drawing.Size(49, 16)
        Me.lblTextTwo.TabIndex = 30
        Me.lblTextTwo.Text = "Label1"
        '
        'lblTextThree
        '
        Me.lblTextThree.AutoSize = True
        Me.lblTextThree.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTextThree.Location = New System.Drawing.Point(12, 230)
        Me.lblTextThree.Name = "lblTextThree"
        Me.lblTextThree.Size = New System.Drawing.Size(49, 16)
        Me.lblTextThree.TabIndex = 31
        Me.lblTextThree.Text = "Label1"
        '
        'cBoxAType
        '
        Me.cBoxAType.DropDownHeight = 150
        Me.cBoxAType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cBoxAType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cBoxAType.FormattingEnabled = True
        Me.cBoxAType.IntegralHeight = False
        Me.cBoxAType.Location = New System.Drawing.Point(15, 27)
        Me.cBoxAType.MaxDropDownItems = 30
        Me.cBoxAType.Name = "cBoxAType"
        Me.cBoxAType.Size = New System.Drawing.Size(387, 28)
        Me.cBoxAType.TabIndex = 32
        '
        'btnEmbedNav
        '
        Me.btnEmbedNav.Location = New System.Drawing.Point(492, 89)
        Me.btnEmbedNav.Name = "btnEmbedNav"
        Me.btnEmbedNav.Size = New System.Drawing.Size(100, 25)
        Me.btnEmbedNav.TabIndex = 33
        Me.btnEmbedNav.Text = "&Embed Nav"
        Me.btnEmbedNav.UseVisualStyleBackColor = True
        Me.btnEmbedNav.Visible = False
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblState.Location = New System.Drawing.Point(12, 63)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(113, 16)
        Me.lblState.TabIndex = 34
        Me.lblState.Text = "Select Meta State"
        Me.lblState.Visible = False
        '
        'cBoxMetaState
        '
        Me.cBoxMetaState.DropDownHeight = 150
        Me.cBoxMetaState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cBoxMetaState.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cBoxMetaState.FormattingEnabled = True
        Me.cBoxMetaState.IntegralHeight = False
        Me.cBoxMetaState.Location = New System.Drawing.Point(15, 82)
        Me.cBoxMetaState.MaxDropDownItems = 30
        Me.cBoxMetaState.Name = "cBoxMetaState"
        Me.cBoxMetaState.Size = New System.Drawing.Size(387, 28)
        Me.cBoxMetaState.TabIndex = 35
        Me.cBoxMetaState.Visible = False
        '
        'ofdSecondaryTable
        '
        Me.ofdSecondaryTable.FileName = "OpenFileDialog1"
        Me.ofdSecondaryTable.Filter = "Nav Files|*.nav"
        Me.ofdSecondaryTable.Title = "Select Embedded Nav"
        '
        'btnCreateMetaState
        '
        Me.btnCreateMetaState.Location = New System.Drawing.Point(492, 120)
        Me.btnCreateMetaState.Name = "btnCreateMetaState"
        Me.btnCreateMetaState.Size = New System.Drawing.Size(100, 23)
        Me.btnCreateMetaState.TabIndex = 36
        Me.btnCreateMetaState.Text = "New State"
        Me.btnCreateMetaState.UseVisualStyleBackColor = True
        '
        'frmSecondaryTable
        '
        Me.AcceptButton = Me.btnOk
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(604, 277)
        Me.Controls.Add(Me.btnCreateMetaState)
        Me.Controls.Add(Me.cBoxMetaState)
        Me.Controls.Add(Me.lblState)
        Me.Controls.Add(Me.btnEmbedNav)
        Me.Controls.Add(Me.cBoxAType)
        Me.Controls.Add(Me.lblTextThree)
        Me.Controls.Add(Me.lblTextTwo)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.lblTextOne)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.lblCbox)
        Me.Controls.Add(Me.cBoxType)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSecondaryTable"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmSecondaryTable"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub


    Friend WithEvents cBoxType As ComboBox
    Friend WithEvents lblCbox As Label
    Friend WithEvents btnOk As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblTextOne As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents lblTextTwo As Label
    Friend WithEvents lblTextThree As Label
    Friend WithEvents cBoxAType As ComboBox
    Friend WithEvents btnEmbedNav As Button
    Friend WithEvents lblState As Label
    Friend WithEvents cBoxMetaState As ComboBox
    Friend WithEvents ofdSecondaryTable As OpenFileDialog
    Friend WithEvents btnCreateMetaState As Button
End Class
