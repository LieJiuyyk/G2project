
$(function () {
    $("#search_txt").on('input propertychange',function () {
        $.post(
            "/Index/Gettxt1",
            { text: $("#search_txt").val() },
            function (data) {
                var textconter = "";
                for (var i = 0; i < data.length; i++) {
                    textconter += '<li class="listst"><a href="/index/shangpxq?id=' + data[i].ComId + '">' + data[i].CName + '</a></li>';
                    $(".searchBox_bomnav2").html(textconter);
                }
            }, "json");

    });
    });