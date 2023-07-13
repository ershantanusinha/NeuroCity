<%@ Page Language="C#" AutoEventWireup="true" CodeFile="appo.aspx.cs" Inherits="appo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Message to: <asp:TextBox ID="txtTo" runat="server" /><br>
        Message from: <asp:TextBox ID="txtFrom" runat="server" /><br>
        Subject: <asp:TextBox ID="txtSubject" runat="server" /><br>
        Message Body:<br>
        <asp:TextBox ID="txtBody" runat="server" Height="171px" TextMode="MultiLine"  Width="270px" /><br>
        <asp:Button ID="Btn_SendMail" runat="server" onclick="Btn_SendMail_Click" Text="Send Email" /><br>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </div>
    </form>
</body>
</html>
