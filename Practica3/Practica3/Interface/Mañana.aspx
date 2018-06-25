<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Mañana.aspx.cs" Inherits="Practica3.Interface.Mañana" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" Height="22px" OnClick="Button1_Click" style="margin-right: 38px" Text="Que dia es mañana?" Width="161px" />
            <asp:TextBox ID="TextBox1" runat="server" Height="37px" Width="312px"></asp:TextBox>
        </div>
    </form>
</body>
</html>
