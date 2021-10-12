import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'customer',
  templateUrl: './customer.component.html',
  styleUrls: ['./customer.component.css']
})
export class CustomerComponent implements OnInit {

  CustomerID: string;
  ContactName: string;
  CompanyName: string;
  Country: string;
  City: string;
  Phone: string;

  constructor() { }

  ngOnInit(): void {
  }

  getAllCustomer(){}
  getOneCustomer(){}
  addCustomer(){}
  modifyCustomer(){}
  deleteCustomer(){}

}
