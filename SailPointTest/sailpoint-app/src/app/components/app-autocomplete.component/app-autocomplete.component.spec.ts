import { ComponentFixture, TestBed } from '@angular/core/testing';
import { NO_ERRORS_SCHEMA } from '@angular/core';
import { AutocompleteComponent } from './app-autocomplete.component';

describe('AppAutocompleteComponent', () => {
    let comp: AutocompleteComponent;
    let fixture: ComponentFixture<AutocompleteComponent>;

    beforeEach(() => {
        TestBed.configureTestingModule({
            declarations: [ AutocompleteComponent ],
            schemas: [ NO_ERRORS_SCHEMA ]
        });
        fixture = TestBed.createComponent(AutocompleteComponent);
        comp = fixture.componentInstance;
    });

    it('can load instance', () => {
        expect(comp).toBeTruthy();
    });

});
