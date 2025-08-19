<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Hello!<br />
        <asp:GridView ID="griChuyenMuc" runat="server" BackColor="White" BorderColor="#999999"
            BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" ShowHeader="False">
            <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
            <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
            <AlternatingRowStyle BackColor="#DCDCDC" />
        </asp:GridView>
        <br />
        <asp:DataList ID="lstChuyenMuc" runat="server" BackColor="LightGoldenrodYellow" BorderColor="Tan"
            BorderWidth="1px" CellPadding="2" ForeColor="Black" RepeatDirection="Horizontal">
            <FooterStyle BackColor="Tan" />
            <AlternatingItemStyle BackColor="PaleGoldenrod" />
            <SelectedItemStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
            <HeaderStyle BackColor="Tan" Font-Bold="True" />
            <ItemTemplate>
                <asp:HyperLink ID="HyperLink1" runat="server" Text='<%# Bind("TenCM") %>'></asp:HyperLink>
            </ItemTemplate>
        </asp:DataList></div>
    </form>
</body>
</html>
