const ipcRenderer = require("electron").ipcRenderer;
const controlId = "dvcontrol";
//Get language change event from the menu and reload control
ipcRenderer.on('change-lang', function (event, lang) {
    launchControl(lang);
});
ipcRenderer.on('edit-document', function (event, type) {
    editDocument(type);
});

//We have to wait the end of the preload script to start the app
ipcRenderer.once('preload-done', () => launchControl());

//This is necessary because when we set the dv control in the innerHTML of a HTMLElement, electron does not execute the JS inside 
const evalPageScripts = () => {
    const scripts = document.querySelectorAll('#dvcontrol script');

    scripts.forEach((script) => {
        const newScript = document.createElement('script');
        newScript.type = 'text/javascript';
        newScript.innerText = script.innerText;

        if (script.parentNode) {
            script.parentNode.removeChild(script);
        }
        return document.body.appendChild(newScript);
    })
};

//Get the DV control from the server and display it in the window
function launchControl(lang) {
    //if no lang is provided, use Auto
    if (!lang) {
        lang = 0;
    }
    fetch(`${process.env.SERVER_SCHEME}://${process.env.SERVER_HOSTNAME}:${process.env.SERVER_PORT}/api/DocuVieware/GetDocuViewareControl`, {
        method: 'POST',
        body: JSON.stringify({
            SessionId: `${window.processId}`,
            ControlId: controlId,
            Lang: lang
        }),
        headers: new Headers({
            "Content-Type": "application/json"
        })
    })
        .then(response => response.json())
        .then(result => {
            document.body.innerHTML = result.htmlContent;
            evalPageScripts();
        });
}

function editDocument(type){
    switch (type) {
        case "AddSignatureFormField":
            DocuViewareAPI.RegisterOnAreaSelected(controlId, () => {
                let region = DocuViewareAPI.GetSelectionAreaCoordinates(controlId);
                DocuViewareAPI.ClearSelectionArea(controlId);
                DocuViewareAPI.SetMouseMode(controlId, 0);
                DocuViewareAPI.PostCustomServerAction(controlId, true, type, { region: region, formFieldName: "sign" }, () => {
                    DocuViewareAPI.RegisterOnAreaSelected(controlId, null);
                });
            });

            //Set mouse mode as selection area
            DocuViewareAPI.SetMouseMode(controlId, 3);
            break;
    }
}