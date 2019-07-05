import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { User } from '../user/user';
import { JsonpCallbackContext } from '@angular/common/http/src/jsonp';
import { jsonpCallbackContext } from '@angular/common/http/src/module';
import { Login } from '../login/Login';
import { Group } from '../creatr-group/Group';
import { Observable } from 'rxjs';


export class RequestResponse {

  Result: boolean;
  Message: string;
  Data: object;

  /**
   *
   */
  constructor(result, message, data) {
    this.Result = result;
    this.Message = message;
    this.Data = data;
  }

}
@Injectable({
  providedIn: 'root'
})
export class ApiCallingService {

  constructor(private http: HttpClient) {

  }

  register(user: User): RequestResponse {

    var result: any;
    this.http.post("http://localhost:51311/api/User/Register", user).subscribe(x => console.log(x));

    return result;

  }
  Login(userData: any): RequestResponse {

    var result: any;
    this.http.post("http://localhost:51311/api/User/Login", userData).subscribe(x => console.log(x));
    return result;

  }
  CreateGroup(group: Group): RequestResponse {

    var result: any;
    this.http.post("http://localhost:51311/api/Group/createGroup", group).subscribe(x => console.log(x));

    return result;

  }
 getcategouries(): Observable<RequestResponse> {
  
  return  this.http.get<RequestResponse>("http://localhost:51311/api/Categoury/allCategouries");

  }

  GetgroupsById(category_id: number):Observable<RequestResponse> {
   return this.http.get<RequestResponse>("http://localhost:51311/api/Group/GetGroups?id_category="+category_id);
     
    
  }
  HotGroups():Observable<RequestResponse>{
    return this.http.get<RequestResponse>("http://localhost:51311/api/Group/HotGroups")
  }


}
