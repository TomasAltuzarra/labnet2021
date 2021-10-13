import { FormComponent } from '../form/form.component';
import { Component, OnInit, Output, ViewChild, Input  } from '@angular/core';
import {NgbModal, ModalDismissReasons} from '@ng-bootstrap/ng-bootstrap';


@Component({
  selector: 'app-form-add',
  templateUrl: './form-add.component.html',
  styleUrls: ['./form-add.component.css']
})
export class FormAddComponent {

  @ViewChild(FormComponent) hijo: FormComponent;

  closeResult = '';
  @Input() state = '';

  pID= '';
  pName='';
  pEmp='';
  pCity='';
  pCountry='';
  pPhone='';

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
}

