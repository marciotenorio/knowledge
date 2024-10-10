import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { FormsModule } from '@angular/forms';
import THE_BASICS_ARTIFACTS from './02-the-basics/the-basics-artifacts';
import COMPONENTS_DATABINDING_ARTIFACTS from './05-components-databinding/components-databinding-artifacts';
import DIRECTIVES_DEEP_DIVE_ARTIFACTS from './07-directives-deep-dive/directives-deep-dive-artifacts';
import { INJECTING_SERVICES_AND_DI_ARTIFACTS, USING_SERVICES_AND_DI_ARTIFACTS } from './09-using-services-and-di/services-and-di-artifacts';
import { INJECTING_CHANGING_PAGES_WITH_ROUTING, USING_CHANGING_PAGES_WITH_ROUTING } from './11-changing-pages-with-routing/changing-pages-with-routing-artifacts';
import { NotFoundComponent } from './not-found/not-found.component';
import { ErrorPage11Component } from './11-changing-pages-with-routing/error-page/error-page-11.component';
import { USING_UNDERSTANDING_OBSERVABLES } from './13-understanding-observables/understanding-observables-artifacts';
import { CommonModule } from '@angular/common';
import { USING_HANDLING_FORMS } from './15-handling-forms/handling-forms-artifacts';

//Learn about standalone components later
@NgModule({
  declarations: [
    AppComponent,
    ...THE_BASICS_ARTIFACTS,
    ...COMPONENTS_DATABINDING_ARTIFACTS,
    ...DIRECTIVES_DEEP_DIVE_ARTIFACTS,
    ...USING_SERVICES_AND_DI_ARTIFACTS,
    ...USING_CHANGING_PAGES_WITH_ROUTING,
    ...USING_UNDERSTANDING_OBSERVABLES,
    ...USING_HANDLING_FORMS,
    NotFoundComponent,
    ErrorPage11Component
  ],
  imports: [
    CommonModule,
    FormsModule,
    BrowserModule,
    AppRoutingModule
  ],
  providers: [
    ...INJECTING_SERVICES_AND_DI_ARTIFACTS,
    ...INJECTING_CHANGING_PAGES_WITH_ROUTING
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
