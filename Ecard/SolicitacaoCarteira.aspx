<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SolicitacaoCarteira.aspx.cs" Inherits="Ecard.SolicitacaoEstudante" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<link rel="stylesheet" type="text/css" href="StyleSolicitacaoCarteira.css"/>    
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
                <div class="box1-pesquisa">
                    <asp:TextBox ID="TextPesquisa" CssClass="textbox1" runat="server" type="text" placeholder="Pesquisar"></asp:TextBox>                </div>
                <div class="box1-filtro">
                    <asp:ListBox ID="Filtrar" CssClass="listbox1" text="Filtrar por..." runat="server">
                        <asp:ListItem>Escola</asp:ListItem>
                        <asp:ListItem>Ordem alfabética</asp:ListItem>
                        <asp:ListItem>Mais recente</asp:ListItem>
                        <asp:ListItem>Mais antiga</asp:ListItem>
                    </asp:ListBox>
                    <asp:Button runat="server" CssClass="btn-ok" Text="Ok"/>
                </div>
                <div class="box1-midi">
                </div>
            </div>

            <div class="box2">
                <div class="box2-user-container">
                    <div class="box2-user">
                         <i class="fas fa-user-circle"></i>
                         <div class="user-name"> 
                            <h1>User</h1>
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
