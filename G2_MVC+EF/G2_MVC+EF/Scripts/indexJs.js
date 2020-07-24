

$(function () {
    $("#search_txt").click(function () {
        $(".searchBox_bomnav").css("display", "block");
        $(".searchBox_nav").css("display", "none");
    });

    $("#searchBox_bomnav").blur(function () {
        $(".searchBox_bomnav").css("display", "none");
        $(".searchBox_nav").css("display", "block");
    });
    if (cookieValue1 != null) {
        $(".login").css("display", "none");
    }
});
        function onout() {
        $(".bom_nav").css("display", "none");
    };
        function onover() {
        $(".bom_nav").css("display", "block");
    };
        function monver() {
        $(".xiala_box").css("display", "block");
    $(".login").css("color", "black");
};
        function monout() {
        $(".xiala_box").css("display", "none");
    $(".login").css("color", "white");
};
    