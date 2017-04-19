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
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.enter = New System.Windows.Forms.TextBox()
        Me.json_file = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(12, -57)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(0, 0)
        Me.WebBrowser1.TabIndex = 0
        '
        'enter
        '
        Me.enter.Location = New System.Drawing.Point(12, 237)
        Me.enter.Name = "enter"
        Me.enter.Size = New System.Drawing.Size(403, 20)
        Me.enter.TabIndex = 1
        '
        'json_file
        '
        Me.json_file.Location = New System.Drawing.Point(12, 12)
        Me.json_file.Multiline = True
        Me.json_file.Name = "json_file"
        Me.json_file.ReadOnly = True
        Me.json_file.Size = New System.Drawing.Size(403, 219)
        Me.json_file.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(427, 269)
        Me.Controls.Add(Me.json_file)
        Me.Controls.Add(Me.enter)
        Me.Controls.Add(Me.WebBrowser1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Read Json File @dreammein"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents enter As System.Windows.Forms.TextBox
    Friend WithEvents json_file As System.Windows.Forms.TextBox

End Class
