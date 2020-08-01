import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AuthGuard, PermissionGuard } from '@abp/ng.core';
import { HotelComponent } from './hotel.component';
import { HoteltypeComponent } from '../hoteltype/hoteltype.component';


const routes: Routes = [
  { path: '', component: HotelComponent, canActivate: [AuthGuard, PermissionGuard] },
  { path: 'hoteltypes', component: HoteltypeComponent, canActivate: [AuthGuard, PermissionGuard] },

];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class HotelRoutingModule { }
