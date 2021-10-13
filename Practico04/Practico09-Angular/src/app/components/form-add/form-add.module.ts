//import { CustomersListModule } from './../customers-list/customers-list.module';
import { FormAddComponent } from './form-add.component';
import { NgModule, Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormModule } from '../form/form.module';

@NgModule({
  declarations: [FormAddComponent,],
  imports: [
    CommonModule,
    FormModule
  ],
  exports: [FormAddComponent]
})
export class FormAddModule {


 }
