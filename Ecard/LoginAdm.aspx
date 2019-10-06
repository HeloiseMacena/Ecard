<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginAdm.aspx.cs" Inherits="Ecard.LoginAdm" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<script src="https://kit.fontawesome.com/4bb70b9eaa.js"></script>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<link rel="stylesheet" type="text/css" href="StyleLoginAdm.css"/>
    <title></title>
</head>  
<body>
 <form class="formulario" runat="server" id="form12">
    
     <div class="coluna-1" >
         <div clAdministrador </p>            
         </div>
       
         <div class="textbox">             
             <asp:TextBox ID="TextUsuario" CssClass="textbox1" runat="server" type="text" placeholder="Usuário"></asp:TextBox>
         </div>   
         
         <div class="textbox">
             <asp:TextBox ID="TextSenha" CssClass="textbox1" runat="server" type="password" placeholder="Senha"></asp:TextBox>               
         </div>   
            
         <div class="login">
             <asp:Button ID="Button1" runat="server" Text="Entrar"  type="submit" class="button" OnClick="Button_click" />
             <p class="link-rec">Esqueceu a senha?</p>
         </div>
    </div>
</form>
</body>
</html>
