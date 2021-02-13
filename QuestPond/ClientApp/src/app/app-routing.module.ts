import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AdminModule } from './admin/admin.module';
import { UserModule } from './user/user.module';


const routes: Routes = [
  { path: '', redirectTo: '/admin/home', pathMatch: 'full' },
  { path: 'admin', loadChildren: () => AdminModule },
  { path: 'user', loadChildren: () => UserModule },
];

@NgModule({
  imports: [RouterModule.forRoot(routes, { useHash: true,  anchorScrolling: 'enabled',
})],
  exports: [RouterModule]
})
export class AppRoutingModule { }
