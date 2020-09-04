import { enableProdMode } from '@angular/core';
import { platformBrowserDynamic } from '@angular/platform-browser-dynamic';
//import {} from '@angular/compiler';
import {HomeModule} from './HomeApp/HomeApp.HomeModule'
import { environment } from './environments/environment';

if (environment.production) {
  enableProdMode();
}

platformBrowserDynamic().bootstrapModule(HomeModule)
  .catch(err => console.error(err));
