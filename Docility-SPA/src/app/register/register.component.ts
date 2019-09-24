import { Component, OnInit } from '@angular/core';
import { AuthService } from '../_services/auth.service';
import { ValuesService } from '../_services/values.service';
import { AlertifyService } from '../_services/alertify.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {
  values: any;
  model: any = {};
  constructor(private val: ValuesService, private auth: AuthService, private alert: AlertifyService) { }

  ngOnInit() {
    this.getValues();
  }

  register() {
    console.log(this.model);
    this.auth.register(this.model).subscribe(() => {
    this.alert.success('Registration Successful');
    }, error => {
    this.alert.error(error);
    });
  }

  cancel() {
    console.log('cancelled');
  }
  getValues() {
    this.val.getValues(1).subscribe(response => {
    this.values = response;
    }, error => {
      this.alert.error(error);
    });
  }
  }


