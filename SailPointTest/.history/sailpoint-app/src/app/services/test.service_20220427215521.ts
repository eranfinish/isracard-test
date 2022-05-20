import { Injectable } from '@angular/core';
import {HttpClient, HttpParams } from '@angular/common/http';
import { HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { catchError } from 'rxjs/operators';
import { HttpErrorHandler, HandleError } from '../http-error-handler.service';
import {City} from '../models/City'
@Injectable({
  providedIn: 'root'
})
export class TestService {
  testUrl = 'http://localhost:44652/get';  // URL to web api
  private handleError: HandleError;

  constructor(
    private http: HttpClient,
    httpErrorHandler: HttpErrorHandler) {
    this.handleError = httpErrorHandler.createHandleError('TestService');
   }
   searchCities(exp: string): Observable<City[]> {
    exp = exp.trim();

    // Add safe, URL encoded search parameter if there is a search term
    const options = exp ?
     { params: new HttpParams().set('name', exp) } : {};

    return this.http.get<City[]>(this.testUrl, options)
      .pipe(
        catchError(this.handleError<City[]>('searchCities', []))
      );

}
