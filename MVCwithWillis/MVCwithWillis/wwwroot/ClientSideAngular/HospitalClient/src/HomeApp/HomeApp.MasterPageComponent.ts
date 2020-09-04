import { Component } from '@angular/core';
import { MySecurity } from 'src/Security/Security.Token';

@Component({
  //selector: 'app-root1',
  templateUrl: './HomeApp.MasterPage.html',
  
})
export class MasterPageComponent {

  constructor(mySecureObj : MySecurity){}

}
