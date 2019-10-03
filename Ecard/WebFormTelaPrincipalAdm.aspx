<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormTelaPrincipalAdm.aspx.cs" Inherits="Ecard.WebFormTelaPrincipalAdm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<script src="https://kit.fontawesome.com/4bb70b9eaa.js"></script>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<link rel="stylesheet" type="text/css" href="StyleTelaPrincipalAdm.css"/>
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
                       <i class="fas fa-bell"></i>
                       <p>Solicitações</p>
                    </div>
                    <div class="box1-button">
                        <asp:Button runat="server" CssClass="btnAdd" Text="INSTITUIÇÃO" PostBackUrl="~/SolicitacaoInstituicao.aspx"  />
                        <asp:Button runat="server" CssClass="btnAdd" Text=" CARTEIRA" PostBackUrl="~/SolicitacaoCarteira.aspx" />
                    </div>
               </div>
               <div class="princi">
                   <div class="princi-icon">
                        <div class="org-1"><i class="fas fa-calculator"></i> <asp:HyperLink CssClass="org-p1" runat="server" NavigateUrl="~/CadastroPassagem.aspx" >Cadastrar valor da passagem</asp:HyperLink></div>
                        <div class="org-2"><i class="fas fa-map-marker-alt"></i><asp:HyperLink CssClass="org-p2" runat="server" NavigateUrl="~/CadastroRota.aspx">Cadastrar rotas de ônibus</asp:HyperLink></div>
                        <div class="org-3"><i class="fas fa-map-marked-alt"></i><asp:HyperLink CssClass="p3" runat="server" NavigateUrl="~/CadastroPonto.aspx">Cadastrar pontos de recarga</asp:HyperLink></div>
                        <div class="org-3"><i class="fas fa-map-marked-alt"></i><asp:HyperLink CssClass="p3" runat="server" NavigateUrl="~/CadastroBairro.aspx">Cadastrar bairros</asp:HyperLink></div> 
                        <div class="org-3"><i class="fas fa-map-marked-alt"></i><asp:HyperLink CssClass="p3" runat="server" NavigateUrl="~/CadastroPontoReferencia.aspx">Cadastrar pontos de referência</asp:HyperLink></div> 
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
                         <asp:Button runat="server" CssClass="btn2"  Text="Ver Perfil" PostBackUrl="~/PerfilAdm.aspx" />
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
