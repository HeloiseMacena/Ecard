<%@ Page Title="" Language="C#" MasterPageFile="~/Administrador.Master" AutoEventWireup="true" CodeBehind="EditarPonto.aspx.cs" Inherits="Ecard.EditarPonto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="StyleEditarPonto.css"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="box1">
                <div class="box1-header">
                    <div class="box1-title">
                        <a class="ai" href="CadastroPonto.aspx"><i class="fas fa-arrow-left"></i></a>
                       <p>Pontos de recarga</p>
                    </div>
                </div>
                <div class="box1-midi">
                      <h1>Editar</h1>
                      <asp:TextBox ID="TextPonto" runat="server" CssClass="box1-mid" placeholder="Nome"></asp:TextBox>
                      <asp:TextBox ID="TextRua" runat="server" CssClass="box1-mid" placeholder="Rua"></asp:TextBox>
                      <asp:TextBox ID="TextBairro" runat="server" CssClass="box1-mid" placeholder="Bairro"></asp:TextBox>
                      <asp:TextBox ID="TextNumero" runat="server" CssClass="box1-mid" placeholder="Número"></asp:TextBox>
                      <asp:TextBox ID="TextCEP" runat="server" CssClass="box1-mid" placeholder="CEP" MaxLength="14"></asp:TextBox>
                      <asp:TextBox ID="TextMunicipio" runat="server" CssClass="box1-mid" placeholder="Município"></asp:TextBox>
                    <div class="btn-b2">
                        <asp:Button class="btn-close" runat="server" Text="Excluir" OnClick="Delete_Click" OnClientClick="javascript:return ConfirmaExclusao();" />
                        <asp:Button class="btn-save" runat="server" Text="Atualizar" OnClick="Update_Click" />
                    </div>
                </div>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" CssClass="compare" runat="server" Display="none" ErrorMessage="CEP inválido" ValidationGroup="validateGroup" ControlToValidate="TextCEP" ValidationExpression="^(\d{5}-\d{3})|(\d{8})$"></asp:RegularExpressionValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" CssClass="compare" runat="server" Display="none" ErrorMessage="Número inválido" ValidationGroup="validateGroup" ControlToValidate="TextNumero" ValidationExpression="^\d+$"></asp:RegularExpressionValidator>
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" ValidationGroup="validateGroup" ShowSummary="false" ShowMessageBox="true"/>
      </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
</asp:Content>
