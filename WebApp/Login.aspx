<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApp.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 372px;
        }
        .auto-style3 {
            height: 30px;
        }
        .auto-style4 {
            width: 372px;
            height: 30px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style2">DEPLOYEMENT BY FILE COPY</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style2">&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label1" runat="server" Text="Username :"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server" Width="233px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="*" ForeColor="Red" ValidationGroup="a"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3"></td>
                <td class="auto-style4">&nbsp;&nbsp; &nbsp;<asp:Label ID="Label2" runat="server" Text="Password :"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox2" runat="server" TextMode="Password" ToolTip="Enter Your Password Here." Width="231px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="*" ForeColor="Red" ValidationGroup="a"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style2">
                    <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click">Register </asp:LinkButton>
                </td>
                <td>
                    <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click" ValidationGroup="a">Login</asp:LinkButton>
                </td>
            </tr>
        </table>
    
    </div>
        <asp:Label ID="Label3" runat="server"></asp:Label>
    </form>
</body>
</html>
