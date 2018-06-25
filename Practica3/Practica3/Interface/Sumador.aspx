<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Sumador.aspx.cs" Inherits="Practica3.Sumador" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" Text="Sumar" OnClick="Sumar_Click" />
            <asp:Button ID="Button2" runat="server" Text="Limpiar" OnClick="Limpiar_Click" />
        </div>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </form>
</body>
</html>
