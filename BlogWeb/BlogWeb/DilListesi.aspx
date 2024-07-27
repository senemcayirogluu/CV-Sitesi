<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeBehind="DilListesi.aspx.cs" Inherits="BlogWeb.DilListesi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
<form id="Form1" runat="server">
 <table class="table table-bordered">
     <tr>
         <th>ID</th>
         <th>DİL</th>
         <th>İŞLEMLER</th>
     </tr>
     <tbody>
         <asp:Repeater ID="Repeater1" runat="server">
             <ItemTemplate>
                 <tr>
                     <th><%# Eval("ID") %></th>
                     <td><%# Eval("DIL") %></td>
                     <td>
                         <asp:HyperLink NavigateUrl='<%# "DilSil.Aspx?ID=" + Eval("ID") %>' ID="HyperLink1" runat="server" CssClass="btn btn-danger">Sil</asp:HyperLink>
                         <asp:HyperLink NavigateUrl='<%# "DilGuncelle.Aspx?ID=" + Eval("ID") %>' ID="HyperLink2" runat="server" CssClass="btn btn-warning">Güncelle</asp:HyperLink>
                     </td>
                 </tr>
             </ItemTemplate>
         </asp:Repeater>
     </tbody>
 </table>
     <asp:HyperLink NavigateUrl="~/DilEkle.aspx" ID ="HyperLink3" runat="server" CssClass="btn btn-info">Yeni Dil Ekle</asp:HyperLink>
</form>
</asp:Content>
