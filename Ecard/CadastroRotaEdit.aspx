<%@ Page Title="" Language="C#" MasterPageFile="~/Administrador.Master" AutoEventWireup="true" CodeBehind="CadastroRotaEdit.aspx.cs" Inherits="Ecard.CadastroRotaEdit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="StyleCadastroRota.css"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="box1">
                <div class="box1-header">
                    <div class="box1-title">
                       <i class="fas fa-map-marker-alt"></i>
                       <p>Rotas</p>
                    </div>
                </div>
                <div class="box1-midi">
                      <h1>Cadastro</h1>
                      <asp:TextBox ID="TextBoxNome" runat="server" CssClass="box1-mid" placeholder="Nome"></asp:TextBox>   
                    <div class="org-1">
                        <div class="org-2">
                        <asp:Label ID="Label1" CssClass="label" runat="server" Text="Bairros"></asp:Label>
                        <asp:CheckBoxList ID="CheckBoxListBairro" CssClass="check" runat="server" CausesValidation="true" ValidationGroup="validateGroup"></asp:CheckBoxList>
                        <!-- <asp:TextBox ID="TextBoxBairro" runat="server" CssClass="box1-mid-1" placeholder="Bairro"></asp:TextBox> -->
                        </div>
                        <div class="org-3">                    
                        <asp:Label ID="Label2" CssClass="label" runat="server" Text="Pontos de referência"></asp:Label>
                        <asp:CheckBoxList ID="CheckBoxListReferencia"  CssClass="check" runat="server" CausesValidation="true" ValidationGroup="validateGroup"></asp:CheckBoxList>
                        <!--<asp:TextBox ID="TextBoxReferencia" runat="server" CssClass="box1-mid-1" placeholder="Ponto de Referência"></asp:TextBox> -->
                    </div>
                    </div>
                    <div class="btn-b2">
                        <asp:Button class="btn-close" runat="server" Text="Fechar" PostBackUrl="~/CadastroRota.aspx" />
                        <asp:Button class="btn-save" runat="server" Text="Salvar" OnClick="Unnamed2_Click" ValidationGroup="validateGroup"/>

                    </div>
                </div>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" CssClass="compare" runat="server" Display="none" ErrorMessage="Nome da Rota não informado." ValidationGroup="validateGroup" ControlToValidate="TextBoxNome"></asp:RequiredFieldValidator>
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" ValidationGroup="validateGroup" ShowSummary="false" ShowMessageBox="true"/>   
      </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
</asp:Content>
