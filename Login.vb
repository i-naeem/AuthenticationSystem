Public Class Login
    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        Dim username As String = UsernameTextBox.Text
        Dim password As String = PasswordTextBox.Text

        ' Check if password or username is empty give error
        If String.IsNullOrEmpty(username) Or String.IsNullOrEmpty(password) Then
            MessageBox.Show("Username or email can not be empty.")
        Else
            Me.Hide()
            ' Reset the username and password input.
            UsernameTextBox.Text = ""
            PasswordTextBox.Text = ""
            Dashboard.Show()
        End If
    End Sub
End Class
