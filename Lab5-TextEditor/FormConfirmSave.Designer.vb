<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfirmSave
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
        Me.lblSaveCheck = New System.Windows.Forms.Label()
        Me.btnConfirmSave = New System.Windows.Forms.Button()
        Me.btnDontSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblSaveCheck
        '
        Me.lblSaveCheck.AutoSize = True
        Me.lblSaveCheck.Location = New System.Drawing.Point(29, 22)
        Me.lblSaveCheck.Name = "lblSaveCheck"
        Me.lblSaveCheck.Size = New System.Drawing.Size(390, 17)
        Me.lblSaveCheck.TabIndex = 0
        Me.lblSaveCheck.Text = "Unsaved changes have been made. Would you like to save?"
        '
        'btnConfirmSave
        '
        Me.btnConfirmSave.Location = New System.Drawing.Point(32, 74)
        Me.btnConfirmSave.Name = "btnConfirmSave"
        Me.btnConfirmSave.Size = New System.Drawing.Size(107, 48)
        Me.btnConfirmSave.TabIndex = 1
        Me.btnConfirmSave.Text = "Save"
        Me.btnConfirmSave.UseVisualStyleBackColor = True
        '
        'btnDontSave
        '
        Me.btnDontSave.Location = New System.Drawing.Point(174, 74)
        Me.btnDontSave.Name = "btnDontSave"
        Me.btnDontSave.Size = New System.Drawing.Size(107, 48)
        Me.btnDontSave.TabIndex = 2
        Me.btnDontSave.Text = "Don't Save"
        Me.btnDontSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(312, 74)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(107, 48)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'frmConfirmSave
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(444, 147)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnDontSave)
        Me.Controls.Add(Me.btnConfirmSave)
        Me.Controls.Add(Me.lblSaveCheck)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConfirmSave"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSaveCheck As Label
    Friend WithEvents btnConfirmSave As Button
    Friend WithEvents btnDontSave As Button
    Friend WithEvents btnCancel As Button
End Class
