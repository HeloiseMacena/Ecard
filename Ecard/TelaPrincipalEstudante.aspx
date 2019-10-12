<%@ Page Title="" Language="C#" MasterPageFile="~/Estudante.Master" AutoEventWireup="true" CodeBehind="TelaPrincipalEstudante.aspx.cs" Inherits="Ecard.TelaPrincipalEstudante" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="stylesheet" type="text/css" href="StyleTelaPrincipalEstudante.css"/>
    <div class="container">
            <div class="box1">              
               <div class="princi">
                   <div class="princi-icon">
                        <div class="org-1"><i class="fas fa-calculator"></i> <asp:HyperLink CssClass="org" runat="server" NavigateUrl="~/CalcularPassagem.aspx" >Calcular Passagem</asp:HyperLink></div>
                        <div class="org-2"><i class="fas fa-map-marker-alt"></i><asp:HyperLink CssClass="org" runat="server" NavigateUrl="~/PesquisarRota.aspx">Pesquisar rotas de ônibus</asp:HyperLink></div>
                        <div class="org-3"><i class="fas fa-map-marked-alt"></i><asp:HyperLink CssClass="org" runat="server" NavigateUrl="~/ConsultaPontodeRecarga.aspx">Pesquisar pontos de recarga</asp:HyperLink></div>
                   </div>  
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


</asp:Content>
