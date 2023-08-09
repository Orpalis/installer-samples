window.onload = function (e) {
    $("#navigation .navigation-close").click(function (e) {
        e.preventDefault();
        $("#navigation .navigation-close").animate({ right: "0px" }, 200);
        $("#navigation .navigation-open").animate({ right: "0px" }, 200);
        $("#navigation .navigation-close").hide();
        $("#navigation .navigation-open").show();
        $("#navigation #container").hide("slide", { direction: "right" }, 200);
    });
    $("#navigation .navigation-open").click(function (e) {
        e.preventDefault();
        $("#navigation .navigation-open").animate({ right: "350px" }, 200);
        $("#navigation .navigation-close").animate({ right: "350px" }, 200);
        $("#navigation .navigation-open").hide();
        $("#navigation .navigation-close").show();
        $("#navigation #container").show("slide", { direction: "right" }, 200);
    });
    $("#navigation .navigation-open").trigger("click");
    $("#navigation #container").show("slide", { direction: "right" }, 200);
};

function applyFilter(actionName) {
    if (actionName) {
        var pages = DocuViewareAPI.GetSelectedThumbnailItems("DocuVieware1");
        var roi = DocuViewareAPI.GetSelectionAreaCoordinates("DocuVieware1");
        if (pages.length == 0) {
            pages[0] = DocuViewareAPI.GetCurrentPage("DocuVieware1");
        }
        var params = { pages: pages, RegionOfInterest: roi };
        DocuViewareAPI.PostCustomServerAction("DocuVieware1", true, actionName, params);
    }
    return false;
}