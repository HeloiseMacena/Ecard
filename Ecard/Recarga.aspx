<%@ Page Title="" Language="C#" MasterPageFile="~/Estudante.Master" AutoEventWireup="true" CodeBehind="Recarga.aspx.cs" Inherits="Ecard.Recarga" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="stylesheet" type="text/css" href="StyleRecarga.css"/>

     <div class="container">

            <div class="box1">
                <div class="box1-header">
                    <div class="box1-title">
                       <a class="ai" href="TelaPrincipalEstudante.aspx"><i class="fas fa-arrow-left"></i></a>
                       <p>Realize sua recarga</p>
                    </div>
                </div>
                 <div class="hl-2"></div><!--  horizontal line -->
                <div class="var">
                    <asp:TextBox ID="TextBoxRecarga" CssClass="text-var" placeholder="Digite aqui o valor da recarga" runat="server"></asp:TextBox> 
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
                    <asp:Button ID="Button3"  OnClick="Unnamed_Click" class="reca" runat="server" Text="Recarregar" ValidationGroup="validateGroup"/>
                </div>
                <div class="forma-2">
                <div class="forma-3">
                    <div class="azul">
                    <asp:Label ID="Label4" runat="server" Text="Total:"></asp:Label>
                    </div>
                    <asp:Label ID="Label5" CssClass="campo-inf" runat="server" Text="???"></asp:Label>
                    </div>
                <div class="forma-4">
                    <div class="azul">
                    <asp:Label ID="Label6" runat="server" Text="Saldo de Recarga:"></asp:Label>
                    </div>
                    <asp:Label ID="LabelSaldo" CssClass="campo-inf" runat="server"></asp:Label>
                    </div>
                </div>
                <div class="forma-5">
                </div>
              </div>
            <div>  
                </div>
           </div>
          <asp:RegularExpressionValidator ID="RegularExpressionValidator1" CssClass="compare" runat="server" Display="none" ErrorMessage="Valor inválido" ValidationGroup="validateGroup" ControlToValidate="TextBoxRecarga" ValidationExpression="^(\d+(\.\d\d)?)$"></asp:RegularExpressionValidator>
          <asp:RequiredFieldValidator ID="RequiredFieldValidator1" CssClass="compare" runat="server" Display="none" ErrorMessage="Valor da Recarga não informado não informado." ValidationGroup="validateGroup" ControlToValidate="TextBoxRecarga"></asp:RequiredFieldValidator>
          <asp:ValidationSummary ID="ValidationSummary1" runat="server" ValidationGroup="validateGroup" ShowSummary="false" ShowMessageBox="true"/>
</asp:Content>
