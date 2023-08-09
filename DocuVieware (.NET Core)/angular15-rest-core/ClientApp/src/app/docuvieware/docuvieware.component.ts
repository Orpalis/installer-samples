import { Component } from '@angular/core';
import { DocuviewareControlService } from 'src/services/docuvieware-control.service';

@Component({
  selector: 'app-docuvieware',
  templateUrl: './docuvieware.component.html',
  styleUrls: ['./docuvieware.component.css']
})
export class DocuviewareComponent {
  constructor(private dvApi: DocuviewareControlService) {
  }

  htmlMarkup: any;

  private static insertInDOM(content: string): void {
    const fragment = document.createRange().createContextualFragment(content);
    document.getElementById('dvContainer')?.appendChild(fragment);
  }

  ngOnInit() {
    this.dvApi.getDocuViewareMarkup().subscribe({
      next : response => DocuviewareComponent.insertInDOM(response.htmlContent),
      error: error => this.htmlMarkup = error as any
    });
  }
}
