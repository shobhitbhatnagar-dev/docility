import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {
  values: any;
  model: any = {};
  constructor(private http: HttpClient) { }

  ngOnInit() {
    this.getValues();
  }

  register() {
    console.log(this.model);
  }

  cancel() {
    console.log('cancelled');
  }
  getValues() {
    this.http.get('http://localhost:5000/api/values/1').subscribe(response => {
    this.values = response;
    console.log('register');
    console.log(this.values);
    }, error => {
      console.log(error);
    });
  }
  }


