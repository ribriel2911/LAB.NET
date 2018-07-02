<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Practica2.aspx.cs" Inherits="LabHerenciaPolimorfismo.Practica2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="col-lg-12">
            <asp:GridView ID="Grid1" runat="server" onrowcommand = "CustomersGridView_RowCommand"  class="table table-striped">
                <Columns>
                    <asp:ButtonField ButtonType="Button" CommandName="Hablar" Text="Hablar"/>
                    <asp:ButtonField ButtonType="Button" CommandName="Caminar" Text="Caminar"/>
                    <asp:ButtonField ButtonType="Button" CommandName="Respirar" Text="Respirar"/>
                </Columns>
            </asp:GridView>
            <div class="form-group col-lg-6">
                <asp:TextBox ID="txtAction" runat="server" class="form-control" Height="50px" Width="300px" /><br />
            </div>
        </div>
    </form>
</body>
</html>
