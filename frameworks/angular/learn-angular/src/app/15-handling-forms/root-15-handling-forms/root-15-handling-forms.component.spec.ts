import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Root15HandlingFormsComponent } from './root-15-handling-forms.component';

describe('Root15HandlingFormsComponent', () => {
  let component: Root15HandlingFormsComponent;
  let fixture: ComponentFixture<Root15HandlingFormsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [Root15HandlingFormsComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(Root15HandlingFormsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
