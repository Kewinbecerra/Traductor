<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Api_El_gago._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
    <section class="row">
        <div class="col-md-6">
            <h2>Traductor Español</h2>
            <asp:Label ID="Label1" runat="server" Text="Ingrese una palabra en español:"></asp:Label><br />
            <asp:TextBox ID="txtPalabra" runat="server" CssClass="form-control" /><br />
            <asp:Button ID="btnTraducir" runat="server" Text="Traducir" CssClass="btn btn-primary" OnClick="btnTraducir_Click" /><br /><br />
            
            <asp:Label ID="lblIngles" runat="server" Text="Inglés: " /><br />
            <asp:Label ID="lblFrances" runat="server" Text="Francés: " /><br />
            <asp:Label ID="lblAleman" runat="server" Text="Alemán: " /><br />
            <asp:Label ID="lblSinonimos" runat="server" Text="Sinónimos: " /><br />
        </div>
    </section>
</main>

</asp:Content>
