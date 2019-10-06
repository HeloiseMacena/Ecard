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
                                   <asp:LinkButton runat="server"><a href="#modal" class="action-button shadow animate blue" id="show-modal">Mais</a></asp:LinkButton>
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
                         <asp:Button runat="server" CssClass="btn2" Text="Ver Perfil" />
                    </div>
                </div>

                <div class="box2-rotas">
                    <div class="rotas">
                        <p>Rotas</p>
                    </div>
                    <div class="rotas2">
                        <i class="fas fa-search"></i>
                        <p>Pesquisar</p>
                    </div>
                </div>
                  <!-- Modal -->
                <aside id="modal" class="modal">
		            <div class="content-modal">
			            <header>
				            <a href="#" class="close-modal">X</a>
				            <h2>Mais informações</h2>	
			            </header>
			            <article>
                          <div class="help-modal">                                
                                        <div class="rota-modal">
                                            <div class="rota-modal-nome">
                                                <p class="ponto-ref">Pontos de Referência:</p>
                                            </div>
                                        </div>
                            </div>
			            </article>
                    </div>
		            <a href="#" class="btn-close-modal"></a>
	            </aside>
            </div>
        </div>
    </form>
</body>
</html>

