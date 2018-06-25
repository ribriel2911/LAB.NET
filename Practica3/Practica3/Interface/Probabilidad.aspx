<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Probabilidad.aspx.cs" Inherits="Practica3.Interface.Probabilidad" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Lanzar Dado" Width="114px" />
            <asp:TextBox ID="TextBox1" runat="server" Height="100px" style="margin-left: 31px" Width="295px" TextMode="MultiLine"></asp:TextBox>
        </div>
    </form>
</body>
</html>
