import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders  } from '@angular/common/http';
import { Observable } from 'rxjs';
import {City} from '../models/City';

   let headers = new HttpHeaders({
    'Content-Type': 'application/json'
 });

@Injectable()
export class TestService {
  constructor(private http: HttpClient) {

    const httpOptions = {
 	 	headers: new HttpHeaders()
	}
 httpOptions.headers.append('Access-Control-Allow-Origin', '*');


  }


 searchCities({ exp }: { exp: string; }): Observable<City[]> {
  const url = 'http://localhost:44652/api/test/los';
  return this.http.get<City[]>(url);
}
}
