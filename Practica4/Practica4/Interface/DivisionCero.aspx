<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DivisionCero.aspx.cs" Inherits="Practica4.Interface.DivisionCero" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" Height="25px" OnClick="Button1_Click" style="margin-bottom: 16px" Text="SimpleException" Width="125px" />
        </div>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <p>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </p>
    </form>
</body>
</html>
