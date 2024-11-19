import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Root17PipesComponent } from './root-17-pipes.component';

describe('Root17PipesComponent', () => {
  let component: Root17PipesComponent;
  let fixture: ComponentFixture<Root17PipesComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [Root17PipesComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(Root17PipesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
