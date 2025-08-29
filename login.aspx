<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Agriculture_Equipment_Store.login" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <title>Login</title>

    <!-- ✅ Bootstrap CSS -->
    <link href="Content/bootstrap.min.css" rel="stylesheet" />

    <style>
        body {
            background: url('image/sunny-meadow-landscape.jpg') no-repeat center fixed;
            background-size: cover;
            font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
            animation: fadeIn 1.2s ease-in-out;
        }

        /* 🌾 Welcome Banner */
        .welcome-container {
            width: 100%;
            background: rgba(40, 167, 69, 0.9);
            color: white;
            font-size: 22px;
            font-weight: bold;
            padding: 8px 0;
            overflow: hidden;
            position: fixed; /* always at top */
            top: 0;
            left: 0;
        }

        .welcome-text {
            display: inline-block;
            white-space: nowrap;
            position: relative;
            animation: moveText 12s linear infinite;
        }

        @keyframes moveText {
            0% {
                left: 100%;
            }

            100% {
                left: -100%;
            }
        }

        /* ✨ Card Styling */
        .login-card {
            border-radius: 30px;
            background-color: rgba(255, 255, 255, 0.94);
            box-shadow: 0 8px 25px rgba(0, 128, 0, 0.35);
            border: 2px solid #28a745;
            transition: transform 0.3s ease, box-shadow 0.3s ease;
            margin-top: 70px; /* prevent overlap with banner */
        }

            .login-card:hover {
                transform: translateY(-8px) scale(1.02); /*mouse to move*/
                box-shadow: 0 12px 30px rgba(0, 128, 0, 0.45);
            }

            .login-card h3 {
                color: #28a745;
                font-weight: bold;
                text-shadow: 1px 1px 3px rgba(0, 128, 0, 0.3);
            }

        .form-control {
            border-radius: 20px;
            border: 2px solid #c3e6cb;
            transition: all 0.3s ease;
        }

            /*click textbox to event*/
            .form-control:focus {
                border-color: #28a745;
                box-shadow: 0 0 10px rgba(40, 167, 69, 0.4); /*only blur no offset*/
                transform: scale(1.02); /*zoom*/
            }

        .form-label {
            font-weight: 600;
            color: #155724; /*text color uname*/
        }


        .btn-success {
            background: linear-gradient(145deg, #28a745, #218838);
            border: none;
            font-weight: 600;
            border-radius: 12px;
            transition: all 0.3s ease;
        }

            .btn-success:hover {
                background: linear-gradient(135deg, #218838, #1e7e34);
                transform: scale(1.05);
                box-shadow: 0 6px 18px rgba(33, 136, 56, 0.5);
            }

            .btn-success:active {
                transform: scale(0.97);
            }

        @keyframes fadeIn {
            from {
                opacity: 0;
                transform: translateY(20px);
            }

            to {
                opacity: 1;
                transform: translateY(0);
            }
        }
    </style>
</head>
<body>



    <form id="form1" runat="server">
        <!-- 🌾 Welcome Banner -->
        <div class="welcome-container">
            <div class="welcome-text">🌾 Welcome to Agriculture Equipment Store 🌾</div>
        </div>

        <!-- Login Card -->
        <div class="container d-flex justify-content-center align-items-center vh-100">
            <div class="card p-4 login-card" style="width: 23rem; animation: fadeIn 1.2s ease;">
                <div class="text-center mb-3">
                    <h3>Login:</h3>
                </div>

                <div class="mb-3">
                    <asp:Label ID="lblUser" runat="server" Text="Username" CssClass="form-label"></asp:Label>
                    <asp:TextBox ID="txtUsername" runat="server" CssClass="form-control" placeholder="Enter username"></asp:TextBox>
                </div>

                <div class="mb-3">
                    <asp:Label ID="lblPass" runat="server" Text="Password" CssClass="form-label"></asp:Label>
                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" CssClass="form-control" placeholder="Enter password"></asp:TextBox>
                </div>

                <div class="d-grid mb-3">
                    <asp:Button ID="btnLogin" runat="server" Text="Login" CssClass="btn btn-success btn-block" OnClick="btnLogin_Click" />
                </div>

                <asp:Label ID="lblMessage" runat="server" CssClass="text-danger fw-bold"></asp:Label>
            </div>
        </div>
    </form>

    <!-- ✅ Bootstrap JS -->
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/js/bootstrap.bundle.min.js"></script>
</body>
</html>
