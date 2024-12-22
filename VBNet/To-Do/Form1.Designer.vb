<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        btnAddItem = New Button()
        lvTasks = New ListView()
        btnRemoveItem = New Button()
        btnAbout = New Button()
        txtAddText = New TextBox()
        btnRemoveAll = New Button()
        SuspendLayout()
        ' 
        ' btnAddItem
        ' 
        btnAddItem.Location = New Point(12, 195)
        btnAddItem.Name = "btnAddItem"
        btnAddItem.Size = New Size(94, 29)
        btnAddItem.TabIndex = 0
        btnAddItem.Text = "Add Item"
        btnAddItem.UseVisualStyleBackColor = True
        ' 
        ' lvTasks
        ' 
        lvTasks.Location = New Point(12, 12)
        lvTasks.Name = "lvTasks"
        lvTasks.Size = New Size(489, 121)
        lvTasks.TabIndex = 1
        lvTasks.UseCompatibleStateImageBehavior = False
        lvTasks.View = View.List
        ' 
        ' btnRemoveItem
        ' 
        btnRemoveItem.Location = New Point(112, 195)
        btnRemoveItem.Name = "btnRemoveItem"
        btnRemoveItem.Size = New Size(120, 29)
        btnRemoveItem.TabIndex = 2
        btnRemoveItem.Text = "Remove Item"
        btnRemoveItem.UseVisualStyleBackColor = True
        ' 
        ' btnAbout
        ' 
        btnAbout.Location = New Point(407, 195)
        btnAbout.Name = "btnAbout"
        btnAbout.Size = New Size(94, 29)
        btnAbout.TabIndex = 3
        btnAbout.Text = "About"
        btnAbout.UseVisualStyleBackColor = True
        ' 
        ' txtAddText
        ' 
        txtAddText.Location = New Point(12, 152)
        txtAddText.Name = "txtAddText"
        txtAddText.Size = New Size(489, 27)
        txtAddText.TabIndex = 4
        txtAddText.Text = "Type Item Here"
        ' 
        ' btnRemoveAll
        ' 
        btnRemoveAll.Location = New Point(238, 195)
        btnRemoveAll.Name = "btnRemoveAll"
        btnRemoveAll.Size = New Size(100, 29)
        btnRemoveAll.TabIndex = 5
        btnRemoveAll.Text = "Remove All"
        btnRemoveAll.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(512, 234)
        Controls.Add(btnRemoveAll)
        Controls.Add(txtAddText)
        Controls.Add(btnAbout)
        Controls.Add(btnRemoveItem)
        Controls.Add(lvTasks)
        Controls.Add(btnAddItem)
        Name = "Form1"
        Text = "To Do"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnAddItem As Button
    Friend WithEvents lvTasks As ListView
    Friend WithEvents btnRemoveItem As Button
    Friend WithEvents btnAbout As Button
    Friend WithEvents txtAddText As TextBox
    Friend WithEvents btnRemoveAll As Button

End Class
