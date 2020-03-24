<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DirectoryWebForm.aspx.cs" Inherits="TestWebApplication.DirectoryWebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="ButtonCustomerHandling" runat="server" Height="29px" OnClick="ButtonCustomerHandling_Click" Text="Добавить, изменить или удалить организацию" Width="297px" />
        </div>
        <br />
        <br />
        <asp:DropDownList ID="DropDownListCustomer" runat="server" Height="20px" Width="207px">
        </asp:DropDownList>
        <br />
        <br />
        <asp:Button ID="ButtonGetCounts" runat="server" OnClick="ButtonGetCounts_Click" Text="Получить счета" />
        <br />
        <br />
        <br />
        <br />
    </form>
</body>
</html>
