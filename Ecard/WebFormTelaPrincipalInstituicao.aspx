<%--<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormTelaPrincipalInstituicao.aspx.cs" Inherits="Ecard.WebFormTelaPrincipalInstituicao" %>--%>

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
                         <i class="fas fa-user-graduate"></i>
                       <p>Estudantes</p>
                    </div>
                    <div class="box1-button">
                        <asp:Button runat="server" CssClass="btnAdd" Text="Novo" PostBackUrl="~/CadastroPontoEdit.aspx" />
                    </div>
                </div>
                <div class="hl"></div> <!-- horizontal line -->
                <div class="pesq">
                    <asp:TextBox ID="TextBox1" CssClass="box1-mid" runat="server" placeholder="Pesquisar" ></asp:TextBox>
                </div>

                 <div class="help">
                     <asp:Repeater ID="Repeater1" runat="server" DataSourceID="ObjectDataSource2">
                         <ItemTemplate>
                             <div class="pontoItem">
                                 <div class="pontoItem-nome">
                                     <p class="ponto-nome"><%#Eval("nome_ponto")%></p>
                                     <p class="ponto-rua">Logradouro: <%#Eval("endereco_logradouro")%></p>
                                 </div>
                                 <div class="vl"></div>
                                 <!-- vertical line -->
                                 <div class="pontoItem-bairro">
                                     <p class="ponto-bairro-title">Bairro</p>
                                     <p><%#Eval("endereco_bairro")%></p>
                                 </div>
                                 <div class="ponto-but">
                                 </div>
                             </div>
                         </ItemTemplate>
                     </asp:Repeater>
                     <asp:ObjectDataSource runat="server" ID="ObjectDataSource2" DataObjectTypeName="Ecard.Modelo.Lista_alunos" DeleteMethod="Delete" InsertMethod="Insert" SelectMethod="SelectAll" TypeName="Ecard.DAL.DALLista_alunos" UpdateMethod="Update"></asp:ObjectDataSource>
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

