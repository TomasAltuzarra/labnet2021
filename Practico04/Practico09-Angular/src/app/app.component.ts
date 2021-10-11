import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'Practico09-Angular';
}

class Customer {
  CustomerID: String;
  ContactName: String;
  CompanyName: String;
  City: String;
}

