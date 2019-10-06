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
            <div class="pesq-2">
                <asp:DropDownList CssClass="ddlist1" runat="server">
                    <asp:ListItem>Natal</asp:ListItem>
                    <asp:ListItem>Parnamirim</asp:ListItem>
                    <asp:ListItem>Extremoz</asp:ListItem>
                    <asp:ListItem>Ceará Mirim</asp:ListItem>
                    <asp:ListItem>São Gonçalo do Amarante</asp:ListItem>
                </asp:DropDownList>
                <div class="valores">                   
                    <asp:TextBox ID="TextBox4" CssClass="box1-mid" placeholder="Dias" runat="server"></asp:TextBox>                   

                    <asp:Label ID="Label3" runat="server" class="text-p" Text="Sobra/Falta:"></asp:Label>
                    <asp:TextBox ID="TextBox3" CssClass="box1-mid" placeholder="R$ 9,43" runat="server"></asp:TextBox>                   
                    
                    <asp:Label ID="Label2" runat="server" class="text-p" Text="Saldo Atual:"></asp:Label>
                    <asp:TextBox ID="TextBox2" CssClass="box1-mid" placeholder="R$ 9,43" runat="server"></asp:TextBox>                   

                    <asp:Label ID="Label5" runat="server" class="text-p" Text="Total:"></asp:Label>
                    <asp:TextBox ID="TextBox1" CssClass="box1-mid" placeholder="R$ 9,43" runat="server"></asp:TextBox>                   
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
