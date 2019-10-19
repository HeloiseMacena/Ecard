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
         <div class="image" ><img src="Imagens/ECard.png"  style="max-width:100%;"/></div>
         <div class="info">
             <p>Administrador</p>            
         </div>
       
         <div class="textbox">             
             <asp:TextBox ID="TextUsuario" CssClass="textbox1" runat="server" type="text" placeholder="Usuário"></asp:TextBox>
         </div>   
         
         <div class="textbox">
             <asp:TextBox ID="TextSenha" CssClass="textbox1" runat="server" type="password" placeholder="Senha"></asp:TextBox>               
         </div>   
            
         <div class="login">


             <asp:Button ID="Button1" runat="server" Text="Entrar"  type="submit" class="button" onclick="Button_click" ValidationGroup="validateGroup" />
           
         </div>
         <div class="volt">
             <a class="vol" href="TelaInicial.aspx"><i class="fas fa-arrow-left"></i></a>
                <div class="vol-1">
                    <a class="vol-1" href="TelaInicial.aspx"><p >Voltar</p></a>
                </div>
            </div>
    </div>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" CssClass="compare" runat="server" Display="none" ErrorMessage="Usuário não informado." ValidationGroup="validateGroup" ControlToValidate="TextUsuario"></asp:RequiredFieldValidator>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" CssClass="compare" runat="server" Display="none" ErrorMessage="Senha não informada." ValidationGroup="validateGroup" ControlToValidate="TextSenha"></asp:RequiredFieldValidator>     
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" ValidationGroup="validateGroup" ShowSummary="false" ShowMessageBox="true" />
</form>
</body>
</html>