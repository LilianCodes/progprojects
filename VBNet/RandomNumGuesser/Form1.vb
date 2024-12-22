Public Class frmGuessNum
    Dim randNum As New Random
    Dim numGuessesLeft = 3

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnGuess.Click
        Dim answer = randNum.Next(1, 100)

        If txtboxGuess.Text = answer.ToString() Then
            MsgBox("You guessed correctly!")
        ElseIf txtboxGuess.Text = " " Then
            MsgBox("Please enter a number. :)")
        Else
            MsgBox("Incorrect. :( Try again!")
            txtboxGuess.Clear()

            numGuessesLeft -= 1
            lblGuessRemaining.Text = numGuessesLeft

            If numGuessesLeft = 0 Then
                MsgBox("You lose! The number I was thinking of was: " & answer & "!")
                Me.Close()
            End If
        End If
    End Sub
End Class
