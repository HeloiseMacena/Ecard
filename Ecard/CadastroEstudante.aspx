﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadastroEstudante.aspx.cs" Inherits="Ecard.CadastroEstudante" %>

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
                <p>Estudante</p>
            	<p style="font-size: 18px;">Informações Básicas</p>
            </div>
            <div class="textbox">
                <asp:TextBox ID="TextNome" runat="server" CssClass="textbox1" type="text" placeholder="Nome Completo"></asp:TextBox>
            </div>
            <div class="textbox">
                <asp:TextBox ID="TextEmail" runat="server" CssClass="textbox1" type="email" placeholder="Email"></asp:TextBox>
            </div>
            <div class="textbox">
            	<asp:TextBox ID="Textbox3" runat="server" CssClass="textbox1" type="email" placeholder="Confirmar Email"></asp:TextBox>
                <asp:CompareValidator ID="CompareValidator1" CssClass="compare" runat="server" ErrorMessage="* Os campos de email devem ser iguais." ControlToValidate="Textbox3" ControlToCompare="TextEmail" Type="String" Display="Dynamic"></asp:CompareValidator>     	            
            </div>
        </div>
        <div class="v1"></div> <!-- vertical line -->
        <div class="coluna2">
            <div class="login-1">Informações avançadas</div>
            <div class="textbox2">
                <asp:TextBox ID="TextCPF" runat="server" CssClass="tt2" type="String" placeholder="CPF (Apenas números)"></asp:TextBox>                
                <asp:rangevalidator id="RangeValidator1" CssClass="range" controltovalidate="TextCPF" minimunvalue="10000000000" maximumvalue="99999999999" type="String" text="* CPF inválido" runat="server"></asp:rangevalidator>
            </div>
            <div class="textbox">
                <asp:TextBox ID="TextRG" runat="server" CssClass="textbox1" type="number" placeholder="RG"></asp:TextBox>
            </div>
            <div class="textbox">
                <asp:TextBox ID="TextSenha" runat="server" CssClass="textbox1" type="password" placeholder="Senha"></asp:TextBox>
            </div>
            <div class="textbox">
                <asp:TextBox ID="Textbox7" runat="server" CssClass="textbox1" type="password" placeholder="Confirmar Senha"></asp:TextBox>
                <asp:CompareValidator ID="CompareValidator2" CssClass="compare" runat="server" Display="Dynamic" type="String" controltovalidate="TextSenha" controltocompare="Textbox7" enableclientscript="true" text="* Os campos de senha devem ser iguais."></asp:CompareValidator>           	
            </div>
            <div class="login">
            	<asp:Button ID="Button1" class="button" type="submit" runat="server" Text="Cadastrar" OnClick="Unnamed1_Click"/>
                <p class="p3">Já possuo uma conta!<a href="LoginEstudante.aspx" class="link-open">Entrar</a></p>
            </div>
         </div>
    </form>
</body>
</html>