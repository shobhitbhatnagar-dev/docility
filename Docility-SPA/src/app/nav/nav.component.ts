import { Component, OnInit } from '@angular/core';
import { AuthService } from '../_services/auth.service';
import { AlertifyService } from '../_services/alertify.service';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css']
})
export class NavComponent implements OnInit {
model: any = {};
  constructor( private authServices: AuthService, private alert: AlertifyService) { }

  ngOnInit() {
  }

  login() {
    this.authServices.login(this.model).subscribe(next => {
      this.alert.success('Logged In Successfully');
    }, error => {
      this.alert.error(error);
    });
  }

   loggedIn() {
     const token = localStorage.getItem('token');
     return !!token;
  }

  loggedOut() {
    localStorage.removeItem('token');
    this.alert.success('logged out');
  }

}
