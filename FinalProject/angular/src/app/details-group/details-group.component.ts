import { Component, OnInit, Inject } from '@angular/core';
import { Group } from '../creatr-group/Group';
import { MAT_DIALOG_DATA } from '@angular/material';
import { DialogData } from '../show-groups/show-groups.component';

@Component({
  selector: 'app-details-group',
  templateUrl: './details-group.component.html',
  styleUrls: ['./details-group.component.css']
})
export class DetailsGroupComponent implements OnInit {

  constructor(@Inject(MAT_DIALOG_DATA) public data:DialogData) { }

  ngOnInit() {
  }

}
