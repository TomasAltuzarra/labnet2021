import { environment } from 'src/environments/environment';
import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';
import { Observable } from 'rxjs/internal/Observable';
import { Customer } from '../components/customer/customer.component';
import {HttpClient} from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class CustomersListService {

  endpoint:string='Customers';
  constructor(private http: HttpClient) {}

  public newCustomer(customerRequest : Customer): Observable<any> {
    let url = environment.apiCustomers + this.endpoint;
    return this.http.post(url,customerRequest);
  }

  public getAllCustomers(): Observable<Array<Customer>>{
    let url = environment.apiCustomers + this.endpoint;
    return this.http.get<Array<Customer>>(url);
  }

  deleteCustomer(id): Observable<any>{
    let url = environment.apiCustomers + this.endpoint;
    return this.http.delete(url,id);
  }

}
