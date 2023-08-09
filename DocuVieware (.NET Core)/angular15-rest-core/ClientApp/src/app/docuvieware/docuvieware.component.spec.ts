import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DocuviewareComponent } from './docuvieware.component';

describe('DocuviewareComponent', () => {
  let component: DocuviewareComponent;
  let fixture: ComponentFixture<DocuviewareComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DocuviewareComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(DocuviewareComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
