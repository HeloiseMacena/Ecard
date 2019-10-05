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
                     <div class="info-2">
                        <asp:Label ID="Label5" CssClass="azul-2" runat="server" Text="RG"></asp:Label>
                        <asp:Label ID="Label6" CssClass="campo-inf-2" runat="server" Text="123.456.789"></asp:Label>
                    </div>
                     <div class="info-2">
                        <asp:Label ID="Label7" CssClass="azul-3" runat="server" Text="CPF"></asp:Label>
                        <asp:Label ID="Label8" CssClass="campo-inf-3" runat="server" Text="123.456.789-11 "></asp:Label>
                    </div>
                     <div class="info-2">
                        <asp:Label ID="Label9" CssClass="azul-4" runat="server" Text="Nascimento"></asp:Label>
                        <asp:Label ID="Label10" CssClass="campo-inf-4" runat="server" Text="01/01/2001"></asp:Label>
                    </div>
                     <div class="info-2">
                        <asp:Label ID="Label11" CssClass="azul-5" runat="server" Text="Instituição"></asp:Label>
                        <asp:Label ID="Label12" CssClass="campo-inf-5" runat="server" Text="IFRN "></asp:Label>
                    </div>
                    <div class="image-1" ><img src="Imagens/fotocarteira.png"  style="max-width:100%;"/></div>
                    <div class="photo">
                        <asp:FileUpload ID="FileUpload1" runat="server" class="multi"  AllowMultiple="true"/>
                        <asp:Label ID="Status" runat="server" Text="Upload"></asp:Label>
                        <asp:Button ID="btnUpload" runat="server" Text="Carregar Fotos" onclick="btnUpload_Click" BackColor="#CC0000" BorderColor="#CC0000" Font-Bold="True" ForeColor="White" />
                        <asp:Image runat="server" ID="userImage" Height="100"  />
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
