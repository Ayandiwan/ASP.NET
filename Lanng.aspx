<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Lanng.aspx.cs" Inherits="Globalization.Lanng" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Globalization Example</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="ddlLanguage" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlLanguage_SelectedIndexChanged">
                <asp:ListItem Text="English" Value="en" />
                <asp:ListItem Text="French" Value="fr" />
                <asp:ListItem Text="Hindi" Value="Hr" />

            </asp:DropDownList>
            <br />
            <br />
            <asp:Label ID="lblWelcome" runat="server" Font-Size="Large" />
        </div>
    </form>
</body>
</html>
