<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="signup.aspx.cs" Inherits="Captcha.WebForm1" %>
<%@ Register Assembly="BotDetect" Namespace="BotDetect.Web.UI" TagPrefix="BotDetect" %>

<!DOCTYPE html>

&nbsp;<html xmlns="http://www.w3.org/1999/xhtml"><head runat="server"><title></title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">
<script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js" integrity="sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM" crossorigin="anonymous"></script>
    <style type="text/css" >
        .auto-style1 {
            font-size: x-large;
        }

        .auto-style2 {
            width: 46%;
            height: 328px;
        }

        .auto-style3 {
            margin-top: 0px;
        }

        .auto-style4 {
            margin-left: 440px;
        }

        .auto-style5 {
            width: 274px;
        }

        .auto-style6 {
            height: 645px;
                                                                                                                                                             width: 1582px;
                                                                                                                                                         }
                                                                                                                                                         .auto-style7 {
                                                                                                                                                             font-size: xx-large;
                                                                                                                                                         }
                                                                                             .auto-style8 {
                                                                                                 height: 35px;
                                                                                             }
                                                                                             .auto-style9 {
                                                                                                 width: 274px;
                                                                                                 height: 35px;
                                                                                             }
    </style></head><body><form id="form1" runat="server" class="auto-style6" style="margin: auto; background-image: url('drawable/background.jpg'); clip: rect(auto, auto, auto, auto); width: auto; height: auto; top: auto; right: auto; bottom: auto; left: auto; table-layout: auto;">
        <strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <span class="auto-style1">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </span> <span class="auto-style7">PC ONLINE</span><span class="auto-style1"><br />
        <br />
        <br />
            </span></strong>
        <table class="auto-style2">
            <tr>
                <td>First Name</td>
                
                    <td class="auto-style5">
                        <asp:TextBox ID="firstname" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        &nbsp;</td>
            </tr>
            <tr>
                <td>Last Name</td>
                <td class="auto-style5"><strong>
                    <asp:TextBox ID="lastname" runat="server"></asp:TextBox>
                </strong>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>Username</td>
                <td class="auto-style5"><strong>
                    <asp:TextBox ID="username" runat="server"></asp:TextBox>
                </strong>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>password</td>
                <td class="auto-style5"><strong>
                    <asp:TextBox ID="password" runat="server"></asp:TextBox>
                </strong>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>confirm password</td>
                <td class="auto-style5"><strong>
                    <asp:TextBox ID="confirmpassword" runat="server"></asp:TextBox>
                </strong>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style8"></td>
                <td class="auto-style9"></td>
                <td class="auto-style8">
                    </td>
            </tr>
            <tr>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <BotDetect:WebFormsCaptcha ID="CaptchaBox" runat="server"/>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Cmsg" runat="server" Text=""></asp:Label>
                    </td>
                </tr>

            
        </table>


        <p class="auto-style4">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" CssClass="auto-style3" OnClick="Button1_Click1" Style="width: 99px" Text="Sign up" />
            &nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server"></asp:Label>
        </p>

    </form>



</body>
</html>
