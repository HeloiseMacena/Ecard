<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormTelaPrincipalInstituicao.aspx.cs" Inherits="Ecard.WebFormTelaPrincipalInstituicao" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<script src="https://kit.fontawesome.com/4bb70b9eaa.js"></script>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<link rel="stylesheet" type="text/css" href="StyleTelaPrincipalInstituicao.css"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="header">
            <a style="width:100px;" href="WebFormTelaPrincipalAdm.aspx"><img src="Imagens/ECard.png" style="width:100px;" /></a>
            <ol>
                <li>Menu</li>
                <li>Page 2</li>
                <li>Page 3</li>
                <li>Page 4</li> 
                <li class="menu-user">Instituição</li>
            </ol>
        </div>
        <div class="container">
            <div class="box1">
                <div class="box1-header">
                    <div class="box1-title">
                      <i class="fas fa-plus"></i>
                       <p>Novo Estudante</p>
                    </div>
                    <d
                    </div>
               </div>
               <div class="princi">
                  
            </div>
            </div>

            <div class="box2">
                <div class="box2-user-container">
                    <div class="box2-user">
                         <i class="fas fa-university"></i>
                         <div class="user-name"> 
                            <h1>Nome Escola</h1>
                            <p>Instituição</p>
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

