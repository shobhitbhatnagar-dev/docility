import { Component, OnInit } from '@angular/core';
import { AuthService } from '../_services/auth.service';
import { ValuesService } from '../_services/values.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {
  values: any;
  model: any = {};
  constructor(private val: ValuesService, private auth: AuthService) { }

  ngOnInit() {
    this.getValues();
  }

  register() {
    console.log(this.model);
    this.auth.register(this.model).subscribe(() => {
      console.log('Registration Successful');
    }, error => {
      console.log(error);
    });
  }

  cancel() {
    console.log('cancelled');
  }
  getValues() {
    this.val.getValues(1).subscribe(response => {
    this.values = response;
    }, error => {
      console.log(error);
    });
  }
  }


