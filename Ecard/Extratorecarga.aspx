<%@ Page Title="" Language="C#" MasterPageFile="~/Estudante.Master" AutoEventWireup="true" CodeBehind="Extratorecarga.aspx.cs" Inherits="Ecard.Extratorecarga" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="stylesheet" type="text/css" href="StyleConsultaPontodeRecarga.css"/>
     <div class="box1">
                <div class="box1-header">
                    <div class="box1-title">
                        <a class="ai" href="TelaPrincipalEstudante.aspx"><i class="fas fa-arrow-left"></i></a>
                       <p>Extrato</p>
                    </div>
                </div>
                <div class="hl-2"></div><!--  horizontal line -->
                <div class=" pesq">
                    <asp:Label ID="Label2" CssClass="text-men" runat="server" Text="Consulte suas recargas!"></asp:Label>       
                </div>
                <div class="help">
                    <asp:Repeater ID="Repeater1" runat="server" DataSourceID="ObjectDataSource1">
                        <ItemTemplate>
                            <div class="pontoItem">
                                <div class="pontoItem-nome">
                                    <p class="ponto-nome">R$ <%#Eval("valor")%></p>
                                    <p class="ponto-rua">Data: <%#Eval("data")%></p>
                                </div>

                                <div class="vl"></div> <!-- vertical line -->

                                
                            </div> 
                        </ItemTemplate>
                    </asp:Repeater>
                    
                    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="SelectAll" TypeName="Ecard.DAL.DALExtrato">
                        <SelectParameters>
                            <asp:SessionParameter SessionField="userid" Name="estudante_id" Type="Int32"></asp:SessionParameter>
                        </SelectParameters>
                    </asp:ObjectDataSource>
                    
                </div>
              </div>
</asp:Content>
