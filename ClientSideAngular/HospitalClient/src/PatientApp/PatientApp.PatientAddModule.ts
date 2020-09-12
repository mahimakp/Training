import { BrowserModule } from '@angular/platform-browser';
import {CommonModule} from '@angular/common'
;import { NgModule } from '@angular/core';
import {FormsModule, ReactiveFormsModule} from '@angular/forms';
import { AppComponent } from './PatientApp.PatientAddComponent';
import { HttpClient, HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import {RouterModule} from '@angular/router';
import {HomeRoutes} from '../HomeApp/HomeApp.Routing';
import {PatientRoutes} from './PatientApp.Routing';
import {JwtInterceptor} from '../Security/Security.Interceptor'
import {MatTableModule} from '@angular/material/table'

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    CommonModule, 
    FormsModule, ReactiveFormsModule,
    HttpClientModule,
    RouterModule.forChild(PatientRoutes),
    MatTableModule
   
  ],
  providers: [
{
  //Injected interceptor
  provide :HTTP_INTERCEPTORS, useClass : JwtInterceptor, multi : true
}

  ],
  bootstrap: [AppComponent]
})
export class PatientAddModule { }
