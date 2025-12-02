<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="WebApplication1.Index" %>

<!DOCTYPE html>
<html>
<head>
    <title>LINQ to SQL CRUD Example</title>
</head>
<body>

    <form id="form1" runat="server">
        <h2>LINQ to SQL CRUD Example</h2>

        Name:
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox><br />

        City:
        <asp:TextBox ID="txtCity" runat="server"></asp:TextBox><br /><br />

        Enter ID (for update/delete):
        <asp:TextBox ID="txtId" runat="server"></asp:TextBox><br /><br />

        <asp:Button ID="btnInsert" runat="server" Text="Insert" OnClick="btnInsert_Click" />
        <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />
        <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" /><br /><br />

        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
    </form>

</body>
</html>
