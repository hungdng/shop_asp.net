<%@ Page Language="C#" AutoEventWireup="true" CodeFile="GioHang.aspx.cs" Inherits="GioHang" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="MA_HANG" HeaderText="Mã hàng" />
            <asp:BoundField DataField="TEN_HANG" HeaderText="Tên hàng" />
            <asp:ImageField DataImageUrlField="HINH_ANH" 
                DataImageUrlFormatString="./HinhAnh/HangHoa/{0}" HeaderText="Hình ảnh">
                <ControlStyle Width="100px" />
            </asp:ImageField>
            <asp:BoundField DataField="DON_GIA" HeaderText="Đơn giá" />
            <asp:BoundField DataField="SO_LUONG" HeaderText="Số lượng" />
            <asp:BoundField DataField="THANH_TIEN" HeaderText="Thành tiền" />
        </Columns>
    </asp:GridView>
    </form>
</body>
</html>
