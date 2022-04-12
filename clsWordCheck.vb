Imports Microsoft.Office.Interop
Imports System.Runtime.InteropServices

<ComVisible(True)>
Public Class clsWordChecker
    Private aWordInstance As Word.Application

    Public Sub New()
        aWordInstance = New Word.Application
    End Sub

    Public Function CheckWord(ByVal strWord As String) As Boolean
        CheckWord = aWordInstance.CheckSpelling(strWord)
    End Function

    Protected Overrides Sub Finalize()
        aWordInstance = Nothing
    End Sub
End Class
