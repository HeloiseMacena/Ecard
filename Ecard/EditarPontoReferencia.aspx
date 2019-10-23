<%@ Page Title="" Language="C#" MasterPageFile="~/Administrador.Master" AutoEventWireup="true" CodeBehind="EditarPontoReferencia.aspx.cs" Inherits="Ecard.EditarPontoReferencia" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="StyleEditarPonto.css"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="box1">
                <div class="box1-header">
                    <div class="box1-title">
                      <a class="ai" href="CadastroPontoReferencia.aspx"><i class="fas fa-arrow-left"></i></a>
                       <p>Ponto de Referência</p>
                    </div>
                </div>
                <div class="box1-midi">
                      <h1>Editar</h1>
                      <asp:TextBox ID="TextBox1" runat="server" CssClass="box1-mid" placeholder="Nome"></asp:TextBox>
                    <div class="btn-b2">
                        <asp:Button class="btn-close" runat="server" Text="Excluir" OnClick="Unnamed1_Click" OnClientClick="javascript:return ConfirmaExclusao();" />
                        <asp:Button class="btn-save" runat="server" Text="Atualizar" OnClick="Unnamed2_Click" ValidationGroup="validateGroup" />
                    </div>
                </div>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" CssClass="compare" runat="server" Display="none" ErrorMessage="Novo nome não foi informado." ValidationGroup="validateGroup" ControlToValidate="TextBox1"></asp:RequiredFieldValidator>
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" ValidationGroup="validateGroup" ShowSummary="false" ShowMessageBox="true"/>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
</asp:Content>
