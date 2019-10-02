import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Project } from '../_models/project';

const httpOptions = {
  headers: new HttpHeaders({
    // tslint:disable-next-line:object-literal-key-quotes
    'Authorization': 'Bearer ' + localStorage.getItem('token')
  })
};

@Injectable({
  providedIn: 'root'
})
export class ProjectService {
  baseUrl = environment.apiUrl;

  constructor(private http: HttpClient) {}

  getProjects(): Observable<Project[]> {
    return this.http.get<Project[]>(this.baseUrl + 'project/', httpOptions);
  }

  getProject(id): Observable<Project> {
    return this.http.get<Project>(this.baseUrl + 'project/' + id, httpOptions);
  }

}
