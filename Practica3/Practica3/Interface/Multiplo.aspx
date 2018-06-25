<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Multiplo.aspx.cs" Inherits="Practica3.Interface.Multiplo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBox1" runat="server" Width="72px"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="margin-left: 28px; margin-right: 32px" Text="Es multiplo de 5?" Width="114px" />
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
