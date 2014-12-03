Imports System.Data.SqlClient

Partial Class videoList
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim con As sqlconnection
        Dim com As SqlCommand
        Dim query As String
        Dim reader As SqlDataReader
        Dim videoId As New ArrayList
        Dim z As Integer = 0

        con = New SqlConnection(ConfigurationManager.ConnectionStrings("videoConnection").ConnectionString)

        query = "SELECT * FROM videos"
        Literal1.Text = ""
        errorLabel.Text = ""
        updateTextBox.Text = ""
        '<embed src='.\videos\" + reader("videoName") + "' autostart='false' />
        com = New SqlCommand(query, con)
        con.Open()
        reader = com.ExecuteReader
        Literal1.Text += "<table boder='1' bgcolor='white'><tr><th>Video name</th><th>Username</th><th>Date sumitted</th><th></tr>"
        If reader.HasRows Then
            While reader.Read
                videoId.Add(reader("id").ToString)
                Literal1.Text += "<tr>"
                '<a href="getting.asp?name=<%=name2%>&phone=<%=phone2%>" target="_self" >
                'Literal1.Text += "<td><a href='showVideo.aspx?videoId=" + videoId(z).ToString + "'>" + reader("videoName") + "</a></td>"
                Literal1.Text += "<td><a href='./videos/" + reader("videoName") + "'>" + reader("videoName") + "</a></td>"
                Literal1.Text += "<td>" + reader("username") + "</td>"
                Literal1.Text += "<td>" + reader("dateSubmitted") + "</td>"
                Literal1.Text += "</tr>"
                z += 1
            End While
        Else
            errorLabel.text = "No video can be found"
        End If
        con.Close()
        Literal1.Text += "</table>"
        'Literal2.Text += "THIS IS A LABEL!: "
        'Literal2.Text += "<a href='showVideo.aspx?videoId=Episode_26.wmv>TEST</a>"
    End Sub

    Protected Sub updateButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles updateButton.Click
        Dim con As SqlConnection
        Dim com As SqlCommand
        Dim query As String
        Dim success As Integer
        Dim currentDate As Date

        currentDate = Date.Now
        con = New SqlConnection(ConfigurationManager.ConnectionStrings("videoConnection").ConnectionString)

        query = "INSERT INTO videos (videoName,username,dateSubmitted) VALUES ('" + updateTextBox.Text + "','sazzad','06/23/2009 12:00:00')"
        '<embed src='.\videos\" + reader("videoName") + "' autostart='false' />
        com = New SqlCommand(query, con)
        con.Open()
        success = com.ExecuteNonQuery()
        con.Close()

        If success = 1 Then
            errorLabel.Text = "SUCCESS!"
        Else
            errorLabel.Text = "Can't insert!"
        End If


    End Sub
End Class
