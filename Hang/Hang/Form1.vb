Public Class Form1

    'This parent form was created to effectively dispose of the main program and start a fresh one when wanted.

#Region "Check Yes or No"

    'By clicking "yes" you begin the game and call a new instance of the main form.
    Private Sub yesButton_Click(sender As Object, e As EventArgs) Handles yesButton.Click
        Dim frm2 = New Form2
        frm2.Show()
        Me.Hide()
    End Sub

    'Clicking "no" closes the program.
    Private Sub noButton_Click(sender As Object, e As EventArgs) Handles noButton.Click
        Me.Close()
    End Sub
#End Region

End Class
