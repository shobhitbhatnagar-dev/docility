import { Component, OnInit } from '@angular/core';
import { User } from '../_models/user';
import { UserService } from '../_services/user.service';
import { AlertifyService } from '../_services/alertify.service';

@Component({
  selector: 'app-user',
  templateUrl: './user.component.html',
  styleUrls: ['./user.component.css']
})
export class UserComponent implements OnInit {
 users: User[];

  constructor(private userService: UserService, private alertify: AlertifyService) { }

  ngOnInit() {
    this.loadUsers();
  }

    loadUsers() {
      this.userService.getUsers().subscribe((user: User[]) => {
        this.users = user;
      }, error => {
        this.alertify.error(error);
      });
      }
    }


