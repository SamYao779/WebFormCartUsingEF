<%@ Page Title="Products" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductList.aspx.cs" Inherits="DemoWebFormEntity.ProductList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <section>
        <div>
            <hgroup>
                <h2><%: Page.Title %></h2>
            </hgroup>
            <asp:ListView ID="productList" runat="server" DataKeyNames="Id" GroupItemCount="4"
                ItemType="DemoWebFormEntity.Models.Product" SelectMethod="GetProduct">
                <EmptyDataTemplate>
                    <table>
                        <tr>
                            <td>No data to Returned</td>
                        </tr>
                    </table>
                </EmptyDataTemplate>
                <GroupTemplate>
                    <tr id="itemPlaceholderContent" runat="server">
                        <td id="itemPlaceholder" runat="server"></td>
                    </tr>
                </GroupTemplate>
                <ItemTemplate>
                    <td runat="server">
                        <table>
                            <tr>
                                <td style="text-align: center">
                                    <a href="ProductDetail.aspx?ProductId=<%#:Item.Id%>"><%#:Item.Name %>
                                    </a>
                                    <br />
                                    <a href="ProductDetail.aspx?ProductId=<%#:Item.Id %>">
                                        <img src="Images/Catalog/Images/busred.png" width="100" height="75" style="border: solid" />
                                    </a>
                                    <br />
                                    <span>
                                        <b>Price : </b><%#:string.Format("{0:c}", Item.UnitPrice) %>
                                    </span>
                                    <br />
                                    <a href="/AddToCart.aspx?ProductId=<%#:Item.Id %>"><span class="ProductListItem">Add To Cart</span></a>
                                </td>
                            </tr>
                        </table>
                    </td>
                </ItemTemplate>
                <LayoutTemplate>
                    <table style="width: 100%">
                        <tbody>
                            <tr>
                                <td>
                                    <table id="groupPlaeholderContainer" runat="server" style="width: 100%">
                                        <tr id="groupPlaceholder"></tr>
                                    </table>
                                </td>
                            </tr>
                            <tr>
                                <td></td>
                            </tr>
                            <tr></tr>
                        </tbody>
                    </table>
                </LayoutTemplate>
            </asp:ListView>
        </div>
    </section>
</asp:Content>
