Public Class Form2

#Region "Declarations"
    Private output As New IO.StreamReader("..\..\words2.txt") 'change words2.txt to wordTest.txt to test the program
    Dim wordList As String = output.ReadToEnd()
    Dim words As String() = wordList.Split(Convert.ToChar(vbLf)) 'words2.txt uses only Line Feed characters between words
    Dim rand As New Random()
    Dim wordAddress As Integer = 0
    Dim wordLimit As Integer = 0
    Dim hangCounter As Integer = 0
    Dim winCounter As Integer = 0
    Dim letterBoxes As TextBox()
    Dim usedCorrectLetters As String = String.Empty
#End Region

#Region "Form Interface"

    'This is fairly straightforward.  Basically, it instantiates and otherwise enables.
    Public Sub startButton_Click(sender As Object, e As EventArgs) Handles startButton.Click


        If wordlimitCheckBox.Checked = True Then
            wordLimit = CInt(wordlimitNumericUpDown.Value)
        End If

        wordAddress = WordPicker()
        letterBoxes = TextBoxPlacement(words(wordAddress).Count)
        checkButton.Enabled = True
        guessTextBox.Enabled = True
        wordlimitCheckBox.Enabled = False
        wordlimitNumericUpDown.Enabled = False
        startButton.Enabled = False

    End Sub

    'The beauty of the program lies here.  It checks for the right letters and displays the letters in the textbox array
    '*wherever they are found* or it starts to hang you if you fail by executing Hangman().
    'If you win the game, it shows the parent form and closes out this form.  Hangman() takes care of that if you lose.
    Private Sub checkButton_Click(sender As Object, e As EventArgs) Handles checkButton.Click

        Dim guessWinCounter = 0
        If usedCorrectLetters.Contains(guessTextBox.Text) Then
            MessageBox.Show("Cain't ya reed, sonny?")
            Return
        Else
            For x As Integer = 0 To words(wordAddress).Count - 1

                Select Case guessTextBox.Text.ToLower()

                    Case words(wordAddress)(x)
                        letterBoxes(x).Text = words(wordAddress)(x)
                        usedCorrectLetters += words(wordAddress)(x)
                        winCounter += 1
                        guessWinCounter += 1

                End Select

            Next
        End If

        If winCounter = words(wordAddress).Count Then

            checkButton.Enabled = False
            startButton.Enabled = True
            MessageBox.Show("You pardoned the poor soul.  Congratulations!")
            winCounter = 0
            hangCounter = 0
            Form1.Show()
            Me.Close()

        ElseIf guessWinCounter = 0 Then

            Hangman()

        End If

    End Sub

#End Region

#Region "Starting Methods"

    'This was nifty to me, because the word list filled with huge words that nobody knows.
    'If you enable the word limit, it will keep searching for a word until it finds one that fits the criteria.
    Private Function WordPicker() As Integer

        If wordLimit >= SmallestWordCount() AndAlso wordLimit <= LargestWordCount() AndAlso wordlimitCheckBox.Checked = True Then
            Dim num As Integer
            Do
                num = rand.Next(0, words.Count)

            Loop Until words(num).Count = wordLimit

            Return num

        End If

        Return rand.Next(0, words.Count)

    End Function

    'This instantiates the TextBox array.
    Private Function TextBoxPlacement(wordcount As Integer) As TextBox()

        Const spacing As Integer = 20
        Dim textboxes(LargestWordCount()) As TextBox

        For x = 0 To wordcount - 1
            textboxes(x) = New TextBox
            textboxes(x).Enabled = False
            textboxes(x).Size = New Size(18, 20)
            textboxes(x).Location = New Point(12 + (x * spacing), 480)
            textboxes(x).MaxLength = 1
            textboxes(x).Visible = True
            Controls.Add(textboxes(x))
        Next

        Return textboxes
    End Function

    'This finds the length of the longest word.
    Private Function LargestWordCount() As Integer
        Dim y As Integer = 0
        For x As Integer = 0 To words.Count - 1
            If y < words(x).Count Then
                y = words(x).Count
            End If
        Next
        Return y
    End Function


    'This finds the length of the shortest word.
    Private Function SmallestWordCount() As Integer
        Dim y As Integer = LargestWordCount()
        For x As Integer = 0 To words.Count - 1
            If y > words(x).Count Then
                y = words(x).Count
            End If
        Next
        Return y
    End Function

#End Region

    'This simply fills in the man being hanged.  If he is filled in completely,
    'you receive a message that tells you what the words is that you missed.
    Private Sub Hangman()
        hangCounter += 1

        Select Case hangCounter
            Case 1
                hangmanTextBox.Text += "O"
            Case 2
                hangmanTextBox.Text += ControlChars.NewLine + "-"
            Case 3
                hangmanTextBox.Text += "|"
            Case 4
                hangmanTextBox.Text += "-"
            Case 5
                hangmanTextBox.Text += ControlChars.NewLine + "|"
            Case 6
                hangmanTextBox.Text += "|"
                checkButton.Enabled = False
                MessageBox.Show("Why'd ya hang 'im?" + ControlChars.NewLine + "By the way, your word was: " + words(wordAddress) + ".")
                startButton.Enabled = True
                winCounter = 0
                hangCounter = 0
                Form1.Show()
                Me.Close()
        End Select

    End Sub
End Class