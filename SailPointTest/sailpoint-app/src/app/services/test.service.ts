import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import {City} from '../models/City'

@Injectable()
export class TestService {
  constructor(private http: HttpClient) {}



public searchCities(exp: string): Observable<City[]> {
  const url = 'http://localhost:44652/api/test/los';
  return this.http.get<City[]>(url);
}
}
