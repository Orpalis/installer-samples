$(document).ready(function () {
    $("#navigation .navigation-close").click(function (e) {
        e.preventDefault();
        $("#navigation .navigation-close").animate({ right: "0px", }, 200);
        $("#navigation .navigation-open").animate({ right: "0px", }, 200);
        $("#navigation .navigation-close").hide();
        $("#navigation .navigation-open").show();
        $("#navigation #container").hide("slide", { direction: "right" }, 200);
    });
    $("#navigation .navigation-open").click(function (e) {
        e.preventDefault();
        $("#navigation .navigation-open").animate({ right: "325px", }, 200);
        $("#navigation .navigation-close").animate({ right: "325px", }, 200);
        $("#navigation .navigation-open").hide();
        $("#navigation .navigation-close").show();
        $("#navigation #container").show("slide", { direction: "right" }, 200);
    });
    $("#navigation .navigation-close").trigger("click");
    $("#navigation #container").hide("slide", { direction: "right" }, 200);

    $(".color-box").each(function () {
        $(this).colpick({
            layout: "full",
            color: $('input[name="' + $(this).data("hidden_val") + '"]').val(),
            onSubmit: function (hsb, hex, rgb, el) {
                $(el).css("background-color", "#" + hex);
                $(el).colpickHide();
                $('input[name="' + $(el).data("hidden_val") + '"]').val("#" + hex);
            }
        }).css("background-color", $('input[name="' + $(this).data("hidden_val") + '"]').val());
    });

    $("input.input_dimensions").keypress(function (e) {
        var c = e.which || e.keyCode;
        if (c != 8 && c != 46 && c != 35 && c != 36 && c != 37 && c != 38 && c != 39 && c != 40 && (c < 48 || c > 57)) return false;
    });

    $('input[name="show_toolbar"]').change(function () {
        if (this.checked) {
            $("#toolbar_buttons").slideDown();
            $("#toolbar_bgcolor").slideDown();
        }
        else {
            $("#toolbar_buttons").slideUp();
            $("#toolbar_bgcolor").slideUp();
        }
    });
    $('input[name="show_toolbar"]').change();

    $('input[name="show_thumbnails"]').change(function () {
        if (this.checked) {
            $("#thumbnail_dimensions").slideDown();
            $("#thumbnail_bgcolor").slideDown();
        }
        else {
            $("#thumbnail_dimensions").slideUp();
            $("#thumbnail_bgcolor").slideUp();
        }
    });
    $('input[name="show_thumbnails"]').change();

    $('input[name="show_annotations"]').change(function () {
        if (this.checked) {
            $("ul.nav li a[href='#sectionAnnotations']").attr("data-toggle", "tab").parent().removeClass("disabled");
        }
        else {
            $("ul.nav li a[href='#sectionAnnotations']").attr("data-toggle", "").parent().addClass("disabled");
        }
    });
    $('input[name="show_annotations"]').change();

    $('input[name="show_zoom"]').change(function () {
        if (this.checked) {
            $("#zoom_step_div").slideDown();
        }
        else {
            $("#zoom_step_div").slideUp();
        }
    });
    $('input[name="show_zoom"]').change();

    $('input[name="show_print"]').change(function () {
        if (this.checked) {
            $("#print_quality_div").slideDown();
        }
        else {
            $("#print_quality_div").slideUp();
        }
    });
    $('input[name="show_print"]').change();

    $('input[name="enable_annotation"]').change(function () {
        if (this.checked) {
            $('input[name="show_annotation"]').parent().parent().show();
        }
        else {
            $('input[name="show_annotation"]').parent().parent().hide();
        }
    });
    $('input[name="enable_annotation"]').change();
});