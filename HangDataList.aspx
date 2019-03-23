<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="HangDataList.aspx.cs" Inherits="HangDataList" %>

<asp:Content ID="content2" runat="server" ContentPlaceHolderID="ContentMain">
    <div>
    
        <a href="../GioHang.aspx">Xem hàng trong giỏ</a><br />
    
        <br />
        <asp:DataList ID="DataList1" runat="server" CellPadding="5" CellSpacing="5" RepeatColumns="3">
            <ItemTemplate>
                <table style="width:150px" border="1">
                    <tr>
                        <td>
                            <asp:Label ID="Label1" runat="server" Text='<%# Eval("TEN_HANG") %>'></asp:Label>
                            <asp:Image ID="Image1" runat="server" Height="140px" ImageUrl='<%# "./HinhAnh/HangHoa/" +Eval("HINH_ANH") %>' Width="216px" />
                        </td>
                    </tr>
                    <tr>
                        <td>Giá bán: <%# Eval("GIA_BAN") %></td>
                    </tr>
                    <tr>
                        <td>Thông số: <%# Eval("THONG_SO") %></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Button ID="Button1" runat="server" Text="Mua Hàng" OnClick="Mua_Click" CommandArgument='<%#Eval("MA_HANG")%>' />
                            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# "./HangDetails.aspx?id="+ Eval("MA_HANG") %>'>Xem chi tiết</asp:HyperLink>
                        </td>
                    </tr>
                </table>
            </ItemTemplate>
        </asp:DataList>
        <br />
    
    </div>
</asp:Content>
