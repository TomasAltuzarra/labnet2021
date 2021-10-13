import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import {CustomersListComponent} from './customers-list.component';
import {FormModule} from './../form/form.module';



@NgModule({
  declarations: [CustomersListComponent],
  imports: [
    CommonModule,
    FormModule
  ],
  exports: [CustomersListComponent]
})
export class CustomersListModule { }
