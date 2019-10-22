<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadastroEstudante.aspx.cs" Inherits="Ecard.CadastroEstudante" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<script src="https://kit.fontawesome.com/4bb70b9eaa.js"></script>
<script src="JS/Events.js"></script>
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
            </div>
        </div>
        <div class="v1"></div> <!-- vertical line -->
        <div class="coluna2">
            <div class="login-1">Informações avançadas</div>
            <div class="textbox">
                <asp:TextBox ID="TextCPF" runat="server" CssClass="textbox1" type="text" placeholder="CPF (Apenas números)" MaxLength="14"></asp:TextBox>
                <asp:CustomValidator ID="CustomValidator1" CssClass="compare" runat="server" Display="dynamic" ErrorMessage="* O seu CPF não foi cadastrado pela sua escola."></asp:CustomValidator>
                <asp:CustomValidator ID="CustomValidator2" CssClass="compare" runat="server" Display="dynamic" ErrorMessage="* O seu CPF já foi cadastrado por você."></asp:CustomValidator>
            </div>
            <div class="textbox">
                <asp:TextBox ID="TextRG" runat="server" CssClass="textbox1" type="text" placeholder="RG (Apenas números)" MaxLength="9"></asp:TextBox>
            </div>
            <div class="textbox">
                <asp:TextBox ID="TextSenha" runat="server" CssClass="textbox1" type="password" placeholder="Senha"></asp:TextBox>
            </div>
            <div class="textbox">
                <asp:TextBox ID="Textbox7" runat="server" CssClass="textbox1" type="password" placeholder="Confirmar Senha"></asp:TextBox>
            </div>
            <div class="login">
            	<asp:Button ID="Button1" class="button" type="submit" runat="server" Text="Cadastrar" OnClick="Unnamed1_Click" ValidationGroup="validateGroup"/>
                <p class="p3">Já possuo uma conta!<a href="LoginEstudante.aspx" class="link-open">Entrar</a></p>
            </div>
             <div class="volt">
             <a class="vol" href="LoginEstudante.aspx"><i class="fas fa-arrow-left"></i></a>
                <div class="vol-1">
                    <a class="vol-1" href="LoginInstituicao.aspx"><p >Voltar</p></a>
                </div>
            </div>
         </div>
         <asp:RegularExpressionValidator ID="RegularExpressionValidator1" CssClass="compare" runat="server" Display="none" ErrorMessage="CPF inválido" ValidationGroup="validateGroup" ControlToValidate="TextCPF" ValidationExpression="^\d{11}$"></asp:RegularExpressionValidator>
         <asp:RegularExpressionValidator ID="RegularExpressionValidator2" CssClass="compare" runat="server" Display="none" ErrorMessage="RG inválido" ValidationGroup="validateGroup" ControlToValidate="TextRG" ValidationExpression="^(\d{9})|(\d{6})$"></asp:RegularExpressionValidator>
         <asp:RegularExpressionValidator ID="RegularExpressionValidator3" CssClass="compare" runat="server" Display="none" ErrorMessage="Email inválido" ValidationGroup="validateGroup" ControlToValidate="TextEmail" ValidationExpression="\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
         <asp:RegularExpressionValidator ID="RegularExpressionValidator4" CssClass="compare" runat="server" Display="none" ErrorMessage="Email inválido" ValidationGroup="validateGroup" ControlToValidate="Textbox3" ValidationExpression="\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
         <asp:RequiredFieldValidator ID="RequiredFieldValidator1" CssClass="compare" runat="server" Display="none" ErrorMessage="Nome não informado." ValidationGroup="validateGroup" ControlToValidate="TextNome"></asp:RequiredFieldValidator>
         <asp:RequiredFieldValidator ID="RequiredFieldValidator2" CssClass="compare" runat="server" Display="none" ErrorMessage="Email não informado." ValidationGroup="validateGroup" ControlToValidate="TextEmail"></asp:RequiredFieldValidator>     
         <asp:RequiredFieldValidator ID="RequiredFieldValidator3" CssClass="compare" runat="server" Display="none" ErrorMessage="Confirmação de email não informado." ValidationGroup="validateGroup" ControlToValidate="Textbox3"></asp:RequiredFieldValidator>
         <asp:RequiredFieldValidator ID="RequiredFieldValidator4" CssClass="compare" runat="server" Display="none" ErrorMessage="CPF não informado." ValidationGroup="validateGroup" ControlToValidate="TextCPF"></asp:RequiredFieldValidator>
         <asp:RequiredFieldValidator ID="RequiredFieldValidator5" CssClass="compare" runat="server" Display="none" ErrorMessage="RG não informado." ValidationGroup="validateGroup" ControlToValidate="TextRG"></asp:RequiredFieldValidator>     
         <asp:RequiredFieldValidator ID="RequiredFieldValidator7" CssClass="compare" runat="server" Display="none" ErrorMessage="Senha não informada." ValidationGroup="validateGroup" ControlToValidate="TextSenha"></asp:RequiredFieldValidator> 
         <asp:RequiredFieldValidator ID="RequiredFieldValidator6" CssClass="compare" runat="server" Display="none" ErrorMessage="Confirmação da senha não informada." ValidationGroup="validateGroup" ControlToValidate="Textbox7"></asp:RequiredFieldValidator>
         <asp:CompareValidator ID="CompareValidator1" CssClass="compare" runat="server" Display="none" ControlToValidate="TextEmail" ControlToCompare="Textbox3" ErrorMessage="Verifique se os campos de email estão iguais." ValidationGroup="validateGroup"></asp:CompareValidator>
         <asp:CompareValidator ID="CompareValidator2" CssClass="compare" runat="server" Display="none" controltovalidate="TextSenha" controltocompare="Textbox7" ErrorMessage="Verifique se os campos de nova senha estão iguais." ValidationGroup="validateGroup"></asp:CompareValidator>           	            	
         <asp:ValidationSummary ID="ValidationSummary1" runat="server" ValidationGroup="validateGroup" ShowSummary="false" ShowMessageBox="true"/>    
    </form>
</body>
</html>