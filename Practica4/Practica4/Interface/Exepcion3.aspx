<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Exepcion3.aspx.cs" Inherits="Practica4.Interface.Exepcion3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" Height="24px" OnClick="Button1_Click" style="margin-bottom: 13px" Text="Generar Excepcion" />
        </div>
        Excepcion<p>
            <asp:TextBox ID="TextBox1" runat="server" style="margin-top: 0px" Height="29px" Width="523px"></asp:TextBox>
        </p>
    </form>
</body>
</html>
