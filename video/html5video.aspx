<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="html5video.aspx.cs" Inherits="video.playvideo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <video style="width:602px;height:365px" controls="controls"> 
    <source src="video/test.mp4" type="video/mp4"/>
</video> 
        <div> 
            <audio controls="controls">  
       <source src="mp3/test.mp3" type="audio/mp3" />       
   </audio> 
        </div>   
    </div>
    </form>
</body>
</html>
