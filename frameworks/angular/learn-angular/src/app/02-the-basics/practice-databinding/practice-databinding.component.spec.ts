import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PracticeDatabindingComponent } from './practice-databinding.component';

describe('PracticeDatabindingComponent', () => {
  let component: PracticeDatabindingComponent;
  let fixture: ComponentFixture<PracticeDatabindingComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [PracticeDatabindingComponent]
    });
    fixture = TestBed.createComponent(PracticeDatabindingComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
