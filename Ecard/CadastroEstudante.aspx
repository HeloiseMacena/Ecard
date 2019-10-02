<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadastroEstudante.aspx.cs" Inherits="Ecard.CadastroEstudante" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<script src="https://kit.fontawesome.com/4bb70b9eaa.js"></script>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<link rel="stylesheet" type="text/css" href="StyleCadastroEstudante.css"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server" class="formulario">
        <div class="coluna1">
            <div class="image"><img style="max-width:100%;" src="Imagens/ECard.png"/></div>
            <div class="info">          
                <h2>Estudante</h2>
            	<p>Informações Básicas</p>
            </div>

            <div class="textbox">
                <asp:TextBox ID="Textbox1" runat="server" CssClass="textbox1" type="text" placeholder="Nome Completo"></asp:TextBox>
            </div>

            <div class="textbox">
                <asp:TextBox ID="Textbox2" runat="server" CssClass="textbox1" type="email" placeholder="Email"></asp:TextBox>
            </div>

            <div class="textbox">
            	<asp:TextBox ID="Textbox3" runat="server" CssClass="textbox1" type="email" placeholder="Confirmar Email"></asp:TextBox>
            </div>
        </div>

        <div class="v1"></div> <!-- vertical line -->
        <div class="coluna2">
            <div class="textbox">
                <asp:TextBox ID="Textbox4" runat="server" CssClass="textbox1" type="text" placeholder="CPF"></asp:TextBox>
            </div>

            <div class="textbox">
                <asp:TextBox ID="Textbox5" runat="server" CssClass="textbox1" type="password" placeholder="Senha"></asp:TextBox>
            </div>

            <div class="textbox">
                <asp:TextBox ID="Textbox6" runat="server" CssClass="textbox1" type="password" placeholder="Confirmar Senha"></asp:TextBox>
            </div>

            <div class="login">
            	<asp:Button ID="Button1" class="button" type="submit" runat="server" Text="Cadastrar" OnClick="Unnamed1_Click"/>
            	<p class="p3">Já possuo uma conta! <a href="LoginEstudante.aspx" class="link-open">Entrar</a></p>
            </div>
         </div>
    </form>
</body>
</html>