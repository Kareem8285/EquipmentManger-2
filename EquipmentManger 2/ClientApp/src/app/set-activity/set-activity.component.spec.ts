import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { SetActivityComponent } from './set-activity.component';

describe('SetActivityComponent', () => {
  let component: SetActivityComponent;
  let fixture: ComponentFixture<SetActivityComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ SetActivityComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(SetActivityComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
