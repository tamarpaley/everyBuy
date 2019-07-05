import { Component, OnInit } from '@angular/core';
import {ApiCallingService,RequestResponse} from '../services/api-calling.service'
import { Login } from './Login';
@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
private login={
  name:"",
  password:""
};
  constructor(private api:ApiCallingService) {
   }

  ngOnInit() {
  }
Login()
{
let response;
response= this.api.Login(this.login);
}
}
