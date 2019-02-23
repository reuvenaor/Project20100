<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Welcome.aspx.cs" Inherits="Project.Welcome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="style.css"/>
</head>
<body>
    <form id="form1" runat="server">
        <fieldset>  
                <asp:Button ID="btnShowWithdraw" class="btns" runat="server" Text="Withdraw" OnClick="Withdraw" />
                <asp:Panel ID="pnlWithraw" runat="server" Visible="false">
                    <fieldset>
                        <p>
                        <asp:Label ID="lblWithdraw" runat="server" AssociatedControlID="txtWithdraw" Text="Amount:" />
                        <br/>
                        <asp:TextBox ID="txtWithdraw" class="txtBox" runat="server"></asp:TextBox>
                        </p>
                        <asp:Button ID="btnConfirmWithdraw" class="btns" runat="server" Text="Confirm" OnClick="ConfirmWithdraw" />
                        <br/>
                        <asp:Label ID="lblWithdrawSum" runat="server" />
                    </fieldset>
                </asp:Panel>
                <asp:Button ID="btnShowDeposit" class="btns" runat="server" Text="Deposit" OnClick="Deposit" /> 
                <asp:Panel ID="pnlDeposit" runat="server" Visible="false">
                    <fieldset>
                        <p>
                        <asp:Label ID="lblDeposit" runat="server" AssociatedControlID="txtDeposit" Text="Amount:" />
                        <br/>
                        <asp:TextBox ID="txtDeposit" class="txtBox" runat="server"></asp:TextBox>
                        </p>
                        <asp:Button ID="btnConfirmDeposit" class="btns" runat="server" Text="Confirm" OnClick="ConfirmDeposit" />
                        <br/>
                        <asp:Label ID="lblDepositSum" runat="server" />
                    </fieldset>
                </asp:Panel>
        </fieldset>
        <p>
            <asp:Button ID="btn3" class="btns" runat="server" Text="Go back" OnClick="GoBack" />
        </p>
    </form>
</body>
</html>
