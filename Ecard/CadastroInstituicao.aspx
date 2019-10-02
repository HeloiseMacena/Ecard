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
         <div class="image" style="margin-right: 103px;"><img src="Imagens/ECard.png"  style="max-width:100%;"/></div>
         <div class="info">
             <h2>Instituição</h2>
             <p>Informações básicas</p>
         </div>
         <div class="textbox">
            
             <asp:TextBox ID="TextBox1" CssClass="textbox1" runat="server" type="text" placeholder="Nome Completo"></asp:TextBox>
         </div>
         <div class="textbox">
             
             <asp:TextBox ID="TextEmail" CssClass="textbox1" runat="server" type="email" placeholder="Email"></asp:TextBox>
         </div>    
             <div class="textbox">
            
             <asp:TextBox ID="TextConEmail" CssClass="textbox1" runat="server" type="email" placeholder="Confirmar Email"></asp:TextBox>
                
         </div>   
         
     </div>
        <div class="vl"></div> <!-- vertical line -->
     <div class="coluna-2">
         <div class="login-1">Informações avançadas</div>
        <div class ="coluna-3">
             <div class="textbox">
               
                <asp:TextBox ID="TextCodigo" CssClass="textbox1" runat="server" type="text" placeholder="Código do INEP/MEC"></asp:TextBox>
             </div> 

             <div class="textbox">
               
                <asp:TextBox ID="TextCNPJ" CssClass="textbox1" runat="server" type="text" placeholder="CNPJ"></asp:TextBox>
             </div>    
             <div class="textbox">
               
                <asp:TextBox ID="TextSenha" CssClass="textbox1" runat="server" type="text" placeholder="Senha"></asp:TextBox>
             </div> 

             <div class="textbox">
                
                <asp:TextBox ID="TextConSenha" CssClass="textbox1" runat="server" type="text" placeholder="Confirmar Senha"></asp:TextBox>
             </div> 

             <div class="textbox">
                
                 <asp:TextBox ID="TextTelefone" CssClass="textbox1" runat="server" type="text" placeholder="Telefone"></asp:TextBox>
             </div> 
        </div>

         <div class="coluna-3">
         <div class="textbox">
             
             <asp:TextBox ID="TextLogradouro" CssClass="textbox1" runat="server" type="text" placeholder="Logradouro"></asp:TextBox>
         </div>

         <div class="textbox">
             
             <asp:TextBox ID="TextBairro" CssClass="textbox1" runat="server" type="text" placeholder="Bairro"></asp:TextBox>
         </div>

         <div class="textbox">
            
             <asp:TextBox ID="TextCEP" CssClass="textbox1" runat="server" type="text" placeholder="CEP"></asp:TextBox>
         </div>

         <div class="textbox">
             
             <asp:TextBox ID="TextMunicipio" CssClass="textbox1" runat="server" type="text" placeholder="Municipio"></asp:TextBox>
         </div>

         <div class="textbox">
           
             <asp:TextBox ID="TextNumero" CssClass="textbox1" runat="server" type="text" placeholder="Número"></asp:TextBox>
         </div>
            </div>
         <div class="login">
             <asp:Button ID="Button1" runat="server" Text="Cadastrar" type="submit" class="button" onclick="Button1_Click"/>
             <p>Já possuo conta!<a class="link-open" href="LoginInstituicao.aspx">Entrar</a></p>
         </div>
</div>
    </form>
</body>
</html>