<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadastroPontoReferencia.aspx.cs" Inherits="Ecard.CadastroPontoReferencia" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<script src="https://kit.fontawesome.com/4bb70b9eaa.js"></script>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<link rel="stylesheet" type="text/css" href="StylePontoBairro.css"/>
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
                        <a class="ai" href="WebFormTelaPrincipalAdm.aspx"><i class="fas fa-arrow-left"></i></a>
                       <p>Pontos de referência</p>
                    </div>
                    <div class="box1-button">
                        <asp:Button runat="server" CssClass="btnAdd" Text="Novo" PostBackUrl="~/CadastroPontoReferenciaEdit.aspx" />
                    </div>
                </div>
                <div class="help">
                    <asp:Repeater ID="Repeater1" runat="server" DataSourceID="ObjectDataSource1">
                        <ItemTemplate>
                            <div class="pontoItem">
                                <div class="pontoItem-nome">
                                    <p class="ponto-nome"><%#Eval("nome")%></p>
                                </div>
                                <div class="ponto-but">
                                   <asp:LinkButton CssClass="link-but" runat="server"  PostBackUrl='<%#"~/EditarPontoReferencia.aspx?id=" +  Eval("Id") %>'> <i class="fas fa-pen-square"></i> </asp:LinkButton>
                                  </div>
                            </div> 
                        </ItemTemplate>
                    </asp:Repeater>
                    
                    
                    
                    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DataObjectTypeName="Ecard.Modelo.Ponto_referencia" DeleteMethod="Delete" InsertMethod="Insert" SelectMethod="SelectAll" TypeName="Ecard.DAL.DALPonto_referencia" UpdateMethod="Update"></asp:ObjectDataSource>
                    
                    
                    
                </div>
              </div>
            <div class="box2">
                <div class="box2-user-container">
                    <div class="box2-user">
                         <i class="fas fa-user-circle"></i>
                         <div class="user-name"> 
                            <h1>User</h1>
                            <p>Administrador</p>
                        </div>
                    </div>
                    <div class="box2-button">
                         <asp:Button runat="server" CssClass="btn2" Text="Ver Perfil" />
                    </div>
                </div>

                <div class="box2-ponto">
                    <div class="ponto">
                        <p>Pontos de recarga</p>
                    </div>
                     <div class=" pesq">
                    <asp:TextBox ID="valueSearch" CssClass="textbox1" runat="server" placeholder="Pesquisar"></asp:TextBox>
                    <div class="pesq-2">
                        <asp:DropDownList id="DDLSearch" CssClass="ddlist1" runat="server">
                        <asp:ListItem>Nome</asp:ListItem>
                    </asp:DropDownList>
                    <asp:Button ID="btnSearch" OnClick="btnSearch_Click"  CssClass="btn-loc" runat="server" Text="Localizar" />
                    </div>
                </div>
                </div>
            </div>
            <div>  
                </div>
           </div>
    </form>
</body>

</html>
