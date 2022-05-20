import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import {City} from '../models/City'

@Injectable()
export class TestService {
  constructor(private http: HttpClient) {}

/*   searchCities(exp: string): Observable<City[]> {
    exp = exp.trim();

    // Add safe, URL encoded search parameter if there is a search term
    const options = exp ?
     { params: new HttpParams().set('name', exp) } : {};

    return this.http.get<City[]>(this.testUrl, options)
      .pipe(
        catchError(this.handleError<City[]>('searchCities', []))
      );

} */
public searchCities(exp: string): Observable<City[]> {
  const url = 'http://localhost:44652/api/test/los';
  return this.http.get<City[]>(url);
}
}
