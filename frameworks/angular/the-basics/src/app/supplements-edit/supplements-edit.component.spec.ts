import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SupplementsEditComponent } from './supplements-edit.component';

describe('SupplementsEditComponent', () => {
  let component: SupplementsEditComponent;
  let fixture: ComponentFixture<SupplementsEditComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [SupplementsEditComponent]
    });
    fixture = TestBed.createComponent(SupplementsEditComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
