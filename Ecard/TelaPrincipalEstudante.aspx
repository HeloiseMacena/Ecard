<%@ Page Title="" Language="C#" MasterPageFile="~/Estudante.Master" AutoEventWireup="true" CodeBehind="TelaPrincipalEstudante.aspx.cs" Inherits="Ecard.TelaPrincipalEstudante" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="stylesheet" type="text/css" href="StyleTelaPrincipalEstudante.css"/>
    <div class="container">
            <div class="box1">              
               <div class="princi">
                   <div class="princi-icon">
                        <div class="org"><i class="fas fa-calculator"></i> <asp:HyperLink CssClass="org-p" runat="server" NavigateUrl="~/CalcularPassagem.aspx" >Calcular Passagem</asp:HyperLink></div>
                        <div class="org"><i class="fas fa-map-marker-alt"></i><asp:HyperLink CssClass="org-p" runat="server" NavigateUrl="~/PesquisarRota.aspx">Pesquisar rotas de ônibus</asp:HyperLink></div>
                        <div class="org"><i class="fas fa-map-marked-alt"></i><asp:HyperLink CssClass="org-p" runat="server" NavigateUrl="~/ConsultaPontodeRecarga.aspx">Pesquisar pontos de recarga</asp:HyperLink></div>
                   </div>  
              </div>
            </div>

            <div class="box2">
                <div class="box2-user-container">
                    <div class="box2-user">
                         <i class="fas fa-user-circle"></i>
                         <div class="user-name"> 
                            <h1>Dara Hadrielle</h1>
                            <p>Estudante</p>
                        </div>
                    </div>
                    <div class="box2-button">
                         <asp:Button runat="server" CssClass="btn2"  Text="Ver Perfil" PostBackUrl="~/PerfilEstudante.aspx"/>
                    </div>
                </div>

                <div class="box2-ponto">
                    <div class="ponto">
                        <p>Seu Saldo</p>
                    </div>
                     <div class="hl"></div> <!--  horizontal line -->
                    <asp:Label ID="Label1" CssClass="title-money" runat="server" Text="R$ 9,58"></asp:Label>
                    <div class="btns">
                         <asp:Button class="btn-rec" runat="server" Text="Recarregar" PostBackUrl="~/Recarga.aspx"/>
                        <asp:Button class="btn-calc" runat="server" Text="Calcular Passagens" PostBackUrl="~/CalcularPassagem.aspx"/>
                    </div>
                </div>

                <div class="box2-card">
                    <div class="card">
                         <i class="fas fa-address-card"></i>
                         <div class="info"> 
                            <p>GARANTA SUA NOVA CARTEIRA!</p>
                        </div>
                    </div>
                    <div class="btn">
                         <asp:Button runat="server" CssClass="btn1"  Text="Adquirir" PostBackUrl="~/TelaSolicitacaoCarteira.aspx" />
                    </div>
                </div>
            </div>           
        </div>
</asp:Content>
