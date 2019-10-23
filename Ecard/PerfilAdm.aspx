<%@ Page Title="" Language="C#" MasterPageFile="~/Administrador.Master" AutoEventWireup="true" CodeBehind="PerfilAdm.aspx.cs" Inherits="Ecard.PerfilAdm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="StylePerfilAdm.css"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="box1">
                <div class="box1-header">
                    <div class="box1-title">
                        <a class="ai" href="TelaPrincipalAdm.aspx"><i class="fas fa-arrow-left"></i></a>
                       <h3>Perfil</h3>
                    </div>
                </div>
                <div class="nov-header">
                    <div class="space">
                         <asp:TextBox ID="Nome" runat="server" CssClass="nov-text" placeholder="Heloise" ></asp:TextBox> 
                        <asp:LinkButton ID="LinkButton1" CssClass="link-alt" runat="server">Alterar</asp:LinkButton>
                   </div>
                    <div class="space-2">
                        <asp:TextBox ID="Email" runat="server" CssClass="nov-text" placeholder="Heloise@outlook.edu.br"></asp:TextBox>
                        <asp:LinkButton ID="LinkButton2" CssClass="link-alt" runat="server">Alterar</asp:LinkButton>
                    </div>
                        </div>
                <div class="box1-midi">
                    <h1 class="title-1">Mudar Senha</h1>
                      <asp:TextBox ID="TextAtual" runat="server" CssClass="box1-mid" placeholder="Senha atual"></asp:TextBox>
                      <asp:TextBox ID="TextNova" runat="server" CssClass="box1-mid" placeholder="Nova senha"></asp:TextBox>
                      <asp:TextBox ID="TextConfirmacao" runat="server" CssClass="box1-mid" placeholder="Confirmar nova senha"></asp:TextBox>
                    <div class="btn-b2">
                        <asp:Button class="btn-close" runat="server" Text="Cancelar" PostBackUrl="~/TelaPrincipalAdm.aspx" />
                        <asp:Button class="btn-save" runat="server" Text="Salvar" ValidationGroup="validateGroup"/>
                    </div>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" CssClass="compare" runat="server" Display="none" ErrorMessage="Senha atual não informada." ValidationGroup="validateGroup" ControlToValidate="TextAtual"></asp:RequiredFieldValidator>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" CssClass="compare" runat="server" Display="none" ErrorMessage="Senha nova não informada." ValidationGroup="validateGroup" ControlToValidate="TextNova"></asp:RequiredFieldValidator>     
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" CssClass="compare" runat="server" Display="none" ErrorMessage="Confirmação da senha não informada." ValidationGroup="validateGroup" ControlToValidate="TextConfirmacao"></asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="CompareValidator1" CssClass="compare" runat="server" Display="none" controltovalidate="TextNova" controltocompare="TextConfirmacao" ErrorMessage="Verifique se os campos de nova senha estão iguais." ValidationGroup="validateGroup"></asp:CompareValidator>           	
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" ValidationGroup="validateGroup" ShowSummary="false" ShowMessageBox="true" />
                </div>
            </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
</asp:Content>
