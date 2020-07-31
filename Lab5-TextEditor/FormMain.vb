Option Strict On
Imports System.IO

''' <summary>
''' Author: Spencer Evans
''' Date: 2020/07/31
''' 
''' Simple text editor create for NETD 2202 Lab 5. Allows the user to create, open, edit and save text files. 
''' </summary>
Public Class frmTextEditor

#Region "Variable Declarations"

    Dim selectedFile As String = String.Empty ' Holds path to current open file
    Dim previousVersion As String = String.Empty ' Holds last saved contents of the file to check if file has been modified
    Public cancelClose As Boolean
    Public saveCheck As Boolean

#End Region

#Region "Event Handlers"
    ''' <summary>
    ''' Clears editor for new text file
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub NewClick(sender As Object, e As EventArgs) Handles mnuFileNew.Click, btnNew.Click
        If (previousVersion = txtArea.Text) Then
            txtArea.Text = String.Empty
            selectedFile = String.Empty
            previousVersion = String.Empty

            lblStatus.Text = "Opened an new blank file"
            Me.Text = "Text Editor"
        ElseIf (ConfirmClose()) Then
            txtArea.Text = String.Empty
            selectedFile = String.Empty
            previousVersion = String.Empty

            lblStatus.Text = "Opened an new blank file"
            Me.Text = "Text Editor"
        End If
    End Sub

    ''' <summary>
    ''' Opens an existing file through the file open dialog
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub OpenClick(sender As Object, e As EventArgs) Handles mnuFileOpen.Click, btnOpen.Click
        Dim inputStream As StreamReader

        If (previousVersion = txtArea.Text) Then
            If openDialog.ShowDialog() = DialogResult.OK Then
                inputStream = New StreamReader(openDialog.FileName)
                txtArea.Text = inputStream.ReadToEnd()
                inputStream.Close()

                selectedFile = openDialog.FileName
                previousVersion = txtArea.Text
                lblStatus.Text = "Opened file " & selectedFile
                Me.Text = "Text Editor " & selectedFile
            End If
        ElseIf (ConfirmClose()) Then
            If openDialog.ShowDialog() = DialogResult.OK Then
                inputStream = New StreamReader(openDialog.FileName)
                txtArea.Text = inputStream.ReadToEnd()
                inputStream.Close()

                selectedFile = openDialog.FileName
                previousVersion = txtArea.Text
                lblStatus.Text = "Opened file " & selectedFile
                Me.Text = "Text Editor " & selectedFile
            End If
        End If

    End Sub

    ''' <summary>
    ''' Calls saveFile sub 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub SaveClick(sender As Object, e As EventArgs) Handles mnuFileSave.Click, btnSave.Click
        SaveFile()
    End Sub

    ''' <summary>
    ''' Clears selectedFile and calls saveFile sub
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub SaveAsClick(sender As Object, e As EventArgs) Handles mnuFileSaveAs.Click
        selectedFile = String.Empty
        SaveFile()
    End Sub

    ''' <summary>
    ''' Opens sub form with program information
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub AboutClick(sender As Object, e As EventArgs) Handles mnuHelpAbout.Click
        Dim aboutModal As New frmAbout

        aboutModal.ShowDialog()
    End Sub

    ''' <summary>
    ''' Closes application
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ExitClick(sender As Object, e As EventArgs) Handles mnuFileExit.Click
        If (previousVersion = txtArea.Text) Then
            Application.Exit()
            Me.Close()
        ElseIf (ConfirmClose()) Then
            Application.Exit()
            Me.Close()
        End If

    End Sub

    ''' <summary>
    ''' Copies currently selected text to clipboard
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CopyClick(sender As Object, e As EventArgs) Handles mnuEditCopy.Click
        txtArea.Copy()
    End Sub

    ''' <summary>
    ''' Deletes currently selected text and copies text to clipboard
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CutClick(sender As Object, e As EventArgs) Handles mnuEditCut.Click
        txtArea.Cut()
    End Sub

    ''' <summary>
    ''' Pastes text stored in clipboard
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub PasteClick(sender As Object, e As EventArgs) Handles mnuEditPaste.Click
        txtArea.Paste()
    End Sub

#End Region

#Region "Subs and Functions"
    ''' <summary>
    ''' Saves currently open file
    ''' Save file dialog is opened if file is new or Save As was selected
    ''' </summary>
    Sub SaveFile()
        Dim outputStream As StreamWriter

        If (String.IsNullOrWhiteSpace(selectedFile)) Then
            If saveDialog.ShowDialog() = DialogResult.OK Then
                outputStream = New StreamWriter(saveDialog.FileName)
                outputStream.Write(txtArea.Text)
                outputStream.Close()

                selectedFile = saveDialog.FileName
                previousVersion = txtArea.Text
                lblStatus.Text = "Saved file as " & selectedFile
                Me.Text = "Text Editor " & selectedFile
            End If
        Else
            outputStream = New StreamWriter(selectedFile)
            outputStream.Write(txtArea.Text)
            outputStream.Close()

            previousVersion = txtArea.Text
            lblStatus.Text = "Saved file as " & selectedFile
        End If
    End Sub

    ''' <summary>
    ''' Asks user if the would like to save their file before closing
    ''' </summary>
    ''' <returns></returns>
    Function ConfirmClose() As Boolean
        Dim confirmSaveModal As New frmConfirmSave
        confirmSaveModal.ShowDialog()

        If (cancelClose) Then
            Return False
        ElseIf (saveCheck) Then
            SaveFile()
            Return True
        End If
        Return True
    End Function

#End Region


End Class
