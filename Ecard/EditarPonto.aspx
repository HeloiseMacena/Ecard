﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditarPonto.aspx.cs" Inherits="Ecard.EditarPonto" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<script src="https://kit.fontawesome.com/4bb70b9eaa.js"></script>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<link rel="stylesheet" type="text/css" href="StyleEditarPonto.css"/>
    <title></title>
</head>
<body>
    <form id="form2" runat="server">
        <div class="header">
            <a style="width:100px;" href="WebFormTelaPrincipalAdm.aspx"><img src="Imagens/ECard.png" style="width:100px;" /></a>
            <ol>
                <li>Menu</li>
                <li>Page 2</li>
                <li>Page 3</li>
                <li>Page 4</li> 
                <li class="menu-user">Daniel Victor</li>
            </ol>
        </div>
        <div class="container">
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
                      <asp:TextBox ID="TextCEP" runat="server" CssClass="box1-mid" placeholder="CEP"></asp:TextBox>
                      <asp:TextBox ID="TextMunicipio" runat="server" CssClass="box1-mid" placeholder="Município"></asp:TextBox>
                    <div class="btn-b2">
                        <asp:Button class="btn-close" runat="server" Text="Excluir" OnClick="Delete_Click" />
                        <asp:Button class="btn-save" runat="server" Text="Atualizar" OnClick="Update_Click" />
                    </div>
                </div>
            </div>

            <div class="box2">
                <div class="box2-user-container">
                    <div class="box2-user">
                         <i class="fas fa-user-circle"></i>
                         <div class="user-name"> 
                            <h1>Daniel Victor</h1>
                            <p>Administrador</p>
                        </div>
                    </div>
                    <div class="box2-button">
                         <asp:Button runat="server" CssClass="btn2" Text="Ver Perfil" />
                    </div>
                </div>

                <div class="box2-ponto">
                    <div class="ponto">
                        <p>Pontos de recarga</p>
                    </div>
                    <div class="ponto2">
                        <i runat="server" id="i1" class="fas fa-search"></i>
                        <p>Pesquisar</p>
                    </div>
                </div>
            </div>
          </div>
    </form>
</body>
</html>
