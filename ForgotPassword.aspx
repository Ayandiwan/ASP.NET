<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ForgotPassword.aspx.cs" Inherits="Agriculture_Equipment_Store.ForgotPassword" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <title>Forgot Password - Agriculture Store</title>
    <link href="bootstrap/css/bootstrap.min.css" rel="stylesheet" />
    <style>
        body {
            background: linear-gradient(to bottom, #d4edda, #ffffff);
            font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
        }

        /* Smaller card */
        .forgot-password-card {
            max-width: 350px;  /* Reduced width */
            margin: 40px auto; /* Reduced top/bottom margin */
            padding: 25px 20px; /* Reduced padding */
            border-radius: 15px;
            box-shadow: 0 6px 20px rgba(0, 128, 0, 0.15);
            background-color: #fefefe;
            border-top: 4px solid #28a745;
        }

        .forgot-password-card h3 {
            color: #155724;
            margin-bottom: 20px; /* Reduced spacing */
            font-weight: 600;
            font-size: 1.4rem;  /* Slightly smaller heading */
        }

        .btn-success {
            width: 100%;
            font-weight: 500;
            padding: 8px 0; /* Reduced button height */
        }

        .form-label {
            font-weight: 500;
            font-size: 0.9rem; /* Slightly smaller labels */
        }

        .form-control {
            font-size: 0.9rem; /* Smaller input text */
            padding: 6px 10px; /* Tighter padding */
        }

        .text-danger {
            font-size: 0.8em; /* Smaller error messages */
        }

        .login-link {
            display: block;
            text-align: center;
            margin-top: 12px; /* Reduced spacing */
            color: #28a745;
            font-weight: 500;
            font-size: 0.9rem;
        }

        .login-link:hover {
            text-decoration: underline;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="forgot-password-card">
            <h3 class="text-center">Forgot Password</h3>

            <!-- Username -->
            <div class="mb-2">
                <asp:Label ID="lbluname" runat="server" Text="Username" CssClass="form-label"></asp:Label>
                <asp:TextBox ID="txtuname" runat="server" CssClass="form-control" placeholder="Enter Username"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rf1" runat="server" ErrorMessage="Please enter Username" ControlToValidate="txtuname" Display="Dynamic" SetFocusOnError="True" ForeColor="Red" />
            </div>

            <!-- Current Password -->
            <div class="mb-2">
                <asp:Label ID="lblcurpass" runat="server" Text="Current Password" CssClass="form-label"></asp:Label>
                <asp:TextBox ID="txtcurpas" runat="server" TextMode="Password" CssClass="form-control" placeholder="Enter Current Password"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rf2" runat="server" ErrorMessage="Please enter Current Password" ControlToValidate="txtcurpas" Display="Dynamic" SetFocusOnError="True" ForeColor="Red" />
            </div>

            <!-- New Password -->
            <div class="mb-2">
                <asp:Label ID="lblnewpasss" runat="server" Text="New Password" CssClass="form-label"></asp:Label>
                <asp:TextBox ID="txtnewpass" runat="server" TextMode="Password" CssClass="form-control" placeholder="Enter New Password"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rf3" runat="server" ErrorMessage="Please enter New Password" ControlToValidate="txtnewpass" Display="Dynamic" SetFocusOnError="True" ForeColor="Red" />
            </div>

            <!-- Repeat Password -->
            <div class="mb-2">
                <asp:Label ID="lblreppas" runat="server" Text="Repeat Password" CssClass="form-label"></asp:Label>
                <asp:TextBox ID="txtreppas" runat="server" TextMode="Password" CssClass="form-control" placeholder="Repeat New Password"></asp:TextBox>
                <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Passwords do not match" ControlToCompare="txtnewpass" ControlToValidate="txtreppas" SetFocusOnError="True" ForeColor="Red"></asp:CompareValidator>
            </div>

            <!-- Submit Button -->
            <div class="d-grid">
                <asp:Button ID="btnsubmit" runat="server" Text="Reset Password" CssClass="btn btn-success" OnClick="btnsubmit_Click" />
            </div>

            <a href="login.aspx" class="login-link">Back to Login</a>
        </div>
    </form>
</body>
</html>
