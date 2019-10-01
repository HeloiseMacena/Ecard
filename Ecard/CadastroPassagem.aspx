﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadastroPassagem.aspx.cs" Inherits="Ecard.CadastroPassagem" %>

<!DOCTYPE html>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<script src="https://kit.fontawesome.com/4bb70b9eaa.js"></script>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<link rel="stylesheet" type="text/css" href="StyleEditEstudante.css"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="header">
            <img src="Imagens/ECard.png" />
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
                      <i class="fas fa-calculator"></i>
                       <p>Cadastro de passagem</p>
                    </div>
                </div>
                <div class="box1-midi">
                    <div class="space">
                    <asp:Label ID="Label5" runat="server" class="text-p" Text="Passagem de Ceará Mirim"></asp:Label>
                    <asp:TextBox ID="TextBox1" CssClass="box1-mid" placeholder="R$ 5,90" runat="server"></asp:TextBox>
                    </div>
                    <div class="space">
                    <asp:Label ID="Label1" runat="server" class="text-p" Text="Passagem de Extremoz"></asp:Label>
                    <asp:TextBox ID="TextBox2" CssClass="box1-mid" placeholder="R$ 4,45" runat="server"></asp:TextBox>
                    </div>
                    <div class="space">
                    <asp:Label ID="Label2" runat="server" class="text-p" Text="Passagem de Natal"></asp:Label>
                    <asp:TextBox ID="TextBox3" CssClass="box1-mid" placeholder="R$ 4,00" runat="server"></asp:TextBox>
                    </div>
                    <div class="space">
                    <asp:Label ID="Label3" runat="server" class="text-p" Text="Passagem de Parnamirm"></asp:Label>
                    <asp:TextBox ID="TextBox4" CssClass="box1-mid" placeholder="R$ 4,45" runat="server"></asp:TextBox>
                    </div>
                    <div class="space">
                    <asp:Label ID="Label4" runat="server" class="text-p" Text="Passagem de São Gonçalo do Amarante"></asp:Label>
                    <asp:TextBox ID="TextBox5" CssClass="box1-mid" placeholder="R$ 4,20" runat="server"></asp:TextBox>
                    </div>
                    <div class="btn-b2">
                        <asp:Button class="btn-close" runat="server" Text="Fechar" PostBackUrl="~/CadastroPonto.aspx" />
                        <asp:Button class="btn-save" runat="server" Text="Salvar"  />

                    </div>
                </div>
            </div>

            <div class="box2">
                <div class="box2-user-container">
                    <div class="box2-user">
                         <i class="fas fa-university"></i>
                         <div class="user-name"> 
                            <h1>Nome Instituição</h1>
                            <p>Instituição</p>
                        </div>
                    </div>
                    <div class="box2-button">
                         <asp:Button runat="server" CssClass="btn2" Text="Ver Perfil" />
                    </div>
                </div>
            </div>
          </div>
    </form>
</body>
</html>