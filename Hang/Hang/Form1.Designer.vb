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
        Me.yesButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.noButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'yesButton
        '
        Me.yesButton.Location = New System.Drawing.Point(28, 141)
        Me.yesButton.Name = "yesButton"
        Me.yesButton.Size = New System.Drawing.Size(75, 23)
        Me.yesButton.TabIndex = 0
        Me.yesButton.Text = "Yes"
        Me.yesButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Playbill", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(-5, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(296, 38)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Are you ready for Hangman?"
        '
        'noButton
        '
        Me.noButton.Location = New System.Drawing.Point(162, 141)
        Me.noButton.Name = "noButton"
        Me.noButton.Size = New System.Drawing.Size(75, 23)
        Me.noButton.TabIndex = 2
        Me.noButton.Text = "No"
        Me.noButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.noButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.yesButton)
        Me.Name = "Form1"
        Me.Text = "Hangman?"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents yesButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents noButton As Button
End Class
