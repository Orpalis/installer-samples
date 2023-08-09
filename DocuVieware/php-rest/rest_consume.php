<?php
session_start();
header('Content-Type: text/html; charset=utf-8');
ini_set('display_errors', 1);
ini_set('display_startup_errors', 1);
error_reporting(E_ALL);

$docuViewareConfig = array(
    'SessionId' => session_id(),
    'ControlId' => 'DocuVieware1',
    'AllowPrint' => true,
    'EnablePrintButton' => true,
    'AllowUpload' => true,
    'EnableFileUploadButton' => true,
    'CollapsedSnapIn' => true,
    'ShowAnnotationsSnapIn' => true,
    'EnableRotateButtons' => true,
    'EnableZoomButtons' => true,
    'EnablePageViewButtons' => true,
    'EnableMultipleThumbnailSelection' => true,
    'EnableMouseModeButtons' => true,
    'EnableFormFieldsEdition' => true,
    'EnableTwainAcquisitionButton' => true,
    'Locale' => substr($_SERVER['HTTP_ACCEPT_LANGUAGE'], 0, 2)
);
$data_string = json_encode($docuViewareConfig);

$ch = curl_init('http://localhost:62968/api/DocuViewareREST/GetDocuViewareControl');
curl_setopt($ch, CURLOPT_CUSTOMREQUEST, 'POST');
curl_setopt($ch, CURLOPT_POSTFIELDS, $data_string);
curl_setopt($ch, CURLOPT_RETURNTRANSFER, true);
curl_setopt($ch, CURLOPT_HTTPHEADER, array(
    'Content-Type: application/json',
    'Content-Length: ' . strlen($data_string))
);
$result = curl_exec($ch);
if ($result === false) {
    $info = curl_getinfo($ch);
    curl_close($ch);
    die('Error occured during curl exec.: ' . var_export($info));
}
curl_close($ch);
$docuViewareControlHtml = $result;
?>
<!DOCTYPE html>
<html>
    <head>
        <title>DocuVieware PHP App</title>
        <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.1.1/jquery.min.js"></script>
        <link rel="stylesheet" type="text/css" href="docuvieware-min.css" />
        <script src="docuvieware-min.js"></script>
    </head>
    <body>
        <div id="dvContainer" style="width:1200px;height:1000px;">
            <?php
            $html = json_decode($docuViewareControlHtml);
            print $html->{'HtmlContent'};
            ?>
        </div>
    </body>
</html>