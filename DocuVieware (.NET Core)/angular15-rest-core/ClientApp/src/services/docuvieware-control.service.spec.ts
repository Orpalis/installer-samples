import { TestBed } from '@angular/core/testing';

import { DocuviewareControlService } from './docuvieware-control.service';

describe('DocuviewareControlService', () => {
  let service: DocuviewareControlService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(DocuviewareControlService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
