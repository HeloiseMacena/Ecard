<%@ Page Title="" Language="C#" MasterPageFile="~/Estudante.Master" AutoEventWireup="true" CodeBehind="CalcularPassagem.aspx.cs" Inherits="Ecard.CalcularPassagem" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="stylesheet" type="text/css" href="StyleCalcularPassagem.css"/>
    <div class="container">
        <div class="box1">
            <div class="box1-header">
                <div class="box1-title">
                    <a class="ai" href="TelaPrincipalEstudante.aspx"><i class="fas fa-arrow-left"></i></a>
                    <p>Calcule suas passagens</p>
                </div>
            </div>
            <div class="hl-2"></div><!--  horizontal line -->
            <div class="pesq">
                <asp:DropDownList CssClass="ddlist1" runat="server">
                    <asp:ListItem>Passagem de Natal</asp:ListItem>
                    <asp:ListItem>Passagem de Parnamirim</asp:ListItem>
                    <asp:ListItem>Passagem de Extremoz</asp:ListItem>
                    <asp:ListItem>Passagem de Ceará Mirim</asp:ListItem>
                    <asp:ListItem>Passagem de São Gonçalo do Amarante</asp:ListItem>
                </asp:DropDownList>
                <div class="valores">
                    <div class="campo1">
                        <asp:Label ID="Label4" CssClass="text-var" runat="server" Text="R$4,20"></asp:Label>
                        <div class="btns-2">
                            <asp:LinkButton ID="LinkButton2" cssClass="btn-soma" runat="server"><i class="fas fa-minus-circle"></i></asp:LinkButton>
                            <asp:LinkButton ID="LinkButton1" CssClass="btn-soma" runat="server"><i class="fas fa-plus-circle"></i></asp:LinkButton>
                        </div>
                    </div>
                    <div class="campo2">
                        <asp:Label ID="Label6" CssClass="text-var" runat="server" Text="R$6,30"></asp:Label>
                        <div class="val">
                            <asp:Label ID="Label2" CssClass="txt-val" runat="server" Text="1"></asp:Label>
                        </div>    
                        <div class="btns-2">
                            <asp:LinkButton ID="LinkButton3" cssClass="btn-soma" runat="server"><i class="fas fa-minus-circle"></i></asp:LinkButton>
                            <asp:LinkButton ID="LinkButton4" CssClass="btn-soma" runat="server"><i class="fas fa-plus-circle"></i></asp:LinkButton>
                        </div>
                    </div>
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
    </div>           
</asp:Content>
