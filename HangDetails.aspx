<%@ Page Language="C#" AutoEventWireup="true" CodeFile="HangDetails.aspx.cs" Inherits="HangDetails" %>

<!DOCTYPE >

<head runat="server">
    <title></title>
</head>
<style>
    .clearBoth {
        clear: both;
    }
</style>
<body>
    <form id="form1" runat="server">
        <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" CellPadding="4" EnableModelValidation="True" ForeColor="#333333" GridLines="Both">
            <CommandRowStyle BackColor="#E2DED6" Font-Bold="True" />
            <EditRowStyle BackColor="#999999" />
            <FieldHeaderStyle BackColor="#E9ECF1" Font-Bold="True" />
            <Fields>
                <asp:BoundField DataField="TEN_HANG" HeaderText="Tên hàng" />
                <asp:ImageField DataImageUrlField="HINH_ANH" DataImageUrlFormatString="./HinhAnh/HangHoa/{0}" HeaderText="Hình ảnh">
                </asp:ImageField>
                <asp:BoundField DataField="GIA_BAN" HeaderText="Giá bán" />
                <asp:BoundField DataField="THONG_SO" HeaderText="Thông Số" />
            </Fields>
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />

        </asp:DetailsView>

        <div class="clearBoth">

            <asp:Panel runat="server" ID="pnlPhanHoi">
                <h2>PHẢN HỔI Ý KIẾN</h2>
                <br />
                Tiêu đề:&nbsp;&nbsp;
                    <asp:TextBox ID="txtTieuDe" runat="server" Width="272px"></asp:TextBox>
                <br />
                <br />
                Họ tên:&nbsp;
                    <asp:TextBox ID="txtTen" runat="server" Width="283px"></asp:TextBox>
                <br />
                <br />
                Liên hệ:&nbsp;
                    <asp:TextBox ID="txtLienHe" runat="server" Width="283px"></asp:TextBox>
                <br />
                <br />
                Nội dung:&nbsp;
                    <asp:TextBox ID="txtNoiDung" runat="server" Width="394px" Height="186px" TextMode="MultiLine"></asp:TextBox>
                <br />
                <br />
                    <asp:Button ID="btnLuuMoi" runat="server" Height="28px" OnClick="btnLuuMoi_Click" Text="Gửi phản hồi" Width="91px" />
            </asp:Panel>

            <asp:Panel runat="server" ID="pnlThongBao">
             <p>
                <asp:Label ID="lblThongBao" runat="server"></asp:Label>
            </p>
            </asp:Panel>
        </div>
    </form>
</body>
