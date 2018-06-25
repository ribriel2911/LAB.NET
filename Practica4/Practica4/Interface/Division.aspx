<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Division.aspx.cs" Inherits="Practica4.Interface.Division" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Ingrese Dividendo:"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" style="margin-left: 17px; margin-bottom: 0px" Width="116px"></asp:TextBox>
        </div>
        <asp:Label ID="Label2" runat="server" Text="Ingrese Divisor:"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server" style="margin-left: 16px; margin-top: 12px"></asp:TextBox>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Dividir" />
        </p>
        <asp:Label ID="Label3" runat="server" Text="Resultado:"></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server" style="margin-left: 16px"></asp:TextBox>
        <p>
            <asp:Label ID="Label4" runat="server" Text="Exepcion:"></asp:Label>
            <asp:TextBox ID="TextBox4" runat="server" style="margin-left: 16px"></asp:TextBox>
        </p>
    </form>
</body>
</html>
