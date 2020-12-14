import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TransportCardListComponent } from './transport-card-list.component';

describe('TransportCardListComponent', () => {
  let component: TransportCardListComponent;
  let fixture: ComponentFixture<TransportCardListComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ TransportCardListComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(TransportCardListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
