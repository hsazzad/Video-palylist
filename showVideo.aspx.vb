﻿
Partial Class showVideo
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(B al sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Label1.Text = "Video ID is: " + Request.QueryString("videoId")
    End Sub
End Class
