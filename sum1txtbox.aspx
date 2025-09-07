<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="sum1txtbox.aspx.cs" Inherits="AdRevision.sum1txtbox" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            EnterNumber1:<asp:TextBox ID="txtnum1" runat="server" AutoPostBack="True" OnTextChanged="txtnum1_TextChanged" style="height: 22px"></asp:TextBox>
            <br />
            EnterNumber2:<asp:TextBox ID="txtnum2" runat="server" AutoPostBack="True" OnTextChanged="txtnum2_TextChanged"></asp:TextBox>

        </div>
    </form>
</body>
</html>
