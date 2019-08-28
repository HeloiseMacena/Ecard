<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditarRota.aspx.cs" Inherits="Ecardmark1.EditarRota" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<script src="https://kit.fontawesome.com/4bb70b9eaa.js"></script>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<link rel="stylesheet" type="text/css" href="StyleEditarPonto.css"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="header">
             <a style="width:100px;" href="WebFormTelaPrincipalAdm.aspx"><img src="Imagens/ECard.png" style="width:100px;" /></a><br />
&nbsp;<ol>
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
                       <i class="fas fa-map-marked-alt"></i>
                       <p>Rotas de Ônibus</p>
                    </div>
                </div>
                <div class="box1-midi">
                      <h1>Editar</h1>
                      <asp:TextBox ID="TextBox1" runat="server" CssClass="box1-mid" placeholder="Nome"></asp:TextBox>
                      <asp:TextBox ID="TextBox2" runat="server" CssClass="box1-mid" placeholder="Rua"></asp:TextBox>
                      <asp:TextBox ID="TextBox3" runat="server" CssClass="box1-mid" placeholder="Bairro"></asp:TextBox>
                      <asp:TextBox ID="TextBox4" runat="server" CssClass="box1-mid" placeholder="Ponto de Referência"></asp:TextBox>
                    <div class="btn-b2">
                        <asp:Button class="btn-close" runat="server" Text="Excluir"  />
                        <asp:Button class="btn-save" runat="server" Text="Atualizar" />
                    </div>  
                   
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

                <div class="box2-rota">
                    <div class="rota">
                        <p>Rotas de Ônibus</p>
                    </div>
                    <div class="rota2">
                        <i runat="server" id="iconTeste" class="fas fa-search"></i>
                        <p>Pesquisar</p>
                    </div>
                </div>
            </div>
    </form>
</body>
</html>
