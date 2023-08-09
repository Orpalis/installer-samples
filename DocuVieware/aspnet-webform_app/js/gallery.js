function loadDocument(doc, elem) {
    if (doc) {
        DocuViewareAPI.PostCustomServerAction("DocuVieware1", true, "load", decodeURIComponent(doc),
            function () {
                resetButtons();
                elem.parentElement.className += " item-selected";
            },
            function () {
                resetButtons();
            }
        );
    }
}

function resetButtons() {
    for (var i = 0; i < document.getElementById("gallery_container").children.length; i++) {
        document.getElementById("gallery_container").children[i].className = "thumbnail_container";
    }
}