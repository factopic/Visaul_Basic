<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListBox
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
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ItemTextBox = New System.Windows.Forms.TextBox()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.ItemsLabel = New System.Windows.Forms.Label()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(276, 29)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(191, 134)
        Me.ListBox1.TabIndex = 0
        '
        'ItemTextBox
        '
        Me.ItemTextBox.Location = New System.Drawing.Point(298, 196)
        Me.ItemTextBox.Name = "ItemTextBox"
        Me.ItemTextBox.Size = New System.Drawing.Size(131, 20)
        Me.ItemTextBox.TabIndex = 1
        '
        'AddButton
        '
        Me.AddButton.Location = New System.Drawing.Point(298, 246)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(75, 34)
        Me.AddButton.TabIndex = 2
        Me.AddButton.Text = "ADD"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'ItemsLabel
        '
        Me.ItemsLabel.AutoSize = True
        Me.ItemsLabel.Location = New System.Drawing.Point(186, 199)
        Me.ItemsLabel.Name = "ItemsLabel"
        Me.ItemsLabel.Size = New System.Drawing.Size(60, 13)
        Me.ItemsLabel.TabIndex = 3
        Me.ItemsLabel.Text = "Enter Items"
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(412, 246)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(75, 34)
        Me.ClearButton.TabIndex = 4
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ListBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(748, 328)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.ItemsLabel)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.ItemTextBox)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "ListBox"
        Me.Text = "ListBox"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents ItemTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddButton As System.Windows.Forms.Button
    Friend WithEvents ItemsLabel As System.Windows.Forms.Label
    Friend WithEvents ClearButton As System.Windows.Forms.Button
End Class
