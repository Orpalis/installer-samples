function loadFromFile() {
    DocuViewareAPI.LoadFromFile('DocuVieware1'
        , updateToolbarUI
        , updateToolbarUI
    );
}

function loadFromUri() {
    $('#document_uri_area').slideUp();
    var uri = $('input[name="document_uri"]').val();
    if (uri != null) {
        DocuViewareAPI.LoadFromUri('DocuVieware1'
            , uri
            , updateToolbarUI
            , updateToolbarUI
        );
    }
}

function previousPage() {
    changePage(parseInt($('input[name="current_page"]').val()) - 1);
}

function nextPage() {
    changePage(parseInt($('input[name="current_page"]').val()) + 1);
}

function changePage(nb) {
    var pageCount = DocuViewareAPI.GetPageCount('DocuVieware1');
    if (nb < 1) {
        nb = 1;
    }
    if (nb > pageCount) {
        nb = pageCount;
    }
    if (nb != 0) {
        DocuViewareAPI.SelectPage('DocuVieware1', nb);
    }
}

function zoomIn() {
    DocuViewareAPI.ZoomIN('DocuVieware1');
}

function zoomOut() {
    DocuViewareAPI.ZoomOUT('DocuVieware1');
}

function updateToolbarUI() {
    var pageCount = DocuViewareAPI.GetPageCount('DocuVieware1');
    var currentPage = DocuViewareAPI.GetCurrentPage('DocuVieware1');
    $('#sp_page_count').html(pageCount);
    $('input[name="current_page"]').val(currentPage);
    if (pageCount == 0) {
        $('.page_navigation').addClass('disabled');
        $('#bt_print').addClass('disabled');
        $('#bt_zoom_out').addClass('disabled');
        $('#bt_zoom_in').addClass('disabled');
        $('#bt_print').attr('disabled', 'disabled');
        $('#bt_zoom_out').attr('disabled', 'disabled');
        $('#bt_zoom_in').attr('disabled', 'disabled');
        $('input[name="current_page"]').attr('disabled', 'disabled');
    }
    else {
        $('.page_navigation').removeClass('disabled');
        $('#bt_print').removeClass('disabled');
        $('#bt_zoom_out').removeClass('disabled');
        $('#bt_zoom_in').removeClass('disabled');
        $('#bt_print').removeAttr('disabled');
        $('#bt_zoom_out').removeAttr('disabled');
        $('#bt_zoom_in').removeAttr('disabled');
        $('input[name="current_page"]').removeAttr('disabled');
    }
    if (currentPage == 0 || currentPage == 1) {
        $("#bt_select_page_prev").addClass('disabled');
        $('#bt_select_page_prev').attr('disabled', 'disabled');
    }
    else {
        $("#bt_select_page_prev").removeClass('disabled');
        $("#bt_select_page_prev").removeAttr('disabled');
    }
    if (currentPage == pageCount) {
        $("#bt_select_page_next").addClass('disabled');
        $('#bt_select_page_next').attr('disabled', 'disabled');
    }
    else {
        $("#bt_select_page_next").removeClass('disabled');
        $("#bt_select_page_next").removeAttr('disabled');
    }
    if (pageCount != 0) {
        $(".toolbar_container").finish().fadeOut(600);
    }
    else {
        $(".toolbar_container").finish().show();
    }
}

function onZoomChange() {
    zoom = Math.round(parseFloat(DocuViewareAPI.GetCurrentZoom('DocuVieware1')) * 100);
    $("#zoom_level_value").html(zoom);
    $("#zoom_level").finish().fadeIn(300).delay(1000).fadeOut(300);
}

function isEnabled(elem) {
    var attr = elem.attr('disabled');
    if (typeof attr !== typeof undefined && attr !== false) {
        return false;
    }
    return true;
}

$(document).ready(function () {
    $(".toolbar_hover").hover(function () {
        $(".toolbar_container").finish().fadeIn(300);
    }, function () {
        if (DocuViewareAPI.GetPageCount('DocuVieware1') != 0) {
            $(".toolbar_container").finish().delay(1000).fadeOut(600);
        }
    });
    $(".toolbar_container").show();
    DocuViewareAPI.RegisterOnPageChanged('DocuVieware1', updateToolbarUI);
    DocuViewareAPI.RegisterOnZoomChanged('DocuVieware1', onZoomChange);
    updateToolbarUI();
});