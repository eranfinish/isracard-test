import { Component, ContentChild, ContentChildren, QueryList, TemplateRef, Directive, Input, ViewChild } from '@angular/core';

import { AutocompleteContentDirective } from '../../directives/autocompleteContent.directive';
import {OptionComponent } from '../app-option/app-option.component'
import { merge } from 'rxjs';
import { switchMap } from 'rxjs/operators';


@Component({
    selector: 'app-autocomplete',
    templateUrl: 'app-autocomplete.component.html',
})
export class AutocompleteComponent {
  @ViewChild('root', {static: false}) rootTemplate: TemplateRef<any>;

  @ContentChild(AutocompleteContentDirective, {static: false})
  content: AutocompleteContentDirective;

  @ContentChildren(OptionComponent) options: QueryList<OptionComponent>;

  optionsClick() {
    return this.options.changes.pipe(
      switchMap(options => {
        const clicks$ = options.map(option => option.click$);
        return merge(...clicks$);
      })
    );
  }
}
