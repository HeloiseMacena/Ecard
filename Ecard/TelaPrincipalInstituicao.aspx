<%@ Page Title="" Language="C#" MasterPageFile="~/Minstituicao.Master" AutoEventWireup="true" CodeBehind="TelaPrincipalInstituicao.aspx.cs" Inherits="Ecard.TelaPrincipalInstituicao" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="StyleTelaPrincipalInstituicao.css"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
            <div class="box1">
                 <div class="box1-header">
                    <div class="box1-title">
                         <i class="fas fa-user-graduate"></i>
                       <p>Estudantes</p>
                    </div>
                    <div class="box1-button">
                    </div>
                </div>
                <div class="hl"></div> <!-- horizontal line -->
                <div class="pesq">
                    <asp:FileUpload ID="FileUpload1" CssClass="multi" runat="server" BorderColor="White" />
                        <asp:Button runat="server" OnClick="Unnamed_Click" CssClass="btnAdd" Text="Mandar"/>
                        <asp:Label ID="resposta" runat="server" Text="Label"></asp:Label>
                </div>
                 <div class="help">
                     <asp:Repeater ID="Repeater1" runat="server" DataSourceID="ObjectDataSource2">
                         <ItemTemplate>
                             <div class="pontoItem">
                                 <div class="pontoItem-nome">
                                     <p class="ponto-nome"><%#Eval("nome_ponto")%></p>
                                     <p class="ponto-rua">Logradouro: <%#Eval("endereco_logradouro")%></p>
                                 </div>
                                 <div class="vl"></div><!-- vertical line -->
                                 <div class="pontoItem-bairro">
                                     <p class="ponto-bairro-title">Bairro</p>
                                     <p><%#Eval("endereco_bairro")%></p>
                                 </div>
                                 <div class="ponto-but">
                                 </div>
                             </div>
                         </ItemTemplate>
                     </asp:Repeater>
                     <asp:ObjectDataSource runat="server" ID="ObjectDataSource2" DataObjectTypeName="Ecard.Modelo.Lista_alunos" DeleteMethod="Delete" InsertMethod="Insert" SelectMethod="SelectAll" TypeName="Ecard.DAL.DALLista_alunos" UpdateMethod="Update"></asp:ObjectDataSource>
                 </div>
            </div>
</asp:Content>
