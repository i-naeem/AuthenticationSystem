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
            ' Creates a query to select user.
            Dim query As String = "SELECT * FROM users_table WHERE username = '" + username + "' AND password = '" + password + "'"

            Dim cmd As New SqlDataAdapter(query, con)
            Dim dt As New DataTable()

            ' Fill the data table with results from database
            cmd.Fill(dt)

            ' Check if user exist with given username and password
            If dt.Rows.Count > 0 Then
                ' Hide the login form
                Me.Hide()

                ' Reset the username and password input.
                UsernameTextBox.Text = ""
                PasswordTextBox.Text = ""

                ' Show the dashboard form
                Dashboard.Show()
            Else
                MessageBox.Show("Username or password is incorrect")
            End If

        End If
    End Sub
End Class
