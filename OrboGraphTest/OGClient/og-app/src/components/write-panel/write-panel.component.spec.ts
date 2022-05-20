import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { WritePanelComponent } from './write-panel.component';

describe('WritePanelComponent', () => {
  let component: WritePanelComponent;
  let fixture: ComponentFixture<WritePanelComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ WritePanelComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(WritePanelComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
