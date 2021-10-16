import { CustomersListComponent } from './../customers-list/customers-list.component';
import { Component, OnInit, ViewChild } from '@angular/core';
import { MatTable } from '@angular/material/table';
import { FormComponent } from '../form/form.component';


@Component({
  selector: 'app-customer',
  templateUrl: './customer.component.html',
  styleUrls: ['./customer.component.css']
})
export class CustomerComponent{

  //columnas: string[] = ['ID', 'Nombre', 'Empresa', 'Ciudad','Pais','Telefono'];

  /*datos: Customer[] = [ //GetAll
    {cID:"TOMY",cName:"Tomy",cCompany:"Company",cCity:"Sanlo",cCountry:"Arg",cPhone:"123"},
    {cID:"CAJA",cName:"La Caja",cCompany:"Box S.A.",cCity:"Rosario",cCountry:"Arg",cPhone:"321"},
    {cID:"TOPO",cName:"El Topo",cCompany:"NFG",cCity:"Rosario",cCountry:"Arg",cPhone:"321"}
  ];*/

  customerselect: Customer = new Customer("","","","","","");

  //@ViewChild(MatTable) tabla1: MatTable<Customer>;

  /*borrarFila(cod: number) {
    if (confirm("Realmente quiere borrarlo?")) {
      this.datos.splice(cod, 1);
      this.tabla1.renderRows();
    }
  }

  agregar() {
    this.datos.push(new Customer(this.customerselect.cID, this.customerselect.cName, this.customerselect.cCompany, this.customerselect.cCity , this.customerselect.cCountry, this.customerselect.cPhone));
    this.tabla1.renderRows();
    this.customerselect = new Customer("","","","","","");
  }*/
}

  export class Customer {
    constructor(public cID: string, public cName: string, public cCompany: string, public cCity: string, public cCountry: string, public cPhone: string) {
    }
  }

