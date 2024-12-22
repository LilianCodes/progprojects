Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click
        If txtAddText.Text = "" Then
            MsgBox("Please enter some text!")
        Else
            lvTasks.Items.Add(txtAddText.Text)
            txtAddText.Clear()
        End If
    End Sub

    Private Sub btnRemoveItem_Click(sender As Object, e As EventArgs) Handles btnRemoveItem.Click
        If lvTasks.SelectedItems.Count > 0 Then
            lvTasks.Items.Remove(lvTasks.SelectedItems(0))
        Else
            MessageBox.Show("Please select an item to remove.")
        End If
    End Sub

    Private Sub btnRemoveAll_Click(sender As Object, e As EventArgs) Handles btnRemoveAll.Click
        lvTasks.Items.Clear()
    End Sub

    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        MsgBox("Silly little project.")
    End Sub
End Class
