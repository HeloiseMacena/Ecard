<%@ Page Title="" Language="C#" MasterPageFile="~/Administrador.Master" AutoEventWireup="true" CodeBehind="SolicitacaoCarteira.aspx.cs" Inherits="Ecard.SolicitacaoCarteira" EnableEventValidation="false" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="StyleSolicitacaoCarteira.css"/> 
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="box1">
                <div class="box1-header">
                    <div class="box1-title">
                        <a class="ai" href="TelaPrincipalAdm.aspx"><i class="fas fa-arrow-left"></i></a>
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
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
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
                                        <div class="row1">
                                            <div class="row1-coluna1">                                                
                                                <asp:Image ID="Image1" runat="server" Width="150" Height="150"/>                                                                     
                                            </div>
                                            <div class="row1-coluna2">
                                                <div class="item-campo">
                                                    <div class="item-campo-nome">
                                                        <asp:Label runat="server" Cssclass="categoria" Text="Data da solicitação:"></asp:Label>
                                                    </div>       
                                                    <asp:Label runat="server" type="text" CssClass="imodal" ID="Modal_data"></asp:Label>
                                                </div>
                                                <div class="item-campo">
                                                    <div class="item-campo-nome">
                                                        <asp:Label runat="server" Cssclass="categoria" Text="ID:"></asp:Label>
                                                    </div>       
                                                    <asp:Label runat="server" type="text" CssClass="imodal" ID="Modal_id"></asp:Label>                                                
                                                </div>
                                            </div>
                                        </div>                                      
                                        <div class="row2">
                                            <div class="item-campo">
                                                <div class="item-campo-nome">
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
</asp:Content>
