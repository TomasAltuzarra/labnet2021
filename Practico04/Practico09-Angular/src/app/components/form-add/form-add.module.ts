//import { CustomersListModule } from './../customers-list/customers-list.module';
import { FormAddComponent } from './form-add.component';
import { NgModule, Component } from '@angular/core';
import { CommonModule } from '@angular/common';



@NgModule({
  declarations: [FormAddComponent,],
  imports: [
    CommonModule,
  ],
  exports: [FormAddComponent]
})
export class FormAddModule { }
