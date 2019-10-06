<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginInstituicao.aspx.cs" Inherits="Ecard.LoginInstituicao" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<script src="https://kit.fontawesome.com/4bb70b9eaa.js"></script>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<link rel="stylesheet" type="text/css" href="StyleLoginInstituicao.css"/>
    <title></title>
</head>  
<body>
 <form class="formulario" runat="server" id="form12">
    
     <div class="coluna-1" >
         <div class="image" ><img src="Imagens/ECard.png"  style="max-width:100%;"/></div>
         <div class="info">
             <p>Instituição</p>             
         </div>
       
         <div class="textbox">             
             <asp:TextBox ID="TextEmail" CssClass="textbox1" runat="server" type="text" placeholder="Email"></asp:TextBox>
         </div>
         
         <div class="textbox">            
             <asp:TextBox ID="TextSenha" CssClass="textbox1" runat="server" type="password" placeholder="Senha"></asp:TextBox>                
         </div>               
      
         <div class="login">
             <!-- PostBackUrl="~/WebFormTelaPrincipalInstituicao.aspx" -->
             <asp:Button ID="Button1" runat="server" Text="Entrar" type="submit" class="button"  OnClick="Button_Click"/>
             <p>Instituição não cadastrada!<a class="link-open" href="CadastroInstituicao.aspx">Cadastre-a</a></p>
             <p class="link-rec">Esqueceu a senha?</p>
         </div>
     </div>
</form>
</body>
</html>
