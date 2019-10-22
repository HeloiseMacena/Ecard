

<%@ Page Language="C#" AutoEventWireup="true" MaintainScrollPositionOnPostback="true" CodeBehind="CadastroRotaEdit.aspx.cs" Inherits="Ecard.CadastroRotaEdit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<script src="https://kit.fontawesome.com/4bb70b9eaa.js"></script>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<link rel="stylesheet" type="text/css" href="StyleCadastroRota.css"/>
    <script src="https://code.jquery.com/jquery-3.4.1.min.js"></script>
    <script src="JS/Events.js"></script>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="header max">
            <a style="width:100px;" href="TelaPrincipalAdm.aspx"><img src="Imagens/ECard.png" style="width:100px;" /></a>
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
                       <i class="fas fa-map-marker-alt"></i>
                       <p>Rotas</p>
                    </div>
                </div>
                <div class="box1-midi">
                      <h1>Cadastro</h1>
                      <asp:TextBox ID="TextBoxNome" runat="server" CssClass="box1-mid" placeholder="Nome"></asp:TextBox>   
                    <div class="org-1">
                        <div class="org-2">
                        <asp:Label ID="Label1" CssClass="label" runat="server" Text="Bairros"></asp:Label>
                        <asp:CheckBoxList ID="CheckBoxListBairro" CssClass="check" runat="server"></asp:CheckBoxList>
                        <!-- <asp:TextBox ID="TextBoxBairro" runat="server" CssClass="box1-mid-1" placeholder="Bairro"></asp:TextBox> -->
                        </div>
                        <div class="org-3">                    
                        <asp:Label ID="Label2" CssClass="label" runat="server" Text="Pontos de referência"></asp:Label>
                        <asp:CheckBoxList ID="CheckBoxListReferencia"  CssClass="check" runat="server"></asp:CheckBoxList>
                        <!--<asp:TextBox ID="TextBoxReferencia" runat="server" CssClass="box1-mid-1" placeholder="Ponto de Referência"></asp:TextBox> -->
                    </div>
                    </div>
                    <div class="btn-b2">
                        <asp:Button class="btn-close" runat="server" Text="Fechar" PostBackUrl="~/CadastroRota.aspx" />
                        <asp:Button class="btn-save" runat="server" Text="Salvar" OnClick="Unnamed2_Click" ValidationGroup="validateGroup"/>

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
    </form>
</body>
</html>
