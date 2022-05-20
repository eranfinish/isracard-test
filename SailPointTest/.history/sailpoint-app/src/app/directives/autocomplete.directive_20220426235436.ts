import { Directive, ElementRef, Input, ViewContainerRef, OnInit } from '@angular/core';
import { NgControl } from '@angular/forms';
import { fromEvent } from 'rxjs';
import { OverlayRef } from '@angular/cdk/overlay';
import { AutocompleteComponent } from '../components/app-autocomplete.component/app-autocomplete.component
@Directive({
  selector: '[appAutocomplete]'
})
export class AutocompleteDirective implements OnInit {
  @Input() appAutocomplete: AutocompleteComponent;
  private overlayRef: OverlayRef;

  constructor(
    private host: ElementRef<HTMLInputElement>,
    private ngControl: NgControl,
    private vcr: ViewContainerRef,
    private overlay: Overlay
  ) {
  }

  get control() {
    return this.ngControl.control;
  }

  get origin() {
    return this.host.nativeElement;
  }

  ngOnInit() {
    fromEvent(this.origin, 'focus').pipe(
      untilDestroyed(this)
    ).subscribe(() => {
      this.openDropdown();
    }
  }
}


