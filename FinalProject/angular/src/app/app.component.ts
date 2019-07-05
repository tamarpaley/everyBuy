import { Component,OnInit,TemplateRef } from '@angular/core';
import {Observable} from "rxjs";
import {HttpClient} from "@angular/common/http";
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'angular';
res:Observable<string>;
  getData(){

  }
  public modalRef: BsModalRef; // {1}
  constructor(private http:HttpClient,private modalService: BsModalService) {
  }

  ngOnInit() {
        // this.http
        // .get<string>("http://localhost:64857/values/GetData").toPromise()
        // .then(
        //   res => { // Success
        //     console.log(res);
        //   }
        // );
       
        
}

public openModal(template: TemplateRef<any>) {
  this.modalRef = this.modalService.show(template); // {3}
}
}
