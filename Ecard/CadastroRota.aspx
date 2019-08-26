<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadastroRota.aspx.cs" Inherits="Ecardmark1.CadastroRota" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<script src="https://kit.fontawesome.com/4bb70b9eaa.js"></script>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<link rel="stylesheet" type="text/css" href="StyleRota.css"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="header">
               <a style="width:100px;" href="WebFormTelaPrincipalAdm.aspx"><img src="Imagens/ECard.png" style="width:100px;" /></a>
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
                    <div class="box1-button">
                        <asp:Button runat="server" CssClass="btnAdd" Text="Novo" PostBackUrl="~/CadastroRotaEdit.aspx" />
                    </div>
                </div>
                <div class="box1-body">
                     <div class="help">
                    <asp:Repeater ID="Repeater1" runat="server" DataSourceID="ObjectDataSource1">
                        <ItemTemplate>
                            <div class="rotaItem">
                                <div class="rotaItem-nome">
                                    <p class="rota-nome">07</p>
                                    <p class="rota-referencia">Alvorada IV / Cidade Jardim via Av. Paulistana</p>
                                </div>
                                <!--<div class="vl"></div> <!-- vertical line -->
                               <!-- <div class="rotaItem-bairro">
                                    <p class="rota-bairro-title">Ponto de Referência</p>
                                    <p>Alvorada IV / Cidade Jardim via Av. Paulistana</p>
                                </div>-->
                            </div> 
                        </ItemTemplate>
                    </asp:Repeater>

                         <asp:ObjectDataSource runat="server" ID="ObjectDataSource1" DataObjectTypeName="Ecardmark1.Modelo.Rota" DeleteMethod="Delete" InsertMethod="Insert" SelectMethod="SelectAll" TypeName="Ecardmark1.DAL.DALRota" UpdateMethod="Update"></asp:ObjectDataSource>
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
                        <i class="fas fa-search"></i>
                        <p>Pesquisar</p>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>

