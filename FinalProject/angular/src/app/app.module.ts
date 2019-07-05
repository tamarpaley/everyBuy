import { BrowserModule } from '@angular/platform-browser';
import { NgModule,TemplateRef } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import {MatButtonModule, MatCheckboxModule, MatFormFieldModule, MatInputModule, MatIconModule,MatCardModule,MatSliderModule, MatDialogModule} from '@angular/material';
import {HttpClientModule} from '@angular/common/http';
import { BsDropdownModule } from 'ngx-bootstrap/dropdown';
import { TooltipModule } from 'ngx-bootstrap/tooltip';
import { ModalModule,BsModalService } from 'ngx-bootstrap/modal';
import { TestComponent } from './test/test.component';
import {UserComponent} from './user/user.component';
import { FormsModule,ReactiveFormsModule  } from '@angular/forms';
import { AgmCoreModule } from '@agm/core';
import { MatGoogleMapsAutocompleteModule } from '@angular-material-extensions/google-maps-autocomplete';
import { MatDatepickerModule, MatNativeDateModule } from "@angular/material";
import { RouterModule, Routes } from '@angular/router';
// import { GroupComponent } from './group/group.component';
import { CreatrGroupComponent } from './creatr-group/creatr-group.component';
import { LoginComponent } from './login/login.component';
import { MatFileUploadModule } from 'angular-material-fileupload';
import { HomeComponent } from './home/home.component';
import { ShowGroupsComponent } from './show-groups/show-groups.component';
import { CategouryComponent } from './categoury/categoury.component';
import { DetailsGroupComponent } from './details-group/details-group.component';

// import{ActivatedRoute,ParamMap } from '@angular/router';
///
// import { FileSelectDirective } from 'ng2-file-upload';
// import { FileUploadModule } from 'ng2-file-upload/ng2-file-upload';



const appRoutes: Routes = [
  { path: 'Register', component:UserComponent },
  { path: 'Login', component:LoginComponent },
  { path: 'Group', component:CreatrGroupComponent},
  { path: 'Group/:currentGroupcategory', component:CreatrGroupComponent},
 
  ];




    
 
  


@NgModule({
  declarations: [
    AppComponent,
    TestComponent,
    UserComponent,
    // GroupComponent,
    CreatrGroupComponent,
    LoginComponent,
    HomeComponent,
    ShowGroupsComponent,
    CategouryComponent,
    DetailsGroupComponent,
    
    
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MatButtonModule,
     MatCheckboxModule,
     MatFormFieldModule,
     ReactiveFormsModule,
     HttpClientModule,
     MatInputModule,
     MatIconModule,
     FormsModule,
     MatDatepickerModule,
     MatNativeDateModule,
      //FileSelectDirective,
      RouterModule.forRoot(
       appRoutes,
       { enableTracing: true },),
     BsDropdownModule.forRoot(),
     TooltipModule.forRoot(),
     ModalModule.forRoot(),
     AgmCoreModule.forRoot({
       apiKey: 'AIzaSyB6XGmiIhsaoXzLTu611HLGNL74ZEWIaSE'}),
       MatGoogleMapsAutocompleteModule.forRoot(),
       MatFileUploadModule,
      //  ActivatedRoute,
       
      MatCardModule,
      MatSliderModule,
      MatDialogModule,
     
       

       
      //  FileUploadModule,
  ],


 
  entryComponents: [DetailsGroupComponent],
  providers: [HttpClientModule,BsModalService],
  bootstrap: [AppComponent]
})
export class AppModule { }
