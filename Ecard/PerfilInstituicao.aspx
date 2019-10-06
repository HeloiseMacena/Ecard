﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PerfilInstituicao.aspx.cs" Inherits="Ecard.PerfilInstituicao" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<script src="https://kit.fontawesome.com/4bb70b9eaa.js"></script>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<link rel="stylesheet" type="text/css" href="StylePerfilInstituicao.css"/>
 <script src="https://code.jquery.com/jquery-3.4.1.min.js"></script>
    <script src="JS/Events.js"></script>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="header max">
            <a style="width:100px;" href="WebFormTelaPrincipalAdm.aspx"><img src="Imagens/ECard.png" style="width:100px;" /></a>
            <div class="ol">
                <div class="li">Menu</div>
                <div class="li">Page 2</div>
                <div class="li">Page 3</div>
                <div class="li">Page 4</div> 
                <div class="menu-user">Daniel Victor</div>
            </div>
        </div>
        <div class="container">
            <div class="box1">
                <div class="box1-header">
                    <div class="box1-title">
                       <h3>Perfil</h3>
                    </div>
                </div>
                <div class="nov-header">
                    <div class="space">
                         <asp:TextBox ID="Nome" runat="server" CssClass="nov-text" placeholder="IFRN" ></asp:TextBox> 
                        <asp:LinkButton ID="LinkButton1" CssClass="link-alt" runat="server">Alterar</asp:LinkButton>
                   </div>
                    <div class="space-2">
                        <asp:TextBox ID="Email" runat="server" CssClass="nov-text" placeholder="ifrn@instituicao.edu.br"></asp:TextBox>
                        <asp:LinkButton ID="LinkButton2" CssClass="link-alt" runat="server">Alterar</asp:LinkButton>
                    </div>
                        </div>
                <div class="box1-midi">
                    <h1 class="title-1">Mudar Senha</h1>
                      <asp:TextBox ID="TextPonto" runat="server" CssClass="box1-mid" placeholder="Senha atual"></asp:TextBox>
                      <asp:TextBox ID="TextRua" runat="server" CssClass="box1-mid" placeholder="Nova senha"></asp:TextBox>
                      <asp:TextBox ID="TextBairro" runat="server" CssClass="box1-mid" placeholder="Confirmar nova senha"></asp:TextBox>
                    <div class="btn-b2">
                        <asp:Button class="btn-close" runat="server" Text="Cancelar" PostBackUrl="~/WebFormTelaPrincipalInstituicao.aspx" />
                        <asp:Button class="btn-save" runat="server" Text="Salvar"  />

                    </div>
                </div>
            </div>

            <div class="box2">
                <div class="box2-user-container">
                    <div class="box2-user">
                          <i class="fas fa-university"></i>
                         <div class="user-name"> 
                            <h1>Nome Escola</h1>
                            <p>Instituição</p>
                        </div>
                    </div>   
                </div>
            </div>
          </div>
    </form>
</body>
</html>
