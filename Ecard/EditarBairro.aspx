<%@ Page Title="" Language="C#" MasterPageFile="~/Administrador.Master" AutoEventWireup="true" CodeBehind="EditarBairro.aspx.cs" Inherits="Ecard.EditarBairro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="StyleEditarPonto.css"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="box1">
                <div class="box1-header">
                    <div class="box1-title">
                       <a class="ai" href="CadastroBairro.aspx"><i class="fas fa-arrow-left"></i></a>
                       <p>Bairro</p>
                    </div>
                </div>
                <div class="box1-midi">
                      <h1>Editar</h1>
                      <asp:TextBox ID="txtNome" runat="server" CssClass="box1-mid" placeholder=""></asp:TextBox>
                    <div class="btn-b2">
                        <asp:Button class="btn-close" runat="server" Text="Excluir"  OnClick="Delete_Click"  OnClientClick="javascript:return ConfirmaExclusao();"/>
                        <asp:Button class="btn-save" runat="server" Text="Atualizar" OnClick="Update_Click"  ValidationGroup="validateGroup"/>
                    </div>
                </div>
                 <asp:RequiredFieldValidator ID="RequiredFieldValidator1" CssClass="compare" runat="server" Display="none" ErrorMessage="Novo nome não foi informado." ValidationGroup="validateGroup" ControlToValidate="txtNome"></asp:RequiredFieldValidator>
                 <asp:ValidationSummary ID="ValidationSummary1" runat="server" ValidationGroup="validateGroup" ShowSummary="false" ShowMessageBox="true"/>
     </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
</asp:Content>
