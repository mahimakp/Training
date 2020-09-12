import { Component } from '@angular/core';
import {MySecurity} from '../Security/Security.Token';
import { Router } from '@angular/router';
import {User} from './HomeApp.UserModel'
import { HttpClient, HttpHeaders } from '@angular/common/http';
import {HomeRoutes} from './HomeApp.Routing'

@Component({

    templateUrl: './HomeApp.Login.html'
})

export class LoginComponent{

    userObj : User = new User();
    constructor(public mySecureObj : MySecurity, private _router : Router,
        public httpObj : HttpClient){

    }

    Login(){

        // const httpOptions = {
        //     headers: new HttpHeaders({ 'Content-Type': 'application/json' })
        //   };
        //http call to security controller
        // let hdr = {
        //     'Content-Type': 'application/json',
        //     'charset':'utf-8'
        // };
        // let options = { headers: hdr };

        const headers = new HttpHeaders().set('Content-Type', 'application/json; charset-utf-8')

        var observable = this.httpObj.post("https://localhost:44366/api/Security", JSON.stringify(this.userObj), {headers, responseType : 'text'});
        observable.subscribe(res=>this.Success(res), res=>this.Error(res));
    }

    Success(res){

        this.mySecureObj.token = res;//Api/Security
        this._router.navigate(['/Master']);
        // console.log(res);
        // console.log(this.mySecureObj.token)
       
      }
      
      Error(res){
    
        console.log(res);
    
      }
    
}

