<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Positivos.aspx.cs" Inherits="Practica3.Positivos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" Text="Empezar" Width="76px" OnClick="Button1_Click" />
        </div>
        <asp:TextBox ID="TextBox1" runat="server" Height="16px" style="margin-left: 1px; margin-bottom: 0px" Width="123px"></asp:TextBox>
        <asp:Button ID="Button2" runat="server" style="margin-left: 13px; margin-right: 17px" Text="Ingresar" Width="80px" OnClick="Button2_Click" />
        <p>
            <asp:Button ID="Button3" runat="server" style="margin-top: 0px" Text="Analizar" OnClick="Button3_Click" />
        </p>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Resultado"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" Height="90px" style="margin-left: 17px; margin-top: 0px" Width="168px" TextMode="MultiLine"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
