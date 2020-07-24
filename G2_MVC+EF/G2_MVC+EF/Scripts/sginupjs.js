$(function () {
    var name = $(".username").val();
    var emali = $(".emalibox").val();
    var pwd = $(".pwd").val();
    var qrpwa = $(".QRpwd").val();
    $(".submintbtn").click(function () {
        alert("ok");
        if (name != "" && emali != "" && pwd != "" && qrpwa != "") {
            console.log("11111");
            $.post("/Index/Getsginup", { name, emali, pwd, qrpwa },
                function () {

                },"json"
            );
        }
    });
});