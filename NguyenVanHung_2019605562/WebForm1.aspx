<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="NguyenVanHung_2019605562.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 584px;
        }

        .auto-style2 {
            width: 342px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width: 100%;">
                <tr>
                    <td class="auto-style2">Mã Sản phẩm</td>
                    <td class="auto-style1">
                        <asp:TextBox ID="txtMaSP" runat="server" Width="237px"></asp:TextBox></td>
                    <td>
                        <asp:Button ID="btnAdd" runat="server" Text="Thêm" OnClick="btnAdd_Click" /></td>
                </tr>
                <tr>
                    <td class="auto-style2">Tên sản phẩm</td>
                    <td class="auto-style1">
                        <asp:TextBox ID="txtTenSP" runat="server"></asp:TextBox></td>
                    <td>
                        <asp:Button ID="btnSua" runat="server" Text="Sửa" OnClick="btnSua_Click" /></td>
                </tr>
                <tr>
                    <td class="auto-style2">Loại sản phẩm</td>
                    <td class="auto-style1">
                        <asp:DropDownList ID="comboLoai" runat="server"></asp:DropDownList></td>
                    <td>
                        <asp:Button ID="btnXoa" runat="server" Text="Xóa" OnClick="btnXoa_Click" /></td>
                </tr>
                <tr>
                    <td class="auto-style2">Đơn giá</td>
                    <td class="auto-style1">
                        <asp:TextBox ID="txtDonGia" runat="server"></asp:TextBox>   
                    </td>
                    <td>
                        <asp:Button ID="btnTim" runat="server" Text="Tìm" OnClick="btnTim_Click" /></td>
                </tr>
            </table>
        </div>
        
        <asp:GridView ID="dgvSanPham" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" Width="1307px" OnSelectedIndexChanged="dgvSanPham_SelectedIndexChanged">
            <Columns>
                <asp:BoundField DataField="MaSP" HeaderText="Mã Sản Phẩm" />
                <asp:BoundField DataField="TenSP" HeaderText="Tên Sản Phẩm" />
                <asp:BoundField DataField="MaLoai" HeaderText="Mã Loại" />
                <asp:BoundField DataField="Dongia" HeaderText="Đơn Giá" />
                <asp:CommandField SelectText="Chọn dòng" ShowSelectButton="True" />
            </Columns>
            <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
            <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
            <RowStyle BackColor="White" ForeColor="#330099" />
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
            <SortedAscendingCellStyle BackColor="#FEFCEB" />
            <SortedAscendingHeaderStyle BackColor="#AF0101" />
            <SortedDescendingCellStyle BackColor="#F6F0C0" />
            <SortedDescendingHeaderStyle BackColor="#7E0000" />
        </asp:GridView>
        
    </form>
</body>
</html>
