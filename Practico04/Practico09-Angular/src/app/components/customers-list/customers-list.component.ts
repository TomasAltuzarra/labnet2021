import { CustomersListService } from 'src/app/services/customers-list.service';
import { Component, OnInit, ViewChild, Input } from '@angular/core';
import { FormComponent } from '../form/form.component';
import {NgbModal} from '@ng-bootstrap/ng-bootstrap';
import {Customer} from '../customer/customer.component';
import { MatTable } from '@angular/material/table';
import {Customers} from '../modules/customer';


@Component({
  selector: 'app-customers-list',
  templateUrl: './customers-list.component.html',
  styleUrls: ['./customers-list.component.css']
})

export class CustomersListComponent implements OnInit {

  public listCustomers: Array<Customers>;
  ngOnInit(): void {
    this.getAll();
  }

  mCustomer: Customer;

  columns: string[] = ['ID', 'Nombre', 'Empresa', 'Ciudad','Pais','Telefono'];

  @ViewChild(MatTable) tabla1: MatTable<Customer>;
  @ViewChild(FormComponent) hijo: FormComponent;

  closeResult = '';
  @Input() state = '';
  datos: Customer[] = [ //GetAll
    {cID:"TOMY",cName:"Tomy",cCompany:"Company",cCity:"Sanlo",cCountry:"Arg",cPhone:"123"},
    {cID:"CAJA",cName:"La Caja",cCompany:"Box S.A.",cCity:"Rosario",cCountry:"Arg",cPhone:"321"},
    {cID:"TOPO",cName:"El Topo",cCompany:"NFG",cCity:"Rosario",cCountry:"Arg",cPhone:"321"}
  ];

  //Add-Update (Modal)
  pID= '';
  pName='';
  pEmp='';
  pCity='';
  pCountry='';
  pPhone='';

  constructor(private modalService: NgbModal, private customerService: CustomersListService, private customersService :CustomersListService
    ) {}

  openNew(content) {
    this.modalService.open(content, {ariaLabelledBy: 'modal-basic-title'});
    this.pID='ID';
    this.pName='Nombre y Apellido';
    this.pEmp='Empresa';
    this.pCity='Ciudad de referencia';
    this.pCountry='Pais';
    this.pPhone='Telefono';
  }

  openUpdate(content,mCustomer) {
    this.modalService.open(content, {ariaLabelledBy: 'modal-basic-title'});
    this.pID=mCustomer.cID;
    this.pName=mCustomer.cName;
    this.pEmp=mCustomer.cCompany;
    this.pCity=mCustomer.cCity;
    this.pCountry=mCustomer.cCountry;
    this.pPhone=mCustomer.cPhone;
  }

  //Tabla
  customerselect: Customer = new Customer("","","","","","");

  agregar() {
    this.datos.push(new Customer(
      this.customerselect.cID,
      this.customerselect.cName,
      this.customerselect.cCompany,
      this.customerselect.cCity,
      this.customerselect.cCountry,
      this.customerselect.cPhone));
    this.tabla1.renderRows();
    this.customerselect = new Customer("","","","","","");
    //this.empList.push(customObj);
  }

  deleteRow(customer){
    if (confirm('¿Realmente desea borrarlo?'))
    {
      this.datos.splice(customer, 1);
      //this.tabla1.renderRows();
      //console.log("Elimina2");
    }
  }

  getAll(){
    this.customersService.getAllCustomers().subscribe(res=>{
        this.listCustomers=res;
        console.log(this.listCustomers);
    });
  }
}

