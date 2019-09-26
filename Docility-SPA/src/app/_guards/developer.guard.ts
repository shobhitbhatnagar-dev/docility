import { Injectable } from '@angular/core';
import { CanActivate, ActivatedRouteSnapshot, RouterStateSnapshot, UrlTree, Router } from '@angular/router';
import { Observable } from 'rxjs';
import { AuthService } from '../_services/auth.service';
import { AlertifyService } from '../_services/alertify.service';

@Injectable({
  providedIn: 'root'
})
export class DeveloperGuard implements CanActivate {
  constructor(private auth: AuthService, private router: Router, private alert: AlertifyService) {}
  canActivate(): boolean {
    if (this.auth.checkRole('dev')) {
      return true;
    }
    this.alert.error('Not Authorized to access this page');
    this.router.navigate(['']);
    return false;
  }
}
