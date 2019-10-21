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
                       <a class="ai" href="TelaPrincipalEstudante.aspx"><i class="fas fa-arrow-left"></i></a>
                       <p>Solicite sua carteira</p>
                    </div>
                    <div class="box1-button">
                        <asp:Label runat="server" CssClass="btnAdd" Text="Valor da carteira: R$ 25,00"></asp:Label>
                        
                    </div>
                </div>  
                <div class="info">
                    <div class="title-info">
                        <asp:Label ID="Label2" cssClass="info-cor" runat="server" Text="Se os dados abaixo estiverem INCORRETOS, procure a sua ESCOLA e solicite atualização de dados antes de solicitar a carteira!"></asp:Label>
                    </div>
                    <div class="info-2">
                        <div class="info-2-label">
                            <asp:Label ID="Label3" CssClass="azul" runat="server" Text="Nome"></asp:Label>
                        </div>
                        <asp:Label ID="LabelNome" CssClass="campo-inf" runat="server"></asp:Label>
                    </div>
                     <div class="info-2"> 
                        <div class="info-2-label">
                            <asp:Label ID="Label5" CssClass="azul" runat="server" Text="RG"></asp:Label>
                        </div>
                        <asp:Label ID="LabelRG" CssClass="campo-inf" runat="server"></asp:Label>
                    </div>
                     <div class="info-2">
                        <div class="info-2-label">
                            <asp:Label ID="Label7" CssClass="azul" runat="server" Text="CPF"></asp:Label>
                        </div>
                        <asp:Label ID="LabelCPF" CssClass="campo-inf" runat="server"></asp:Label>
                    </div>
                     <div class="info-2">
                        <div class="info-2-label">
                            <asp:Label ID="Label9" CssClass="azul" runat="server" Text="Nascimento"></asp:Label>
                        </div>
                        <asp:Label ID="LabelNascimento" CssClass="campo-inf" runat="server" Text="01/01/2001"></asp:Label>
                    </div>
                     <div class="info-2">
                        <div class="info-2-label">
                            <asp:Label ID="Label11" CssClass="azul" runat="server" Text="Instituição"></asp:Label>
                        </div>
                        <asp:Label ID="LabelInstituicao" CssClass="campo-inf" runat="server"></asp:Label>
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
                                <asp:Button runat="server" ID="btnUpload1" OnClick="btnUpload_Click" style="display: none" />
                            </div>
                        </div>
                    </div>
                    <hr style="width: 100%; margin: 20px 0;" />
                    <div class="term-content">
                        <div class="term-content-text">
                            <label style="display: block; font-weight: 700; margin-bottom: 20px;">
                                Termo de compromisso sobre o Cartão Estudante/Carteira Nacional de Identificação Estudantil
                            </label>
                            <asp:Label ID="Termo" runat="server" style="font-size: 12px;"></asp:Label>
                            <label style="font-size: 12px;" >, afirmo, no ato do recebimento deste Cartão Estudante/ Identidade Eletrônica, Ru: 633419 afirmo, no ato do recebimento deste Cartão Estudante/Carteira Nacional de Identificação Estudantil (sob pena de medidas administrativas, civis e criminais - Art. 299 do Código Penal), que sou estudante regularmente matriculado em instituição de ensino e declaro conhecer as formas corretas de utilização deste documento. Asseguro ainda estar ciente de que me submeterei às penas legais e criminais em caso de fraude, especialmente se este cartão pessoal for cedido para utilização de terceiros, estudantes ou não, como também em caso de utilização deste documento de forma ilegal, que possa caracterizar fraude, independentemente de obter ou não, qualquer tipo de vantagem. Além disso, comprometo-me a alertar meus familiares de que o uso deste cartão por outra pessoa que não seja eu mesmo, é crime e pode gerar consequências legais.</label>
                        </div>
                        <div class="term-content-footer">
                            <asp:CheckBox runat="server" ID="cbTerm" Text="DECLARO, para os fins que se fizerem necessários, ter lido e ACEITO integralmente as condições expressas no Termo de Compromisso sobre o cartão abaixo discriminadas." />
                            <asp:Button runat="server" ID="btnSendForm" CssClass="btnSendForm" Text="Confirmar solicitação" onclick="btnSendForm_Click"/>
                        </div>
                    </div>
                </div>
              </div>

            </div>
        <div>  
    </div>
</asp:Content>
