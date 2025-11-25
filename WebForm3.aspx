<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="WebApplication1.WebForm3" culture="auto" meta:resourcekey="PageResource1" uiculture="auto" %>

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

                    <td>

                        <asp:Label ID="lblnm" runat="server" Text="Name" meta:resourcekey="lblnmResource1"></asp:Label>
                    </td>

                    <td>
                        <asp:TextBox ID="txtnm" runat="server"></asp:TextBox> 

                    </td>

                </tr>


                <tr>

                    <td>
                        <asp:Label ID="lblddl" runat="server" Text="Select" meta:resourcekey="lblddlResource1"></asp:Label>


                    </td>



                    <td>
                        <asp:DropDownList ID="DropDownList1" runat="server" meta:resourcekey="DropDownList1Resource1" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                            <asp:ListItem meta:resourcekey="ListItemResource1" Value="en">English</asp:ListItem>
                            <asp:ListItem meta:resourcekey="ListItemResource2" Value="gu">Gujrati</asp:ListItem>
                            <asp:ListItem meta:resourcekey="ListItemResource3" Value="hi">Hindi</asp:ListItem>
                        </asp:DropDownList>

                    </td>



                </tr>


            </table>


        </div>
    </form>
</body>
</html>
