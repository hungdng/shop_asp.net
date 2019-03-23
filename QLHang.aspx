<%@ Page Language="C#" AutoEventWireup="true" CodeFile="QLHang.aspx.cs" Inherits="QLHang" %>

<!DOCTYPE >

<head runat="server">
    <title></title>
</head>
<style>
    .clearBoth {
        clear: both;
    }
    .form-data{
        padding:.5em;
    }
</style>
<body>
    <form id="form2" runat="server">
        <div class="clearBoth">
    
        <h2>QUẢN LÝ HÀNG</h2>
            <div class="clearBoth form-data">
                <label>Mã hàng:</label>
                <asp:TextBox ID="txtMaHang" runat="server" Width="283px"></asp:TextBox>
            </div>

            <div class="clearBoth form-data">
                <label>Tên hàng:</label>
                <asp:TextBox ID="txtTenHang" runat="server" Width="283px"></asp:TextBox>
            </div>

            <div class="clearBoth form-data">
                <label>Loại hàng:</label>
                <asp:DropDownList ID="DropDownList1" runat="server">
                </asp:DropDownList>
            </div>

            <div class="clearBoth form-data">
                <label>Giá bán:</label>
                <asp:TextBox ID="txtGiaBan" runat="server" Width="283px"></asp:TextBox>
            </div>
            <div class="clearBoth  form-data">
                <label>Giá nhập:</label>
                <asp:TextBox ID="txtGiaNhap" runat="server" Width="283px"></asp:TextBox>
            </div>
            <div class="clearBoth form-data">
                <label>Thuộc tính:</label>
                <asp:TextBox ID="txtThuocTinh" runat="server" Width="283px"></asp:TextBox>
            </div>
            <div class="clearBoth form-data">
                <label>Hình ảnh:</label>
                 <asp:FileUpload ID="fudHinhAnh" runat="server" />
            </div>
        
        <asp:Button ID="btnLuuMoi" runat="server" Height="28px" Text="Lưu mới" Width="91px" OnClick="btnLuuMoi_Click" />
&nbsp;
        <asp:Button ID="btnThayDoi" runat="server" Height="28px" Text="Thay đổi" 
                Width="91px" onclick="btnThayDoi_Click" />
        <br />
        <br />
        <asp:Label ID="lblThongBao" runat="server"></asp:Label>
        <br />
        <asp:GridView ID="GridView1" runat="server" 
            AutoGenerateColumns="False"  BackColor="LightGoldenrodYellow" 
            BorderColor="Tan" BorderWidth="1px" CellPadding="2" 
            EnableModelValidation="True" GridLines="None"  
            ForeColor="Black" DataKeyNames="MA_HANG">
            <Columns>
                <asp:BoundField DataField="MA_HANG" HeaderText="Mã hàng" />
                <asp:BoundField DataField="TEN_HANG" HeaderText="Tên hàng" />
                <asp:BoundField DataField="GIA_BAN" HeaderText="Giá bán" />
                <asp:BoundField DataField="GIA_NHAP" HeaderText="Giá nhập" />
                <asp:BoundField DataField="THONG_SO" HeaderText="Thông số" />
                <asp:ImageField DataImageUrlField="HINH_ANH" DataImageUrlFormatString="./HinhAnh/HangHoa/{0}" HeaderText="Hình ảnh">
                    <ControlStyle Width="100px" />
                </asp:ImageField>
                <asp:TemplateField>
                    <ItemTemplate>
                    <asp:Button runat="server" Text="Xóa"  Width="80px" CommandName='<%#Eval("MA_HANG") %>' OnClick="Xoa_Click"/>
                    <asp:Button runat="server" Text="Chọn" Width="80px"  CommandName='<%#Eval("MA_HANG") %>' OnClick="Chon_Click"/>
                        </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    
    </div>
    </form>
</body>
