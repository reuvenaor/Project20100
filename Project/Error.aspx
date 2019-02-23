<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Error.aspx.cs" Inherits="Project.Error" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="style.css"/>
</head>
<body>
    <form id="form1" runat="server">
        <fieldset>  
            <asp:Label ID="lblError" runat="server" Text="Acount not exists" />
            <br/>
            <asp:Image ID="Image1" runat="server" ImageUrl="~/G2632.jpg" />
        </fieldset>
        <p>
            <asp:Button ID="GoBackError" class="btns" runat="server" Text="Go back" OnClick="GoBack" />
        </p>
    </form>
</body>
</html>
