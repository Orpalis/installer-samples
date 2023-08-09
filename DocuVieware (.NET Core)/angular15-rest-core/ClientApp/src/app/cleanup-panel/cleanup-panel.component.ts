import { Component, OnInit } from '@angular/core';

declare var DocuViewareAPI: any;

@Component({
  selector: 'app-cleanup-panel',
  templateUrl: './cleanup-panel.component.html',
  styleUrls: ['./cleanup-panel.component.css']
})
export class CleanupPanelComponent implements OnInit {

  DOCUVIEWARE_CONTROL_ID = 'DocuVieware1';

  constructor() {
  }

  ngOnInit() {
  }

  applyFilter(customActionName: string) {
    const pages = DocuViewareAPI.GetSelectedThumbnailItems(this.DOCUVIEWARE_CONTROL_ID);
    const roi = DocuViewareAPI.GetSelectionAreaCoordinates(this.DOCUVIEWARE_CONTROL_ID);
    if (pages.length === 0) {
      pages[0] = DocuViewareAPI.GetCurrentPage(this.DOCUVIEWARE_CONTROL_ID);
    }
    const param = { Pages: pages, RegionOfInterest: roi };

    DocuViewareAPI.PostCustomServerAction(this.DOCUVIEWARE_CONTROL_ID, true, customActionName, param);
  }

}
