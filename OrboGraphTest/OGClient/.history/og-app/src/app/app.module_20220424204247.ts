import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { WritePanelComponent } from '../components/write-panel/write-panel.component';
import { RightPanelComponent } from '../components/right-panel/right-panel.component';

@NgModule({
  declarations: [
    AppComponent,
    WritePanelComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
