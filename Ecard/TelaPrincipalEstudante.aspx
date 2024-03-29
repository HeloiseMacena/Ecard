﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Estudante.Master" AutoEventWireup="true" CodeBehind="TelaPrincipalEstudante.aspx.cs" Inherits="Ecard.TelaPrincipalEstudante" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="stylesheet" type="text/css" href="StyleTelaPrincipalEstudante.css"/>
    <div class="container">
            <div class="box1"> 
                <div class="al">
                    <asp:Label ID="welcome" runat="server" class="neutro" Text=""></asp:Label>
                    <asp:Label ID="solicitado" runat="server" class="statusAviso" Text=""></asp:Label>
                    <asp:Label ID="deferido" runat="server" CssClass="statusAprov" Text=""></asp:Label>
                    <asp:Label ID="indeferido" runat="server" CssClass="statusIndeferido" Text=""></asp:Label>
                </div>
               <div class="princi">
                   <div class="princi-icon">
                        <div class="org-1"><i class="fas fa-calculator"></i> <asp:HyperLink CssClass="org" runat="server" NavigateUrl="~/CalcularPassagem.aspx" >Calcular Passagem</asp:HyperLink></div>
                        <div class="org-2"><i class="fas fa-map-marker-alt"></i><asp:HyperLink CssClass="org" runat="server" NavigateUrl="~/PesquisarRota.aspx">Pesquisar rotas de ônibus</asp:HyperLink></div>
                        <div class="org-3"><i class="fas fa-map-marked-alt"></i><asp:HyperLink CssClass="org" runat="server" NavigateUrl="~/ConsultaPontodeRecarga.aspx">Pesquisar pontos de recarga</asp:HyperLink></div>
                       <div class="org-3"><i class="fas fa-hourglass-half"></i><asp:HyperLink CssClass="org1" runat="server" NavigateUrl="~/Extratorecarga.aspx">Consultar Extrato de Recargas</asp:HyperLink></div>
                   </div>  
              </div>
            </div>
        </div>
</asp:Content>
