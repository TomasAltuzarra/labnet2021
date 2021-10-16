import { CustomersListService } from 'src/app/services/customers-list.service';
import { Component, OnInit, ViewChild, Input } from '@angular/core';
import { FormComponent } from '../form/form.component';
import {NgbModal} from '@ng-bootstrap/ng-bootstrap';
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

  @ViewChild(FormComponent) hijo: FormComponent;

  closeResult = '';
  @Input() state = '';


  //Add-Update (Modal)
  pID= '';
  pName='';
  pEmp='';
  pCity='';
  pCountry='';
  pPhone='';

  constructor(private modalService: NgbModal, private customersService :CustomersListService
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
    this.pID=mCustomer.CustomerID;
    this.pName=mCustomer.ContactName;
    this.pEmp=mCustomer.CompanyName;
    this.pCity=mCustomer.City;
    this.pCountry=mCustomer.Country;
    this.pPhone=mCustomer.Phone;
  }

//Tabla
  deleteRow(id){
    if (confirm('¿Realmente desea borrarlo?'))
    {
      this.customersService.deleteCustomer(id);
    }
  }

  getAll(){
    this.customersService.getAllCustomers().subscribe(res=>{
        this.listCustomers=res;
        console.log(this.listCustomers);
    });
  }
}

