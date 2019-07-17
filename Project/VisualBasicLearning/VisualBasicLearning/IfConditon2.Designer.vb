<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IfConditon2
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
        Me.MarksTextBox = New System.Windows.Forms.TextBox()
        Me.GradeTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Calcu = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ClassTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'MarksTextBox
        '
        Me.MarksTextBox.AllowDrop = True
        Me.MarksTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MarksTextBox.Location = New System.Drawing.Point(312, 37)
        Me.MarksTextBox.Name = "MarksTextBox"
        Me.MarksTextBox.Size = New System.Drawing.Size(200, 31)
        Me.MarksTextBox.TabIndex = 2
        '
        'GradeTextBox
        '
        Me.GradeTextBox.AllowDrop = True
        Me.GradeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GradeTextBox.Location = New System.Drawing.Point(312, 131)
        Me.GradeTextBox.Name = "GradeTextBox"
        Me.GradeTextBox.Size = New System.Drawing.Size(200, 31)
        Me.GradeTextBox.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(73, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 31)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Marks"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(72, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 31)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Grade"
        '
        'Calcu
        '
        Me.Calcu.Location = New System.Drawing.Point(209, 346)
        Me.Calcu.Name = "Calcu"
        Me.Calcu.Size = New System.Drawing.Size(169, 54)
        Me.Calcu.TabIndex = 7
        Me.Calcu.Text = "Calculate Grade"
        Me.Calcu.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 218)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 31)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Class Obtained"
        '
        'ClassTextBox
        '
        Me.ClassTextBox.AllowDrop = True
        Me.ClassTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClassTextBox.Location = New System.Drawing.Point(312, 218)
        Me.ClassTextBox.Name = "ClassTextBox"
        Me.ClassTextBox.Size = New System.Drawing.Size(200, 31)
        Me.ClassTextBox.TabIndex = 9
        '
        'IfConditon2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(810, 443)
        Me.Controls.Add(Me.ClassTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Calcu)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GradeTextBox)
        Me.Controls.Add(Me.MarksTextBox)
        Me.Name = "IfConditon2"
        Me.Text = "IfConditon2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MarksTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GradeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Calcu As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ClassTextBox As System.Windows.Forms.TextBox
End Class
