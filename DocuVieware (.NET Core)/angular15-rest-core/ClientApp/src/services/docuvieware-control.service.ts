import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { DocuviewareControlResponse } from '../model/docuvieware-control-response';

@Injectable({
  providedIn: 'root'
})
export class DocuviewareControlService {
  DOCUVIEWARE_CONTROL_ID = 'DocuVieware1';
  DOCUVIEWARE_ENDPOINT_BASE_URL = 'https://localhost:7064/api/DocuVieware';
  DOCUVIEWARE_GETMARKUP_ENDPOINT = 'GetDocuViewareControl';
  
  constructor(private httpClient: HttpClient) { }

  getDocuViewareMarkup(): Observable<DocuviewareControlResponse> {
    const httpOptions = {
      headers: new HttpHeaders({
        'Content-Type': 'application/json'
      })
    };

    const docuViewareConfig = {
      SessionId: 'mySessionId', // Set to an arbitrary value, should be replaced by the session identifier from your session mechanism
      ControlId: this.DOCUVIEWARE_CONTROL_ID,
      AllowPrint: true,
      EnablePrintButton: true,
      AllowUpload: true,
      EnableFileUploadButton: true,
      CollapsedSnapIn: true,
      ShowAnnotationsSnapIn: true,
      EnableRotateButtons: true,
      EnableZoomButtons: true,
      EnablePageViewButtons: true,
      EnableMultipleThumbnailSelection: true,
      EnableMouseModeButtons: true,
      EnableFormFieldsEdition: true,
      EnableTwainAcquisitionButton: true
    };
    return this.httpClient.post<DocuviewareControlResponse>(`${this.DOCUVIEWARE_ENDPOINT_BASE_URL}/${this.DOCUVIEWARE_GETMARKUP_ENDPOINT}/`, docuViewareConfig, httpOptions);
  }

}
