//�ڴ������ʱ��Ϊ��¼��ť�󶨵���¼�  
$(document).ready(function () {  
    $("#login").click(function () {

        $.post('/login.ashx', {  
            //����һ���û���  
            userName: $("#userName").val(),  
            //������������  
            passWord: $("#passWord").val()  
        },  
        //�ص�����  
            function (data) {  
                //������  
                alert(data);  
            },  
        //��������  
            "text"  
            );  
    });  
});