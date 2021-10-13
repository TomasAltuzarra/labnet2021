import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import {MatTableModule} from '@angular/material/table';
import { FooterModule } from './components/shared-view/footer/footer.module';
import { HeaderModule } from './components/shared-view/header/header.module';
import { CustomersListModule } from './components/customers-list/customers-list.module';
import { ReactiveFormsModule } from '@angular/forms';


@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MatTableModule,
    FooterModule,
    HeaderModule,
    CustomersListModule,
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
