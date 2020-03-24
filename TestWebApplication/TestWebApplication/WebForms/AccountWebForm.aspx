<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AccountWebForm.aspx.cs" Inherits="TestWebApplication.AccontWebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Счёт"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server" MaxLength="100" Width="163px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Название счета"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox2" runat="server" MaxLength="100" Width="163px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="БИК банка"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox3" runat="server" MaxLength="100" Width="163px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="Остаток на счете"></asp:Label>
&nbsp;
            <asp:TextBox ID="TextBox4" runat="server" MaxLength="100" Width="163px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Создать" Width="72px" />
&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" Text="Отменить" />
        </div>
    </form>
</body>
</html>
