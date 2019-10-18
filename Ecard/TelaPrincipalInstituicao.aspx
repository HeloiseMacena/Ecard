<%@ Page Title="" Language="C#" MasterPageFile="~/Minstituicao.Master" AutoEventWireup="true" CodeBehind="TelaPrincipalInstituicao.aspx.cs" Inherits="Ecard.TelaPrincipalInstituicao" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="StyleTelaPrincipalInstituicao.css"/>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script>
        function selectFile() {
            $('#ContentPlaceHolder1_FileUpload1').click();
        }

        function uploadLista() {
            $('#ContentPlaceHolder1_btnUpload1').click();
        }
    </script>
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
                <div class="alerta">
                  <p class="attention">  <i class="fas fa-exclamation-circle"></i> Aviso: Somente enviar arquivos de texto (*.txt). 
                       Os dados devem seguir esta ordem pré-determinada: nome do aluno, RG e CPF e devem ser separados por  ";"  sem nenhum espaço entre elas
                      <br/> Ex: João Medeiros;123520469;12052004050</p>
                </div>
                <div class="list" >
                    <asp:FileUpload ID="FileUpload1" CssClass="multi" runat="server" AllowMultiple="true" onchange="uploadLista()" />
                    <asp:Button ID="btnUpload" CssClass="btnUpload" runat="server" Text="Carregar Lista" OnClientClick="selectFile(); return false;" />
                    <asp:Button ID="btnUpload1" runat="server" OnClick="Unnamed_Click" style="display: none" /> <asp:Label ID="userImage" runat="server" Text=""></asp:Label>
                    <div class="alert">
                    <asp:Label ID="resposta" CssClass="msg" runat="server" Text="Arquivo enviado com sucesso" style="display: none"></asp:Label>
                     <asp:Label ID="respostaError" CssClass="msg1" runat="server" Text="Por favor, selecione um arquivo *.txt para enviar" style="display: none"></asp:Label>
                        </div>
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
