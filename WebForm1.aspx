<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="palim.WebForm1" %>

<%@ Register assembly="palindrome" namespace="palindrome" tagprefix="cc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Enter a word: <br /> 
            <asp:TextBox ID="TextBox1" runat="server" style="width:198px" AutoPostBack="True"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="Check" />
            <br /> <br /> 
            <cc1:WebCustomControl1 ID="WebCustomControl11" runat="server" />
            <br /> <br /> 

        </div> 

    </form>
</body>
</html>
