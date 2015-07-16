<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductDetail.aspx.cs" Inherits="DemoWebFormEntity.ProductDetail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:FormView ID="productDetail" runat="server" ItemType="DemoWebFormEntity.Models.Product" SelectMethod="Detail" RenderOuterTable="false">
        <ItemTemplate>
            <div>
                <h1><b><%#:Item.Name %></b></h1>
            </div><br />
            <table>
                <tr>
                    <td>
                        <img src="Images/Catalog/Images/busgreen.png" style="border:solid; height:200px" alt="<%#:Item.Name %>"/>
                    </td>
                    <td>&nbsp;</td>
                    <td style="vertical-align:top; text-align:left">
                        <b>Product Number : </b><%#:Item.Id %><br />
                        <b>Product Name : </b> <%#:Item.Name %><br />
                        <b>Unit Price : </b><%#:string.Format("{0:c}", Item.UnitPrice) %><br />
                        <b>Category: </b><%#:Item.Category.Name %>
                    </td>
                </tr>
            </table>
        </ItemTemplate>
    </asp:FormView>
</asp:Content>
