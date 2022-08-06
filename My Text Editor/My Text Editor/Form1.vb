Imports System.IO
Public Class frmEdtior
    Private Sub frmEdtior_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        txtEditor.Height = Me.Height - 10
        txtEditor.Width = Me.Width - 10
    End Sub
    Private Function isChanged() As Boolean

        Return False
    End Function
    Private Sub BlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BlueToolStripMenuItem.Click
        txtEditor.ForeColor = Color.Blue
    End Sub

    Private Sub GreenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GreenToolStripMenuItem.Click
        txtEditor.ForeColor = Color.Green
    End Sub

    Private Sub BackgroundToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackgroundToolStripMenuItem.Click
        CD.ShowDialog()
        txtEditor.BackColor = CD.Color
    End Sub

    Private Sub RedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedToolStripMenuItem.Click
        txtEditor.ForeColor = Color.Red
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        Dim result As DialogResult
        Dim fr As StreamReader
        result = OFD.ShowDialog
        If result = DialogResult.OK Then
            fr = New StreamReader(OFD.FileName)
            txtEditor.Text = fr.ReadToEnd
            fr.Close()
        End If
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        Dim result As DialogResult
        Dim fw As StreamWriter
        result = SFD.ShowDialog
        If result = DialogResult.OK Then
            fw = New StreamWriter(SFD.FileName, False)
            fw.Write(txtEditor.Text)
            fw.Close()
        End If

    End Sub

    Private Sub SizeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SizeToolStripMenuItem.Click
        FD.ShowDialog()
        txtEditor.Font = FD.Font
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Dim result As DialogResult
        Dim fr As StreamReader
        result = OFD.ShowDialog
        If result = DialogResult.OK Then
            fr = New StreamReader(OFD.FileName)
            txtEditor.Text = fr.ReadToEnd
            fr.Close()
        End If
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        Dim result As DialogResult
        Dim fw As StreamWriter
        result = SFD.ShowDialog
        If result = DialogResult.OK Then
            fw = New StreamWriter(SFD.FileName, False)
            fw.Write(txtEditor.Text)
            fw.Close()
        End If
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        Clipboard.Clear()
        Clipboard.SetText(txtEditor.Text)
    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        Clipboard.Clear()
        Clipboard.SetText(txtEditor.SelectedText)
        txtEditor.SelectedText = ""

    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        txtEditor.Text = Clipboard.GetText
    End Sub

    Private Sub UndiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UndiToolStripMenuItem.Click
        txtEditor.Undo()
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        PFD.ShowDialog()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        If MsgBox("Do you want to exit?", vbYesNoCancel, "Exit") Then
            Dim fw As StreamWriter
            Dim result As DialogResult
            result = SFD.ShowDialog
            If result = DialogResult.OK Then
                fw = New StreamWriter(SFD.FileName, False)
                fw.Write(txtEditor.Text)
                fw.Close()
            End If
        Else
            Me.Close()
        End If
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Dim fw As StreamWriter
        Dim result As DialogResult
        result = SFD.ShowDialog
        If result = DialogResult.OK Then
            fw = New StreamWriter(SFD.FileName, False)
            fw.Write(txtEditor.Text)
            fw.Close()
        End If
        txtEditor.Clear()
    End Sub

    Private Sub LeftToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LeftToolStripMenuItem.Click
        txtEditor.TextAlign = HorizontalAlignment.Left
    End Sub

    Private Sub RightToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RightToolStripMenuItem.Click
        txtEditor.TextAlign = HorizontalAlignment.Right
    End Sub

    Private Sub CenterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CenterToolStripMenuItem.Click
        txtEditor.TextAlign = HorizontalAlignment.Center
    End Sub

    Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs) Handles ToolStripButton6.Click
        txtEditor.Text = Clipboard.GetText
    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click
        Clipboard.Clear()
        Clipboard.SetText(txtEditor.Text)
    End Sub

    Private Sub ToolStripButton7_Click(sender As Object, e As EventArgs) Handles ToolStripButton7.Click
        Clipboard.Clear()
        Clipboard.SetText(txtEditor.SelectedText)
        txtEditor.SelectedText = ""
    End Sub

    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
        PFD.ShowDialog()
    End Sub

    Private Sub txtEditor_TextChanged(sender As Object, e As EventArgs) Handles txtEditor.TextChanged
        ToolStripStatusLabel3.Text = ""
        ToolStripStatusLabel3.Text = "Cols: " & txtEditor.Text.Length
    End Sub

    Private Sub ToolStripStatusLabel2_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel2.Click

    End Sub
End Class
