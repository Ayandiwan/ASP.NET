<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="3 number sum.aspx.cs" Inherits="AdRevision._3_number_sum" %>

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
                    <td>EnterNumber1:</td>
                    <td>
                        <asp:TextBox ID="txtnum1" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>EnterNumber2:</td>
                    <td>
                        <asp:TextBox ID="txtnum2" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>EnterNumber3:</td>
                    <td>
                        <asp:TextBox ID="txtnum3" runat="server"></asp:TextBox>
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
    </form>
</body>
</html>
