<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="upload_imagem._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Upload de Imagem</h1>
        <p class="lead"></p>
       


        <p>
              <asp:FileUpload ID="FileUpload1" runat="server" /><asp:Button ID="btnUpload" runat="server" Text="Upload" CssClass="btn btn-primary btn-lg" OnClick="btnUpload_Click" />
             
        </p>
    </div>


    <div class="jumbotron">

        <asp:Image ID="Image1" runat="server" />
     </div>



  
  






</asp:Content>
