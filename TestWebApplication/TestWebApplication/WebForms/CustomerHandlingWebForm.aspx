<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerHandlingWebForm.aspx.cs" Inherits="TestWebApplication.CustomerWebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Наименование организации"></asp:Label>
&nbsp;<asp:TextBox ID="TextBoxCustomerName" runat="server" MaxLength="100" Width="163px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="ИНН организации"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBoxINN" runat="server" MaxLength="12" Width="161px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Адрес организации"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBoxAddress" runat="server" MaxLength="255" Width="159px"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Button ID="ButtonCreateEditCustomer" runat="server" OnClick="ButtonCreateEditCustomer_Click" Text="Создать" />
&nbsp;&nbsp;<asp:Button ID="ButtonDeleteCustomer" runat="server" OnClick="ButtonDeleteCustomer_Click" Text="Удалить" Visible="False" />
&nbsp;
            <asp:Button ID="ButtonCancelCustomer" runat="server" OnClick="ButtonCancelCustomer_Click" Text="Отменить" />
        </div>
    </form>
</body>
</html>
