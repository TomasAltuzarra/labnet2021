//import { CustomerComponent } from './../../customer/customer.component';
import { CustomerComponent } from './customer.component';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';



@NgModule({
  declarations: [CustomerComponent],
  imports: [
    CommonModule
  ],
  exports: [CustomerComponent]
})
export class CustomerModule { }
