<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TacGia_admin.aspx.cs" Inherits="TacGia_admin" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Quản lý Tác giả</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="griTacGia" runat="server" AutoGenerateColumns="False" CellPadding="4"
            DataKeyNames="MaTG" ForeColor="#333333" Width="100%" OnSelectedIndexChanged="griTacGia_SelectedIndexChanged">
            <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
            <Columns>
                <asp:CommandField HeaderText="Cập nhật" SelectText="Chọn" ShowSelectButton="True">
                    <HeaderStyle Width="1%" Wrap="False" />
                    <ItemStyle HorizontalAlign="Center" />
                </asp:CommandField>
                <asp:BoundField DataField="MaTG" HeaderText="M&#227; số">
                    <HeaderStyle Width="1%" Wrap="False" />
                    <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="HoTenTG" HeaderText="Họ v&#224; t&#234;n">
                    <HeaderStyle Width="1%" Wrap="False" />
                    <ItemStyle Wrap="False" />
                </asp:BoundField>
                <asp:BoundField DataField="ButDanh" HeaderText="B&#250;t danh">
                    <HeaderStyle HorizontalAlign="Left" Width="1%" Wrap="False" />
                    <ItemStyle Wrap="False" />
                </asp:BoundField>
                <asp:TemplateField HeaderText="..."></asp:TemplateField>
            </Columns>
            <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <AlternatingRowStyle BackColor="White" />
        </asp:GridView>
    
    </div>
        <asp:LinkButton ID="lbtnThemMoi" runat="server" Font-Bold="True" Font-Underline="False" OnClick="lbtnThemMoi_Click">Thêm mới</asp:LinkButton>
        <br />
        <asp:Panel ID="pnlCapNhat" runat="server" BorderColor="#FF8000" BorderStyle="Dotted"
            BorderWidth="1px" Visible="False" Width="100%">
            <table width="100%">
                <tr>
                    <td colspan="2">
                        CẬP NHẬT</td>
                </tr>
                <tr>
                    <td style="width: 125px; text-align: right">
                        Mã số tác giả:</td>
                    <td>
                        <asp:TextBox ID="txtMaTG" runat="server" ReadOnly="True" Width="37px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="width: 125px; text-align: right">
                        Họ và tên đệm (*):</td>
                    <td>
                        <asp:TextBox ID="txtHoTG" runat="server" Width="284px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="width: 125px; text-align: right">
                        Tên tác giả (*):</td>
                    <td>
                        <asp:TextBox ID="txtTenTG" runat="server" Width="67px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="width: 125px; text-align: right">
                        Bút danh:</td>
                    <td>
                        <asp:TextBox ID="txtButDanh" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="width: 125px; text-align: right">
                    </td>
                    <td>
                        <asp:Button ID="btnThem" runat="server" Text="Thêm" Width="70px" OnClick="btnThem_Click" />
                        <asp:Button ID="btnSua" runat="server" Text="Sửa" Width="70px" OnClick="btnSua_Click" Visible="False" />
                        <asp:Button ID="btnXoa" runat="server" Text="Xóa" Width="70px" OnClick="btnXoa_Click" Visible="False" />
                        <asp:Button ID="btnBoQua" runat="server" OnClick="btnBoQua_Click" Text="Bỏ qua" Width="70px" /></td>
                </tr>
            </table>
        </asp:Panel>
        <br />
        <br />
        <br />
    </form>
</body>
</html>
