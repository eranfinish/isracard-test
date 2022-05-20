import { Component , OnInit} from '@angular/core';
import {TestService} from '../app/services/test.service'
import {City} from '../app/models/City'
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit{
  title = 'sailpoint-app';
  cities = new Array<City>();
  constructor(public testService: TestService) { }

  ngOnInit(): void {
    this.testService.searchCities("zxx").subscribe(response => {
      console.log(response);
        this.cities = response;
    });
  }
}