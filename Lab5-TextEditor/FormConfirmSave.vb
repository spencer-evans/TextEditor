''' <summary>
''' Author: Spencer Evans
''' Date: 2020/07/31
''' 
''' Subform for the text editor. Warns user that the file they are closing is unsaved and asks if they would like to save it.
''' </summary>
Public Class frmConfirmSave

    Dim cancelClose As Boolean
    Dim saveCheck As Boolean

    Private Sub btnConfirmSave_Click(sender As Object, e As EventArgs) Handles btnConfirmSave.Click
        frmTextEditor.cancelClose = False
        frmTextEditor.saveCheck = True
        Me.Close()
    End Sub

    Private Sub btnDontSave_Click(sender As Object, e As EventArgs) Handles btnDontSave.Click
        frmTextEditor.cancelClose = False
        frmTextEditor.saveCheck = False
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        frmTextEditor.cancelClose = True
        Me.Close()
    End Sub
End Class