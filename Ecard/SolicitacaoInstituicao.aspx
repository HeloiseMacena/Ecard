<%@ Page Title="" Language="C#" MasterPageFile="~/Administrador.Master" AutoEventWireup="true" CodeBehind="SolicitacaoInstituicao.aspx.cs" Inherits="Ecard.SolicitacaoInstituicao" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="StyleSolicitacaoInstituicao.css"/>  
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="box1">
                <div class="box1-header">
                    <div class="box1-title">
                        <a class="ai" href="TelaPrincipalAdm.aspx"><i class="fas fa-arrow-left"></i></a>
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
                <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DataObjectTypeName="Ecard.Modelo.Instituicao" DeleteMethod="Delete" InsertMethod="Insert" SelectMethod="SelectAll" TypeName="Ecard.DAL.DALInstituicao" UpdateMethod="Update"></asp:ObjectDataSource>                                  
                  </div>
              
            </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
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
                                                <asp:Label runat="server" class="categoria" Text="Id da Instituição:"></asp:Label>
                                            </div>    
                                            <asp:Label runat="server" type="text" CssClass="imodal" ID="Id_instituicao"></asp:Label>                                                                                  
                                        </div>

                                        <div class="item-campo">
                                            <div class="item-campo-nome">
                                                <asp:label runat="server" class="categoria" Text="Nome da Instituição:"></asp:label>
                                            </div>
                                            <asp:Label runat="server" type="text" CssClass="imodal" ID="Modalnome1"></asp:Label>                                                            
                                        </div>

                                        <div class="item-campo">
                                            <div class="item-campo-nome">
                                              <asp:Label runat="server" class="categoria">Email:</asp:Label>
                                            </div>
                                            <asp:Label runat="server" type="text" CssClass="imodal" ID="Modalemail1"></asp:Label>
                                        </div>

                                        <div class="item-campo">
                                            <div class="item-campo-nome">
                                                <asp:Label runat="server" class="categoria">Código INEP/MEC:</asp:Label>
                                            </div>     
                                            <asp:Label runat="server" type="text" CssClass="imodal" ID="Modalcodigo1"></asp:Label>
                                        </div>

                                        <div class="item-campo">
                                            <div class="item-campo-nome">
                                                <asp:Label runat="server" class="categoria">CNPJ:</asp:Label>
                                            </div>     
                                            <asp:Label runat="server" type="text" CssClass="imodal" ID="Modalcnpj1"></asp:Label>
                                        </div>                                                                                                                                                                                                           
                                                                                                                                                                                                              
                                       <div class="item-campo">
                                            <asp:DropDownList runat="server" CssClass="ddlist" ID="erro">
                                                <asp:ListItem>Não há erro...</asp:ListItem>
                                                <asp:ListItem>Código INEP/MEC não identificado</asp:ListItem>
                                                <asp:ListItem>CNPJ não identificado</asp:ListItem>
                                                <asp:ListItem>Código INEP/MEC e CNPJ não identificados</asp:ListItem>
                                            </asp:DropDownList>                                               
                                       </div>                                   
                                       <div class="btn-modal">
                                            <asp:Button runat="server" CssClass="btn-act" text="Enviar" OnClick="Enviar_click"/>
                                       </div>
                                       </div>                                     
                                    </div>
                            </div>
                        </div>
                    </div>
                </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
</asp:Content>
