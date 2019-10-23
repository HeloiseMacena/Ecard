<%@ Page Title="" Language="C#" MasterPageFile="~/Administrador.Master" AutoEventWireup="true" CodeBehind="CadastroPontoEdit.aspx.cs" Inherits="Ecard.CadastroPontoEdit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="StyleCadastroPonto.css"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="box1">
                <div class="box1-header">
                    <div class="box1-title">
                       <i class="fas fa-map-marked-alt"></i>
                       <p>Pontos de recarga</p>
                    </div>
                </div>
                <div class="box1-midi">
                      <h1>Cadastro</h1>
                      <asp:TextBox ID="TextPonto" runat="server" CssClass="box1-mid" placeholder="Nome"></asp:TextBox>
                      <asp:TextBox ID="TextRua" runat="server" CssClass="box1-mid" placeholder="Logradouro"></asp:TextBox>
                      <asp:TextBox ID="TextBairro" runat="server" CssClass="box1-mid" placeholder="Bairro"></asp:TextBox>
                      <asp:TextBox ID="TextNumero" runat="server" CssClass="box1-mid" placeholder="Número"></asp:TextBox>
                      <asp:TextBox ID="TextCEP" runat="server" CssClass="box1-mid" placeholder="CEP" MaxLength="10"></asp:TextBox>
                      <asp:TextBox ID="TextMunicipio" runat="server" CssClass="box1-mid" placeholder="Município"></asp:TextBox>
                    <div class="btn-b2">
                        <asp:Button class="btn-close" runat="server" Text="Fechar" PostBackUrl="~/CadastroPonto.aspx"/>
                        <asp:Button class="btn-save" runat="server" Text="Salvar" OnClick="Unnamed2_Click" ValidationGroup="validateGroup"/>

                    </div>
                </div>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" CssClass="compare" runat="server" Display="none" ErrorMessage="CEP inválido" ValidationGroup="validateGroup" ControlToValidate="TextCEP" ValidationExpression="^(\d{5}-\d{3})|(\d{8})$"></asp:RegularExpressionValidator>
              <asp:RegularExpressionValidator ID="RegularExpressionValidator2" CssClass="compare" runat="server" Display="none" ErrorMessage="Número inválido" ValidationGroup="validateGroup" ControlToValidate="TextNumero" ValidationExpression="^\d+$"></asp:RegularExpressionValidator>
              <asp:RequiredFieldValidator ID="RequiredFieldValidator1" CssClass="compare" runat="server" Display="none" ErrorMessage="Nome não informado." ValidationGroup="validateGroup" ControlToValidate="TextPonto"></asp:RequiredFieldValidator>
              <asp:RequiredFieldValidator ID="RequiredFieldValidator9" CssClass="compare" runat="server" Display="none" ErrorMessage="Logradouro não informado." ValidationGroup="validateGroup" ControlToValidate="TextRua"></asp:RequiredFieldValidator>
              <asp:RequiredFieldValidator ID="RequiredFieldValidator10" CssClass="compare" runat="server" Display="none" ErrorMessage="Bairro não informado." ValidationGroup="validateGroup" ControlToValidate="TextBairro"></asp:RequiredFieldValidator>
              <asp:RequiredFieldValidator ID="RequiredFieldValidator11" CssClass="compare" runat="server" Display="none" ErrorMessage="CEP não informado." ValidationGroup="validateGroup" ControlToValidate="TextCEP"></asp:RequiredFieldValidator>
              <asp:RequiredFieldValidator ID="RequiredFieldValidator12" CssClass="compare" runat="server" Display="none" ErrorMessage="Município não informado." ValidationGroup="validateGroup" ControlToValidate="TextMunicipio"></asp:RequiredFieldValidator>
              <asp:RequiredFieldValidator ID="RequiredFieldValidator13" CssClass="compare" runat="server" Display="none" ErrorMessage="Número não informado." ValidationGroup="validateGroup" ControlToValidate="TextNumero"></asp:RequiredFieldValidator>
              <asp:ValidationSummary ID="ValidationSummary1" runat="server" ValidationGroup="validateGroup" ShowSummary="false" ShowMessageBox="true"/>
     </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
</asp:Content>
