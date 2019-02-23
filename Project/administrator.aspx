<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="administrator.aspx.cs" Inherits="Project.administrator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="style.css"/>
</head>
<body>
    <form id="form1" runat="server">
        <fieldset>
            <p>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="SqlDataSource1" AllowSorting="True" onrowcommand="GridView1_RowCommand">
                <Columns>
                    <asp:BoundField DataField="Id" HeaderText="Id" ReadOnly="True" SortExpression="Id" />
                    <asp:BoundField DataField="firstName" HeaderText="firstName" SortExpression="firstName" />
                    <asp:BoundField DataField="lastName" HeaderText="lastName" SortExpression="lastName" />
                    <asp:BoundField DataField="address" HeaderText="address" SortExpression="address" />
                    <asp:BoundField DataField="cityNum" HeaderText="cityNum" SortExpression="cityNum" />
                    <asp:BoundField DataField="phone" HeaderText="phone" SortExpression="phone" />
                    <asp:ButtonField ButtonType="Button" Text="ok" CommandName="cmd" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:pDBConnectionString %>" SelectCommand="SELECT * FROM [Customers]"></asp:SqlDataSource>
            </p>
            <p>
            <asp:Label ID="lblRow" runat="server" Text="null" />
            </p>
            <asp:DropDownList ID="DropDownList" runat="server" DataSourceID="SqlDataSource1" DataTextField="Id" DataValueField="firstName" >
            <asp:ListItem></asp:ListItem>
            </asp:DropDownList>
            <asp:button Text="Submit" OnClick="SubmitBtn_Click" runat="server"/>        
            <p>      
            DropDown: <asp:Label ID="Label1" runat="server" Text="null" />
            </p>
        </fieldset>
        <br />
        <asp:Button ID="btnGoBackAdmin" class="btns" runat="server" Text="Go back" OnClick="GoBack" />
        
        <asp:SqlDataSource ID="SqlDataSource2" runat="server"></asp:SqlDataSource>
    </form>
</body>
</html>
