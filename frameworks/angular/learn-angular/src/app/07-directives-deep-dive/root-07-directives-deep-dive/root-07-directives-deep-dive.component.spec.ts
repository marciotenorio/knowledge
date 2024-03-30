import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Root07DirectivesDeepDiveComponent } from './root-07-directives-deep-dive.component';

describe('Root07DirectivesDeepDiveComponent', () => {
  let component: Root07DirectivesDeepDiveComponent;
  let fixture: ComponentFixture<Root07DirectivesDeepDiveComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [Root07DirectivesDeepDiveComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(Root07DirectivesDeepDiveComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
