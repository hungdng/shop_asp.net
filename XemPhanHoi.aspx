<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="XemPhanHoi.aspx.cs" Inherits="XemPhanHoi" %>

<asp:Content ID="content4" runat="server" ContentPlaceHolderID="ContentMain">
    <div class="clearBoth">
        <h2>Phản hồi</h2>
       <asp:GridView ID="GridView1" 
           runat="server" 
           GridLines="Both" 
           CellPadding="9" 
           AutoGenerateColumns="false"
           BackColor="WhiteSmoke">
           <HeaderStyle BackColor="Tan" Font-Bold="True" />
           <Columns>
                <asp:BoundField DataField="TIEU_DE" 
                                HeaderText="Tiêu đề" />
                <asp:BoundField DataField="HO_TEN" 
                                HeaderText="Họ tên" />
                <asp:BoundField DataField="LIEN_HE" 
                                HeaderText="Liên hệ" />
                <asp:BoundField DataField="NOI_DUNG" 
                                HeaderText="Nội dung" />
               <asp:TemplateField>
                    <ItemTemplate>
                        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl='<%# "./SuaPhanHoi.aspx?id="+ Eval("ID") %>'>Edit</asp:HyperLink>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    
    </div>
</asp:Content>