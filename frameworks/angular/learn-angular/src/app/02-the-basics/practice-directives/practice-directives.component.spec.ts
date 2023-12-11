import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PracticeDirectivesComponent } from './practice-directives.component';

describe('PracticeDirectivesComponent', () => {
  let component: PracticeDirectivesComponent;
  let fixture: ComponentFixture<PracticeDirectivesComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [PracticeDirectivesComponent]
    });
    fixture = TestBed.createComponent(PracticeDirectivesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
