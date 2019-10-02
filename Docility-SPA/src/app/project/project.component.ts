import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { AlertifyService } from '../_services/alertify.service';
import { ProjectService } from '../_services/project.service';
import { Project } from '../_models/project';

@Component({
  selector: 'app-project',
  templateUrl: './project.component.html',
  styleUrls: ['./project.component.css']
})
export class ProjectComponent implements OnInit {
  projects: any;
  project: any;
  viewProject: boolean ;
  constructor(
    private http: HttpClient,
    private alert: AlertifyService,
    private projectServices: ProjectService
  ) {}

  ngOnInit() {
    this.loadProjects();
    this.viewProject = false;
  }

  loadProjects() {
    this.projectServices.getProjects().subscribe(
      (projects: Project[]) => {
        this.projects = projects;
      },
      error => {
        this.alert.error(error);
      }
    );
  }

  backToProjects() {
    this.viewProject = false;
  }

  getProject(id: number) {
    this.projectServices.getProject(id).subscribe(
      (project: Project) => {
        console.log(project);
        this.project = project;
        this.viewProject = true;
      },
      error => {
        this.alert.error(error);
      }, () => {
        if ( this.project) {
          this.viewProject = true;
        }
      }
    );
  }
}
