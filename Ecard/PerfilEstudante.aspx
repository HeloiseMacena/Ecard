<%@ Page Title="" Language="C#" MasterPageFile="~/Estudante.Master" AutoEventWireup="true" CodeBehind="PerfilEstudante.aspx.cs" Inherits="Ecard.PerfilEstudante" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="stylesheet" type="text/css" href="StylePerfilEstudante.css"/>
    <div class="container">
        <div class="box1">
            <div class="box1-header">
                <div class="box1-title">
                    <a class="ai" href="WebFormTelaPrincipalAdm.aspx"><i class="fas fa-arrow-left"></i></a>
                    <h3>Perfil</h3>
                </div>
            </div>
            <div class="nov-header">
                <div class="space">
                    <asp:TextBox ID="Nome" runat="server" CssClass="nov-text"></asp:TextBox> 
                    <asp:LinkButton ID="LinkButton1" CssClass="link-alt" runat="server" OnClick="LinkButton1_Click" >Alterar</asp:LinkButton>
                </div>
                <div class="space-2">
                    <asp:TextBox ID="Email" runat="server" CssClass="nov-text"></asp:TextBox>
                    <asp:LinkButton ID="LinkButton2" CssClass="link-alt" runat="server" OnClick="LinkButton2_Click">Alterar</asp:LinkButton>
                </div>
            </div>
            <div class="box1-midi">
                <h1 class="title-1">Mudar Senha</h1>
                <asp:TextBox ID="TextAtual" runat="server" CssClass="box1-mid" placeholder="Senha atual" type="password"></asp:TextBox>
                <asp:TextBox ID="TextNova" runat="server" CssClass="box1-mid" placeholder="Nova senha" type="password"></asp:TextBox>
                <asp:TextBox ID="TextConfirmacao" runat="server" CssClass="box1-mid" placeholder="Confirmar nova senha" type="password"></asp:TextBox>                             
                <div class="btn-b2">
                    <asp:Button class="btn-close" runat="server" Text="Cancelar" PostBackUrl="~/TelaPrincipalEstudante.aspx"/>
                    <asp:Button class="btn-save" runat="server" Text="Salvar" OnClick="Unnamed_Click" ValidationGroup="validateGroup"/>                                       
                </div>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" CssClass="compare" runat="server" Display="none" ErrorMessage="* Senha atual não informada." ValidationGroup="validateGroup" ControlToValidate="TextAtual"></asp:RequiredFieldValidator>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" CssClass="compare" runat="server" Display="none" ErrorMessage="* Senha nova não informada." ValidationGroup="validateGroup" ControlToValidate="TextNova" EnableClientScript="false"></asp:RequiredFieldValidator>     
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" CssClass="compare" runat="server" Display="none" ErrorMessage="* Confirmação da senha não informada." ValidationGroup="validateGroup" ControlToValidate="TextConfirmacao"></asp:RequiredFieldValidator>
            <asp:CompareValidator ID="CompareValidator1" CssClass="compare" runat="server" Display="none" type="String" controltovalidate="TextNova" controltocompare="TextConfirmacao" text="* Verifique se os campos de nova senha estão iguais." ValidationGroup="validateGroup"></asp:CompareValidator>           	
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" DisplayMode="List" ValidationGroup="validateGroup" ShowValidationErrors="true" ShowSummary="true" ShowMessageBox="true"/>
            </div>
        </div>
    </div>
</asp:Content>
