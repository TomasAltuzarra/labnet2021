import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-form',
  templateUrl: './form.component.html',
  styleUrls: ['./form.component.css']
})
export class FormComponent implements OnInit {
  pID='ID';
  pName='Nombre y Apellido';
  pEmp='Empresa';
  pCity='Ciudad de referencia';
  pCountry='Pais';
  pPhone='Telefono';

  constructor() { }

  ngOnInit(): void {
  }

}
