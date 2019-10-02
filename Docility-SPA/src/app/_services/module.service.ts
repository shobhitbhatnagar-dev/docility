import { Injectable } from '@angular/core';
import { HttpHeaders, HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';
import { Module } from '../_models/Module';

const httpOptions = {
  headers: new HttpHeaders({
    // tslint:disable-next-line:object-literal-key-quotes
    'Authorization': 'Bearer ' + localStorage.getItem('token')
  })
};
@Injectable({
  providedIn: 'root'
})
export class ModuleService {

  baseUrl = environment.apiUrl;

  constructor(private http: HttpClient) {}

  getModules(): Observable<Module[]> {
    return this.http.get<Module[]>(this.baseUrl + 'module/', httpOptions);
  }

  getProject(id): Observable<Module> {
    return this.http.get<Module>(this.baseUrl + 'module/' + id, httpOptions);
  }

}
