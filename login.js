//在窗体加载时，为登录按钮绑定点击事件  
$(document).ready(function () {  
    $("#login").click(function () {

        $.post('/login.ashx', {  
            //参数一：用户名  
            userName: $("#userName").val(),  
            //参数二：密码  
            passWord: $("#passWord").val()  
        },  
        //回调函数  
            function (data) {  
                //输出结果  
                alert(data);  
            },  
        //返回类型  
            "text"  
            );  
    });  
});