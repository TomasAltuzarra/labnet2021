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

  /*lista = new BehaviorSubject<Customer[]> ([ //GetAll
    {cID:"TOMY",cName:"Tomy",cCompany:"Company",cCity:"Sanlo",cCountry:"Arg",cPhone:"123"},
    {cID:"CAJA",cName:"La Caja",cCompany:"Box S.A.",cCity:"Rosario",cCountry:"Arg",cPhone:"321"},
    {cID:"TOPO",cName:"El Topo",cCompany:"NFG",cCity:"Rosario",cCountry:"Arg",cPhone:"321"}
  ]);

  //customers = new BehaviorSubject<Customer[]>(this.lista);
  customers$ = this.lista.asObservable();
  constructor() { }

  deleteCustomer(customer){
    if (confirm('¿Realmente desea borrarlo?')) {
    this.lista.getValue().splice(customer,1);
    //console.log("Elimina2");
  }
  }
  /*getCustomers(): Observable<Customer[]> {
    return this.http.get<Categoria[]>(environment.URLSERVICIO + "Categories");
  }*/


}
