<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewState.aspx.cs" Inherits="WebApp.ViewState" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:TextBox ID="sampleTxt" runat="server"></asp:TextBox>
        <asp:Button ID="sampleBtn" runat="server" OnClick="sampleBtn_Click" Text="Button" />
    </form>
</body>
</html>
