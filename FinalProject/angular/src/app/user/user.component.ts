import { Component, OnInit } from '@angular/core';
import { User } from "src/app/user/user";
import {FormControl, FormGroupDirective, NgForm, Validators} from '@angular/forms';
import {ApiCallingService,RequestResponse} from '../services/api-calling.service'
import {ErrorStateMatcher} from '@angular/material/core';
import { MatGoogleMapsAutocompleteModule } from '@angular-material-extensions/google-maps-autocomplete';
// import {GoogleplaceDirective} from '../directives/googleplace.directive';
import {Observable} from 'rxjs';
import {map, startWith} from 'rxjs/operators';
@Component({
  selector: 'app-user',
  templateUrl: './user.component.html',
  styleUrls: ['./user.component.css']
})
export class UserComponent implements OnInit {

  private user:User;
  userSettings = {}
	autoCompleteCallback1(selectedData:any) {
    //do any necessery stuff.
    console.log('sss!!',selectedData);
	}
  emailValidator = new FormControl('', [Validators.required, Validators.email]);
  // userModel:{id:number,name:string,passwors:string,mail:string,phone:string,city:string,adress:string,tz:string}=
  // {id:0,name:'',passwors:'',mail:'',phone:'',adress:'',city:'',tz:''};
 
  constructor(private api:ApiCallingService) {
    this.user = new User;
   }
 
  ngOnInit() {
  }
  Register()
{
let response;
response= this.api.register(this.user);
}
}

