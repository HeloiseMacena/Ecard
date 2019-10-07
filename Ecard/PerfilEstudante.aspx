<%@ Page Title="" Language="C#" MasterPageFile="~/Estudante.Master" AutoEventWireup="true" CodeBehind="PerfilEstudante.aspx.cs" Inherits="Ecard.PerfilEstudante" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="stylesheet" type="text/css" href="StylePerfilEstudante.css"/>
    <div class="container">
        <div class="box1">
            <div class="box1-header">
                <div class="box1-title">
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
                    <asp:Button class="btn-close" runat="server" Text="Cancelar" PostBackUrl="~/TelaPrincipalEstudante.aspx"/>
                    <asp:Button class="btn-save" runat="server" Text="Salvar" OnClick="Unnamed_Click"/>
                </div>
            </div>
        </div>
            
        <div class="box2">
            <div class="box2-user-container">
                <div class="box2-user">
                    <i class="fas fa-user-circle"></i>
                    <div class="user-name"> 
                        <h1>Dara Hadrielle</h1>
                        <p>Estudante</p>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
