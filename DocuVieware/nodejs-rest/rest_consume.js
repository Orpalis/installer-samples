var http = require('http');

var docuViewareConfiguration = JSON.stringify({
    'SessionId': 'mySessionId', //Set to an arbitrary value, should be replaced by the session identifier from your session mechanism
    'ControlId': 'DocuVieware1',
    'AllowPrint': true,
    'EnablePrintButton': true,
    'AllowUpload': true,
    'EnableFileUploadButton': true,
    'CollapsedSnapIn': true,
    'ShowAnnotationsSnapIn': true,
    'EnableRotateButtons': true,
    'EnableZoomButtons': true,
    'EnablePageViewButtons': true,
    'EnableMultipleThumbnailSelection': true,
    'EnableMouseModeButtons': true,
    'EnableFormFieldsEdition': true,
    'EnableTwainAcquisitionButton': true
});

var postheaders = {
    'Content-Type': 'application/json',
    'Content-Length': Buffer.byteLength(docuViewareConfiguration, 'utf8')
};

var optionspost = {
    host: 'localhost',
    port: 65346,
    path: '/api/DocuViewareREST/GetDocuViewareControl',
    method: 'POST',
    headers: postheaders
};

var reqPost = http.request(optionspost, function (res) {
    res.on('data', function (data) {
        console.log(data.toString());
    });
});

reqPost.write(docuViewareConfiguration);
reqPost.end();
reqPost.on('error', function (e) {
    console.error(e);
});