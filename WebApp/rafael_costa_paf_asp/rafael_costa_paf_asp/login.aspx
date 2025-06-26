<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="rafael_costa_paf_asp.login" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login - AirAtec</title>
    <style>
        body {
            margin: 0;
            font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
            background: linear-gradient(to right, #005fa3, #00aaff);
            height: 100vh;
            display: flex;
            justify-content: center;
            align-items: center;
        }

        .login-box {
            background-color: white;
            padding: 40px 30px;
            border-radius: 12px;
            box-shadow: 0 15px 35px rgba(0, 0, 0, 0.2);
            max-width: 500px;
            width: 100%;
        }

        .logo {
            text-align: center;
            margin-bottom: 20px;
        }

        .logo img {
            width: 120px;
        }

        h2, h3 {
            text-align: center;
            color: #005fa3;
            margin-bottom: 15px;
        }

        .form-input {
            width: 100%;
            padding: 12px;
            margin: 10px 0;
            border: 1px solid #ccc;
            border-radius: 8px;
            font-size: 15px;
            box-sizing: border-box;
        }

        .asp-button {
            width: 100%;
            padding: 12px;
            background-color: #007acc;
            color: white;
            border: none;
            border-radius: 8px;
            font-size: 16px;
            margin-top: 15px;
            cursor: pointer;
            transition: background-color 0.3s;
        }

        .asp-button:hover {
            background-color: #005fa3;
        }

        .status-label {
            margin-top: 15px;
            color: red;
            font-size: 14px;
            text-align: center;
        }

        .create-account {
            text-align: center;
            margin-top: 20px;
            font-size: 14px;
        }

        .create-account a {
            color: #007acc;
            text-decoration: none;
            font-weight: bold;
        }

        .create-account a:hover {
            text-decoration: underline;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="login-box">
            <div class="logo">
                <img src="imagens/airatec.png" alt="AirAtec Logo" />
            </div>
            <h2>Bem-vindo à AirAtec</h2>
            <h3>Entre com a sua conta</h3>
            <label>Utilizador:</label>
            <asp:TextBox ID="tb_username" runat="server" placeholder="Utilizador" CssClass="form-input" />
            <label>Password:</label>
            <asp:TextBox ID="tb_password" runat="server" TextMode="Password" placeholder="Password" CssClass="form-input" />
            <asp:Button ID="btn_login" runat="server" Text="Entrar" CssClass="asp-button" OnClick="btn_login_Click" />
            <asp:Label ID="lbl_loginEstado" runat="server" CssClass="status-label" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
