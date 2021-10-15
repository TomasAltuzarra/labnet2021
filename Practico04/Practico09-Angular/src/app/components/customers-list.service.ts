import { Injectable } from '@angular/core';
import { Customer } from './customer/customer.component';

@Injectable({
  providedIn: 'root'
})
export class CustomersListService {  datos: Customer[]

  constructor() { }
}
