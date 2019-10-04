<%@ Page Title="" Language="C#" MasterPageFile="~/Estudante.Master" AutoEventWireup="true" CodeBehind="TelaSolicitacaoCarteira.aspx.cs" Inherits="Ecard.TelaSolicitacaoCarteira" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <link rel="stylesheet" type="text/css" href="StyleTelaSolicitacaoCarteira.css"/>

     <div class="container">

            <div class="box1">
                <div class="box1-header">
                    <div class="box1-title">
                       <a class="ai" href="WebFormTelaPrincipalAdm.aspx"><i class="fas fa-arrow-left"></i></a>
                       <p>Solicite sua carteira</p>
                    </div>
                    <div class="box1-button">
                        <asp:Button runat="server" CssClass="btnAdd" Text="R$ 25,00" PostBackUrl="~/CadastroBairroEdit.aspx" />
                    </div>
                </div>  
                <div class="info">
                    <div class="title-info">
                        <asp:Label ID="Label2" cssClass="info-cor" runat="server" Text="Se os dados abaixo estiverem INCORRETOS, procure a sua ESCOLA e solicite atualização de dados antes de solicitar!"></asp:Label>
                    </div>
                    <div class="info-2">
                        <asp:Label ID="Label3" CssClass="azul" runat="server" Text="Nome"></asp:Label>
                        <asp:Label ID="Label4" CssClass="campo-inf" runat="server" Text="Dara Hadrielle da Cunha Rocha "></asp:Label>
                    </div>
                </div>
              </div>
            <div class="box2">
                <div class="box2-user-container">
                    <div class="box2-user">
                         <i class="fas fa-user-circle"></i>
                         <div class="user-name"> 
                            <h1>User</h1>
                            <p>Estudante</p>
                        </div>
                    </div>
                    <div class="box2-button">
                         <asp:Button runat="server" CssClass="btn2" Text="Ver Perfil" />
                    </div>
                </div>

                <div class="box2-ponto">
                    <div class="ponto">
                        <p>Seu Saldo</p>
                    </div>
                     <div class="hl"></div> <!--  horizontal line -->
                    <asp:Label ID="Label1" CssClass="title-money" runat="server" Text="R$ 9,58"></asp:Label>
                    <div class="btns">
                         <asp:Button class="btn-rec" runat="server" Text="Recarregar" />
                        <asp:Button class="btn-calc" runat="server" Text="Calcular Passagens"  />
                    </div>
                </div>
            </div>
            <div>  
                </div>
           </div>
</asp:Content>
