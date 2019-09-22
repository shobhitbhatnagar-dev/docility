import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class ValuesService {
baseUrl = 'http://localhost:5000/api/';
constructor(private http: HttpClient) { }

getValues(type: any) {
  return this.http.get(this.baseUrl + 'values/' + type );
}
}
