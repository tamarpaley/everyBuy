import { Component, OnInit,Inject } from '@angular/core';
import { categoury } from '../categoury/categoury';
import { ApiCallingService, RequestResponse } from '../services/api-calling.service';
import { HttpClient, HttpParams } from '@angular/common/http';
import {coerceNumberProperty} from '@angular/cdk/coercion';
import { Group } from '../creatr-group/Group';
import {MatDialog, MatDialogRef, MAT_DIALOG_DATA} from '@angular/material/dialog';
import{DetailsGroupComponent}from '../details-group/details-group.component'

export interface DialogData{
  groupDetails:Group
}
@Component({
  selector: 'app-show-groups',
  templateUrl: './show-groups.component.html',
  styleUrls: ['./show-groups.component.css'],
  
})
export class ShowGroupsComponent implements OnInit {
  currentGroupcategory: number;
  categouries: any;
  hotGroups:any;
  listGroups: any;
  hide: boolean;
  constructor(private api: ApiCallingService, private http: HttpClient,public dialog: MatDialog ) {
    this.currentGroupcategory = null;
    this.hide = true;
    
  }

  ngOnInit() {
    this.api.getcategouries().subscribe(x => { this.categouries = x.Data; });
    this.api.HotGroups().subscribe(x=>{this.hotGroups=x.Data;});
    
    // this.api.getcategouries();
  }
  ChangeView(category_id: number) {
    this.hide = this.hide ? !this.hide : this.hide = this.hide;
    this.currentGroupcategory = category_id;

  }
  GetgroupsById(category_id: number) {
    // this.http.get<RequestResponse>("http://localhost:51311/api/Group/GetGroups?id_category="+category_id).subscribe(x => {
    //   this.listGroups = x.Data;
    // });
    this.api.GetgroupsById(category_id).subscribe(x=>{this.listGroups=x.Data})
  }
  OnClick(category_id: number) {
    this.ChangeView(category_id);
    this.GetgroupsById(category_id);

  }
  Details(item:Group){
    
  }
  openDialog(group:Group): void {
    const dialogRef = this.dialog.open( DetailsGroupComponent,{
      data: {

        groupDetails:group
      
      }
     
      
    });
     
   

    
  }






  autoTicks = false;
  disabled = false;
  invert = false;
  max = 100;
  min = 0;
  showTicks = false;
  step = 1;
  thumbLabel = false;
  value = 0;
  vertical = false;

  get tickInterval(): number | 'auto' {
    return this.showTicks ? (this.autoTicks ? 'auto' : this._tickInterval) : 0;
  }
  set tickInterval(value) {
    this._tickInterval = coerceNumberProperty(value);
  }
  private _tickInterval = 1;

}
