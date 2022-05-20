import { Directive, Input, TemplateRef } from '@angular/core';

@Directive({
  selector: '[AutocompleteContentDirective]'
})
export class AutocompleteContentDirective {
  constructor(public tpl: TemplateRef<any>) {
  }
}
