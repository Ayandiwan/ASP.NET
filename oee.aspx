<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="oee.aspx.cs" Inherits="oddand_even.oee" %>

<%@ Register assembly="oe" namespace="oe" tagprefix="cc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>Enter NO:</td>
                    <td>
                        <asp:TextBox ID="txtnum" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Button ID="Submit" runat="server" Text="Submit" OnClick="Submit_Click" />
                    </td>
                </tr>
                
            </table>
        </div>
        <cc1:WebCustomControl1 ID="WebCustomControl11" runat="server" />
    </form>
</body>
</html>
