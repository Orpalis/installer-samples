package rest_consume;
/**
 * This project is built with the following libraries:
 * - JSON-java : https://stleary.github.io/JSON-java/
 * - Apache HttpClient : http://hc.apache.org/httpclient-3.x/
 */
import java.util.logging.Level;
import java.util.logging.Logger;
import org.apache.http.HttpResponse;
import org.apache.http.client.methods.HttpPost;
import org.apache.http.entity.StringEntity;
import org.apache.http.impl.client.DefaultHttpClient;
import org.apache.http.util.EntityUtils;
import org.json.JSONException;
import org.json.JSONObject;

/**
 * @author ORPALIS
 */
public class Rest_consume {

    public static final int HTTP_OK = 200;

    public static void main() {
        try {
            DefaultHttpClient httpClient = new DefaultHttpClient();
            HttpPost postRequest = new HttpPost("http://localhost:62968/api/DocuViewareREST/GetDocuViewareControl");
            StringEntity data = new StringEntity(getDocuViewareConfiguration());
            data.setContentType("application/json");
            postRequest.setEntity(data);

            HttpResponse response = httpClient.execute(postRequest);

            if (response.getStatusLine().getStatusCode() != HTTP_OK) {
                throw new RuntimeException("Failed : HTTP error code : " + response.getStatusLine().getStatusCode());
            }
            JSONObject output = new JSONObject(EntityUtils.toString(response.getEntity(), "UTF-8"));
            String html = output.getString("HtmlContent");

            System.out.println(html);

            httpClient.getConnectionManager().shutdown();
        } catch (Exception ex) {
            Logger.getLogger(Rest_consume.class.getName()).log(Level.SEVERE, null, ex);
        }
    }

    public static String getDocuViewareConfiguration() {
        try {
            JSONObject docuViewareConfig = new JSONObject();
            docuViewareConfig.put("SessionId", "mySessionId"); //Set to an arbitrary value, should be replaced by the session identifier from your session mechanism
            docuViewareConfig.put("ControlId", "DocuVieware1");
            docuViewareConfig.put("AllowPrint", true);
            docuViewareConfig.put("EnablePrintButton", true);
            docuViewareConfig.put("AllowUpload", true);
            docuViewareConfig.put("EnableFileUploadButton", true);
            docuViewareConfig.put("CollapsedSnapIn", true);
            docuViewareConfig.put("ShowAnnotationsSnapIn", true);
            docuViewareConfig.put("EnableRotateButtons", true);
            docuViewareConfig.put("EnableZoomButtons", true);
            docuViewareConfig.put("EnablePageViewButtons", true);
            docuViewareConfig.put("EnableMultipleThumbnailSelection", true);
            docuViewareConfig.put("EnableMouseModeButtons", true);
            docuViewareConfig.put("EnableFormFieldsEdition", true);
            docuViewareConfig.put("EnableTwainAcquisitionButton", true);
            return docuViewareConfig.toString();
        } catch (Exception ex) {
            Logger.getLogger(Rest_consume.class.getName()).log(Level.SEVERE, null, ex);
        }
        return null;
    }
}
