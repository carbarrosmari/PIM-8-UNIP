<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="ProjetoPIM.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="StyleSheet.css" rel="stylesheet"/>
</head>
<body>
    <form id="form1" runat="server">
        <p style="height: 3em; text-align:center;"><asp:Label ID="labelDadosPessoais" runat="server" Text="Dados Pessoais" CssClass="title"></asp:Label></p>
        <p>
            <asp:Label ID="labelNome" runat="server" Text="Nome:" CssClass="label"></asp:Label>
            <input id="inputNome" type="text" style="width: 850px;" />
        </p>
        <p>
            <asp:Label ID="labelCpf" runat="server" Text="CPF:" CssClass="label"></asp:Label>
            <input id="inputCpf" type="text"/>
        </p>
        <p>
            <asp:Label ID="labelLogradouro" runat="server" Text="Logradouro:" CssClass="label"></asp:Label>
            <input id="inputLogradouro" type="text" style="width: 850px;" />
        </p>
        <p>
            <asp:Label ID="labelBairro" runat="server" Text="Bairro:" CssClass="label"></asp:Label>
            <input id="inputBairro" type="text"  />
            <asp:Label ID="labelCep" runat="server" Text="CEP:" CssClass="label"></asp:Label>
            <input id="inputCep" type="text"  />
            <asp:Label ID="labelLogNumero" runat="server" Text="Número:" CssClass="label"></asp:Label>
            <input id="inputNum" type="text" style="width: 50px;"/>
        </p>
        <p>
            <asp:Label ID="labelCidade" runat="server" Text="Cidade:" CssClass="label"></asp:Label>
            <input id="inputCidade" type="text" />
            <asp:Label ID="labelEstado" runat="server" Text="UF:" CssClass="label"></asp:Label>
            <input id="inputEstado" type="text" style="width: 50px;"/>
        </p>
        <p>
            <asp:Label ID="labelTipoTel" runat="server" Text="Tipo Tel.:" CssClass="label"></asp:Label>
            <input id="inputTipoTel" type="text" />
            <asp:Label ID="labelDDD" runat="server" Text="DDD:" CssClass="label"></asp:Label>
            <input id="inputDDD" type="text" style="width: 50px;"/>
            <asp:Label ID="labelNumTelefone" runat="server" Text="Número:" CssClass="label"></asp:Label>
            <input id="inputNumTel" type="text" />
        </p>  
        <div style="text-align: center;">
            <asp:Button ID="btnCadastrar" runat="server" Text="Cadastrar" CssClass="btn" />
            <asp:Button ID="btnAlterar" runat="server" Text="Alterar Dados" CssClass="btn" />
            <asp:Button ID="btnConsultar" runat="server" Text="Consultar" CssClass="btn" />
            <asp:Button ID="btnExcluir" runat="server" Text="Excluir" CssClass="btn" />
        </div>
    </form>
</body>
</html>
