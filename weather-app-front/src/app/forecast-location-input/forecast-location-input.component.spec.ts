import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ForecastLocationInputComponent } from './forecast-location-input.component';

describe('ForecastLocationInputComponent', () => {
  let component: ForecastLocationInputComponent;
  let fixture: ComponentFixture<ForecastLocationInputComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [ForecastLocationInputComponent]
    });
    fixture = TestBed.createComponent(ForecastLocationInputComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
