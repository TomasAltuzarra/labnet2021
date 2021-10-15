import { CustomerComponent } from './customer.component';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CustomersListModule } from '../customers-list/customers-list.module';



@NgModule({
  declarations: [CustomerComponent],
  imports: [
    CommonModule,
    CustomersListModule,
  ],
  exports:[CustomerComponent]
})
export class CustomerModule { }
