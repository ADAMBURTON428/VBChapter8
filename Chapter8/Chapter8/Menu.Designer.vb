<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
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
        Me.btnFriends = New System.Windows.Forms.Button()
        Me.btnSeating = New System.Windows.Forms.Button()
        Me.btnRandomNum = New System.Windows.Forms.Button()
        Me.btnFriend2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnFriends
        '
        Me.btnFriends.Location = New System.Drawing.Point(89, 53)
        Me.btnFriends.Name = "btnFriends"
        Me.btnFriends.Size = New System.Drawing.Size(75, 23)
        Me.btnFriends.TabIndex = 0
        Me.btnFriends.Text = "Friend"
        Me.btnFriends.UseVisualStyleBackColor = True
        '
        'btnSeating
        '
        Me.btnSeating.Location = New System.Drawing.Point(89, 93)
        Me.btnSeating.Name = "btnSeating"
        Me.btnSeating.Size = New System.Drawing.Size(75, 23)
        Me.btnSeating.TabIndex = 1
        Me.btnSeating.Text = "Seating"
        Me.btnSeating.UseVisualStyleBackColor = True
        '
        'btnRandomNum
        '
        Me.btnRandomNum.Location = New System.Drawing.Point(89, 137)
        Me.btnRandomNum.Name = "btnRandomNum"
        Me.btnRandomNum.Size = New System.Drawing.Size(75, 37)
        Me.btnRandomNum.TabIndex = 2
        Me.btnRandomNum.Text = "Random Num"
        Me.btnRandomNum.UseVisualStyleBackColor = True
        '
        'btnFriend2
        '
        Me.btnFriend2.Location = New System.Drawing.Point(89, 191)
        Me.btnFriend2.Name = "btnFriend2"
        Me.btnFriend2.Size = New System.Drawing.Size(75, 23)
        Me.btnFriend2.TabIndex = 3
        Me.btnFriend2.Text = "Friend 2"
        Me.btnFriend2.UseVisualStyleBackColor = True
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnFriend2)
        Me.Controls.Add(Me.btnRandomNum)
        Me.Controls.Add(Me.btnSeating)
        Me.Controls.Add(Me.btnFriends)
        Me.Name = "Menu"
        Me.Text = "Menu"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnFriends As System.Windows.Forms.Button
    Friend WithEvents btnSeating As System.Windows.Forms.Button
    Friend WithEvents btnRandomNum As System.Windows.Forms.Button
    Friend WithEvents btnFriend2 As System.Windows.Forms.Button
End Class
