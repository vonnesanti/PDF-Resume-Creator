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
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.exitBtn = New System.Windows.Forms.Button()
        Me.createBtn = New System.Windows.Forms.Button()
        Me.viewBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(37, 21)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(707, 527)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = ""
        '
        'exitBtn
        '
        Me.exitBtn.Location = New System.Drawing.Point(37, 554)
        Me.exitBtn.Name = "exitBtn"
        Me.exitBtn.Size = New System.Drawing.Size(75, 35)
        Me.exitBtn.TabIndex = 1
        Me.exitBtn.Text = "EXIT"
        Me.exitBtn.UseVisualStyleBackColor = True
        '
        'createBtn
        '
        Me.createBtn.Location = New System.Drawing.Point(335, 554)
        Me.createBtn.Name = "createBtn"
        Me.createBtn.Size = New System.Drawing.Size(75, 35)
        Me.createBtn.TabIndex = 2
        Me.createBtn.Text = "CREATE"
        Me.createBtn.UseVisualStyleBackColor = True
        '
        'viewBtn
        '
        Me.viewBtn.Location = New System.Drawing.Point(660, 554)
        Me.viewBtn.Name = "viewBtn"
        Me.viewBtn.Size = New System.Drawing.Size(75, 35)
        Me.viewBtn.TabIndex = 3
        Me.viewBtn.Text = "VIEW PDF"
        Me.viewBtn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(774, 601)
        Me.Controls.Add(Me.viewBtn)
        Me.Controls.Add(Me.createBtn)
        Me.Controls.Add(Me.exitBtn)
        Me.Controls.Add(Me.RichTextBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents exitBtn As Button
    Friend WithEvents createBtn As Button
    Friend WithEvents viewBtn As Button
End Class
