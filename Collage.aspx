<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Collage.aspx.cs" Inherits="Work.WebForm6" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
        <tr>
            <td>Collage:</td>
            <td>
                <asp:DropDownList ID="collage" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="True"></asp:DropDownList>
            </td>
        </tr>

        <tr>
            <td>Profeser::</td>
            <td>
                <asp:DropDownList ID="pro" runat="server"  ></asp:DropDownList>
            </td>
        </tr>

        <tr>
            <td></td>
            <td>
                <asp:Button ID="Submit"  runat="server" Text="Submit" OnClick="Submit_Click" />
                <asp:Button ID="Resect" runat="server" Text="Resect" />

            </td>


        </tr>


    </table>


</asp:Content>
