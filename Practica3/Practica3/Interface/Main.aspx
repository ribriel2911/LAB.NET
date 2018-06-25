<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="Practica3.Interface.Main" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" Text="Sumador" Width="70px" OnClick="Button1_Click" />
            <asp:Button ID="Button3" runat="server" style="margin-left: 28px" Text="Adivinar" Width="79px" OnClick="Button3_Click" />
            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" style="margin-left: 28px" Text="Probabilidad" Width="101px" />
        </div>
        <p>
            <asp:Button ID="Button2" runat="server" style="margin-left: 1px" Text="Positivos" Width="70px" OnClick="Button2_Click" />
            <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" style="margin-left: 27px; margin-right: 0px" Text="Multiplo" Width="79px" />
            <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" style="margin-left: 39px; margin-right: 22px" Text="Mañana" Width="83px" />
        </p>
    </form>
</body>
</html>
