<%@ Page Title="" Language="C#" MasterPageFile="~/Administrador.Master" AutoEventWireup="true" CodeBehind="CadastroBairro.aspx.cs" Inherits="Ecard.CadastroBairro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="StylePontoBairro.css"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="box1">
                <div class="box1-header">
                    <div class="box1-title">
                       <a class="ai" href="TelaPrincipalAdm.aspx"><i class="fas fa-arrow-left"></i></a>
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
                                   
                                   <asp:LinkButton CssClass="link-but" runat="server"  PostBackUrl='<%#"~/EditarBairro.aspx?id=" +  Eval("id") %>'> <i class="fas fa-pen-square"></i> </asp:LinkButton>
                                  </div>
                            </div> 
                        </ItemTemplate>
                    </asp:Repeater>
                                                            
                    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DataObjectTypeName="Ecard.Modelo.Bairro" DeleteMethod="Delete" InsertMethod="Insert" SelectMethod="SelectAll" TypeName="Ecard.DAL.DALBairro" UpdateMethod="Update"></asp:ObjectDataSource>                                  
                  </div>  
       </div>     
            

</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
   <div class="box2-ponto">
                    <div class="ponto">
                        <p>Bairro</p>
                    </div>
                     <div class=" pesq">
                    <asp:TextBox ID="valueSearch" CssClass="textbox1" runat="server" placeholder="Pesquisar"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" CssClass="compare" runat="server" Display="dynamic" ErrorMessage="* Nome do ponto não informado." ValidationGroup="validateGroup" ControlToValidate="valueSearch"></asp:RequiredFieldValidator>
                    <div class="pesq-2">
                        <asp:DropDownList id="DDLSearch" CssClass="ddlist1" runat="server">
                        <asp:ListItem>Nome</asp:ListItem>
                    </asp:DropDownList>
                    <asp:Button ID="btnSearch" OnClick="BtnSearch_Click"  CssClass="btn-loc" runat="server" Text="Localizar" />
                    </div>
                </div>
   </div>
</asp:Content>


