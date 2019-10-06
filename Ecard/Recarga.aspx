<%@ Page Title="" Language="C#" MasterPageFile="~/Estudante.Master" AutoEventWireup="true" CodeBehind="Recarga.aspx.cs" Inherits="Ecard.Recarga" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="stylesheet" type="text/css" href="StyleRecarga.css"/>

     <div class="container">

            <div class="box1">
                <div class="box1-header">
                    <div class="box1-title">
                       <a class="ai" href="WebFormTelaPrincipalAdm.aspx"><i class="fas fa-arrow-left"></i></a>
                       <p>Realize sua recarga</p>
                    </div>
                </div>
                 <div class="hl-2"></div><!--  horizontal line -->
                <div class="var">
                <asp:Label ID="Label2" CssClass="text-var" runat="server" Text="R$ 4,00"></asp:Label>
                <div class="btns-2">
                    <asp:LinkButton ID="LinkButton2" cssClass="btn-soma" runat="server"><i class="fas fa-minus-circle"></i></asp:LinkButton>
                    <asp:LinkButton ID="LinkButton1" CssClass="btn-soma" runat="server"><i class="fas fa-plus-circle"></i></asp:LinkButton>
                </div>
                </div>
                <div class="forma">
                    <div class="pag">
                        <asp:Label ID="Label3" CssClass="text-pag" runat="server" Text="Realizar pagamento com :"></asp:Label>
                    </div>
                    <asp:DropDownList ID="DropDownList1" CssClass="drop" runat="server">
                         <asp:ListItem>Cartão de Crédito</asp:ListItem>
                         <asp:ListItem>Cartão de Débito</asp:ListItem>
                         <asp:ListItem>Boleto</asp:ListItem>
 
                    </asp:DropDownList>
                    <asp:Button ID="Button3" class="reca" runat="server" Text="Recarregar" />
                </div>
                <div class="forma-2">
                <div class="forma-3">
                    <div class="azul">
                    <asp:Label ID="Label4" runat="server" Text="Total:"></asp:Label>
                    </div>
                    <asp:Label ID="Label5" CssClass="campo-inf" runat="server" Text="R$ 9,43"></asp:Label>
                    </div>
                <div class="forma-4">
                    <div class="azul">
                    <asp:Label ID="Label6" runat="server" Text="Saldo de Recarga:"></asp:Label>
                    </div>
                    <asp:Label ID="Label7" CssClass="campo-inf" runat="server" Text="R$ 9,43"></asp:Label>
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
