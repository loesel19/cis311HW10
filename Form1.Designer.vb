<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblResults = New System.Windows.Forms.Label()
        Me.txtWord = New System.Windows.Forms.TextBox()
        Me.btnCheckSpelling = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Word"
        '
        'lblResults
        '
        Me.lblResults.AutoSize = True
        Me.lblResults.Location = New System.Drawing.Point(12, 51)
        Me.lblResults.Name = "lblResults"
        Me.lblResults.Size = New System.Drawing.Size(310, 15)
        Me.lblResults.TabIndex = 1
        Me.lblResults.Text = "Enter a word in the textbox and then press Check Spelling"
        '
        'txtWord
        '
        Me.txtWord.Location = New System.Drawing.Point(59, 6)
        Me.txtWord.Name = "txtWord"
        Me.txtWord.Size = New System.Drawing.Size(208, 23)
        Me.txtWord.TabIndex = 2
        '
        'btnCheckSpelling
        '
        Me.btnCheckSpelling.Location = New System.Drawing.Point(272, 6)
        Me.btnCheckSpelling.Name = "btnCheckSpelling"
        Me.btnCheckSpelling.Size = New System.Drawing.Size(142, 23)
        Me.btnCheckSpelling.TabIndex = 3
        Me.btnCheckSpelling.Text = "Check Spelling"
        Me.btnCheckSpelling.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(426, 88)
        Me.Controls.Add(Me.btnCheckSpelling)
        Me.Controls.Add(Me.txtWord)
        Me.Controls.Add(Me.lblResults)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblResults As Label
    Friend WithEvents txtWord As TextBox
    Friend WithEvents btnCheckSpelling As Button
End Class
