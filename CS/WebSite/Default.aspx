﻿<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register Assembly="DevExpress.Web.v13.1" Namespace="DevExpress.Web"
    TagPrefix="dx" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <dx:ASPxCaptcha ID="ASPxCaptcha1" runat="server" OnChallengeImageCustomRender="ASPxCaptcha1_ChallengeImageCustomRender">
        </dx:ASPxCaptcha>
    
    </div>
    </form>
</body>
</html>
