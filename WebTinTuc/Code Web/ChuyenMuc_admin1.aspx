<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ChuyenMuc_admin1.aspx.cs" Inherits="ChuyenMuc_admin1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 200px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:GridView ID="griChuyenMuc" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" DataKeyNames="MaCM" OnSelectedIndexChanged="btnThemMoi_Click" Width="100%">
            <AlternatingRowStyle BackColor="#F7F7F7" />
            <Columns>
                <asp:CommandField HeaderText="Cập Nhật" SelectText="Chọn" ShowSelectButton="True">
                <HeaderStyle Width="1%" Wrap="False" />
                <ItemStyle HorizontalAlign="Center" />
                </asp:CommandField>
                <asp:BoundField DataField="MaCM" HeaderText="Mã Số">
                <HeaderStyle Width="1%" Wrap="False" />
                <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="TenCM" HeaderText="Tên Chuyên Mục">
                <HeaderStyle HorizontalAlign="Left" />
                </asp:BoundField>
            </Columns>
            <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
            <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
            <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
            <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
            <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
            <SortedAscendingCellStyle BackColor="#F4F4FD" />
            <SortedAscendingHeaderStyle BackColor="#5A4C9D" />
            <SortedDescendingCellStyle BackColor="#D8D8F0" />
            <SortedDescendingHeaderStyle BackColor="#3E3277" />
        </asp:GridView>
        <asp:LinkButton ID="btnThemMoi" runat="server" Font-Bold="True" Font-Italic="False" Font-Underline="True" OnClick="btnThemMoi_Click">Thêm Mới</asp:LinkButton>
        <asp:Panel ID="pnlCapNhat" runat="server" BorderColor="#CC00FF" BorderStyle="Solid" Visible="False">
            CẬP NHẬT<br />
            <table style="width:100%;">
                <tr>
                    <td class="auto-style1">Mã Số</td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server" Width="106px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Tên Chuyên Mục</td>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server" Width="542px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td>
                        <asp:Button ID="btnThem" runat="server" OnClick="Button1_Click" Text="Thêm" />
                        <asp:Button ID="btnSua" runat="server" Text="Sửa" />
                        <asp:Button ID="btnXoa" runat="server" Text="Xóa" />
                        <asp:Button ID="btnBoQua" runat="server" OnClick="btnBoQua_Click" Text="Bỏ Qua" />
                    </td>
                </tr>
            </table>
            <br />
        </asp:Panel>
    </form>
</body>
</html>
