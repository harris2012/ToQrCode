<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ToQrCode.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="ContentTextBox" runat="server" Text="http://192.168.1.100:1234/apk/app-debug.apk"></asp:TextBox>
        </div>
        <div>
            <asp:Button ID="BtStart" runat="server" Text="Button" OnClick="BtStart_Click" />
        </div>
        <div>
            <asp:Image ID="QrImage" runat="server" />
        </div>
    </form>
</body>
</html>
