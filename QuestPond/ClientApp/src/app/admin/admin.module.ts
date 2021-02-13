import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { HomeComponent } from './home/home.component';
import { RegisterComponent } from './register/register.component';
import { LoginComponent } from './login/login.component';
import { ForgotPasswordComponent } from './forgot-password/forgot-password.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { UserSettingComponent } from './user-setting/user-setting.component';
import { SidemenuComponent } from './sidemenu/sidemenu.component';
import { SharedModule } from '../_helpers/shared.module';
import { AdminSettingComponent} from './admin-setting/admin-setting.component';
import { AdminComponent } from './admin.component';
import { AdminRoutingModule } from './admin-routing.module';


@NgModule({
  declarations: [
    AdminComponent,
    HomeComponent,
    RegisterComponent,
    LoginComponent,
    ForgotPasswordComponent,
    DashboardComponent,
    UserSettingComponent,
    SidemenuComponent,
    AdminSettingComponent,
  ],
  imports: [
    AdminRoutingModule,
    CommonModule,
    NgbModule,
    SharedModule,
  ],
  providers: [
  ]
})
export class AdminModule { }
