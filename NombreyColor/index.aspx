<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="NombreyColor.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="lblNombre" runat="server" Text="Nombre:"></asp:Label>
        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblColor" runat="server" Text="Color:"></asp:Label>
        <asp:TextBox ID="txtColor" runat="server"></asp:TextBox>
    
        <br />
        <asp:Button ID="btnOk" runat="server" OnClick="Button1_Click" Text="Ok" />
    
    </div>
    </form>
</body>
</html>
