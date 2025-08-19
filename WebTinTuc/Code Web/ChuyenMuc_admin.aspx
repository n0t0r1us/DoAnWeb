<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ChuyenMuc_admin.aspx.cs" Inherits="ChuyenMuc_admin" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Quản lý Chuyên mục tin</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="griChuyenMuc" runat="server" AutoGenerateColumns="False" BorderColor="Red" BorderStyle="Groove" BorderWidth="1px" CellPadding="4" ForeColor="#333333" Width="100%" DataKeyNames="MaCM" OnSelectedIndexChanged="griChuyenMuc_SelectedIndexChanged">
            <RowStyle BackColor="#EFF3FB" />
            <Columns>
                <asp:CommandField HeaderText="Cập nhật" SelectText="Chọn" ShowSelectButton="True">
                    <HeaderStyle Width="1%" Wrap="False" />
                    <ItemStyle HorizontalAlign="Center" />
                </asp:CommandField>
                <asp:BoundField DataField="MaCM" HeaderText="M&#227; số">
                    <HeaderStyle Width="1%" Wrap="False" />
                    <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="TenCM" HeaderText="T&#234;n chuy&#234;n mục">
                    <HeaderStyle HorizontalAlign="Left" />
                </asp:BoundField>
            </Columns>
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <EditRowStyle BackColor="#2461BF" />
            <AlternatingRowStyle BackColor="White" />
        </asp:GridView>
        <asp:LinkButton ID="lbtnThemMoi" runat="server" Font-Bold="True" Font-Underline="False"
            OnClick="lbtnThemMoi_Click">Thêm mới</asp:LinkButton><br />
        <asp:Panel ID="pnlCapNhat" runat="server" BorderColor="#FF8000" BorderStyle="Dotted"
            BorderWidth="1px" Visible="False" Width="100%">
            <table width="100%">
                <tr>
                    <td colspan="2">
                        CẬP NHẬT</td>
                </tr>
                <tr>
                    <td style="width: 125px; text-align: right">
                        Mã chuyên mục:</td>
                    <td>
                        <asp:TextBox ID="txtMaCM" runat="server" ReadOnly="True" Width="37px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="width: 125px; text-align: right">
                        Tên chuyên mục:</td>
                    <td>
                        <asp:TextBox ID="txtTenCM" runat="server" Width="284px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="width: 125px; text-align: right">
                    </td>
                    <td>
                        <asp:Button ID="btnThem" runat="server" OnClick="btnThem_Click" Text="Thêm" Width="70px" />
                        <asp:Button ID="btnSua" runat="server" OnClick="btnSua_Click" Text="Sửa" Visible="False"
                            Width="70px" />
                        <asp:Button ID="btnXoa" runat="server" OnClick="btnXoa_Click" Text="Xóa" Visible="False"
                            Width="70px" />
                        <asp:Button ID="btnBoQua" runat="server" OnClick="btnBoQua_Click" Text="Bỏ qua" Width="70px" /></td>
                </tr>
            </table>
        </asp:Panel>
    
    </div>
    </form>
</body>
</html>
