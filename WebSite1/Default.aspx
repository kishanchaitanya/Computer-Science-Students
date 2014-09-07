<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" 
            onselectedindexchanged="DropDownList1_SelectedIndexChanged">
            <asp:ListItem Value="null">Select Item</asp:ListItem>
            <asp:ListItem>ME</asp:ListItem>
            <asp:ListItem>MCA</asp:ListItem>
            <asp:ListItem>EIE</asp:ListItem>
        </asp:DropDownList>
        <br />
        <asp:Panel ID="Panel3" runat="server">
            <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                <asp:ListItem>India</asp:ListItem>
                <asp:ListItem>Australia</asp:ListItem>
                <asp:ListItem>Iceland</asp:ListItem>
            </asp:RadioButtonList>
        </asp:Panel>
        <asp:Panel ID="Panel1" runat="server">
            <asp:RadioButtonList ID="RadioButtonList2" runat="server">
                <asp:ListItem>India2</asp:ListItem>
                <asp:ListItem>Australia2</asp:ListItem>
                <asp:ListItem>Iceland2</asp:ListItem>
            </asp:RadioButtonList>
        </asp:Panel>
        <asp:Panel ID="Panel2" runat="server">
            <asp:RadioButtonList ID="RadioButtonList3" runat="server">
                <asp:ListItem>India3</asp:ListItem>
                <asp:ListItem>Australia3</asp:ListItem>
                <asp:ListItem>Iceland3</asp:ListItem>
            </asp:RadioButtonList>
        </asp:Panel>
        <br>
        <asp:Button ID="Button1" runat="server" Text="Button" onclick="Button1_Click" />
    
    </div>
    </form>
</body>
</html>
