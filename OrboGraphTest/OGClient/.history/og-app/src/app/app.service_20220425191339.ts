import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { catchError, retry } from 'rxjs/operators';
@Injectable()
export class AppService {
xmlUrl ='http://localhost:39255/GetXml/D%3A%5C%D7%94%D7%95%D7%A8%D7%93%D7%95%D7%AA%5CFirstTest.xml';
  constructor(private http: HttpClient) {

    getXmlData():Observable<[]>{
        return this.http.get<[]]>(xmlUrl)
        .pipe(
          catchError(this.handleError<any>('getXml', []))
        );    }
  }



