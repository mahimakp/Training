import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {FormsModule} from '@angular/forms';
import { HttpClient, HttpClientModule } from '@angular/common/http';
import {HomeComponent} from './HomeApp.HomeComponent';
import{MasterPageComponent} from './HomeApp.MasterPageComponent';
import {RouterModule} from '@angular/router';
import {HomeRoutes} from './HomeApp.Routing';
import {MySecurity} from '../Security/Security.Token'
import {IndexComponent} from './HomeApp.IndexComponent'
import {LoginComponent} from './HomeApp.LoginComponent'
import { MyAuthGuard } from '../Security/Security.AuthGuard';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations'
import {MatSliderModule} from '@angular/material/slider';
import {MatTableDataSource, MatTable, MatTableModule} from '@angular/material/table'

@NgModule({
  declarations: [
    HomeComponent,
    MasterPageComponent,
    IndexComponent,
    LoginComponent

  ],
  imports: [
    BrowserModule, 
    FormsModule, 
    HttpClientModule,
    RouterModule.forRoot(HomeRoutes),
    BrowserAnimationsModule,
    MatSliderModule,
    MatTableModule
  ],
  providers: [MySecurity, MyAuthGuard],
  bootstrap: [IndexComponent]
})
export class HomeModule { }
