import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SupplementsListComponent } from './supplements-list.component';

describe('SupplementsListComponent', () => {
  let component: SupplementsListComponent;
  let fixture: ComponentFixture<SupplementsListComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [SupplementsListComponent]
    });
    fixture = TestBed.createComponent(SupplementsListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
