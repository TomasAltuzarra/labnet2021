import { CustomersListService } from 'src/app/services/customers-list.service';
import { Component, OnInit, Input, ViewChild, Output } from '@angular/core';
import { AbstractControl, FormBuilder, FormGroup } from '@angular/forms';
import {Customer} from '../customer/customer.component';
import {Customers} from '../modules/customer';

@Component({
  selector: 'app-form',
  templateUrl: './form.component.html',
  styleUrls: ['./form.component.css']
})
export class FormComponent implements OnInit {

  get nombreCtrl(): AbstractControl {
    return this.form.get('cusName');
  }
  get empresaCtrl(): AbstractControl {
    return this.form.get('cusComp');
  }
  get idCtrl(): AbstractControl {
    return this.form.get('cusID');
  }
  get cityCtrl(): AbstractControl {
    return this.form.get('cusCity');
  }
  get phoneCtrl(): AbstractControl {
    return this.form.get('cusPhone');
  }
  get paisCtrl(): AbstractControl {
    return this.form.get('cusCountry');
  }

  //Recibiria estos datos y con una condicion para saber si modificar o agregar uno nuevo
  @Input() iID: string;
  @Input() iName: string;
  @Input() iEmp: string;
  @Input() iCity: string;
  @Input() iCountry: string;
  @Input() iPhone: string;
  @Input() state: string;
  @Input() datos: Customer[];

  @Output() cusID: string;
  @Output() cusComp: string;
  @Output() cusName: string;
  @Output() cusCity: string;
  @Output() cusCountry: string;
  @Output() cusPhone: string;

  form: FormGroup;

  //@Output() nuevo= new EventEmitter<Customer>();

  constructor(private readonly fb: FormBuilder, private customerService :CustomersListService) { }

  ngOnInit(): void {
    this.form = this.fb.group({
      cusID: [''],
      cusComp: [''],
      cusName: [''],
      cusCity: [''],
      cusCountry: [''],
      cusPhone: [''],
    });
  }

  onSubmit(){
    var cus= new Customers();
      cus.cID = this.form.get('cusID').value;
      cus.cName = this.form.get('cusName').value;
      cus.cCompany = this.form.get('cusComp').value;
      cus.cCity = this.form.get('cusCity').value;
      cus.cCountry = this.form.get('cusCountry').value;
      cus.cPhone = this.form.get('cusPhone').value;
    this.customerService.newCustomer(cus).subscribe(res=> {
      this.form.reset();
      console.log('andó');
      });
  }

  onClickLimpiar():void{
    if (this.idCtrl){
      this.idCtrl.setValue('');
    }
    if (this.nombreCtrl){
      this.nombreCtrl.setValue('');
    }
    if (this.empresaCtrl){
      this.empresaCtrl.setValue('');
    }
    if (this.cityCtrl){
      this.cityCtrl.setValue('');
    }
    if (this.phoneCtrl){
      this.phoneCtrl.setValue('');
    }
    if (this.paisCtrl){
      this.paisCtrl.setValue('');
    }
  }
}
