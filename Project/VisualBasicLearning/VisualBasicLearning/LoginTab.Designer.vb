<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginTab
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
        Me.UserNameTextBox = New System.Windows.Forms.TextBox()
        Me.pwdTextBox = New System.Windows.Forms.TextBox()
        Me.LoginButton = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.UserNameLabel = New System.Windows.Forms.Label()
        Me.PwdLabel = New System.Windows.Forms.Label()
        Me.RegisterLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'UserNameTextBox
        '
        Me.UserNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserNameTextBox.Location = New System.Drawing.Point(191, 59)
        Me.UserNameTextBox.Name = "UserNameTextBox"
        Me.UserNameTextBox.Size = New System.Drawing.Size(229, 35)
        Me.UserNameTextBox.TabIndex = 0
        '
        'pwdTextBox
        '
        Me.pwdTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pwdTextBox.Location = New System.Drawing.Point(191, 169)
        Me.pwdTextBox.Name = "pwdTextBox"
        Me.pwdTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.pwdTextBox.Size = New System.Drawing.Size(229, 35)
        Me.pwdTextBox.TabIndex = 1
        '
        'LoginButton
        '
        Me.LoginButton.Location = New System.Drawing.Point(180, 263)
        Me.LoginButton.Name = "LoginButton"
        Me.LoginButton.Size = New System.Drawing.Size(75, 38)
        Me.LoginButton.TabIndex = 2
        Me.LoginButton.Text = "Login"
        Me.LoginButton.UseVisualStyleBackColor = True
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Location = New System.Drawing.Point(320, 263)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(75, 38)
        Me.Cancel_Button.TabIndex = 3
        Me.Cancel_Button.Text = "Cancel"
        Me.Cancel_Button.UseVisualStyleBackColor = True
        '
        'UserNameLabel
        '
        Me.UserNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserNameLabel.Location = New System.Drawing.Point(21, 64)
        Me.UserNameLabel.Name = "UserNameLabel"
        Me.UserNameLabel.Size = New System.Drawing.Size(146, 30)
        Me.UserNameLabel.TabIndex = 5
        Me.UserNameLabel.Text = "User Name"
        '
        'PwdLabel
        '
        Me.PwdLabel.AutoSize = True
        Me.PwdLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PwdLabel.Location = New System.Drawing.Point(35, 175)
        Me.PwdLabel.Name = "PwdLabel"
        Me.PwdLabel.Size = New System.Drawing.Size(106, 25)
        Me.PwdLabel.TabIndex = 6
        Me.PwdLabel.Text = "Password"
        '
        'RegisterLabel
        '
        Me.RegisterLabel.AutoSize = True
        Me.RegisterLabel.Location = New System.Drawing.Point(246, 345)
        Me.RegisterLabel.Name = "RegisterLabel"
        Me.RegisterLabel.Size = New System.Drawing.Size(71, 13)
        Me.RegisterLabel.TabIndex = 7
        Me.RegisterLabel.Text = "New Register"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(683, 383)
        Me.Controls.Add(Me.RegisterLabel)
        Me.Controls.Add(Me.PwdLabel)
        Me.Controls.Add(Me.UserNameLabel)
        Me.Controls.Add(Me.Cancel_Button)
        Me.Controls.Add(Me.LoginButton)
        Me.Controls.Add(Me.pwdTextBox)
        Me.Controls.Add(Me.UserNameTextBox)
        Me.Name = "Login"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UserNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents pwdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LoginButton As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents UserNameLabel As System.Windows.Forms.Label
    Friend WithEvents PwdLabel As System.Windows.Forms.Label
    Friend WithEvents RegisterLabel As System.Windows.Forms.Label
End Class
