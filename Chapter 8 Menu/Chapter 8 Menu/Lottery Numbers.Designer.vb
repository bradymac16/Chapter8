<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Lottery_Numbers
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
        Me.lblone = New System.Windows.Forms.Label()
        Me.lbltwo = New System.Windows.Forms.Label()
        Me.lblthree = New System.Windows.Forms.Label()
        Me.lblfour = New System.Windows.Forms.Label()
        Me.lblFive = New System.Windows.Forms.Label()
        Me.btnGenerateNumbers = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblone
        '
        Me.lblone.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblone.Location = New System.Drawing.Point(47, 55)
        Me.lblone.Name = "lblone"
        Me.lblone.Size = New System.Drawing.Size(60, 40)
        Me.lblone.TabIndex = 0
        '
        'lbltwo
        '
        Me.lbltwo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbltwo.Location = New System.Drawing.Point(121, 55)
        Me.lbltwo.Name = "lbltwo"
        Me.lbltwo.Size = New System.Drawing.Size(60, 40)
        Me.lbltwo.TabIndex = 1
        '
        'lblthree
        '
        Me.lblthree.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblthree.Location = New System.Drawing.Point(199, 55)
        Me.lblthree.Name = "lblthree"
        Me.lblthree.Size = New System.Drawing.Size(60, 40)
        Me.lblthree.TabIndex = 2
        '
        'lblfour
        '
        Me.lblfour.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblfour.Location = New System.Drawing.Point(277, 55)
        Me.lblfour.Name = "lblfour"
        Me.lblfour.Size = New System.Drawing.Size(60, 40)
        Me.lblfour.TabIndex = 3
        '
        'lblFive
        '
        Me.lblFive.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFive.Location = New System.Drawing.Point(358, 55)
        Me.lblFive.Name = "lblFive"
        Me.lblFive.Size = New System.Drawing.Size(60, 40)
        Me.lblFive.TabIndex = 4
        '
        'btnGenerateNumbers
        '
        Me.btnGenerateNumbers.Location = New System.Drawing.Point(86, 186)
        Me.btnGenerateNumbers.Name = "btnGenerateNumbers"
        Me.btnGenerateNumbers.Size = New System.Drawing.Size(75, 51)
        Me.btnGenerateNumbers.TabIndex = 5
        Me.btnGenerateNumbers.Text = "Generate Numbers"
        Me.btnGenerateNumbers.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(277, 186)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 51)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Lottery_Numbers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(492, 349)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnGenerateNumbers)
        Me.Controls.Add(Me.lblFive)
        Me.Controls.Add(Me.lblfour)
        Me.Controls.Add(Me.lblthree)
        Me.Controls.Add(Me.lbltwo)
        Me.Controls.Add(Me.lblone)
        Me.Name = "Lottery_Numbers"
        Me.Text = "Lottery_Numbers"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblone As System.Windows.Forms.Label
    Friend WithEvents lbltwo As System.Windows.Forms.Label
    Friend WithEvents lblthree As System.Windows.Forms.Label
    Friend WithEvents lblfour As System.Windows.Forms.Label
    Friend WithEvents lblFive As System.Windows.Forms.Label
    Friend WithEvents btnGenerateNumbers As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
End Class
