<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Friends_List_2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnShowAll = New System.Windows.Forms.Button()
        Me.txtNames = New System.Windows.Forms.TextBox()
        Me.lstFriends = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(83, 167)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnShowAll
        '
        Me.btnShowAll.Location = New System.Drawing.Point(283, 276)
        Me.btnShowAll.Name = "btnShowAll"
        Me.btnShowAll.Size = New System.Drawing.Size(173, 23)
        Me.btnShowAll.TabIndex = 1
        Me.btnShowAll.Text = "Show All"
        Me.btnShowAll.UseVisualStyleBackColor = True
        '
        'txtNames
        '
        Me.txtNames.Location = New System.Drawing.Point(54, 141)
        Me.txtNames.Name = "txtNames"
        Me.txtNames.Size = New System.Drawing.Size(138, 20)
        Me.txtNames.TabIndex = 2
        '
        'lstFriends
        '
        Me.lstFriends.FormattingEnabled = True
        Me.lstFriends.Location = New System.Drawing.Point(262, 63)
        Me.lstFriends.Name = "lstFriends"
        Me.lstFriends.Size = New System.Drawing.Size(221, 186)
        Me.lstFriends.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(80, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Enter a Friends Name"
        '
        'Friends_List_2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(537, 380)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstFriends)
        Me.Controls.Add(Me.txtNames)
        Me.Controls.Add(Me.btnShowAll)
        Me.Controls.Add(Me.btnAdd)
        Me.Name = "Friends_List_2"
        Me.Text = "Friends_List_2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnShowAll As System.Windows.Forms.Button
    Friend WithEvents txtNames As System.Windows.Forms.TextBox
    Friend WithEvents lstFriends As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
