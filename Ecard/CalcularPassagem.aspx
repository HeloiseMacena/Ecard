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
                <asp:DropDownList id="tipoPreco" CssClass="ddlist1" runat="server" OnSelectedIndexChanged="Unnamed3_Click">
                    <asp:ListItem Value="Natal">Passagem de Natal</asp:ListItem>
                    <asp:ListItem Value="Parnamirim">Passagem de Parnamirim</asp:ListItem>
                    <asp:ListItem Value="Extremoz">Passagem de Extremoz</asp:ListItem>
                    <asp:ListItem Value="Ceará">Passagem de Ceará Mirim</asp:ListItem>
                    <asp:ListItem Value="Amarante">Passagem de São Gonçalo do Amarante</asp:ListItem>
                </asp:DropDownList>
                <div class="valores">
                    <div class="campos">
                        <asp:Label id="Label2" CssClass="text-var" runat="server" Text="R$4,20"></asp:Label>
                        <asp:TextBox ID="TextBoxRecarga" CssClass="campo-qntPas" placeholder="0" runat="server"></asp:TextBox> 
                    </div>
                    <div class="campos">
                        <asp:Label id="Label3" CssClass="text-var" runat="server" Text="R$6,30"></asp:Label>
                        <asp:TextBox ID="TextBox1" CssClass="campo-qntPas" placeholder="0" runat="server"></asp:TextBox> 
                    </div>
                    <div class="campos">
                        <asp:Label id="Label4" CssClass="text-var" runat="server" Text="Dias"></asp:Label>
                        <asp:TextBox ID="TextBox2" CssClass="campo-qntDia" placeholder="0" runat="server"></asp:TextBox>                    
                    </div>
                </div>
                <div class="resultados">
                    <div class="resul">
                        <div class="campo">
                            <div Class="text-varbox"><asp:Label id="Label5" runat="server" Text="Sobra"></asp:Label></div>
                            <asp:Label ID="ResulSobra" CssClass="campo-resul" text="R$ 0,00" runat="server"></asp:Label>    
                        </div>
                        <div class="campo-2">
                            <div Class="text-varbox"><asp:Label id="Label6" runat="server" Text="Falta"></asp:Label></div>
                            <asp:Label ID="ResulFalta" CssClass="campo-resul" text="R$ 0,00" runat="server"></asp:Label>    
                        </div>
                    </div>
                    <div class="resul-2">
                        <div class="campo">
                            <div Class="text-varbox"><asp:Label id="Label7" runat="server" Text="Saldo"></asp:Label></div>
                            <asp:Label ID="Label8" CssClass="campo-resul" text="R$ 0,00" runat="server"></asp:Label>    
                        </div>
                        <div class="campo-2">
                            <div Class="text-varbox"><asp:Label id="Label9" runat="server" Text="Total"></asp:Label></div>
                            <asp:Label ID="Label10" CssClass="campo-resul" text="R$ 0,00" runat="server"></asp:Label>    
                        </div>
                    </div>
                </div>
                <asp:Button ID="ButtonCalc" class="calc-result" runat="server" Text="Calcular" />
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
                    <asp:Button class="btn-rec" runat="server" Text="Recarregar" PostBackUrl="~/Recarga.aspx" OnClick="Unnamed3_Click" />
                    <asp:Button class="btn-calc" runat="server" Text="Calcular Passagens"  />
                </div>
            </div>
        </div>
    </div>           
</asp:Content>
