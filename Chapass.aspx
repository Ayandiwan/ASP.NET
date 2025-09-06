<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Chapass.aspx.cs" Inherits="Work.WebForm7" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
        <tr>
            <td>CurrentPassword:</td>
            <td>
                <asp:TextBox ID="txtcurpass" TextMode="Password" runat="server"></asp:TextBox>

            </td>
        </tr>

        <tr>
            <td>NewPassword:</td>
            <td>
                <asp:TextBox ID="txtnewpass" TextMode="Password" runat="server"></asp:TextBox>

            </td>
        </tr>
        <tr>
            <td>Repeatepass:</td>
            <td>
                <asp:TextBox ID="txtreppass" TextMode="Password" runat="server"></asp:TextBox></td>
        </tr>

        <tr>
            <td></td>
            <td>
                <asp:Button ID="Submit" runat="server" Text="Submit" OnClick="Submit_Click" />
                <asp:Button ID="Resect" runat="server" Text="Resect" />


            </td>


        </tr>


    </table>

</asp:Content>
