import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import {CustomersListComponent} from './customers-list.component';
import {FormModule} from './../form/form.module';
import { MatTableModule } from '@angular/material/table';

import { MatInputModule } from '@angular/material/input';
import { MatButtonModule } from '@angular/material/button';
import {FormsModule} from '@angular/forms';



@NgModule({
  declarations: [CustomersListComponent],
  imports: [
    CommonModule,
    FormModule,
    MatTableModule

  ],
  exports: [CustomersListComponent]
})
export class CustomersListModule { }
