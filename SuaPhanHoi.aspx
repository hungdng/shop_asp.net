<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="SuaPhanHoi.aspx.cs" Inherits="SuaPhanHoi" %>

<asp:Content ID="content5" runat="server" ContentPlaceHolderID="ContentMain">
    <div class="clearBoth">
        <h2>PHẢN HỔI Ý KIẾN</h2>
        <br />
        <p>
            <asp:Label ID="lblThongBao" runat="server"></asp:Label>
        </p>
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
        <asp:Button ID="btnLuu" runat="server" Height="28px" Text="Lưu phản hồi" Width="91px" OnClick="btnLuu_Click" />
        <asp:Button ID="btnCancel" runat="server" Height="28px" Text="Quay lại" Width="91px" OnClick="btnCancel_Click" />

    </div>
</asp:Content>
