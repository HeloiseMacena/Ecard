<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SolicitacaoInstituicao.aspx.cs" Inherits="Ecard.SolicitacaoInstituicao" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<script src="https://kit.fontawesome.com/4bb70b9eaa.js"></script>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<link rel="stylesheet" type="text/css" href="StyleSolicitacaoInstituicao.css"/>    
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
                        <a class="ai" href="TelaPrincipalEstudante.aspx"><i class="fas fa-arrow-left"></i></a>
                        <p>Visualize as solicitações de instituições</p>
                    </div>
                </div>
                <asp:TextBox ID="TextPesquisa" CssClass="textbox1" runat="server" type="text" placeholder="Pesquisar"></asp:TextBox>
                <div class="box1-filtro">
                    <asp:DropDownList CssClass="ddlist1" runat="server">
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
                                    <p class="solicit-nome"><%#Eval("Nome")%></p>
                                </div>
                                <div class="solicit-but">
                                    <asp:Button runat="server" Text="Mais" CommandArgument='<%#Eval("id")%>' CssClass="action-button animate blue" OnClick="getModalInfos_Click" />
                                  </div>
                            </div> 
                        </ItemTemplate>
                    </asp:Repeater>                                                            
                    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DataObjectTypeName="Ecard.Modelo.Bairro" DeleteMethod="Delete" InsertMethod="Insert" SelectMethod="SelectAll" TypeName="Ecard.DAL.DALBairro" UpdateMethod="Update"></asp:ObjectDataSource>                                  
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
                         <asp:Button runat="server" CssClass="btn2"  Text="Ver Perfil" PostBackUrl="~/PerfilAdm.aspx" />
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
                                            <div class="rota-modal-nome">
                                                <p class="ponto-ref">Nome da Instituição:
                                                    <asp:Label runat="server" type="text" CssClass="imodal" ID="Modalnome"></asp:Label>
                                               </p>
                                                </div>
                                            <div class="rota-modal-nome">
                                                <p class="ponto-ref">Email:
                                                   <asp:Label runat="server" type="text" CssClass="imodal" ID="Modalemail"></asp:Label>
                                                </p>
                                                </div>
                                            <div class="rota-modal-nome">
                                                <p class="ponto-ref">Código INEP/MEC:
                                                    <asp:Label runat="server" type="text" CssClass="imodal" ID="Modalcodigo"></asp:Label>
                                                </p>
                                            </div>
                                             <div class="rota-modal-nome">
                                                <p class="ponto-ref">CNPJ:
                                                     <asp:Label runat="server" type="text" CssClass="imodal" ID="Modalcnpj"></asp:Label>
                                                </p>
                                            </div>
                                                <asp:DropDownList runat="server" CssClass="ddlist2">
                                                <asp:ListItem>Não há erro...</asp:ListItem>
                                                <asp:ListItem>Código INEP/MEC não identificado</asp:ListItem>
                                                <asp:ListItem>CNPJ não identificado</asp:ListItem>
                                                </asp:DropDownList>
                                            <div class="btn-modal">
                                                <asp:Button runat="server" CssClass="btn-rec" text="Recusar" />
                                                <asp:Button runat="server" CssClass="btn-act" text="Aceitar" />
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
