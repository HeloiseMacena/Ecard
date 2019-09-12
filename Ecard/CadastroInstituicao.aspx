<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadastroInstituicao.aspx.cs" Inherits="Ecard.CadastroInstituicao" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<script src="https://kit.fontawesome.com/4bb70b9eaa.js"></script>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<link rel="stylesheet" type="text/css" href="StyleCadastroInstituicao.css"/>
    <title></title>
</head>  
<body>
 <form class="formulario" runat="server" id="form12">
    
     <div class="coluna-1" >
         <div class="image"><img src="Imagens/ECard.png"  style="max-width:100%;"/></div>
         
         <div class="textbox">
             <i class="fas fa-user icon"></i>
             <asp:TextBox ID="TextBox1" CssClass="textbox" runat="server" type="text" placeholder="Nome Completo"></asp:TextBox>
         </div>
         <div class="textbox">
             <i class="fas fa-envelope icon"></i>
             <asp:TextBox ID="TextEmail" runat="server" type="text" placeholder="Email"></asp:TextBox>
         </div>    
             <div class="textbox">
             <i class="fas fa-envelope icon"></i>
             <asp:TextBox ID="TextConEmail" runat="server" type="text" placeholder="Confirmar Email"></asp:TextBox>
         </div>   
     </div>
     <div class="coluna-2">
         <div class="login">Informações avançadas</div>
        <div class ="coluna-3">
             <div class="textbox">
                <i class="fas fa-angle-right icon"></i>
                <asp:TextBox ID="TextCodigo" runat="server" type="text" placeholder="Código do INEP/MEC"></asp:TextBox>
             </div> 

             <div class="textbox">
                <i class="fas fa-angle-right icon"></i>
                <asp:TextBox ID="TextCNPJ" runat="server" type="text" placeholder="CNPJ"></asp:TextBox>
             </div>    
             <div class="textbox">
                <i class="fas fa-key icon"></i>
                <asp:TextBox ID="TextSenha" runat="server" type="text" placeholder="Senha"></asp:TextBox>
             </div> 

             <div class="textbox">
                <i class="fas fa-key icon"></i>
                <asp:TextBox ID="TextConSenha" runat="server" type="text" placeholder="Confirmar Senha"></asp:TextBox>
             </div> 

             <div class="textbox">
                 <i class="fas fa-phone-alt icon"></i>
                 <asp:TextBox ID="TextTelefone" runat="server" type="text" placeholder="Telefone"></asp:TextBox>
             </div> 
        </div>

         <div class="coluna-3">
         <div class="textbox">
             <i class="fas fa-angle-right icon"></i>
             <asp:TextBox ID="TextLogradouro" runat="server" type="text" placeholder="Logradouro"></asp:TextBox>
         </div>

         <div class="textbox">
             <i class="fas fa-angle-right icon"></i>
             <asp:TextBox ID="TextBairro" runat="server" type="text" placeholder="Bairro"></asp:TextBox>
         </div>

         <div class="textbox">
             <i class="fas fa-angle-right icon"></i>
             <asp:TextBox ID="TextCEP" runat="server" type="text" placeholder="CEP"></asp:TextBox>
         </div>

         <div class="textbox">
             <i class="fas fa-angle-right icon"></i>
             <asp:TextBox ID="TextMunicipio" runat="server" type="text" placeholder="Municipio"></asp:TextBox>
         </div>

         <div class="textbox">
             <i class="fas fa-angle-right icon"></i>
             <asp:TextBox ID="TextNumero" runat="server" type="text" placeholder="Número"></asp:TextBox>
         </div>
            </div>
         <div class="login">
             <asp:Button ID="Button1" runat="server" Text="Cadastrar" type="submit" class="button" />
             <p>Já possuo conta!<a href="LoginInstituicao.aspx">Entrar</a></p>
         </div>
</div>
    </form>
</body>
</html>
