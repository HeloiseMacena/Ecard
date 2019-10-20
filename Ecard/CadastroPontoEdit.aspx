<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadastroPontoEdit.aspx.cs" Inherits="Ecard.CadastroPontoEdit" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<script src="https://kit.fontawesome.com/4bb70b9eaa.js"></script>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<link rel="stylesheet" type="text/css" href="StyleCadastroPonto.css"/>
    <script src="https://code.jquery.com/jquery-3.4.1.min.js"></script>
    <script src="JS/Events.js"></script>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="header max">
            <a style="width:100px;" href="WebFormTelaPrincipalAdm.aspx"><img src="Imagens/ECard.png" style="width:100px;" /></a>
            <div class="ol">
                <div class="li">Menu</div>
                <div class="li">Page 2</div>
                <div class="li">Page 3</div>
                <div class="li">Page 4</div> 
                <div class="menu-user">Daniel Victor</div>
            </div>
        </div>
        <div class="container">
            <div class="box1">
                <div class="box1-header">
                    <div class="box1-title">
                       <i class="fas fa-map-marked-alt"></i>
                       <p>Pontos de recarga</p>
                    </div>
                </div>
                <div class="box1-midi">
                      <h1>Cadastro</h1>
                      <asp:TextBox ID="TextPonto" runat="server" CssClass="box1-mid" placeholder="Nome"></asp:TextBox>
                      <asp:TextBox ID="TextRua" runat="server" CssClass="box1-mid" placeholder="Logradouro"></asp:TextBox>
                      <asp:TextBox ID="TextBairro" runat="server" CssClass="box1-mid" placeholder="Bairro"></asp:TextBox>
                      <asp:TextBox ID="TextNumero" runat="server" CssClass="box1-mid" placeholder="Número"></asp:TextBox>
                      <asp:TextBox ID="TextCEP" runat="server" CssClass="box1-mid" placeholder="CEP" MaxLength="10"></asp:TextBox>
                      <asp:TextBox ID="TextMunicipio" runat="server" CssClass="box1-mid" placeholder="Município"></asp:TextBox>
                    <div class="btn-b2">
                        <asp:Button class="btn-close" runat="server" Text="Fechar" PostBackUrl="~/CadastroPonto.aspx" ValidationGroup="validateGroup"/>
                        <asp:Button class="btn-save" runat="server" Text="Salvar" OnClick="Unnamed2_Click" />

                    </div>
                </div>
            </div>

            <div class="box2">
                <div class="box2-user-container">
                    <div class="box2-user">
                         <i class="fas fa-user-circle"></i>
                         <div class="user-name"> 
                            <h1>Daniel Victor</h1>
                            <p>Administrador</p>
                        </div>
                    </div>
                    <div class="box2-button">
                         <asp:Button runat="server" CssClass="btn2" Text="Ver Perfil" />
                    </div>
                </div>
            </div>
          </div>
          <asp:RegularExpressionValidator ID="RegularExpressionValidator1" CssClass="compare" runat="server" Display="none" ErrorMessage="CEP inválido" ValidationGroup="validateGroup" ControlToValidate="TextCEP" ValidationExpression="^(\d{5}-\d{3})|(\d{8})$"></asp:RegularExpressionValidator>
          <asp:RegularExpressionValidator ID="RegularExpressionValidator2" CssClass="compare" runat="server" Display="none" ErrorMessage="Número inválido" ValidationGroup="validateGroup" ControlToValidate="TextNumero" ValidationExpression="^\d+$"></asp:RegularExpressionValidator>
          <asp:RequiredFieldValidator ID="RequiredFieldValidator1" CssClass="compare" runat="server" Display="none" ErrorMessage="Nome não informado." ValidationGroup="validateGroup" ControlToValidate="TextPonto"></asp:RequiredFieldValidator>
          <asp:RequiredFieldValidator ID="RequiredFieldValidator9" CssClass="compare" runat="server" Display="none" ErrorMessage="Logradouro não informado." ValidationGroup="validateGroup" ControlToValidate="TextRua"></asp:RequiredFieldValidator>
          <asp:RequiredFieldValidator ID="RequiredFieldValidator10" CssClass="compare" runat="server" Display="none" ErrorMessage="Bairro não informado." ValidationGroup="validateGroup" ControlToValidate="TextBairro"></asp:RequiredFieldValidator>
          <asp:RequiredFieldValidator ID="RequiredFieldValidator11" CssClass="compare" runat="server" Display="none" ErrorMessage="CEP não informado." ValidationGroup="validateGroup" ControlToValidate="TextCEP"></asp:RequiredFieldValidator>
          <asp:RequiredFieldValidator ID="RequiredFieldValidator12" CssClass="compare" runat="server" Display="none" ErrorMessage="Município não informado." ValidationGroup="validateGroup" ControlToValidate="TextMunicipio"></asp:RequiredFieldValidator>
          <asp:RequiredFieldValidator ID="RequiredFieldValidator13" CssClass="compare" runat="server" Display="none" ErrorMessage="Número não informado." ValidationGroup="validateGroup" ControlToValidate="TextNumero"></asp:RequiredFieldValidator>
          <asp:ValidationSummary ID="ValidationSummary1" runat="server" ValidationGroup="validateGroup" ShowSummary="false" ShowMessageBox="true"/>
    </form>
</body>
</html>

