<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadastroPonto.aspx.cs" Inherits="Ecardmark1.CadastroPonto" %>

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
                       <p>Pontos de recarga</p>
                    </div>
                    <div class="box1-button">
                        <asp:Button runat="server" CssClass="btnAdd" Text="Novo" PostBackUrl="~/CadastroPontoEdit.aspx" />
                    </div>
                </div>
                <div class="help">
                    <asp:Repeater ID="Repeater1" runat="server" DataSourceID="ObjectDataSource1">
                        <ItemTemplate>
                            <div class="pontoItem">
                                <div class="pontoItem-nome">
                                    <p class="ponto-nome"><%#Eval("nome_ponto")%></p>
                                    <p class="ponto-rua">Logradouro: <%#Eval("endereco_logradouro")%></p>
                                </div>
                                <div class="vl"></div> <!-- vertical line -->
                                <div class="pontoItem-bairro">
                                    <p class="ponto-bairro-title">Bairro</p>
                                    <p><%#Eval("endereco_bairro")%></p>
                                </div>
                                <div class="ponto-but">

                                  
                                  </div>
                            </div> 
                        </ItemTemplate>
                    </asp:Repeater>
                    
                    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DataObjectTypeName="Ecardmark1.Modelo.Ponto_recarga" DeleteMethod="Delete" InsertMethod="Insert" SelectMethod="SelectAll" TypeName="Ecardmark1.DAL.DALPonto_recarga" UpdateMethod="Update"></asp:ObjectDataSource>
                    
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
                                                <p class="ponto-nume">N°:</p>
                                                <asp:Label runat="server" ID="lblModalNumero"></asp:Label>
                                                <p class="ponto-cep">CEP:</p>
                                                <asp:Label runat="server" ID="lblModalCEP"></asp:Label>
                                            </div>
                                            <div class="vl"></div>
                                            <!-- vertical line -->
                                            <div class="pontoItem-muni">
                                                <p class="ponto-muni-title">Municipio:</p>
                                                <asp:Label runat="server" ID="lblModalMunicipio"></asp:Label>
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
