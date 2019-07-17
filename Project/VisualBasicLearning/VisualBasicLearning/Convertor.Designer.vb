<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Convertor
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
        Me.FootTextBox = New System.Windows.Forms.TextBox()
        Me.CmTextBox = New System.Windows.Forms.TextBox()
        Me.ConvertButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'FootTextBox
        '
        Me.FootTextBox.Location = New System.Drawing.Point(124, 59)
        Me.FootTextBox.Name = "FootTextBox"
        Me.FootTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FootTextBox.TabIndex = 0
        Me.FootTextBox.Text = "5"
        '
        'CmTextBox
        '
        Me.CmTextBox.Location = New System.Drawing.Point(462, 59)
        Me.CmTextBox.Name = "CmTextBox"
        Me.CmTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CmTextBox.TabIndex = 2
        '
        'ConvertButton
        '
        Me.ConvertButton.Location = New System.Drawing.Point(254, 128)
        Me.ConvertButton.Name = "ConvertButton"
        Me.ConvertButton.Size = New System.Drawing.Size(75, 36)
        Me.ConvertButton.TabIndex = 3
        Me.ConvertButton.Text = "Convert"
        Me.ConvertButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(160, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Foot"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(501, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(21, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "cm"
        '
        'Convertor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(702, 261)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ConvertButton)
        Me.Controls.Add(Me.CmTextBox)
        Me.Controls.Add(Me.FootTextBox)
        Me.Name = "Convertor"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FootTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CmTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ConvertButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
