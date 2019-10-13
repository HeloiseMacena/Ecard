﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginEstudante.aspx.cs" Inherits="Ecard.LoginEstudante" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<script src="https://kit.fontawesome.com/4bb70b9eaa.js"></script>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<link rel="stylesheet" type="text/css" href="StyleLoginEstudante.css"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server" class="formulario">
        <div class="coluna1">
            <div class="image" ><img src="Imagens/ECard.png"  style="max-width:100%;"/></div>
            <div class="info">
                <p>Estudante</p>            
            </div>
       
            <div class="textbox">             
                <asp:TextBox ID="TextUsuario" CssClass="textbox1" runat="server" type="text" placeholder="CPF"></asp:TextBox>
            </div>   
         
            <div class="textbox">
                <asp:TextBox ID="TextSenha" CssClass="textbox1" runat="server" type="password" placeholder="Senha"></asp:TextBox>               
            </div>   
            
         <div class="login">
             <asp:Button ID="Button1" runat="server" Text="Entrar" type="submit" class="button" OnClick="Button_click" />
             <p>Estudante não cadastrado!<a class="link-open" href="CadastroEstudante.aspx">Cadastre-se</a></p>
             <p class="link-rec">Esqueceu a senha?</p>
         </div>
            <div class="volt">
             <a class="vol" href="TelaInicial.aspx"><i class="fas fa-arrow-left"></i></a>
                <div class="vol-1">
                    <p >Voltar</p>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
