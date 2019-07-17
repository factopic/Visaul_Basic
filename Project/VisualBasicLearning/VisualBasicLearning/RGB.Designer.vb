<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RGB
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
        Me.HeadingLabel = New System.Windows.Forms.Label()
        Me.BLabel = New System.Windows.Forms.Label()
        Me.GLabel = New System.Windows.Forms.Label()
        Me.RLabel = New System.Windows.Forms.Label()
        Me.BTextBox = New System.Windows.Forms.TextBox()
        Me.GTextBox = New System.Windows.Forms.TextBox()
        Me.RTextBox = New System.Windows.Forms.TextBox()
        Me.DisplayButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'HeadingLabel
        '
        Me.HeadingLabel.AutoSize = True
        Me.HeadingLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HeadingLabel.Location = New System.Drawing.Point(48, 132)
        Me.HeadingLabel.Name = "HeadingLabel"
        Me.HeadingLabel.Size = New System.Drawing.Size(186, 24)
        Me.HeadingLabel.TabIndex = 37
        Me.HeadingLabel.Text = "Change the Bg Color"
        '
        'BLabel
        '
        Me.BLabel.AutoSize = True
        Me.BLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BLabel.Location = New System.Drawing.Point(329, 183)
        Me.BLabel.Name = "BLabel"
        Me.BLabel.Size = New System.Drawing.Size(34, 33)
        Me.BLabel.TabIndex = 36
        Me.BLabel.Text = "B"
        '
        'GLabel
        '
        Me.GLabel.AutoSize = True
        Me.GLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GLabel.Location = New System.Drawing.Point(329, 125)
        Me.GLabel.Name = "GLabel"
        Me.GLabel.Size = New System.Drawing.Size(38, 33)
        Me.GLabel.TabIndex = 35
        Me.GLabel.Text = "G"
        '
        'RLabel
        '
        Me.RLabel.AutoSize = True
        Me.RLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RLabel.Location = New System.Drawing.Point(329, 76)
        Me.RLabel.Name = "RLabel"
        Me.RLabel.Size = New System.Drawing.Size(36, 33)
        Me.RLabel.TabIndex = 34
        Me.RLabel.Text = "R"
        '
        'BTextBox
        '
        Me.BTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTextBox.Location = New System.Drawing.Point(429, 183)
        Me.BTextBox.Name = "BTextBox"
        Me.BTextBox.Size = New System.Drawing.Size(100, 40)
        Me.BTextBox.TabIndex = 33
        '
        'GTextBox
        '
        Me.GTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GTextBox.Location = New System.Drawing.Point(429, 125)
        Me.GTextBox.Name = "GTextBox"
        Me.GTextBox.Size = New System.Drawing.Size(100, 40)
        Me.GTextBox.TabIndex = 32
        '
        'RTextBox
        '
        Me.RTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RTextBox.Location = New System.Drawing.Point(429, 73)
        Me.RTextBox.Name = "RTextBox"
        Me.RTextBox.Size = New System.Drawing.Size(100, 40)
        Me.RTextBox.TabIndex = 31
        '
        'DisplayButton
        '
        Me.DisplayButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisplayButton.Location = New System.Drawing.Point(345, 272)
        Me.DisplayButton.Name = "DisplayButton"
        Me.DisplayButton.Size = New System.Drawing.Size(184, 50)
        Me.DisplayButton.TabIndex = 30
        Me.DisplayButton.Text = "Display bgc"
        Me.DisplayButton.UseVisualStyleBackColor = True
        '
        'RGB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 361)
        Me.Controls.Add(Me.HeadingLabel)
        Me.Controls.Add(Me.BLabel)
        Me.Controls.Add(Me.GLabel)
        Me.Controls.Add(Me.RLabel)
        Me.Controls.Add(Me.BTextBox)
        Me.Controls.Add(Me.GTextBox)
        Me.Controls.Add(Me.RTextBox)
        Me.Controls.Add(Me.DisplayButton)
        Me.Name = "RGB"
        Me.Text = "RGB"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents HeadingLabel As System.Windows.Forms.Label
    Friend WithEvents BLabel As System.Windows.Forms.Label
    Friend WithEvents GLabel As System.Windows.Forms.Label
    Friend WithEvents RLabel As System.Windows.Forms.Label
    Friend WithEvents BTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DisplayButton As System.Windows.Forms.Button
End Class
