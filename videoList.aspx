<%@ Page Language="VB" AutoEventWireup="false" CodeFile="videoList.aspx.vb" Inherits="videoList" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<title>Video Transmission over 3G</title>
<link href="default.css" rel="stylesheet" type="text/css" media="screen" />
</head>
<body>
<!-- start header -->
<div id="header">
<div id="logo">
	<h1>
        <span style="font-size: 1em">Video Transmission over 3g</span> <a href="#">&nbsp;</a></h1>
</div>
<div id="menu">
	<ul id="main">
	<li class="current_page_item"><a href="#"><span style="color: #99cc00">Homepage</span></a></li>
		<li><a href="livevideo.aspx"><span style="color: #99cc00">Live Video</span></a></li>
		<li><a href="videoList.aspx"><span style="color: #ffffff">Video list</span></a></li>
		<li><a href="aboutus.aspx"><span style="color: #99cc00">About Us</span></a></li>
	</ul>
	<ul id="feed">
		<li>&nbsp;</li><li></li>
	</ul>
</div>
</div>
<!-- end header -->

    <form id="form1" runat="server">

<div id="wrapper">
<!-- start page -->
<div id="page">
	<!-- start content -->
	<div id="content">
		<div style="padding-bottom: 20px;">
            &nbsp;</div>
		<div class="post">
			<h1 class="title"><a href="#"><span style="color: #66cc00">Video List&nbsp;</span></a></h1>
			<p class="byline">
                <asp:Label ID="errorLabel" runat="server"></asp:Label>
                        </p>
                        <p class="byline">
                            <asp:Literal ID="Literal1" runat="server"></asp:Literal>
                        </p>
                        <p class="byline">
                            <asp:TextBox ID="updateTextBox" runat="server"></asp:TextBox>
                            <asp:Button ID="updateButton" runat="server" Text="Update DB" />
                        </p>
                        <p class="byline">
                            <asp:Literal ID="Literal2" runat="server"></asp:Literal>
                        </p>
		</div>
	</div>
	            <br />
	<!-- end content -->
	<!-- start sidebars -->
	<!-- end sidebars -->
	<div style="clear: both;">&nbsp;</div>
</div>
<!-- end page -->
</div>
<div id="footer">
	<p>
        �2009 All Rights Reserved FSKSM, UTM.</p>
</div>
    <div>
    
    </div>
    </form>
</body>
</html>
