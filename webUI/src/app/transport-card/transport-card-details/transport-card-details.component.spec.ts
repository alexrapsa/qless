import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TransportCardDetailsComponent } from './transport-card-details.component';

describe('TransportCardDetailsComponent', () => {
  let component: TransportCardDetailsComponent;
  let fixture: ComponentFixture<TransportCardDetailsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ TransportCardDetailsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(TransportCardDetailsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
