<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="mestrodetalle.aspx.cs" Inherits="Api_El_gago.Formulario_web1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
    <br />
</p>
<p>
    Meaestro detalle traducciones</p>
<p>
</p>
    <asp:GridView ID="GridView1" runat="server" DataSourceID="SqlDataSource2" AutoGenerateColumns="False" DataKeyNames="codigo" AllowPaging="True" AllowSorting="True">
        <Columns>
            <asp:CommandField ShowSelectButton="True" />
            <asp:BoundField DataField="codigo" HeaderText="codigo" ReadOnly="True" SortExpression="codigo" />
            <asp:BoundField DataField="Palabra" HeaderText="Palabra" SortExpression="Palabra" />
            <asp:BoundField DataField="codigoingles" HeaderText="codigoingles" SortExpression="codigoingles" />
            <asp:BoundField DataField="codigofrances" HeaderText="codigofrances" SortExpression="codigofrances" />
            <asp:BoundField DataField="codigoaleman" HeaderText="codigoaleman" SortExpression="codigoaleman" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:idiomasConnectionString2 %>" SelectCommand="SELECT * FROM [español]"></asp:SqlDataSource>
<p>
</p>
<p>
    Traducciones</p>
<p>
    <asp:GridView ID="GridView2" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataSourceID="SqlDataSource3" DataKeyNames="codigo">
        <Columns>
            <asp:BoundField DataField="codigo" HeaderText="codigo" SortExpression="codigo" ReadOnly="True" />
            <asp:BoundField DataField="español" HeaderText="español" SortExpression="español" />
            <asp:BoundField DataField="ingles" HeaderText="ingles" SortExpression="ingles" />
            <asp:BoundField DataField="frances" HeaderText="frances" SortExpression="frances" />
            <asp:BoundField DataField="aleman" HeaderText="aleman" SortExpression="aleman" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:idiomasConnectionString4 %>" ProviderName="<%$ ConnectionStrings:idiomasConnectionString4.ProviderName %>" SelectCommand="SELECT * FROM [vista_Traducciones] WHERE ([codigo] = @codigo)">
        <SelectParameters>
            <asp:ControlParameter ControlID="GridView1" Name="codigo" PropertyName="SelectedValue" Type="Int32" />
        </SelectParameters>
    </asp:SqlDataSource>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:idiomasConnectionString3 %>" ProviderName="<%$ ConnectionStrings:idiomasConnectionString3.ProviderName %>" SelectCommand="SELECT * FROM [vista_Traducciones] WHERE ([español] = @español)">
        <SelectParameters>
            <asp:ControlParameter ControlID="GridView1" Name="español" PropertyName="SelectedValue" Type="String" />
        </SelectParameters>
    </asp:SqlDataSource>
</p>
<p>
</p>
</asp:Content>
