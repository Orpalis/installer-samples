$(window).load(function () {
    $(".example").hover(
        function () {
            $(this).find(".layer_hover").finish().toggle("slide");
        }, function () {
            $(this).find(".layer_hover").finish().toggle("slide");
        }
    );
});