<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditEstudante.aspx.cs" Inherits="Ecard.EditEstudante" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<script src="https://kit.fontawesome.com/4bb70b9eaa.js"></script>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<link rel="stylesheet" type="text/css" href="StyleEditEstudante.css"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="header">
            <img src="Imagens/ECard.png" />
            <ol>
                <li>Menu</li>
                <li>Page 2</li>
                <li>Page 3</li>
                <li>Page 4</li> 
                <li class="menu-user">Daniel Victor</li>
            </ol>
        </div>
        <div class="container">
            <div class="box1">
                <div class="box1-header">
                    <div class="box1-title">
                       <i class="fas fa-map-marked-alt"></i>
                       <p>Cadastrar Estudante</p>
                    </div>
                </div>
                <div class="box1-midi">
                      <h1>Cadastro</h1>
                      <asp:TextBox ID="TextNome" runat="server" CssClass="box1-mid" placeholder="Nome"></asp:TextBox>
                      <asp:TextBox ID="TextRG" runat="server" CssClass="box1-mid" placeholder="RG"></asp:TextBox>
                      <asp:TextBox ID="TextCPF" runat="server" CssClass="box1-mid" placeholder="CPF"></asp:TextBox>
                      <asp:TextBox ID="TextDatadeNascimento" runat="server" CssClass="box1-mid" placeholder="Data de Nascimento"></asp:TextBox>
                      <asp:TextBox ID="TextInstitu" runat="server" CssClass="box1-mid" placeholder="Instituição"></asp:TextBox>
                      <asp:TextBox ID="TextCurso" runat="server" CssClass="box1-mid" placeholder="Curso"></asp:TextBox>
                    <div class="btn-b2">
                        <asp:Button class="btn-close" runat="server" Text="Fechar" PostBackUrl="~/CadastroPonto.aspx" />
                        <asp:Button class="btn-save" runat="server" Text="Salvar" OnClick="Unnamed2_Click" />

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
                         <asp:Button runat="server" CssClass="btn2" Text="Ver Perfil" />
                    </div>
                </div>

            </div>
          </div>
    </form>
</body>
</html>
