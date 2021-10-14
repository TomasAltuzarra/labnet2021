import { Component, OnInit, ViewChild, Input } from '@angular/core';
import { FormAddComponent } from '../form-add/form-add.component';
import { FormComponent } from '../form/form.component';
import {NgbModal} from '@ng-bootstrap/ng-bootstrap';
import { CustomerService } from 'src/app/services/customer.service';


@Component({
  selector: 'app-customers-list',
  templateUrl: './customers-list.component.html',
  styleUrls: ['./customers-list.component.css']
})

export class CustomersListComponent implements OnInit {

  ngOnInit(): void {
  }

  @ViewChild(FormComponent) hijo: FormComponent;

  closeResult = '';
  @Input() state = '';

  pID= '';
  pName='';
  pEmp='';
  pCity='';
  pCountry='';
  pPhone='';

  /*datos: Customer[] = [
    new Customer(TOMY, 'Tomy', 'Hornero', 'SanLo', 'Argentina', '430012',),
    new Customer(TOPO, 'Topo', 'NFG', 'Rosario', 'Argentina', '123456',),
    new Customer(CAJA, 'La Caja', 'xD', 'Bunge', 'Argentina', '654321',),
  ];*/

  constructor(private modalService: NgbModal) {}

  openNew(content) {
    this.modalService.open(content, {ariaLabelledBy: 'modal-basic-title'});
    this.pID='ID';
    this.pName='Nombre y Apellido';
    this.pEmp='Empresa';
    this.pCity='Ciudad de referencia';
    this.pCountry='Pais';
    this.pPhone='Telefono';
  }

  openUpdate(content) {
    this.modalService.open(content, {ariaLabelledBy: 'modal-basic-title'});
    this.pID='AAAA';
    this.pName='Nombre y Apellido CARGADO';
    this.pEmp='Empresa CARGADO';
    this.pCity='Ciudad de referencia CARGADO';
    this.pCountry='Pais CARGADO';
    this.pPhone='Telefono CARGADO';
  }

  deleteRow(){
    /*if (confirm('Realmente quiere borrarlo?')) {
    this.customers.splice(cod, 1);
    this.tabla1.renderRows();*/
    console.log("Elimina2");
  }

}

