<%@ Page Title="" Language="C#" MasterPageFile="~/Administrador.Master" AutoEventWireup="true" CodeBehind="CadastroPassagem.aspx.cs" Inherits="Ecard.CadastroPassagem" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="StyleCadastroPassagem.css"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="box1">
                <div class="box1-header">
                    <div class="box1-title">
                      <i class="fas fa-calculator"></i>
                       <p>Cadastro de passagem</p>
                    </div>
                </div>
                <div class="box1-midi">
                    <div class="space">
                    <asp:Label ID="Label5" runat="server" class="text-p" Text="Passagem de Ceará Mirim"></asp:Label>
                    <asp:TextBox ID="TextBox1" CssClass="box1-mid" runat="server"></asp:TextBox>
                    </div>
                    <div class="space">
                    <asp:Label ID="Label1" runat="server" class="text-p" Text="Passagem de Extremoz"></asp:Label>
                    <asp:TextBox ID="TextBox2" CssClass="box1-mid" runat="server"></asp:TextBox>
                    </div>
                    <div class="space">
                    <asp:Label ID="Label2" runat="server" class="text-p" Text="Passagem de Natal"></asp:Label>
                    <asp:TextBox ID="TextBox3" CssClass="box1-mid"  runat="server"></asp:TextBox>
                    </div>
                    <div class="space">
                    <asp:Label ID="Label3" runat="server" class="text-p" Text="Passagem de Parnamirim"></asp:Label>
                    <asp:TextBox ID="TextBox4" CssClass="box1-mid"  runat="server"></asp:TextBox>
                    </div>
                    <div class="space">
                    <asp:Label ID="Label4" runat="server" class="text-p" Text="Passagem de São Gonçalo do Amarante"></asp:Label>
                    <asp:TextBox ID="TextBox5" CssClass="box1-mid"  runat="server"></asp:TextBox>
                    </div>
                    <div class="btn-b2">
                        <asp:Button class="btn-close" runat="server" Text="Fechar" PostBackUrl="~/TelaPrincipalAdm.aspx" />
                        <asp:Button class="btn-save" runat="server" Text="Salvar" OnClick="Unnamed2_Click" ValidationGroup="validateGroup"/>
                    </div>
                </div>
    </div>
                      <asp:RegularExpressionValidator ID="RegularExpressionValidator1" CssClass="compare" runat="server" Display="none" ErrorMessage="Valor para Ceará Mirim é inválido" ValidationGroup="validateGroup" ControlToValidate="TextBox1" ValidationExpression="^(\d+(\,\d\d)?)$"></asp:RegularExpressionValidator>
                      <asp:RegularExpressionValidator ID="RegularExpressionValidator2" CssClass="compare" runat="server" Display="none" ErrorMessage="Valor para Extremoz é inválido" ValidationGroup="validateGroup" ControlToValidate="TextBox2" ValidationExpression="^(\d+(\,\d\d)?)$"></asp:RegularExpressionValidator>
                      <asp:RegularExpressionValidator ID="RegularExpressionValidator3" CssClass="compare" runat="server" Display="none" ErrorMessage="Valor para Natal é inválido" ValidationGroup="validateGroup" ControlToValidate="TextBox3" ValidationExpression="^(\d+(\,\d\d)?)$"></asp:RegularExpressionValidator>
                      <asp:RegularExpressionValidator ID="RegularExpressionValidator4" CssClass="compare" runat="server" Display="none" ErrorMessage="Valor para Parnamirim é inválido" ValidationGroup="validateGroup" ControlToValidate="TextBox4" ValidationExpression="^(\d+(\,\d\d)?)$"></asp:RegularExpressionValidator>
                      <asp:RegularExpressionValidator ID="RegularExpressionValidator5" CssClass="compare" runat="server" Display="none" ErrorMessage="Valor para São Gonçalo é inválido" ValidationGroup="validateGroup" ControlToValidate="TextBox5" ValidationExpression="^(\d+(\,\d\d)?)$"></asp:RegularExpressionValidator>
                      <asp:RequiredFieldValidator ID="RequiredFieldValidator1" CssClass="compare" runat="server" Display="none" ErrorMessage="Passagem de Ceará Mirim não informada." ValidationGroup="validateGroup" ControlToValidate="TextBox1"></asp:RequiredFieldValidator>
                      <asp:RequiredFieldValidator ID="RequiredFieldValidator2" CssClass="compare" runat="server" Display="none" ErrorMessage="Passagem de Extremoz não informada." ValidationGroup="validateGroup" ControlToValidate="TextBox2"></asp:RequiredFieldValidator>
                      <asp:RequiredFieldValidator ID="RequiredFieldValidator3" CssClass="compare" runat="server" Display="none" ErrorMessage="Passagem de Natal não informada." ValidationGroup="validateGroup" ControlToValidate="TextBox3"></asp:RequiredFieldValidator>
                      <asp:RequiredFieldValidator ID="RequiredFieldValidator4" CssClass="compare" runat="server" Display="none" ErrorMessage="Passagem de Parnamirim não informada." ValidationGroup="validateGroup" ControlToValidate="TextBox4"></asp:RequiredFieldValidator>
                      <asp:RequiredFieldValidator ID="RequiredFieldValidator5" CssClass="compare" runat="server" Display="none" ErrorMessage="Passagem de São Gonçalo não informada." ValidationGroup="validateGroup" ControlToValidate="TextBox5"></asp:RequiredFieldValidator>
                      <asp:ValidationSummary ID="ValidationSummary1" runat="server" ValidationGroup="validateGroup" ShowSummary="false" ShowMessageBox="true"/>
    </form>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
