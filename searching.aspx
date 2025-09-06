<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="searching.aspx.cs" Inherits="Work.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
        <tr>
            <td>Searching:</td>
            <td>
                <asp:TextBox ID="txtsrh" runat="server" AutoPostBack="True" OnTextChanged="txtsrh_TextChanged"></asp:TextBox>
            </td>

        </tr>
       

    </table>
                                <asp:GridView ID="GridView1" runat="server" ></asp:GridView>


</asp:Content>
