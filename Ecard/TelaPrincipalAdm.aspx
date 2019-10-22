<%@ Page Title="" Language="C#" MasterPageFile="~/Administrador.Master" AutoEventWireup="true" CodeBehind="TelaPrincipalAdm.aspx.cs" Inherits="Ecard.TelaPrincipalAdm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="StyleTelaPrincipalAdm.css"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="box1">
                <div class="box1-header">
                    <div class="box1-title">
                       <i class="fas fa-bell"></i>
                       <p>Solicitações</p>
                    </div>
                    <div class="vdc">
                    <div class="box1-button">
                        <div class="conta">
                        <asp:Button runat="server" CssClass="btnAdd" Text="INSTITUIÇÃO" PostBackUrl="~/SolicitacaoInstituicao.aspx"  />
                        <asp:Label ID="Continstituicao" CssClass="cont" runat="server" Text="0"></asp:Label>
                        </div>
                        <div class="conta">
                       
                        <asp:Button runat="server" CssClass="btnAdd" Text=" CARTEIRA" PostBackUrl="~/SolicitacaoCarteira.aspx" />
                        <asp:Label ID="ContCarteira" CssClass="cont" runat="server" Text="0" ></asp:Label>
                     </div>
                    </div>
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
</asp:Content>
