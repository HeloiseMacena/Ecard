<%--<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormTelaPrincipalInstituicao.aspx.cs" Inherits="Ecard.WebFormTelaPrincipalInstituicao" %>--%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<script src="https://kit.fontawesome.com/4bb70b9eaa.js"></script>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<link rel="stylesheet" type="text/css" href="StyleTelaPrincipalInstituicao.css"/>
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
                         <i class="fas fa-user-graduate"></i>
                       <p>Estudantes</p>
                    </div>
                    <div class="box1-button">
                        <asp:FileUpload ID="FileUpload1" runat="server" />
                        <asp:Button runat="server" CssClass="btnAdd" Text="Mandar"/>
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
                     <asp:ObjectDataSource runat="server" ID="ObjectDataSource2" DataObjectTypeName="Ecard.Modelo.Lista_alunos" DeleteMethod="Delete" InsertMethod="Insert" SelectMethod="SelectAll" TypeName="Ecard.DAL.DALLista_alunos" UpdateMethod="Update"></asp:ObjectDataSource> -->
                 </div>
            </div>

            <div class="box2">
                <div class="box2-user-container">
                    <div class="box2-user">
                         <i class="fas fa-university"></i>
                         <div class="user-name"> 
                            <h1>Nome Instituição</h1>
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

