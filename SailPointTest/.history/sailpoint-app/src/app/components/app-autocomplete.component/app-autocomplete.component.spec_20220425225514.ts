import { ComponentFixture, TestBed } from '@angular/core/testing';
import { NO_ERRORS_SCHEMA } from '@angular/core';
import { AppAutocompleteComponent } from './app-autocomplete.component';

describe('AppAutocompleteComponent', () => {
    let comp: AppAutocompleteComponent;
    let fixture: ComponentFixture<AppAutocompleteComponent>;

    beforeEach(() => {
        TestBed.configureTestingModule({
            declarations: [ AppAutocompleteComponent ],
            schemas: [ NO_ERRORS_SCHEMA ]
        });
        fixture = TestBed.createComponent(AppAutocompleteComponent);
        comp = fixture.componentInstance;
    });

    it('can load instance', () => {
        expect(comp).toBeTruthy();
    });

});