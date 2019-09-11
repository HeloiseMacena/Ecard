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
    <form id="form1" runat="server">
        <div class="container">
            <div class="box1">
            	<div class="box1-header">
            		<img src="Imagens/ECard.png"/>
            		<p>Estudante</p>
            		<p>Informações Básicas</p>
            	</div>
            	<div class="lado1">
            		<asp:TextBox ID="Textbox1" runat="server" CssClass="box-lado1" placeholder="Nome Completo"></asp:TextBox>
            		<asp:TextBox ID="Textbox2" runat="server" CssClass="box-lado1" placeholder="Email"></asp:TextBox>
            		<asp:TextBox ID="Textbox3" runat="server" CssClass="box-lado1" placeholder="Confirmar Email"></asp:TextBox>
            	</div>
            	<div class="linha"></div>
            	<div class="lado2">
            		<asp:TextBox ID="Textbox4" runat="server" CssClass="box-lado2" placeholder="CPF"></asp:TextBox>
            		<asp:TextBox ID="Textbox5" runat="server" CssClass="box-lado2" placeholder="Senha"></asp:TextBox>
            		<asp:TextBox ID="Textbox6" runat="server" CssClass="box-lado2" placeholder="Confirmar Senha"></asp:TextBox>
            		<asp:Button class="btn=cadastrar" runat="server" Text="Cadastrar" OnClick="Unnamed1_Click"/>
            		<p>Já possuo uma conta! <a href="LoginEstudante.aspx">Entrar</a></p>
            	</div>
            </div>
        </div>
    </form>
</body>
</html>
