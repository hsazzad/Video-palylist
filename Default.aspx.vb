Imports System.Data.SqlClient

Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub logInButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles logInButton.Click
        Dim username As String
        Dim password As String
        Dim strConn As SqlConnection
        Dim sqlUserName As String
        Dim reader As SqlDataReader
        Dim com As SqlCommand

        Session("userNameSession") = ""

        'Dim something As String

        'something =  Session("userNameSession").ToString
        '(to retrieve from previous page)

        username = usernameTextBox.Text
        password = passwordTextBox.Text

        strConn = New SqlConnection(ConfigurationManager.ConnectionStrings("videoConnection").ToString)

        If (usernameTextBox.Text = "" Or passwordTextBox.Text = "") Then
            errorLabel.Text = "Please fill in all the fields"
        Else
        End If

        Try

            sqlUserName = "SELECT username  FROM users WHERE username = '" + username + "' AND password = '" + password + "'"
            com = New SqlCommand(sqlUserName, strConn)

            strConn.Open()
            reader = com.ExecuteReader

            If reader.HasRows Then
                While reader.Read
                    Session("userNameSession") = reader("username").ToString
                    ' Session("privilegeSession") = reader("privilege").ToString

                End While
                strConn.Close()
                'sqlFullName = "SELECT * FROM userDetails WHERE username = '" + username + "'"
                ' com = New SqlCommand(sqlFullName, strConn)
                'strConn.Open()
                ' 'reader = com.ExecuteReader
                'While reader.Read
                'ion("fullNameSession") = reader("firstName").ToString + " " + reader("lastName")
                Response.Redirect("videoList.aspx")
                'End While
                strConn.Close()

            Else

                errorLabel.Text = "Your username and password is not correct"
            End If

        Catch ex As Exception
            errorLabel.Text = ex.Message
        End Try
    End Sub

    Protected Sub usernameTextBox_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles usernameTextBox.TextChanged

    End Sub
End Class
