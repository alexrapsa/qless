import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TransportCardDiscountedComponent } from './transport-card-discounted.component';

describe('TransportCardDiscountedComponent', () => {
  let component: TransportCardDiscountedComponent;
  let fixture: ComponentFixture<TransportCardDiscountedComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ TransportCardDiscountedComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(TransportCardDiscountedComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
