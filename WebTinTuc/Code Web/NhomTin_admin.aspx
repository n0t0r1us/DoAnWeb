<%@ Page Language="C#" AutoEventWireup="true" CodeFile="NhomTin_admin.aspx.cs" Inherits="NhomTin_admin" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Quản lý danh mục Nhóm tin</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Chọn chuyên mục:
        <asp:DropDownList ID="droChuyenMuc" runat="server" AutoPostBack="True" DataTextField="TenCM"
            DataValueField="MaCM" OnSelectedIndexChanged="droChuyenMuc_SelectedIndexChanged">
        </asp:DropDownList><br />
        <asp:GridView ID="griNhomTin" runat="server" AutoGenerateColumns="False" BorderColor="Red"
            BorderStyle="Groove" BorderWidth="1px" CellPadding="4" DataKeyNames="MaNT" ForeColor="#333333"
            OnSelectedIndexChanged="griNhomTin_SelectedIndexChanged" Width="100%">
            <RowStyle BackColor="#EFF3FB" />
            <Columns>
                <asp:CommandField HeaderText="Cập nhật" SelectText="Chọn" ShowSelectButton="True">
                    <HeaderStyle Width="1%" Wrap="False" />
                    <ItemStyle HorizontalAlign="Center" />
                </asp:CommandField>
                <asp:BoundField DataField="MaNT" HeaderText="M&#227; số">
                    <HeaderStyle Width="1%" Wrap="False" />
                    <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="TenNT" HeaderText="T&#234;n nh&#243;m tin">
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
    
    </div>
    </form>
</body>
</html>
