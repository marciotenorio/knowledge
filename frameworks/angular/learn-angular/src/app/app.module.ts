import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { FormsModule } from '@angular/forms';
import THE_BASICS_ARTIFACTS from './02-the-basics/the-basics-artifacts';
import COMPONENTS_DATABINDING_ARTIFACTS from './05-components-databinding/components-databinding-artifacts';
import DIRECTIVES_DEEP_DIVE_ARTIFACTS from './07-directives-deep-dive/directives-deep-dive-artifacts';

//Learn about standalone components later
@NgModule({
  declarations: [
    AppComponent,
    ...THE_BASICS_ARTIFACTS,
    ...COMPONENTS_DATABINDING_ARTIFACTS,
    ...DIRECTIVES_DEEP_DIVE_ARTIFACTS
  ],
  imports: [
    FormsModule,
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
