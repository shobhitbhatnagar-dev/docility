import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Bug } from '../_models/bug';

const httpOptions = {
  headers: new HttpHeaders({
    // tslint:disable-next-line:object-literal-key-quotes
    'Authorization': 'Bearer ' + localStorage.getItem('token')
  })
};

@Injectable({
  providedIn: 'root'
})
export class BugService {
  baseUrl = environment.apiUrl;

  constructor(private http: HttpClient) {}

  getBugs(): Observable<Bug[]> {
    return this.http.get<Bug[]>(this.baseUrl + 'bug/', httpOptions);
  }

  getBug(id): Observable<Bug> {
    return this.http.get<Bug>(this.baseUrl + 'bug/' + id, httpOptions);
  }

}
