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

  constructor( public authServices: AuthService, private alert: AlertifyService) { }

  ngOnInit() { }

  login() {
    this.authServices.login(this.model).subscribe(next => {
      this.alert.success('Logged In Successfully');
    }, error => {
      this.alert.error(error);
    });
  }

  loggedIn() {
    return this.authServices.loggedIn();
  }

  loggedOut() {
    localStorage.removeItem('token');
    this.alert.success('logged out');
  }

  checkRole(role: string) {
    if ( role === this.authServices.userRole) {
      return true;
   }return false;
  }
}
