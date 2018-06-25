<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Adivinar.aspx.cs" Inherits="Practica3.Interface.Adivinar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Nuevo Juego" />
            <asp:TextBox ID="TextBox1" runat="server" style="margin-left: 39px" Width="16px"></asp:TextBox>
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" style="margin-left: 12px; margin-right: 17px" Text="Probar" Width="47px" />
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
