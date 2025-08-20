import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DemoRegistroComponent } from './demo-registro.component';

describe('DemoRegistroComponent', () => {
  let component: DemoRegistroComponent;
  let fixture: ComponentFixture<DemoRegistroComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [DemoRegistroComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(DemoRegistroComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
