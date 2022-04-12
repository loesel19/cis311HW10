Imports System.ComponentModel
Public Class Form1

    Dim aCheckRef As New clsWordChecker()

    Private Sub btnCheckSpelling_Click(sender As Object, e As EventArgs) Handles btnCheckSpelling.Click
        If aCheckRef.CheckWord(txtWord.Text) Then
            lblResults.Text = txtWord.Text & " is okay"
        Else
            lblResults.Text = txtWord.Text & " is incorrectly spelled!"
        End If
    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs)
        aCheckRef = Nothing
    End Sub
End Class