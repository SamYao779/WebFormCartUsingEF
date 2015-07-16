<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ShoppingCart.aspx.cs" Inherits="DemoWebFormEntity.ShoppingCartaspx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div id="ShoppingcartTitle" runat="server" class="ContentHead"><h1>Shoppingcart</h1></div>
    <asp:GridView ID="CartList" runat="server" ItemType="DemoWebFormEntity.Models.CartItem" AutoGenerateColumns="False" SelectMethod="GetCart" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4" CssClass="table table-striped table-bordered">
        <Columns>
            <asp:BoundField DataField="ProductId" HeaderText="Id" SortExpression="ProductId" />
            <asp:BoundField HeaderText="Name" DataField="Product.Name"/>
            <asp:BoundField HeaderText="UnitPrice" DataField="Product.UnitPrice" DataFormatString="{0:c}"/>
            <asp:TemplateField HeaderText="Quantity">
                <ItemTemplate>
                    <asp:TextBox ID="txtQuantity" CssClass="form-control" runat="server" Width="40" Text="<%#:Item.Quantity %>"></asp:TextBox>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Total">
                <ItemTemplate>
                    <%#: string.Format("{0:c}", Item.Quantity * Item.Product.UnitPrice) %>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Remove">
                <ItemTemplate>
                    <asp:CheckBox ID="chkRemove" runat="server" />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
        <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
        <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
        <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
        <RowStyle BackColor="White" ForeColor="#003399" />
        <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
        <SortedAscendingCellStyle BackColor="#EDF6F6" />
        <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
        <SortedDescendingCellStyle BackColor="#D6DFDF" />
        <SortedDescendingHeaderStyle BackColor="#002876" />
    </asp:GridView>
    <div>
        <strong>
            <asp:Label ID="lblTotalText" runat="server" Text="Total"></asp:Label>
            <asp:Label ID="lblTotal" runat="server" EnableViewState="false"></asp:Label>
        </strong>
    </div><br />
    <table>
        <tr>
            <td>
                <asp:Button ID="btnUpdate" runat="server" Text="Update" CssClass="btn btn-Default" />
            </td>
        </tr>
    </table>
</asp:Content>
