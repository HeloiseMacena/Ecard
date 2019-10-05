<%@ Page Language="C#" AutoEventWireup="true" MaintainScrollPositionOnPostback="true" CodeBehind="CadastroRotaEdit.aspx.cs" Inherits="Ecard.CadastroRotaEdit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<script src="https://kit.fontawesome.com/4bb70b9eaa.js"></script>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<link rel="stylesheet" type="text/css" href="StyleCadastroRota.css"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="header">
            <img src="Imagens/ECard.png" />
            <ol>
                <li>Menu</li>
                <li>Page 2</li>
                <li>Page 3</li>
                <li>Page 4</li> 
                <li class="menu-user">Daniel Victor</li>
            </ol>
        </div>
        <div class="container">
            <div class="box1">
                <div class="box1-header">
                    <div class="box1-title">
                       <i class="fas fa-map-marker-alt"></i>
                       <p>Rotas</p>
                    </div>
                </div>
                <div class="box1-midi">
                      <h1>Cadastro</h1>
                      <asp:TextBox ID="TextBoxNome" runat="server" CssClass="box1-mid" placeholder="Nome"></asp:TextBox>   
                    <div class="org-1">
                        <asp:DropDownList ID="DropDownBairro" runat="server"></asp:DropDownList>
                        <!-- <asp:TextBox ID="TextBoxBairro" runat="server" CssClass="box1-mid-1" placeholder="Bairro"></asp:TextBox> -->
                        <asp:Button ID="Button11" class="btn-add-1" runat="server" Text="Adicionar" PostBackUrl="~/CadastroBairroEdit.aspx"/>
                    </div> 
                    <div class="org-1">
                        <asp:DropDownList ID="DropDownReferencia" runat="server"></asp:DropDownList>
                        <!--<asp:TextBox ID="TextBoxReferencia" runat="server" CssClass="box1-mid-1" placeholder="Ponto de Referência"></asp:TextBox> -->
                        <asp:Button ID="Button22" class="btn-add-1" runat="server" Text="Adicionar" PostBackUrl="~/CadastroPontoReferenciaEdit.aspx"/>
                    </div>
                    <div class="btn-b2">
                        <asp:Button class="btn-close" runat="server" Text="Fechar" PostBackUrl="~/CadastroRota.aspx" />
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

                <div class="box2-rotas">
                    <div class="rotas">
                        <p>Rotas</p>
                    </div>
                    <div class="rotas2">
                        <i runat="server" id="iconTeste" class="fas fa-search"></i>
                        <p>Pesquisar</p>
                    </div>
                </div>
            </div>
          </div>
    </form>
</body>
</html>
