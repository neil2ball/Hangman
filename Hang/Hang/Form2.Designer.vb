<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.checkButton = New System.Windows.Forms.Button()
        Me.wordlimitGroupBox = New System.Windows.Forms.GroupBox()
        Me.wordlimitNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.wordlimitCheckBox = New System.Windows.Forms.CheckBox()
        Me.startButton = New System.Windows.Forms.Button()
        Me.hangmanTextBox = New System.Windows.Forms.TextBox()
        Me.letterGroupBox = New System.Windows.Forms.GroupBox()
        Me.guessTextBox = New System.Windows.Forms.TextBox()
        Me.wordlimitGroupBox.SuspendLayout()
        CType(Me.wordlimitNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.letterGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'checkButton
        '
        Me.checkButton.Enabled = False
        Me.checkButton.Location = New System.Drawing.Point(6, 15)
        Me.checkButton.Name = "checkButton"
        Me.checkButton.Size = New System.Drawing.Size(75, 23)
        Me.checkButton.TabIndex = 0
        Me.checkButton.Text = "Check 'em!"
        Me.checkButton.UseVisualStyleBackColor = True
        '
        'wordlimitGroupBox
        '
        Me.wordlimitGroupBox.Controls.Add(Me.wordlimitNumericUpDown)
        Me.wordlimitGroupBox.Controls.Add(Me.wordlimitCheckBox)
        Me.wordlimitGroupBox.Location = New System.Drawing.Point(305, 515)
        Me.wordlimitGroupBox.Name = "wordlimitGroupBox"
        Me.wordlimitGroupBox.Size = New System.Drawing.Size(245, 34)
        Me.wordlimitGroupBox.TabIndex = 1
        Me.wordlimitGroupBox.TabStop = False
        Me.wordlimitGroupBox.Text = "Letter Limit"
        '
        'wordlimitNumericUpDown
        '
        Me.wordlimitNumericUpDown.Location = New System.Drawing.Point(119, 8)
        Me.wordlimitNumericUpDown.Name = "wordlimitNumericUpDown"
        Me.wordlimitNumericUpDown.ReadOnly = True
        Me.wordlimitNumericUpDown.Size = New System.Drawing.Size(120, 20)
        Me.wordlimitNumericUpDown.TabIndex = 1
        '
        'wordlimitCheckBox
        '
        Me.wordlimitCheckBox.AutoSize = True
        Me.wordlimitCheckBox.Location = New System.Drawing.Point(17, 15)
        Me.wordlimitCheckBox.Name = "wordlimitCheckBox"
        Me.wordlimitCheckBox.Size = New System.Drawing.Size(65, 17)
        Me.wordlimitCheckBox.TabIndex = 0
        Me.wordlimitCheckBox.Text = "Enabled"
        Me.wordlimitCheckBox.UseVisualStyleBackColor = True
        '
        'startButton
        '
        Me.startButton.Font = New System.Drawing.Font("Playbill", 48.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.startButton.Location = New System.Drawing.Point(99, 3)
        Me.startButton.Name = "startButton"
        Me.startButton.Size = New System.Drawing.Size(311, 75)
        Me.startButton.TabIndex = 2
        Me.startButton.Text = "String 'em up!"
        Me.startButton.UseVisualStyleBackColor = True
        '
        'hangmanTextBox
        '
        Me.hangmanTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hangmanTextBox.Location = New System.Drawing.Point(264, 196)
        Me.hangmanTextBox.Multiline = True
        Me.hangmanTextBox.Name = "hangmanTextBox"
        Me.hangmanTextBox.Size = New System.Drawing.Size(100, 166)
        Me.hangmanTextBox.TabIndex = 3
        Me.hangmanTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'letterGroupBox
        '
        Me.letterGroupBox.Controls.Add(Me.guessTextBox)
        Me.letterGroupBox.Controls.Add(Me.checkButton)
        Me.letterGroupBox.Location = New System.Drawing.Point(12, 515)
        Me.letterGroupBox.Name = "letterGroupBox"
        Me.letterGroupBox.Size = New System.Drawing.Size(271, 45)
        Me.letterGroupBox.TabIndex = 4
        Me.letterGroupBox.TabStop = False
        Me.letterGroupBox.Text = "Guess your letter here"
        '
        'guessTextBox
        '
        Me.guessTextBox.Enabled = False
        Me.guessTextBox.Location = New System.Drawing.Point(140, 18)
        Me.guessTextBox.MaxLength = 1
        Me.guessTextBox.Name = "guessTextBox"
        Me.guessTextBox.Size = New System.Drawing.Size(100, 20)
        Me.guessTextBox.TabIndex = 1
        Me.guessTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(584, 561)
        Me.ControlBox = False
        Me.Controls.Add(Me.letterGroupBox)
        Me.Controls.Add(Me.hangmanTextBox)
        Me.Controls.Add(Me.startButton)
        Me.Controls.Add(Me.wordlimitGroupBox)
        Me.Name = "Form2"
        Me.Text = "Hangman!"
        Me.wordlimitGroupBox.ResumeLayout(False)
        Me.wordlimitGroupBox.PerformLayout()
        CType(Me.wordlimitNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.letterGroupBox.ResumeLayout(False)
        Me.letterGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents checkButton As Button
    Friend WithEvents wordlimitGroupBox As GroupBox
    Friend WithEvents wordlimitNumericUpDown As NumericUpDown
    Friend WithEvents wordlimitCheckBox As CheckBox
    Friend WithEvents startButton As Button
    Friend WithEvents hangmanTextBox As TextBox
    Friend WithEvents letterGroupBox As GroupBox
    Friend WithEvents guessTextBox As TextBox
End Class
