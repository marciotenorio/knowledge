import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ObsSubBehComponent } from './obs-sub-beh.component';

describe('ObsSubBehComponent', () => {
  let component: ObsSubBehComponent;
  let fixture: ComponentFixture<ObsSubBehComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ObsSubBehComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(ObsSubBehComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
