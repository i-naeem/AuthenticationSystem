Imports System.Data.SqlClient

Public Class Login
    ReadOnly connectionString As String = "Server=Localhost\SQLEXPRESS;database=master;Integrated Security=true"
    ReadOnly con As New SqlConnection(connectionString)


    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        Dim username As String = UsernameTextBox.Text
        Dim password As String = PasswordTextBox.Text

        ' Check if password or username is empty give error
        If String.IsNullOrEmpty(username) Or String.IsNullOrEmpty(password) Then
            MessageBox.Show("Username or email can not be empty.")
        Else
            ' Check if user exist with given username and password
            Dim query As String = "SELECT user FROM users_table WHERE username = " + username + " AND password = " + password
            Dim cmd As SqlDataAdapter = New SqlDataAdapter(query, con)


            Me.Hide()
            ' Reset the username and password input.
            UsernameTextBox.Text = ""
            PasswordTextBox.Text = ""
            Dashboard.Show()
        End If
    End Sub
End Class
