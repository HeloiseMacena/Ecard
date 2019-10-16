<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadastroPassagem.aspx.cs" Inherits="Ecard.CadastroPassagem" %>

<!DOCTYPE html>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<script src="https://kit.fontawesome.com/4bb70b9eaa.js"></script>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<link rel="stylesheet" type="text/css" href="StyleCadastroPassagem.css"/>
    <script src="https://code.jquery.com/jquery-3.4.1.min.js"></script>
    <script src="JS/Events.js"></script>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="header max">
            <a style="width:100px;" href="WebFormTelaPrincipalAdm.aspx"><img src="Imagens/ECard.png" style="width:100px;" /></a>
            <div class="ol">
                <div class="li">Menu</div>
                <div class="li">Page 2</div>
                <div class="li">Page 3</div>
                <div class="li">Page 4</div> 
                <div class="menu-user">Daniel Victor</div>
            </div>
        </div>
        <div class="container">
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
                    <asp:TextBox ID="TextBox2" CssClass="box1-mid"  runat="server"></asp:TextBox>
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
                        <asp:Button class="btn-close" runat="server" Text="Fechar" PostBackUrl="~/WebFormTelaPrincipalAdm.aspx" />
                        <asp:Button class="btn-save" runat="server" Text="Salvar" OnClick="Unnamed2_Click"/>
                    </div>
                </div>
            </div>

          <div class="box2">
                <div class="box2-user-container">
                    <div class="box2-user">
                         <i class="fas fa-user-circle"></i>
                         <div class="user-name"> 
                            <h1>Daniel Victor</h1>
                            <p>Administrador</p>
                        </div>
                    </div>
                    <div class="box2-button">
                         <asp:Button runat="server" CssClass="btn2"  Text="Ver Perfil" PostBackUrl="~/PerfilAdm.aspx"/>
                    </div>
                </div>
            </div>
          </div>
    </form>
</body>
</html>
