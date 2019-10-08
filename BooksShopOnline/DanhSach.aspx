0<%@ Page Title="MR MỠ" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DanhSach.aspx.cs" Inherits="BooksShopOnline.DanhSach" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
            <section>
         <div class="tranghchu">
         <hgroup>
         
             <h2></h2>         
         </hgroup>
         <asp:ListView ID="bookList" runat="server" DataKeyNames="BookID"
        GroupItemCount="4"
         ItemType="BooksShopOnline.Models.Sport" SelectMethod="GetBooks">
         <EmptyDataTemplate>
         <table >
         <tr>
         <td>Xin chào quý khách.</td>
         </tr>
         </table>
         </EmptyDataTemplate>
         <EmptyItemTemplate>
         <td/>
         </EmptyItemTemplate>
         <GroupTemplate>
         <tr id="itemPlaceholderContainer" runat="server">
         <td id="itemPlaceholder" runat="server"></td>
         </tr>
         </GroupTemplate>
         <ItemTemplate>
         <td runat="server">
         <table>
         <tr>
         <td>
         <a href="ThongTin.aspx?bookID=<%#:Item.BookID%>">
         <img src ="/Images/<%#:Item.ImagePath%>"  width="280" height="350" style="border:solid" /></a>
         </td>
         </tr>
         <tr>
         <td>
         <a href="ThongTin.aspx?bookID=<%#:Item.BookID%>">
         <span>
         <%#:Item.BookName%>
         </span>
         </a>
         <br />
         <span>
         <b>Giá: </b><%#:String.Format("{0:c}",Item.UnitPrice)%>
         </span>
         <br />
         <br />
            <a href="AddToCart.aspx?bookID=<%#:Item.BookID%>">
            <span>
            <b>Thêm giỏ hàng<b>
            </span>
            </a>
         </td>
         </tr>
         <tr>
         <td>&nbsp;</td>
         </tr>
         </table>
         </p>
         </td>
         </ItemTemplate>
         <LayoutTemplate>
         <table style="width:100%;">
         <tbody>
         <tr>
         <td>
         <table id="groupPlaceholderContainer" runat="server"
        style="width:100%">
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
