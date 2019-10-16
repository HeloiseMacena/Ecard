<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadastroRota.aspx.cs" Inherits="Ecard.CadastroRota" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<script src="https://kit.fontawesome.com/4bb70b9eaa.js"></script>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<link rel="stylesheet" type="text/css" href="StyleRota.css"/>
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
                       <p>Rotas</p>
                    </div>
                    <div class="box1-button">
                        <asp:Button runat="server" CssClass="btnAdd" Text="Novo" PostBackUrl="~/CadastroRotaEdit.aspx" />
                    </div>
                </div>
                <div class="box1-body">
                     <div class="help">
                    <asp:Repeater ID="Repeater1" runat="server" DataSourceID="ObjectDataSource1">
                        <ItemTemplate>
                            <div class="rotaItem">
                                <div class="rotaItem-nome">
                                    <p class="rota-nome"><%#Eval("nome")%></p>
                                </div>
                                
                                <div class="rota-but">
                                    <asp:Button runat="server" Text="Mais" CommandArgument='<%#Eval("nome")%>' CssClass="action-button animate blue"  OnClick="getModalInfos_Click" />
                                   <asp:LinkButton CssClass="link-but" runat="server"  PostBackUrl='<%#"~/EditarRota.aspx?id=" +  Eval("id") %>'> <i class="fas fa-pen-square"></i> </asp:LinkButton>
                                 </div>
                            </div> 
                        </ItemTemplate>
                    </asp:Repeater>
                       
                         <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DataObjectTypeName="Ecard.Modelo.Rota" DeleteMethod="Delete" InsertMethod="Insert" SelectMethod="SelectAll" TypeName="Ecard.DAL.DALRota" UpdateMethod="Update"></asp:ObjectDataSource>
                       
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
                         <asp:Button runat="server" CssClass="btn2" Text="Ver Perfil"  PostBackUrl="~/PerfilAdm.aspx" />
                    </div>
                </div>

                <div class="box2-ponto">
                    <div class="ponto">
                        <p>Rota</p>
                    </div>
                    <div class=" pesq">
                    <asp:TextBox ID="valueSearch" CssClass="textbox1" runat="server" placeholder="Pesquisar"></asp:TextBox>
                    <div class="pesq-2">
                        <asp:DropDownList id="DDLSearch" CssClass="ddlist1" runat="server">
                        <asp:ListItem>Nome</asp:ListItem>
                        <asp:ListItem>Bairro</asp:ListItem>
                        <asp:ListItem>Ponto de Referência</asp:ListItem>
                    </asp:DropDownList>
                    <asp:Button ID="btnSearch" OnClick="btnSearch_Click"  CssClass="btn-loc" runat="server" Text="Localizar" />
                    </div>
                </div>
                </div>
                 <!-- Modal -->
                <div class="help-modal">
                    <div>
                        <div class="modal-container" id="modalContainer" runat="server">
                            <div class="modal-content">
                                <div class="modal-header">
                                   <h2>Mais Informações</h2>
                                    <i class="fas fa-times" id="closeModal" runat="server" onclick="document.querySelector('.modal-container').style.visibility = 'hidden';"></i>
                                </div>
                                <div class="modal-body">
                                 <div class="help-modal">                                
                                        <div class="rota-modal">
                                            <div class="test">
                                            <asp:Repeater ID="Repeater2" runat="server" DataSourceID="ObjectDataSource2">
                                                <ItemTemplate>
                                                    <div class="rota-modal-nome1">
                                                        <p class="ponto-ref">
                                                            Bairro:
                                                    <asp:Label runat="server" ID="modalBairro"><%#Eval("nome")%></asp:Label>
                                                        </p>
                                                    </div>
                                                </ItemTemplate>
                                            </asp:Repeater>
                                            <asp:ObjectDataSource runat="server" ID="ObjectDataSource2" SelectMethod="SelectAll" TypeName="Ecard.DAL.DALBairro"></asp:ObjectDataSource>
                                            </div>
                                            <div class="vl"></div>
                                            <div class="rota-modal-nome">
                                                <asp:Repeater ID="Repeater3" runat="server" DataSourceID="ObjectDataSource3">
                                                    <ItemTemplate>
                                                        <p class="ponto-ref">
                                                            Ponto de referência:
                                                    <asp:Label runat="server" ID="modalPonto"><%#Eval("nome")%></asp:Label>
                                                        </p>
                                                    </ItemTemplate>
                                                </asp:Repeater>
                                                <asp:ObjectDataSource runat="server" ID="ObjectDataSource3" SelectMethod="SelectAll" TypeName="Ecard.DAL.DALPonto_referencia"></asp:ObjectDataSource>
                                            </div>
                                        </div>
                                    </div> 
                                </div>
                                <div class="modal-footer"></div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>