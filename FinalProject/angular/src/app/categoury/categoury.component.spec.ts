import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CategouryComponent } from './categoury.component';

describe('CategouryComponent', () => {
  let component: CategouryComponent;
  let fixture: ComponentFixture<CategouryComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CategouryComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CategouryComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
