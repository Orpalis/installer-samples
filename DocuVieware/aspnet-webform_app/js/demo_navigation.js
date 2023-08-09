$(document).ready(function () {
    $(".slider-button").click(function () {
        setSliderPanel('#' + $(this).attr("data-slider"));
        $(".row").children(".tnb").removeClass("tnb-active");
        $(this).parent(".tnb").addClass("tnb-active");
    });
    setSliderPanel("#" + $("#link-annotations").attr("data-slider"));
});

function setSliderPanel(elem) {
    $(".slider-panel").hide();
    $(".img-slider").hide();
    $(".img-slider").removeAttr("style");
    $(elem).fadeIn("fast");
    $(".img-slider").fadeIn(600);
    $(".img-slider").animate({ left: "+=50" }, 500);
}