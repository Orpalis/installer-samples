import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CleanupPanelComponent } from './cleanup-panel.component';

describe('CleanupPanelComponent', () => {
  let component: CleanupPanelComponent;
  let fixture: ComponentFixture<CleanupPanelComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CleanupPanelComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CleanupPanelComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
