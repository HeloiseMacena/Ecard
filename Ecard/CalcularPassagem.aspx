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
                <asp:DropDownList id="tipoPreco" CssClass="ddlist1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="tipoPreco_SelectedIndexChanged">
                    <asp:ListItem Value="Natal">Passagem de Natal</asp:ListItem>
                    <asp:ListItem Value="Parnamirim">Passagem de Parnamirim</asp:ListItem>
                    <asp:ListItem Value="Extremoz">Passagem de Extremoz</asp:ListItem>
                    <asp:ListItem Value="Ceará">Passagem de Ceará Mirim</asp:ListItem>
                    <asp:ListItem Value="Amarante">Passagem de São Gonçalo do Amarante</asp:ListItem>
                </asp:DropDownList>
                <div class="valores">
                    <div class="campos">
                        <asp:Label id="Label2" CssClass="text-var" runat="server" Text="R$ 4,20"></asp:Label>
                        <asp:TextBox ID="TextBoxRecarga" Enabled="true" CssClass="campo-qntPas" placeholder="0" runat="server"></asp:TextBox> 
                    </div>
                    <div class="campos">
                        <asp:Label id="Label3" CssClass="text-var" runat="server" Text="R$ 6,30"></asp:Label>
                        <asp:TextBox ID="TextBoxRecarga1" Enabled="true" CssClass="campo-qntPas" placeholder="0" runat="server"></asp:TextBox> 
                    </div>
                    <div class="campos">
                        <asp:Label id="Label4" CssClass="text-var" runat="server" Text="Dias"></asp:Label>
                        <asp:TextBox ID="TextBox2" Enabled="true" CssClass="campo-qntDia" placeholder="0" runat="server" style="margin-left: 24px;"></asp:TextBox>                    
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
                <asp:Button ID="ButtonCalc" class="calc-result" runat="server" Text="Calcular" OnClick="ButtonCalc_Click" ValidationGroup="validateGroup"/>
            </div>
        </div>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" CssClass="compare" runat="server" Display="none" ErrorMessage="Valor inválido" ValidationGroup="validateGroup" ControlToValidate="TextBoxRecarga" ValidationExpression="^\d+$"></asp:RegularExpressionValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" CssClass="compare" runat="server" Display="none" ErrorMessage="Valor inválido" ValidationGroup="validateGroup" ControlToValidate="TextBoxRecarga1" ValidationExpression="^\d+$"></asp:RegularExpressionValidator>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" CssClass="compare" runat="server" Display="none" ErrorMessage="Quantidade de dias não informado não informado." ValidationGroup="validateGroup" ControlToValidate="TextBox2"></asp:RequiredFieldValidator>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ValidationGroup="validateGroup" ShowSummary="false" ShowMessageBox="true"/>
    </div>           
</asp:Content>
