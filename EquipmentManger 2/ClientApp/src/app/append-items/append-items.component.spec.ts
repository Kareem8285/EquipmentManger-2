import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AppendItemsComponent } from './append-items.component';

describe('AppendItemsComponent', () => {
  let component: AppendItemsComponent;
  let fixture: ComponentFixture<AppendItemsComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AppendItemsComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AppendItemsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
