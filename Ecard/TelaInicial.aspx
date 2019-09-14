<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TelaInicial.aspx.cs" Inherits="Ecard.TelaInicial" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<script src="https://kit.fontawesome.com/4bb70b9eaa.js"></script>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<link rel="stylesheet" type="text/css" href="StyleTelaInicial.css"/>
    <title></title>
</head>  
<body>
 <form class="formulario" runat="server" id="form12">
    
     <div class="coluna-1" >
         <div class="image" style="margin-right: 104px;"><img src="Imagens/ECard.png"  style="max-width:100%;"/></div>
         <div class="hl"></div> <!-- horizontal line -->
         <div class="info">
             <p>Escolha o tipo de usuário para realizar o login:</p>
             
         </div>
       
         <div class="login">
             <asp:Button ID="Button2" CssClass="button" runat="server" Text="Estudante" PostBackUrl="~/LoginEstudante.aspx" />
            
            <asp:Button ID="Button3" CssClass="button" runat="server" Text="Instituição" PostBackUrl="~/LoginInstituicao.aspx" />
                
         </div>   
         
     
      
         <div class="textbox">
    
            <a class="link-open" href="LoginAdm.aspx">Acesso Administrador</a>
         </div>
        </div>
    </form>
</body>
</html>