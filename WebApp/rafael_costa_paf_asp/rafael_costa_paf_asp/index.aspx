<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="rafael_costa_paf_asp.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Reservas - AirAtec</title>
    <style>
        body {
            font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
            margin: 0;
            padding: 0;
        }

        .main-container {
            padding: 40px;
            max-width: 1200px;
            margin: 0 auto;
        }

        h1, h2 {
            text-align: center;
            color: #333;
        }

        .logout-button {
            float: right;
            margin: 20px;
            padding: 10px 20px;
            background-color: rgb(0, 76, 146);
            color: white;
            border: none;
            border-radius: 6px;
            cursor: pointer;
            font-size: 14px;
        }

        .logout-button:hover {
            background-color: rgb(8, 66, 118);
        }

        .gridview-container {
            margin-top: 30px;
        }

        .gridview-style {
            width: 100%;
            border-collapse: collapse;
        }

        .gridview-style th, .gridview-style td {
            padding: 10px;
            text-align: left;
            border-bottom: 1px solid #ddd;
        }

        .gridview-style th {
            background-color: rgb(0, 76, 146);
            color: white;
        }

        .gridview-style tr:nth-child(even) {
            background-color: #f2f2f2;
        }

        .gridview-style tr:hover {
            background-color: #e9f1f7;
        }

        .error-label {
            display: block;
            margin-top: 20px;
            text-align: center;
            color: #ff3300;
            font-weight: bold;
        }

        /* Optional: clear floats */
        .clearfix::after {
            content: "";
            clear: both;
            display: table;
        }

        .asp-button {
            background-color: rgb(0, 76, 146);
            border-radius: 5px;
            color: white;
            border: 0;
            padding: 8px;
        }

        .asp-button:hover {
            background-color: rgb(8, 66, 118);
        }

    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="main-container">
            <div class="clearfix">
                <img src="imagens/airatec.png" style="width: 80px;"/>
                <asp:Button ID="btn_logout" runat="server" Text="Logout" CssClass="logout-button" OnClick="btn_logout_Click" />
            </div>

            <h1>Bem-vindo <%= rafael_costa_paf_asp.Geral.nomeCompleto %>!</h1>
            <h2>Aqui estão as suas Reservas</h2>

            <div class="gridview-container">
                <asp:GridView ID="gv_dadosReservas" runat="server" CssClass="gridview-style" AutoGenerateColumns="true"
                    CellPadding="4" ForeColor="#333333" GridLines="None" EmptyDataText="Não existem reservas." OnRowCommand="gv_dadosReservas_RowCommand">
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <EditRowStyle BackColor="#999999" />
                    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />

                    <Columns>
                         <asp:TemplateField>
                             <ItemTemplate>
                                 <asp:Button ID="btnExportar" runat="server" Text="Exportar PDF" CommandName="Exportar" CommandArgument='<%# Eval("Reserva") %>' CssClass="asp-button" />
                             </ItemTemplate>
                         </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </div>
            <asp:Label ID="lbl_erro" runat="server" CssClass="error-label" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
