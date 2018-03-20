<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication_denglu.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="StyleSheet_DENGLU.css" rel="stylesheet" type="text/css">
    <script type="text/javascript">
        function Button_ok_Click() {
            alert("a");
         }
    </script>
</head>
<body id="body" >

    <form id="form1" runat="server">
    <div id="denglu" class="whloe">
        <div id="name" class="whloe">
            <div class="part1">用户名</div>
            <div class="part2">&nbsp;<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></div>    
        </div>
        <div id="pvd" class="whloe">
            <div class="part1">密码</div>
            <div class="part2">&nbsp;<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></div>    
        </div>
        <div id="check" class="whloe">
            <div class="part1">验证码</div>
            <div class="part2">
            &nbsp;<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            &nbsp;<asp:TextBox ID="TextBox4" runat="server" 
                    ontextchanged="TextBox4_TextChanged"></asp:TextBox>
            </div>    
        </div>
        <div id="butten" class="whloe">
            <div class="part1">
                <asp:Button ID="Button_ok" class=login-button runat="server" Text="登陆" onclick="Button_ok_Click" Width="50px"   /></div>
            <div id="cz"  class="part2">
                <asp:Button ID="Button_re" class=login-button runat="server" Text="重置" onclick="Button_re_Click" Width="50px"/></div> 
        </div>
    </div>
    </form>

</body>
</html>
