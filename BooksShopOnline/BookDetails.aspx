<%@ Page Title="Thông Tin" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="BookDetails.aspx.cs" Inherits="BooksShopOnline.BookDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
            <asp:FormView ID="bookDetail" runat="server"
        ItemType="BooksShopOnline.Models.Book" SelectMethod ="GetDetails"
         RenderOuterTable="false">
         <ItemTemplate>
         <div>
         <h1>Thông Tin</h1>
         </div>
         <br />
         <table>
         <tr>
         <td>
         <img src="/Images/<%#:Item.ImagePath %>"
         style="border:solid; height:200px" alt="<%#:Item.BookName %>"/>
         </td>
         <td>&nbsp;</td>
         <td style="vertical-align: top; text-align:left;">
         <b>Thông Tin:</b><br /><%#:Item.Description %>
         <br />
         <span><b>Giá Bán:</b>&nbsp;<%#: String.Format("{0:c}",Item.UnitPrice)
        %></span>
         <br />
         <span><b>Mã Số:</b>&nbsp;<%#:Item.BookID %></span>
         <br />
         </td>
         </tr>
         </table>
         </ItemTemplate>
         </asp:FormView>
</asp:Content>
