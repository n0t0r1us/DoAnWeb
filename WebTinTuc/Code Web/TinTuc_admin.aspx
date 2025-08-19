<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TinTuc_admin.aspx.cs" Inherits="TinTuc_admin" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Quản lý đăng tin</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="griTinTuc" runat="server" AutoGenerateColumns="False" CellPadding="4"
            DataKeyNames="MaTT" ForeColor="#333333" Width="100%">
            <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
            <Columns>
                <asp:CommandField HeaderText="Cập nhật" SelectText="Chọn" ShowSelectButton="True">
                    <HeaderStyle Width="1%" Wrap="False" />
                    <ItemStyle HorizontalAlign="Center" />
                </asp:CommandField>
                <asp:BoundField DataField="TieuDe" HeaderText="Ti&#234;u đề">
                    <HeaderStyle HorizontalAlign="Left" />
                </asp:BoundField>
            </Columns>
            <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <AlternatingRowStyle BackColor="White" />
        </asp:GridView>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
    
    </div>
    </form>
</body>
</html>
