import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';



@NgModule({
  declarations: [],
  imports: [
    CommonModule
  ]
})
export class CustomerModule {
    constructor(
      public cID: string,
      public cName: string,
      public cCompany: string,
      public cCity: string,
      public cCountry: string,
      public cPhone: string,
    ) {}
}
