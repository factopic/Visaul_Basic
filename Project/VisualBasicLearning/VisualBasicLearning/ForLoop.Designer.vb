<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ForLoop
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
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Pattern1Button = New System.Windows.Forms.Button()
        Me.Pattern2Button = New System.Windows.Forms.Button()
        Me.Pattern3Button = New System.Windows.Forms.Button()
        Me.Pattern4Button = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(32, 285)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 42)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "While Button"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 31
        Me.ListBox1.Location = New System.Drawing.Point(340, 12)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(234, 221)
        Me.ListBox1.TabIndex = 1
        '
        'Pattern1Button
        '
        Me.Pattern1Button.Location = New System.Drawing.Point(155, 285)
        Me.Pattern1Button.Name = "Pattern1Button"
        Me.Pattern1Button.Size = New System.Drawing.Size(106, 42)
        Me.Pattern1Button.TabIndex = 4
        Me.Pattern1Button.Text = "Pattern 1"
        Me.Pattern1Button.UseVisualStyleBackColor = True
        '
        'Pattern2Button
        '
        Me.Pattern2Button.Location = New System.Drawing.Point(294, 285)
        Me.Pattern2Button.Name = "Pattern2Button"
        Me.Pattern2Button.Size = New System.Drawing.Size(106, 42)
        Me.Pattern2Button.TabIndex = 5
        Me.Pattern2Button.Text = " Pattern 2"
        Me.Pattern2Button.UseVisualStyleBackColor = True
        '
        'Pattern3Button
        '
        Me.Pattern3Button.Location = New System.Drawing.Point(435, 285)
        Me.Pattern3Button.Name = "Pattern3Button"
        Me.Pattern3Button.Size = New System.Drawing.Size(106, 42)
        Me.Pattern3Button.TabIndex = 6
        Me.Pattern3Button.Text = "Pattern 3"
        Me.Pattern3Button.UseVisualStyleBackColor = True
        '
        'Pattern4Button
        '
        Me.Pattern4Button.Location = New System.Drawing.Point(575, 285)
        Me.Pattern4Button.Name = "Pattern4Button"
        Me.Pattern4Button.Size = New System.Drawing.Size(106, 42)
        Me.Pattern4Button.TabIndex = 7
        Me.Pattern4Button.Text = "Pattern 4"
        Me.Pattern4Button.UseVisualStyleBackColor = True
        '
        'ForLoop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1041, 383)
        Me.Controls.Add(Me.Pattern4Button)
        Me.Controls.Add(Me.Pattern3Button)
        Me.Controls.Add(Me.Pattern2Button)
        Me.Controls.Add(Me.Pattern1Button)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "ForLoop"
        Me.Text = "ForLoop"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Pattern1Button As System.Windows.Forms.Button
    Friend WithEvents Pattern2Button As System.Windows.Forms.Button
    Friend WithEvents Pattern3Button As System.Windows.Forms.Button
    Friend WithEvents Pattern4Button As System.Windows.Forms.Button
End Class
