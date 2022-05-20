import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { catchError } from 'rxjs/operators';
import { HttpErrorHandler, HandleError } from '../app/http-error-handler.service';
import {City} from '../../../models/city.model';
@Injectable()
export class AppService {
 // xmlUrl1:string;
xmlUrl ='http://localhost:39255/GetXml/D%3A%5C%D7%94%D7%95%D7%A8%D7%93%D7%95%D7%AA%5CFirstTest.xml';
  constructor(
    private http: HttpClient,
    httpErrorHandler: HttpErrorHandler) {
       }   Observable<City[]>{
        return this.http.get(xmlUrl)
        .pipe(
          catchError(this.handleError<any>('getXml', []))
          );
       }
      }





