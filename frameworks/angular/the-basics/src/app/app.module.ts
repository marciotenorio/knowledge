import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { NavigationComponent } from './navigation/navigation.component';
import { SupplementsComponent } from './supplements/supplements.component';
import { SupplementsListComponent } from './supplements-list/supplements-list.component';
import { SupplementsEditComponent } from './supplements-edit/supplements-edit.component';

@NgModule({
  declarations: [
    AppComponent,
    NavigationComponent,
    SupplementsComponent,
    SupplementsListComponent,
    SupplementsEditComponent
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
