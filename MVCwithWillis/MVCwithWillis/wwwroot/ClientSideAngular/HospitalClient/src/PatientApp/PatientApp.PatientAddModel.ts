import{NgForm,
        FormGroup,
            FormControl,
                Validators,
FormBuilder
}from '@angular/forms';

export class Patient{

    formgroup : FormGroup = null;
    
    name : string = "";
    address : string = "";
    email : string = "";

    constructor(){
        
        // this.name = "Mahima";
        // this.address = "Nagpur";
        // this.email = "mahimakpatel61@gmail.com";

        var _builder = new FormBuilder();
        this.formgroup = _builder.group({});

        this.formgroup.addControl("PatientNameControl",
        new FormControl('', Validators.required));

        var validationCollection = [];
        validationCollection.push(Validators.required);
        validationCollection.push(
            Validators.pattern("^[a-z]{1,10}@[a-z]{1,10}.[a-z]{1,10}$"));
        
        this.formgroup.addControl("EmailControl",
        new FormControl('',Validators.compose(validationCollection)));


    }

    problems:Array<PatientProblem> = new Array<PatientProblem>();

}

export class PatientProblem{

    id : number = 0;
    problem : string = "";
    genetic : boolean;
    
}

