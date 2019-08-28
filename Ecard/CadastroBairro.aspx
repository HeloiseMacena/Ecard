<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadastroBairro.aspx.cs" Inherits="Ecard.CadastroBairro" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<script src="https://kit.fontawesome.com/4bb70b9eaa.js"></script>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<link rel="stylesheet" type="text/css" href="StylePonto.css"/>
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
                <li class="menu-user">Daniel Victor</li>
            </ol>
        </div>
        <div class="container">
            <div class="box1">
                <div class="box1-header">
                    <div class="box1-title">
                       <i class="fas fa-map-marked-alt"></i>
                       <p>Bairros</p>
                    </div>
                    <div class="box1-button">
                        <asp:Button runat="server" CssClass="btnAdd" Text="Novo" PostBackUrl="~/CadastroBairroEdit.aspx" />
                    </div>
                </div>
                <div class="help">
                    <asp:Repeater ID="Repeater1" runat="server" DataSourceID="ObjectDataSource1">
                        <ItemTemplate>
                            <div class="pontoItem">
                                <div class="pontoItem-nome">
                                    <p class="ponto-nome"><%#Eval("Nome")%></p>
                                </div>
                                <div class="ponto-but">
                                   <asp:LinkButton runat="server"><a href="#modal" class="action-button shadow animate blue" id="show-modal">Mais</a></asp:LinkButton>
                                   <asp:LinkButton CssClass="link-but" runat="server"  PostBackUrl='<%#"~/EditarBairro.aspx?id=" +  Eval("id") %>'> <i class="fas fa-pen-square"></i> </asp:LinkButton>
                                  </div>
                            </div> 
                        </ItemTemplate>
                    </asp:Repeater>
                    
                    
                    
                    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DataObjectTypeName="Ecardmark1.Modelo.Bairro" DeleteMethod="Delete" InsertMethod="Insert" SelectMethod="SelectAll" TypeName="Ecardmark1.DAL.DALBairro" UpdateMethod="Update"></asp:ObjectDataSource>
                    
                    
                    
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
                    <div class="ponto2">
                        <i class="fas fa-search"></i>
                        <p>Pesquisar</p>
                    </div>
                </div>
            </div>
            <div>   <!-- Modal -->
                    <aside id="modal" class="modal">
		            <div class="content-modal">
			            <header>
				            <a href="#" class="close-modal">X</a>
				            <h2>Mais informações</h2>	
			            </header>
			            <article>
                            <div class="help-modal">
                                
                                        <div class="ponto-modal">
                                            <div class="ponto-modal-nome">
                                                <p class="ponto-nume">N° </p>
                                                <p class="ponto-cep">CEP: </p>
                                            </div>
                                            <div class="vl"></div>
                                            <!-- vertical line -->
                                            <div class="pontoItem-muni">
                                                <p class="ponto-muni-title">Municipio</p>
                                                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
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
