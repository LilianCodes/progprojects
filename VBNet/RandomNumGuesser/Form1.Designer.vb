<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmGuessNum
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        btnGuess = New Button()
        Label1 = New Label()
        txtboxGuess = New TextBox()
        Label2 = New Label()
        lblGuessRemaining = New Label()
        SuspendLayout()
        ' 
        ' btnGuess
        ' 
        btnGuess.Location = New Point(152, 130)
        btnGuess.Name = "btnGuess"
        btnGuess.Size = New Size(94, 29)
        btnGuess.TabIndex = 0
        btnGuess.Text = "Guess"
        btnGuess.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(377, 20)
        Label1.TabIndex = 1
        Label1.Text = "I'm thinking of a number between 1 and 100. What is it?" & vbCrLf
        ' 
        ' txtboxGuess
        ' 
        txtboxGuess.Location = New Point(94, 75)
        txtboxGuess.Name = "txtboxGuess"
        txtboxGuess.Size = New Size(201, 27)
        txtboxGuess.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(94, 40)
        Label2.Name = "Label2"
        Label2.Size = New Size(139, 20)
        Label2.TabIndex = 3
        Label2.Text = "Guesses Remaining:"
        ' 
        ' lblGuessRemaining
        ' 
        lblGuessRemaining.AutoSize = True
        lblGuessRemaining.Location = New Point(278, 40)
        lblGuessRemaining.Name = "lblGuessRemaining"
        lblGuessRemaining.Size = New Size(17, 20)
        lblGuessRemaining.TabIndex = 4
        lblGuessRemaining.Text = "3"
        ' 
        ' frmGuessNum
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(408, 171)
        Controls.Add(lblGuessRemaining)
        Controls.Add(Label2)
        Controls.Add(txtboxGuess)
        Controls.Add(Label1)
        Controls.Add(btnGuess)
        MaximizeBox = False
        Name = "frmGuessNum"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Guess The Number"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnGuess As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtboxGuess As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblGuessRemaining As Label

End Class
