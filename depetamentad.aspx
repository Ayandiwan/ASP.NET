<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="depetamentad.aspx.cs" Inherits="Work.depetamentad" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Department:

            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource1" DataTextField="deptname" DataValueField="deptid"></asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [DEPT]"></asp:SqlDataSource>
            <br />
            <br />
            <br />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="empid" DataSourceID="SqlDataSource2">
                <Columns>
                    <asp:BoundField DataField="empid" HeaderText="empid" ReadOnly="True" SortExpression="empid" />
                    <asp:BoundField DataField="empName" HeaderText="empName" SortExpression="empName" />
                    <asp:BoundField DataField="empSurname" HeaderText="empSurname" SortExpression="empSurname" />
                </Columns>
            </asp:GridView>

            <br />
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [emp] WHERE ([empid] = @empid)">
                <SelectParameters>
                    <asp:ControlParameter ControlID="DropDownList1" Name="empid" PropertyName="SelectedValue" Type="Int32" />
                </SelectParameters>
            </asp:SqlDataSource>

        </div>
    </form>
</body>
</html>
