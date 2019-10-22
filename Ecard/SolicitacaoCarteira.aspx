<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SolicitacaoCarteira.aspx.cs" Inherits="Ecard.SolicitacaoEstudante" EnableEventValidation="false" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<script src="https://kit.fontawesome.com/4bb70b9eaa.js"></script>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<link rel="stylesheet" type="text/css" href="StyleSolicitacaoCarteira.css"/>  
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
                        <p>Visualize as solicitações de estudantes</p>
                    </div>
                </div>
                <asp:TextBox ID="TextPesquisa" CssClass="textbox1" runat="server" type="text" placeholder="Pesquisar"></asp:TextBox>
                <div class="box1-filtro">
                    <asp:DropDownList CssClass="ddlist1" runat="server">
                        <asp:ListItem>Escola</asp:ListItem>
                        <asp:ListItem>Ordem alfabética</asp:ListItem>
                        <asp:ListItem>Mais recente</asp:ListItem>
                        <asp:ListItem>Mais antiga</asp:ListItem>
                    </asp:DropDownList>
                    <asp:Button runat="server" CssClass="btn-ok" Text="Ok"/>
                </div>
                <div class="help">
                    <asp:Repeater ID="Repeater1" runat="server" >
                        <ItemTemplate>
                            <div class="solicitItem">
                                <div class="solicitItem-nome">
                                    <p class="solicit-nome"><%#Eval("estudante_id")%></p>
                                </div>
                                <div class="solicit-but">
                                    <asp:Button runat="server" Text="Mais" CommandArgument='<%#Eval("id")%>' CssClass="action-button animate blue" OnClick="Unnamed_Click" />
                                  </div>
                            </div> 
                        </ItemTemplate>
                    </asp:Repeater>                                                            
                    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="SelectPendentes" TypeName="Ecard.DAL.DALSolicitacao_carteira" DataObjectTypeName="Ecard.Modelo.Solicitacao_carteira" DeleteMethod="Delete" InsertMethod="Insert" UpdateMethod="Update">
                    </asp:ObjectDataSource>                                  
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
                                 <div class="campos">                                
                                        <div class="item-campo">
                                            <div class="item-campo-nome">
                                                <asp:Image ID="Image1" runat="server" Width="100" Height="100"/>
                                            </div>
                                        </div>

                                            <div class="item-campo">
                                                <div class="item-campo-nome">
                                                    <asp:Label runat="server" Cssclass="categoria" Text="ID:"></asp:Label>
                                                </div>       
                                                <asp:Label runat="server" type="text" CssClass="imodal" ID="Modal_id"></asp:Label>                                                
                                            </div>

                                            <div class="item-campo">
                                                <div class="rota-modal-nome">
                                                    <asp:Label runat="server" Cssclass="categoria" Text="Data da solicitação:"></asp:Label>
                                                </div>       
                                                <asp:Label runat="server" type="text" CssClass="imodal" ID="Modal_data"></asp:Label>
                                            </div>

                                            <div class="item-campo">
                                                <div class="rota-modal-nome">
                                                    <asp:Label runat="server" Cssclass="categoria" Text="Nome:"></asp:Label>
                                                </div>       
                                                <asp:Label runat="server" type="text" CssClass="imodal" ID="Modal_estudante"></asp:Label>
                                            </div>
                                            
                                            <div class="item-campo">
                                                <asp:DropDownList runat="server" CssClass="ddlist" ID="erro">
                                                    <asp:ListItem>Não há erro...</asp:ListItem>
                                                    <asp:ListItem>Foto irregular</asp:ListItem>
                                                </asp:DropDownList>
                                            </div>                                                                                                                                                                                                                                       
                                            <div class="btn-modal">
                                                <asp:Button runat="server" CssClass="btn-act" text="Enviar" OnClick="Aceitar_click"/>
                                            </div>
                                        </div>
                                    </div> 
                                </div>            
                            </div>
                        </div>
                    </div>
                </div>
    </form>
</body>
</html>
