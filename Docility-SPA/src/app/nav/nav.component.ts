import { Component, OnInit } from '@angular/core';
import { AuthService } from '../_services/auth.service';
import { AlertifyService } from '../_services/alertify.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css']
})
export class NavComponent implements OnInit {
model: any = {};

  constructor( public authServices: AuthService, private alert: AlertifyService, private router: Router) { }

  ngOnInit() { }

  login() {
    this.authServices.login(this.model).subscribe(next => {
      this.alert.success('Logged In Successfully');
    }, error => {
      this.alert.error(error);
    }, () => {
      this.router.navigate(['/bugs']);
    });
  }

  loggedIn() {
    return this.authServices.loggedIn();
  }

  loggedOut() {
    localStorage.removeItem('token');
    this.router.navigate(['\home']);
    this.alert.success('logged out');
  }

  checkRole(role: string) {
    return this.authServices.checkRole(role);
  }

}
