<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnFriendsList = New System.Windows.Forms.Button()
        Me.btnFriendsList2 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(86, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Lottery Numbers"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(86, 41)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Seating Chart"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnFriendsList
        '
        Me.btnFriendsList.Location = New System.Drawing.Point(86, 70)
        Me.btnFriendsList.Name = "btnFriendsList"
        Me.btnFriendsList.Size = New System.Drawing.Size(75, 23)
        Me.btnFriendsList.TabIndex = 2
        Me.btnFriendsList.Text = "Friends List"
        Me.btnFriendsList.UseVisualStyleBackColor = True
        '
        'btnFriendsList2
        '
        Me.btnFriendsList2.Location = New System.Drawing.Point(86, 99)
        Me.btnFriendsList2.Name = "btnFriendsList2"
        Me.btnFriendsList2.Size = New System.Drawing.Size(75, 23)
        Me.btnFriendsList2.TabIndex = 3
        Me.btnFriendsList2.Text = "friends List 2"
        Me.btnFriendsList2.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(86, 128)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Button5"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.btnFriendsList2)
        Me.Controls.Add(Me.btnFriendsList)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Chapter 8 Menu"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnFriendsList As System.Windows.Forms.Button
    Friend WithEvents btnFriendsList2 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button

End Class
