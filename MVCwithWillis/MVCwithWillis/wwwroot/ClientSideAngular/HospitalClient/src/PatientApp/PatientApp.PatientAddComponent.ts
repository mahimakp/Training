import { Component } from '@angular/core';
import {Patient, PatientProblem} from "./PatientApp.PatientAddModel";
import {HttpClient} from '@angular/common/http';
import { observable, of, Observable } from 'rxjs';
import { filter, distinct } from 'rxjs/operators';
import { TitleCasePipe } from '@angular/common';
import {RouterModule} from '@angular/router';

@Component({
  selector: 'app-root1',
  
  templateUrl: './PatientApp.PatientAdd.html',
  styleUrls: ['./PatientApp.PatientAdd.css']
})
export class AppComponent {

  title = 'HospitalClient';
  patientobj : Patient = new Patient();//represents single patient
  patientObjs :Array<Patient> = new Array<Patient>();
  constructor(public httpObj : HttpClient){

  }

  AddInMemory(){
    this.patientObjs.push(this.patientobj);
    this.patientobj = new Patient(); 
  }

  Add(){

    //this.patientsObjs send it to WebApi
    var observable = this.httpObj.post("https://localhost:44366/api/PatientApi", this.patientObjs);
    observable.subscribe(res=>this.Success(res), res=>this.Error(res));
  }

  Success(res){

    this.patientObjs = res;
   
  }
  Error(res){

    console.log(res);

  }

}
