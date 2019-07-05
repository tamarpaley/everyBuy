import { Component, OnInit } from '@angular/core';
import { Group } from './Group';
import {FormControl, FormGroupDirective, NgForm, Validators} from '@angular/forms';
import {ApiCallingService,RequestResponse} from '../services/api-calling.service'
import{ShowGroupsComponent}from '../show-groups/show-groups.component'
import { from } from 'rxjs';
import { ActivatedRoute } from '@angular/router';
// import{ActivatedRoute,ParamMap } from '@angular/router';

// import {  FileUploader, FileSelectDirective } from 'ng2-file-upload/ng2-file-upload';

// const URL = 'http://localhost:3000/api/upload';
@Component({
  selector: 'app-creatr-group',
  templateUrl: './creatr-group.component.html',
  styleUrls: ['./creatr-group.component.css']
})
export class CreatrGroupComponent implements OnInit {
private group:Group;
private categoryId:number;
public fileUploadQueue:any;
groupSettings = {}
	autoCompleteCallback1(selectedData:any) {
    //do any necessery stuff.
    console.log('sss!!',selectedData);
  }
  // public uploader: FileUploader = new FileUploader({url: URL, itemAlias: 'photo'});
  // image= new FormControl(null, [Validators.required, requiredFileType('png')])
  image= new FormControl(null, [Validators.required])
 
  constructor(private api:ApiCallingService,
     private activatedRoute: ActivatedRoute
    ) {
    
    // this.activatedRoute.queryParams.subscribe(params => {
    //  this.categoryId = params['startdate'];
            
    //       });
   }
   click(){
     console.log(this.fileUploadQueue)
   }
   CreateGroup(){
    
    let response;
    this.group.group_manager_id=1;
    this.group.is_active=true;
    // this.group.category_id=this.categoryId;
    this.group.category_id=this.categoryId;
    response= this.api.CreateGroup(this.group);
   }
  ngOnInit() {
    this.group=new Group;
    this.activatedRoute.params.subscribe(w=>this.categoryId=w["currentGroupcategory"]);
    // this.uploader.onAfterAddingFile = (file) => { file.withCredentials = false; };
    // this.uploader.onCompleteItem = (item: any, response: any, status: any, headers: any) => {
    //      console.log('ImageUpload:uploaded:', item, status, response);
    //      alert('File uploaded successfully');
    //  };
  }

}
