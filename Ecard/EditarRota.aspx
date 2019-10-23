<%@ Page Title="" Language="C#" MasterPageFile="~/Administrador.Master" AutoEventWireup="true" CodeBehind="EditarRota.aspx.cs" Inherits="Ecard.EditarRota" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="StyleEditarRota.css"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="box1">
                <div class="box1-header">
                    <div class="box1-title">
                      <a class="ai" href="CadastroRota.aspx"><i class="fas fa-arrow-left"></i></a>
                       <p>Rotas</p>
                    </div>
                </div>
                <div class="box1-midi">
                      <h1>Editar</h1>
                      <asp:TextBox ID="TextBox1" runat="server" CssClass="box1-mid" placeholder="Nome"></asp:TextBox>
                    <div class="btn-b2">
                        <asp:Button class="btn-close" runat="server" Text="Excluir" OnClick="Unnamed1_Click" OnClientClick="javascript:return ConfirmaExclusao();"  />
                        <asp:Button class="btn-save" runat="server" Text="Atualizar" OnClick="Unnamed2_Click" />
                    </div>                     
                </div>
      </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
</asp:Content>
