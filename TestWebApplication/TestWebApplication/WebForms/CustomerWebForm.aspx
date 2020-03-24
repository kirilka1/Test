<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerWebForm.aspx.cs" Inherits="TestWebApplication.WebForms.CustomerWebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <asp:Label ID="Label1" runat="server" Text="Для исправления или удаления организации кликните по ней в списке:"></asp:Label>
        <br />
        <asp:ListBox ID="ListBoxCustomer" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ListBoxCustomer_SelectedIndexChanged" Width="182px"></asp:ListBox>
        <br />
        <br />
        <asp:Button ID="ButtonAddCustomer" runat="server" OnClick="ButtonAddCustomer_Click" Text="Добавить организацию" />
            &nbsp;&nbsp;&nbsp;
            <asp:Button ID="ButtonCustomerCancel" runat="server" OnClick="ButtonCustomerCancel_Click" Text="Отменить" />
            <br />
        </div>
    </form>
</body>
</html>
