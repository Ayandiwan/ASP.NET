<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="pdf_itext.aspx.cs" Inherits="itext_demo.pdf_itext" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>iTextSharp PDF Generation</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align:center; margin-top:50px;">
            <asp:Button ID="Button1" runat="server" Text="Generate PDF" 
                BackColor="#007bff" ForeColor="White" Font-Bold="True"
                Height="40px" Width="180px"
                OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
