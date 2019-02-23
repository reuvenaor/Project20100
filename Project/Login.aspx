<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Project.Login" %>

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
            <asp:Label ID="lblName" runat="server" AssociatedControlID="txtName" Text="Name:" />
            <br/>
            <asp:TextBox ID="txtName" class="txtBox" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblPass" runat="server" AssociatedControlID="txtPass" Text="Password:" /> 
            <br/>
            <asp:TextBox ID="txtPass" class="txtBox" runat="server"></asp:TextBox>
        </p>
        <asp:Button ID="BtnSubmit" Class="btns" runat="server" Text="OK" OnClick="Validation" />
       </fieldset>
    </form>
</body>
</html>
