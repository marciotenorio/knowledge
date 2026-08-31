import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Root18MakingHttpRequestsComponent } from './root-18-making-http-requests.component';

describe('Root18MakingHttpRequestsComponent', () => {
  let component: Root18MakingHttpRequestsComponent;
  let fixture: ComponentFixture<Root18MakingHttpRequestsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [Root18MakingHttpRequestsComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(Root18MakingHttpRequestsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
