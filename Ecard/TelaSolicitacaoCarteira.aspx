<%@ Page Title="" Language="C#" MasterPageFile="~/Estudante.Master" AutoEventWireup="true" CodeBehind="TelaSolicitacaoCarteira.aspx.cs" Inherits="Ecard.TelaSolicitacaoCarteira" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <link rel="stylesheet" type="text/css" href="StyleTelaSolicitacaoCarteira.css"/>
    <script>
        function selectFile() {
            $('#ContentPlaceHolder1_FileUpload1').click();
        }

        function uploadPhoto() {
            $('#ContentPlaceHolder1_btnUpload1').click();
        }
    </script>

     <div class="container">

            <div class="box1">
                <div class="box1-header">
                    <div class="box1-title">
                       <a class="ai" href="WebFormTelaPrincipalAdm.aspx"><i class="fas fa-arrow-left"></i></a>
                       <p>Solicite sua carteira</p>
                    </div>
                    <div class="box1-button">
                        <asp:Button runat="server" CssClass="btnAdd" Text="R$ 25,00" PostBackUrl="~/CadastroBairroEdit.aspx" />
                    </div>
                </div>  
                <div class="info">
                    <div class="title-info">
                        <asp:Label ID="Label2" cssClass="info-cor" runat="server" Text="Se os dados abaixo estiverem INCORRETOS, procure a sua ESCOLA e solicite atualização de dados antes de solicitar!"></asp:Label>
                    </div>
                    <div class="info-2">
                        <div class="info-2-label">
                            <asp:Label ID="Label3" CssClass="azul" runat="server" Text="Nome"></asp:Label>
                        </div>
                        <asp:Label ID="Label4" CssClass="campo-inf" runat="server" Text="Dara Hadrielle da Cunha Rocha "></asp:Label>
                    </div>
                     <div class="info-2"> 
                        <div class="info-2-label">
                            <asp:Label ID="Label5" CssClass="azul" runat="server" Text="RG"></asp:Label>
                        </div>
                        <asp:Label ID="Label6" CssClass="campo-inf" runat="server" Text="123.456.789"></asp:Label>
                    </div>
                     <div class="info-2">
                        <div class="info-2-label">
                            <asp:Label ID="Label7" CssClass="azul" runat="server" Text="CPF"></asp:Label>
                        </div>
                        <asp:Label ID="Label8" CssClass="campo-inf" runat="server" Text="123.456.789-11 "></asp:Label>
                    </div>
                     <div class="info-2">
                        <div class="info-2-label">
                            <asp:Label ID="Label9" CssClass="azul" runat="server" Text="Nascimento"></asp:Label>
                        </div>
                        <asp:Label ID="Label10" CssClass="campo-inf" runat="server" Text="01/01/2001"></asp:Label>
                    </div>
                     <div class="info-2">
                        <div class="info-2-label">
                            <asp:Label ID="Label11" CssClass="azul" runat="server" Text="Instituição"></asp:Label>
                        </div>
                        <asp:Label ID="Label12" CssClass="campo-inf" runat="server" Text="IFRN "></asp:Label>
                    </div>
                    <div class="image-1" ><img src="Imagens/fotocarteira.png"  style="width:100%;"/></div>
                    <div class="photo">
                        <div>
                            <asp:Image runat="server" ImageUrl="~/Imagens/default.png" Width="200" ID="userImage" />
                        </div>
                        <div style="margin-left: 20px;" class="photo-content">
                            <div>
                                <h1 style="font-size: 22px; font-weight: 700; margin-bottom: 10px;">Selecione a sua foto</h1>
                                <label style="font-size: 14px;">Escolha uma foto que atenda a todos os requisitos apresentados acima e aperte em enviar!</label>
                            </div>
                            <div style="margin-bottom: 4px; display: flex; align-items: flex-end">
                                <asp:FileUpload ID="FileUpload1" runat="server" class="multi" AllowMultiple="true" onchange="uploadPhoto()" />
                                <asp:Button ID="btnUpload" CssClass="btnUpload" runat="server" Text="Carregar Foto" OnClientClick="selectFile(); return false;" />
                                <asp:Button runat="server" CssClass="btnSubmit" Text="Enviar" />
                                <asp:Button runat="server" ID="btnUpload1" OnClick="btnUpload_Click" style="display: none" />
                            </div>
                        </div>
                    </div>
                </div>
              </div>
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
            <div>  
                </div>
           </div>
</asp:Content>
