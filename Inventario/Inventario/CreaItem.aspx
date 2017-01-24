<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreaItem.aspx.cs" Inherits="Inventario.CreaItem" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        
    
        <asp:GridView ID="grvItems" runat="server" AutoGenerateColumns="False" DataKeyNames="ID" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="ID" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="ID" />
                <asp:BoundField DataField="ItemCode" HeaderText="ItemCode" SortExpression="ItemCode" />
                <asp:BoundField DataField="Description" HeaderText="Description" SortExpression="Description" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:InventarioConnectionString %>" SelectCommand="SELECT * FROM [Items]"></asp:SqlDataSource>
        <br />
        <asp:Button ID="btnShow" runat="server" OnClick="btnShow_Click" Text="Show" />
        <br />
        <br />
        
        
    
        Item Code&nbsp;
        <asp:TextBox ID="txtItemCode" runat="server"></asp:TextBox>
        <br />
        Description
        <asp:TextBox ID="txtDescription" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="btnCrear" runat="server" Text="Crear" OnClick="btnCrear_Click" />
&nbsp;<asp:Label ID="lblStatus" runat="server" Text=""></asp:Label>
        
    
    </div>
    </form>
</body>
</html>
