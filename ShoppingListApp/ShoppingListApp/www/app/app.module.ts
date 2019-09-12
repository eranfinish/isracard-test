import { NgModule, ErrorHandler } from '@angular/http';
import { IonicApp, IonicModule, IonicErrorHandler } from 'ionic-angular';
import { MyApp } from '../app.component';
import { ShopListPage } from '../Pages/ShopList/ShopList';

@Component({
    templateUrl: 'app.html'
})
export class MyApp {
    rootPage = ShopListPage;

    constructor(platform: Platform) {
        platform.ready().then(() => {
            // Okay, so the platform is ready and our plugins are available.
            // Here you can do any higher level native things you might need.
            StatusBar.styleDefault();
            Splashscreen.hide();
        });
    }
}
