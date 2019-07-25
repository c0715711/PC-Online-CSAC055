<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="Captcha.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: x-large;
        }
        .auto-
            width: 36%;
            height: 93px;
        }
        .auto-style3 {
            width: 28px;
        }
        .auto-style4 {
            font-size: large;
        }
        .auto-style5 {
            font-size: xx-large;
        }
    </style>

   <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">
<script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js" integrity="sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM" crossorigin="anonymous"></script> 

</head>
<body style="background-image: url('Drawables/background.jpg'); height: 740px; width: 1255px;">
    
     
    <form id="form1" runat="server">
        <p>
            &nbsp;<strong><span class="auto-style1">&nbsp;&nbsp;&nbsp;&nbsp;</span></strong></p>
        <p>
            <strong><span class="auto-style1">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span><span class="auto-style5">&nbsp;&nbsp; PC ONLINE</span></strong></p>
        <p>
            &nbsp;</p>
        <table class="auto-style2">
            <tr>
                <td>Username</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="RequiredFieldValidator" ForeColor="Red">*</asp:RequiredFieldValidator>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
                <td class="auto-style3">
                    <asp:Button ID="Button3" runat="server" Text="Login" OnClick="Button3_Click" Width="73px" />
                </td>
            </tr>
            <tr>
                <td>password</td>
                <td colspan="2">
                    <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="RequiredFieldValidator" ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
            </tr>
        </table>
        <p>
            &nbsp;<asp:Label ID="Label3" runat="server"></asp:Label>
        </p>
        <p>
            <strong><span class="auto-style4">Don&#39;t have an Account ?&nbsp;&nbsp; </span></strong>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Sign up" CausesValidation="False" Height="40px" Width="99px" />
        </p>
        <p>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
        </p>
    </form>
        
</body>
    
</html>
