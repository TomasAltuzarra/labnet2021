import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import {CustomersListComponent} from './customers-list.component';
import {FormAddModule} from './../form-add/form-add.module';



@NgModule({
  declarations: [CustomersListComponent],
  imports: [
    CommonModule,
    FormAddModule
  ],
  exports: [CustomersListComponent]
})
export class CustomersListModule { }
