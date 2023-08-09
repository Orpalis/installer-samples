<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="formfields_demo.aspx.cs" Inherits="DocuVieware_webform_app_demo.FormfieldsDemo" %>

<%@ Register Assembly="GdPicture.NET.14.WEB.DocuVieware" Namespace="GdPicture14.WEB" TagPrefix="cc1" %>

<!DOCTYPE html>

<html>
<head>
    <title>DocuVieware - PDF Form Fieds Demo.</title>
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
    <link href="favicon.ico" rel="icon" />
    <link href="style/formfields.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript">
        function Calculate() {
            DocuViewareAPI.PostCustomServerAction('DocuVieware1', true, "Calculate");
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div id="description_container">
            <!-- Demo explanations -->
            <p>DocuVieware 3.0 provides support for PDF Form Fields. The fields are displayed, the user can interact with them and the content of the fields can be save to the PDF. Finally, the server side application read and writes the content of the fields.</p>
            <p>This capability offers a convenient way for the user to interact with the information system:</p>
            <ul>
                <li>the user can feed the business process with data entered in the fields of a PDF</li>
                <li>the user can get a simple PDF with all the information he needs back from the business process</li>
                <li>The logic implemented server side can automatically create the PDF and fill in the required information</li>
            </ul>
            <p>DocuVieware 3.0 provides the possibility for the user to fill in the fields.</p>
            <p>The data can be processed (populated or read) on the server side by the mean of GdPicture.NET 14.</p>
            <hr />
            <p>In this demonstration we offer the possibility to fill in an invoice, you can type the invoice number, articles references and obviously quantities and unit price.</p>
            <p>Once done, when you click on the calculation button, a custom action is triggered server side and the subtotal, VAT amount and total are computed and put back into the document for you to see the result.</p>
            <p>For convenience, you might want to save or print the resulting document (to send the actual invoice to someone) and this is achieved with the save and print buttons.</p>
        </div>
        <div id="application_container">
            <div id="toolbar_container">
                <!-- Toolbar -->
                <!-- This button will trigger the server side DocuVieware custom action that will calculate the subtotal, VAT amout and total -->
                <button type="button" onclick="Calculate();">
                    <img src="data:image/png;base64,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" alt="Calculate" />
                </button>
                <!-- This ASP button will start the download of a flatten (non editable) version of the PDF -->
                <asp:ImageButton ID="btnSaveAsPdf" runat="server" OnClick="btnSaveAsPdf_Click" ImageUrl="data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAADAAAAAwCAYAAABXAvmHAAAACXBIWXMAAA7EAAAOxAGVKw4bAAAFMklEQVRoge2abYhUVRjHf3dmErUWzZYtNdk0UjOE5F4oK618a4e8Es5tUZC+1JfsRRuViigxqCB1SD9UkJCh0apzN/UWd9liITMVudfIWms/hPlSSGyZq6uWOzN9OGd2rzNz13t3Z9wV/MPwnHnOy/z/c57znHPujJLL5QgKV9fmAs3y7RHVcu4J3LlCUEIKOAmMBY4AU4BVquWsqxC3QIiFbD9W2peBT4C7y0snPMIK8PY7BpwuI5c+EwmDTuBGxEwMA74uO6OQKBKQSqSjQFeBe3rSNA4AJ4DJwF3SXpR9moDHKku1GEnTUILOwFTgAPAdgviL0n9c2jFl5hYYQQVMlvawtIq0vwMkTaOmnKQAuv7LcLb9PD+1/Iazsw2/ZBlUwAPSWsCGvFO1nH+BCHBLP7iWRGxIlJvHVDFjyVQUBQ42tpVuF3A8tePPzptUyznq6lrelx+xNsQ4fcKUR2r7LeCGqurhtUArIvPMASbJuqPA98C0fvL0RVX1cN+6oAIcJaK0yvKcvNPVtRWq5awH3kCEV0WgRBTfuqAC3gJwde3VAv86YD3whW3bDcCivhD0QlEU6urqArcPIuAXYJcsvy2tCSQAXF3brlpOfTwefw64l56MdVUQRMCapGnkXF1bmneolmO4umYCC4EnXV1boFrObmAeYAPeU2oWyAHRMvLuxpUE/ABsk+V8+twCoFpOwtW1c4ijxS5X12aqlvOtbdsaYkGfBv4Azsl+QxA7uIYQ/jg9+0k3yh1Cq+W3/5Kn7Que+hrE+Qhgj6trS+OW8wGwv8RYF4Ef5etjYC6wE/BPMQHQm4BDSdPIx35K2kbVcs7kG6iWcx5QXF07DowD3nd1bRlwAbgVGF0w5klgN7BStZyvgNcRSaAiAl4DcHXtFQ/h/MKtAp4AFgAPAbd5+k3CH7cDS4HFwCjbtndTIKBcIbQjaRpNsvyOtFtdXVsOrKTnYpNHO+Kwdwh4CrjDU/cr8CGwVbWcU66urQLeBYjH4xcCMw0hIJs0jXoAV9c2efxL5AvABZqAJtVy9hb0X+3q2ixgDWJ27gTWAms9x5BT0vb7EFgkIGkaOUl+JvC0dHcCjcAWGbuXwbbtCYjMUwVsj1tOC9Di6towxOY2H7gfsSZOAfWy332FY4UNoaJLvatrBvApIu0BoFqON90piFT4KDADcVId5an/B9gEbEacnfwwDvgGGH8lkl2XMmxc9HmRv+hC4+raPmA6cN4jYHFeB+IiM4/LF20hRiLWyQrgZ6AF2CPLfyHCZhawiuIsFRoxSbwK6JC+rYAuywdVy2lIJdLDkqaxA8+3lclkaG5uphcoiEcvU4DngxIKnYVcXYt5yH8ETARGyPcPSruWgqmORqPE4/HAH1QpxIAvZXkf4nb1sHw/W7WcrlQiPRt4diDIdSPr//AthohpgGp6ss6bquW0pBLp0YhtP5LNZIlEIxXl6Yezf/tvFzF6blMTpW+ZajkbU4n0UEQmGQfQfryDmvEjK8vUB217T/jWKblcDlfX5iM2nM2q5ZyR5D9DHBcAqJkwklnPTKO6dgRDhlb0CtyNc6cv0NpyjP3bWslmisMoaRpKyYe7qUT6MOJZ0KBGyQdbqUQ6wjVAPo9SseB/gx6E6FMwJ02j3DxKIpvJ8l59Y69trs5qrCDKJmDDokYyl7JF/uXbF1Z0/7g+AwON6wIGGtcFDDRKXeozgJJKpIP/Aj6A8J2BpGlcEyJ6DaEwIpY1LCwPo5AI9F+JwToTgX8nHszhFOrfKoMR/wPSMYy58IJtegAAAABJRU5ErkJggg==" />
                <!-- This button will trigger the print dialog so the user can print the page -->
                <button type="button" onclick="DocuViewareAPI.Print('DocuVieware1');">
                    <img src="data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAADAAAAAwCAYAAABXAvmHAAAACXBIWXMAAA7EAAAOxAGVKw4bAAACkUlEQVRoge2ZT2sTQRjGfzvZSGh6MfHgSRBBWlBj0UM8KIJC9KwfoBdFi0cRJiFIkDBeBA+lXjwoXv0AQiMS9JRQqKBSFCzeK16Ca6yZ9ZA/tP7p7myWJJvkB3vYZd7J88y8+87OxHJdlyhjD1tAv0wNDBtjA/l8/pzrusvAMcAKUcuGEGKpXC6/MgkyNtARf9w0zgdzWusVYN4kKEgKzQOUy2WEEAHC/42UEmDONG7y3oFRY2pg2ETegOXnW2jxwWpyc6vZGICeHofSicSz2xebXu18zUB6Ns7mlmdfoZKajftq15sBKeV5YBk4CvSiS6USLQSX7r4IX+UerN67jC0sCoXCzsffgTXgplLqPeyegUcEWEgGzAxwFngKnIaOASmlRXvko8KClFIopXR3BkTnigqCdpo3I19GpwaGzWQYiMcElgWDOsCICQtbCMD7B30ZsGOCzOE065+/9qvNF6eOHEAIC61DMNBoNEilUsirGe4/f8u7L9/YbulQhP7JPrs9UHeuZABwHMczxtNAvV4nl8txcP8MD6+d6V+lAbVazbONp4FqtYpt22SzWZLJZCjCvHAch1qtRqVS8WzracB1XSqViq/OhsFklNFRZmwNJJRSTQApZQz4NThJZozNDGjao9y9/9E56vsvSqlQhRQKBbT2vUBuAz+hI1gp5Uop1+ls0yLAa6WUC7tT6AbwmPaxuVFqPXn5MZCKxQvGu1gHeANc7z7oCVVKrQELXj1IKVuA0Fr3TqcDCNmLuFLKd9EI8hJrRmj/HEoVGmAK/UUoBkJOISPGZh3oi2kK9UHQKsTOMjpMghj4AJwsFothawH4ZLIGQDADt2gfw58g3PVgw7KsJdMgX//QjDKRL6O/AYrxtP/CkuHtAAAAAElFTkSuQmCC" alt="Print" />
                </button>
            </div>
            <div id="viewer_container">
                <cc1:DocuVieware ID="DocuVieware1"
                    runat="server"
                    Height="100%"
                    Width="100%"
                    SinglePageView="True"
                    ForceScrollBars="False"
                    MaxUploadSize="52428800"
                    ShowThumbnailsSnapIn="False"
                    ShowBookmarksSnapIn="False"
                    ShowTextSearchSnapIn="False"
                    ShowAnnotationsSnapIn="False"
                    ShowToolbar="True"
                    EnableFileUploadButton="False"
                    EnableLoadFromUriButton="False"
                    EnableTwainAcquisitionButton="False"
                    EnablePrintButton="False"
                    EnableSaveButton="False"
                    EnablePagesNavigationButtons="False"
                    EnableRotateButtons="False"
                    EnablePageViewButtons="False"
                    EnableMouseModeButtons="False"
                    EnableFullScreenButton="False"
                    EnableFormFieldsEdition="True" />
            </div>
        </div>
    </form>
</body>
</html>
