<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegisterTab
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NotConfirmPwd = New System.Windows.Forms.Label()
        Me.ConfirmPwd = New System.Windows.Forms.TextBox()
        Me.Register = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.Pwd = New System.Windows.Forms.TextBox()
        Me.PhoneNum = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(90, 173)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 13)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Confirm Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(103, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(90, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Phone Number"
        '
        'NotConfirmPwd
        '
        Me.NotConfirmPwd.AutoSize = True
        Me.NotConfirmPwd.Location = New System.Drawing.Point(209, 203)
        Me.NotConfirmPwd.Name = "NotConfirmPwd"
        Me.NotConfirmPwd.Size = New System.Drawing.Size(39, 13)
        Me.NotConfirmPwd.TabIndex = 23
        Me.NotConfirmPwd.Text = "Label1"
        '
        'ConfirmPwd
        '
        Me.ConfirmPwd.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConfirmPwd.Location = New System.Drawing.Point(199, 163)
        Me.ConfirmPwd.Name = "ConfirmPwd"
        Me.ConfirmPwd.Size = New System.Drawing.Size(228, 23)
        Me.ConfirmPwd.TabIndex = 22
        '
        'Register
        '
        Me.Register.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Register.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Register.Location = New System.Drawing.Point(199, 246)
        Me.Register.Name = "Register"
        Me.Register.Size = New System.Drawing.Size(75, 30)
        Me.Register.TabIndex = 21
        Me.Register.Text = "Register"
        Me.Register.UseVisualStyleBackColor = False
        '
        'Cancel
        '
        Me.Cancel.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Cancel.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel.Location = New System.Drawing.Point(352, 246)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(75, 30)
        Me.Cancel.TabIndex = 20
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = False
        '
        'Pwd
        '
        Me.Pwd.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pwd.Location = New System.Drawing.Point(199, 108)
        Me.Pwd.Name = "Pwd"
        Me.Pwd.Size = New System.Drawing.Size(228, 23)
        Me.Pwd.TabIndex = 19
        '
        'PhoneNum
        '
        Me.PhoneNum.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PhoneNum.Location = New System.Drawing.Point(199, 52)
        Me.PhoneNum.Name = "PhoneNum"
        Me.PhoneNum.Size = New System.Drawing.Size(228, 23)
        Me.PhoneNum.TabIndex = 18
        '
        'RegisterTab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 561)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.NotConfirmPwd)
        Me.Controls.Add(Me.ConfirmPwd)
        Me.Controls.Add(Me.Register)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.Pwd)
        Me.Controls.Add(Me.PhoneNum)
        Me.Name = "RegisterTab"
        Me.Text = "Register"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents NotConfirmPwd As System.Windows.Forms.Label
    Friend WithEvents ConfirmPwd As System.Windows.Forms.TextBox
    Friend WithEvents Register As System.Windows.Forms.Button
    Friend WithEvents Cancel As System.Windows.Forms.Button
    Friend WithEvents Pwd As System.Windows.Forms.TextBox
    Friend WithEvents PhoneNum As System.Windows.Forms.TextBox
End Class
