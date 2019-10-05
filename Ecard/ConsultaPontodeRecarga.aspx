﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Estudante.Master" AutoEventWireup="true" CodeBehind="ConsultaPontodeRecarga.aspx.cs" Inherits="Ecard.CnsultaPontodeRecarga" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <link rel="stylesheet" type="text/css" href="StyleConsultaPontodeRecarga.css"/>
    <div class="container">
            <div class="box1">
                <div class="box1-header">
                    <div class="box1-title">
                        <a class="ai" href="WebFormTelaPrincipalAdm.aspx"><i class="fas fa-arrow-left"></i></a>
                       <p>Pontos de recarga</p>
                    </div>
                </div>
                <div class="hl-2"></div><!--  horizontal line -->
                <div class=" pesq">
                    <asp:Label ID="Label2" CssClass="text-men" runat="server" Text="Encontre o ponto mais perto de você!"></asp:Label> 
                    <asp:TextBox ID="TextBox1" CssClass="textbox1" runat="server" placeholder="Pesquisar"></asp:TextBox>
                    <div class="pesq-2">
                        <asp:DropDownList CssClass="ddlist1" runat="server">
                        <asp:ListItem>Nome</asp:ListItem>
                        <asp:ListItem>Logradouro</asp:ListItem>
                        <asp:ListItem>Bairro</asp:ListItem>
                        <asp:ListItem>CEP</asp:ListItem>
                    </asp:DropDownList>
                    <asp:Button ID="Button1" CssClass="btn-loc" runat="server" Text="Localizar" />
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
                                   <asp:Button runat="server" Text="Mais" CommandArgument='<%#Eval("id")%>' CssClass="action-button animate blue" OnClick="getModalInfos_Click" />
                                  </div>
                            </div> 
                        </ItemTemplate>
                    </asp:Repeater>
                    
                    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DataObjectTypeName="Ecard.Modelo.Ponto_recarga" DeleteMethod="Delete" InsertMethod="Insert" SelectMethod="SelectAll" TypeName="Ecard.DAL.DALPonto_recarga" UpdateMethod="Update"></asp:ObjectDataSource>
                    
                </div>
              </div>
            <div class="box2">
                 <div class="box2">
                <div class="box2-user-container">
                    <div class="box2-user">
                         <i class="fas fa-user-circle"></i>
                         <div class="user-name"> 
                            <h1>User</h1>
                            <p>Estudante</p>
                        </div>
                    </div>
                    <div class="box2-button">
                         <asp:Button runat="server" CssClass="btn2" Text="Ver Perfil" />
                    </div>
                </div>

                <div class="box2-ponto">
                    <div class="ponto">
                        <p>Seu Saldo</p>
                    </div>
                     <div class="hl"></div> <!--  horizontal line -->
                    <asp:Label ID="Label1" CssClass="title-money" runat="server" Text="R$ 9,58"></asp:Label>
                    <div class="btns">
                         <asp:Button class="btn-rec" runat="server" Text="Recarregar" />
                        <asp:Button class="btn-calc" runat="server" Text="Calcular Passagens"  />
                    </div>
                </div>
            </div>
            </div>
            <div>   <!-- Modal -->
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
                                                <p class="ponto-ref">Nº:
                                                    <asp:Label runat="server" ID="modalNum"></asp:Label>
                                               </p>
                                                </div>
                                            <div class="rota-modal-nome">
                                                <p class="ponto-ref">CEP:
                                                    <asp:Label runat="server" ID="modalCEP"></asp:Label>
                                                </p>
                                                </div>
                                            <div class="rota-modal-nome">
                                                <p class="ponto-ref">Município:
                                                    <asp:Label runat="server" ID="modalMun"></asp:Label>
                                                </p>
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
</asp:Content>
