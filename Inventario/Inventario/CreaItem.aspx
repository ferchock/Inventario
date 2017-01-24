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
