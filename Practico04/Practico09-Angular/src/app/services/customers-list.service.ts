import { environment } from 'src/environments/environment';
import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';
import { Observable } from 'rxjs/internal/Observable';
//import { Customer } from '../components/customer/customer.component';
import {HttpClient} from '@angular/common/http';
import { Customers } from '../components/modules/customer';

@Injectable({
  providedIn: 'root'
})
export class CustomersListService {

  //id: string;
  endpoint:string='Customers';
  endpoints:string='Customers/';
  constructor(private http: HttpClient) {}

  public newCustomer(customerRequest : Customers): Observable<any> {
    let url = environment.apiCustomers + this.endpoints;
    return this, this.http.post(url,customerRequest);
  }

  public getAllCustomers(): Observable<Array<Customers>>{
    let url = environment.apiCustomers + this.endpoints;
    return this.http.get<Array<Customers>>(url);
  }

  deleteCustomer(id): void{
    let url = environment.apiCustomers + this.endpoints;
    this.http.delete(url,id);
  }

  updateCustomer(customerRequest : Customers): void {
    let url = environment.apiCustomers + this.endpoints;
    this.http.put(url,customerRequest);
  }

}
