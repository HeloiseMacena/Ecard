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
            <div class="image" ><img src="Imagens/ECard.png"  style="max-width:100%;"/></div>
            <div class="info">
                <p>Instituição</p>
                <p style="font-size: 18px;">Informações básicas</p>
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
                    <asp:TextBox ID="TextCodigo" CssClass="textbox1" runat="server" type="String" placeholder="Código do INEP/MEC"></asp:TextBox>
                 </div> 
                 <div class="textbox">
                    <asp:TextBox ID="TextCNPJ" CssClass="textbox1" runat="server" type="String" placeholder="CNPJ"></asp:TextBox>
                 </div>    
                 <div class="textbox">
                    <asp:TextBox ID="TextSenha" CssClass="textbox1" runat="server" type="Password" placeholder="Senha"></asp:TextBox>
                 </div> 
                 <div class="textbox">
                    <asp:TextBox ID="TextConSenha" CssClass="textbox1" runat="server" type="Password" placeholder="Confirmar Senha"></asp:TextBox>
                    <asp:CompareValidator ID="CompareValidator2" CssClass="compare" runat="server" Display="Dynamic" type="String" controltovalidate="TextConSenha" controltocompare="TextSenha" enableclientscript="true" text="* Os campos de senha devem ser iguais."></asp:CompareValidator>           	           
                 </div> 
                 <div class="textbox">
                     <asp:TextBox ID="TextTelefone" CssClass="textbox1" runat="server" type="String" placeholder="Telefone"></asp:TextBox>
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
                    <asp:TextBox ID="TextNumero" CssClass="textbox1" runat="server" type="Double" placeholder="Número"></asp:TextBox>
                </div>
            </div>
            <div class="login">
                <asp:Button ID="Button1" runat="server" Text="Cadastrar" type="submit" class="button" onclick="Button1_Click"  ValidationGroup="validateGroup"/>
                <p>Já possuo conta!<a class="link-open" href="LoginInstituicao.aspx">Entrar</a></p>
            </div>
             <div class="volt">
             <a class="vol" href="LoginInstituicao.aspx"><i class="fas fa-arrow-left"></i></a>
                <div class="vol-1">
                    <p >Voltar</p>
                </div>
            </div>
        </div>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" CssClass="compare" runat="server" Display="none" ErrorMessage="Nome não informado." ValidationGroup="validateGroup" ControlToValidate="TextBox1"></asp:RequiredFieldValidator>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" CssClass="compare" runat="server" Display="none" ErrorMessage="Email não informado." ValidationGroup="validateGroup" ControlToValidate="TextEmail"></asp:RequiredFieldValidator>     
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" CssClass="compare" runat="server" Display="none" ErrorMessage="Confirmação de email não informado." ValidationGroup="validateGroup" ControlToValidate="TextConEmail"></asp:RequiredFieldValidator>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" CssClass="compare" runat="server" Display="none" ErrorMessage="Codigo não informado." ValidationGroup="validateGroup" ControlToValidate="TextCodigo"></asp:RequiredFieldValidator>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" CssClass="compare" runat="server" Display="none" ErrorMessage="CNPJ não informado." ValidationGroup="validateGroup" ControlToValidate="TextCNPJ"></asp:RequiredFieldValidator>     
        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" CssClass="compare" runat="server" Display="none" ErrorMessage="Senha não informada." ValidationGroup="validateGroup" ControlToValidate="TextSenha"></asp:RequiredFieldValidator>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" CssClass="compare" runat="server" Display="none" ErrorMessage="Confirmação da senha não informada." ValidationGroup="validateGroup" ControlToValidate="TextConSenha"></asp:RequiredFieldValidator>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator8" CssClass="compare" runat="server" Display="none" ErrorMessage="Telefone não informado." ValidationGroup="validateGroup" ControlToValidate="TextTelefone"></asp:RequiredFieldValidator>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator9" CssClass="compare" runat="server" Display="none" ErrorMessage="Logradouro não informado." ValidationGroup="validateGroup" ControlToValidate="TextLogradouro"></asp:RequiredFieldValidator>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator10" CssClass="compare" runat="server" Display="none" ErrorMessage="Bairro não informado." ValidationGroup="validateGroup" ControlToValidate="TextBairro"></asp:RequiredFieldValidator>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator11" CssClass="compare" runat="server" Display="none" ErrorMessage="CEP não informado." ValidationGroup="validateGroup" ControlToValidate="TextCEP"></asp:RequiredFieldValidator>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator12" CssClass="compare" runat="server" Display="none" ErrorMessage="Município não informado." ValidationGroup="validateGroup" ControlToValidate="TextMunicipio"></asp:RequiredFieldValidator>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator13" CssClass="compare" runat="server" Display="none" ErrorMessage="Número não informado." ValidationGroup="validateGroup" ControlToValidate="TextNumero"></asp:RequiredFieldValidator>
        <asp:CompareValidator ID="CompareValidator1" CssClass="compare" runat="server" Display="none" ControlToValidate="TextEmail" ControlToCompare="TextConEmail" ErrorMessage="Verifique se os campos de email estão iguais." ValidationGroup="validateGroup"></asp:CompareValidator>
        <asp:CompareValidator ID="CompareValidator3" CssClass="compare" runat="server" Display="none" controltovalidate="TextSenha" controltocompare="TextConSenha" ErrorMessage="Verifique se os campos de nova senha estão iguais." ValidationGroup="validateGroup"></asp:CompareValidator>           	            	
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ValidationGroup="validateGroup" ShowSummary="false" ShowMessageBox="true" />
    </form>
</body>
</html>