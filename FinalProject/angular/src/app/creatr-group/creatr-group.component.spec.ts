import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CreatrGroupComponent } from './creatr-group.component';

describe('CreatrGroupComponent', () => {
  let component: CreatrGroupComponent;
  let fixture: ComponentFixture<CreatrGroupComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CreatrGroupComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CreatrGroupComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
