import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { AlertifyService } from '../_services/alertify.service';

@Component({
  selector: 'app-project',
  templateUrl: './project.component.html',
  styleUrls: ['./project.component.css']
})
export class ProjectComponent implements OnInit {
projects: any;
  constructor(private http: HttpClient, private alert: AlertifyService) { }

  ngOnInit() {
    this.getProjects();
  }

  getProjects() {
    this.http.get('http://localhost:5000/api/project').subscribe(response => {
    this.projects = response;
    }, error => {
      this.alert.error(error);
    });
  }
}
