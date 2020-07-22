
    $(
            function () {
        $("form").bind("submit", checkFrom);
    $(".loginbtn").click(function () {
        $.post(
            "/index/Loginget",
            { Username: $(".userTexbox").val(), Userpwd: $(".userpwdbox").val() },
            function (res) {
                console.log(typeof res.isdat);
                if (res.isdat == "true") {
                    window.location.href = "/index/index";
                }
                else {
                    $(".txt1").html("账号或密码错误！");
                    $(".txt1").css("color", "red");
                    $(".userTexbox").val("");
                    $(".userpwdbox").val("");
                }
            }, "json")
    });
}
);
        function checkuser() {
            if ($(".userTexbox").val() == "") {
        $(".txt1").css("color", "red");
    $(".txt1").html("账号不能为空！");
    $(".userTexbox").focus();
    return false;
            } else {
        $(".txt1").html("");
    return true;
}
}
        function checkowd1() {
            if ($(".userpwdbox").val() == "") {
        $(".txt3").css("color", "red");
    $(".txt3").html("密码不能为空！");
    $(".userpwdbox").focus();
    return false;
            } else {
        $(".txt3").html("");
    return true;
}
}
        function checkFrom() {
            if (checkuser() && checkowd1())
        return true;
    return false;
}
