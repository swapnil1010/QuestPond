import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { UserComponent } from './user.component';
import { IntroComponent } from './intro/intro.component';
import { SharedModule } from '../_helpers/shared.module';
import { UserRoutingModule } from './user-routing.module';


@NgModule({
  declarations: [
    UserComponent, 
    IntroComponent, 
  ],
  imports: [
    CommonModule,
    UserRoutingModule,
    SharedModule
  ],
  providers:[]
})
export class UserModule { }
